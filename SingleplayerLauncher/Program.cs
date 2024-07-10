using SingleplayerLauncher.GameFiles;
using System;
using System.IO;
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


            string rootFolder = FileUtils.FindRootFolder();
            Settings.Instance.RootGamePath = rootFolder;

            string launcherInstallationPath = FileUtils.GetLauncherInstallationPath(rootFolder);
            Settings.Instance.LauncherInstallationPath = launcherInstallationPath;


            // TODO: remove at later release
            string settingsFile = Path.Combine(rootFolder, FileUtils.BINARIES_FOLDER_NAME, Settings.SETTINGS_FILE_NAME);
            string gameConfigFile = Path.Combine(rootFolder, FileUtils.BINARIES_FOLDER_NAME, GameConfig.GAME_CONFIG_FILE_NAME);
            string loadoutsFile = Path.Combine(rootFolder, FileUtils.BINARIES_FOLDER_NAME, Loadouts.LOADOUTS_FILE_NAME);
            if (File.Exists(settingsFile))
            {
                string newSettingsFile = Path.Combine(Settings.Instance.LauncherInstallationPath, FileUtils.CONFIG_FOLDER_NAME, Settings.SETTINGS_FILE_NAME);
                File.Move(settingsFile, newSettingsFile);
            }
            if (File.Exists(gameConfigFile))
            {
                string newGameConfigFile = Path.Combine(Settings.Instance.LauncherInstallationPath, FileUtils.CONFIG_FOLDER_NAME, GameConfig.GAME_CONFIG_FILE_NAME);
                File.Move(gameConfigFile, newGameConfigFile);
            }
            if (File.Exists(loadoutsFile))
            {
                string newLoadoutsFile = Path.Combine(Settings.Instance.LauncherInstallationPath, FileUtils.CONFIG_FOLDER_NAME, Loadouts.LOADOUTS_FILE_NAME);
                File.Move(loadoutsFile, newLoadoutsFile);
            }

            Settings.Instance.Load();
            GameConfig.Instance.Load();
            Loadouts.Instance.Load();

            Application.Run(new LauncherMainForm());
            ////Application.Run(new MainForm());


            // Cleanup
            ////Cef.Shutdown();
        }
    }
}
