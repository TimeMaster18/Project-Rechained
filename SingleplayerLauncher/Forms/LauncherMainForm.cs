﻿using Newtonsoft.Json.Linq;
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
        private readonly List<List<ComboBox>> ComBoxTrapPartsSlots;
        private readonly List<ComboBox> ComBoxGuardianSlots;
        private readonly List<ComboBox> ComBoxConsumableSlots;
        private readonly List<ComboBox> ComBoxTraitSlots;

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

            ComBoxTrapPartsSlots = new List<List<ComboBox>>()
            {
                new List<ComboBox> { comBoxTrapPartsSlot1Part1, comBoxTrapPartsSlot1Part2, comBoxTrapPartsSlot1Part3 },
                new List<ComboBox> { comBoxTrapPartsSlot2Part1, comBoxTrapPartsSlot2Part2, comBoxTrapPartsSlot2Part3 },
                new List<ComboBox> { comBoxTrapPartsSlot3Part1, comBoxTrapPartsSlot3Part2, comBoxTrapPartsSlot3Part3 },
                new List<ComboBox> { comBoxTrapPartsSlot4Part1, comBoxTrapPartsSlot4Part2, comBoxTrapPartsSlot4Part3 },
                new List<ComboBox> { comBoxTrapPartsSlot5Part1, comBoxTrapPartsSlot5Part2, comBoxTrapPartsSlot5Part3 },
                new List<ComboBox> { comBoxTrapPartsSlot6Part1, comBoxTrapPartsSlot6Part2, comBoxTrapPartsSlot6Part3 },
                new List<ComboBox> { comBoxTrapPartsSlot7Part1, comBoxTrapPartsSlot7Part2, comBoxTrapPartsSlot7Part3 },
                new List<ComboBox> { comBoxTrapPartsSlot8Part1, comBoxTrapPartsSlot8Part2, comBoxTrapPartsSlot8Part3 },
                new List<ComboBox> { comBoxTrapPartsSlot9Part1, comBoxTrapPartsSlot9Part2, comBoxTrapPartsSlot9Part3 }
            };

            ComBoxGuardianSlots = new List<ComboBox>()
            {
                comBoxGuardianSlot1, comBoxGuardianSlot2
            };

            ComBoxConsumableSlots = new List<ComboBox>()
            {
                comBoxConsumableSlot1, comBoxConsumableSlot2
            };

            ComBoxTraitSlots = new List<ComboBox>()
            {
                comboxTraitGreenSlot, comboxTraitBlueSlot, comboxTraitYellowSlot, comboxTraitNoBonusSlot // This order must match the order in Loadout.cs for simplicity
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string language in Language.GetLanguageMap().Values)
            {
                comBoxLanguage.Items.Add(language);
            }

            comBoxLanguage.SelectedItem = Settings.Instance.ContainsKey("language") ? Settings.Instance["language"] : DefaultValues.SelectedLanguage;

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
            chkRunAs32.Checked = Settings.Instance.ContainsKey("RunAs32") && (bool)Settings.Instance["RunAs32"];
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
            chkEnhancedTrapRotation.Checked = Settings.Instance.ContainsKey("EnhancedTrapRotation") && (bool)Settings.Instance["EnhancedTrapRotation"];
            chkSellTrapsAnytime.Checked = Settings.Instance.ContainsKey("SellTrapsAnytime") && (bool)Settings.Instance["SellTrapsAnytime"];

            chkCustomStartCoin.Checked = Settings.Instance.ContainsKey("CustomStartCoinEnabled") && (bool)Settings.Instance["CustomStartCoinEnabled"];
            startingCoinInput.Enabled = Settings.Instance.ContainsKey("CustomStartCoinEnabled") && (bool)Settings.Instance["CustomStartCoinEnabled"];
            startingCoinInput.Value = Settings.Instance.ContainsKey("CustomStartCoinEnabled") && Settings.Instance.ContainsKey("StartingCoin") ? Int32.Parse((string)Settings.Instance["StartingCoin"]) : GameInfo.Battleground.Map.StartingCoin;

            // TODO: check if loading from JSON is possible with embedded: https://github.com/Fody/Costura
            PopulateSlots(ComBoxLoadoutSlots, Model.Trap.Traps.Keys.ToList());
            PopulateSlots(ComBoxLoadoutSlots, Model.Gear.Gears.Keys.ToList());
            PopulateSlots(ComBoxGuardianSlots, Model.Guardian.Guardians.Keys.ToList());
            PopulateSlots(ComBoxConsumableSlots, Model.Consumable.Consumables.Keys.ToList());
            PopulateSlots(ComBoxTraitSlots, Model.Trait.Traits.Keys.ToList());


            // Load settings from json
            if (Settings.Instance.ContainsKey("loadout"))
            {
                GameInfo.Loadout.SlotItems = ((JArray)Settings.Instance["loadout"]).ToObject<string[]>().Select(lsi => SlotItems[lsi]).ToArray();
            }

            if (Settings.Instance.ContainsKey("trapParts"))
            {
                var trapPartsArray = (JArray)Settings.Instance["trapParts"];

                trapPartsArray
                    .Select((row, i) => ((JArray)row)
                        .Select((tp, j) => new { i, j, tp = tp.ToString() }))
                    .SelectMany(x => x)
                    .ToList()
                    .ForEach(item => GameInfo.Loadout.TrapParts[item.i, item.j] = string.IsNullOrEmpty(item.tp) ? null : Model.TrapPart.TrapParts[item.tp]);
            }

            if (Settings.Instance.ContainsKey("guardians"))
            {
                GameInfo.Loadout.Guardians = ((JArray)Settings.Instance["guardians"]).ToObject<string[]>().Select(lgi => Model.Guardian.Guardians[lgi]).ToArray();
            }

            if (Settings.Instance.ContainsKey("consumables"))
            {
                GameInfo.Loadout.Consumables = ((JArray)Settings.Instance["consumables"]).ToObject<string[]>().Select(lci => Model.Consumable.Consumables[lci]).ToArray();
            }

            if (Settings.Instance.ContainsKey("traits"))
            {
                GameInfo.Loadout.Traits = ((JArray)Settings.Instance["traits"]).ToObject<string[]>().Select(lti => Model.Trait.Traits[lti]).ToArray();
            }

            SetCurrentLoadout();
            SetCurrentTrapParts();
            SetCurrenGuardians();
            SetCurrentConsumables();
            SetCurrentTraits();
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            btnLaunch.Text = "Game will start soon...";
            GameLauncher.ApplyChanges();

            SaveSettings();


            btnLaunch.Text = "Game running... (Launcher disabled)";
            GameLauncher.StartGame(chkDebug.Checked, chkRunAs32.Checked, comBoxLanguage.Text);
            btnLaunch.Text = "Launch";
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
            Settings.Instance["runAs32"] = chkRunAs32.Checked;
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

        private void comBoxHero_SelectedIndexChanged(object sender, EventArgs e)
        {
            comBoxSkin.Items.Clear();

            string selectedHero = comBoxHero.SelectedItem.ToString();
            GameInfo.Loadout.Hero = Model.Hero.Heroes[selectedHero];

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
            Mods.Mods.StartingCoinOverride.Value = (int)startingCoinInput.Value;
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

        private void SetCurrentConsumables()
        {
            for (int i = 0; i < Loadout.CONSUMABLE_SLOT_COUNT; i++)
            {
                ComBoxConsumableSlots[i].SelectedItem = GameInfo.Loadout.Consumables[i].Name;
            }
        }

        private void SetCurrentTraits()
        {
            TraitComboBoxHelper comboBoxHelper = new TraitComboBoxHelper(Trait.Traits);
            for (int i = 0; i < Loadout.TRAIT_SLOT_COUNT; i++)
            {
                comboBoxHelper.InitializeComboBox(ComBoxTraitSlots[i]);
                ComBoxTraitSlots[i].SelectedItem = GameInfo.Loadout.Traits[i].Name;
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

        private void SaveConsumables()
        {
            List<string> consumableNames = new List<string>();
            for (int i = 0; i < Loadout.CONSUMABLE_SLOT_COUNT; i++)
            {
                string consumableName = ComBoxConsumableSlots[i].Text;
                consumableNames.Add(consumableName);
                if (consumableName.Length > 0)
                {
                    GameInfo.Loadout.Consumables[i] = Consumable.Consumables[consumableName];
                }
            }
            Settings.Instance["consumables"] = consumableNames;
            Settings.Save();
        }

        private void SaveTraits()
        {
            List<string> traitNames = new List<string>();
            for (int i = 0; i < Loadout.TRAIT_SLOT_COUNT; i++)
            {
                string traitName = ComBoxTraitSlots[i].Text;
                traitNames.Add(traitName);
                if (traitName.Length > 0)
                {
                    GameInfo.Loadout.Traits[i] = Trait.Traits[traitName];
                }
            }
            Settings.Instance["traits"] = traitNames;
            Settings.Save();
        }

        private void SetCurrentLoadout()
        {
            SlotItemComboBoxHelper comboBoxHelper = new SlotItemComboBoxHelper(SlotItems);
            for (int i = 0; i < Loadout.SLOT_ITEMS_COUNT; i++)
            {
                comboBoxHelper.InitializeComboBox(ComBoxLoadoutSlots[i]);
                ComBoxLoadoutSlots[i].SelectedItem = GameInfo.Loadout.SlotItems[i].Name;
            }
        }

        private void SetCurrentTrapParts()
        {
            TrapPartComboBoxHelper comboBoxHelper = new TrapPartComboBoxHelper(TrapPart.TrapParts);
            for (int i = 0; i < Loadout.SLOT_ITEMS_COUNT; i++)
            {
                for (int j = 0; j < Loadout.TRAP_PART_SLOT_COUNT; j++)
                {
                    if (i < ComBoxTrapPartsSlots.Count && j < ComBoxTrapPartsSlots[i].Count)
                    {
                        comboBoxHelper.InitializeComboBox(ComBoxTrapPartsSlots[i][j]);
                        TrapPart current = GameInfo.Loadout.TrapParts[i,j];
                        ComBoxTrapPartsSlots[i][j].SelectedItem = current == null ? null : current.Name;
                    }
                }
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

        private void SaveTrapParts()
        {
            List<List<string>> trapPartNames = new List<List<string>>();

            for (int i = 0; i < ComBoxTrapPartsSlots.Count; i++)
            {
                List<string> partNames = new List<string>();

                for (int j = 0; j < ComBoxTrapPartsSlots[i].Count; j++)
                {
                    string partName = ComBoxTrapPartsSlots[i][j].Text;
                    partNames.Add(partName);

                    if (partName.Length > 0)
                    {
                        GameInfo.Loadout.TrapParts[i,j] = TrapPart.TrapParts[partName];
                    }
                }

                trapPartNames.Add(partNames);
            }

            Settings.Instance["trapParts"] = trapPartNames;
            Settings.Save();
        }

        private void comBoxLoadoutSlot1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveLoadout();
            AdjustTrapPartsComBoxes(sender, 1 - 1);
        }

        private void comBoxLoadoutSlot2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveLoadout();
            AdjustTrapPartsComBoxes(sender, 2 - 1);
        }

        private void comBoxLoadoutSlot3_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveLoadout();
            AdjustTrapPartsComBoxes(sender, 3 - 1);
        }

        private void comBoxLoadoutSlot4_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveLoadout();
            AdjustTrapPartsComBoxes(sender, 4 - 1);
        }

        private void comBoxLoadoutSlot5_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveLoadout();
            AdjustTrapPartsComBoxes(sender, 5 - 1);
        }

        private void comBoxLoadoutSlot6_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveLoadout();
            AdjustTrapPartsComBoxes(sender, 6 - 1);
        }

        private void comBoxLoadoutSlot7_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveLoadout();
            AdjustTrapPartsComBoxes(sender, 7 - 1);
        }

        private void comBoxLoadoutSlot8_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveLoadout();
            AdjustTrapPartsComBoxes(sender, 8 - 1);
        }

        private void comBoxLoadoutSlot9_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveLoadout();
            AdjustTrapPartsComBoxes(sender, 9 - 1);
        }

        private void AdjustTrapPartsComBoxes(object sender, int slotIdx)
        {
            String selected = ((ComboBox)sender).SelectedItem?.ToString();
            Trap trap = Trap.Traps.ContainsKey(selected) ? (Trap)Trap.Traps[selected] : null;
            bool isTrap = trap != null;

            for (int i = 0; i < ComBoxTrapPartsSlots[slotIdx].Count; i++)
            {
                ComboBox trapPartComBox = ComBoxTrapPartsSlots[slotIdx][i];
                trapPartComBox.Enabled = isTrap;
                if (trapPartComBox.Enabled)
                {
                    var trapPartNames = TrapPart.GetTrapPartsBySlotType(trap.TrapPartSlots[i])
                                                .Select(tp => tp.Name)
                                                .ToList();
                    trapPartNames.Insert(0, "");
                    trapPartComBox.Items.Clear();
                    PopulateSlots(new List<ComboBox> { trapPartComBox }, trapPartNames);
                } else
                {
                    trapPartComBox.SelectedItem = null;
                }
            }
        }

        private void comBoxTrapPartsSlot1Part1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveTrapParts();
        }

        private void comBoxGuardianSlot1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveGuardians();
        }

        private void comBoxGuardianSlot2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveGuardians();
        }

        private void comBoxConsumableSlot1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveConsumables();
        }

        private void comBoxConsumableSlot2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveConsumables();
        }

        private void comboxTraitGreenSlot_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveTraits();
        }

        private void comboxTraitBlueSlot_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveTraits();
        }

        private void comboxTraitYellowSlot_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveTraits();
        }

        private void comboxTraitNoBonusSlot_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveTraits();
        }

        private void chkCustomStartCoin_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkCustomStartCoin.Checked)
            {
                GameInfo.Battleground.StartingCoin = 0;
            }
            startingCoinInput.Enabled = chkCustomStartCoin.Checked;
            Mods.Mods.StartingCoinOverride.IsEnabled = chkCustomStartCoin.Checked;
            Settings.Instance["CustomStartCoinEnabled"] = chkCustomStartCoin.Checked;
            Settings.Save();
        }

        private void chkSellTrapsAnytime_CheckedChanged(object sender, EventArgs e)
        {
            Mods.Mods.SellTrapsAnytime.IsEnabled = chkSellTrapsAnytime.Checked;
            Settings.Instance["SellTrapsAnytime"] = chkSellTrapsAnytime.Checked;
            Settings.Save();
        }

        private void chkEnhancedTrapRotation_CheckedChanged(object sender, EventArgs e)
        {
            Mods.Mods.EnhancedTrapRotation.IsEnabled = chkEnhancedTrapRotation.Checked;
            Settings.Instance["EnhancedTrapRotation"] = chkEnhancedTrapRotation.Checked;
            Settings.Save();
        }

        private void comBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedLanguage = comBoxLanguage.SelectedItem.ToString();
            Settings.Instance["language"] = selectedLanguage;
            Settings.Save();
        }

        private void comBoxTrapPartsSlot1Part1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SaveTrapParts();
        }

        private void comBoxTrapPartsSlot1Part2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveTrapParts();
        }

        private void comBoxTrapPartsSlot1Part3_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveTrapParts();
        }

        private void comBoxTrapPartsSlot2Part3_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveTrapParts();
        }

        private void comBoxTrapPartsSlot2Part2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveTrapParts();
        }

        private void comBoxTrapPartsSlot2Part1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveTrapParts();
        }

        private void comBoxTrapPartsSlot3Part1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveTrapParts();
        }

        private void comBoxTrapPartsSlot3Part2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveTrapParts();
        }

        private void comBoxTrapPartsSlot3Part3_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveTrapParts();
        }

        private void comBoxTrapPartsSlot4Part1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveTrapParts();
        }

        private void comBoxTrapPartsSlot4Part2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveTrapParts();
        }

        private void comBoxTrapPartsSlot4Part3_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveTrapParts();
        }

        private void comBoxTrapPartsSlot5Part3_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveTrapParts();
        }

        private void comBoxTrapPartsSlot5Part2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveTrapParts();
        }

        private void comBoxTrapPartsSlot5Part1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveTrapParts();
        }

        private void comBoxTrapPartsSlot6Part1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveTrapParts();
        }

        private void comBoxTrapPartsSlot6Part2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveTrapParts();
        }

        private void comBoxTrapPartsSlot6Part3_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveTrapParts();
        }

        private void comBoxTrapPartsSlot7Part3_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveTrapParts();
        }

        private void comBoxTrapPartsSlot7Part2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveTrapParts();
        }

        private void comBoxTrapPartsSlot7Part1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveTrapParts();
        }

        private void comBoxTrapPartsSlot8Part1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveTrapParts();
        }

        private void comBoxTrapPartsSlot8Part2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveTrapParts();
        }

        private void comBoxTrapPartsSlot8Part3_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveTrapParts();
        }

        private void comBoxTrapPartsSlot9Part3_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveTrapParts();
        }

        private void comBoxTrapPartsSlot9Part2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveTrapParts();
        }

        private void comBoxTrapPartsSlot9Part1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveTrapParts();
        }
    }
}

