using SingleplayerLauncher.GameFiles;
using System;
using System.Diagnostics;
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

            // SpitfireDashboard Initialization
            string dashboardFolderPath = Path.Combine(Settings.Instance.RootGamePath, FileUtils.DASHBOARD_FOLDER_PATH);
            string dllPath = Path.Combine(Settings.Instance.LauncherInstallationPath, "Newtonsoft.Json.dll");
            string targetDllPath = Path.Combine(dashboardFolderPath, "Newtonsoft.Json.dll");

            // Check and copy DLL if it doesn't exist or the size has changed
            if (!File.Exists(targetDllPath) || new FileInfo(dllPath).Length != new FileInfo(targetDllPath).Length)
            {
                FileUtils.CopyFileWithCheck(dllPath, targetDllPath, true);
            }

            string launcherExePath = Path.Combine(Settings.Instance.LauncherInstallationPath, FileUtils.PROJECT_RECHAINED_LAUNCHER_EXE_FILE_NAME);
            string dashboardExePath = Path.Combine(dashboardFolderPath, FileUtils.SPITFIREDASHBOARD_EXE_FILENAME);

            FileInfo spitfireDashboardExeFileInfo = new FileInfo(dashboardExePath);
            FileInfo launcherExeFileInfo = new FileInfo(launcherExePath);

            bool isUpdateRequired = spitfireDashboardExeFileInfo.LastWriteTime != launcherExeFileInfo.LastWriteTime;
            bool isExecutingFromDashboardFolder = Directory.GetCurrentDirectory().Equals(dashboardFolderPath, StringComparison.OrdinalIgnoreCase);

            if (!File.Exists(dashboardExePath) || (!isExecutingFromDashboardFolder && isUpdateRequired))
            {
                FileUtils.CopyFileWithCheck(launcherExePath, dashboardExePath, File.Exists(dashboardExePath));
            }

            string tempExePath = Path.Combine(dashboardFolderPath, "temp_" + FileUtils.SPITFIREDASHBOARD_EXE_FILENAME);

            if (File.Exists(tempExePath))
            {
                File.Delete(tempExePath);
            }

            if (isExecutingFromDashboardFolder && isUpdateRequired)
            {
                MessageBox.Show("The application will now apply the new update.");
                try { 
                    // Rename the current executable to a temporary name
                    File.Move(dashboardExePath, tempExePath);

                    // Copy the new executable to the original target name
                    FileUtils.CopyFileWithCheck(launcherExePath, dashboardExePath);

                    MessageBox.Show("The application has been updated. Please restart the application.");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error updating Launcher when running from Steam. Try running it from the Rechained Folder. Error: " + e.Message);
                }
                Application.Exit();
            }
            else
            {
                Settings.Instance.Load();
                GameConfig.Instance.Load();
                Loadouts.Instance.Load();

                Application.Run(new LauncherMainForm());
            }

            ////Application.Run(new MainForm());
            ///


            // Cleanup
            ////Cef.Shutdown();
        }
    }
}
