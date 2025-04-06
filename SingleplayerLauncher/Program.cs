using Microsoft.Extensions.Hosting;
using SingleplayerLauncher.GameFiles;
using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace SingleplayerLauncher
{
    internal static class Program
    {
        private static IHost _apiHost;

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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            InitializeGameSettings();

            StartApiServer(); // Start the embedded REST API

            if (Settings.Instance.IsSiegeInstallation)
            {
                LoadSiegeMode();
            }
            else
            {
                LoadSurvivalMode();
            }
        }

        /// <summary>
        /// Loads and runs the game in Survival mode.
        /// </summary>
        private static void LoadSurvivalMode()
        {
            UpdateSpitfireDashboardFiles();
            Settings.Instance.Load();
            GameConfig.Instance.Load();
            SurvivalLoadouts.Instance.Load();

            Application.Run(new LauncherMainForm());
        }

        /// <summary>
        /// Loads and runs the game in Siege mode.
        /// </summary>
        private static void LoadSiegeMode()
        {
            Settings.Instance.Load();
            GameConfig.Instance.Load();
            SiegeLoadouts.Instance.Load();

            Application.Run(new LauncherMainForm());
        }

        /// <summary>
        /// Updates the Spitfire Dashboard if necessary.
        /// </summary>
        private static void UpdateSpitfireDashboardFiles()
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

            FileInfo spitfireDashboardExeFileInfo = new(dashboardExePath);
            FileInfo launcherExeFileInfo = new(launcherExePath);

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
        }

        /// <summary>
        /// Initializes game settings and configurations.
        /// </summary>
        private static void InitializeGameSettings()
        {
            string rootFolder = FileUtils.FindRootFolder();
            Settings.Instance.RootGamePath = rootFolder;

            string launcherInstallationPath = FileUtils.GetLauncherInstallationPath(rootFolder);
            Settings.Instance.LauncherInstallationPath = launcherInstallationPath;

            Settings.Instance.IsSiegeInstallation = DetectSiegeInstallation();

            MoveLegacyConfigFiles(rootFolder);
        }

        /// <summary>
        /// Detects if the game is a Siege installation based on UPK file size.
        /// </summary>
        private static bool DetectSiegeInstallation()
        {
            /* TODO: Add proper checking for game versions
            else
            {
                if (new FileInfo(spitfireGameUPK).Length != FileUtils.SPITFIREGAME_UPK_ORG_SIZE)
                {
                    MessageBox.Show("The SpitfireGame UPK file is not the expected size. Please verify the integrity of the game files.");
                }
            }
            */
            string upksFolderPath = Path.Combine(Settings.Instance.RootGamePath, FileUtils.UPKS_PATH);
            string spitfireGameUPK = Path.Combine(upksFolderPath, FileUtils.SPITFIREGAME_UPK_FILENAME);

            return File.Exists(spitfireGameUPK) &&
                   new FileInfo(spitfireGameUPK).Length == FileUtils.SPITFIREGAME_SIEGE_UPK_ORG_SIZE;
        }

        /// <summary>
        /// Moves legacy config files to the appropriate launcher installation path.
        /// </summary>
        private static void MoveLegacyConfigFiles(string rootFolder)
        {
            string[] filesToMove =
            {
                Settings.SETTINGS_FILE_NAME,
                GameConfig.GAME_CONFIG_FILE_NAME,
                SurvivalLoadouts.Instance.FileName
            };

            string configPath = Path.Combine(Settings.Instance.LauncherInstallationPath, FileUtils.CONFIG_FOLDER_NAME);
            foreach (string file in filesToMove)
            {
                string oldPath = Path.Combine(rootFolder, FileUtils.BINARIES_FOLDER_NAME, file);
                string newPath = Path.Combine(configPath, file);

                if (File.Exists(oldPath))
                {
                    File.Move(oldPath, newPath, true);
                }
            }
        }

        /// <summary>
        /// Starts an embedded ASP.NET Core Web API server.
        /// </summary>
        private static async void StartApiServer()
        {
            _apiHost = Host.CreateDefaultBuilder()
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseKestrel()
                              .UseUrls("http://localhost:5001") // Set desired API port
                              .ConfigureServices(services =>
                              {
                                  services.AddControllers();
                                  services.AddCors(options =>
                                  {
                                      options.AddPolicy("AllowAllOrigins",
                                          builder => builder.AllowAnyOrigin()
                                                            .AllowAnyMethod()
                                                            .AllowAnyHeader());
                                  });
                              })
                              .Configure(app =>
                              {
                                  app.UseRouting();
                                  app.UseCors("AllowAllOrigins"); // Apply CORS globally
                                  app.UseEndpoints(endpoints => endpoints.MapControllers());
                              });
                })
                .Build();

            await _apiHost.StartAsync();
        }
    }
}
