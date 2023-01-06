namespace ExcelToSql
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.folder = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.table = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.truncateTable = new System.Windows.Forms.CheckBox();
            this.schema = new System.Windows.Forms.TextBox();
            this.file = new System.Windows.Forms.TextBox();
            this.extension = new System.Windows.Forms.TextBox();
            this.fileSameAsTable = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(12, 31);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(216, 20);
            this.txtServer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Server";
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(12, 70);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(216, 20);
            this.txtUserId.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "User";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(12, 109);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(216, 20);
            this.txtPassword.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Database";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(12, 148);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(216, 20);
            this.txtDatabase.TabIndex = 8;
            // 
            // folder
            // 
            this.folder.Location = new System.Drawing.Point(12, 187);
            this.folder.Name = "folder";
            this.folder.Size = new System.Drawing.Size(79, 20);
            this.folder.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "File Location";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Schema";
            // 
            // table
            // 
            this.table.Location = new System.Drawing.Point(96, 249);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(132, 20);
            this.table.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 46);
            this.button1.TabIndex = 13;
            this.button1.Text = "EXPORT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // truncateTable
            // 
            this.truncateTable.AutoSize = true;
            this.truncateTable.Checked = true;
            this.truncateTable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.truncateTable.Location = new System.Drawing.Point(12, 275);
            this.truncateTable.Name = "truncateTable";
            this.truncateTable.Size = new System.Drawing.Size(165, 17);
            this.truncateTable.TabIndex = 14;
            this.truncateTable.Text = "Truncate table before import?";
            this.truncateTable.UseVisualStyleBackColor = true;
            // 
            // schema
            // 
            this.schema.Location = new System.Drawing.Point(12, 249);
            this.schema.Name = "schema";
            this.schema.Size = new System.Drawing.Size(79, 20);
            this.schema.TabIndex = 15;
            // 
            // file
            // 
            this.file.Location = new System.Drawing.Point(97, 187);
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(79, 20);
            this.file.TabIndex = 16;
            this.file.TextChanged += new System.EventHandler(this.file_TextChanged);
            // 
            // extension
            // 
            this.extension.Location = new System.Drawing.Point(182, 187);
            this.extension.Name = "extension";
            this.extension.Size = new System.Drawing.Size(46, 20);
            this.extension.TabIndex = 17;
            this.extension.Text = "xlsx";
            // 
            // fileSameAsTable
            // 
            this.fileSameAsTable.AutoSize = true;
            this.fileSameAsTable.Checked = true;
            this.fileSameAsTable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fileSameAsTable.Location = new System.Drawing.Point(12, 213);
            this.fileSameAsTable.Name = "fileSameAsTable";
            this.fileSameAsTable.Size = new System.Drawing.Size(200, 17);
            this.fileSameAsTable.TabIndex = 18;
            this.fileSameAsTable.Text = "Is file name the same as table name?";
            this.fileSameAsTable.UseVisualStyleBackColor = true;
            this.fileSameAsTable.CheckedChanged += new System.EventHandler(this.fileSameAsTable_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(94, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "FileName";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(180, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Extension";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(93, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "TableName";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 360);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.fileSameAsTable);
            this.Controls.Add(this.extension);
            this.Controls.Add(this.file);
            this.Controls.Add(this.schema);
            this.Controls.Add(this.truncateTable);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.table);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.folder);
            this.Controls.Add(this.txtDatabase);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtServer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMPORT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.TextBox folder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox table;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox truncateTable;
        private System.Windows.Forms.TextBox schema;
        private System.Windows.Forms.TextBox file;
        private System.Windows.Forms.TextBox extension;
        private System.Windows.Forms.CheckBox fileSameAsTable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

