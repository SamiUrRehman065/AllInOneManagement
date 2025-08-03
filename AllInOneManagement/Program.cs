using System.Runtime.InteropServices;

namespace FactoryManagementSystem
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            SetProcessDpiAwareness();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetHighDpiMode(HighDpiMode.SystemAware); // Add this line
            ApplicationConfiguration.Initialize();
            Guna.UI2.WinForms.Guna2LicenseManager.LicenseKey = "FakeKey";


            Application.Run(new Login());

        }

        private static void SetProcessDpiAwareness()
        {
            if (Environment.OSVersion.Version.Major >= 6) // Windows Vista or later
            {
                SetProcessDpiAwareness(2); // 2 = Per Monitor DPI Aware
            }
        }

        //[DllImport("user32.dll")]
        [DllImport("shcore.dll")]
        private static extern int SetProcessDpiAwareness(int awareness);
    }
}