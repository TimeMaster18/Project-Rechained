using SingleplayerLauncher.Model;
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
            if (Settings.Instance.FirstRun)
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
            // Launcher settings
            foreach (string language in Language.GetLanguageMap().Values)
            {
                comBoxLanguage.Items.Add(language);
            }
            chkDebug.Checked = Settings.Instance.Debug;
            chkRunAs32.Checked = Settings.Instance.RunAs32;
            comBoxLanguage.SelectedItem = Settings.Instance.Language;

            // Game settings
            foreach (string gm in Model.GameMode.GameModes.Keys)
            {
                comBoxGameMode.Items.Add(gm);
            }

            chk_modsEnabled.Checked = GameConfig.Instance.ModsEnabled;
            modsGroupBox.Enabled = GameConfig.Instance.ModsEnabled;

            // TODO Fix loading of below game settings (it gets ovewritten from the onChange event)
            comBoxExtraDifficulty.SelectedItem = GameConfig.Instance.ExtraDifficulty;
            comBoxDifficulty.SelectedItem = GameConfig.Instance.Difficulty;
            comBoxBattleground.SelectedItem = GameConfig.Instance.Battleground;
            comBoxGameMode.SelectedItem = GameConfig.Instance.GameMode;

            // Mods
            chkGodMode.Checked = GameConfig.Instance.GodMode;
            chkShowTrapDamageFlyoffs.Checked = GameConfig.Instance.ShowTrapDamage;
            chkNoTrapCap.Checked = GameConfig.Instance.NoTrapCap;
            chkInvincibleBarricades.Checked = GameConfig.Instance.InvincibleBarricades;
            chkTrapsInTraps.Checked = GameConfig.Instance.TrapsInTraps;
            chkHardcore.Checked = GameConfig.Instance.Hardcore;
            chkNoLimitUniqueTraps.Checked = GameConfig.Instance.NoLimitUniqueTraps;
            chkNoTrapGrid.Checked = GameConfig.Instance.NoTrapGrid;
            chkTrapsAnySurface.Checked = GameConfig.Instance.TrapsAnySurface;
            chkEnhancedTrapRotation.Checked = GameConfig.Instance.EnhancedTrapRotation;
            chkSellTrapsAnytime.Checked = GameConfig.Instance.SellTrapsAnytime;

            chkCustomStartCoin.Checked = GameConfig.Instance.CustomStartCoinEnabled;
            startingCoinInput.Enabled = GameConfig.Instance.CustomStartCoinEnabled;
            startingCoinInput.Value = GameConfig.Instance.StartingCoin;

            // Loadout
            // TODO: check if loading from JSON is possible with embedded: https://github.com/Fody/Costura
            foreach (string h in Model.Hero.Heroes.Keys)
            {
                comBoxHero.Items.Add(h);
            }

            foreach (string d in Model.Dye.Dyes.Keys)
            {
                comBoxDye.Items.Add(d);
            }

            PopulateSlots(ComBoxLoadoutSlots, Model.Trap.Traps.Keys.ToList());
            PopulateSlots(ComBoxLoadoutSlots, Model.Gear.Gears.Keys.ToList());
            PopulateSlots(ComBoxGuardianSlots, Model.Guardian.Guardians.Keys.ToList());
            PopulateSlots(ComBoxConsumableSlots, Model.Consumable.Consumables.Keys.ToList());
            PopulateSlots(ComBoxTraitSlots, Model.Trait.TriangleSlotTraits.Keys.ToList());
            PopulateSlots(ComBoxTraitSlots, Model.Trait.PentagonSlotTraits.Keys.ToList());
            PopulateSlots(ComBoxTraitSlots, Model.Trait.DiamondSlotTraits.Keys.ToList());

            foreach (string loadoutName in Loadouts.Instance.GetLoadoutNames())
            {
                comBoxLoadouts.Items.Add(loadoutName);
            }
            comBoxLoadouts.SelectedIndex = comBoxLoadouts.Items.Count == 0 ? -1 : 0;
            btnDeleteLoadout.Enabled = comBoxLoadouts.Items.Count > 0;
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            GameLauncher.ApplyChanges(isHost: true);
            SaveSettings();

            string playerName = maskedTextBoxPlayerName.Text;
            var (isPlayerNameValid, errorMessagePlayerName) = InputValidator.ValidatePlayerName(playerName);

            if (!isPlayerNameValid)
            {
                MessageBox.Show(errorMessagePlayerName, "Invalid Player Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var invalidLoadouts = ValidateAllLoadoutCodes();
            if (invalidLoadouts.Any())
            {
                string errorMessage = "Some loadouts are invalid:\n" + string.Join("\n", invalidLoadouts);
                MessageBox.Show(errorMessage, "Invalid Loadouts", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ApplyAllLoadouts();
            GameLauncher.StartGame(GameInfo.Loadout.PlayerName, isHost: true);
        }

        private void ApplyAllLoadouts()
        {
            var loadouts = new List<MaskedTextBox>
            {
                maskedTextBoxHostGamePlayer1Loadout,
                maskedTextBoxHostGamePlayer2Loadout,
                maskedTextBoxHostGamePlayer3Loadout,
                maskedTextBoxHostGamePlayer4Loadout,
                maskedTextBoxHostGamePlayer5Loadout
            };

            foreach (var loadout in loadouts)
            {
                if (!string.IsNullOrWhiteSpace(loadout.Text))
                {
                    GameFiles.CharacterData.ApplyLoadout(Loadout.DecodeLoadout(loadout.Text));
                }
            }
        }

        private void btnJoinGame_Click(object sender, EventArgs e)
        {
            GameLauncher.ApplyChanges(isHost: false);
            SaveSettings();

            string hostIP = maskedTextBoxJoinGameHostIP.Text;
            string loadoutCode = maskedTextBoxJoinGameLoadout.Text;
            var (isIPValid, errorMessageIp) = InputValidator.ValidateIpAddress(hostIP);
            var (isLoadoutValid, errorMessagePlayerName) = InputValidator.ValidateLoadoutCode(loadoutCode);

            if (!isIPValid)
            {
                MessageBox.Show(errorMessageIp, "Invalid IP Address", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!isLoadoutValid)
            {
                MessageBox.Show(errorMessagePlayerName, "Invalid Player Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Loadout loadout = Loadout.DecodeLoadout(loadoutCode);
            string playerName = loadout.PlayerName;
            loadout.PlayerName  = "0";
            GameFiles.CharacterData.ApplyLoadout(loadout);
            loadout.PlayerName = playerName;
            GameLauncher.StartGame(loadout.PlayerName, isHost: false, hostIP);
        }

        public void SaveSettings()
        {
            Settings.Instance.Debug = chkDebug.Checked;
            Settings.Instance.RunAs32 = chkRunAs32.Checked;
            Settings.Instance.Save();
        }

        private void comBoxBattleground_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedBattleground = comBoxBattleground.SelectedItem.ToString();
            GameConfig.Instance.Battleground = selectedBattleground;
            GameConfig.Instance.Save();

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
            GameConfig.Instance.GameMode = comBoxGameMode.SelectedItem.ToString();
            GameConfig.Instance.Save();
        }


        private void comBoxDifficulty_SelectedIndexChanged(object sender, EventArgs e)
        {
            GameConfig.Instance.Difficulty = comBoxDifficulty.SelectedItem.ToString();
            GameConfig.Instance.Save();

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
            GameConfig.Instance.ExtraDifficulty = selectedExtraDifficulty;
            GameConfig.Instance.Save();

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
                UpdateLoadoutExportCode();
            }
        }

        private void comBoxSkin_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSkin = comBoxSkin.SelectedItem.ToString();
            GameInfo.Loadout.Skin = Model.Skin.Skins[selectedSkin];
            UpdateLoadoutExportCode();
        }

        private void comBoxDye_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDye = comBoxDye.SelectedItem.ToString();
            GameInfo.Loadout.Dye = Model.Dye.Dyes[selectedDye];
            UpdateLoadoutExportCode();
        }

        private void btnResetConfig_Click(object sender, EventArgs e)
        {
            GameLauncher.FirstLaunchInitialization();
        }

        private void chkGodMode_CheckedChanged(object sender, EventArgs e)
        {
            Mods.Mods.GodMode.IsEnabled = chkGodMode.Checked;
            GameConfig.Instance.GodMode = chkGodMode.Checked;
            GameConfig.Instance.Save();
        }

        private void chkNoTrapCap_CheckedChanged(object sender, EventArgs e)
        {
            Mods.Mods.NoTrapCap.IsEnabled = chkNoTrapCap.Checked;
            GameConfig.Instance.NoTrapCap = chkNoTrapCap.Checked;
            GameConfig.Instance.Save();
        }

        private void chkTrapsInTraps_CheckedChanged(object sender, EventArgs e)
        {
            Mods.Mods.TrapsInTraps.IsEnabled = chkTrapsInTraps.Checked;
            GameConfig.Instance.TrapsInTraps = chkTrapsInTraps.Checked;
            GameConfig.Instance.Save();
        }

        private void StartingCoinInput_ValueChanged(object sender, EventArgs e)
        {
            Mods.Mods.StartingCoinOverride.Value = (int)startingCoinInput.Value;
            GameConfig.Instance.StartingCoin = (int)startingCoinInput.Value;
            GameConfig.Instance.Save();
        }

        private void chkNoLimitUniqueTraps_CheckedChanged(object sender, EventArgs e)
        {
            Mods.Mods.NoLimitUniqueTraps.IsEnabled = chkNoLimitUniqueTraps.Checked;
            GameConfig.Instance.NoLimitUniqueTraps = chkNoLimitUniqueTraps.Checked;
            GameConfig.Instance.Save();
        }

        private void chkTrapsAnySurface_CheckedChanged(object sender, EventArgs e)
        {
            Mods.Mods.TrapsAnySurface.IsEnabled = chkTrapsAnySurface.Checked;
            GameConfig.Instance.TrapsAnySurface = chkTrapsAnySurface.Checked;
            GameConfig.Instance.Save();
        }

        private void chkNoTrapGrid_CheckedChanged(object sender, EventArgs e)
        {
            Mods.Mods.NoTrapGrid.IsEnabled = chkNoTrapGrid.Checked;
            GameConfig.Instance.NoTrapGrid = chkNoTrapGrid.Checked;
            GameConfig.Instance.Save();
        }

        private void chkHardcore_CheckedChanged(object sender, EventArgs e)
        {
            Mods.Mods.Hardcore.IsEnabled = chkHardcore.Checked;
            GameConfig.Instance.Hardcore = chkHardcore.Checked;
            GameConfig.Instance.Save();
        }

        private void chkInvincibleBarricades_CheckedChanged(object sender, EventArgs e)
        {
            Mods.Mods.InvincibleBarricades.IsEnabled = chkInvincibleBarricades.Checked;
            GameConfig.Instance.InvincibleBarricades = chkInvincibleBarricades.Checked;
            GameConfig.Instance.Save();
        }

        private void chkShowTrapDamageFlyoffs_CheckedChanged(object sender, EventArgs e)
        {
            Mods.Mods.ShowTrapDamageFlyoffs.IsEnabled = chkShowTrapDamageFlyoffs.Checked;
            GameConfig.Instance.ShowTrapDamage = chkShowTrapDamageFlyoffs.Checked;
            GameConfig.Instance.Save();
        }

        private void chk_modsEnabled_CheckedChanged(object sender, EventArgs e)
        {
            modsGroupBox.Enabled = chk_modsEnabled.Checked;
            GameConfig.Instance.ModsEnabled = chk_modsEnabled.Checked;
            GameConfig.Instance.Save();
        }

        private void PopulateSlots(List<ComboBox> comBoxSlotList, List<String> entryList)
        {
            entryList.Sort();
            entryList.Insert(0, "");
            foreach (ComboBox comBoxSlot in comBoxSlotList)
            {
                foreach (string entry in entryList)
                {
                    comBoxSlot.Items.Add(entry);
                }
            }
        }

        private void SetCurrenGuardians(Loadout loadout)
        {
            GuardianComboBoxHelper comboBoxHelper = new GuardianComboBoxHelper(Guardian.Guardians);
            List<Guardian> guardians = loadout.Guardians.ToList();
            for (int i = 0; i < Loadout.GUARDIAN_SLOT_COUNT; i++)
            {
                comboBoxHelper.InitializeComboBox(ComBoxGuardianSlots[i]);
                Guardian current = guardians[i];
                ComBoxGuardianSlots[i].SelectedItem = current?.Name;
            }
        }

        private void SetCurrentConsumables(Loadout loadout)
        {
            ConsumableComboBoxHelper comboBoxHelper = new ConsumableComboBoxHelper(Consumable.Consumables);
            List<Consumable> consumables = loadout.Consumables.ToList();
            for (int i = 0; i < Loadout.CONSUMABLE_SLOT_COUNT; i++)
            {
                comboBoxHelper.InitializeComboBox(ComBoxConsumableSlots[i]);
                Consumable current = consumables[i];
                ComBoxConsumableSlots[i].SelectedItem = current?.Name;
            }
        }

        private void SetCurrentTraits(Loadout loadout)
        {
            TraitComboBoxHelper comboBoxHelper = new TraitComboBoxHelper(Trait.Traits);
            List<Trait> traits = loadout.Traits.ToList();
            for (int i = 0; i < Loadout.TRAIT_SLOT_COUNT; i++)
            {
                comboBoxHelper.InitializeComboBox(ComBoxTraitSlots[i]);
                Trait current = traits[i];
                ComBoxTraitSlots[i].SelectedItem = current?.Name;
            }
        }

        private void SaveGuardians()
        {
            for (int i = 0; i < Loadout.GUARDIAN_SLOT_COUNT; i++)
            {
                string guardianName = ComBoxGuardianSlots[i].Text;
                GameInfo.Loadout.Guardians[i] = guardianName.Length > 0 ? Guardian.Guardians[guardianName] : null;
            }

            UpdateLoadoutExportCode();
        }

        private void SaveConsumables()
        {
            for (int i = 0; i < Loadout.CONSUMABLE_SLOT_COUNT; i++)
            {
                string consumableName = ComBoxConsumableSlots[i].Text;
                GameInfo.Loadout.Consumables[i] = consumableName.Length > 0 ? Consumable.Consumables[consumableName] : null;
            }

            UpdateLoadoutExportCode();
        }

        private void SaveTraits()
        {
            for (int i = 0; i < Loadout.TRAIT_SLOT_COUNT; i++)
            {
                string traitName = ComBoxTraitSlots[i].Text;
                GameInfo.Loadout.Traits[i] = traitName.Length > 0 ? Trait.Traits[traitName] : null;
            }

            UpdateLoadoutExportCode();
        }

        private void SetCurrentHero(Loadout loadout)
        {
            string heroName = loadout.Hero.Name;
            string skinName = loadout.Skin.Name;
            string dyeName = loadout.Dye.Name;

            comBoxHero.SelectedItem = heroName;
            comBoxSkin.SelectedItem = skinName;
            comBoxDye.SelectedItem = dyeName;
        }

        private void SetCurrentSlotItems(Loadout loadout)
        {
            SlotItemComboBoxHelper comboBoxHelper = new SlotItemComboBoxHelper(SlotItems);
            List<SlotItem> slotItems = loadout.SlotItems.ToList();

            for (int i = 0; i < Loadout.SLOT_ITEMS_COUNT; i++)
            {
                comboBoxHelper.InitializeComboBox(ComBoxLoadoutSlots[i]);
                SlotItem current = slotItems[i];
                ComBoxLoadoutSlots[i].SelectedItem = current?.Name;
            }
        }

        private void SetCurrentTrapParts(Loadout loadout)
        {
            TrapPartComboBoxHelper comboBoxHelper = new TrapPartComboBoxHelper(TrapPart.TrapParts);
            List<List<TrapPart>> trapParts = ConvertArrayToListOfLists(loadout.TrapParts);

            for (int i = 0; i < Loadout.SLOT_ITEMS_COUNT; i++)
            {
                for (int j = 0; j < Loadout.TRAP_PART_SLOT_COUNT; j++)
                {
                    if (i < ComBoxTrapPartsSlots.Count && j < ComBoxTrapPartsSlots[i].Count)
                    {
                        comboBoxHelper.InitializeComboBox(ComBoxTrapPartsSlots[i][j]);
                        TrapPart current = trapParts[i][j];
                        ComBoxTrapPartsSlots[i][j].SelectedItem = current?.Name;
                    }
                }
            }
        }

        private List<List<TrapPart>> ConvertArrayToListOfLists(TrapPart[,] trapPartsArray)
        {
            return Enumerable.Range(0, trapPartsArray.GetLength(0))
                             .Select(i => Enumerable.Range(0, trapPartsArray.GetLength(1))
                                                    .Select(j => trapPartsArray[i, j])
                                                    .ToList())
                             .ToList();
        }

        private static readonly Dictionary<string, SlotItem> SlotItems =
            new List<Dictionary<string, SlotItem>>() { Gear.Gears, Trap.Traps }
                .SelectMany(dict => dict)
                .ToDictionary(pair => pair.Key, pair => pair.Value);

        private void SaveLoadoutItem(int slotItemIdx)
        {
            string slotItemName = ComBoxLoadoutSlots[slotItemIdx].Text;
            GameInfo.Loadout.SlotItems[slotItemIdx] = slotItemName.Length > 0 ? SlotItems[slotItemName] : null;
            UpdateLoadoutExportCode();
        }

        private void SaveTrapPart(int slotIdx, int partIdx)
        {
            string partName = ComBoxTrapPartsSlots[slotIdx][partIdx].Text;
            GameInfo.Loadout.TrapParts[slotIdx, partIdx] = partName.Length > 0 ? TrapPart.TrapParts[partName] : null;
            UpdateLoadoutExportCode();
        }

        private void UpdateLoadoutExportCode()
        {
            textBoxExportLoadout.Text = Loadout.EncodeLoadout(GameInfo.Loadout);
            maskedTextBoxHostGamePlayer1Loadout.Text = Loadout.EncodeLoadout(GameInfo.Loadout);
        }

        private void comBoxLoadoutSlot1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItemSlot = ((ComboBox)sender).SelectedItem?.ToString();
            SaveLoadoutItem(1 - 1);
            AdjustTrapPartsComBoxes(selectedItemSlot, 1 - 1);
        }

        private void comBoxLoadoutSlot2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItemSlot = ((ComboBox)sender).SelectedItem?.ToString();
            SaveLoadoutItem(2 - 1);
            AdjustTrapPartsComBoxes(selectedItemSlot, 2 - 1);
        }

        private void comBoxLoadoutSlot3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItemSlot = ((ComboBox)sender).SelectedItem?.ToString();
            SaveLoadoutItem(3 - 1);
            AdjustTrapPartsComBoxes(selectedItemSlot, 3 - 1);
        }

        private void comBoxLoadoutSlot4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItemSlot = ((ComboBox)sender).SelectedItem?.ToString();
            SaveLoadoutItem(4 - 1);
            AdjustTrapPartsComBoxes(selectedItemSlot, 4 - 1);
        }

        private void comBoxLoadoutSlot5_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItemSlot = ((ComboBox)sender).SelectedItem?.ToString();
            SaveLoadoutItem(5 - 1);
            AdjustTrapPartsComBoxes(selectedItemSlot, 5 - 1);
        }

        private void comBoxLoadoutSlot6_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItemSlot = ((ComboBox)sender).SelectedItem?.ToString();
            SaveLoadoutItem(6 - 1);
            AdjustTrapPartsComBoxes(selectedItemSlot, 6 - 1);
        }

        private void comBoxLoadoutSlot7_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItemSlot = ((ComboBox)sender).SelectedItem?.ToString();
            SaveLoadoutItem(7 - 1);
            AdjustTrapPartsComBoxes(selectedItemSlot, 7 - 1);
        }

        private void comBoxLoadoutSlot8_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItemSlot = ((ComboBox)sender).SelectedItem?.ToString();
            SaveLoadoutItem(8 - 1);
            AdjustTrapPartsComBoxes(selectedItemSlot, 8 - 1);
        }

        private void comBoxLoadoutSlot9_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItemSlot = ((ComboBox)sender).SelectedItem?.ToString();
            SaveLoadoutItem(9 - 1);
            AdjustTrapPartsComBoxes(selectedItemSlot, 9 - 1);
        }

        private void AdjustTrapPartsComBoxes(string slotItemSelectedName, int slotIdx)
        {
            String selected = slotItemSelectedName;
            Trap trap = selected != null && selected != "" && Trap.Traps.ContainsKey(selected) ? (Trap)Trap.Traps[selected] : null;
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
                    trapPartComBox.Items.Clear();
                    PopulateSlots(new List<ComboBox> { trapPartComBox }, trapPartNames);
                }

                trapPartComBox.SelectedItem = null;
            }
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
            GameConfig.Instance.CustomStartCoinEnabled = chkCustomStartCoin.Checked;
            GameConfig.Instance.Save();
        }

        private void chkSellTrapsAnytime_CheckedChanged(object sender, EventArgs e)
        {
            Mods.Mods.SellTrapsAnytime.IsEnabled = chkSellTrapsAnytime.Checked;
            GameConfig.Instance.SellTrapsAnytime = chkSellTrapsAnytime.Checked;
            GameConfig.Instance.Save();
        }

        private void chkEnhancedTrapRotation_CheckedChanged(object sender, EventArgs e)
        {
            Mods.Mods.EnhancedTrapRotation.IsEnabled = chkEnhancedTrapRotation.Checked;
            GameConfig.Instance.EnhancedTrapRotation = chkEnhancedTrapRotation.Checked;
            GameConfig.Instance.Save();
        }

        private void comBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedLanguage = comBoxLanguage.SelectedItem.ToString();
            Settings.Instance.Language = selectedLanguage;
            Settings.Instance.Save();
        }

        private void comBoxTrapPartsSlot1Part1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveTrapPart(0, 0);
        }

        private void comBoxTrapPartsSlot1Part2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveTrapPart(0, 1);
        }

        private void comBoxTrapPartsSlot1Part3_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveTrapPart(0, 2);
        }

        private void comBoxTrapPartsSlot2Part1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveTrapPart(1, 0);
        }

        private void comBoxTrapPartsSlot2Part2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveTrapPart(1, 1);
        }

        private void comBoxTrapPartsSlot2Part3_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveTrapPart(1, 2);
        }

        private void comBoxTrapPartsSlot3Part1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveTrapPart(2, 0);
        }

        private void comBoxTrapPartsSlot3Part2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveTrapPart(2, 1);
        }

        private void comBoxTrapPartsSlot3Part3_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveTrapPart(2, 2);
        }

        private void comBoxTrapPartsSlot4Part1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveTrapPart(3, 0);
        }

        private void comBoxTrapPartsSlot4Part2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveTrapPart(3, 1);
        }

        private void comBoxTrapPartsSlot4Part3_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveTrapPart(3, 2);
        }

        private void comBoxTrapPartsSlot5Part1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveTrapPart(4, 0);
        }

        private void comBoxTrapPartsSlot5Part2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveTrapPart(4, 1);
        }

        private void comBoxTrapPartsSlot5Part3_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveTrapPart(4, 2);
        }

        private void comBoxTrapPartsSlot6Part1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveTrapPart(5, 0);
        }

        private void comBoxTrapPartsSlot6Part2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveTrapPart(5, 1);
        }

        private void comBoxTrapPartsSlot6Part3_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveTrapPart(5, 2);
        }

        private void comBoxTrapPartsSlot7Part1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveTrapPart(6, 0);
        }

        private void comBoxTrapPartsSlot7Part2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveTrapPart(6, 1);
        }

        private void comBoxTrapPartsSlot7Part3_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveTrapPart(6, 2);
        }

        private void comBoxTrapPartsSlot8Part1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveTrapPart(7, 0);
        }

        private void comBoxTrapPartsSlot8Part2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveTrapPart(7, 1);
        }

        private void comBoxTrapPartsSlot8Part3_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveTrapPart(7, 2);
        }

        private void comBoxTrapPartsSlot9Part1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveTrapPart(8, 0);
        }

        private void comBoxTrapPartsSlot9Part2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveTrapPart(8, 1);
        }

        private void comBoxTrapPartsSlot9Part3_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveTrapPart(8, 2);
        }


        private void btnCopyLoadoutToClipboard_Click(object sender, EventArgs e)
        {
            string loadoutCode = textBoxExportLoadout.Text;

            var (isLoadoutCodeValid, errorMessageLoadout) = InputValidator.ValidateLoadoutCode(loadoutCode);

            if (!isLoadoutCodeValid)
            {
                MessageBox.Show(errorMessageLoadout, "Invalid Loadout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Clipboard.SetText(loadoutCode);
            maskedTextBoxJoinGameLoadout.Text = loadoutCode;
        }

        private void btnSaveLoadout_Click(object sender, EventArgs e)
        {
            string loadoutName = maskedTextBoxLoadoutName.Text;
            string loadoutCode = textBoxExportLoadout.Text;
            var (isLoadoutValid, errorMessageLoadout) = InputValidator.ValidateLoadoutCode(loadoutCode);
            var (isLoadoutNameValid, errorMessageLoadoutName) = InputValidator.ValidateLoadoutName(loadoutName);

            if (!isLoadoutValid)
            {
                MessageBox.Show(errorMessageLoadout, "Invalid Loadout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!isLoadoutNameValid)
            {
                MessageBox.Show(errorMessageLoadoutName, "Invalid Loadout Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Loadouts.Instance.Exists(loadoutName))
            {
                Loadouts.Instance.UpdateLoadout(loadoutName, loadoutCode);
            }
            else
            {
                Loadouts.Instance.AddLoadout(loadoutName, loadoutCode);
                comBoxLoadouts.Items.Add(loadoutName);
            }

            Loadouts.Instance.Save();
            comBoxLoadouts.SelectedItem = loadoutName;
        }

        private void maskedTextBoxLoadoutName_TextChanged(object sender, EventArgs e)
        {
            string loadoutName = maskedTextBoxLoadoutName.Text;
            var (isValid, errorMessage) = InputValidator.ValidateLoadoutName(loadoutName);

            errorProvider.SetError(maskedTextBoxLoadoutName, isValid ? string.Empty : errorMessage);

            GameInfo.Loadout.Name = loadoutName;
        }

        private void maskedTextBoxPlayerName_TextChanged(object sender, EventArgs e)
        {
            string playerName = maskedTextBoxPlayerName.Text;
            var (isValid, errorMessage) = InputValidator.ValidatePlayerName(playerName);

            errorProvider.SetError(maskedTextBoxPlayerName, isValid ? string.Empty: errorMessage);

            GameInfo.Loadout.PlayerName = playerName;
            UpdateLoadoutExportCode();
        }

        private void comBoxLoadouts_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedLoadoutName = comBoxLoadouts.SelectedItem.ToString();
            string selectedLoadoutCode = Loadouts.Instance.GetLoadoutByName(selectedLoadoutName).Code;
            Loadout decodedLoadout = Loadout.DecodeLoadout(selectedLoadoutCode);
            GameInfo.Loadout = decodedLoadout;

            SetCurrentHero(decodedLoadout);
            SetCurrentSlotItems(decodedLoadout);
            SetCurrentTrapParts(decodedLoadout);
            SetCurrenGuardians(decodedLoadout);
            SetCurrentConsumables(decodedLoadout);
            SetCurrentTraits(decodedLoadout);

            maskedTextBoxLoadoutName.Text = selectedLoadoutName;
            maskedTextBoxPlayerName.Text = decodedLoadout.PlayerName;

            if (comBoxLoadouts.Items.Count > 0)
            {
                btnDeleteLoadout.Enabled = true;
            }
        }

        private void btnImportLoadout_Click(object sender, EventArgs e)
        {
            var (isValid, errorMessage) = InputValidator.ValidateLoadoutCode(maskedTextBoxImportLoadout.Text);

            if (!isValid)
            {
                MessageBox.Show(errorMessage, "Invalid Import Loadout Code", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string loadoutCode = maskedTextBoxImportLoadout.Text;
            Loadout decodedLoadout = Loadout.DecodeLoadout(loadoutCode);
            GameInfo.Loadout = decodedLoadout;

            string loadoutName = "";
            while (loadoutName.Length == 0 || Loadouts.Instance.Exists(loadoutName))
            {
                loadoutName = decodedLoadout.PlayerName + "-Imported-" + Guid.NewGuid().ToString().Substring(0, 8);
            }

            Loadouts.Instance.AddLoadout(loadoutName, loadoutCode);
            Loadouts.Instance.Save();

            comBoxLoadouts.Items.Add(loadoutName);
            comBoxLoadouts.SelectedItem = loadoutName;
            btnImportLoadout.Enabled = false;
            maskedTextBoxImportLoadout.Text = "";
        }

        private void maskedTextBoxImportLoadout_TextChanged(object sender, EventArgs e)
        {
            btnImportLoadout.Enabled = true;
            string loadoutCode = maskedTextBoxImportLoadout.Text;
            if (loadoutCode.Length == 0)
            {
                errorProvider.SetError(maskedTextBoxImportLoadout, string.Empty);
                btnImportLoadout.Enabled = false;
                return;
            }

            var (isValid, errorMessage) = InputValidator.ValidateLoadoutCode(loadoutCode);

            errorProvider.SetError(maskedTextBoxImportLoadout, isValid ? string.Empty : errorMessage);
        }

        private void btnDeleteLoadout_Click(object sender, EventArgs e)
        {
            string selectedLoadoutName = comBoxLoadouts.SelectedItem.ToString();
            Loadouts.Instance.RemoveLoadout(selectedLoadoutName);
            Loadouts.Instance.Save();
            comBoxLoadouts.Items.Remove(selectedLoadoutName);
            comBoxLoadouts.SelectedIndex = comBoxLoadouts.Items.Count == 0 ? -1 : 0;

            if (comBoxLoadouts.Items.Count == 0)
            {
                btnDeleteLoadout.Enabled = false;
            }
        }

        private static readonly string DISCORD_SERVER_INVITE_CODE = "MngtsvvA5E";
        private static readonly string DISCORD_SERVER_INVITE_URL = "https://discord.gg/" + DISCORD_SERVER_INVITE_CODE;

        private void btnDiscord_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(DISCORD_SERVER_INVITE_URL);
        }

        private void maskedTextBoxHostGamePlayer1Loadout_TextChanged(object sender, EventArgs e)
        {
            ValidateLoadoutCode(maskedTextBoxHostGamePlayer1Loadout);
        }

        private void maskedTextBoxHostGamePlayer2Loadout_TextChanged(object sender, EventArgs e)
        {
            ValidateLoadoutCode(maskedTextBoxHostGamePlayer2Loadout);
        }

        private void maskedTextBoxHostGamePlayer3Loadout_TextChanged(object sender, EventArgs e)
        {
            ValidateLoadoutCode(maskedTextBoxHostGamePlayer3Loadout);
        }

        private void maskedTextBoxHostGamePlayer4Loadout_TextChanged(object sender, EventArgs e)
        {
            ValidateLoadoutCode(maskedTextBoxHostGamePlayer4Loadout);
        }

        private void maskedTextBoxHostGamePlayer5Loadout_TextChanged(object sender, EventArgs e)
        {
            ValidateLoadoutCode(maskedTextBoxHostGamePlayer5Loadout);
        }
               
        private void maskedTextBoxJoinGameHostIP_TextChanged(object sender, EventArgs e)
        {
            string hostIP = maskedTextBoxJoinGameHostIP.Text;
            var (isValid, errorMessage) = InputValidator.ValidateIpAddress(hostIP);

            errorProvider.SetError(maskedTextBoxJoinGameHostIP, isValid || hostIP.Length == 0 ? string.Empty : errorMessage);
        }

        private void maskedTextBoxJoinGamePlayerName_TextChanged(object sender, EventArgs e)
        {
            string loadoutCode = maskedTextBoxJoinGameLoadout.Text;
            var (isValid, errorMessage) = InputValidator.ValidateLoadoutCode(loadoutCode);

            errorProvider.SetError(maskedTextBoxJoinGameLoadout, isValid || loadoutCode.Length == 0 ? string.Empty : errorMessage);
        }

        private (bool isValid, string errorMessage) ValidateLoadoutCode(MaskedTextBox maskedTextBox)
        {
            string loadoutCode = maskedTextBox.Text;

            if (string.IsNullOrWhiteSpace(loadoutCode))
            {
                return (true, string.Empty);
            }

            var (isValid, validationErrorMessage) = InputValidator.ValidateLoadoutCode(loadoutCode);

            errorProvider.SetError(maskedTextBox, isValid ? string.Empty : validationErrorMessage);

            return (isValid, isValid ? string.Empty : validationErrorMessage);
        }

        private List<string> ValidateAllLoadoutCodes()
        {
            var invalidLoadouts = new List<string>();

            var loadouts = new Dictionary<string, MaskedTextBox>
            {
                { "Player 1", maskedTextBoxHostGamePlayer1Loadout },
                { "Player 2", maskedTextBoxHostGamePlayer2Loadout },
                { "Player 3", maskedTextBoxHostGamePlayer3Loadout },
                { "Player 4", maskedTextBoxHostGamePlayer4Loadout },
                { "Player 5", maskedTextBoxHostGamePlayer5Loadout }
            };

            foreach (var loadout in loadouts)
            {
                var (isValid, errorMessage) = ValidateLoadoutCode(loadout.Value);
                if (!isValid && !string.IsNullOrEmpty(errorMessage))
                {
                    invalidLoadouts.Add($"{loadout.Key}: {errorMessage}");
                }
            }

            return invalidLoadouts;
        }

        string MULTIPLAYER_KNOWN_ISSUES_URL = "https://github.com/TimeMaster18/Project-Rechained?tab=readme-ov-file#known-problems";

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(MULTIPLAYER_KNOWN_ISSUES_URL);        
        }
    }
}

