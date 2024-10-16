using System;
using System.Windows.Forms;

namespace WinFormsApp3
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Kh?i t?o c?u hình ?ng d?ng
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
