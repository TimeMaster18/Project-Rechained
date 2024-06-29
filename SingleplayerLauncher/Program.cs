using System;
using System.Windows.Forms;
//using CefSharp;
//using CefSharp.WinForms;

namespace SingleplayerLauncher
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            //var settings = new CefSettings() { CachePath = System.IO.Path.GetFullPath() + "Cache" };
            //Cef.Initialize(settings);

            ////Cef.Initialize(new CefSettings());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LauncherMainForm());
            ////Application.Run(new MainForm());


            // Cleanup
            ////Cef.Shutdown();
        }
    }
}
