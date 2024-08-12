using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SingleplayerLauncher.GameFiles
{
    public static class FileUtils
    {
        public const string PROJECT_RECHAINED_FOLDER_NAME = "ProjectRechained";
        public const string PROJECT_RECHAINED_LAUNCHER_EXE_FILE_NAME = "ProjectRechainedLauncher.exe";

        private const string BACKUP_FOLDER_NAME = "Backups";
        public const string MOD_HOOKS_FOLDER_NAME = "Hooks";
        public const string CONFIG_FOLDER_NAME = "Config";

        public const string INI_CONFIGS_FOLDER_RELATIVE_PATH = "./SpitfireGame/Config/";
        public const string INI_CHARACTER_DATA_FILENAME = "DefaultCharacterData.ini";
        public const string INI_DEFAULT_GAME_FILENAME = "DefaultGame.ini";

        public const string UPKS_PATH = "./SpitfireGame/CookedPCConsole/";
        public const string SPITFIREGAME_UPK_FILENAME = "SpitfireGame.upk";
        public const int SPITFIREGAME_UPK_ORG_SIZE = 100225213;
        public const int SPITFIREGAME_SIEGE_UPK_ORG_SIZE = 194276902;

        public const string DASHBOARD_FOLDER_PATH = "Dashboard\\Bin";
        public const string SPITFIREDASHBOARD_EXE_FILENAME = "SpitfireDashboard.exe";
        public const int SPITFIREDASHBOARD_EXE_ORG_SIZE = 16801792;

        public const string SPITFIREGAME_EXE_FILENAME = "SpitfireGame.exe";
        public const string BINARIES_FOLDER_NAME = "Binaries";
        public const string SPITFIREGAME_BINARIES_WIN32_PATH = "./" + BINARIES_FOLDER_NAME + "/Win32/";
        public const string SPITFIREGAME_BINARIES_WIN64_PATH = "./" + BINARIES_FOLDER_NAME + "/Win64/";

        public const string P2P_HOOK_FILENAME = "project_rechained_hook.dll";
        public const string P2P_HOOK_SIEGE_FILENAME = "project_rechained_siege_hook.dll";
        public const string P2P_HOOK_TARGET_FILENAME = "x3daudio1_7.dll";

        public const string UE_EXTRACTOR_FOLDER_NAME = "UE Extractor";
        private const string DECOMPRESSED_UPK_FOLDER_PATH = "./" + UE_EXTRACTOR_FOLDER_NAME + "/unpacked/";
        private const string DECOMPRESS_EXE_FILENAME = "decompress.exe";


        /// <summary>
        /// Creates a backup of the specified file.
        /// </summary>
        /// <param name="fileName">The name of the file to backup.</param>
        /// <param name="filePath">The path of the file to backup.</param>
        /// <remarks>
        /// This method checks if the backup folder exists, creates it if it does not,
        /// and then copies the file to the backup folder. If the file already exists in
        /// the backup folder, the method does nothing. Various exceptions are caught
        /// and shown to the user in message boxes.
        /// </remarks>
        public static void CreateBackup(string fileName, string filePath)
        {
            try
            {
                string rootPath = Settings.Instance.RootGamePath;
                string backupFolderPath = Path.Combine(Settings.Instance.LauncherInstallationPath, BACKUP_FOLDER_NAME);
                // Check and create backup folder if it doesn't exist
                if (!Directory.Exists(backupFolderPath))
                {
                    try
                    {
                        Directory.CreateDirectory(backupFolderPath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: Backup folder '{BACKUP_FOLDER_NAME}' could not be created. {ex.Message}", "Backup Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw ex;
                    }
                }

                // Check if the backup file already exists
                string backupFilePath = Path.Combine(backupFolderPath, fileName);
                if (!File.Exists(backupFilePath))
                {
                    try
                    {
                        CopyFileWithCheck(filePath, backupFilePath);
                    }
                    catch (FileNotFoundException ex)
                    {
                        MessageBox.Show($"Error: Source file '{filePath}' not found. {ex.Message}", "Backup Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw ex;
                    }
                    catch (UnauthorizedAccessException ex)
                    {
                        MessageBox.Show($"Error: Permission denied while accessing '{filePath}'. {ex.Message}", "Backup Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw ex;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: Backup file '{backupFilePath}' could not be copied. {ex.Message}", "Backup Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw ex;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Backup Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
        }

        /// <summary>
        /// Decompresses the specified UPK file if it has not already been decompressed.
        /// </summary>
        /// <param name="upkFileName">The name of the UPK file to decompress.</param>
        /// <param name="upkFileOriginalSize">The original size of the UPK file.</param>
        /// <remarks>
        /// This method checks if the UPK file needs decompression by comparing its size to the original size.
        /// If decompression is needed, it creates a backup of the file, copies it to a specified location,
        /// and runs a decompression process. Various exceptions are caught and shown to the user in message boxes.
        /// </remarks>
        public static void DecompressUPKFile(string upkFileName, int upkFileOriginalSize)
        {
            try
            {
                string rootPath = Settings.Instance.RootGamePath;
                string upkFilePath = Path.Combine(rootPath, UPKS_PATH, upkFileName);
                FileInfo spitfireGameUPKFileInfo = new FileInfo(upkFilePath);
                if (spitfireGameUPKFileInfo.Length > upkFileOriginalSize)
                {
                    return; // Already decompressed (hopefully)
                }

                FileUtils.CreateBackup(upkFileName, upkFilePath);

                string fileToDecompressPath = Path.Combine(Settings.Instance.LauncherInstallationPath, UE_EXTRACTOR_FOLDER_NAME, upkFileName);
                if (!File.Exists(fileToDecompressPath))
                {
                    try
                    {
                        CopyFileWithCheck(Path.Combine(Settings.Instance.LauncherInstallationPath, BACKUP_FOLDER_NAME, upkFileName), fileToDecompressPath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: Could not copy backup file '{upkFileName}' to decompress path. {ex.Message}", "Decompress Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Environment.Exit(0);
                    }
                }

                string decompressExePath = Path.Combine(Settings.Instance.LauncherInstallationPath, UE_EXTRACTOR_FOLDER_NAME, DECOMPRESS_EXE_FILENAME);
                try
                {
                    // Decompress
                    ProcessStartInfo psi = new ProcessStartInfo
                    {
                        FileName = Path.GetFileName(decompressExePath),
                        WorkingDirectory = Path.GetDirectoryName(decompressExePath),
                        Arguments = $"\"{Path.GetFileName(fileToDecompressPath)}\""
                    };
                    Process process = Process.Start(psi);
                    process.WaitForExit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: Decompression process was not successful. {ex.Message}", "Decompress Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(0);
                }

                string fileDecompressedPath = Path.Combine(Settings.Instance.LauncherInstallationPath, DECOMPRESSED_UPK_FOLDER_PATH, upkFileName);
                // Check if the decompressed file exists
                if (!File.Exists(fileDecompressedPath))
                {
                    MessageBox.Show($"Error: Decompressed file '{fileDecompressedPath}' does not exist.", "Decompress Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(0);
                }

                try
                {
                    if (File.Exists(upkFilePath))
                    {
                        File.Delete(upkFilePath);
                    }
                    else
                    {
                        MessageBox.Show($"Info: Original file '{upkFilePath}' does not exist.", "Decompress Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: Could not delete original file '{upkFilePath}'. {ex.Message}", "Decompress Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(0);
                }

                try
                {
                    File.Move(fileDecompressedPath, upkFilePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: Could not move decompressed file to '{upkFilePath}'. {ex.Message}", "Decompress Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Decompress Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }



        /// <summary>
        /// Rounds a given number to the nearest lower thousand, with a pessimistic adjustment to ensure robustness
        /// in case the file size changes.
        /// </summary>
        /// <param name="n">The number to round.</param>
        /// <returns>The rounded number.</returns>
        public static int RoundToNearestLowerThousandPessimistic(int n)
        {
            int result = n - 500;
            if (result <= 0)
            {
                return 0;
            }

            return (result / 1000) * 1000;
        }

        public static void CopyFileWithCheck(string sourcePath, string destinationPath, bool overwrite = false)
        {
            try
            {
                if (File.Exists(destinationPath))
                {
                    if (overwrite)
                    {
                        File.Copy(sourcePath, destinationPath, true);
                    }
                }
                else
                {
                    File.Copy(sourcePath, destinationPath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred while copying the file {sourcePath}: {ex.Message}", "Copy File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }

        public static string FindRootFolder()
        {
            string[] requiredFolders = new[] { "Binaries", "Dashboard", "Engine", "SpitfireGame" };
            string currentDirectory = Directory.GetCurrentDirectory();

            while (!string.IsNullOrEmpty(currentDirectory))
            {
                if (requiredFolders.All(folder => Directory.Exists(Path.Combine(currentDirectory, folder))))
                {
                    return currentDirectory;
                }

                DirectoryInfo parentDirectory = Directory.GetParent(currentDirectory);
                if (parentDirectory == null)
                {
                    break;
                }
                currentDirectory = parentDirectory.FullName;
            }

            MessageBox.Show($"An unexpected error occurred: Root folder not found. Check that the Launcher was installed in the Game Root folder.", "Initialization", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Environment.Exit(0);

            return null;
        }

        /// <summary>
        /// Searches for the launcher installation path by checking the current directory first and then recursively
        /// searching from the specified root path up to 5 levels deep for a directory containing all required folders.
        /// </summary>
        /// <param name="rootPath">The root path to start the search from if the current directory does not contain the required folders.</param>
        /// <returns>The path to the launcher installation if found, otherwise null.</returns>
        public static string GetLauncherInstallationPath(string rootPath)
        {
            string[] requiredFolders = new[] { "Backups", "Config", "Hooks", "UE Extractor" };

            /// <summary>
            /// Helper function to check if the directory contains all required folders.
            /// </summary>
            /// <param name="path">The path to check.</param>
            /// <returns>True if all required folders are present, otherwise false.</returns>
            bool ContainsRequiredFolders(string path) =>
                requiredFolders.All(folder => Directory.Exists(Path.Combine(path, folder)));

            // Check current directory
            try
            {
                string currentDirectory = Directory.GetCurrentDirectory();
                if (ContainsRequiredFolders(currentDirectory))
                {
                    return currentDirectory;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred getting the current directory: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return null; // This line will never be reached, but is required to compile.
            }

            /// <summary>
            /// Recursively searches directories for the required folders up to the specified depth.
            /// </summary>
            /// <param name="path">The current path to search.</param>
            /// <param name="depth">The current depth of the search.</param>
            /// <returns>The path to the launcher installation if found, otherwise null.</returns>
            string SearchDirectory(string path, int depth)
            {
                if (depth > 5)
                {
                    return null;
                }

                if (ContainsRequiredFolders(path))
                {
                    return path;
                }

                foreach (string subDir in Directory.GetDirectories(path))
                {
                    string result = SearchDirectory(subDir, depth + 1);
                    if (result != null)
                    {
                        return result;
                    }
                }

                return null;
            }

            // Search from root path
            try
            {
                return SearchDirectory(rootPath, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred searching the directory: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return null; // This line will never be reached, but is required to compile.
            }
        }

        public static void ApplyHook(string hookFileName, string hookTargetFileName, string hookTargetFolder)
        {
            string hookSourceFilePath = Path.Combine(Settings.Instance.LauncherInstallationPath, MOD_HOOKS_FOLDER_NAME, hookFileName);
            string hookTargetFilePath = Path.Combine(hookTargetFolder, hookTargetFileName);
            FileUtils.CopyFileWithCheck(hookSourceFilePath, hookTargetFilePath, overwrite: true);
        }
    }
}
