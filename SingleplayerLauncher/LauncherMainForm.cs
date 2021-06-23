using IniParser.Model;
using Newtonsoft.Json.Linq;
using SingleplayerLauncher.Mods;
using SingleplayerLauncher.Resources;
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


        private const string valueTrue = "TRUE";
        private const string RCharacterDataSection = "RCharacterData_0 RCharacterData";

        private const string characterDataKeyGodMode = "GodMode";
        private const string characterDataKeyHero = "PawnTemplateName";
        private const string characterDataKeyDye = "HeroicDyeIdx";
        private const string characterDataKeyBonusStartingCoin = "BonusStartingCoin";


        private const string RGameReplicationInfoSection = "SpitfireGame.RGameReplicationInfo";

        private const string GameReplicationInfoKeyGameMode = "DefaultOfflineDifficulty";
        private const string GameReplicationInfoKeyMapLevel = "DefaultOfflineSuggestedLevel";
        private const string GameReplicationInfoKeyPlayerLevel = "DefaultOfflinePlayerLevel";
        private const string GameReplicationInfoKeyPlayerCount = "PlayerCountOverride";

        private const string gameModeSurvival = "Survival";
        private const string gameModeEndless = "Endless";
        private const string noExtraDifficulty = "No";


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
            IniData characterData = characterDataConfigFile.data;

            characterData.Sections.AddSection(RCharacterDataSection);

            foreach (KeyValuePair<string, string> entry in DefaultValues.CharacterDataSection)
                characterData[RCharacterDataSection].AddKey(entry.Key, entry.Value);

            characterDataConfigFile.Write(characterData);

            // DefaultGame.ini Initialization
            CreateBackup(defaultGameIniFileName, defaultGameIniPath);

            ConfigFile defaultGame = new ConfigFile(defaultGameIniPath);
            IniData defaultGameData = defaultGame.data;

            foreach (KeyValuePair<string, string> entry in DefaultValues.GameReplicationInfoSection)
                defaultGameData[RGameReplicationInfoSection][entry.Key] = entry.Value;

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
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = Path.GetFileName(decompressorPath),
                    WorkingDirectory = Path.GetDirectoryName(decompressorPath),
                    Arguments = "\"" + Path.GetFileName(spitfireGameUPKDecompressPath) + "\""
                };
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
            foreach (string m in GameInfo.Maps.Keys)
                comBoxMap.Items.Add(m);

            foreach (string h in GameInfo.Heroes.Keys)
                comBoxHero.Items.Add(h);

            foreach (string d in IniConfig.Dyes.Keys)
                comBoxDye.Items.Add(d);

            foreach (string gm in IniConfig.GameModes.Keys)
                comBoxGameMode.Items.Add(gm);

            foreach (string s in GameInfo.Heroes[DefaultValues.SelectedHero].Skins.Keys)
                comBoxSkin.Items.Add(s);

            comBoxHero.SelectedItem = DefaultValues.SelectedHero;
            comBoxSkin.SelectedItem = DefaultValues.SelectedSkin;
            comBoxDye.SelectedItem = DefaultValues.SelectedDye;

            comBoxMap.SelectedItem = DefaultValues.SelectedMap;
            comBoxGameMode.SelectedItem = DefaultValues.SelectedGameMode;

            chkCustomIni.Checked = DefaultValues.CustomIniSetting;

            hero.Loadout = DefaultValues.Loadout;
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
                string[] savedLoadOut = ((JArray)Settings.Instance["loadout"]).ToObject<string[]>();
                hero.Loadout = savedLoadOut;
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
                hero.Skin = comBoxSkin.SelectedItem.ToString();


            if (comBoxHero.SelectedItem != null)
                hero.Name = comBoxHero.SelectedItem.ToString();

            MessageBox.Show("Saving your changes. Please wait.");
            if (SpitfireGameUPK.HeroObjects.ContainsKey(hero.Name))
            {
                hero.ApplyLoadoutChanges();
            }
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
            IniData data = characterData.data;

            data[RCharacterDataSection][characterDataKeyHero] = IniConfig.Heroes[comBoxHero.Text];
            data[RCharacterDataSection][characterDataKeyDye] = IniConfig.Dyes[comBoxDye.Text];

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
                if (GameInfo.startingCoin6000Maps.Contains(mapName))
                {
                    baseStartingCoins = 6000;
                }

                double startingCoinsMultiplier = (double)startingCoin / baseStartingCoins;
                // it's a multiplier, so it needs an offset of -1
                startingCoinsMultiplier--;

                return startingCoinsMultiplier.ToString();
            }

        }

        private void UpdateDefaultGameIni()
        {
            ConfigFile defaultGame = new ConfigFile(defaultGameIniPath);
            IniData data = defaultGame.data;

            string selectedGameMode = comBoxGameMode.SelectedItem.ToString();
            string selectedExtraDifficulty = comBoxExtraDifficulty.SelectedItem.ToString();

            foreach (KeyValuePair<string, string> entry in Resources.DefaultValues.GameReplicationInfoSection) // TODO improve default/set handling to prevent rewriting same key
                data[RGameReplicationInfoSection][entry.Key] = entry.Value;

            data[RGameReplicationInfoSection][GameReplicationInfoKeyGameMode] = IniConfig.GameModes[selectedGameMode];

            bool extraDifficulty = !selectedExtraDifficulty.Equals(noExtraDifficulty);

            if (selectedGameMode.Equals(gameModeSurvival))
            {
                string selectedDifficulty = comBoxDifficulty.SelectedItem.ToString();

                if (extraDifficulty)
                {
                    data[RGameReplicationInfoSection][GameReplicationInfoKeyMapLevel] = IniConfig.survivalExtraDifficulties[selectedDifficulty][selectedExtraDifficulty][1].ToString();
                    data[RGameReplicationInfoSection][GameReplicationInfoKeyPlayerLevel] = IniConfig.survivalExtraDifficulties[selectedDifficulty][selectedExtraDifficulty][0].ToString();
                    data[RGameReplicationInfoSection][GameReplicationInfoKeyPlayerCount] = "3";
                }
                else
                {
                    data[RGameReplicationInfoSection][GameReplicationInfoKeyMapLevel] = IniConfig.survivalDifficulties[selectedDifficulty];
                    data[RGameReplicationInfoSection][GameReplicationInfoKeyPlayerLevel] = IniConfig.survivalDifficulties[selectedDifficulty];
                }
            }
            else if (selectedGameMode.Equals(gameModeEndless))
            {
                if (extraDifficulty)
                {
                    data[RGameReplicationInfoSection][GameReplicationInfoKeyMapLevel] = IniConfig.endlessDifficulties[selectedExtraDifficulty];
                    data[RGameReplicationInfoSection][GameReplicationInfoKeyPlayerCount] = "3";
                }
            }

            hero.AccountLevel = Int32.Parse(data[RGameReplicationInfoSection][GameReplicationInfoKeyPlayerLevel]);

            defaultGame.Write(data);
        }

        private string CreateExeArguments()
        {
            string arguments = "";

            string map = IniConfig.Maps[comBoxMap.Text];
            string defaultArgs = DefaultValues.ExeArguments;

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

                    foreach (string ed in IniConfig.endlessDifficulties.Keys)
                        comBoxExtraDifficulty.Items.Add(ed);

                    break;

                case gameModeSurvival:
                    comBoxDifficulty.Enabled = true;

                    string selectedMap = comBoxMap.SelectedItem.ToString();

                    foreach (string md in GameInfo.Maps[selectedMap].SurvivalDifficulties)
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
                object modeSelected = comBoxGameMode.SelectedItem;
                comBoxGameMode.SelectedIndex = -1;
                comBoxGameMode.SelectedItem = modeSelected;

                if (GameInfo.startingCoin6000Maps.Contains(selectedMap))
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

            foreach (string ef in IniConfig.survivalExtraDifficulties[selectedDifficulty].Keys)
            {
                comBoxExtraDifficulty.Items.Add(ef);
            }
        }

        // TODO to change when more heroes are playable
        private void comBoxHero_SelectedIndexChanged(object sender, EventArgs e)
        {
            comBoxSkin.Items.Clear();
            string selectedHero = comBoxHero.SelectedItem.ToString();
            if (GameInfo.Heroes[selectedHero].Skins != null)
            {
                comBoxSkin.Enabled = true;

                foreach (string s in GameInfo.Heroes[selectedHero].Skins.Keys)
                    comBoxSkin.Items.Add(s);

                comBoxSkin.SelectedItem = DefaultValues.SelectedSkin;
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
    }
}

