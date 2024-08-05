using SingleplayerLauncher.Model;
using SingleplayerLauncher.GameFiles;
using System.Diagnostics;
using System.IO;
using System;
using System.Windows.Forms;

namespace SingleplayerLauncher
{
    class GameLauncher
    {
        private static readonly GameInfo GameInfo = GameInfo.Instance;
        private static readonly SpitfireGameUPK SpitfireGameUPK = new SpitfireGameUPK();

        public static void ApplyChanges(bool isHost, bool isSiege = false)
        {
            if (!isSiege)
            {
                SpitfireGameUPK.SpitfireGameUPKFile = new UPKFile(Path.Combine(Settings.Instance.RootGamePath, FileUtils.UPKS_PATH, FileUtils.SPITFIREGAME_UPK_FILENAME));
                SpitfireGameUPK.ApplyMultiplayerPatches(isHost);

                if (isHost)
                {
                    SpitfireGameUPK.ApplyMods(GameConfig.Instance.ModsEnabled);
                    SpitfireGameUPK.ApplyParTime();

                    // Loadouts are applied as soon as input is received

                    GameFiles.DefaultGame.Apply();

                    GameFiles.CharacterData.ApplyMods(GameConfig.Instance.ModsEnabled);
                }

                SpitfireGameUPK.SaveChanges();
            }

            // TODO add multiplayer patches for Siege Host

            GameFiles.DefaultGame.ApplySettings();
        }

        public static void FirstLaunchInitialization()
        {
            string launcherInstallationPath = FileUtils.GetLauncherInstallationPath(Settings.Instance.RootGamePath);
            Settings.Instance.LauncherInstallationPath = launcherInstallationPath;

            FileUtils.CreateBackup(FileUtils.INI_CHARACTER_DATA_FILENAME, Path.Combine(Settings.Instance.RootGamePath, FileUtils.INI_CONFIGS_FOLDER_RELATIVE_PATH, FileUtils.INI_CHARACTER_DATA_FILENAME));
            FileUtils.CreateBackup(FileUtils.INI_DEFAULT_GAME_FILENAME, Path.Combine(Settings.Instance.RootGamePath, FileUtils.INI_CONFIGS_FOLDER_RELATIVE_PATH, FileUtils.INI_DEFAULT_GAME_FILENAME));

            GameFiles.CharacterData.Initialize();
            GameFiles.DefaultGame.Initialize();

            // SpitfireGame (decompress) Initialization
            if (!Settings.Instance.IsSiegeInstallation)
            {
                // TODO extend to decompress Siege UPK
                int spitfireGameUPKFileSize = Settings.Instance.IsSiegeInstallation ? FileUtils.SPITFIREGAME_SIEGE_UPK_ORG_SIZE : FileUtils.SPITFIREGAME_UPK_ORG_SIZE;
                FileUtils.DecompressUPKFile(FileUtils.SPITFIREGAME_UPK_FILENAME, spitfireGameUPKFileSize);
            }

            // Hook (for co-op and non-dedicated server) Initialization
            string p2pHookFileName = Settings.Instance.IsSiegeInstallation ? FileUtils.P2P_HOOK_SIEGE_FILENAME : FileUtils.P2P_HOOK_FILENAME;
            FileUtils.ApplyHook(p2pHookFileName, FileUtils.P2P_HOOK_TARGET_FILENAME, Path.Combine(Settings.Instance.RootGamePath, FileUtils.SPITFIREGAME_BINARIES_WIN64_PATH));
            FileUtils.ApplyHook(p2pHookFileName, FileUtils.P2P_HOOK_TARGET_FILENAME, Path.Combine(Settings.Instance.RootGamePath, FileUtils.SPITFIREGAME_BINARIES_WIN32_PATH));
            FileUtils.CreateBackup(p2pHookFileName, Path.Combine(Settings.Instance.LauncherInstallationPath, FileUtils.MOD_HOOKS_FOLDER_NAME, p2pHookFileName));

            // Delete Hooks folder (not needed anymore)
            try
            {
                // TODO: Remove in future release
                if (Directory.Exists(Path.Combine(Settings.Instance.RootGamePath, FileUtils.BINARIES_FOLDER_NAME, FileUtils.MOD_HOOKS_FOLDER_NAME)))
                {
                    Directory.Delete(Path.Combine(Settings.Instance.RootGamePath, FileUtils.BINARIES_FOLDER_NAME, FileUtils.MOD_HOOKS_FOLDER_NAME), true);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error deleting obsolete Hooks folder: " + e.Message);
            }

            // Delete UE Extractor folder (not needed here anymore)
            try
            {
                // TODO: Remove in future release
                if (Directory.Exists(Path.Combine(Settings.Instance.RootGamePath, FileUtils.BINARIES_FOLDER_NAME, FileUtils.UE_EXTRACTOR_FOLDER_NAME)))
                {
                    Directory.Delete(Path.Combine(Settings.Instance.RootGamePath, FileUtils.BINARIES_FOLDER_NAME, FileUtils.UE_EXTRACTOR_FOLDER_NAME), true);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error deleting obsolete UE Extractor folder: " + e.Message);
            }

            Settings.Instance.FirstRun = false;
            Settings.Instance.Save();
        }

        public static void StartGame(string playerName, bool isHost, string hostIP = "")
        {
            Process p = new Process();
            p.StartInfo.FileName = FileUtils.SPITFIREGAME_EXE_FILENAME;
            string filePath = Path.Combine(Settings.Instance.RootGamePath, Settings.Instance.RunAs32 ? FileUtils.SPITFIREGAME_BINARIES_WIN32_PATH : FileUtils.BINARIES_FOLDER_NAME);
            p.StartInfo.WorkingDirectory = filePath;
            
            p.StartInfo.Arguments = CreateExeArguments(Settings.Instance.Debug, Settings.Instance.Language, isHost, hostIP, playerName);

            p.Start();

            p.WaitForExit();
        }

        private const string EXE_ARGUMENTS = " -seekfreeloadingpcconsole -writepid";
        private const string DEBUG_ARGUMENTS = " -log -ABSLOG=log.txt";
        private const string LANGUAGE_OPTION = " -language=";

        private static string CreateExeArguments(bool debug, string language, bool isHost, string hostIP, string playerName)
        {
            string arguments = "";

            string map = GameInfo.Battleground.Map.UmapCode;
            string playerGUID = playerName;
            string defaultArgs = EXE_ARGUMENTS;
            string languageArg = LANGUAGE_OPTION + Language.languageMap[language];

            arguments += isHost ? map : hostIP;
            arguments += isHost ? "?listen" : "";
            arguments += isHost ? "?PlayerReadyCount=" + GameInfo.PlayerCount : "";
            arguments += "?PlayerGUID=" + playerGUID;
            arguments += defaultArgs;
            arguments += languageArg;

            if (debug)
            {
                arguments += DEBUG_ARGUMENTS;
            }

            arguments += isHost ? " --net_mode=ListenServer" : " --net_mode=Client";

            return arguments;
        }
    }    
}
