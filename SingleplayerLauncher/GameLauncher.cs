using SingleplayerLauncher.Model;
using SingleplayerLauncher.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace SingleplayerLauncher
{
    class GameLauncher
    {
        private static readonly GameInfo GameInfo = GameInfo.Instance;
        private static readonly SpitfireGameUPK SpitfireGameUPK = new SpitfireGameUPK();


        private static readonly List<string> CUSTOM_LOADOUT_HERO_NAMES = new List<string>() { Names.Hero.MAXIMILIAN, Names.Hero.HOGARTH, Names.Hero.GABRIELLA, Names.Hero.SMOLDER, Names.Hero.IVY, Names.Hero.BIONKA };
        public static void ApplyChanges()
        {
            SpitfireGameUPK.SpitfireGameUPKFile = new UPKFile(FileUtils.SPITFIREGAME_UPK_PATH);
            if (CUSTOM_LOADOUT_HERO_NAMES.Contains(GameInfo.Loadout.Hero.Name))
            {
                SpitfireGameUPK.ApplyLoadout();
            }
            SpitfireGameUPK.ApplyMods();
            SpitfireGameUPK.ApplyTrapTiers();
            SpitfireGameUPK.SaveChanges();

            GameSettings.CharacterData.Apply();
            GameSettings.DefaultGame.Apply();
        }


        private const string UPK_FILES_PATH = "..//SpitfireGame//CookedPCConsole//";
        private const string MOD_DEFAULT_PAWNWEAPON_UPK_FILES_PATH = ".//DefaultLoadouts//";

        private const string PAWNWEAPON_DEADEYE_UPK_FILENAME = "pawnweapon_deadeye_SF.upk";
        private const string PAWNWEAPON_ZOEY_UPK_FILENAME = "pawnweapon_zoey_SF.upk";
        private const string PAWNWEAPON_BRASS_UPK_FILENAME = "pawnweapon_brass_SF.upk";
        private const string PAWNWEAPON_CYGNUS_UPK_FILENAME = "pawnweapon_cygnus_SF.upk";
        private const string PAWNWEAPON_BLOODSPIKE_UPK_FILENAME = "pawnweapon_bloodspike_SF.upk";
        private const string PAWNWEAPON_TEMPER_UPK_FILENAME = "pawnweapon_temper_SF.upk";
        private const string PAWNWEAPON_HOOKSWORD_UPK_FILENAME = "pawnweapon_hooksword_SF.upk";
        private const string PAWNWEAPON_OZIEL_UPK_FILENAME = "pawnweapon_oziel_SF.upk";
        private const string PAWNWEAPON_TUNDRA_UPK_FILENAME = "pawnweapon_tundra_SF.upk";
        private const string PAWNWEAPON_STINKEYE_UPK_FILENAME = "pawnweapon_stinkeye_SF.upk";
        private const string PAWNWEAPON_DOBBIN_UPK_FILENAME = "pawnweapon_dobbin_SF.upk";
        private const string PAWNWEAPON_BLACKPAW_UPK_FILENAME = "pawnweapon_blackpaw_SF.upk";
        private const string PAWNWEAPON_MIDNIGHT_UPK_FILENAME = "pawnweapon_midnight_SF.upk";

        private const int PAWNWEAPON_DEADEYE_UPK_FILE_SIZE = 2971040;
        private const int PAWNWEAPON_ZOEY_UPK_FILE_SIZE = 1644500;
        private const int PAWNWEAPON_BRASS_UPK_FILE_SIZE = 1594065;
        private const int PAWNWEAPON_CYGNUS_UPK_FILE_SIZE = 1689050;
        private const int PAWNWEAPON_BLOODSPIKE_UPK_FILE_SIZE = 1668882;
        private const int PAWNWEAPON_TEMPER_UPK_FILE_SIZE = 1427244;
        private const int PAWNWEAPON_HOOKSWORD_UPK_FILE_SIZE = 1713352;
        private const int PAWNWEAPON_OZIEL_UPK_FILE_SIZE = 1119775;
        private const int PAWNWEAPON_TUNDRA_UPK_FILE_SIZE = 1041680;
        private const int PAWNWEAPON_STINKEYE_UPK_FILE_SIZE = 983974;
        private const int PAWNWEAPON_DOBBIN_UPK_FILE_SIZE = 1124993;
        private const int PAWNWEAPON_BLACKPAW_UPK_FILE_SIZE = 1242970;
        private const int PAWNWEAPON_MIDNIGHT_UPK_FILE_SIZE = 696772;
        private const int NUM_PAWNWEAPONS = 13;
        private static readonly string[] PAWNWEAPON_FILENAMES = new string[NUM_PAWNWEAPONS] { PAWNWEAPON_DEADEYE_UPK_FILENAME, PAWNWEAPON_ZOEY_UPK_FILENAME, PAWNWEAPON_BRASS_UPK_FILENAME,
                                                                 PAWNWEAPON_CYGNUS_UPK_FILENAME, PAWNWEAPON_BLOODSPIKE_UPK_FILENAME, PAWNWEAPON_TEMPER_UPK_FILENAME,
                                                                 PAWNWEAPON_HOOKSWORD_UPK_FILENAME, PAWNWEAPON_OZIEL_UPK_FILENAME, PAWNWEAPON_TUNDRA_UPK_FILENAME,
                                                                 PAWNWEAPON_STINKEYE_UPK_FILENAME, PAWNWEAPON_DOBBIN_UPK_FILENAME, PAWNWEAPON_BLACKPAW_UPK_FILENAME, PAWNWEAPON_MIDNIGHT_UPK_FILENAME };
        private static readonly int[] PAWNWEAPON_ORIGINAL_FILESIZES = new int[NUM_PAWNWEAPONS] { PAWNWEAPON_DEADEYE_UPK_FILE_SIZE, PAWNWEAPON_ZOEY_UPK_FILE_SIZE, PAWNWEAPON_BRASS_UPK_FILE_SIZE,
                                                                 PAWNWEAPON_CYGNUS_UPK_FILE_SIZE, PAWNWEAPON_BLOODSPIKE_UPK_FILE_SIZE, PAWNWEAPON_TEMPER_UPK_FILE_SIZE,
                                                                 PAWNWEAPON_HOOKSWORD_UPK_FILE_SIZE, PAWNWEAPON_OZIEL_UPK_FILE_SIZE, PAWNWEAPON_TUNDRA_UPK_FILE_SIZE,
                                                                 PAWNWEAPON_STINKEYE_UPK_FILE_SIZE, PAWNWEAPON_DOBBIN_UPK_FILE_SIZE, PAWNWEAPON_BLACKPAW_UPK_FILE_SIZE, PAWNWEAPON_MIDNIGHT_UPK_FILE_SIZE };
        public static void FirstLaunchInitialization()
        {
            GameSettings.CharacterData.Initialize();
            GameSettings.DefaultGame.Initialize();

            // Alternative Heroes, Default Loadout (pawnweapon files)
            for (int i = 0; i < NUM_PAWNWEAPONS; i++)
            {
                FileInfo pawnWeaponUPKFileInfo = new FileInfo(UPK_FILES_PATH + PAWNWEAPON_FILENAMES[i]);
                if (pawnWeaponUPKFileInfo.Length == PAWNWEAPON_ORIGINAL_FILESIZES[i])
                    FileUtils.CreateBackup(PAWNWEAPON_FILENAMES[i], UPK_FILES_PATH + PAWNWEAPON_FILENAMES[i]);

                File.Delete(UPK_FILES_PATH + PAWNWEAPON_FILENAMES[i]);
                File.Copy(MOD_DEFAULT_PAWNWEAPON_UPK_FILES_PATH + PAWNWEAPON_FILENAMES[i], UPK_FILES_PATH + PAWNWEAPON_FILENAMES[i]);
            }

            // SpitfireGame (decompress) Initialization
            FileUtils.DecompressUPKFile(FileUtils.SPITFIREGAME_UPK_PATH, FileUtils.SPITFIREGAME_UPK_ORG_SIZE);

            Settings.Instance["FirstRun"] = false;
            Settings.Save();
        }

        

        public static void StartGame(bool debug)
        {
            Process p = new Process();
            p.StartInfo.FileName = FileUtils.SPITFIREGAME_EXE_FILENAME;
            p.StartInfo.Arguments = CreateExeArguments(debug);

            p.Start();
        }


        private const string EXE_ARGUMENTS = " -seekfreeloadingpcconsole -writepid -Language=INT -Region=us";
        private const string DEBUG_ARGUMENTS = " -log -ABSLOG=log.txt";
        private static string CreateExeArguments(bool debug)
        {
            string arguments = "";

            string map = GameInfo.Battleground.Map.UmapCode;
            string defaultArgs = EXE_ARGUMENTS;

            arguments += map;
            arguments += defaultArgs;

            if (debug)
                arguments += DEBUG_ARGUMENTS;

            return arguments;
        }
    }
}
