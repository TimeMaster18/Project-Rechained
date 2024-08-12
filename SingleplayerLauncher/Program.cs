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
            /* TODO: Add folder picker for survival and siege game installation paths
            var dlg = new FolderPicker();
            dlg.InputPath = @"c:\windows\system32";
            if (dlg.ShowDialog(IntPtr.Zero) == true)
            {
                MessageBox.Show(dlg.ResultPath);
            }
            */
            //var settings = new CefSettings() { CachePath = System.IO.Path.GetFullPath() + "Cache" };
            //Cef.Initialize(settings);

            ////Cef.Initialize(new CefSettings());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            string rootFolder = FileUtils.FindRootFolder();
            Settings.Instance.RootGamePath = rootFolder;

            string launcherInstallationPath = FileUtils.GetLauncherInstallationPath(rootFolder);
            Settings.Instance.LauncherInstallationPath = launcherInstallationPath;

            bool isSiegeInstallation = false;
            string UPKsFolderPath = Path.Combine(Settings.Instance.RootGamePath, FileUtils.UPKS_PATH);
            string spitfireGameUPK = Path.Combine(UPKsFolderPath, FileUtils.SPITFIREGAME_UPK_FILENAME);
            if (new FileInfo(spitfireGameUPK).Length == FileUtils.SPITFIREGAME_SIEGE_UPK_ORG_SIZE)
            {
                // Assuming that the file in the Siege version is never extracted
                isSiegeInstallation = true;
            }
            /* TODO: Add proper checking for game versions
            else
            {
                if (new FileInfo(spitfireGameUPK).Length != FileUtils.SPITFIREGAME_UPK_ORG_SIZE)
                {
                    MessageBox.Show("The SpitfireGame UPK file is not the expected size. Please verify the integrity of the game files.");
                }
            }
            */

            Settings.Instance.IsSiegeInstallation = isSiegeInstallation;


            // TODO: remove at later release
            var survivalLoadouts = SurvivalLoadouts.Instance;
            string settingsFile = Path.Combine(rootFolder, FileUtils.BINARIES_FOLDER_NAME, Settings.SETTINGS_FILE_NAME);
            string gameConfigFile = Path.Combine(rootFolder, FileUtils.BINARIES_FOLDER_NAME, GameConfig.GAME_CONFIG_FILE_NAME);
            string loadoutsFile = Path.Combine(rootFolder, FileUtils.BINARIES_FOLDER_NAME, survivalLoadouts.FileName);
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
                string newLoadoutsFile = Path.Combine(Settings.Instance.LauncherInstallationPath, FileUtils.CONFIG_FOLDER_NAME, survivalLoadouts.FileName);
                File.Move(loadoutsFile, newLoadoutsFile);
            }

            if (!isSiegeInstallation)
            {
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
                    try
                    {
                        // Rename the current executable to a temporary name
                        File.Move(dashboardExePath, tempExePath);

                        // Copy the new executable to the original target name
                        FileUtils.CopyFileWithCheck(launcherExePath, dashboardExePath);

                        MessageBox.Show("The application has been updated. Please restart the application.");
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Error updating Launcher when running from Steam. Try running it from the Project Rechained Folder. Error: " + e.Message);
                    }
                    Application.Exit();
                }
                else
                {

                    Settings.Instance.Load();
                    GameConfig.Instance.Load();
                    SurvivalLoadouts.Instance.Load();

                    Application.Run(new LauncherMainForm());
                }
            }
            else
            {
                Settings.Instance.Load();
                GameConfig.Instance.Load();
                SiegeLoadouts.Instance.Load();

                Application.Run(new LauncherMainForm());
            }


            ////Application.Run(new MainForm());
            ///

            // Cleanup
            ////Cef.Shutdown();
        }
    }
}
