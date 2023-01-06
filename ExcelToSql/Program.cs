using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelToSql
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
            Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            var ex = ExceptionHandler.GetMessages(e.Exception);
            MessageBox.Show(ex, Application.ProductName);
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            var ex = ExceptionHandler.GetMessages((Exception)e.ExceptionObject);
            MessageBox.Show(ex, Application.ProductName);
        }
    }
    /// <summary>
    /// Handles exception detailing
    /// </summary>
    public class ExceptionHandler
    {
        /// <summary>
        /// The current exception thrown
        /// </summary>
        public static Exception Error;

        /// <summary>
        /// [Recursive] - Get all the exception information even inner exceptions
        /// </summary>
        /// <param name="ex">The exception to extract</param>
        /// <param name="currentMessage">This will contain all extracted exceptions on the loop</param>
        /// <param name="inner"></param>
        /// <returns>The complete information about the exception</returns>
        public static string GetMessages(Exception ex, string currentMessage = "", string inner = "")
        {
            if (ex == null)
                return currentMessage;
            currentMessage = currentMessage + ex.Message + Environment.NewLine;
            if (ex.InnerException == null) return currentMessage.Trim();
            inner += GetMessages(ex.InnerException);
            if (!currentMessage.Contains(inner.Trim()))
                currentMessage += inner;
            return currentMessage.Trim();
        }
    }
}
