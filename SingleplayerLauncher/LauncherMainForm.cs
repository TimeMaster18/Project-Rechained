using Newtonsoft.Json.Linq;
using SingleplayerLauncher.Mods;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace SingleplayerLauncher
{
    public partial class LauncherMainForm : Form
    {
        private const string characterDataIniPath = "..//SpitfireGame//Config//DefaultCharacterData.ini";
        private const string defaultGameIniPath = "..//SpitfireGame//Config//DefaultGame.ini";
        private const string spitfireGameUPKPath = "..//SpitfireGame//CookedPCConsole//SpitfireGame.upk";
        private const string backupFolderPath = "..//OMDU_Offline_Backups";

        private const string characterDataIniFileName = "DefaultCharacterData.ini";
        private const string defaultGameIniFileName = "DefaultGame.ini";
        private const string spitfireGameUPKFileName = "SpitfireGame.upk";
        private const int spitfireGameUPKOriginalFileSize = 100225213;


        private const string spitfireGameEXEFileName = "SpitfireGame.exe";

        private const string spitfireGameUPKDecompressPath = ".//UE Extractor//SpitfireGame.upk";
        private const string decompressorPath = ".//UE Extractor//decompress.exe";
        private const string spitfireGameUPKDecompressedPath = ".//UE Extractor//unpacked//SpitfireGame.upk";

        private const string loggingArgument = " -log -ABSLOG=log.txt";
        private const string defaultArguments = " -seekfreeloadingpcconsole -writepid -Language=INT -Region=us";

        private const string defaultSelectedHero = "Maximilian"; // Default selected Hero "Maximillian" Main Hero of the OrcsMustDie! Saga
        private const string defaultSelectedSkin = "Default";  // Default selected skin
        private const string defaultSelectedDye = "Normal";  // Default selected Normal dye

        private const string defaultSelectedMap = "The Baths"; // Default Selected "The Baths" because it's well optimised and Iconic Level 
        private const string defaultSelectedGameMode = "Survival"; // Default selected Game Mode "Survival"

        private const bool defaultCustomIniSetting = true;

        private const string valueTrue = "TRUE";
        private const string RCharacterDataSection = "RCharacterData_0 RCharacterData";

        private const string characterDataKeyGodMode = "GodMode";
        private const string characterDataKeyHero = "PawnTemplateName";
        private const string characterDataKeyDye = "HeroicDyeIdx";
        private const string characterDataKeyBonusStartingCoin = "BonusStartingCoin";

        private readonly Dictionary<string, string> defaultCharacterDataSection = new Dictionary<string, string>
        {
            { "PlayerName",         "Savitar"                           },
            { "GuildTag",           "~(^-^)~"                           },
            { "GuildName",          "ComboCalypse"                      },
            { "PawnTemplateName",   "PawnWeapon_Warmage.Pawn_Warmage"   },
            { "Team" ,              "1"                                 },
            { "HeroicDyeIdx",       "Normal"                            },
            { "GodMode",            "FALSE"                             }
        };

        private const string RGameReplicationInfoSection = "SpitfireGame.RGameReplicationInfo";

        private const string GameReplicationInfoKeyGameMode = "DefaultOfflineDifficulty";
        private const string GameReplicationInfoKeyMapLevel = "DefaultOfflineSuggestedLevel";
        private const string GameReplicationInfoKeyPlayerLevel = "DefaultOfflinePlayerLevel";
        private const string GameReplicationInfoKeyPlayerCount = "PlayerCountOverride";

        private const string gameModeSurvival = "Survival";
        private const string gameModeEndless = "Endless";
        private const string noExtraDifficulty = "No";

        private readonly Dictionary<string, string> defaultGameReplicationInfoSection = new Dictionary<string, string>
        {
            { "DefaultOfflineDifficulty",                       "1"         },
            { "PlayerCountOverride",                            "1"         },
            { "DefaultOfflineSuggestedLevel",                   "1"         },
            { "DefaultOfflinePlayerLevel",                      "1"         },
            { "DefaultOfflinePauseTimerDurationInSeconds",      "999999"    }   // Can be applied only once
        };

        private const string RDisplayColorInfoSection = "SpitfireGame.RDisplayColorInfo";
        

        private readonly Hero hero = Hero.Instance;

        public LauncherMainForm()
        {
            if (IsFirstRun())
            {
                FirstRunInitialization();
            }
            InitializeComponent();            
        }

        private void FirstRunInitialization()
        {
            // CharacterData.ini Initialization
            CreateBackup(characterDataIniFileName, characterDataIniPath);

            ConfigFile characterDataConfigFile = new ConfigFile(characterDataIniPath, true);
            var characterData = characterDataConfigFile.data;

            characterData.Sections.AddSection(RCharacterDataSection);

            foreach (KeyValuePair<string, string> entry in defaultCharacterDataSection)
                characterData[RCharacterDataSection].AddKey(entry.Key, entry.Value);

            characterDataConfigFile.Write(characterData);

            // DefaultGame.ini Initialization
            CreateBackup(defaultGameIniFileName, defaultGameIniPath);
            
            ConfigFile defaultGame = new ConfigFile(defaultGameIniPath);
            var defaultGameData = defaultGame.data;

            foreach (KeyValuePair<string, string> entry in defaultGameReplicationInfoSection)
                defaultGameData[RGameReplicationInfoSection][entry.Key] =  entry.Value;

            defaultGameData.Sections.RemoveSection(RDisplayColorInfoSection);

            defaultGame.Write(defaultGameData);

            // SpitfireGame (decompress) Initialization
            FileInfo spitfireGameUPKFileInfo = new FileInfo(spitfireGameUPKPath);
            if (spitfireGameUPKFileInfo.Length == spitfireGameUPKOriginalFileSize)
            {
                CreateBackup(spitfireGameUPKFileName, spitfireGameUPKPath);

                if (!File.Exists(spitfireGameUPKDecompressPath))
                    File.Copy(spitfireGameUPKPath, spitfireGameUPKDecompressPath);

                // Decompress
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = Path.GetFileName(decompressorPath);
                psi.WorkingDirectory = Path.GetDirectoryName(decompressorPath);
                psi.Arguments = "\"" + Path.GetFileName(spitfireGameUPKDecompressPath) + "\""; 
                Process process = Process.Start(psi);
                process.WaitForExit();
                File.Delete(spitfireGameUPKPath);
                File.Move(spitfireGameUPKDecompressedPath, spitfireGameUPKPath); //TODO I think decompress.exe can get output folder as parameter 
            }


            Settings.Instance["FirstRun"] = false;
            Settings.Save();
        }

        private void CreateBackup(string fileName, string path)
        {
            bool backupFolderExists = System.IO.Directory.Exists(backupFolderPath);

            if (!backupFolderExists)
                System.IO.Directory.CreateDirectory(backupFolderPath);

            if (!File.Exists(backupFolderPath + "//" + fileName))
                File.Copy(path, backupFolderPath + "//" + fileName);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string m in Resources.maps.Keys)
                comBoxMap.Items.Add(m);

            foreach (string h in Resources.heroes.Keys)
                comBoxHero.Items.Add(h);

            foreach (string d in Resources.dyes.Keys)
                comBoxDye.Items.Add(d);

            foreach (string gm in Resources.gameModes.Keys)
                comBoxGameMode.Items.Add(gm);

            foreach (string s in Resources.skins[defaultSelectedHero].Keys)
                comBoxSkin.Items.Add(s);

            comBoxHero.SelectedItem = defaultSelectedHero;
            comBoxSkin.SelectedItem = defaultSelectedSkin;
            comBoxDye.SelectedItem = defaultSelectedDye;

            comBoxMap.SelectedItem = defaultSelectedMap;
            comBoxGameMode.SelectedItem = defaultSelectedGameMode;

            chkCustomIni.Checked = defaultCustomIniSetting;

            hero.loadout = Resources.defaultLoadout;
            if (Settings.Instance.ContainsKey("hero"))
                comBoxHero.SelectedItem = Settings.Instance["hero"];
            if (Settings.Instance.ContainsKey("skin"))
                comBoxSkin.SelectedItem = Settings.Instance["skin"];
            if (Settings.Instance.ContainsKey("dye"))
                comBoxDye.SelectedItem = Settings.Instance["dye"];
            if (Settings.Instance.ContainsKey("map"))
                comBoxMap.SelectedItem = Settings.Instance["map"];
            if (Settings.Instance.ContainsKey("gameMode"))
                comBoxGameMode.SelectedItem = Settings.Instance["gameMode"];
            if (Settings.Instance.ContainsKey("difficulty"))
                comBoxDifficulty.SelectedItem = Settings.Instance["difficulty"];
            if (Settings.Instance.ContainsKey("extraDifficulty"))
                comBoxExtraDifficulty.SelectedItem = Settings.Instance["extraDifficulty"];
            if (Settings.Instance.ContainsKey("customIni"))
                chkCustomIni.Checked = (bool)Settings.Instance["customIni"];
            if (Settings.Instance.ContainsKey("log"))
                chkLog.Checked = (bool)Settings.Instance["log"];
            if (Settings.Instance.ContainsKey("loadout"))
            {
                var savedLoadOut = ((JArray)Settings.Instance["loadout"]).ToObject<string[]>();
                hero.loadout = savedLoadOut;
            }
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            UPKFile spitfireGameUPKFile = new UPKFile(spitfireGameUPKPath);
            hero.UPKFile = spitfireGameUPKFile;

            if (chkCustomIni.Checked)
            {
                UpdateCharacterDataIni();
                UpdateDefaultGameIni();
            }
            if (comBoxSkin.SelectedItem != null)
            {
                hero.Skin = comBoxSkin.SelectedItem.ToString();
            }
            
            MessageBox.Show("Saving your changes. Please wait.");
            hero.ApplyLoadoutChanges();

            ApplyMods(spitfireGameUPKFile);

            spitfireGameUPKFile.Save();
            MessageBox.Show("Finished");
            SaveSettings();
            StartGame();
        }
        public void SaveSettings()
        {

            Settings.Instance["hero"] = comBoxHero.SelectedItem;
            Settings.Instance["skin"] = comBoxSkin.SelectedItem;
            Settings.Instance["dye"] = comBoxDye.SelectedItem;
            Settings.Instance["map"] = comBoxMap.SelectedItem;
            Settings.Instance["gameMode"] = comBoxGameMode.SelectedItem;
            Settings.Instance["difficulty"] = comBoxDifficulty.SelectedItem;
            Settings.Instance["extraDifficulty"] = comBoxExtraDifficulty.SelectedItem;
            Settings.Instance["customIni"] = chkCustomIni.Checked;
            Settings.Instance["log"] = chkLog.Checked;
            Settings.Save();
        }
        private static void ApplyMods(UPKFile spitfireGameUPKFile)
        {
            NoTrapCap ntp = new NoTrapCap(spitfireGameUPKFile);
            if (Settings.Instance.ContainsKey("NoTrapCap") && (bool)Settings.Instance["NoTrapCap"])
            {
                ntp.InstallMod();
            }
            else
            {
                ntp.UninstallMod();
            }
            
            TrapsInTraps tit = new TrapsInTraps(spitfireGameUPKFile);
            if (Settings.Instance.ContainsKey("TrapsInTraps") && (bool)Settings.Instance["TrapsInTraps"])
            {
                tit.InstallMod();
            }
            else
            {
                tit.UninstallMod();
            }
        }

        private void StartGame()
        {
            Process p = new Process();
            p.StartInfo.FileName = spitfireGameEXEFileName;
            p.StartInfo.Arguments = CreateExeArguments();

            p.Start();
        }

        private void UpdateCharacterDataIni()
        {
            ConfigFile characterData = new ConfigFile(characterDataIniPath);
            var data = characterData.data;

            data[RCharacterDataSection][characterDataKeyHero] = Resources.heroes[comBoxHero.Text];
            data[RCharacterDataSection][characterDataKeyDye] = Resources.dyes[comBoxDye.Text];

            if (Settings.Instance.ContainsKey("GodMode") && (bool)Settings.Instance["GodMode"])
                data[RCharacterDataSection][characterDataKeyGodMode] = valueTrue;

            if (Settings.Instance.ContainsKey("StartingCoin"))
                data[RCharacterDataSection][characterDataKeyBonusStartingCoin] = calculateMultiplierStartingCoin(comBoxMap.Text, Int32.Parse((string)Settings.Instance["StartingCoin"]));

            characterData.Write(data);
        }

        private string calculateMultiplierStartingCoin(string mapName, int startingCoin)
        {
            if (mapName.Contains("Tutorial") || mapName.Contains("Prologue"))
                return "0";

            if (startingCoin == -1)
            {
                return "0";
            }
            else if (startingCoin == 0)
            {
                return "-1";
            }
            else
            {
                int baseStartingCoins = 9000;
                if (Resources.startingCoin6000Maps.Contains(mapName))
                {
                    baseStartingCoins = 6000;
                }

                double startingCoinsMultiplier = (double) startingCoin / baseStartingCoins;
                // it's a multiplier, so it needs an offset of -1
                startingCoinsMultiplier--;

                return startingCoinsMultiplier.ToString();
            }

        }

        private void UpdateDefaultGameIni()
        {
            ConfigFile defaultGame = new ConfigFile(defaultGameIniPath);
            var data = defaultGame.data;

            string selectedGameMode = comBoxGameMode.SelectedItem.ToString();
            string selectedExtraDifficulty = comBoxExtraDifficulty.SelectedItem.ToString();

            foreach (KeyValuePair<string, string> entry in defaultGameReplicationInfoSection) // TODO improve default/set handling to prevent rewriting same key
                data[RGameReplicationInfoSection][entry.Key] = entry.Value;

            data[RGameReplicationInfoSection][GameReplicationInfoKeyGameMode] = Resources.gameModes[selectedGameMode];

            bool extraDifficulty = false;
            if (!selectedExtraDifficulty.Equals(noExtraDifficulty))
                extraDifficulty = true;


            if (selectedGameMode.Equals(gameModeSurvival))
            {
                string selectedDifficulty = comBoxDifficulty.SelectedItem.ToString();

                if (extraDifficulty)
                {
                    data[RGameReplicationInfoSection][GameReplicationInfoKeyPlayerLevel] = Resources.survivalExtraDifficulties[selectedDifficulty][selectedExtraDifficulty][0].ToString();
                    data[RGameReplicationInfoSection][GameReplicationInfoKeyMapLevel] = Resources.survivalExtraDifficulties[selectedDifficulty][selectedExtraDifficulty][1].ToString();
                    data[RGameReplicationInfoSection][GameReplicationInfoKeyPlayerCount] = "3";
                }
                else
                {
                    data[RGameReplicationInfoSection][GameReplicationInfoKeyMapLevel] = Resources.survivalDifficulties[selectedDifficulty];
                    data[RGameReplicationInfoSection][GameReplicationInfoKeyPlayerLevel] = Resources.survivalDifficulties[selectedDifficulty];
                }
            }            
            else if (selectedGameMode.Equals(gameModeEndless))
            {
                if (extraDifficulty)
                {
                    data[RGameReplicationInfoSection][GameReplicationInfoKeyMapLevel] = Resources.endlessDifficulties[selectedExtraDifficulty];
                    data[RGameReplicationInfoSection][GameReplicationInfoKeyPlayerCount] = "3";
                }
            }

            defaultGame.Write(data);
        }

        private string CreateExeArguments()
        {
            string arguments = "";

            string map = Resources.maps[comBoxMap.Text];
            string defaultArgs = defaultArguments;

            arguments += map;
            arguments += defaultArgs;

            if (chkLog.Checked)
                arguments += loggingArgument;

            return arguments;
        }

        private void chkCustomIni_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkCustomIni.Checked)
            {
                comBoxHero.Enabled = false;
                comBoxDye.Enabled = false;
                comBoxDifficulty.Enabled = false;
                comBoxExtraDifficulty.Enabled = false;
                comBoxGameMode.Enabled = false;
            }
            else
            {
                comBoxHero.Enabled = true;
                comBoxDye.Enabled = true;
                comBoxDifficulty.Enabled = true;
                comBoxExtraDifficulty.Enabled = true;
                comBoxGameMode.Enabled = true;
            }
        }

        private void btnLoadoutEditor_Click(object sender, EventArgs e)
        {
            LoadoutEditorForm ld = new LoadoutEditorForm();
            ld.Show();
        }

        private void comBoxGameMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            comBoxDifficulty.Items.Clear();

            comBoxExtraDifficulty.Items.Clear();
            comBoxExtraDifficulty.Items.Add(noExtraDifficulty);
            comBoxExtraDifficulty.SelectedItem = noExtraDifficulty;

            switch (comBoxGameMode.SelectedItem)
            {
                case gameModeEndless:
                    comBoxDifficulty.Enabled = false;

                    foreach (string ed in Resources.endlessDifficulties.Keys)
                        comBoxExtraDifficulty.Items.Add(ed);

                    break;

                case gameModeSurvival:
                    comBoxDifficulty.Enabled = true;

                    string selectedMap = comBoxMap.SelectedItem.ToString();

                    foreach (string md in Resources.mapSurvivalDifficulties[selectedMap])
                        comBoxDifficulty.Items.Add(md);

                    comBoxDifficulty.SelectedIndex = 0;

                    break;

                default:
                    break;
            }
        }

        private void comBoxMap_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMap = comBoxMap.SelectedItem.ToString();
            if (selectedMap.Contains("Tutorial") || selectedMap.Contains("Prologue"))
            {
                comBoxGameMode.Enabled = false;
                comBoxDifficulty.Enabled = false;
                comBoxExtraDifficulty.Enabled = false;
            }
            else
            {
                comBoxGameMode.Enabled = true;
                comBoxDifficulty.Enabled = true;
                comBoxExtraDifficulty.Enabled = true;

                // Manual refresh of possible difficulties
                var modeSelected = comBoxGameMode.SelectedItem;
                comBoxGameMode.SelectedIndex = -1;
                comBoxGameMode.SelectedItem = modeSelected;

                if (Resources.startingCoin6000Maps.Contains(selectedMap))
                    Settings.Instance["StartingCoin"] = "6000";
                else
                    Settings.Instance["StartingCoin"] = "9000";
                Settings.Save();
            }
        }


        private void comBoxDifficulty_SelectedIndexChanged(object sender, EventArgs e)
        {
            comBoxExtraDifficulty.Items.Clear();
            comBoxExtraDifficulty.Items.Add(noExtraDifficulty);
            comBoxExtraDifficulty.SelectedItem = noExtraDifficulty;

            string selectedDifficulty = comBoxDifficulty.SelectedItem.ToString();

            foreach (string ef in Resources.survivalExtraDifficulties[selectedDifficulty].Keys)
            {
                comBoxExtraDifficulty.Items.Add(ef);
            }
        }

        // TODO to change when more heroes are playable
        private void comBoxHero_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comBoxHero.SelectedItem.Equals(defaultSelectedHero))
            {
                comBoxSkin.Enabled = true;
            }
            else
            {
                comBoxSkin.Enabled = false;
                comBoxSkin.SelectedIndex = -1;
            }
        }
        private static bool IsFirstRun()
        {
            return !Settings.Instance.ContainsKey("FirstRun");
        }

        private void btnResetConfig_Click(object sender, EventArgs e)
        {
            FirstRunInitialization();
        }

        private void btnMods_Click(object sender, EventArgs e)
        {
            ModLoaderForm mlf = new ModLoaderForm();
            mlf.Show();
        }

        private void ChkLog_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}

    