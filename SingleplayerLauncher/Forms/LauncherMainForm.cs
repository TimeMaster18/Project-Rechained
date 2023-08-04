using SingleplayerLauncher.Model;
using SingleplayerLauncher.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SingleplayerLauncher
{
    public partial class LauncherMainForm : Form
    {
        private const string noExtraDifficulty = "No";

        private readonly GameInfo GameInfo = GameInfo.Instance;

        public LauncherMainForm()
        {
            if (IsFirstRun())
            {
                GameLauncher.FirstLaunchInitialization();
            }
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string m in Model.Map.Maps.Keys)
            {
                comBoxMap.Items.Add(m);
            }

            foreach (string h in Model.Hero.Heroes.Keys)
            {
                comBoxHero.Items.Add(h);
            }

            foreach (string d in Model.Dye.Dyes.Keys)
            {
                comBoxDye.Items.Add(d);
            }

            foreach (string gm in Model.GameMode.GameModes.Keys)
            {
                comBoxGameMode.Items.Add(gm);
            }

            comBoxHero.SelectedItem = DefaultValues.SelectedHero;
            comBoxSkin.SelectedItem = DefaultValues.SelectedSkin;
            comBoxDye.SelectedItem = DefaultValues.SelectedDye;

            comBoxMap.SelectedItem = DefaultValues.SelectedMap;
            comBoxGameMode.SelectedItem = DefaultValues.SelectedGameMode;

            if (Settings.Instance.ContainsKey("hero"))
            {
                comBoxHero.SelectedItem = Settings.Instance["hero"];
            }

            if (Settings.Instance.ContainsKey("skin"))
            {
                comBoxSkin.SelectedItem = Settings.Instance["skin"];
            }

            if (Settings.Instance.ContainsKey("dye"))
            {
                comBoxDye.SelectedItem = Settings.Instance["dye"];
            }

            if (Settings.Instance.ContainsKey("map"))
            {
                comBoxMap.SelectedItem = Settings.Instance["map"];
            }

            if (Settings.Instance.ContainsKey("gameMode"))
            {
                comBoxGameMode.SelectedItem = Settings.Instance["gameMode"];
            }

            if (Settings.Instance.ContainsKey("difficulty"))
            {
                comBoxDifficulty.SelectedItem = Settings.Instance["difficulty"];
            }

            if (Settings.Instance.ContainsKey("extraDifficulty"))
            {
                comBoxExtraDifficulty.SelectedItem = Settings.Instance["extraDifficulty"];
            }

            if (Settings.Instance.ContainsKey("debug"))
            {
                chkDebug.Checked = (bool)Settings.Instance["debug"];
            }
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saving your changes. Please wait.");
            GameLauncher.ApplyChanges();
            MessageBox.Show("Finished");

            SaveSettings();
            GameLauncher.StartGame(chkDebug.Checked);
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
            Settings.Instance["debug"] = chkDebug.Checked;
            Settings.Save();
        }

        private void btnLoadoutEditor_Click(object sender, EventArgs e)
        {
            LoadoutEditorForm ld = new LoadoutEditorForm();
            ld.Show();
        }

        private void comBoxMap_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMap = comBoxMap.SelectedItem.ToString();
            GameInfo.Battleground.Map = Model.Map.Maps[selectedMap];

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

                comBoxGameMode.Items.Clear();
                comBoxGameMode.Items.Add(Names.GameMode.SURVIVAL);
                if (GameInfo.Battleground.Map.HasEndlessAvailable)
                {
                    comBoxGameMode.Items.Add(Names.GameMode.ENDLESS);
                }

                comBoxGameMode.SelectedIndex = 0;
            }
        }

        private void comBoxGameMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            comBoxDifficulty.Items.Clear();

            switch (comBoxGameMode.SelectedItem)
            {
                case Names.GameMode.ENDLESS:
                    comBoxDifficulty.Items.Add(Model.Difficulty.Endless.Name);
                    break;

                case Names.GameMode.SURVIVAL:
                    comBoxDifficulty.Items.AddRange(Model.Map.Maps[comBoxMap.SelectedItem.ToString()].SurvivalAvailableMapNames);
                    break;

                default:
                    break;
            }

            comBoxDifficulty.SelectedIndex = 0;

            GameInfo.Battleground.GameMode = Model.GameMode.GameModes[comBoxGameMode.SelectedItem.ToString()];
        }


        private void comBoxDifficulty_SelectedIndexChanged(object sender, EventArgs e)
        {
            comBoxExtraDifficulty.Items.Clear();
            comBoxExtraDifficulty.Items.Add(noExtraDifficulty);
            comBoxExtraDifficulty.SelectedItem = noExtraDifficulty;

            string selectedDifficulty = comBoxDifficulty.SelectedItem.ToString();

            GameInfo.Battleground.Difficulty = Model.Difficulty.Difficulties[selectedDifficulty];

            switch (selectedDifficulty)
            {
                case Names.Difficulty.ENDLESS:
                    foreach (string ed in Model.Difficulty.EndlessExtraDifficulties.Keys)
                    {
                        comBoxExtraDifficulty.Items.Add(ed);
                    }

                    break;

                case Names.Difficulty.APPRENTICE:
                    foreach (string ed in Model.Difficulty.ApprenticeExtraDifficulties.Keys)
                    {
                        comBoxExtraDifficulty.Items.Add(ed);
                    }

                    break;

                case Names.Difficulty.WAR_MAGE:
                    foreach (string ed in Model.Difficulty.WarMageExtraDifficulties.Keys)
                    {
                        comBoxExtraDifficulty.Items.Add(ed);
                    }

                    break;

                case Names.Difficulty.MASTER:
                    foreach (string ed in Model.Difficulty.MasterExtraDifficulties.Keys)
                    {
                        comBoxExtraDifficulty.Items.Add(ed);
                    }

                    break;

                case Names.Difficulty.RIFT_LORD:
                    foreach (string ed in Model.Difficulty.RiftLordExtraDifficulties.Keys)
                    {
                        comBoxExtraDifficulty.Items.Add(ed);
                    }

                    break;

                default:
                    break;
            }
        }

        private void comBoxExtraDifficulty_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDifficulty = comBoxDifficulty.SelectedItem.ToString();
            string selectedExtraDifficulty = comBoxExtraDifficulty.SelectedItem.ToString();

            GameInfo.Battleground.Difficulty = selectedExtraDifficulty.Equals(noExtraDifficulty) ? Model.Difficulty.Difficulties[selectedDifficulty] : Model.Difficulty.Difficulties[selectedExtraDifficulty];
        }

        // TODO to change when more heroes are playable
        private readonly List<string> CUSTOM_LOADOUT_HERO_NAMES = new List<string>() { Names.Hero.MAXIMILIAN, Names.Hero.HOGARTH, Names.Hero.GABRIELLA, Names.Hero.SMOLDER, Names.Hero.IVY, Names.Hero.BIONKA, Names.Hero.OZIEL, Names.Hero.BLOODSPIKE, Names.Hero.BLACKPAW, Names.Hero.BRASS, Names.Hero.CYGNUS, Names.Hero.MIDNIGHT, Names.Hero.YI_LIN, Names.Hero.DEADEYE, Names.Hero.DOBBIN, };
        private void comBoxHero_SelectedIndexChanged(object sender, EventArgs e)
        {
            comBoxSkin.Items.Clear();

            string selectedHero = comBoxHero.SelectedItem.ToString();
            GameInfo.Loadout.Hero = Model.Hero.Heroes[selectedHero];
            btnLoadoutEditor.Enabled = CUSTOM_LOADOUT_HERO_NAMES.Contains(selectedHero);
            comBoxSkin.Enabled = CUSTOM_LOADOUT_HERO_NAMES.Contains(selectedHero);

            if (GameInfo.Loadout.Hero.Skins != null)
            {

                foreach (string s in GameInfo.Loadout.Hero.Skins.Select(s => s.Name).ToArray())
                {
                    comBoxSkin.Items.Add(s);
                }

                comBoxSkin.SelectedItem = GameInfo.Loadout.Hero.Skins[0].Name;
                GameInfo.Loadout.Hero = Model.Hero.Heroes[selectedHero];
            }
        }

        private void comBoxSkin_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSkin = comBoxSkin.SelectedItem.ToString();
            GameInfo.Loadout.Skin = Model.Skin.Skins[selectedSkin];
        }

        private void comBoxDye_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDye = comBoxDye.SelectedItem.ToString();
            GameInfo.Loadout.Dye = Model.Dye.Dyes[selectedDye];
        }

        private static bool IsFirstRun()
        {
            return !Settings.Instance.ContainsKey("FirstRun");
        }

        private void btnResetConfig_Click(object sender, EventArgs e)
        {
            GameLauncher.FirstLaunchInitialization();
        }

        private void btnMods_Click(object sender, EventArgs e)
        {
            ModLoaderForm mlf = new ModLoaderForm();
            mlf.Show();
        }
    }
}

