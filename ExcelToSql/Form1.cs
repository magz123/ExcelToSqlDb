using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ExcelToSql
{
    public partial class Form1 : Form
    {
        public SynchronizationContext Context { get; set; }
        public Form1()
        {
            InitializeComponent();
            Context = SynchronizationContext.Current;
        }
        private static void CheckInputs(Control parent)
        {
            var list = new List<object>();
            foreach (Control control in parent.Controls)
            {
                switch (control)
                {
                    case TextBox _:
                        if (string.IsNullOrEmpty(control.Text))
                        {
                            list.Add(control);
                        }
                        break;
                }
            }

            if (list.Count <= 0)
            {
                return;
            } (list.FirstOrDefault() as TextBox)?.Focus();
            throw new Exception("All field is required!");
        }
        private void ToggleControls(bool enable)
        {
            foreach (Control control in Controls)
            {
                switch (control)
                {
                    case Button _:
                    case TextBox _:
                    case TabControl _:
                    case TabPage _:
                        control.Enabled = enable;
                        break;
                }
            }
            Cursor = enable ? Cursors.Default : Cursors.WaitCursor;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CheckInputs(((Control)sender).Parent);
            ToggleControls(false);
            var builder = new StringBuilder();
            Task.Factory.StartNew(async () =>
            {
                try
                {
                    var connectionString = $"Data Source={txtServer.Text}; Initial Catalog={txtDatabase.Text};User Id={txtUserId.Text};Password={txtPassword.Text};";
                    using (var conn = new SqlConnection(connectionString))
                    {
                        await conn.OpenAsync();
                    }
                    var filePath = Path.Combine(folder.Text, $"{file.Text}.{extension.Text}");
                    if (!File.Exists(filePath))
                        throw new Exception("File not found");
                    using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    {
                        using (var reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            var result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                                {
                                    UseHeaderRow = true
                                }
                            });
                            using (var conn = new SqlConnection(connectionString))
                            {
                                await conn.OpenAsync();
                                var tableName = $"[{schema.Text}].[{table.Text}]";
                                if (truncateTable.Checked)
                                    using (SqlCommand cmd = new SqlCommand($"TRUNCATE TABLE {tableName}", conn))
                                    {
                                        cmd.CommandType = CommandType.Text;
                                        cmd.ExecuteNonQuery();
                                    }
                                using (SqlBulkCopy bulkCopy = new SqlBulkCopy(conn))
                                {
                                    bulkCopy.DestinationTableName = tableName;
                                    await bulkCopy.WriteToServerAsync(result.Tables[0]);
                                    builder.Append("IMPORT COMPLETED");
                                }
                            }
                        }
                    }
                }
                catch (Exception exception)
                {
                    builder.Append(ExceptionHandler.GetMessages(exception));
                }
                Context.Post(_ =>
                {
                    Activate();
                    ToggleControls(true);
                    throw new Exception(builder.ToString());
                }, null);
            }, TaskCreationOptions.LongRunning);
        }

        void FileSameAsTable(object sender)
        {
            var tbox = (TextBox)sender;
            if (fileSameAsTable.Checked)
                table.Text = tbox.Text;
        }

        private void file_TextChanged(object sender, EventArgs e)
        {
            FileSameAsTable(sender);
        }

        private void fileSameAsTable_CheckedChanged(object sender, EventArgs e)
        {
            var obj = (CheckBox)sender;
            if (obj.Checked)
                FileSameAsTable(file);
            else table.Text = string.Empty;
        }
    }
}
