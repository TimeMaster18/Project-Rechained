using SingleplayerLauncher.Model;
using SingleplayerLauncher.GameFiles;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace SingleplayerLauncher
{
    class GameLauncher
    {
        private static readonly GameInfo GameInfo = GameInfo.Instance;
        private static readonly SpitfireGameUPK SpitfireGameUPK = new SpitfireGameUPK();

        private static readonly List<string> SPITFIREGAME_LOADOUT_HERO_NAMES = new List<string>() { Names.Hero.MAXIMILIAN, Names.Hero.HOGARTH, Names.Hero.GABRIELLA, Names.Hero.SMOLDER, Names.Hero.IVY, Names.Hero.BIONKA };
        public static void ApplyChanges()
        {
            SpitfireGameUPK.SpitfireGameUPKFile = new UPKFile(FileUtils.SPITFIREGAME_UPK_PATH);

            SpitfireGameUPK.ApplyMods(GameConfig.Instance.ModsEnabled);

            SpitfireGameUPK.ApplyParTime();
            SpitfireGameUPK.ApplyHostPatches(); // TODO adjust for multiplayer
            SpitfireGameUPK.SaveChanges();

            GameFiles.CharacterData.ApplyLoadout();
            GameFiles.DefaultGame.Apply();

            GameFiles.CharacterData.ApplyMods(GameConfig.Instance.ModsEnabled);
            GameFiles.DefaultGame.ApplyMods(GameConfig.Instance.ModsEnabled);
        }

        private const string MOD_HOOK_FILES_PATH = "./Hooks/";
        private const string P2P_HOOK_FILENAME = "omdu_hook.dll";
        private const string P2P_HOOK_TARGET_FILENAME = "x3daudio1_7.dll";

        public static void FirstLaunchInitialization()
        {
            GameFiles.CharacterData.Initialize();
            GameFiles.DefaultGame.Initialize();

            // SpitfireGame (decompress) Initialization
            FileUtils.DecompressUPKFile(FileUtils.SPITFIREGAME_UPK_PATH, FileUtils.SPITFIREGAME_UPK_ORG_SIZE);

            // Hook (for co-op and non-dedicated server) Initialization
            string hookSourceFilePath = Path.Combine(MOD_HOOK_FILES_PATH, P2P_HOOK_FILENAME);
            string hookTargetFilePathWin64 = Path.Combine(FileUtils.SPITFIREGAME_EXE_WIN64_FILEPATH, P2P_HOOK_TARGET_FILENAME);
            string hookTargetFilePathWin32 = Path.Combine(FileUtils.SPITFIREGAME_EXE_WIN32_FILEPATH, P2P_HOOK_TARGET_FILENAME);
            FileUtils.CopyFileWithCheck(hookSourceFilePath, hookTargetFilePathWin64, overwrite: true);
            FileUtils.CopyFileWithCheck(hookSourceFilePath, hookTargetFilePathWin32, overwrite: true);

            Settings.Instance.FirstRun = false;
            Settings.Instance.Save();
        }

        public static void StartGame()
        {
            Process p = new Process();
            p.StartInfo.FileName = FileUtils.SPITFIREGAME_EXE_FILENAME;
            if (Settings.Instance.RunAs32)
            {
                p.StartInfo.WorkingDirectory = FileUtils.SPITFIREGAME_EXE_WIN32_FILEPATH;
            }
            p.StartInfo.Arguments = CreateExeArguments(Settings.Instance.Debug, Settings.Instance.Language);

            p.Start();

            p.WaitForExit();
        }

        private const string EXE_ARGUMENTS = " -seekfreeloadingpcconsole -writepid";
        private const string DEBUG_ARGUMENTS = " -log -ABSLOG=log.txt";
        private const string LANGUAGE_OPTION = " -language=";

        private static string CreateExeArguments(bool debug, string language)
        {
            string arguments = "";

            string map = GameInfo.Battleground.Map.UmapCode;
            string defaultArgs = EXE_ARGUMENTS;
            string languageArg = LANGUAGE_OPTION + Language.GetKeyFromValue(language);

            arguments += map;
            arguments += "?listen?PlayerGUID=Time-Master --net_mode=ListenServer"; // TODO Adjust for multiplayer
            arguments += defaultArgs;
            arguments += languageArg;

            if (debug)
            {
                arguments += DEBUG_ARGUMENTS;
            }

            return arguments;
        }
    }    
}
