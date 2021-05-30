using System;
using System.Windows.Forms;

namespace FileManager
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FileManagerForm form = new FileManagerForm();
            Application.Run(form);
        }
    }
}
