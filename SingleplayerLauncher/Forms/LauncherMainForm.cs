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

        private readonly List<ComboBox> ComBoxSiegeLoadoutSlots;
        private readonly List<ComboBox> ComBoxSiegeLoadoutGearSlots;
        private readonly List<ComboBox> ComBoxSiegeLoadoutTrapSlots;
        private readonly List<ComboBox> ComBoxSiegeLv1WaveSlots;
        private readonly List<ComboBox> ComBoxSiegeLv2WaveSlots;
        private readonly List<ComboBox> ComBoxSiegeLv3WaveSlots;
        private readonly List<ComboBox> ComBoxSiegeLv4WaveSlots;
        private readonly List<ComboBox> ComBoxSiegeBossWaveSlots;
        private readonly List<ComboBox> ComBoxSiegeWaveSlots;
        private readonly List<ComboBox> ComBoxSiegeTraitSlots;

        Random random = new Random();

        public LauncherMainForm()
        {
            if (Settings.Instance.FirstRun)
            {
                GameLauncher.FirstLaunchInitialization();
            }
            InitializeComponent();

            // Survival Loadout
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

            // Siege Loadout
            ComBoxSiegeLoadoutGearSlots = new List<ComboBox>()
            {
                comBoxSiegeLoadoutSlot1, comBoxSiegeLoadoutSlot2
            };
            ComBoxSiegeLoadoutTrapSlots = new List<ComboBox>()
            {
                comBoxSiegeLoadoutSlot3,
                comBoxSiegeLoadoutSlot4, comBoxSiegeLoadoutSlot5, comBoxSiegeLoadoutSlot6,
                comBoxSiegeLoadoutSlot7, comBoxSiegeLoadoutSlot8, comBoxSiegeLoadoutSlot9
            };

            ComBoxSiegeLoadoutSlots = ComBoxSiegeLoadoutGearSlots.Concat(ComBoxSiegeLoadoutTrapSlots).ToList();


            ComBoxSiegeLv1WaveSlots = new List<ComboBox>()
            {
                comBoxSiegeLv1WaveSlot1, comBoxSiegeLv1WaveSlot2,
            };
            ComBoxSiegeLv2WaveSlots = new List<ComboBox>()
            {
                comBoxSiegeLv2WaveSlot1, comBoxSiegeLv2WaveSlot2
            };
            ComBoxSiegeLv3WaveSlots = new List<ComboBox>()
            {
                comBoxSiegeLv3WaveSlot1, comBoxSiegeLv3WaveSlot2
            };
            ComBoxSiegeLv4WaveSlots = new List<ComboBox>()
            {
                comBoxSiegeLv4WaveSlot1, comBoxSiegeLv4WaveSlot2
            };
            ComBoxSiegeBossWaveSlots = new List<ComboBox>()
            {
                comBoxSiegeBossWaveSlot1, comBoxSiegeBossWaveSlot2
            };

            ComBoxSiegeWaveSlots = ComBoxSiegeLv1WaveSlots.Concat(ComBoxSiegeLv2WaveSlots)
                .Concat(ComBoxSiegeLv3WaveSlots).Concat(ComBoxSiegeLv4WaveSlots).Concat(ComBoxSiegeBossWaveSlots).ToList();

            ComBoxSiegeTraitSlots = new List<ComboBox>()
            {
                comboxSiegeTraitGreenSlot, comboxSiegeTraitBlueSlot, comboxSiegeTraitYellowSlot, comboxSiegeTraitNoBonusSlot // This order must match the order in Loadout.cs for simplicity
            };


            // Launcher settings
            foreach (string language in Language.GetLanguageMap().Values)
            {
                comBoxLanguage.Items.Add(language);
                comBoxSiegeLanguage.Items.Add(language);
            }
            chkDebug.Checked = Settings.Instance.Debug;
            chkRunAs32.Checked = Settings.Instance.RunAs32;
            comBoxLanguage.SelectedItem = Settings.Instance.Language;
            comBoxSiegeLanguage.SelectedItem = Settings.Instance.Language;

            // Survival Game settings
            foreach (string gm in Model.GameMode.GameModes.Keys)
            {
                comBoxGameMode.Items.Add(gm);
            }

            chk_modsEnabled.Checked = GameConfig.Instance.ModsEnabled;
            modsGroupBox.Enabled = GameConfig.Instance.ModsEnabled;
            chkShowTrapDamageFlyoffs.Checked = GameConfig.Instance.ShowTrapDamage;

            // TODO Fix loading of below game settings (it gets ovewritten from the onChange event)
            comBoxExtraDifficulty.SelectedItem = GameConfig.Instance.ExtraDifficulty;
            comBoxDifficulty.SelectedItem = GameConfig.Instance.Difficulty;
            comBoxBattleground.SelectedItem = GameConfig.Instance.Battleground;
            comBoxGameMode.SelectedItem = GameConfig.Instance.GameMode;

            // Siege Game settings
            PopulateSlots(new List<ComboBox> { comBoxSiegeBattleground }, Model.Siege.SiegeBattlegrounds.Keys.ToList(), addEmptyOption: false);
            // select config or first index if no config
            comBoxSiegeBattleground.SelectedItem = GameConfig.Instance.Battleground ?? comBoxSiegeBattleground.Items[0];

            // Mods
            chkGodMode.Checked = GameConfig.Instance.GodMode;
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
            PopulateSlots(new List<ComboBox> { comBoxAdditionalHeroWeapon }, Model.Hero.Heroes.Keys.ToList());
            chkAdditionalHeroWeapon.Checked = GameConfig.Instance.AdditionalHeroWeaponEnabled;
            comBoxAdditionalHeroWeapon.SelectedItem = GameConfig.Instance.AdditionalHeroWeapon;

            // Survival Loadout initializations
            // TODO: check if loading from JSON is possible with embedded: https://github.com/Fody/Costura
            PopulateSlots(new List<ComboBox> { comBoxHero }, Model.Hero.Heroes.Keys.ToList(), addEmptyOption: false);
            PopulateSlots(new List<ComboBox> { comBoxDye }, Model.Dye.Dyes.Keys.ToList(), addEmptyOption: false);

            PopulateSlots(ComBoxLoadoutSlots, Model.Trap.Traps.Keys.ToList());
            PopulateSlots(ComBoxLoadoutSlots, Model.Gear.Gears.Keys.ToList());
            PopulateSlots(ComBoxGuardianSlots, Model.Guardian.Guardians.Keys.ToList());
            PopulateSlots(ComBoxConsumableSlots, Model.Consumable.Consumables.Keys.ToList());
            PopulateSlots(ComBoxTraitSlots, Model.SurvivalTrait.TriangleSlotTraits.Keys.ToList());
            PopulateSlots(ComBoxTraitSlots, Model.SurvivalTrait.PentagonSlotTraits.Keys.ToList());
            PopulateSlots(ComBoxTraitSlots, Model.SurvivalTrait.DiamondSlotTraits.Keys.ToList());

            InitializeSlots(ComBoxLoadoutSlots, new SlotItemComboBoxHelper(SlotItem.GetAllSlotItems()));
            InitializeSlots(ComBoxGuardianSlots, new GuardianComboBoxHelper(Guardian.Guardians));
            InitializeSlots(ComBoxConsumableSlots, new ConsumableComboBoxHelper(Consumable.Consumables));
            InitializeSlots(ComBoxTraitSlots, new TraitComboBoxHelper<SurvivalTrait>(SurvivalTrait.Traits));
            foreach (List<ComboBox> comBoxTrapPartsSlots in ComBoxTrapPartsSlots)
            {
                InitializeSlots(comBoxTrapPartsSlots, new TrapPartComboBoxHelper(TrapPart.TrapParts));
            }

            foreach (string loadoutName in SurvivalLoadouts.Instance.GetLoadoutNames())
            {
                comBoxLoadouts.Items.Add(loadoutName);
            }
            comBoxLoadouts.SelectedIndex = comBoxLoadouts.Items.Count == 0 ? -1 : 0;
            btnDeleteLoadout.Enabled = comBoxLoadouts.Items.Count > 0;


            // Siege Loadout initializations
            // TODO: check if loading from JSON is possible with embedded: https://github.com/Fody/Costura
            PopulateSlots(new List<ComboBox> { comBoxSiegeHero }, Model.Hero.SiegeHeroes.Keys.ToList(), addEmptyOption: false);
            PopulateSlots(new List<ComboBox> { comBoxSiegeDye }, Model.Dye.Dyes.Keys.ToList(), addEmptyOption: false);

            PopulateSlots(ComBoxSiegeLoadoutGearSlots, Model.Gear.Gears.Keys.ToList());
            PopulateSlots(ComBoxSiegeLoadoutTrapSlots, Model.Trap.SiegeTraps.Keys.ToList());
            PopulateSlots(new List<ComboBox> { comBoxRole }, Model.SiegeRole.Roles.Keys.ToList(), addEmptyOption: false);
            PopulateSlots(ComBoxSiegeLv1WaveSlots, Model.Wave.Lvl1Waves.Keys.ToList());
            PopulateSlots(ComBoxSiegeLv2WaveSlots, Model.Wave.Lvl2Waves.Keys.ToList());
            PopulateSlots(ComBoxSiegeLv3WaveSlots, Model.Wave.Lvl3Waves.Keys.ToList());
            PopulateSlots(ComBoxSiegeLv4WaveSlots, Model.Wave.Lvl4Waves.Keys.ToList());
            PopulateSlots(ComBoxSiegeBossWaveSlots, Model.Wave.BossWaves.Keys.ToList());
            PopulateSlots(ComBoxSiegeTraitSlots, Model.SiegeTrait.TriangleSlotTraits.Keys.ToList());
            PopulateSlots(ComBoxSiegeTraitSlots, Model.SiegeTrait.PentagonSlotTraits.Keys.ToList());
            PopulateSlots(ComBoxSiegeTraitSlots, Model.SiegeTrait.DiamondSlotTraits.Keys.ToList());

            InitializeSlots(ComBoxSiegeLoadoutGearSlots, new SiegeSlotItemComboBoxHelper(SlotItem.GetAllSiegeSlotItems()));
            InitializeSlots(ComBoxSiegeLoadoutTrapSlots, new SiegeSlotItemComboBoxHelper(SlotItem.GetAllSiegeSlotItems()));
            InitializeSlots(new List<ComboBox> { comBoxRole }, new RoleComboBoxHelper(SiegeRole.Roles));
            InitializeSlots(ComBoxSiegeTraitSlots, new TraitComboBoxHelper<SiegeTrait>(SiegeTrait.Traits));
            InitializeSlots(ComBoxSiegeLv1WaveSlots, new WaveComboBoxHelper(Wave.Waves));
            InitializeSlots(ComBoxSiegeLv2WaveSlots, new WaveComboBoxHelper(Wave.Waves));
            InitializeSlots(ComBoxSiegeLv3WaveSlots, new WaveComboBoxHelper(Wave.Waves));
            InitializeSlots(ComBoxSiegeLv4WaveSlots, new WaveComboBoxHelper(Wave.Waves));
            InitializeSlots(ComBoxSiegeBossWaveSlots, new WaveComboBoxHelper(Wave.Waves));

            foreach (string loadoutName in SiegeLoadouts.Instance.GetLoadoutNames())
            {
                comBoxSiegeLoadouts.Items.Add(loadoutName);
            }
            comBoxSiegeLoadouts.SelectedIndex = comBoxSiegeLoadouts.Items.Count == 0 ? -1 : 0;
            btnDeleteSiegeLoadout.Enabled = comBoxSiegeLoadouts.Items.Count > 0;

            if (Settings.Instance.IsSiegeInstallation)
            {
                gameModeTabControl.TabPages.Remove(gameModeSurvivalTab);
                loadoutEditorTabControl.TabPages.Remove(loadoutEditorSurvivalTab);
            }
            else
            {
                gameModeTabControl.TabPages.Remove(gameModeSiegeTab);
                loadoutEditorTabControl.TabPages.Remove(loadoutEditorSiegeTab);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
            GameLauncher.StartGame(GameInfo.SurvivalLoadout.PlayerName, isHost: true);
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
                    SurvivalLoadout sLoadout = new SurvivalLoadout();
                    GameFiles.CharacterData.ApplyLoadout((SurvivalLoadout)sLoadout.Decode(loadout.Text));
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

            SurvivalLoadout loadout = new SurvivalLoadout();
            loadout.Decode(loadoutCode);
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

            if (Model.Survival.SurvivalBattlegroundsByDifficulty.TryGetValue(selectedDifficulty, out Dictionary<string, Survival> battlegrounds))
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
            GameInfo.SurvivalLoadout.Hero = Model.Hero.Heroes[selectedHero];

            if (GameInfo.SurvivalLoadout.Hero.Skins != null)
            {
                PopulateSlots(new List<ComboBox> { comBoxSkin }, GameInfo.SurvivalLoadout.Hero.Skins.Select(s => s.Name).ToList(), addEmptyOption: false);

                comBoxSkin.SelectedItem = GameInfo.SurvivalLoadout.Hero.Skins[0].Name;
                GameInfo.SurvivalLoadout.Hero = Model.Hero.Heroes[selectedHero];
                UpdateLoadoutExportCode();
            }
        }

        private void comBoxSkin_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSkin = comBoxSkin.SelectedItem.ToString();
            GameInfo.SurvivalLoadout.Skin = Model.Skin.Skins[selectedSkin];
            UpdateLoadoutExportCode();
        }

        private void comBoxDye_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDye = comBoxDye.SelectedItem.ToString();
            GameInfo.SurvivalLoadout.Dye = Model.Dye.Dyes[selectedDye];
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
            modsPanel.Visible = chk_modsEnabled.Checked;
            GameConfig.Instance.ModsEnabled = chk_modsEnabled.Checked;
            GameConfig.Instance.Save();
        }

        private void PopulateSlots(List<ComboBox> comBoxSlotList, List<string> entryList, bool addEmptyOption = true)
        {
            entryList.Sort();
            if (addEmptyOption)
            {
                entryList.Insert(0, "");
            }
            foreach (ComboBox comBoxSlot in comBoxSlotList)
            {
                foreach (string entry in entryList)
                {
                    comBoxSlot.Items.Add(entry);
                }
            }
        }

        private void InitializeSlots<T>(List<ComboBox> comBoxSlotList, ComboBoxHelper<T> comboBoxHelper)
        {
            foreach (ComboBox comBoxSlot in comBoxSlotList)
            {
                comboBoxHelper.InitializeComboBox(comBoxSlot);
            }
        }

        private void SetCurrentGuardians(SurvivalLoadout loadout)
        {
            List<Guardian> guardians = loadout.Guardians.ToList();
            for (int i = 0; i < SurvivalLoadout.GUARDIAN_SLOT_COUNT; i++)
            {
                Guardian current = guardians[i];
                ComBoxGuardianSlots[i].SelectedItem = current?.Name;
            }
        }

        private void SetCurrentConsumables(SurvivalLoadout loadout)
        {
            List<Consumable> consumables = loadout.Consumables.ToList();
            for (int i = 0; i < SurvivalLoadout.CONSUMABLE_SLOT_COUNT; i++)
            {
                Consumable current = consumables[i];
                ComBoxConsumableSlots[i].SelectedItem = current?.Name;
            }
        }

        private void SetCurrentTraits(BaseLoadout loadout)
        {
            List<Trait> traits = loadout.Traits.ToList();
            for (int i = 0; i < SurvivalLoadout.TRAIT_SLOT_COUNT; i++)
            {
                Trait current = traits[i];
                ComBoxTraitSlots[i].SelectedItem = current?.Name;
            }
        }

        private void SetCurrentSiegeTraits(BaseLoadout loadout)
        {
            List<Trait> traits = loadout.Traits.ToList();
            for (int i = 0; i < SurvivalLoadout.TRAIT_SLOT_COUNT; i++)
            {
                Trait current = traits[i];
                ComBoxSiegeTraitSlots[i].SelectedItem = current?.Name;
            }
        }

        private void SetCurrentWaves(SiegeLoadout loadout)
        {
            List<Wave> waves = loadout.Waves.ToList();
            for (int i = 0; i < SiegeLoadout.WAVES_SLOT_COUNT; i++)
            {
                Wave current = waves[i];
                ComBoxSiegeWaveSlots[i].SelectedItem = current?.Name;
            }
        }

        private void SaveGuardians()
        {
            for (int i = 0; i < SurvivalLoadout.GUARDIAN_SLOT_COUNT; i++)
            {
                string guardianName = ComBoxGuardianSlots[i].Text;
                ((SurvivalLoadout)GameInfo.SurvivalLoadout).Guardians[i] = guardianName.Length > 0 ? Guardian.Guardians[guardianName] : null;
            }

            UpdateLoadoutExportCode();
        }

        private void SaveConsumables()
        {
            for (int i = 0; i < SurvivalLoadout.CONSUMABLE_SLOT_COUNT; i++)
            {
                string consumableName = ComBoxConsumableSlots[i].Text;
                ((SurvivalLoadout)GameInfo.SurvivalLoadout).Consumables[i] = consumableName.Length > 0 ? Consumable.Consumables[consumableName] : null;
            }

            UpdateLoadoutExportCode();
        }

        private void SaveTraits()
        {
            for (int i = 0; i < BaseLoadout.TRAIT_SLOT_COUNT; i++)
            {
                string traitName = ComBoxTraitSlots[i].Text;
                GameInfo.SurvivalLoadout.Traits[i] = traitName.Length > 0 ? SurvivalTrait.Traits[traitName] : null;
            }

            UpdateLoadoutExportCode();
        }

        private void SetCurrentHero(BaseLoadout loadout)
        {
            string heroName = loadout.Hero.Name;
            string skinName = loadout.Skin.Name;
            string dyeName = loadout.Dye.Name;

            comBoxHero.SelectedItem = heroName;
            comBoxSkin.SelectedItem = skinName;
            comBoxDye.SelectedItem = dyeName;
        }

        private void SetCurrentSiegeHero(BaseLoadout loadout)
        {
            string heroName = loadout.Hero.Name;
            string skinName = loadout.Skin.Name;
            string dyeName = loadout.Dye.Name;

            comBoxSiegeHero.SelectedItem = heroName;
            comBoxSiegeSkin.SelectedItem = skinName;
            comBoxSiegeDye.SelectedItem = dyeName;
        }

        private void SetCurrentRole(SiegeLoadout loadout)
        {
            comBoxRole.SelectedItem = loadout.Role.Name;
        }

        private void SetCurrentSlotItems(BaseLoadout loadout)
        {
            List<SlotItem> slotItems = loadout.SlotItems.ToList();

            for (int i = 0; i < BaseLoadout.SLOT_ITEMS_COUNT; i++)
            {
                SlotItem current = slotItems[i];
                ComBoxLoadoutSlots[i].SelectedItem = current?.Name;
            }
        }

        private void SetCurrentSiegeSlotItems(BaseLoadout loadout)
        {
            List<SlotItem> slotItems = loadout.SlotItems.ToList();

            for (int i = 0; i < BaseLoadout.SLOT_ITEMS_COUNT; i++)
            {
                SlotItem current = slotItems[i];
                ComBoxSiegeLoadoutSlots[i].SelectedItem = current?.SiegeName ?? current?.Name;
            }
        }

        private void SetCurrentTrapParts(SurvivalLoadout loadout)
        {
            List<List<TrapPart>> trapParts = ConvertArrayToListOfLists(loadout.TrapParts);

            for (int i = 0; i < BaseLoadout.SLOT_ITEMS_COUNT; i++)
            {
                for (int j = 0; j < SurvivalLoadout.TRAP_PART_SLOT_COUNT; j++)
                {
                    if (i < ComBoxTrapPartsSlots.Count && j < ComBoxTrapPartsSlots[i].Count)
                    {
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

        private void SaveLoadoutItem(int slotItemIdx)
        {
            string slotItemName = ComBoxLoadoutSlots[slotItemIdx].Text;
            GameInfo.SurvivalLoadout.SlotItems[slotItemIdx] = slotItemName.Length > 0 ? SlotItem.GetAllSlotItems()[slotItemName] : null;
            UpdateLoadoutExportCode();
        }

        private void SaveTrapPart(int slotIdx, int partIdx)
        {
            string partName = ComBoxTrapPartsSlots[slotIdx][partIdx].Text;
            ((SurvivalLoadout)GameInfo.SurvivalLoadout).TrapParts[slotIdx, partIdx] = partName.Length > 0 ? TrapPart.TrapParts[partName] : null;
            UpdateLoadoutExportCode();
        }

        private void UpdateLoadoutExportCode()
        {
            string encodedLoadout = GameInfo.SurvivalLoadout.Encode();
            textBoxExportLoadout.Text = encodedLoadout;
            maskedTextBoxHostGamePlayer1Loadout.Text = encodedLoadout;
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

            if (SurvivalLoadouts.Instance.Exists(loadoutName))
            {
                SurvivalLoadouts.Instance.UpdateLoadout(loadoutName, loadoutCode);
            }
            else
            {
                SurvivalLoadouts.Instance.AddLoadout(loadoutName, loadoutCode);
                comBoxLoadouts.Items.Add(loadoutName);
            }

            SurvivalLoadouts.Instance.Save();
            comBoxLoadouts.SelectedItem = loadoutName;
        }

        private void maskedTextBoxLoadoutName_TextChanged(object sender, EventArgs e)
        {
            string loadoutName = maskedTextBoxLoadoutName.Text;
            var (isValid, errorMessage) = InputValidator.ValidateLoadoutName(loadoutName);

            errorProvider.SetError(maskedTextBoxLoadoutName, isValid ? string.Empty : errorMessage);

            GameInfo.SurvivalLoadout.Name = loadoutName;
        }

        private void maskedTextBoxPlayerName_TextChanged(object sender, EventArgs e)
        {
            string playerName = maskedTextBoxPlayerName.Text;
            var (isValid, errorMessage) = InputValidator.ValidatePlayerName(playerName);

            errorProvider.SetError(maskedTextBoxPlayerName, isValid ? string.Empty: errorMessage);

            GameInfo.SurvivalLoadout.PlayerName = playerName;
            UpdateLoadoutExportCode();
        }

        private void comBoxLoadouts_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SuspendLayout();

            string selectedLoadoutName = comBoxLoadouts.SelectedItem.ToString();
            string selectedLoadoutCode = SurvivalLoadouts.Instance.GetLoadoutByName(selectedLoadoutName).Code;
            SurvivalLoadout survivalLoadout = new SurvivalLoadout();
            survivalLoadout.Decode(selectedLoadoutCode);
            GameInfo.SurvivalLoadout = survivalLoadout;

            SetCurrentHero(survivalLoadout);
            SetCurrentGuardians(survivalLoadout);
            SetCurrentConsumables(survivalLoadout);
            SetCurrentTraits(survivalLoadout);
            SetCurrentSlotItems(survivalLoadout);
            SetCurrentTrapParts(survivalLoadout);

            maskedTextBoxLoadoutName.Text = selectedLoadoutName;
            maskedTextBoxPlayerName.Text = survivalLoadout.PlayerName;

            if (comBoxLoadouts.Items.Count > 0)
            {
                btnDeleteLoadout.Enabled = true;
            }

            this.ResumeLayout();
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
            SurvivalLoadout survivalLoadout = new SurvivalLoadout();
            survivalLoadout.Decode(loadoutCode);
            GameInfo.SurvivalLoadout = survivalLoadout;

            string loadoutName = "";
            while (loadoutName.Length == 0 || SurvivalLoadouts.Instance.Exists(loadoutName))
            {
                loadoutName = survivalLoadout.PlayerName + "-Imported-" + Guid.NewGuid().ToString().Substring(0, 8);
            }

            SurvivalLoadouts.Instance.AddLoadout(loadoutName, loadoutCode);
            SurvivalLoadouts.Instance.Save();

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
            SurvivalLoadouts.Instance.RemoveLoadout(selectedLoadoutName);
            SurvivalLoadouts.Instance.Save();
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

        private void buttonOpenLoadoutEditor_Click(object sender, EventArgs e)
        {
            this.SuspendLayout();
            panelLoadoutEditor.Visible = true;
            groupBoxLoadout.Visible = true;
            this.ResumeLayout();
        }

        private void comBoxAdditionalHeroWeapon_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mods.Mods.AdditionalHeroWeapon.Value = comBoxAdditionalHeroWeapon.Text;
            GameConfig.Instance.AdditionalHeroWeapon = comBoxAdditionalHeroWeapon.Text;
            GameConfig.Instance.Save();
        }

        private void chkAdditionalHeroWeapon_CheckedChanged(object sender, EventArgs e)
        {
            comBoxAdditionalHeroWeapon.Enabled = chkAdditionalHeroWeapon.Checked;
            GameConfig.Instance.AdditionalHeroWeaponEnabled = chkAdditionalHeroWeapon.Checked;
            GameConfig.Instance.Save();
        }

        private void comBoxSiegeLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedLanguage = comBoxLanguage.SelectedItem.ToString();
            Settings.Instance.Language = selectedLanguage;
            Settings.Instance.Save();
        }

        private void maskedTextBoxJoinSiegeGameHostIP_TextChanged(object sender, EventArgs e)
        {
            string hostIP = maskedTextBoxJoinSiegeGameHostIP.Text;
            var (isValid, errorMessage) = InputValidator.ValidateIpAddress(hostIP);

            errorProvider.SetError(maskedTextBoxJoinSiegeGameHostIP, isValid || hostIP.Length == 0 ? string.Empty : errorMessage);
        }

        private void btnJoinSiegeGame_Click(object sender, EventArgs e)
        {
            GameLauncher.ApplyChanges(isHost: false, isSiege: true);
            SaveSettings();

            string hostIP = maskedTextBoxJoinSiegeGameHostIP.Text;
            string loadoutCode = maskedTextBoxJoinSiegeGameLoadout.Text;
            var (isIPValid, errorMessageIp) = InputValidator.ValidateIpAddress(hostIP);
            var (isLoadoutValid, errorMessagePlayerName) = InputValidator.ValidateSiegeLoadoutCode(loadoutCode);

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

            SiegeLoadout loadout = new SiegeLoadout();
            loadout.Decode(loadoutCode);
            string playerName = loadout.PlayerName;
            loadout.PlayerName = "0";
            GameFiles.CharacterData.ApplySiegeLoadout(loadout);
            loadout.PlayerName = playerName;
            GameLauncher.StartGame(loadout.PlayerName, isHost: false, hostIP);
        }

        private void btnSiegeLaunch_Click(object sender, EventArgs e)
        {
            GameLauncher.ApplyChanges(isHost: true, isSiege: true);
            SaveSettings();

            string playerName = maskedTextBoxSiegePlayerName.Text;
            var (isPlayerNameValid, errorMessagePlayerName) = InputValidator.ValidatePlayerName(playerName);

            if (!isPlayerNameValid)
            {
                MessageBox.Show(errorMessagePlayerName, "Invalid Player Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var invalidLoadouts = ValidateAllSiegeLoadoutCodes();
            if (invalidLoadouts.Any())
            {
                string errorMessage = "Some loadouts are invalid:\n" + string.Join("\n", invalidLoadouts);
                MessageBox.Show(errorMessage, "Invalid Loadouts", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ApplyAllSiegeLoadouts();
            GameLauncher.StartGame(GameInfo.SiegeLoadout.PlayerName, isHost: true);
        }

        private (bool isValid, string errorMessage) ValidateSiegeLoadoutCode(MaskedTextBox maskedTextBox)
        {
            string loadoutCode = maskedTextBox.Text;

            if (string.IsNullOrWhiteSpace(loadoutCode))
            {
                return (true, string.Empty);
            }

            var (isValid, validationErrorMessage) = InputValidator.ValidateSiegeLoadoutCode(loadoutCode);

            errorProvider.SetError(maskedTextBox, isValid ? string.Empty : validationErrorMessage);

            return (isValid, isValid ? string.Empty : validationErrorMessage);
        }

        private List<string> ValidateAllSiegeLoadoutCodes()
        {
            var invalidLoadouts = new List<string>();

            var loadouts = new Dictionary<string, MaskedTextBox>
            {
                { "Player 1", maskedTextBoxSiegeHostGamePlayer1Loadout },
                { "Player 2", maskedTextBoxSiegeHostGamePlayer2Loadout },
                { "Player 3", maskedTextBoxSiegeHostGamePlayer3Loadout },
                { "Player 4", maskedTextBoxSiegeHostGamePlayer4Loadout },
                { "Player 5", maskedTextBoxSiegeHostGamePlayer5Loadout },
                { "Player 6", maskedTextBoxSiegeHostGamePlayer6Loadout },
                { "Player 7", maskedTextBoxSiegeHostGamePlayer7Loadout },
                { "Player 8", maskedTextBoxSiegeHostGamePlayer8Loadout },
                { "Player 9", maskedTextBoxSiegeHostGamePlayer9Loadout },
                { "Player 10", maskedTextBoxSiegeHostGamePlayer10Loadout },
            };

            foreach (var loadout in loadouts)
            {
                var (isValid, errorMessage) = ValidateSiegeLoadoutCode(loadout.Value);
                if (!isValid && !string.IsNullOrEmpty(errorMessage))
                {
                    invalidLoadouts.Add($"{loadout.Key}: {errorMessage}");
                }
            }

            return invalidLoadouts;
        }

        private void ApplyAllSiegeLoadouts()
        {
            var loadoutsTeam1 = new List<MaskedTextBox>
            {
                maskedTextBoxSiegeHostGamePlayer1Loadout,
                maskedTextBoxSiegeHostGamePlayer2Loadout,
                maskedTextBoxSiegeHostGamePlayer3Loadout,
                maskedTextBoxSiegeHostGamePlayer4Loadout,
                maskedTextBoxSiegeHostGamePlayer5Loadout,
            };

            var loadoutsTeam2 = new List<MaskedTextBox>
            {
                maskedTextBoxSiegeHostGamePlayer6Loadout,
                maskedTextBoxSiegeHostGamePlayer7Loadout,
                maskedTextBoxSiegeHostGamePlayer8Loadout,
                maskedTextBoxSiegeHostGamePlayer9Loadout,
                maskedTextBoxSiegeHostGamePlayer10Loadout
            };

            bool randomBool = random.Next(0, 2) == 0;

            int team1 = randomBool ? 1 : 2;
            int team2 = randomBool ? 2 : 1;

            for (int i = 0; i < loadoutsTeam1.Count; i++)
            {
                if (!string.IsNullOrWhiteSpace(loadoutsTeam1[i].Text))
                {
                    SiegeLoadout siegeLoadout = new SiegeLoadout();
                    GameFiles.CharacterData.ApplySiegeLoadout((SiegeLoadout)siegeLoadout.Decode(loadoutsTeam1[i].Text), team1);
                }
                if (!string.IsNullOrWhiteSpace(loadoutsTeam2[i].Text))
                {
                    SiegeLoadout siegeLoadout = new SiegeLoadout();
                    GameFiles.CharacterData.ApplySiegeLoadout((SiegeLoadout)siegeLoadout.Decode(loadoutsTeam2[i].Text), team2);
                }
            }
        }

        private void btnCopySiegeLoadoutToClipboard_Click(object sender, EventArgs e)
        {
            string loadoutCode = textBoxExportSiegeLoadout.Text;

            var (isLoadoutCodeValid, errorMessageLoadout) = InputValidator.ValidateSiegeLoadoutCode(loadoutCode);

            if (!isLoadoutCodeValid)
            {
                MessageBox.Show(errorMessageLoadout, "Invalid Loadout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Clipboard.SetText(loadoutCode);
            maskedTextBoxJoinSiegeGameLoadout.Text = loadoutCode;
        }

        private void btnSaveSiegeLoadout_Click(object sender, EventArgs e)
        {
            string loadoutName = maskedTextBoxSiegeLoadoutName.Text;
            string loadoutCode = textBoxExportSiegeLoadout.Text;
            var (isLoadoutValid, errorMessageLoadout) = InputValidator.ValidateSiegeLoadoutCode(loadoutCode);
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

            if (SiegeLoadouts.Instance.Exists(loadoutName))
            {
                SiegeLoadouts.Instance.UpdateLoadout(loadoutName, loadoutCode);
            }
            else
            {
                SiegeLoadouts.Instance.AddLoadout(loadoutName, loadoutCode);
                comBoxSiegeLoadouts.Items.Add(loadoutName);
            }

            SiegeLoadouts.Instance.Save();
            comBoxSiegeLoadouts.SelectedItem = loadoutName;
        }

        private void maskedTextBoxSiegeLoadoutName_TextChanged(object sender, EventArgs e)
        {
            string loadoutName = maskedTextBoxSiegeLoadoutName.Text;
            var (isValid, errorMessage) = InputValidator.ValidateLoadoutName(loadoutName);

            errorProvider.SetError(maskedTextBoxSiegeLoadoutName, isValid ? string.Empty : errorMessage);

            GameInfo.SiegeLoadout.Name = loadoutName;
        }

        private void maskedTextBoxSiegePlayerName_TextChanged(object sender, EventArgs e)
        {
            string playerName = maskedTextBoxSiegePlayerName.Text;
            var (isValid, errorMessage) = InputValidator.ValidatePlayerName(playerName);

            errorProvider.SetError(maskedTextBoxSiegePlayerName, isValid ? string.Empty : errorMessage);

            GameInfo.SiegeLoadout.PlayerName = playerName;
            UpdateSiegeLoadoutExportCode();
        }

        private void comBoxSiegeLoadouts_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SuspendLayout();

            string selectedLoadoutName = comBoxSiegeLoadouts.SelectedItem.ToString();
            string selectedLoadoutCode = SiegeLoadouts.Instance.GetLoadoutByName(selectedLoadoutName).Code;
            SiegeLoadout siegeLoadout = new SiegeLoadout();
            siegeLoadout.Decode(selectedLoadoutCode);
            GameInfo.SiegeLoadout = siegeLoadout;

            SetCurrentSiegeHero(siegeLoadout);
            SetCurrentSiegeSlotItems(siegeLoadout);
            SetCurrentRole(siegeLoadout);
            SetCurrentSiegeTraits(siegeLoadout);
            SetCurrentWaves(siegeLoadout);

            maskedTextBoxSiegeLoadoutName.Text = selectedLoadoutName;
            maskedTextBoxSiegePlayerName.Text = siegeLoadout.PlayerName;

            if (comBoxSiegeLoadouts.Items.Count > 0)
            {
                btnDeleteSiegeLoadout.Enabled = true;
            }

            this.ResumeLayout();
        }

        private void btnImportSiegeLoadout_Click(object sender, EventArgs e)
        {
            var (isValid, errorMessage) = InputValidator.ValidateSiegeLoadoutCode(maskedTextBoxImportSiegeLoadout.Text);

            if (!isValid)
            {
                MessageBox.Show(errorMessage, "Invalid Import Loadout Code", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string loadoutCode = maskedTextBoxImportSiegeLoadout.Text;
            SiegeLoadout siegeLoadout = new SiegeLoadout();
            siegeLoadout.Decode(loadoutCode);
            GameInfo.SiegeLoadout = siegeLoadout;

            string loadoutName = "";
            while (loadoutName.Length == 0 || SiegeLoadouts.Instance.Exists(loadoutName))
            {
                loadoutName = siegeLoadout.PlayerName + "-Imported-" + Guid.NewGuid().ToString().Substring(0, 8);
            }

            SiegeLoadouts.Instance.AddLoadout(loadoutName, loadoutCode);
            SiegeLoadouts.Instance.Save();

            comBoxSiegeLoadouts.Items.Add(loadoutName);
            comBoxSiegeLoadouts.SelectedItem = loadoutName;
            btnImportSiegeLoadout.Enabled = false;
            maskedTextBoxImportSiegeLoadout.Text = "";
        }

        private void maskedTextBoxImportSiegeLoadout_TextChanged(object sender, EventArgs e)
        {
            btnImportSiegeLoadout.Enabled = true;
            string loadoutCode = maskedTextBoxImportSiegeLoadout.Text;
            if (loadoutCode.Length == 0)
            {
                errorProvider.SetError(maskedTextBoxImportSiegeLoadout, string.Empty);
                btnImportSiegeLoadout.Enabled = false;
                return;
            }

            var (isValid, errorMessage) = InputValidator.ValidateSiegeLoadoutCode(loadoutCode);

            errorProvider.SetError(maskedTextBoxImportSiegeLoadout, isValid ? string.Empty : errorMessage);
        }

        private void btnDeleteSiegeLoadout_Click(object sender, EventArgs e)
        {
            string selectedLoadoutName = comBoxSiegeLoadouts.SelectedItem.ToString();
            SiegeLoadouts.Instance.RemoveLoadout(selectedLoadoutName);
            SiegeLoadouts.Instance.Save();
            comBoxSiegeLoadouts.Items.Remove(selectedLoadoutName);
            comBoxSiegeLoadouts.SelectedIndex = comBoxSiegeLoadouts.Items.Count == 0 ? -1 : 0;

            if (comBoxSiegeLoadouts.Items.Count == 0)
            {
                btnDeleteSiegeLoadout.Enabled = false;
            }
        }

        private void UpdateSiegeLoadoutExportCode()
        {
            string encodedLoadout = GameInfo.SiegeLoadout.Encode();
            textBoxExportSiegeLoadout.Text = encodedLoadout;
            maskedTextBoxSiegeHostGamePlayer1Loadout.Text = encodedLoadout;
        }

        private void comBoxSiegeHero_SelectedIndexChanged(object sender, EventArgs e)
        {
            comBoxSiegeSkin.Items.Clear();

            string selectedHero = comBoxSiegeHero.SelectedItem.ToString();
            GameInfo.SiegeLoadout.Hero = Model.Hero.SiegeHeroes[selectedHero];

            if (GameInfo.SiegeLoadout.Hero.Skins != null)
            {
                PopulateSlots(new List<ComboBox> { comBoxSiegeSkin }, GameInfo.SiegeLoadout.Hero.SiegeSkins.Select(s => s.Name).ToList(), addEmptyOption: false);

                comBoxSiegeSkin.SelectedItem = GameInfo.SiegeLoadout.Hero.SiegeSkins[0].Name;
                GameInfo.SiegeLoadout.Hero = Model.Hero.SiegeHeroes[selectedHero];
                UpdateSiegeLoadoutExportCode();
            }
        }

        private void comBoxSiegeSkin_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSkin = comBoxSiegeSkin.SelectedItem.ToString();
            GameInfo.SiegeLoadout.Skin = Model.Skin.Skins[selectedSkin];
            UpdateSiegeLoadoutExportCode();
        }

        private void comBoxSiegeDye_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDye = comBoxSiegeDye.SelectedItem.ToString();
            GameInfo.SiegeLoadout.Dye = Model.Dye.Dyes[selectedDye];
            UpdateSiegeLoadoutExportCode();
        }

        private void SaveSiegeLoadoutItem(int slotItemIdx)
        {
            string slotItemName = ComBoxSiegeLoadoutSlots[slotItemIdx].Text;
            GameInfo.SiegeLoadout.SlotItems[slotItemIdx] = slotItemName.Length > 0 ? SlotItem.GetAllSiegeSlotItems()[slotItemName] : null;
            UpdateSiegeLoadoutExportCode();
        }

        private void comBoxSiegeLoadoutSlot1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItemSlot = ((ComboBox)sender).SelectedItem?.ToString();
            SaveSiegeLoadoutItem(1 - 1);
        }

        private void comBoxSiegeLoadoutSlot2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItemSlot = ((ComboBox)sender).SelectedItem?.ToString();
            SaveSiegeLoadoutItem(2 - 1);
        }

        private void comBoxSiegeLoadoutSlot3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItemSlot = ((ComboBox)sender).SelectedItem?.ToString();
            SaveSiegeLoadoutItem(3 - 1);
        }

        private void comBoxSiegeLoadoutSlot4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItemSlot = ((ComboBox)sender).SelectedItem?.ToString();
            SaveSiegeLoadoutItem(4 - 1);
        }

        private void comBoxSiegeLoadoutSlot5_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItemSlot = ((ComboBox)sender).SelectedItem?.ToString();
            SaveSiegeLoadoutItem(5 - 1);
        }

        private void comBoxSiegeLoadoutSlot6_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItemSlot = ((ComboBox)sender).SelectedItem?.ToString();
            SaveSiegeLoadoutItem(6 - 1);
        }

        private void comBoxSiegeLoadoutSlot7_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItemSlot = ((ComboBox)sender).SelectedItem?.ToString();
            SaveSiegeLoadoutItem(7 - 1);
        }

        private void comBoxSiegeLoadoutSlot8_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItemSlot = ((ComboBox)sender).SelectedItem?.ToString();
            SaveSiegeLoadoutItem(8 - 1);
        }

        private void comBoxSiegeLoadoutSlot9_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItemSlot = ((ComboBox)sender).SelectedItem?.ToString();
            SaveSiegeLoadoutItem(9 - 1);
        }

        private void comBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRole = comBoxRole.SelectedItem.ToString();
            GameInfo.SiegeLoadout.Role = Model.SiegeRole.Roles[selectedRole];
            UpdateSiegeLoadoutExportCode();
        }

        private void SaveSiegeTraits()
        {
            for (int i = 0; i < BaseLoadout.TRAIT_SLOT_COUNT; i++)
            {
                string traitName = ComBoxSiegeTraitSlots[i].Text;
                GameInfo.SiegeLoadout.Traits[i] = traitName.Length > 0 ? SiegeTrait.Traits[traitName] : null;
            }

            UpdateSiegeLoadoutExportCode();
        }

        private void comboxSiegeTraitYellowSlot_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveSiegeTraits();
        }

        private void comboxSiegeTraitGreenSlot_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveSiegeTraits();
        }

        private void comboxSiegeTraitBlueSlot_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveSiegeTraits();
        }

        private void comboxSiegeTraitNoBonusSlot_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveSiegeTraits();
        }

        private void SaveSiegeWaveSlot(int waveSlotIdx)
        {
            string waveSlotName = ComBoxSiegeWaveSlots[waveSlotIdx].Text;
            GameInfo.SiegeLoadout.Waves[waveSlotIdx] = waveSlotName.Length > 0 ? Wave.Waves[waveSlotName] : null;
            UpdateSiegeLoadoutExportCode();
        }

        private void comBoxSiegeLv1WaveSlot1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveSiegeWaveSlot(1 - 1);
        }

        private void comBoxSiegeLv1WaveSlot2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveSiegeWaveSlot(2 - 1);
        }

        private void comBoxSiegeLv2WaveSlot1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveSiegeWaveSlot(3 - 1);
        }

        private void comBoxSiegeLv2WaveSlot2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveSiegeWaveSlot(4 - 1);
        }

        private void comBoxSiegeLv3WaveSlot1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveSiegeWaveSlot(5 - 1);
        }

        private void comBoxSiegeLv3WaveSlot2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveSiegeWaveSlot(6 - 1);
        }

        private void comBoxSiegeLv4WaveSlot1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveSiegeWaveSlot(7 - 1);
        }

        private void comBoxSiegeLv4WaveSlot2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveSiegeWaveSlot(8 - 1);
        }

        private void comBoxSiegeBossWaveSlot1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveSiegeWaveSlot(9 - 1);
        }

        private void comBoxSiegeBossWaveSlot2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveSiegeWaveSlot(10 - 1);
        }

        private void comBoxSiegeBattleground_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedBattleground = comBoxSiegeBattleground.SelectedItem.ToString();
            GameConfig.Instance.Battleground = selectedBattleground;
            GameConfig.Instance.Save();

            GameInfo.Battleground = Model.Siege.SiegeBattlegrounds[selectedBattleground];
        }
    }
}

