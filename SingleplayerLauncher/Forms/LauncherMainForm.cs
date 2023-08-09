using Newtonsoft.Json.Linq;
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

        private readonly List<ComboBox> ComBoxLoadoutSlots;
        private readonly List<ComboBox> ComBoxGuardianSlots;

        public LauncherMainForm()
        {
            if (IsFirstRun())
            {
                GameLauncher.FirstLaunchInitialization();
            }
            InitializeComponent();

            ComBoxLoadoutSlots = new List<ComboBox>()
            {
                comBoxLoadoutSlot1, comBoxLoadoutSlot2, comBoxLoadoutSlot3,
                comBoxLoadoutSlot4, comBoxLoadoutSlot5, comBoxLoadoutSlot6,
                comBoxLoadoutSlot7, comBoxLoadoutSlot8, comBoxLoadoutSlot9
            };

            ComBoxGuardianSlots = new List<ComboBox>()
            {
                comBoxGuardianSlot1, comBoxGuardianSlot2
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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

            comBoxHero.SelectedItem = Settings.Instance.ContainsKey("hero") ? Settings.Instance["hero"] : DefaultValues.SelectedHero;
            comBoxSkin.SelectedItem = Settings.Instance.ContainsKey("skin") ? Settings.Instance["skin"] : DefaultValues.SelectedSkin;
            comBoxDye.SelectedItem = Settings.Instance.ContainsKey("dye") ? Settings.Instance["dye"] : DefaultValues.SelectedDye;

            comBoxGameMode.SelectedItem = Settings.Instance.ContainsKey("gameMode") ? Settings.Instance["gameMode"] : DefaultValues.SelectedGameMode;
            comBoxDifficulty.SelectedItem = Settings.Instance.ContainsKey("difficulty") ? Settings.Instance["difficulty"] : DefaultValues.SelectedDifficulty;
            comBoxBattleground.SelectedItem = Settings.Instance.ContainsKey("battleground") ? Settings.Instance["battleground"] : DefaultValues.SelectedBattleground;
            comBoxExtraDifficulty.SelectedItem = Settings.Instance.ContainsKey("extraDifficulty") ? Settings.Instance["extraDifficulty"] : noExtraDifficulty;

            chkDebug.Checked = Settings.Instance.ContainsKey("debug") && (bool)Settings.Instance["debug"];
            chk_modsEnabled.Checked = Settings.Instance.ContainsKey("modsEnabled") && (bool)Settings.Instance["modsEnabled"];
            modsGroupBox.Enabled = chk_modsEnabled.Checked;

            chkGodMode.Checked = Settings.Instance.ContainsKey("GodMode") && (bool)Settings.Instance["GodMode"];
            chkShowTrapDamageFlyoffs.Checked = Settings.Instance.ContainsKey("ShowTrapDamage") && (bool)Settings.Instance["ShowTrapDamage"];
            chkNoTrapCap.Checked = Settings.Instance.ContainsKey("NoTrapCap") && (bool)Settings.Instance["NoTrapCap"];
            chkInvincibleBarricades.Checked = Settings.Instance.ContainsKey("InvincibleBarricades") && (bool)Settings.Instance["InvincibleBarricades"];
            chkTrapsInTraps.Checked = Settings.Instance.ContainsKey("TrapsInTraps") && (bool)Settings.Instance["TrapsInTraps"];
            chkHardcore.Checked = Settings.Instance.ContainsKey("Hardcore") && (bool)Settings.Instance["Hardcore"];
            chkNoLimitUniqueTraps.Checked = Settings.Instance.ContainsKey("NoLimitUniqueTraps") && (bool)Settings.Instance["NoLimitUniqueTraps"];
            chkNoTrapGrid.Checked = Settings.Instance.ContainsKey("NoTrapGrid") && (bool)Settings.Instance["NoTrapGrid"];
            chkTrapsAnySurface.Checked = Settings.Instance.ContainsKey("TrapsAnySurface") && (bool)Settings.Instance["TrapsAnySurface"];
            startingCoinInput.Value = Settings.Instance.ContainsKey("StartingCoin") ? Int32.Parse((string)Settings.Instance["StartingCoin"]) : GameInfo.Battleground.Map.StartingCoin;


            PopulateSlots(ComBoxLoadoutSlots, Model.Trap.Traps.Keys.ToList());
            PopulateSlots(ComBoxLoadoutSlots, Model.Gear.Gears.Keys.ToList());
            PopulateSlots(ComBoxGuardianSlots, Model.Guardian.Guardians.Keys.ToList());

            if (Settings.Instance.ContainsKey("loadout"))
            {
                GameInfo.Loadout.SlotItems = ((JArray)Settings.Instance["loadout"]).ToObject<string[]>().Select(lsi => SlotItems[lsi]).ToArray();
            }

            if (Settings.Instance.ContainsKey("guardians"))
            {
                GameInfo.Loadout.Guardians = ((JArray)Settings.Instance["guardians"]).ToObject<string[]>().Select(lgi => Model.Guardian.Guardians[lgi]).ToArray();
            }

            SetCurrentLoadout();
            SetCurrenGuardians();
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
            Settings.Instance["map"] = comBoxBattleground.SelectedItem;
            Settings.Instance["gameMode"] = comBoxGameMode.SelectedItem;
            Settings.Instance["difficulty"] = comBoxDifficulty.SelectedItem;
            Settings.Instance["extraDifficulty"] = comBoxExtraDifficulty.SelectedItem;
            Settings.Instance["debug"] = chkDebug.Checked;
            Settings.Save();
        }

        private void comBoxBattleground_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedBattleground = comBoxBattleground.SelectedItem.ToString();

            switch (comBoxGameMode.SelectedItem)
            {
                case Names.GameMode.ENDLESS:
                    GameInfo.Battleground = Model.Endless.EndlessBattlegrounds[selectedBattleground];
                    break;

                case Names.GameMode.SURVIVAL:
                    string selectedDifficulty = comBoxDifficulty.SelectedItem.ToString();
                    Dictionary<string, Survival> battlegrounds = Model.Survival.SurvivalBattlegroundsByDifficulty[selectedDifficulty];
                    GameInfo.Battleground = battlegrounds[selectedBattleground];
                    break;

                default:
                    break;
            }
        }

        private void comBoxGameMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            comBoxDifficulty.Items.Clear();
            comBoxBattleground.Items.Clear();

            switch (comBoxGameMode.SelectedItem)
            {
                case Names.GameMode.ENDLESS:
                    comBoxDifficulty.Enabled = false;
                    comBoxBattleground.Items.AddRange(Model.Endless.EndlessBattlegrounds.Keys.ToArray());
                    comBoxBattleground.SelectedIndex = 0;

                    comBoxExtraDifficulty.Items.Clear();
                    comBoxExtraDifficulty.Items.Add(noExtraDifficulty);
                    comBoxExtraDifficulty.SelectedItem = noExtraDifficulty;
                    comBoxExtraDifficulty.Items.AddRange(Model.Difficulty.EndlessExtraDifficulties.Keys.ToArray());
                    break;

                case Names.GameMode.SURVIVAL:
                    comBoxDifficulty.Enabled = true;
                    comBoxDifficulty.Items.AddRange(Model.Difficulty.SurvivalDifficulties.Keys.ToArray());
                    comBoxDifficulty.SelectedIndex = 0;
                    break;

                default:
                    break;
            }

            GameInfo.Battleground.GameMode = Model.GameMode.GameModes[comBoxGameMode.SelectedItem.ToString()];
        }


        private void comBoxDifficulty_SelectedIndexChanged(object sender, EventArgs e)
        {
            comBoxBattleground.Items.Clear();
            comBoxExtraDifficulty.Items.Clear();
            comBoxExtraDifficulty.Items.Add(noExtraDifficulty);
            comBoxExtraDifficulty.SelectedItem = noExtraDifficulty;

            string selectedDifficulty = comBoxDifficulty.SelectedItem.ToString();
            GameInfo.Battleground.Difficulty = Model.Difficulty.Difficulties[selectedDifficulty];

            if (Model.Survival.SurvivalBattlegroundsByDifficulty.TryGetValue(selectedDifficulty, out var battlegrounds))
            {
                comBoxBattleground.Items.AddRange(battlegrounds.Keys.ToArray());
                comBoxBattleground.SelectedIndex = 0;
            }

            if (Model.Difficulty.ExtraDifficultiesByDifficulty.TryGetValue(selectedDifficulty, out var extraDifficulties))
            {
                comBoxExtraDifficulty.Items.AddRange(extraDifficulties.Keys.ToArray());
            }
        }

        private void comBoxExtraDifficulty_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedExtraDifficulty = comBoxExtraDifficulty.SelectedItem.ToString();

            if (!comBoxExtraDifficulty.SelectedItem.ToString().Equals(noExtraDifficulty))
            {
                GameInfo.Battleground.Difficulty = Model.Difficulty.Difficulties[selectedExtraDifficulty];
            }
        }

        // TODO to change when more heroes are playable
        private readonly List<string> CUSTOM_LOADOUT_HERO_NAMES = new List<string>() { Names.Hero.MAXIMILIAN, Names.Hero.HOGARTH, Names.Hero.GABRIELLA, Names.Hero.SMOLDER, Names.Hero.IVY, Names.Hero.BIONKA, Names.Hero.OZIEL, Names.Hero.BLOODSPIKE, Names.Hero.BLACKPAW, Names.Hero.BRASS, Names.Hero.CYGNUS, Names.Hero.MIDNIGHT, Names.Hero.YI_LIN, Names.Hero.DEADEYE, Names.Hero.DOBBIN, };
        private void comBoxHero_SelectedIndexChanged(object sender, EventArgs e)
        {
            comBoxSkin.Items.Clear();

            string selectedHero = comBoxHero.SelectedItem.ToString();
            GameInfo.Loadout.Hero = Model.Hero.Heroes[selectedHero];
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

        private void chkGodMode_CheckedChanged(object sender, EventArgs e)
        {
            Mods.Mods.GodMode.IsEnabled = chkGodMode.Checked;
            Settings.Instance["GodMode"] = chkGodMode.Checked;
            Settings.Save();
        }

        private void chkNoTrapCap_CheckedChanged(object sender, EventArgs e)
        {
            Mods.Mods.NoTrapCap.IsEnabled = chkNoTrapCap.Checked;
            Settings.Instance["NoTrapCap"] = chkNoTrapCap.Checked;
            Settings.Save();
        }

        private void chkTrapsInTraps_CheckedChanged(object sender, EventArgs e)
        {
            Mods.Mods.TrapsInTraps.IsEnabled = chkTrapsInTraps.Checked;
            Settings.Instance["TrapsInTraps"] = chkTrapsInTraps.Checked;
            Settings.Save();
        }

        private void StartingCoinInput_ValueChanged(object sender, EventArgs e)
        {
            GameInfo.Battleground.StartingCoin = (int)startingCoinInput.Value;
            Settings.Instance["StartingCoin"] = startingCoinInput.Value.ToString();
            Settings.Save();
        }

        private void chkNoLimitUniqueTraps_CheckedChanged(object sender, EventArgs e)
        {
            Mods.Mods.NoLimitUniqueTraps.IsEnabled = chkNoLimitUniqueTraps.Checked;
            Settings.Instance["NoLimitUniqueTraps"] = chkNoLimitUniqueTraps.Checked;
            Settings.Save();
        }

        private void chkTrapsAnySurface_CheckedChanged(object sender, EventArgs e)
        {
            Mods.Mods.TrapsAnySurface.IsEnabled = chkTrapsAnySurface.Checked;
            Settings.Instance["TrapsAnySurface"] = chkTrapsAnySurface.Checked;
            Settings.Save();
        }

        private void chkNoTrapGrid_CheckedChanged(object sender, EventArgs e)
        {
            Mods.Mods.NoTrapGrid.IsEnabled = chkNoTrapGrid.Checked;
            Settings.Instance["NoTrapGrid"] = chkNoTrapGrid.Checked;
            Settings.Save();
        }

        private void chkHardcore_CheckedChanged(object sender, EventArgs e)
        {
            Mods.Mods.Hardcore.IsEnabled = chkHardcore.Checked;
            Settings.Instance["Hardcore"] = chkHardcore.Checked;
            Settings.Save();
        }

        private void chkInvincibleBarricades_CheckedChanged(object sender, EventArgs e)
        {
            Mods.Mods.InvincibleBarricades.IsEnabled = chkInvincibleBarricades.Checked;
            Settings.Instance["InvincibleBarricades"] = chkInvincibleBarricades.Checked;
            Settings.Save();
        }

        private void chkShowTrapDamageFlyoffs_CheckedChanged(object sender, EventArgs e)
        {
            Mods.Mods.ShowTrapDamageFlyoffs.IsEnabled = chkShowTrapDamageFlyoffs.Checked;
            Settings.Instance["ShowTrapDamage"] = chkShowTrapDamageFlyoffs.Checked;
            Settings.Save();
        }

        private void chk_modsEnabled_CheckedChanged(object sender, EventArgs e)
        {
            modsGroupBox.Enabled = chk_modsEnabled.Checked;
            Settings.Instance["modsEnabled"] = chk_modsEnabled.Checked;
            Settings.Save();
        }

        private void PopulateSlots(List<ComboBox> comBoxSlotList, List<String> entryList)
        {
            foreach (ComboBox comBoxSlot in comBoxSlotList)
            {
                foreach (string entry in entryList)
                {
                    comBoxSlot.Items.Add(entry);
                }
            }
        }

        private void SetCurrenGuardians()
        {
            for (int i = 0; i < Loadout.GUARDIAN_SLOT_COUNT; i++)
            {
                ComBoxGuardianSlots[i].SelectedItem = GameInfo.Loadout.Guardians[i].Name;
            }
        }

        private void SaveGuardians()
        {
            List<string> guardianNames = new List<string>();
            for (int i = 0; i < Loadout.GUARDIAN_SLOT_COUNT; i++)
            {
                string guardianName = ComBoxGuardianSlots[i].Text;
                guardianNames.Add(guardianName);
                if (guardianName.Length > 0)
                {
                    GameInfo.Loadout.Guardians[i] = Guardian.Guardians[guardianName];
                }
            }
            Settings.Instance["guardians"] = guardianNames;
            Settings.Save();
        }

        private void SetCurrentLoadout()
        {
            for (int i = 0; i < Loadout.SLOT_ITEMS_COUNT; i++)
            {
                ComBoxLoadoutSlots[i].SelectedItem = GameInfo.Loadout.SlotItems[i].Name;
            }
        }

        private static readonly Dictionary<string, SlotItem> SlotItems =
            new List<Dictionary<string, SlotItem>>() { Gear.Gears, Trap.Traps }
                .SelectMany(dict => dict)
                .ToDictionary(pair => pair.Key, pair => pair.Value);

        private void SaveLoadout()
        {
            List<string> slotItemNames = new List<string>();
            for (int i = 0; i < Loadout.SLOT_ITEMS_COUNT; i++)
            {
                string slotItemName = ComBoxLoadoutSlots[i].Text;
                slotItemNames.Add(slotItemName);
                if (slotItemName.Length > 0)
                {
                    GameInfo.Loadout.SlotItems[i] = SlotItems[slotItemName];
                }
            }
            Settings.Instance["loadout"] = slotItemNames;
            Settings.Save();
        }

        private void comBoxLoadoutSlot1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveLoadout();
        }

        private void comBoxLoadoutSlot2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveLoadout();
        }

        private void comBoxLoadoutSlot3_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveLoadout();
        }

        private void comBoxLoadoutSlot4_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveLoadout();
        }

        private void comBoxLoadoutSlot5_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveLoadout();
        }

        private void comBoxLoadoutSlot6_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveLoadout();
        }

        private void comBoxLoadoutSlot7_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveLoadout();
        }

        private void comBoxLoadoutSlot8_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveLoadout();
        }

        private void comBoxLoadoutSlot9_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveLoadout();
        }

        private void comBoxGuardianSlot1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveGuardians();
        }

        private void comBoxGuardianSlot2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveGuardians();
        }
    }
}

