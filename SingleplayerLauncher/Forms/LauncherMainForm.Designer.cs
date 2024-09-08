using SingleplayerLauncher.Model;
using System.Windows.Forms;

namespace SingleplayerLauncher
{
    partial class LauncherMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LauncherMainForm));
            btnLaunch = new Button();
            chkDebug = new CheckBox();
            battlegroundGroupBox = new GroupBox();
            comBoxExtraDifficulty = new ComboBox();
            labelExtraDifficulty = new Label();
            comBoxDifficulty = new ComboBox();
            labelDifficulty = new Label();
            comBoxGameMode = new ComboBox();
            labelGameMode = new Label();
            comBoxBattleground = new ComboBox();
            labelMap = new Label();
            btnResetConfig = new Button();
            chkShowTrapDamageFlyoffs = new CheckBox();
            chkInvincibleBarricades = new CheckBox();
            chkNoTrapGrid = new CheckBox();
            chkTrapsAnySurface = new CheckBox();
            chkHardcore = new CheckBox();
            chkNoLimitUniqueTraps = new CheckBox();
            startingCoinInput = new NumericUpDown();
            chkTrapsInTraps = new CheckBox();
            chkNoTrapCap = new CheckBox();
            chkGodMode = new CheckBox();
            modsGroupBox = new GroupBox();
            chkOverrideTrapTier = new CheckBox();
            inputOverrideTrapTier = new NumericUpDown();
            chkOverrideAccountLevel = new CheckBox();
            inputOverrideAccountLevel = new NumericUpDown();
            chkAdditionalHeroWeapon = new CheckBox();
            chkEnhancedTrapRotation = new CheckBox();
            comBoxAdditionalHeroWeapon = new ComboBox();
            chkCustomStartCoin = new CheckBox();
            chkSellTrapsAnytime = new CheckBox();
            chk_modsEnabled = new CheckBox();
            chkRunAs32 = new CheckBox();
            comBoxLanguage = new ComboBox();
            labelLanguage = new Label();
            errorProvider = new ErrorProvider(components);
            label1 = new Label();
            btnDiscord = new Button();
            maskedTextBoxHostGamePlayer1Loadout = new MaskedTextBox();
            maskedTextBoxHostGamePlayer4Loadout = new MaskedTextBox();
            maskedTextBoxHostGamePlayer3Loadout = new MaskedTextBox();
            maskedTextBoxHostGamePlayer2Loadout = new MaskedTextBox();
            maskedTextBoxHostGamePlayer5Loadout = new MaskedTextBox();
            labelHostGamePlayer1 = new Label();
            labelHostGamePlayer2 = new Label();
            labelHostGamePlayer4 = new Label();
            labelHostGamePlayer3 = new Label();
            labelHostGamePlayer5 = new Label();
            maskedTextBoxJoinGameHostIP = new MaskedTextBox();
            labelJoinGameHostIP = new Label();
            btnJoinGame = new Button();
            maskedTextBoxJoinGameLoadout = new MaskedTextBox();
            labelJoinGameLoadout = new Label();
            survivalGameTabControl = new TabControl();
            tabPage1 = new TabPage();
            linkLabelJoinGameKnownIssues = new LinkLabel();
            labelJoinGameBriefInstructions = new Label();
            labelJoinGameAdditionalInfo = new Label();
            tabPage2 = new TabPage();
            linkLabel2 = new LinkLabel();
            labelHostGameAdditionalInfo = new Label();
            labelHostGameBriefInstructions = new Label();
            toolTip1 = new ToolTip(components);
            label7 = new Label();
            label10 = new Label();
            modsPanel = new Panel();
            gameSettingsGroupBox = new GroupBox();
            panelLoadoutEditor = new Panel();
            groupBoxLoadout = new GroupBox();
            btnDeleteLoadout = new Button();
            labelPlayerName = new Label();
            maskedTextBoxPlayerName = new MaskedTextBox();
            labelLoadoutName = new Label();
            btnSaveLoadout = new Button();
            maskedTextBoxLoadoutName = new MaskedTextBox();
            btnCopyLoadoutToClipboard = new Button();
            btnImportLoadout = new Button();
            labelExportLoadout = new Label();
            textBoxExportLoadout = new TextBox();
            maskedTextBoxImportLoadout = new MaskedTextBox();
            comBoxTrapPartsSlot9Part3 = new ComboBox();
            comBoxTrapPartsSlot9Part2 = new ComboBox();
            comBoxTrapPartsSlot9Part1 = new ComboBox();
            comBoxTrapPartsSlot8Part3 = new ComboBox();
            comBoxTrapPartsSlot8Part2 = new ComboBox();
            comBoxTrapPartsSlot8Part1 = new ComboBox();
            comBoxTrapPartsSlot7Part3 = new ComboBox();
            comBoxTrapPartsSlot7Part2 = new ComboBox();
            comBoxTrapPartsSlot7Part1 = new ComboBox();
            comBoxTrapPartsSlot6Part3 = new ComboBox();
            comBoxTrapPartsSlot6Part2 = new ComboBox();
            comBoxTrapPartsSlot6Part1 = new ComboBox();
            comBoxTrapPartsSlot5Part3 = new ComboBox();
            comBoxTrapPartsSlot5Part2 = new ComboBox();
            comBoxTrapPartsSlot5Part1 = new ComboBox();
            comBoxTrapPartsSlot4Part3 = new ComboBox();
            comBoxTrapPartsSlot4Part2 = new ComboBox();
            comBoxTrapPartsSlot4Part1 = new ComboBox();
            comBoxTrapPartsSlot3Part3 = new ComboBox();
            comBoxTrapPartsSlot3Part2 = new ComboBox();
            comBoxTrapPartsSlot3Part1 = new ComboBox();
            comBoxTrapPartsSlot2Part3 = new ComboBox();
            comBoxTrapPartsSlot2Part2 = new ComboBox();
            comBoxTrapPartsSlot2Part1 = new ComboBox();
            comBoxTrapPartsSlot1Part3 = new ComboBox();
            comBoxTrapPartsSlot1Part2 = new ComboBox();
            comBoxTrapPartsSlot1Part1 = new ComboBox();
            labelTraitNoBonusSlot = new Label();
            comboxTraitYellowSlot = new ComboBox();
            labelTraitYellowSlot = new Label();
            comboxTraitNoBonusSlot = new ComboBox();
            labelTraitBlueSlot = new Label();
            comboxTraitGreenSlot = new ComboBox();
            labelTraitGreenSlot = new Label();
            comboxTraitBlueSlot = new ComboBox();
            comBoxDye = new ComboBox();
            labelHero = new Label();
            labelConsumableSlot2 = new Label();
            comBoxHero = new ComboBox();
            comBoxConsumableSlot1 = new ComboBox();
            comBoxSkin = new ComboBox();
            labelConsumableSlot1 = new Label();
            labelDye = new Label();
            comBoxConsumableSlot2 = new ComboBox();
            labelSkin = new Label();
            labelGuardianSlot2 = new Label();
            comBoxLoadouts = new ComboBox();
            labelLoadoutSlot9 = new Label();
            comBoxGuardianSlot1 = new ComboBox();
            labelGuardianSlot1 = new Label();
            labelLoadoutSlot8 = new Label();
            comBoxGuardianSlot2 = new ComboBox();
            labelLoadoutSlot7 = new Label();
            labelLoadoutSlot6 = new Label();
            labelLoadoutSlot5 = new Label();
            labelLoadoutSlot4 = new Label();
            labelLoadoutSlot3 = new Label();
            labelLoadoutSlot2 = new Label();
            labelLoadoutSlot1 = new Label();
            comBoxLoadoutSlot1 = new ComboBox();
            comBoxLoadoutSlot2 = new ComboBox();
            comBoxLoadoutSlot3 = new ComboBox();
            comBoxLoadoutSlot9 = new ComboBox();
            comBoxLoadoutSlot4 = new ComboBox();
            comBoxLoadoutSlot8 = new ComboBox();
            comBoxLoadoutSlot5 = new ComboBox();
            comBoxLoadoutSlot7 = new ComboBox();
            comBoxLoadoutSlot6 = new ComboBox();
            panel1 = new Panel();
            gameModeTabControl = new TabControl();
            gameModeSurvivalTab = new TabPage();
            gameModeSiegeTab = new TabPage();
            siegeGameTabControl = new TabControl();
            tabPage7 = new TabPage();
            btnPlaySiegeTutorial = new Button();
            linkLabel1 = new LinkLabel();
            label6 = new Label();
            maskedTextBoxJoinSiegeGameLoadout = new MaskedTextBox();
            label8 = new Label();
            btnJoinSiegeGame = new Button();
            label9 = new Label();
            maskedTextBoxJoinSiegeGameHostIP = new MaskedTextBox();
            tabPage8 = new TabPage();
            groupBox1 = new GroupBox();
            chkSiegeEnemyTeamAsBots = new CheckBox();
            comBoxSiegeDifficulty = new ComboBox();
            labelSiegeDifficulty = new Label();
            comBoxSiegeBattleground = new ComboBox();
            labelSiegeMap = new Label();
            label21 = new Label();
            maskedTextBoxSiegeHostGamePlayer8Loadout = new MaskedTextBox();
            maskedTextBoxSiegeHostGamePlayer6Loadout = new MaskedTextBox();
            maskedTextBoxSiegeHostGamePlayer9Loadout = new MaskedTextBox();
            maskedTextBoxSiegeHostGamePlayer7Loadout = new MaskedTextBox();
            label2 = new Label();
            label4 = new Label();
            label18 = new Label();
            maskedTextBoxSiegeHostGamePlayer10Loadout = new MaskedTextBox();
            label19 = new Label();
            label20 = new Label();
            label11 = new Label();
            maskedTextBoxSiegeHostGamePlayer3Loadout = new MaskedTextBox();
            maskedTextBoxSiegeHostGamePlayer1Loadout = new MaskedTextBox();
            maskedTextBoxSiegeHostGamePlayer4Loadout = new MaskedTextBox();
            btnSiegeLaunch = new Button();
            maskedTextBoxSiegeHostGamePlayer2Loadout = new MaskedTextBox();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            maskedTextBoxSiegeHostGamePlayer5Loadout = new MaskedTextBox();
            label15 = new Label();
            label16 = new Label();
            siegeGameSettingsGroupBox = new GroupBox();
            comBoxSiegeLanguage = new ComboBox();
            labelSiegeLanguage = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            loadoutEditorTabControl = new TabControl();
            loadoutEditorSurvivalTab = new TabPage();
            loadoutEditorSiegeTab = new TabPage();
            siegeLoadoutEditorGroupBox = new GroupBox();
            comBoxRole = new ComboBox();
            roleLabel = new Label();
            comBoxSiegeBossWaveSlot2 = new ComboBox();
            label45 = new Label();
            comBoxSiegeBossWaveSlot1 = new ComboBox();
            comBoxSiegeLv4WaveSlot2 = new ComboBox();
            label36 = new Label();
            comBoxSiegeLv4WaveSlot1 = new ComboBox();
            comBoxSiegeLv3WaveSlot2 = new ComboBox();
            label34 = new Label();
            comBoxSiegeLv3WaveSlot1 = new ComboBox();
            comBoxSiegeLv2WaveSlot2 = new ComboBox();
            label31 = new Label();
            comBoxSiegeLv2WaveSlot1 = new ComboBox();
            comBoxSiegeLv1WaveSlot2 = new ComboBox();
            label30 = new Label();
            comBoxSiegeLv1WaveSlot1 = new ComboBox();
            btnDeleteSiegeLoadout = new Button();
            label22 = new Label();
            maskedTextBoxSiegePlayerName = new MaskedTextBox();
            label23 = new Label();
            btnSaveSiegeLoadout = new Button();
            maskedTextBoxSiegeLoadoutName = new MaskedTextBox();
            btnCopySiegeLoadoutToClipboard = new Button();
            btnImportSiegeLoadout = new Button();
            label24 = new Label();
            textBoxExportSiegeLoadout = new TextBox();
            maskedTextBoxImportSiegeLoadout = new MaskedTextBox();
            label25 = new Label();
            comboxSiegeTraitYellowSlot = new ComboBox();
            label26 = new Label();
            comboxSiegeTraitNoBonusSlot = new ComboBox();
            label27 = new Label();
            comboxSiegeTraitGreenSlot = new ComboBox();
            label28 = new Label();
            comboxSiegeTraitBlueSlot = new ComboBox();
            comBoxSiegeDye = new ComboBox();
            label29 = new Label();
            comBoxSiegeHero = new ComboBox();
            comBoxSiegeSkin = new ComboBox();
            label32 = new Label();
            label33 = new Label();
            comBoxSiegeLoadouts = new ComboBox();
            label35 = new Label();
            label37 = new Label();
            label38 = new Label();
            label39 = new Label();
            label40 = new Label();
            label41 = new Label();
            label42 = new Label();
            label43 = new Label();
            label44 = new Label();
            comBoxSiegeLoadoutSlot1 = new ComboBox();
            comBoxSiegeLoadoutSlot2 = new ComboBox();
            comBoxSiegeLoadoutSlot3 = new ComboBox();
            comBoxSiegeLoadoutSlot9 = new ComboBox();
            comBoxSiegeLoadoutSlot4 = new ComboBox();
            comBoxSiegeLoadoutSlot8 = new ComboBox();
            comBoxSiegeLoadoutSlot5 = new ComboBox();
            comBoxSiegeLoadoutSlot7 = new ComboBox();
            comBoxSiegeLoadoutSlot6 = new ComboBox();
            labelOverrideLevels = new Label();
            label3 = new Label();
            battlegroundGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)startingCoinInput).BeginInit();
            modsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)inputOverrideTrapTier).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inputOverrideAccountLevel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            survivalGameTabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            modsPanel.SuspendLayout();
            gameSettingsGroupBox.SuspendLayout();
            groupBoxLoadout.SuspendLayout();
            panel1.SuspendLayout();
            gameModeTabControl.SuspendLayout();
            gameModeSurvivalTab.SuspendLayout();
            gameModeSiegeTab.SuspendLayout();
            siegeGameTabControl.SuspendLayout();
            tabPage7.SuspendLayout();
            tabPage8.SuspendLayout();
            groupBox1.SuspendLayout();
            siegeGameSettingsGroupBox.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            loadoutEditorTabControl.SuspendLayout();
            loadoutEditorSurvivalTab.SuspendLayout();
            loadoutEditorSiegeTab.SuspendLayout();
            siegeLoadoutEditorGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // btnLaunch
            // 
            btnLaunch.BackColor = System.Drawing.Color.SpringGreen;
            btnLaunch.Location = new System.Drawing.Point(228, 365);
            btnLaunch.Margin = new Padding(4, 3, 4, 3);
            btnLaunch.Name = "btnLaunch";
            btnLaunch.Size = new System.Drawing.Size(144, 69);
            btnLaunch.TabIndex = 0;
            btnLaunch.Text = "Launch Match";
            btnLaunch.UseVisualStyleBackColor = false;
            btnLaunch.Click += btnLaunch_Click;
            // 
            // chkDebug
            // 
            chkDebug.AutoSize = true;
            chkDebug.Location = new System.Drawing.Point(230, 650);
            chkDebug.Margin = new Padding(4, 3, 4, 3);
            chkDebug.Name = "chkDebug";
            chkDebug.Size = new System.Drawing.Size(61, 19);
            chkDebug.TabIndex = 6;
            chkDebug.Text = "Debug";
            chkDebug.UseVisualStyleBackColor = true;
            // 
            // battlegroundGroupBox
            // 
            battlegroundGroupBox.BackColor = System.Drawing.SystemColors.Control;
            battlegroundGroupBox.Controls.Add(comBoxExtraDifficulty);
            battlegroundGroupBox.Controls.Add(labelExtraDifficulty);
            battlegroundGroupBox.Controls.Add(comBoxDifficulty);
            battlegroundGroupBox.Controls.Add(labelDifficulty);
            battlegroundGroupBox.Controls.Add(comBoxGameMode);
            battlegroundGroupBox.Controls.Add(labelGameMode);
            battlegroundGroupBox.Controls.Add(comBoxBattleground);
            battlegroundGroupBox.Controls.Add(labelMap);
            battlegroundGroupBox.Location = new System.Drawing.Point(3, 7);
            battlegroundGroupBox.Margin = new Padding(4, 3, 4, 3);
            battlegroundGroupBox.Name = "battlegroundGroupBox";
            battlegroundGroupBox.Padding = new Padding(4, 3, 4, 3);
            battlegroundGroupBox.Size = new System.Drawing.Size(385, 89);
            battlegroundGroupBox.TabIndex = 8;
            battlegroundGroupBox.TabStop = false;
            battlegroundGroupBox.Text = "Battleground";
            // 
            // comBoxExtraDifficulty
            // 
            comBoxExtraDifficulty.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxExtraDifficulty.FormattingEnabled = true;
            comBoxExtraDifficulty.Location = new System.Drawing.Point(276, 55);
            comBoxExtraDifficulty.Margin = new Padding(4, 3, 4, 3);
            comBoxExtraDifficulty.Name = "comBoxExtraDifficulty";
            comBoxExtraDifficulty.Size = new System.Drawing.Size(104, 23);
            comBoxExtraDifficulty.TabIndex = 9;
            comBoxExtraDifficulty.SelectedIndexChanged += comBoxExtraDifficulty_SelectedIndexChanged;
            // 
            // labelExtraDifficulty
            // 
            labelExtraDifficulty.AutoSize = true;
            labelExtraDifficulty.Location = new System.Drawing.Point(183, 59);
            labelExtraDifficulty.Margin = new Padding(4, 0, 4, 0);
            labelExtraDifficulty.Name = "labelExtraDifficulty";
            labelExtraDifficulty.Size = new System.Drawing.Size(84, 15);
            labelExtraDifficulty.TabIndex = 8;
            labelExtraDifficulty.Text = "Extra Difficulty";
            // 
            // comBoxDifficulty
            // 
            comBoxDifficulty.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxDifficulty.Enabled = false;
            comBoxDifficulty.FormattingEnabled = true;
            comBoxDifficulty.Location = new System.Drawing.Point(245, 24);
            comBoxDifficulty.Margin = new Padding(4, 3, 4, 3);
            comBoxDifficulty.Name = "comBoxDifficulty";
            comBoxDifficulty.Size = new System.Drawing.Size(135, 23);
            comBoxDifficulty.TabIndex = 7;
            comBoxDifficulty.SelectedIndexChanged += comBoxDifficulty_SelectedIndexChanged;
            // 
            // labelDifficulty
            // 
            labelDifficulty.AutoSize = true;
            labelDifficulty.Location = new System.Drawing.Point(183, 28);
            labelDifficulty.Margin = new Padding(4, 0, 4, 0);
            labelDifficulty.Name = "labelDifficulty";
            labelDifficulty.Size = new System.Drawing.Size(55, 15);
            labelDifficulty.TabIndex = 6;
            labelDifficulty.Text = "Difficulty";
            // 
            // comBoxGameMode
            // 
            comBoxGameMode.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxGameMode.FormattingEnabled = true;
            comBoxGameMode.Location = new System.Drawing.Point(45, 24);
            comBoxGameMode.Margin = new Padding(4, 3, 4, 3);
            comBoxGameMode.Name = "comBoxGameMode";
            comBoxGameMode.Size = new System.Drawing.Size(127, 23);
            comBoxGameMode.TabIndex = 5;
            comBoxGameMode.SelectedIndexChanged += comBoxGameMode_SelectedIndexChanged;
            // 
            // labelGameMode
            // 
            labelGameMode.AutoSize = true;
            labelGameMode.Location = new System.Drawing.Point(5, 30);
            labelGameMode.Margin = new Padding(4, 0, 4, 0);
            labelGameMode.Name = "labelGameMode";
            labelGameMode.Size = new System.Drawing.Size(38, 15);
            labelGameMode.TabIndex = 2;
            labelGameMode.Text = "Mode";
            // 
            // comBoxBattleground
            // 
            comBoxBattleground.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxBattleground.FormattingEnabled = true;
            comBoxBattleground.Location = new System.Drawing.Point(45, 55);
            comBoxBattleground.Margin = new Padding(4, 3, 4, 3);
            comBoxBattleground.Name = "comBoxBattleground";
            comBoxBattleground.Size = new System.Drawing.Size(127, 23);
            comBoxBattleground.TabIndex = 1;
            comBoxBattleground.SelectedIndexChanged += comBoxBattleground_SelectedIndexChanged;
            // 
            // labelMap
            // 
            labelMap.AutoSize = true;
            labelMap.Location = new System.Drawing.Point(5, 59);
            labelMap.Margin = new Padding(4, 0, 4, 0);
            labelMap.Name = "labelMap";
            labelMap.Size = new System.Drawing.Size(31, 15);
            labelMap.TabIndex = 0;
            labelMap.Text = "Map";
            // 
            // btnResetConfig
            // 
            btnResetConfig.Location = new System.Drawing.Point(304, 645);
            btnResetConfig.Margin = new Padding(4, 3, 4, 3);
            btnResetConfig.Name = "btnResetConfig";
            btnResetConfig.Size = new System.Drawing.Size(97, 27);
            btnResetConfig.TabIndex = 9;
            btnResetConfig.Text = "Reset Configs";
            btnResetConfig.UseVisualStyleBackColor = true;
            btnResetConfig.Click += btnResetConfig_Click;
            // 
            // chkShowTrapDamageFlyoffs
            // 
            chkShowTrapDamageFlyoffs.AutoSize = true;
            chkShowTrapDamageFlyoffs.Location = new System.Drawing.Point(233, 44);
            chkShowTrapDamageFlyoffs.Margin = new Padding(4, 3, 4, 3);
            chkShowTrapDamageFlyoffs.Name = "chkShowTrapDamageFlyoffs";
            chkShowTrapDamageFlyoffs.Size = new System.Drawing.Size(127, 19);
            chkShowTrapDamageFlyoffs.TabIndex = 21;
            chkShowTrapDamageFlyoffs.Text = "Show Trap Damage";
            chkShowTrapDamageFlyoffs.UseVisualStyleBackColor = true;
            chkShowTrapDamageFlyoffs.CheckedChanged += chkShowTrapDamageFlyoffs_CheckedChanged;
            // 
            // chkInvincibleBarricades
            // 
            chkInvincibleBarricades.AutoSize = true;
            chkInvincibleBarricades.Location = new System.Drawing.Point(8, 95);
            chkInvincibleBarricades.Margin = new Padding(4, 3, 4, 3);
            chkInvincibleBarricades.Name = "chkInvincibleBarricades";
            chkInvincibleBarricades.Size = new System.Drawing.Size(134, 19);
            chkInvincibleBarricades.TabIndex = 20;
            chkInvincibleBarricades.Text = "Invincible Barricades";
            chkInvincibleBarricades.UseVisualStyleBackColor = true;
            chkInvincibleBarricades.CheckedChanged += chkInvincibleBarricades_CheckedChanged;
            // 
            // chkNoTrapGrid
            // 
            chkNoTrapGrid.AutoSize = true;
            chkNoTrapGrid.Location = new System.Drawing.Point(199, 115);
            chkNoTrapGrid.Margin = new Padding(4, 3, 4, 3);
            chkNoTrapGrid.Name = "chkNoTrapGrid";
            chkNoTrapGrid.Size = new System.Drawing.Size(91, 19);
            chkNoTrapGrid.TabIndex = 19;
            chkNoTrapGrid.Text = "No trap Grid";
            chkNoTrapGrid.UseVisualStyleBackColor = true;
            chkNoTrapGrid.CheckedChanged += chkNoTrapGrid_CheckedChanged;
            // 
            // chkTrapsAnySurface
            // 
            chkTrapsAnySurface.AutoSize = true;
            chkTrapsAnySurface.Location = new System.Drawing.Point(199, 62);
            chkTrapsAnySurface.Margin = new Padding(4, 3, 4, 3);
            chkTrapsAnySurface.Name = "chkTrapsAnySurface";
            chkTrapsAnySurface.Size = new System.Drawing.Size(134, 19);
            chkTrapsAnySurface.TabIndex = 18;
            chkTrapsAnySurface.Text = "Traps on any Surface";
            chkTrapsAnySurface.UseVisualStyleBackColor = true;
            chkTrapsAnySurface.CheckedChanged += chkTrapsAnySurface_CheckedChanged;
            // 
            // chkHardcore
            // 
            chkHardcore.AutoSize = true;
            chkHardcore.Location = new System.Drawing.Point(9, 204);
            chkHardcore.Margin = new Padding(4, 3, 4, 3);
            chkHardcore.Name = "chkHardcore";
            chkHardcore.Size = new System.Drawing.Size(111, 19);
            chkHardcore.TabIndex = 17;
            chkHardcore.Text = "Hardcore (1 life)";
            chkHardcore.UseVisualStyleBackColor = true;
            chkHardcore.CheckedChanged += chkHardcore_CheckedChanged;
            // 
            // chkNoLimitUniqueTraps
            // 
            chkNoLimitUniqueTraps.AutoSize = true;
            chkNoLimitUniqueTraps.Location = new System.Drawing.Point(8, 122);
            chkNoLimitUniqueTraps.Margin = new Padding(4, 3, 4, 3);
            chkNoLimitUniqueTraps.Name = "chkNoLimitUniqueTraps";
            chkNoLimitUniqueTraps.Size = new System.Drawing.Size(143, 19);
            chkNoLimitUniqueTraps.TabIndex = 16;
            chkNoLimitUniqueTraps.Text = "No Limit Unique Traps";
            chkNoLimitUniqueTraps.UseVisualStyleBackColor = true;
            chkNoLimitUniqueTraps.CheckedChanged += chkNoLimitUniqueTraps_CheckedChanged;
            // 
            // startingCoinInput
            // 
            startingCoinInput.Increment = new decimal(new int[] { 50, 0, 0, 0 });
            startingCoinInput.Location = new System.Drawing.Point(290, 226);
            startingCoinInput.Margin = new Padding(4, 3, 4, 3);
            startingCoinInput.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            startingCoinInput.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            startingCoinInput.Name = "startingCoinInput";
            startingCoinInput.Size = new System.Drawing.Size(99, 23);
            startingCoinInput.TabIndex = 14;
            startingCoinInput.ValueChanged += StartingCoinInput_ValueChanged;
            // 
            // chkTrapsInTraps
            // 
            chkTrapsInTraps.AutoSize = true;
            chkTrapsInTraps.Location = new System.Drawing.Point(199, 89);
            chkTrapsInTraps.Margin = new Padding(4, 3, 4, 3);
            chkTrapsInTraps.Name = "chkTrapsInTraps";
            chkTrapsInTraps.Size = new System.Drawing.Size(117, 19);
            chkTrapsInTraps.TabIndex = 13;
            chkTrapsInTraps.Text = "Traps can overlap";
            chkTrapsInTraps.UseVisualStyleBackColor = true;
            chkTrapsInTraps.CheckedChanged += chkTrapsInTraps_CheckedChanged;
            // 
            // chkNoTrapCap
            // 
            chkNoTrapCap.AutoSize = true;
            chkNoTrapCap.Location = new System.Drawing.Point(8, 69);
            chkNoTrapCap.Margin = new Padding(4, 3, 4, 3);
            chkNoTrapCap.Name = "chkNoTrapCap";
            chkNoTrapCap.Size = new System.Drawing.Size(91, 19);
            chkNoTrapCap.TabIndex = 12;
            chkNoTrapCap.Text = "No Trap Cap";
            chkNoTrapCap.UseVisualStyleBackColor = true;
            chkNoTrapCap.CheckedChanged += chkNoTrapCap_CheckedChanged;
            // 
            // chkGodMode
            // 
            chkGodMode.AutoSize = true;
            chkGodMode.Location = new System.Drawing.Point(9, 230);
            chkGodMode.Margin = new Padding(4, 3, 4, 3);
            chkGodMode.Name = "chkGodMode";
            chkGodMode.Size = new System.Drawing.Size(82, 19);
            chkGodMode.TabIndex = 11;
            chkGodMode.Text = "God Mode";
            chkGodMode.UseVisualStyleBackColor = true;
            chkGodMode.CheckedChanged += chkGodMode_CheckedChanged;
            // 
            // modsGroupBox
            // 
            modsGroupBox.BackColor = System.Drawing.Color.Thistle;
            modsGroupBox.Controls.Add(label3);
            modsGroupBox.Controls.Add(labelOverrideLevels);
            modsGroupBox.Controls.Add(chkOverrideTrapTier);
            modsGroupBox.Controls.Add(inputOverrideTrapTier);
            modsGroupBox.Controls.Add(chkOverrideAccountLevel);
            modsGroupBox.Controls.Add(inputOverrideAccountLevel);
            modsGroupBox.Controls.Add(chkAdditionalHeroWeapon);
            modsGroupBox.Controls.Add(chkEnhancedTrapRotation);
            modsGroupBox.Controls.Add(comBoxAdditionalHeroWeapon);
            modsGroupBox.Controls.Add(chkCustomStartCoin);
            modsGroupBox.Controls.Add(chkSellTrapsAnytime);
            modsGroupBox.Controls.Add(chkNoLimitUniqueTraps);
            modsGroupBox.Controls.Add(chkHardcore);
            modsGroupBox.Controls.Add(chkNoTrapCap);
            modsGroupBox.Controls.Add(startingCoinInput);
            modsGroupBox.Controls.Add(chkNoTrapGrid);
            modsGroupBox.Controls.Add(chkGodMode);
            modsGroupBox.Controls.Add(chkInvincibleBarricades);
            modsGroupBox.Controls.Add(chkTrapsAnySurface);
            modsGroupBox.Controls.Add(chkTrapsInTraps);
            modsGroupBox.Location = new System.Drawing.Point(7, 99);
            modsGroupBox.Margin = new Padding(4, 3, 4, 3);
            modsGroupBox.Name = "modsGroupBox";
            modsGroupBox.Padding = new Padding(4, 3, 4, 3);
            modsGroupBox.Size = new System.Drawing.Size(396, 383);
            modsGroupBox.TabIndex = 22;
            modsGroupBox.TabStop = false;
            modsGroupBox.Text = "Mods";
            // 
            // chkOverrideTrapTier
            // 
            chkOverrideTrapTier.AutoSize = true;
            chkOverrideTrapTier.Location = new System.Drawing.Point(8, 305);
            chkOverrideTrapTier.Margin = new Padding(4, 3, 4, 3);
            chkOverrideTrapTier.Name = "chkOverrideTrapTier";
            chkOverrideTrapTier.Size = new System.Drawing.Size(118, 19);
            chkOverrideTrapTier.TabIndex = 79;
            chkOverrideTrapTier.Text = "Override Trap Tier";
            chkOverrideTrapTier.UseVisualStyleBackColor = true;
            chkOverrideTrapTier.CheckedChanged += chkOverrideTrapTier_CheckedChanged;
            // 
            // inputOverrideTrapTier
            // 
            inputOverrideTrapTier.Location = new System.Drawing.Point(162, 301);
            inputOverrideTrapTier.Margin = new Padding(4, 3, 4, 3);
            inputOverrideTrapTier.Maximum = new decimal(new int[] { 7, 0, 0, 0 });
            inputOverrideTrapTier.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            inputOverrideTrapTier.Name = "inputOverrideTrapTier";
            inputOverrideTrapTier.Size = new System.Drawing.Size(99, 23);
            inputOverrideTrapTier.TabIndex = 78;
            inputOverrideTrapTier.Value = new decimal(new int[] { 1, 0, 0, 0 });
            inputOverrideTrapTier.ValueChanged += inputOverrideTrapTier_ValueChanged;
            // 
            // chkOverrideAccountLevel
            // 
            chkOverrideAccountLevel.AutoSize = true;
            chkOverrideAccountLevel.Location = new System.Drawing.Point(9, 280);
            chkOverrideAccountLevel.Margin = new Padding(4, 3, 4, 3);
            chkOverrideAccountLevel.Name = "chkOverrideAccountLevel";
            chkOverrideAccountLevel.Size = new System.Drawing.Size(149, 19);
            chkOverrideAccountLevel.TabIndex = 77;
            chkOverrideAccountLevel.Text = "Override Account Level";
            chkOverrideAccountLevel.UseVisualStyleBackColor = true;
            chkOverrideAccountLevel.CheckedChanged += chkOverrideAccountLevel_CheckedChanged;
            // 
            // inputOverrideAccountLevel
            // 
            inputOverrideAccountLevel.Increment = new decimal(new int[] { 50, 0, 0, 0 });
            inputOverrideAccountLevel.Location = new System.Drawing.Point(162, 276);
            inputOverrideAccountLevel.Margin = new Padding(4, 3, 4, 3);
            inputOverrideAccountLevel.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            inputOverrideAccountLevel.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            inputOverrideAccountLevel.Name = "inputOverrideAccountLevel";
            inputOverrideAccountLevel.Size = new System.Drawing.Size(99, 23);
            inputOverrideAccountLevel.TabIndex = 76;
            inputOverrideAccountLevel.Value = new decimal(new int[] { 1, 0, 0, 0 });
            inputOverrideAccountLevel.ValueChanged += inputOverrideAccountLevel_ValueChanged;
            // 
            // chkAdditionalHeroWeapon
            // 
            chkAdditionalHeroWeapon.AutoSize = true;
            chkAdditionalHeroWeapon.Location = new System.Drawing.Point(10, 355);
            chkAdditionalHeroWeapon.Margin = new Padding(4, 3, 4, 3);
            chkAdditionalHeroWeapon.Name = "chkAdditionalHeroWeapon";
            chkAdditionalHeroWeapon.Size = new System.Drawing.Size(155, 19);
            chkAdditionalHeroWeapon.TabIndex = 75;
            chkAdditionalHeroWeapon.Text = "Additional Hero weapon";
            chkAdditionalHeroWeapon.UseVisualStyleBackColor = true;
            chkAdditionalHeroWeapon.CheckedChanged += chkAdditionalHeroWeapon_CheckedChanged;
            // 
            // chkEnhancedTrapRotation
            // 
            chkEnhancedTrapRotation.AutoSize = true;
            chkEnhancedTrapRotation.Location = new System.Drawing.Point(199, 167);
            chkEnhancedTrapRotation.Margin = new Padding(4, 3, 4, 3);
            chkEnhancedTrapRotation.Name = "chkEnhancedTrapRotation";
            chkEnhancedTrapRotation.Size = new System.Drawing.Size(151, 19);
            chkEnhancedTrapRotation.TabIndex = 24;
            chkEnhancedTrapRotation.Text = "Enhanced Trap Rotation";
            chkEnhancedTrapRotation.UseVisualStyleBackColor = true;
            chkEnhancedTrapRotation.CheckedChanged += chkEnhancedTrapRotation_CheckedChanged;
            // 
            // comBoxAdditionalHeroWeapon
            // 
            comBoxAdditionalHeroWeapon.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxAdditionalHeroWeapon.FormattingEnabled = true;
            comBoxAdditionalHeroWeapon.Location = new System.Drawing.Point(179, 353);
            comBoxAdditionalHeroWeapon.Margin = new Padding(4, 3, 4, 3);
            comBoxAdditionalHeroWeapon.Name = "comBoxAdditionalHeroWeapon";
            comBoxAdditionalHeroWeapon.Size = new System.Drawing.Size(146, 23);
            comBoxAdditionalHeroWeapon.TabIndex = 74;
            comBoxAdditionalHeroWeapon.SelectedIndexChanged += comBoxAdditionalHeroWeapon_SelectedIndexChanged;
            // 
            // chkCustomStartCoin
            // 
            chkCustomStartCoin.AutoSize = true;
            chkCustomStartCoin.Location = new System.Drawing.Point(199, 227);
            chkCustomStartCoin.Margin = new Padding(4, 3, 4, 3);
            chkCustomStartCoin.Name = "chkCustomStartCoin";
            chkCustomStartCoin.Size = new System.Drawing.Size(78, 19);
            chkCustomStartCoin.TabIndex = 23;
            chkCustomStartCoin.Text = "Start Coin";
            chkCustomStartCoin.UseVisualStyleBackColor = true;
            chkCustomStartCoin.CheckedChanged += chkCustomStartCoin_CheckedChanged;
            // 
            // chkSellTrapsAnytime
            // 
            chkSellTrapsAnytime.AutoSize = true;
            chkSellTrapsAnytime.Location = new System.Drawing.Point(199, 142);
            chkSellTrapsAnytime.Margin = new Padding(4, 3, 4, 3);
            chkSellTrapsAnytime.Name = "chkSellTrapsAnytime";
            chkSellTrapsAnytime.Size = new System.Drawing.Size(122, 19);
            chkSellTrapsAnytime.TabIndex = 22;
            chkSellTrapsAnytime.Text = "Sell Traps Anytime";
            chkSellTrapsAnytime.UseVisualStyleBackColor = true;
            chkSellTrapsAnytime.CheckedChanged += chkSellTrapsAnytime_CheckedChanged;
            // 
            // chk_modsEnabled
            // 
            chk_modsEnabled.AutoSize = true;
            chk_modsEnabled.Location = new System.Drawing.Point(233, 17);
            chk_modsEnabled.Margin = new Padding(4, 3, 4, 3);
            chk_modsEnabled.Name = "chk_modsEnabled";
            chk_modsEnabled.Size = new System.Drawing.Size(101, 19);
            chk_modsEnabled.TabIndex = 25;
            chk_modsEnabled.Text = "Mods enabled";
            chk_modsEnabled.UseVisualStyleBackColor = true;
            chk_modsEnabled.CheckedChanged += chk_modsEnabled_CheckedChanged;
            // 
            // chkRunAs32
            // 
            chkRunAs32.AutoSize = true;
            chkRunAs32.Location = new System.Drawing.Point(114, 650);
            chkRunAs32.Margin = new Padding(4, 3, 4, 3);
            chkRunAs32.Name = "chkRunAs32";
            chkRunAs32.Size = new System.Drawing.Size(89, 19);
            chkRunAs32.TabIndex = 26;
            chkRunAs32.Text = "Force 32bits";
            chkRunAs32.UseVisualStyleBackColor = true;
            // 
            // comBoxLanguage
            // 
            comBoxLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxLanguage.FormattingEnabled = true;
            comBoxLanguage.Location = new System.Drawing.Point(88, 37);
            comBoxLanguage.Margin = new Padding(4, 3, 4, 3);
            comBoxLanguage.Name = "comBoxLanguage";
            comBoxLanguage.Size = new System.Drawing.Size(92, 23);
            comBoxLanguage.TabIndex = 11;
            comBoxLanguage.SelectedIndexChanged += comBoxLanguage_SelectedIndexChanged;
            // 
            // labelLanguage
            // 
            labelLanguage.AutoSize = true;
            labelLanguage.Location = new System.Drawing.Point(16, 40);
            labelLanguage.Margin = new Padding(4, 0, 4, 0);
            labelLanguage.Name = "labelLanguage";
            labelLanguage.Size = new System.Drawing.Size(59, 15);
            labelLanguage.TabIndex = 10;
            labelLanguage.Text = "Language";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(122, 12);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(223, 15);
            label1.TabIndex = 73;
            label1.Text = "Any issues or feedback? Join our Discord:";
            // 
            // btnDiscord
            // 
            btnDiscord.BackColor = System.Drawing.Color.Transparent;
            btnDiscord.FlatStyle = FlatStyle.Popup;
            btnDiscord.Image = (System.Drawing.Image)resources.GetObject("btnDiscord.Image");
            btnDiscord.Location = new System.Drawing.Point(364, 5);
            btnDiscord.Margin = new Padding(0);
            btnDiscord.Name = "btnDiscord";
            btnDiscord.Size = new System.Drawing.Size(42, 30);
            btnDiscord.TabIndex = 74;
            btnDiscord.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDiscord.UseVisualStyleBackColor = false;
            btnDiscord.Click += btnDiscord_Click;
            // 
            // maskedTextBoxHostGamePlayer1Loadout
            // 
            maskedTextBoxHostGamePlayer1Loadout.Enabled = false;
            maskedTextBoxHostGamePlayer1Loadout.Location = new System.Drawing.Point(84, 244);
            maskedTextBoxHostGamePlayer1Loadout.Margin = new Padding(4, 3, 4, 3);
            maskedTextBoxHostGamePlayer1Loadout.Name = "maskedTextBoxHostGamePlayer1Loadout";
            maskedTextBoxHostGamePlayer1Loadout.Size = new System.Drawing.Size(288, 23);
            maskedTextBoxHostGamePlayer1Loadout.TabIndex = 73;
            maskedTextBoxHostGamePlayer1Loadout.TextChanged += maskedTextBoxHostGamePlayer1Loadout_TextChanged;
            // 
            // maskedTextBoxHostGamePlayer4Loadout
            // 
            maskedTextBoxHostGamePlayer4Loadout.Location = new System.Drawing.Point(84, 335);
            maskedTextBoxHostGamePlayer4Loadout.Margin = new Padding(4, 3, 4, 3);
            maskedTextBoxHostGamePlayer4Loadout.Name = "maskedTextBoxHostGamePlayer4Loadout";
            maskedTextBoxHostGamePlayer4Loadout.Size = new System.Drawing.Size(288, 23);
            maskedTextBoxHostGamePlayer4Loadout.TabIndex = 75;
            maskedTextBoxHostGamePlayer4Loadout.TextChanged += maskedTextBoxHostGamePlayer4Loadout_TextChanged;
            // 
            // maskedTextBoxHostGamePlayer3Loadout
            // 
            maskedTextBoxHostGamePlayer3Loadout.Location = new System.Drawing.Point(84, 305);
            maskedTextBoxHostGamePlayer3Loadout.Margin = new Padding(4, 3, 4, 3);
            maskedTextBoxHostGamePlayer3Loadout.Name = "maskedTextBoxHostGamePlayer3Loadout";
            maskedTextBoxHostGamePlayer3Loadout.Size = new System.Drawing.Size(288, 23);
            maskedTextBoxHostGamePlayer3Loadout.TabIndex = 76;
            maskedTextBoxHostGamePlayer3Loadout.TextChanged += maskedTextBoxHostGamePlayer3Loadout_TextChanged;
            // 
            // maskedTextBoxHostGamePlayer2Loadout
            // 
            maskedTextBoxHostGamePlayer2Loadout.Location = new System.Drawing.Point(84, 274);
            maskedTextBoxHostGamePlayer2Loadout.Margin = new Padding(4, 3, 4, 3);
            maskedTextBoxHostGamePlayer2Loadout.Name = "maskedTextBoxHostGamePlayer2Loadout";
            maskedTextBoxHostGamePlayer2Loadout.Size = new System.Drawing.Size(288, 23);
            maskedTextBoxHostGamePlayer2Loadout.TabIndex = 77;
            maskedTextBoxHostGamePlayer2Loadout.TextChanged += maskedTextBoxHostGamePlayer2Loadout_TextChanged;
            // 
            // maskedTextBoxHostGamePlayer5Loadout
            // 
            maskedTextBoxHostGamePlayer5Loadout.Location = new System.Drawing.Point(84, 365);
            maskedTextBoxHostGamePlayer5Loadout.Margin = new Padding(4, 3, 4, 3);
            maskedTextBoxHostGamePlayer5Loadout.Name = "maskedTextBoxHostGamePlayer5Loadout";
            maskedTextBoxHostGamePlayer5Loadout.Size = new System.Drawing.Size(137, 23);
            maskedTextBoxHostGamePlayer5Loadout.TabIndex = 78;
            maskedTextBoxHostGamePlayer5Loadout.TextChanged += maskedTextBoxHostGamePlayer5Loadout_TextChanged;
            // 
            // labelHostGamePlayer1
            // 
            labelHostGamePlayer1.AutoSize = true;
            labelHostGamePlayer1.Location = new System.Drawing.Point(14, 247);
            labelHostGamePlayer1.Margin = new Padding(4, 0, 4, 0);
            labelHostGamePlayer1.Name = "labelHostGamePlayer1";
            labelHostGamePlayer1.Size = new System.Drawing.Size(63, 15);
            labelHostGamePlayer1.TabIndex = 79;
            labelHostGamePlayer1.Text = "Host (You)";
            // 
            // labelHostGamePlayer2
            // 
            labelHostGamePlayer2.AutoSize = true;
            labelHostGamePlayer2.Location = new System.Drawing.Point(28, 277);
            labelHostGamePlayer2.Margin = new Padding(4, 0, 4, 0);
            labelHostGamePlayer2.Name = "labelHostGamePlayer2";
            labelHostGamePlayer2.Size = new System.Drawing.Size(48, 15);
            labelHostGamePlayer2.TabIndex = 80;
            labelHostGamePlayer2.Text = "Player 2";
            // 
            // labelHostGamePlayer4
            // 
            labelHostGamePlayer4.AutoSize = true;
            labelHostGamePlayer4.Location = new System.Drawing.Point(28, 339);
            labelHostGamePlayer4.Margin = new Padding(4, 0, 4, 0);
            labelHostGamePlayer4.Name = "labelHostGamePlayer4";
            labelHostGamePlayer4.Size = new System.Drawing.Size(48, 15);
            labelHostGamePlayer4.TabIndex = 81;
            labelHostGamePlayer4.Text = "Player 4";
            // 
            // labelHostGamePlayer3
            // 
            labelHostGamePlayer3.AutoSize = true;
            labelHostGamePlayer3.Location = new System.Drawing.Point(28, 309);
            labelHostGamePlayer3.Margin = new Padding(4, 0, 4, 0);
            labelHostGamePlayer3.Name = "labelHostGamePlayer3";
            labelHostGamePlayer3.Size = new System.Drawing.Size(48, 15);
            labelHostGamePlayer3.TabIndex = 82;
            labelHostGamePlayer3.Text = "Player 3";
            // 
            // labelHostGamePlayer5
            // 
            labelHostGamePlayer5.AutoSize = true;
            labelHostGamePlayer5.Location = new System.Drawing.Point(28, 369);
            labelHostGamePlayer5.Margin = new Padding(4, 0, 4, 0);
            labelHostGamePlayer5.Name = "labelHostGamePlayer5";
            labelHostGamePlayer5.Size = new System.Drawing.Size(48, 15);
            labelHostGamePlayer5.TabIndex = 83;
            labelHostGamePlayer5.Text = "Player 5";
            // 
            // maskedTextBoxJoinGameHostIP
            // 
            maskedTextBoxJoinGameHostIP.Location = new System.Drawing.Point(84, 281);
            maskedTextBoxJoinGameHostIP.Margin = new Padding(4, 3, 4, 3);
            maskedTextBoxJoinGameHostIP.Name = "maskedTextBoxJoinGameHostIP";
            maskedTextBoxJoinGameHostIP.Size = new System.Drawing.Size(137, 23);
            maskedTextBoxJoinGameHostIP.TabIndex = 73;
            maskedTextBoxJoinGameHostIP.TextChanged += maskedTextBoxJoinGameHostIP_TextChanged;
            // 
            // labelJoinGameHostIP
            // 
            labelJoinGameHostIP.AutoSize = true;
            labelJoinGameHostIP.Location = new System.Drawing.Point(29, 286);
            labelJoinGameHostIP.Margin = new Padding(4, 0, 4, 0);
            labelJoinGameHostIP.Name = "labelJoinGameHostIP";
            labelJoinGameHostIP.Size = new System.Drawing.Size(45, 15);
            labelJoinGameHostIP.TabIndex = 84;
            labelJoinGameHostIP.Text = "Host IP";
            // 
            // btnJoinGame
            // 
            btnJoinGame.BackColor = System.Drawing.Color.SpringGreen;
            btnJoinGame.Location = new System.Drawing.Point(228, 281);
            btnJoinGame.Margin = new Padding(4, 3, 4, 3);
            btnJoinGame.Name = "btnJoinGame";
            btnJoinGame.Size = new System.Drawing.Size(144, 69);
            btnJoinGame.TabIndex = 85;
            btnJoinGame.Text = "Join Match";
            btnJoinGame.UseVisualStyleBackColor = false;
            btnJoinGame.Click += btnJoinGame_Click;
            // 
            // maskedTextBoxJoinGameLoadout
            // 
            maskedTextBoxJoinGameLoadout.Location = new System.Drawing.Point(84, 251);
            maskedTextBoxJoinGameLoadout.Margin = new Padding(4, 3, 4, 3);
            maskedTextBoxJoinGameLoadout.Name = "maskedTextBoxJoinGameLoadout";
            maskedTextBoxJoinGameLoadout.Size = new System.Drawing.Size(286, 23);
            maskedTextBoxJoinGameLoadout.TabIndex = 86;
            maskedTextBoxJoinGameLoadout.TextChanged += maskedTextBoxJoinGamePlayerName_TextChanged;
            // 
            // labelJoinGameLoadout
            // 
            labelJoinGameLoadout.AutoSize = true;
            labelJoinGameLoadout.Location = new System.Drawing.Point(28, 256);
            labelJoinGameLoadout.Margin = new Padding(4, 0, 4, 0);
            labelJoinGameLoadout.Name = "labelJoinGameLoadout";
            labelJoinGameLoadout.Size = new System.Drawing.Size(51, 15);
            labelJoinGameLoadout.TabIndex = 87;
            labelJoinGameLoadout.Text = "Loadout";
            // 
            // survivalGameTabControl
            // 
            survivalGameTabControl.Controls.Add(tabPage1);
            survivalGameTabControl.Controls.Add(tabPage2);
            survivalGameTabControl.ItemSize = new System.Drawing.Size(167, 20);
            survivalGameTabControl.Location = new System.Drawing.Point(4, 80);
            survivalGameTabControl.Margin = new Padding(4, 3, 4, 3);
            survivalGameTabControl.Name = "survivalGameTabControl";
            survivalGameTabControl.SelectedIndex = 0;
            survivalGameTabControl.Size = new System.Drawing.Size(400, 487);
            survivalGameTabControl.SizeMode = TabSizeMode.Fixed;
            survivalGameTabControl.TabIndex = 84;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(linkLabelJoinGameKnownIssues);
            tabPage1.Controls.Add(labelJoinGameBriefInstructions);
            tabPage1.Controls.Add(labelJoinGameAdditionalInfo);
            tabPage1.Controls.Add(maskedTextBoxJoinGameLoadout);
            tabPage1.Controls.Add(labelJoinGameLoadout);
            tabPage1.Controls.Add(btnJoinGame);
            tabPage1.Controls.Add(labelJoinGameHostIP);
            tabPage1.Controls.Add(maskedTextBoxJoinGameHostIP);
            tabPage1.Location = new System.Drawing.Point(4, 24);
            tabPage1.Margin = new Padding(4, 3, 4, 3);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4, 3, 4, 3);
            tabPage1.Size = new System.Drawing.Size(392, 459);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Join Game";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // linkLabelJoinGameKnownIssues
            // 
            linkLabelJoinGameKnownIssues.ForeColor = System.Drawing.SystemColors.GrayText;
            linkLabelJoinGameKnownIssues.LinkArea = new LinkArea(14, 9);
            linkLabelJoinGameKnownIssues.LinkColor = System.Drawing.Color.Blue;
            linkLabelJoinGameKnownIssues.Location = new System.Drawing.Point(21, 103);
            linkLabelJoinGameKnownIssues.Margin = new Padding(4, 0, 4, 0);
            linkLabelJoinGameKnownIssues.Name = "linkLabelJoinGameKnownIssues";
            linkLabelJoinGameKnownIssues.Size = new System.Drawing.Size(355, 59);
            linkLabelJoinGameKnownIssues.TabIndex = 90;
            linkLabelJoinGameKnownIssues.TabStop = true;
            linkLabelJoinGameKnownIssues.Text = "Known Issues (Full List): \r\n - (Host) No voices, movement skills, wave count (visual)\r\n - (Client) If incompolete loadout, join match again\r\n - Some mods can cause issues";
            linkLabelJoinGameKnownIssues.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            linkLabelJoinGameKnownIssues.UseCompatibleTextRendering = true;
            linkLabelJoinGameKnownIssues.LinkClicked += linkLabel1_LinkClicked;
            // 
            // labelJoinGameBriefInstructions
            // 
            labelJoinGameBriefInstructions.AutoSize = true;
            labelJoinGameBriefInstructions.Location = new System.Drawing.Point(13, 225);
            labelJoinGameBriefInstructions.Margin = new Padding(4, 0, 4, 0);
            labelJoinGameBriefInstructions.Name = "labelJoinGameBriefInstructions";
            labelJoinGameBriefInstructions.Size = new System.Drawing.Size(254, 15);
            labelJoinGameBriefInstructions.TabIndex = 89;
            labelJoinGameBriefInstructions.Text = "Enter the host IP and your loadout code below:";
            // 
            // labelJoinGameAdditionalInfo
            // 
            labelJoinGameAdditionalInfo.Location = new System.Drawing.Point(8, 308);
            labelJoinGameAdditionalInfo.Margin = new Padding(4, 0, 4, 0);
            labelJoinGameAdditionalInfo.Name = "labelJoinGameAdditionalInfo";
            labelJoinGameAdditionalInfo.Size = new System.Drawing.Size(214, 47);
            labelJoinGameAdditionalInfo.TabIndex = 88;
            labelJoinGameAdditionalInfo.Text = "Hover for more info about multiplayer";
            labelJoinGameAdditionalInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            toolTip1.SetToolTip(labelJoinGameAdditionalInfo, resources.GetString("labelJoinGameAdditionalInfo.ToolTip"));
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(linkLabel2);
            tabPage2.Controls.Add(battlegroundGroupBox);
            tabPage2.Controls.Add(labelHostGameAdditionalInfo);
            tabPage2.Controls.Add(labelHostGameBriefInstructions);
            tabPage2.Controls.Add(maskedTextBoxHostGamePlayer3Loadout);
            tabPage2.Controls.Add(maskedTextBoxHostGamePlayer1Loadout);
            tabPage2.Controls.Add(maskedTextBoxHostGamePlayer4Loadout);
            tabPage2.Controls.Add(btnLaunch);
            tabPage2.Controls.Add(maskedTextBoxHostGamePlayer2Loadout);
            tabPage2.Controls.Add(labelHostGamePlayer2);
            tabPage2.Controls.Add(labelHostGamePlayer5);
            tabPage2.Controls.Add(labelHostGamePlayer4);
            tabPage2.Controls.Add(maskedTextBoxHostGamePlayer5Loadout);
            tabPage2.Controls.Add(labelHostGamePlayer1);
            tabPage2.Controls.Add(labelHostGamePlayer3);
            tabPage2.Location = new System.Drawing.Point(4, 24);
            tabPage2.Margin = new Padding(4, 3, 4, 3);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4, 3, 4, 3);
            tabPage2.Size = new System.Drawing.Size(392, 459);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Host Game";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // linkLabel2
            // 
            linkLabel2.ForeColor = System.Drawing.SystemColors.GrayText;
            linkLabel2.LinkArea = new LinkArea(14, 9);
            linkLabel2.LinkColor = System.Drawing.Color.Blue;
            linkLabel2.Location = new System.Drawing.Point(17, 126);
            linkLabel2.Margin = new Padding(4, 0, 4, 0);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new System.Drawing.Size(355, 59);
            linkLabel2.TabIndex = 91;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Known Issues (Full List): \r\n - (Host) No voices, movement skills, wave count (visual)\r\n - (Client) If incompolete loadout, join match again\r\n - Some mods can cause issues";
            linkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            linkLabel2.UseCompatibleTextRendering = true;
            // 
            // labelHostGameAdditionalInfo
            // 
            labelHostGameAdditionalInfo.Location = new System.Drawing.Point(8, 392);
            labelHostGameAdditionalInfo.Margin = new Padding(4, 0, 4, 0);
            labelHostGameAdditionalInfo.Name = "labelHostGameAdditionalInfo";
            labelHostGameAdditionalInfo.Size = new System.Drawing.Size(214, 47);
            labelHostGameAdditionalInfo.TabIndex = 85;
            labelHostGameAdditionalInfo.Text = "Hover for more info about multiplayer";
            labelHostGameAdditionalInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            toolTip1.SetToolTip(labelHostGameAdditionalInfo, resources.GetString("labelHostGameAdditionalInfo.ToolTip"));
            // 
            // labelHostGameBriefInstructions
            // 
            labelHostGameBriefInstructions.AutoSize = true;
            labelHostGameBriefInstructions.Location = new System.Drawing.Point(14, 219);
            labelHostGameBriefInstructions.Margin = new Padding(4, 0, 4, 0);
            labelHostGameBriefInstructions.Name = "labelHostGameBriefInstructions";
            labelHostGameBriefInstructions.Size = new System.Drawing.Size(213, 15);
            labelHostGameBriefInstructions.TabIndex = 84;
            labelHostGameBriefInstructions.Text = "Enter the players' loadout codes below:";
            // 
            // label7
            // 
            label7.Location = new System.Drawing.Point(8, 282);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(214, 47);
            label7.TabIndex = 88;
            label7.Text = "Hover for more info about multiplayer";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            toolTip1.SetToolTip(label7, resources.GetString("label7.ToolTip"));
            // 
            // label10
            // 
            label10.Location = new System.Drawing.Point(13, 406);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(214, 47);
            label10.TabIndex = 85;
            label10.Text = "Hover for more info about multiplayer";
            label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            toolTip1.SetToolTip(label10, resources.GetString("label10.ToolTip"));
            // 
            // modsPanel
            // 
            modsPanel.AutoSize = true;
            modsPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            modsPanel.Controls.Add(modsGroupBox);
            modsPanel.Location = new System.Drawing.Point(1108, 3);
            modsPanel.Margin = new Padding(4, 3, 4, 3);
            modsPanel.Name = "modsPanel";
            modsPanel.Size = new System.Drawing.Size(407, 485);
            modsPanel.TabIndex = 85;
            modsPanel.Visible = false;
            // 
            // gameSettingsGroupBox
            // 
            gameSettingsGroupBox.BackColor = System.Drawing.SystemColors.Control;
            gameSettingsGroupBox.Controls.Add(chk_modsEnabled);
            gameSettingsGroupBox.Controls.Add(comBoxLanguage);
            gameSettingsGroupBox.Controls.Add(labelLanguage);
            gameSettingsGroupBox.Controls.Add(chkShowTrapDamageFlyoffs);
            gameSettingsGroupBox.Location = new System.Drawing.Point(4, 4);
            gameSettingsGroupBox.Margin = new Padding(4, 3, 4, 3);
            gameSettingsGroupBox.Name = "gameSettingsGroupBox";
            gameSettingsGroupBox.Padding = new Padding(4, 3, 4, 3);
            gameSettingsGroupBox.Size = new System.Drawing.Size(398, 70);
            gameSettingsGroupBox.TabIndex = 86;
            gameSettingsGroupBox.TabStop = false;
            gameSettingsGroupBox.Text = "Game Settings";
            // 
            // panelLoadoutEditor
            // 
            panelLoadoutEditor.AutoSize = true;
            panelLoadoutEditor.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelLoadoutEditor.Location = new System.Drawing.Point(7, 31);
            panelLoadoutEditor.Margin = new Padding(4, 3, 4, 3);
            panelLoadoutEditor.Name = "panelLoadoutEditor";
            panelLoadoutEditor.Size = new System.Drawing.Size(0, 0);
            panelLoadoutEditor.TabIndex = 92;
            panelLoadoutEditor.Visible = false;
            // 
            // groupBoxLoadout
            // 
            groupBoxLoadout.AutoSize = true;
            groupBoxLoadout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBoxLoadout.BackColor = System.Drawing.SystemColors.Control;
            groupBoxLoadout.Controls.Add(btnDeleteLoadout);
            groupBoxLoadout.Controls.Add(labelPlayerName);
            groupBoxLoadout.Controls.Add(maskedTextBoxPlayerName);
            groupBoxLoadout.Controls.Add(labelLoadoutName);
            groupBoxLoadout.Controls.Add(btnSaveLoadout);
            groupBoxLoadout.Controls.Add(maskedTextBoxLoadoutName);
            groupBoxLoadout.Controls.Add(btnCopyLoadoutToClipboard);
            groupBoxLoadout.Controls.Add(btnImportLoadout);
            groupBoxLoadout.Controls.Add(labelExportLoadout);
            groupBoxLoadout.Controls.Add(textBoxExportLoadout);
            groupBoxLoadout.Controls.Add(maskedTextBoxImportLoadout);
            groupBoxLoadout.Controls.Add(comBoxTrapPartsSlot9Part3);
            groupBoxLoadout.Controls.Add(comBoxTrapPartsSlot9Part2);
            groupBoxLoadout.Controls.Add(comBoxTrapPartsSlot9Part1);
            groupBoxLoadout.Controls.Add(comBoxTrapPartsSlot8Part3);
            groupBoxLoadout.Controls.Add(comBoxTrapPartsSlot8Part2);
            groupBoxLoadout.Controls.Add(comBoxTrapPartsSlot8Part1);
            groupBoxLoadout.Controls.Add(comBoxTrapPartsSlot7Part3);
            groupBoxLoadout.Controls.Add(comBoxTrapPartsSlot7Part2);
            groupBoxLoadout.Controls.Add(comBoxTrapPartsSlot7Part1);
            groupBoxLoadout.Controls.Add(comBoxTrapPartsSlot6Part3);
            groupBoxLoadout.Controls.Add(comBoxTrapPartsSlot6Part2);
            groupBoxLoadout.Controls.Add(comBoxTrapPartsSlot6Part1);
            groupBoxLoadout.Controls.Add(comBoxTrapPartsSlot5Part3);
            groupBoxLoadout.Controls.Add(comBoxTrapPartsSlot5Part2);
            groupBoxLoadout.Controls.Add(comBoxTrapPartsSlot5Part1);
            groupBoxLoadout.Controls.Add(comBoxTrapPartsSlot4Part3);
            groupBoxLoadout.Controls.Add(comBoxTrapPartsSlot4Part2);
            groupBoxLoadout.Controls.Add(comBoxTrapPartsSlot4Part1);
            groupBoxLoadout.Controls.Add(comBoxTrapPartsSlot3Part3);
            groupBoxLoadout.Controls.Add(comBoxTrapPartsSlot3Part2);
            groupBoxLoadout.Controls.Add(comBoxTrapPartsSlot3Part1);
            groupBoxLoadout.Controls.Add(comBoxTrapPartsSlot2Part3);
            groupBoxLoadout.Controls.Add(comBoxTrapPartsSlot2Part2);
            groupBoxLoadout.Controls.Add(comBoxTrapPartsSlot2Part1);
            groupBoxLoadout.Controls.Add(comBoxTrapPartsSlot1Part3);
            groupBoxLoadout.Controls.Add(comBoxTrapPartsSlot1Part2);
            groupBoxLoadout.Controls.Add(comBoxTrapPartsSlot1Part1);
            groupBoxLoadout.Controls.Add(labelTraitNoBonusSlot);
            groupBoxLoadout.Controls.Add(comboxTraitYellowSlot);
            groupBoxLoadout.Controls.Add(labelTraitYellowSlot);
            groupBoxLoadout.Controls.Add(comboxTraitNoBonusSlot);
            groupBoxLoadout.Controls.Add(labelTraitBlueSlot);
            groupBoxLoadout.Controls.Add(comboxTraitGreenSlot);
            groupBoxLoadout.Controls.Add(labelTraitGreenSlot);
            groupBoxLoadout.Controls.Add(comboxTraitBlueSlot);
            groupBoxLoadout.Controls.Add(comBoxDye);
            groupBoxLoadout.Controls.Add(labelHero);
            groupBoxLoadout.Controls.Add(labelConsumableSlot2);
            groupBoxLoadout.Controls.Add(comBoxHero);
            groupBoxLoadout.Controls.Add(comBoxConsumableSlot1);
            groupBoxLoadout.Controls.Add(comBoxSkin);
            groupBoxLoadout.Controls.Add(labelConsumableSlot1);
            groupBoxLoadout.Controls.Add(labelDye);
            groupBoxLoadout.Controls.Add(comBoxConsumableSlot2);
            groupBoxLoadout.Controls.Add(labelSkin);
            groupBoxLoadout.Controls.Add(labelGuardianSlot2);
            groupBoxLoadout.Controls.Add(comBoxLoadouts);
            groupBoxLoadout.Controls.Add(labelLoadoutSlot9);
            groupBoxLoadout.Controls.Add(comBoxGuardianSlot1);
            groupBoxLoadout.Controls.Add(labelGuardianSlot1);
            groupBoxLoadout.Controls.Add(labelLoadoutSlot8);
            groupBoxLoadout.Controls.Add(comBoxGuardianSlot2);
            groupBoxLoadout.Controls.Add(labelLoadoutSlot7);
            groupBoxLoadout.Controls.Add(labelLoadoutSlot6);
            groupBoxLoadout.Controls.Add(labelLoadoutSlot5);
            groupBoxLoadout.Controls.Add(labelLoadoutSlot4);
            groupBoxLoadout.Controls.Add(labelLoadoutSlot3);
            groupBoxLoadout.Controls.Add(labelLoadoutSlot2);
            groupBoxLoadout.Controls.Add(labelLoadoutSlot1);
            groupBoxLoadout.Controls.Add(comBoxLoadoutSlot1);
            groupBoxLoadout.Controls.Add(comBoxLoadoutSlot2);
            groupBoxLoadout.Controls.Add(comBoxLoadoutSlot3);
            groupBoxLoadout.Controls.Add(comBoxLoadoutSlot9);
            groupBoxLoadout.Controls.Add(comBoxLoadoutSlot4);
            groupBoxLoadout.Controls.Add(comBoxLoadoutSlot8);
            groupBoxLoadout.Controls.Add(comBoxLoadoutSlot5);
            groupBoxLoadout.Controls.Add(comBoxLoadoutSlot7);
            groupBoxLoadout.Controls.Add(comBoxLoadoutSlot6);
            groupBoxLoadout.Location = new System.Drawing.Point(0, 2);
            groupBoxLoadout.Margin = new Padding(4, 3, 4, 3);
            groupBoxLoadout.Name = "groupBoxLoadout";
            groupBoxLoadout.Padding = new Padding(4, 3, 4, 3);
            groupBoxLoadout.Size = new System.Drawing.Size(664, 648);
            groupBoxLoadout.TabIndex = 24;
            groupBoxLoadout.TabStop = false;
            groupBoxLoadout.Text = "Loadout Editor";
            // 
            // btnDeleteLoadout
            // 
            btnDeleteLoadout.BackColor = System.Drawing.Color.Tomato;
            btnDeleteLoadout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnDeleteLoadout.Location = new System.Drawing.Point(7, 601);
            btnDeleteLoadout.Margin = new Padding(4, 3, 4, 3);
            btnDeleteLoadout.Name = "btnDeleteLoadout";
            btnDeleteLoadout.Size = new System.Drawing.Size(186, 25);
            btnDeleteLoadout.TabIndex = 72;
            btnDeleteLoadout.Text = "Delete selected Loadout";
            btnDeleteLoadout.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            btnDeleteLoadout.UseVisualStyleBackColor = false;
            btnDeleteLoadout.Click += btnDeleteLoadout_Click;
            // 
            // labelPlayerName
            // 
            labelPlayerName.AutoSize = true;
            labelPlayerName.Location = new System.Drawing.Point(7, 560);
            labelPlayerName.Margin = new Padding(4, 0, 4, 0);
            labelPlayerName.Name = "labelPlayerName";
            labelPlayerName.Size = new System.Drawing.Size(74, 15);
            labelPlayerName.TabIndex = 71;
            labelPlayerName.Text = "Player Name";
            // 
            // maskedTextBoxPlayerName
            // 
            maskedTextBoxPlayerName.Location = new System.Drawing.Point(92, 556);
            maskedTextBoxPlayerName.Margin = new Padding(4, 3, 4, 3);
            maskedTextBoxPlayerName.Name = "maskedTextBoxPlayerName";
            maskedTextBoxPlayerName.Size = new System.Drawing.Size(115, 23);
            maskedTextBoxPlayerName.TabIndex = 70;
            maskedTextBoxPlayerName.TextChanged += maskedTextBoxPlayerName_TextChanged;
            // 
            // labelLoadoutName
            // 
            labelLoadoutName.AutoSize = true;
            labelLoadoutName.Location = new System.Drawing.Point(215, 560);
            labelLoadoutName.Margin = new Padding(4, 0, 4, 0);
            labelLoadoutName.Name = "labelLoadoutName";
            labelLoadoutName.Size = new System.Drawing.Size(86, 15);
            labelLoadoutName.TabIndex = 69;
            labelLoadoutName.Text = "Loadout Name";
            // 
            // btnSaveLoadout
            // 
            btnSaveLoadout.BackColor = System.Drawing.Color.MediumSpringGreen;
            btnSaveLoadout.Location = new System.Drawing.Point(587, 541);
            btnSaveLoadout.Margin = new Padding(4, 3, 4, 3);
            btnSaveLoadout.Name = "btnSaveLoadout";
            btnSaveLoadout.Size = new System.Drawing.Size(69, 51);
            btnSaveLoadout.TabIndex = 67;
            btnSaveLoadout.Text = "Save Loadout";
            btnSaveLoadout.UseVisualStyleBackColor = false;
            btnSaveLoadout.Click += btnSaveLoadout_Click;
            // 
            // maskedTextBoxLoadoutName
            // 
            maskedTextBoxLoadoutName.Location = new System.Drawing.Point(312, 556);
            maskedTextBoxLoadoutName.Margin = new Padding(4, 3, 4, 3);
            maskedTextBoxLoadoutName.Name = "maskedTextBoxLoadoutName";
            maskedTextBoxLoadoutName.Size = new System.Drawing.Size(268, 23);
            maskedTextBoxLoadoutName.TabIndex = 68;
            maskedTextBoxLoadoutName.TextChanged += maskedTextBoxLoadoutName_TextChanged;
            // 
            // btnCopyLoadoutToClipboard
            // 
            btnCopyLoadoutToClipboard.Location = new System.Drawing.Point(607, 603);
            btnCopyLoadoutToClipboard.Margin = new Padding(4, 3, 4, 3);
            btnCopyLoadoutToClipboard.Name = "btnCopyLoadoutToClipboard";
            btnCopyLoadoutToClipboard.Size = new System.Drawing.Size(49, 23);
            btnCopyLoadoutToClipboard.TabIndex = 27;
            btnCopyLoadoutToClipboard.Text = "Copy";
            btnCopyLoadoutToClipboard.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            btnCopyLoadoutToClipboard.UseVisualStyleBackColor = true;
            btnCopyLoadoutToClipboard.Click += btnCopyLoadoutToClipboard_Click;
            // 
            // btnImportLoadout
            // 
            btnImportLoadout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnImportLoadout.Location = new System.Drawing.Point(603, 22);
            btnImportLoadout.Margin = new Padding(4, 3, 4, 3);
            btnImportLoadout.Name = "btnImportLoadout";
            btnImportLoadout.Size = new System.Drawing.Size(52, 23);
            btnImportLoadout.TabIndex = 28;
            btnImportLoadout.Text = "Import";
            btnImportLoadout.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            btnImportLoadout.UseVisualStyleBackColor = true;
            btnImportLoadout.Click += btnImportLoadout_Click;
            // 
            // labelExportLoadout
            // 
            labelExportLoadout.AutoSize = true;
            labelExportLoadout.Location = new System.Drawing.Point(223, 608);
            labelExportLoadout.Margin = new Padding(4, 0, 4, 0);
            labelExportLoadout.Name = "labelExportLoadout";
            labelExportLoadout.Size = new System.Drawing.Size(41, 15);
            labelExportLoadout.TabIndex = 66;
            labelExportLoadout.Text = "Export";
            // 
            // textBoxExportLoadout
            // 
            textBoxExportLoadout.Location = new System.Drawing.Point(273, 603);
            textBoxExportLoadout.Margin = new Padding(4, 3, 4, 3);
            textBoxExportLoadout.Name = "textBoxExportLoadout";
            textBoxExportLoadout.ReadOnly = true;
            textBoxExportLoadout.Size = new System.Drawing.Size(326, 23);
            textBoxExportLoadout.TabIndex = 65;
            // 
            // maskedTextBoxImportLoadout
            // 
            maskedTextBoxImportLoadout.Location = new System.Drawing.Point(366, 22);
            maskedTextBoxImportLoadout.Margin = new Padding(4, 3, 4, 3);
            maskedTextBoxImportLoadout.Name = "maskedTextBoxImportLoadout";
            maskedTextBoxImportLoadout.Size = new System.Drawing.Size(233, 23);
            maskedTextBoxImportLoadout.TabIndex = 64;
            maskedTextBoxImportLoadout.TextChanged += maskedTextBoxImportLoadout_TextChanged;
            // 
            // comBoxTrapPartsSlot9Part3
            // 
            comBoxTrapPartsSlot9Part3.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxTrapPartsSlot9Part3.FormattingEnabled = true;
            comBoxTrapPartsSlot9Part3.Location = new System.Drawing.Point(530, 510);
            comBoxTrapPartsSlot9Part3.Margin = new Padding(4, 3, 4, 3);
            comBoxTrapPartsSlot9Part3.Name = "comBoxTrapPartsSlot9Part3";
            comBoxTrapPartsSlot9Part3.Size = new System.Drawing.Size(125, 23);
            comBoxTrapPartsSlot9Part3.TabIndex = 63;
            comBoxTrapPartsSlot9Part3.SelectedIndexChanged += comBoxTrapPartsSlot9Part3_SelectedIndexChanged;
            // 
            // comBoxTrapPartsSlot9Part2
            // 
            comBoxTrapPartsSlot9Part2.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxTrapPartsSlot9Part2.FormattingEnabled = true;
            comBoxTrapPartsSlot9Part2.Location = new System.Drawing.Point(401, 510);
            comBoxTrapPartsSlot9Part2.Margin = new Padding(4, 3, 4, 3);
            comBoxTrapPartsSlot9Part2.Name = "comBoxTrapPartsSlot9Part2";
            comBoxTrapPartsSlot9Part2.Size = new System.Drawing.Size(125, 23);
            comBoxTrapPartsSlot9Part2.TabIndex = 62;
            comBoxTrapPartsSlot9Part2.SelectedIndexChanged += comBoxTrapPartsSlot9Part2_SelectedIndexChanged;
            // 
            // comBoxTrapPartsSlot9Part1
            // 
            comBoxTrapPartsSlot9Part1.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxTrapPartsSlot9Part1.FormattingEnabled = true;
            comBoxTrapPartsSlot9Part1.Location = new System.Drawing.Point(273, 510);
            comBoxTrapPartsSlot9Part1.Margin = new Padding(4, 3, 4, 3);
            comBoxTrapPartsSlot9Part1.Name = "comBoxTrapPartsSlot9Part1";
            comBoxTrapPartsSlot9Part1.Size = new System.Drawing.Size(125, 23);
            comBoxTrapPartsSlot9Part1.TabIndex = 61;
            comBoxTrapPartsSlot9Part1.SelectedIndexChanged += comBoxTrapPartsSlot9Part1_SelectedIndexChanged;
            // 
            // comBoxTrapPartsSlot8Part3
            // 
            comBoxTrapPartsSlot8Part3.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxTrapPartsSlot8Part3.FormattingEnabled = true;
            comBoxTrapPartsSlot8Part3.Location = new System.Drawing.Point(530, 479);
            comBoxTrapPartsSlot8Part3.Margin = new Padding(4, 3, 4, 3);
            comBoxTrapPartsSlot8Part3.Name = "comBoxTrapPartsSlot8Part3";
            comBoxTrapPartsSlot8Part3.Size = new System.Drawing.Size(125, 23);
            comBoxTrapPartsSlot8Part3.TabIndex = 60;
            comBoxTrapPartsSlot8Part3.SelectedIndexChanged += comBoxTrapPartsSlot8Part3_SelectedIndexChanged;
            // 
            // comBoxTrapPartsSlot8Part2
            // 
            comBoxTrapPartsSlot8Part2.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxTrapPartsSlot8Part2.FormattingEnabled = true;
            comBoxTrapPartsSlot8Part2.Location = new System.Drawing.Point(401, 479);
            comBoxTrapPartsSlot8Part2.Margin = new Padding(4, 3, 4, 3);
            comBoxTrapPartsSlot8Part2.Name = "comBoxTrapPartsSlot8Part2";
            comBoxTrapPartsSlot8Part2.Size = new System.Drawing.Size(125, 23);
            comBoxTrapPartsSlot8Part2.TabIndex = 59;
            comBoxTrapPartsSlot8Part2.SelectedIndexChanged += comBoxTrapPartsSlot8Part2_SelectedIndexChanged;
            // 
            // comBoxTrapPartsSlot8Part1
            // 
            comBoxTrapPartsSlot8Part1.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxTrapPartsSlot8Part1.FormattingEnabled = true;
            comBoxTrapPartsSlot8Part1.Location = new System.Drawing.Point(273, 479);
            comBoxTrapPartsSlot8Part1.Margin = new Padding(4, 3, 4, 3);
            comBoxTrapPartsSlot8Part1.Name = "comBoxTrapPartsSlot8Part1";
            comBoxTrapPartsSlot8Part1.Size = new System.Drawing.Size(125, 23);
            comBoxTrapPartsSlot8Part1.TabIndex = 58;
            comBoxTrapPartsSlot8Part1.SelectedIndexChanged += comBoxTrapPartsSlot8Part1_SelectedIndexChanged;
            // 
            // comBoxTrapPartsSlot7Part3
            // 
            comBoxTrapPartsSlot7Part3.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxTrapPartsSlot7Part3.FormattingEnabled = true;
            comBoxTrapPartsSlot7Part3.Location = new System.Drawing.Point(530, 448);
            comBoxTrapPartsSlot7Part3.Margin = new Padding(4, 3, 4, 3);
            comBoxTrapPartsSlot7Part3.Name = "comBoxTrapPartsSlot7Part3";
            comBoxTrapPartsSlot7Part3.Size = new System.Drawing.Size(125, 23);
            comBoxTrapPartsSlot7Part3.TabIndex = 57;
            comBoxTrapPartsSlot7Part3.SelectedIndexChanged += comBoxTrapPartsSlot7Part3_SelectedIndexChanged;
            // 
            // comBoxTrapPartsSlot7Part2
            // 
            comBoxTrapPartsSlot7Part2.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxTrapPartsSlot7Part2.FormattingEnabled = true;
            comBoxTrapPartsSlot7Part2.Location = new System.Drawing.Point(401, 448);
            comBoxTrapPartsSlot7Part2.Margin = new Padding(4, 3, 4, 3);
            comBoxTrapPartsSlot7Part2.Name = "comBoxTrapPartsSlot7Part2";
            comBoxTrapPartsSlot7Part2.Size = new System.Drawing.Size(125, 23);
            comBoxTrapPartsSlot7Part2.TabIndex = 56;
            comBoxTrapPartsSlot7Part2.SelectedIndexChanged += comBoxTrapPartsSlot7Part2_SelectedIndexChanged;
            // 
            // comBoxTrapPartsSlot7Part1
            // 
            comBoxTrapPartsSlot7Part1.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxTrapPartsSlot7Part1.FormattingEnabled = true;
            comBoxTrapPartsSlot7Part1.Location = new System.Drawing.Point(273, 448);
            comBoxTrapPartsSlot7Part1.Margin = new Padding(4, 3, 4, 3);
            comBoxTrapPartsSlot7Part1.Name = "comBoxTrapPartsSlot7Part1";
            comBoxTrapPartsSlot7Part1.Size = new System.Drawing.Size(125, 23);
            comBoxTrapPartsSlot7Part1.TabIndex = 55;
            comBoxTrapPartsSlot7Part1.SelectedIndexChanged += comBoxTrapPartsSlot7Part1_SelectedIndexChanged;
            // 
            // comBoxTrapPartsSlot6Part3
            // 
            comBoxTrapPartsSlot6Part3.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxTrapPartsSlot6Part3.FormattingEnabled = true;
            comBoxTrapPartsSlot6Part3.Location = new System.Drawing.Point(530, 417);
            comBoxTrapPartsSlot6Part3.Margin = new Padding(4, 3, 4, 3);
            comBoxTrapPartsSlot6Part3.Name = "comBoxTrapPartsSlot6Part3";
            comBoxTrapPartsSlot6Part3.Size = new System.Drawing.Size(125, 23);
            comBoxTrapPartsSlot6Part3.TabIndex = 54;
            comBoxTrapPartsSlot6Part3.SelectedIndexChanged += comBoxTrapPartsSlot6Part3_SelectedIndexChanged;
            // 
            // comBoxTrapPartsSlot6Part2
            // 
            comBoxTrapPartsSlot6Part2.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxTrapPartsSlot6Part2.FormattingEnabled = true;
            comBoxTrapPartsSlot6Part2.Location = new System.Drawing.Point(401, 417);
            comBoxTrapPartsSlot6Part2.Margin = new Padding(4, 3, 4, 3);
            comBoxTrapPartsSlot6Part2.Name = "comBoxTrapPartsSlot6Part2";
            comBoxTrapPartsSlot6Part2.Size = new System.Drawing.Size(125, 23);
            comBoxTrapPartsSlot6Part2.TabIndex = 53;
            comBoxTrapPartsSlot6Part2.SelectedIndexChanged += comBoxTrapPartsSlot6Part2_SelectedIndexChanged;
            // 
            // comBoxTrapPartsSlot6Part1
            // 
            comBoxTrapPartsSlot6Part1.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxTrapPartsSlot6Part1.FormattingEnabled = true;
            comBoxTrapPartsSlot6Part1.Location = new System.Drawing.Point(273, 417);
            comBoxTrapPartsSlot6Part1.Margin = new Padding(4, 3, 4, 3);
            comBoxTrapPartsSlot6Part1.Name = "comBoxTrapPartsSlot6Part1";
            comBoxTrapPartsSlot6Part1.Size = new System.Drawing.Size(125, 23);
            comBoxTrapPartsSlot6Part1.TabIndex = 52;
            comBoxTrapPartsSlot6Part1.SelectedIndexChanged += comBoxTrapPartsSlot6Part1_SelectedIndexChanged;
            // 
            // comBoxTrapPartsSlot5Part3
            // 
            comBoxTrapPartsSlot5Part3.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxTrapPartsSlot5Part3.FormattingEnabled = true;
            comBoxTrapPartsSlot5Part3.Location = new System.Drawing.Point(530, 385);
            comBoxTrapPartsSlot5Part3.Margin = new Padding(4, 3, 4, 3);
            comBoxTrapPartsSlot5Part3.Name = "comBoxTrapPartsSlot5Part3";
            comBoxTrapPartsSlot5Part3.Size = new System.Drawing.Size(125, 23);
            comBoxTrapPartsSlot5Part3.TabIndex = 51;
            comBoxTrapPartsSlot5Part3.SelectedIndexChanged += comBoxTrapPartsSlot5Part3_SelectedIndexChanged;
            // 
            // comBoxTrapPartsSlot5Part2
            // 
            comBoxTrapPartsSlot5Part2.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxTrapPartsSlot5Part2.FormattingEnabled = true;
            comBoxTrapPartsSlot5Part2.Location = new System.Drawing.Point(401, 385);
            comBoxTrapPartsSlot5Part2.Margin = new Padding(4, 3, 4, 3);
            comBoxTrapPartsSlot5Part2.Name = "comBoxTrapPartsSlot5Part2";
            comBoxTrapPartsSlot5Part2.Size = new System.Drawing.Size(125, 23);
            comBoxTrapPartsSlot5Part2.TabIndex = 50;
            comBoxTrapPartsSlot5Part2.SelectedIndexChanged += comBoxTrapPartsSlot5Part2_SelectedIndexChanged;
            // 
            // comBoxTrapPartsSlot5Part1
            // 
            comBoxTrapPartsSlot5Part1.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxTrapPartsSlot5Part1.FormattingEnabled = true;
            comBoxTrapPartsSlot5Part1.Location = new System.Drawing.Point(273, 385);
            comBoxTrapPartsSlot5Part1.Margin = new Padding(4, 3, 4, 3);
            comBoxTrapPartsSlot5Part1.Name = "comBoxTrapPartsSlot5Part1";
            comBoxTrapPartsSlot5Part1.Size = new System.Drawing.Size(125, 23);
            comBoxTrapPartsSlot5Part1.TabIndex = 49;
            comBoxTrapPartsSlot5Part1.SelectedIndexChanged += comBoxTrapPartsSlot5Part1_SelectedIndexChanged;
            // 
            // comBoxTrapPartsSlot4Part3
            // 
            comBoxTrapPartsSlot4Part3.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxTrapPartsSlot4Part3.FormattingEnabled = true;
            comBoxTrapPartsSlot4Part3.Location = new System.Drawing.Point(530, 354);
            comBoxTrapPartsSlot4Part3.Margin = new Padding(4, 3, 4, 3);
            comBoxTrapPartsSlot4Part3.Name = "comBoxTrapPartsSlot4Part3";
            comBoxTrapPartsSlot4Part3.Size = new System.Drawing.Size(125, 23);
            comBoxTrapPartsSlot4Part3.TabIndex = 48;
            comBoxTrapPartsSlot4Part3.SelectedIndexChanged += comBoxTrapPartsSlot4Part3_SelectedIndexChanged;
            // 
            // comBoxTrapPartsSlot4Part2
            // 
            comBoxTrapPartsSlot4Part2.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxTrapPartsSlot4Part2.FormattingEnabled = true;
            comBoxTrapPartsSlot4Part2.Location = new System.Drawing.Point(401, 354);
            comBoxTrapPartsSlot4Part2.Margin = new Padding(4, 3, 4, 3);
            comBoxTrapPartsSlot4Part2.Name = "comBoxTrapPartsSlot4Part2";
            comBoxTrapPartsSlot4Part2.Size = new System.Drawing.Size(125, 23);
            comBoxTrapPartsSlot4Part2.TabIndex = 47;
            comBoxTrapPartsSlot4Part2.SelectedIndexChanged += comBoxTrapPartsSlot4Part2_SelectedIndexChanged;
            // 
            // comBoxTrapPartsSlot4Part1
            // 
            comBoxTrapPartsSlot4Part1.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxTrapPartsSlot4Part1.FormattingEnabled = true;
            comBoxTrapPartsSlot4Part1.Location = new System.Drawing.Point(273, 354);
            comBoxTrapPartsSlot4Part1.Margin = new Padding(4, 3, 4, 3);
            comBoxTrapPartsSlot4Part1.Name = "comBoxTrapPartsSlot4Part1";
            comBoxTrapPartsSlot4Part1.Size = new System.Drawing.Size(125, 23);
            comBoxTrapPartsSlot4Part1.TabIndex = 46;
            comBoxTrapPartsSlot4Part1.SelectedIndexChanged += comBoxTrapPartsSlot4Part1_SelectedIndexChanged;
            // 
            // comBoxTrapPartsSlot3Part3
            // 
            comBoxTrapPartsSlot3Part3.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxTrapPartsSlot3Part3.FormattingEnabled = true;
            comBoxTrapPartsSlot3Part3.Location = new System.Drawing.Point(530, 323);
            comBoxTrapPartsSlot3Part3.Margin = new Padding(4, 3, 4, 3);
            comBoxTrapPartsSlot3Part3.Name = "comBoxTrapPartsSlot3Part3";
            comBoxTrapPartsSlot3Part3.Size = new System.Drawing.Size(125, 23);
            comBoxTrapPartsSlot3Part3.TabIndex = 45;
            comBoxTrapPartsSlot3Part3.SelectedIndexChanged += comBoxTrapPartsSlot3Part3_SelectedIndexChanged;
            // 
            // comBoxTrapPartsSlot3Part2
            // 
            comBoxTrapPartsSlot3Part2.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxTrapPartsSlot3Part2.FormattingEnabled = true;
            comBoxTrapPartsSlot3Part2.Location = new System.Drawing.Point(401, 323);
            comBoxTrapPartsSlot3Part2.Margin = new Padding(4, 3, 4, 3);
            comBoxTrapPartsSlot3Part2.Name = "comBoxTrapPartsSlot3Part2";
            comBoxTrapPartsSlot3Part2.Size = new System.Drawing.Size(125, 23);
            comBoxTrapPartsSlot3Part2.TabIndex = 44;
            comBoxTrapPartsSlot3Part2.SelectedIndexChanged += comBoxTrapPartsSlot3Part2_SelectedIndexChanged;
            // 
            // comBoxTrapPartsSlot3Part1
            // 
            comBoxTrapPartsSlot3Part1.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxTrapPartsSlot3Part1.FormattingEnabled = true;
            comBoxTrapPartsSlot3Part1.Location = new System.Drawing.Point(273, 323);
            comBoxTrapPartsSlot3Part1.Margin = new Padding(4, 3, 4, 3);
            comBoxTrapPartsSlot3Part1.Name = "comBoxTrapPartsSlot3Part1";
            comBoxTrapPartsSlot3Part1.Size = new System.Drawing.Size(125, 23);
            comBoxTrapPartsSlot3Part1.TabIndex = 43;
            comBoxTrapPartsSlot3Part1.SelectedIndexChanged += comBoxTrapPartsSlot3Part1_SelectedIndexChanged;
            // 
            // comBoxTrapPartsSlot2Part3
            // 
            comBoxTrapPartsSlot2Part3.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxTrapPartsSlot2Part3.FormattingEnabled = true;
            comBoxTrapPartsSlot2Part3.Location = new System.Drawing.Point(530, 292);
            comBoxTrapPartsSlot2Part3.Margin = new Padding(4, 3, 4, 3);
            comBoxTrapPartsSlot2Part3.Name = "comBoxTrapPartsSlot2Part3";
            comBoxTrapPartsSlot2Part3.Size = new System.Drawing.Size(125, 23);
            comBoxTrapPartsSlot2Part3.TabIndex = 42;
            comBoxTrapPartsSlot2Part3.SelectedIndexChanged += comBoxTrapPartsSlot2Part3_SelectedIndexChanged;
            // 
            // comBoxTrapPartsSlot2Part2
            // 
            comBoxTrapPartsSlot2Part2.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxTrapPartsSlot2Part2.FormattingEnabled = true;
            comBoxTrapPartsSlot2Part2.Location = new System.Drawing.Point(401, 292);
            comBoxTrapPartsSlot2Part2.Margin = new Padding(4, 3, 4, 3);
            comBoxTrapPartsSlot2Part2.Name = "comBoxTrapPartsSlot2Part2";
            comBoxTrapPartsSlot2Part2.Size = new System.Drawing.Size(125, 23);
            comBoxTrapPartsSlot2Part2.TabIndex = 41;
            comBoxTrapPartsSlot2Part2.SelectedIndexChanged += comBoxTrapPartsSlot2Part2_SelectedIndexChanged;
            // 
            // comBoxTrapPartsSlot2Part1
            // 
            comBoxTrapPartsSlot2Part1.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxTrapPartsSlot2Part1.FormattingEnabled = true;
            comBoxTrapPartsSlot2Part1.Location = new System.Drawing.Point(273, 292);
            comBoxTrapPartsSlot2Part1.Margin = new Padding(4, 3, 4, 3);
            comBoxTrapPartsSlot2Part1.Name = "comBoxTrapPartsSlot2Part1";
            comBoxTrapPartsSlot2Part1.Size = new System.Drawing.Size(125, 23);
            comBoxTrapPartsSlot2Part1.TabIndex = 40;
            comBoxTrapPartsSlot2Part1.SelectedIndexChanged += comBoxTrapPartsSlot2Part1_SelectedIndexChanged;
            // 
            // comBoxTrapPartsSlot1Part3
            // 
            comBoxTrapPartsSlot1Part3.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxTrapPartsSlot1Part3.FormattingEnabled = true;
            comBoxTrapPartsSlot1Part3.Location = new System.Drawing.Point(530, 261);
            comBoxTrapPartsSlot1Part3.Margin = new Padding(4, 3, 4, 3);
            comBoxTrapPartsSlot1Part3.Name = "comBoxTrapPartsSlot1Part3";
            comBoxTrapPartsSlot1Part3.Size = new System.Drawing.Size(125, 23);
            comBoxTrapPartsSlot1Part3.TabIndex = 39;
            comBoxTrapPartsSlot1Part3.SelectedIndexChanged += comBoxTrapPartsSlot1Part3_SelectedIndexChanged;
            // 
            // comBoxTrapPartsSlot1Part2
            // 
            comBoxTrapPartsSlot1Part2.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxTrapPartsSlot1Part2.FormattingEnabled = true;
            comBoxTrapPartsSlot1Part2.Location = new System.Drawing.Point(401, 261);
            comBoxTrapPartsSlot1Part2.Margin = new Padding(4, 3, 4, 3);
            comBoxTrapPartsSlot1Part2.Name = "comBoxTrapPartsSlot1Part2";
            comBoxTrapPartsSlot1Part2.Size = new System.Drawing.Size(125, 23);
            comBoxTrapPartsSlot1Part2.TabIndex = 38;
            comBoxTrapPartsSlot1Part2.SelectedIndexChanged += comBoxTrapPartsSlot1Part2_SelectedIndexChanged;
            // 
            // comBoxTrapPartsSlot1Part1
            // 
            comBoxTrapPartsSlot1Part1.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxTrapPartsSlot1Part1.FormattingEnabled = true;
            comBoxTrapPartsSlot1Part1.Location = new System.Drawing.Point(273, 261);
            comBoxTrapPartsSlot1Part1.Margin = new Padding(4, 3, 4, 3);
            comBoxTrapPartsSlot1Part1.Name = "comBoxTrapPartsSlot1Part1";
            comBoxTrapPartsSlot1Part1.Size = new System.Drawing.Size(125, 23);
            comBoxTrapPartsSlot1Part1.TabIndex = 37;
            comBoxTrapPartsSlot1Part1.SelectedIndexChanged += comBoxTrapPartsSlot1Part1_SelectedIndexChanged;
            // 
            // labelTraitNoBonusSlot
            // 
            labelTraitNoBonusSlot.AutoSize = true;
            labelTraitNoBonusSlot.Location = new System.Drawing.Point(324, 215);
            labelTraitNoBonusSlot.Margin = new Padding(4, 0, 4, 0);
            labelTraitNoBonusSlot.Name = "labelTraitNoBonusSlot";
            labelTraitNoBonusSlot.Size = new System.Drawing.Size(84, 15);
            labelTraitNoBonusSlot.TabIndex = 35;
            labelTraitNoBonusSlot.Text = "No Bonus Trait";
            // 
            // comboxTraitYellowSlot
            // 
            comboxTraitYellowSlot.DropDownStyle = ComboBoxStyle.DropDownList;
            comboxTraitYellowSlot.FormattingEnabled = true;
            comboxTraitYellowSlot.Location = new System.Drawing.Point(422, 117);
            comboxTraitYellowSlot.Margin = new Padding(4, 3, 4, 3);
            comboxTraitYellowSlot.Name = "comboxTraitYellowSlot";
            comboxTraitYellowSlot.Size = new System.Drawing.Size(233, 23);
            comboxTraitYellowSlot.TabIndex = 32;
            comboxTraitYellowSlot.SelectedIndexChanged += comboxTraitYellowSlot_SelectedIndexChanged;
            // 
            // labelTraitYellowSlot
            // 
            labelTraitYellowSlot.AutoSize = true;
            labelTraitYellowSlot.BackColor = System.Drawing.Color.Gold;
            labelTraitYellowSlot.Location = new System.Drawing.Point(324, 121);
            labelTraitYellowSlot.Margin = new Padding(4, 0, 4, 0);
            labelTraitYellowSlot.Name = "labelTraitYellowSlot";
            labelTraitYellowSlot.Size = new System.Drawing.Size(73, 15);
            labelTraitYellowSlot.TabIndex = 34;
            labelTraitYellowSlot.Text = "Triangle Trait";
            // 
            // comboxTraitNoBonusSlot
            // 
            comboxTraitNoBonusSlot.DropDownStyle = ComboBoxStyle.DropDownList;
            comboxTraitNoBonusSlot.FormattingEnabled = true;
            comboxTraitNoBonusSlot.Location = new System.Drawing.Point(422, 210);
            comboxTraitNoBonusSlot.Margin = new Padding(4, 3, 4, 3);
            comboxTraitNoBonusSlot.Name = "comboxTraitNoBonusSlot";
            comboxTraitNoBonusSlot.Size = new System.Drawing.Size(233, 23);
            comboxTraitNoBonusSlot.TabIndex = 33;
            comboxTraitNoBonusSlot.SelectedIndexChanged += comboxTraitNoBonusSlot_SelectedIndexChanged;
            // 
            // labelTraitBlueSlot
            // 
            labelTraitBlueSlot.AutoSize = true;
            labelTraitBlueSlot.BackColor = System.Drawing.Color.LightSkyBlue;
            labelTraitBlueSlot.Location = new System.Drawing.Point(324, 183);
            labelTraitBlueSlot.Margin = new Padding(4, 0, 4, 0);
            labelTraitBlueSlot.Name = "labelTraitBlueSlot";
            labelTraitBlueSlot.Size = new System.Drawing.Size(81, 15);
            labelTraitBlueSlot.TabIndex = 31;
            labelTraitBlueSlot.Text = "Diamond Trait";
            // 
            // comboxTraitGreenSlot
            // 
            comboxTraitGreenSlot.DropDownStyle = ComboBoxStyle.DropDownList;
            comboxTraitGreenSlot.FormattingEnabled = true;
            comboxTraitGreenSlot.Location = new System.Drawing.Point(422, 148);
            comboxTraitGreenSlot.Margin = new Padding(4, 3, 4, 3);
            comboxTraitGreenSlot.Name = "comboxTraitGreenSlot";
            comboxTraitGreenSlot.Size = new System.Drawing.Size(233, 23);
            comboxTraitGreenSlot.TabIndex = 28;
            comboxTraitGreenSlot.SelectedIndexChanged += comboxTraitGreenSlot_SelectedIndexChanged;
            // 
            // labelTraitGreenSlot
            // 
            labelTraitGreenSlot.AutoSize = true;
            labelTraitGreenSlot.BackColor = System.Drawing.Color.LightGreen;
            labelTraitGreenSlot.Location = new System.Drawing.Point(324, 152);
            labelTraitGreenSlot.Margin = new Padding(4, 0, 4, 0);
            labelTraitGreenSlot.Name = "labelTraitGreenSlot";
            labelTraitGreenSlot.Size = new System.Drawing.Size(83, 15);
            labelTraitGreenSlot.TabIndex = 30;
            labelTraitGreenSlot.Text = "Pentagon Trait";
            // 
            // comboxTraitBlueSlot
            // 
            comboxTraitBlueSlot.DropDownStyle = ComboBoxStyle.DropDownList;
            comboxTraitBlueSlot.FormattingEnabled = true;
            comboxTraitBlueSlot.Location = new System.Drawing.Point(422, 179);
            comboxTraitBlueSlot.Margin = new Padding(4, 3, 4, 3);
            comboxTraitBlueSlot.Name = "comboxTraitBlueSlot";
            comboxTraitBlueSlot.Size = new System.Drawing.Size(233, 23);
            comboxTraitBlueSlot.TabIndex = 29;
            comboxTraitBlueSlot.SelectedIndexChanged += comboxTraitBlueSlot_SelectedIndexChanged;
            // 
            // comBoxDye
            // 
            comBoxDye.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxDye.FormattingEnabled = true;
            comBoxDye.Location = new System.Drawing.Point(526, 69);
            comBoxDye.Margin = new Padding(4, 3, 4, 3);
            comBoxDye.Name = "comBoxDye";
            comBoxDye.Size = new System.Drawing.Size(129, 23);
            comBoxDye.TabIndex = 6;
            comBoxDye.SelectedIndexChanged += comBoxDye_SelectedIndexChanged;
            // 
            // labelHero
            // 
            labelHero.AutoSize = true;
            labelHero.Location = new System.Drawing.Point(7, 73);
            labelHero.Margin = new Padding(4, 0, 4, 0);
            labelHero.Name = "labelHero";
            labelHero.Size = new System.Drawing.Size(33, 15);
            labelHero.TabIndex = 1;
            labelHero.Text = "Hero";
            // 
            // labelConsumableSlot2
            // 
            labelConsumableSlot2.AutoSize = true;
            labelConsumableSlot2.Location = new System.Drawing.Point(6, 213);
            labelConsumableSlot2.Margin = new Padding(4, 0, 4, 0);
            labelConsumableSlot2.Name = "labelConsumableSlot2";
            labelConsumableSlot2.Size = new System.Drawing.Size(83, 15);
            labelConsumableSlot2.TabIndex = 27;
            labelConsumableSlot2.Text = "Consumable 2";
            // 
            // comBoxHero
            // 
            comBoxHero.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxHero.FormattingEnabled = true;
            comBoxHero.Location = new System.Drawing.Point(49, 69);
            comBoxHero.Margin = new Padding(4, 3, 4, 3);
            comBoxHero.Name = "comBoxHero";
            comBoxHero.Size = new System.Drawing.Size(146, 23);
            comBoxHero.TabIndex = 2;
            comBoxHero.SelectedIndexChanged += comBoxHero_SelectedIndexChanged;
            // 
            // comBoxConsumableSlot1
            // 
            comBoxConsumableSlot1.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxConsumableSlot1.FormattingEnabled = true;
            comBoxConsumableSlot1.Location = new System.Drawing.Point(99, 179);
            comBoxConsumableSlot1.Margin = new Padding(4, 3, 4, 3);
            comBoxConsumableSlot1.Name = "comBoxConsumableSlot1";
            comBoxConsumableSlot1.Size = new System.Drawing.Size(205, 23);
            comBoxConsumableSlot1.TabIndex = 24;
            comBoxConsumableSlot1.SelectedIndexChanged += comBoxConsumableSlot1_SelectedIndexChanged;
            // 
            // comBoxSkin
            // 
            comBoxSkin.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxSkin.FormattingEnabled = true;
            comBoxSkin.Location = new System.Drawing.Point(245, 69);
            comBoxSkin.Margin = new Padding(4, 3, 4, 3);
            comBoxSkin.Name = "comBoxSkin";
            comBoxSkin.Size = new System.Drawing.Size(221, 23);
            comBoxSkin.TabIndex = 4;
            comBoxSkin.SelectedIndexChanged += comBoxSkin_SelectedIndexChanged;
            // 
            // labelConsumableSlot1
            // 
            labelConsumableSlot1.AutoSize = true;
            labelConsumableSlot1.Location = new System.Drawing.Point(6, 182);
            labelConsumableSlot1.Margin = new Padding(4, 0, 4, 0);
            labelConsumableSlot1.Name = "labelConsumableSlot1";
            labelConsumableSlot1.Size = new System.Drawing.Size(83, 15);
            labelConsumableSlot1.TabIndex = 26;
            labelConsumableSlot1.Text = "Consumable 1";
            // 
            // labelDye
            // 
            labelDye.AutoSize = true;
            labelDye.Location = new System.Drawing.Point(489, 73);
            labelDye.Margin = new Padding(4, 0, 4, 0);
            labelDye.Name = "labelDye";
            labelDye.Size = new System.Drawing.Size(27, 15);
            labelDye.TabIndex = 5;
            labelDye.Text = "Dye";
            // 
            // comBoxConsumableSlot2
            // 
            comBoxConsumableSlot2.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxConsumableSlot2.FormattingEnabled = true;
            comBoxConsumableSlot2.Location = new System.Drawing.Point(99, 210);
            comBoxConsumableSlot2.Margin = new Padding(4, 3, 4, 3);
            comBoxConsumableSlot2.Name = "comBoxConsumableSlot2";
            comBoxConsumableSlot2.Size = new System.Drawing.Size(205, 23);
            comBoxConsumableSlot2.TabIndex = 25;
            comBoxConsumableSlot2.SelectedIndexChanged += comBoxConsumableSlot2_SelectedIndexChanged;
            // 
            // labelSkin
            // 
            labelSkin.AutoSize = true;
            labelSkin.Location = new System.Drawing.Point(205, 73);
            labelSkin.Margin = new Padding(4, 0, 4, 0);
            labelSkin.Name = "labelSkin";
            labelSkin.Size = new System.Drawing.Size(29, 15);
            labelSkin.TabIndex = 3;
            labelSkin.Text = "Skin";
            // 
            // labelGuardianSlot2
            // 
            labelGuardianSlot2.AutoSize = true;
            labelGuardianSlot2.Location = new System.Drawing.Point(6, 151);
            labelGuardianSlot2.Margin = new Padding(4, 0, 4, 0);
            labelGuardianSlot2.Name = "labelGuardianSlot2";
            labelGuardianSlot2.Size = new System.Drawing.Size(64, 15);
            labelGuardianSlot2.TabIndex = 21;
            labelGuardianSlot2.Text = "Guardian 2";
            // 
            // comBoxLoadouts
            // 
            comBoxLoadouts.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxLoadouts.FormattingEnabled = true;
            comBoxLoadouts.Location = new System.Drawing.Point(10, 22);
            comBoxLoadouts.Margin = new Padding(4, 3, 4, 3);
            comBoxLoadouts.Name = "comBoxLoadouts";
            comBoxLoadouts.Size = new System.Drawing.Size(293, 23);
            comBoxLoadouts.TabIndex = 23;
            comBoxLoadouts.SelectedIndexChanged += comBoxLoadouts_SelectedIndexChanged;
            // 
            // labelLoadoutSlot9
            // 
            labelLoadoutSlot9.AutoSize = true;
            labelLoadoutSlot9.Location = new System.Drawing.Point(6, 513);
            labelLoadoutSlot9.Margin = new Padding(4, 0, 4, 0);
            labelLoadoutSlot9.Name = "labelLoadoutSlot9";
            labelLoadoutSlot9.Size = new System.Drawing.Size(36, 15);
            labelLoadoutSlot9.TabIndex = 17;
            labelLoadoutSlot9.Text = "Slot 9";
            // 
            // comBoxGuardianSlot1
            // 
            comBoxGuardianSlot1.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxGuardianSlot1.FormattingEnabled = true;
            comBoxGuardianSlot1.Location = new System.Drawing.Point(82, 117);
            comBoxGuardianSlot1.Margin = new Padding(4, 3, 4, 3);
            comBoxGuardianSlot1.Name = "comBoxGuardianSlot1";
            comBoxGuardianSlot1.Size = new System.Drawing.Size(222, 23);
            comBoxGuardianSlot1.TabIndex = 18;
            comBoxGuardianSlot1.SelectedIndexChanged += comBoxGuardianSlot1_SelectedIndexChanged;
            // 
            // labelGuardianSlot1
            // 
            labelGuardianSlot1.AutoSize = true;
            labelGuardianSlot1.Location = new System.Drawing.Point(6, 120);
            labelGuardianSlot1.Margin = new Padding(4, 0, 4, 0);
            labelGuardianSlot1.Name = "labelGuardianSlot1";
            labelGuardianSlot1.Size = new System.Drawing.Size(64, 15);
            labelGuardianSlot1.TabIndex = 20;
            labelGuardianSlot1.Text = "Guardian 1";
            // 
            // labelLoadoutSlot8
            // 
            labelLoadoutSlot8.AutoSize = true;
            labelLoadoutSlot8.Location = new System.Drawing.Point(6, 482);
            labelLoadoutSlot8.Margin = new Padding(4, 0, 4, 0);
            labelLoadoutSlot8.Name = "labelLoadoutSlot8";
            labelLoadoutSlot8.Size = new System.Drawing.Size(36, 15);
            labelLoadoutSlot8.TabIndex = 16;
            labelLoadoutSlot8.Text = "Slot 8";
            // 
            // comBoxGuardianSlot2
            // 
            comBoxGuardianSlot2.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxGuardianSlot2.FormattingEnabled = true;
            comBoxGuardianSlot2.Location = new System.Drawing.Point(82, 148);
            comBoxGuardianSlot2.Margin = new Padding(4, 3, 4, 3);
            comBoxGuardianSlot2.Name = "comBoxGuardianSlot2";
            comBoxGuardianSlot2.Size = new System.Drawing.Size(222, 23);
            comBoxGuardianSlot2.TabIndex = 19;
            comBoxGuardianSlot2.SelectedIndexChanged += comBoxGuardianSlot2_SelectedIndexChanged;
            // 
            // labelLoadoutSlot7
            // 
            labelLoadoutSlot7.AutoSize = true;
            labelLoadoutSlot7.Location = new System.Drawing.Point(6, 451);
            labelLoadoutSlot7.Margin = new Padding(4, 0, 4, 0);
            labelLoadoutSlot7.Name = "labelLoadoutSlot7";
            labelLoadoutSlot7.Size = new System.Drawing.Size(36, 15);
            labelLoadoutSlot7.TabIndex = 15;
            labelLoadoutSlot7.Text = "Slot 7";
            // 
            // labelLoadoutSlot6
            // 
            labelLoadoutSlot6.AutoSize = true;
            labelLoadoutSlot6.Location = new System.Drawing.Point(6, 420);
            labelLoadoutSlot6.Margin = new Padding(4, 0, 4, 0);
            labelLoadoutSlot6.Name = "labelLoadoutSlot6";
            labelLoadoutSlot6.Size = new System.Drawing.Size(36, 15);
            labelLoadoutSlot6.TabIndex = 14;
            labelLoadoutSlot6.Text = "Slot 6";
            // 
            // labelLoadoutSlot5
            // 
            labelLoadoutSlot5.AutoSize = true;
            labelLoadoutSlot5.Location = new System.Drawing.Point(6, 389);
            labelLoadoutSlot5.Margin = new Padding(4, 0, 4, 0);
            labelLoadoutSlot5.Name = "labelLoadoutSlot5";
            labelLoadoutSlot5.Size = new System.Drawing.Size(36, 15);
            labelLoadoutSlot5.TabIndex = 13;
            labelLoadoutSlot5.Text = "Slot 5";
            // 
            // labelLoadoutSlot4
            // 
            labelLoadoutSlot4.AutoSize = true;
            labelLoadoutSlot4.Location = new System.Drawing.Point(6, 358);
            labelLoadoutSlot4.Margin = new Padding(4, 0, 4, 0);
            labelLoadoutSlot4.Name = "labelLoadoutSlot4";
            labelLoadoutSlot4.Size = new System.Drawing.Size(36, 15);
            labelLoadoutSlot4.TabIndex = 12;
            labelLoadoutSlot4.Text = "Slot 4";
            // 
            // labelLoadoutSlot3
            // 
            labelLoadoutSlot3.AutoSize = true;
            labelLoadoutSlot3.Location = new System.Drawing.Point(6, 327);
            labelLoadoutSlot3.Margin = new Padding(4, 0, 4, 0);
            labelLoadoutSlot3.Name = "labelLoadoutSlot3";
            labelLoadoutSlot3.Size = new System.Drawing.Size(36, 15);
            labelLoadoutSlot3.TabIndex = 11;
            labelLoadoutSlot3.Text = "Slot 3";
            // 
            // labelLoadoutSlot2
            // 
            labelLoadoutSlot2.AutoSize = true;
            labelLoadoutSlot2.Location = new System.Drawing.Point(6, 295);
            labelLoadoutSlot2.Margin = new Padding(4, 0, 4, 0);
            labelLoadoutSlot2.Name = "labelLoadoutSlot2";
            labelLoadoutSlot2.Size = new System.Drawing.Size(36, 15);
            labelLoadoutSlot2.TabIndex = 10;
            labelLoadoutSlot2.Text = "Slot 2";
            // 
            // labelLoadoutSlot1
            // 
            labelLoadoutSlot1.AutoSize = true;
            labelLoadoutSlot1.Location = new System.Drawing.Point(6, 264);
            labelLoadoutSlot1.Margin = new Padding(4, 0, 4, 0);
            labelLoadoutSlot1.Name = "labelLoadoutSlot1";
            labelLoadoutSlot1.Size = new System.Drawing.Size(36, 15);
            labelLoadoutSlot1.TabIndex = 9;
            labelLoadoutSlot1.Text = "Slot 1";
            // 
            // comBoxLoadoutSlot1
            // 
            comBoxLoadoutSlot1.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxLoadoutSlot1.FormattingEnabled = true;
            comBoxLoadoutSlot1.Location = new System.Drawing.Point(52, 261);
            comBoxLoadoutSlot1.Margin = new Padding(4, 3, 4, 3);
            comBoxLoadoutSlot1.Name = "comBoxLoadoutSlot1";
            comBoxLoadoutSlot1.Size = new System.Drawing.Size(185, 23);
            comBoxLoadoutSlot1.TabIndex = 0;
            comBoxLoadoutSlot1.SelectedIndexChanged += comBoxLoadoutSlot1_SelectedIndexChanged;
            // 
            // comBoxLoadoutSlot2
            // 
            comBoxLoadoutSlot2.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxLoadoutSlot2.FormattingEnabled = true;
            comBoxLoadoutSlot2.Location = new System.Drawing.Point(52, 292);
            comBoxLoadoutSlot2.Margin = new Padding(4, 3, 4, 3);
            comBoxLoadoutSlot2.Name = "comBoxLoadoutSlot2";
            comBoxLoadoutSlot2.Size = new System.Drawing.Size(185, 23);
            comBoxLoadoutSlot2.TabIndex = 1;
            comBoxLoadoutSlot2.SelectedIndexChanged += comBoxLoadoutSlot2_SelectedIndexChanged;
            // 
            // comBoxLoadoutSlot3
            // 
            comBoxLoadoutSlot3.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxLoadoutSlot3.FormattingEnabled = true;
            comBoxLoadoutSlot3.Location = new System.Drawing.Point(52, 323);
            comBoxLoadoutSlot3.Margin = new Padding(4, 3, 4, 3);
            comBoxLoadoutSlot3.Name = "comBoxLoadoutSlot3";
            comBoxLoadoutSlot3.Size = new System.Drawing.Size(185, 23);
            comBoxLoadoutSlot3.TabIndex = 2;
            comBoxLoadoutSlot3.SelectedIndexChanged += comBoxLoadoutSlot3_SelectedIndexChanged;
            // 
            // comBoxLoadoutSlot9
            // 
            comBoxLoadoutSlot9.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxLoadoutSlot9.FormattingEnabled = true;
            comBoxLoadoutSlot9.Location = new System.Drawing.Point(52, 510);
            comBoxLoadoutSlot9.Margin = new Padding(4, 3, 4, 3);
            comBoxLoadoutSlot9.Name = "comBoxLoadoutSlot9";
            comBoxLoadoutSlot9.Size = new System.Drawing.Size(185, 23);
            comBoxLoadoutSlot9.TabIndex = 8;
            comBoxLoadoutSlot9.SelectedIndexChanged += comBoxLoadoutSlot9_SelectedIndexChanged;
            // 
            // comBoxLoadoutSlot4
            // 
            comBoxLoadoutSlot4.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxLoadoutSlot4.FormattingEnabled = true;
            comBoxLoadoutSlot4.Location = new System.Drawing.Point(52, 354);
            comBoxLoadoutSlot4.Margin = new Padding(4, 3, 4, 3);
            comBoxLoadoutSlot4.Name = "comBoxLoadoutSlot4";
            comBoxLoadoutSlot4.Size = new System.Drawing.Size(185, 23);
            comBoxLoadoutSlot4.TabIndex = 3;
            comBoxLoadoutSlot4.SelectedIndexChanged += comBoxLoadoutSlot4_SelectedIndexChanged;
            // 
            // comBoxLoadoutSlot8
            // 
            comBoxLoadoutSlot8.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxLoadoutSlot8.FormattingEnabled = true;
            comBoxLoadoutSlot8.Location = new System.Drawing.Point(52, 479);
            comBoxLoadoutSlot8.Margin = new Padding(4, 3, 4, 3);
            comBoxLoadoutSlot8.Name = "comBoxLoadoutSlot8";
            comBoxLoadoutSlot8.Size = new System.Drawing.Size(185, 23);
            comBoxLoadoutSlot8.TabIndex = 7;
            comBoxLoadoutSlot8.SelectedIndexChanged += comBoxLoadoutSlot8_SelectedIndexChanged;
            // 
            // comBoxLoadoutSlot5
            // 
            comBoxLoadoutSlot5.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxLoadoutSlot5.FormattingEnabled = true;
            comBoxLoadoutSlot5.Location = new System.Drawing.Point(52, 385);
            comBoxLoadoutSlot5.Margin = new Padding(4, 3, 4, 3);
            comBoxLoadoutSlot5.Name = "comBoxLoadoutSlot5";
            comBoxLoadoutSlot5.Size = new System.Drawing.Size(185, 23);
            comBoxLoadoutSlot5.TabIndex = 4;
            comBoxLoadoutSlot5.SelectedIndexChanged += comBoxLoadoutSlot5_SelectedIndexChanged;
            // 
            // comBoxLoadoutSlot7
            // 
            comBoxLoadoutSlot7.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxLoadoutSlot7.FormattingEnabled = true;
            comBoxLoadoutSlot7.Location = new System.Drawing.Point(52, 448);
            comBoxLoadoutSlot7.Margin = new Padding(4, 3, 4, 3);
            comBoxLoadoutSlot7.Name = "comBoxLoadoutSlot7";
            comBoxLoadoutSlot7.Size = new System.Drawing.Size(185, 23);
            comBoxLoadoutSlot7.TabIndex = 6;
            comBoxLoadoutSlot7.SelectedIndexChanged += comBoxLoadoutSlot7_SelectedIndexChanged;
            // 
            // comBoxLoadoutSlot6
            // 
            comBoxLoadoutSlot6.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxLoadoutSlot6.FormattingEnabled = true;
            comBoxLoadoutSlot6.Location = new System.Drawing.Point(52, 417);
            comBoxLoadoutSlot6.Margin = new Padding(4, 3, 4, 3);
            comBoxLoadoutSlot6.Name = "comBoxLoadoutSlot6";
            comBoxLoadoutSlot6.Size = new System.Drawing.Size(185, 23);
            comBoxLoadoutSlot6.TabIndex = 5;
            comBoxLoadoutSlot6.SelectedIndexChanged += comBoxLoadoutSlot6_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(gameModeTabControl);
            panel1.Controls.Add(btnDiscord);
            panel1.Controls.Add(chkDebug);
            panel1.Controls.Add(chkRunAs32);
            panel1.Controls.Add(btnResetConfig);
            panel1.Location = new System.Drawing.Point(686, 3);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(414, 678);
            panel1.TabIndex = 93;
            // 
            // gameModeTabControl
            // 
            gameModeTabControl.Controls.Add(gameModeSurvivalTab);
            gameModeTabControl.Controls.Add(gameModeSiegeTab);
            gameModeTabControl.ItemSize = new System.Drawing.Size(175, 18);
            gameModeTabControl.Location = new System.Drawing.Point(0, 38);
            gameModeTabControl.Margin = new Padding(4, 3, 4, 3);
            gameModeTabControl.Name = "gameModeTabControl";
            gameModeTabControl.SelectedIndex = 0;
            gameModeTabControl.Size = new System.Drawing.Size(415, 600);
            gameModeTabControl.SizeMode = TabSizeMode.Fixed;
            gameModeTabControl.TabIndex = 95;
            // 
            // gameModeSurvivalTab
            // 
            gameModeSurvivalTab.BackColor = System.Drawing.Color.PaleTurquoise;
            gameModeSurvivalTab.Controls.Add(survivalGameTabControl);
            gameModeSurvivalTab.Controls.Add(gameSettingsGroupBox);
            gameModeSurvivalTab.Location = new System.Drawing.Point(4, 22);
            gameModeSurvivalTab.Margin = new Padding(4, 3, 4, 3);
            gameModeSurvivalTab.Name = "gameModeSurvivalTab";
            gameModeSurvivalTab.Padding = new Padding(4, 3, 4, 3);
            gameModeSurvivalTab.Size = new System.Drawing.Size(407, 574);
            gameModeSurvivalTab.TabIndex = 0;
            gameModeSurvivalTab.Text = "Survival";
            // 
            // gameModeSiegeTab
            // 
            gameModeSiegeTab.BackColor = System.Drawing.Color.FromArgb(251, 182, 89);
            gameModeSiegeTab.Controls.Add(siegeGameTabControl);
            gameModeSiegeTab.Controls.Add(siegeGameSettingsGroupBox);
            gameModeSiegeTab.Location = new System.Drawing.Point(4, 22);
            gameModeSiegeTab.Margin = new Padding(4, 3, 4, 3);
            gameModeSiegeTab.Name = "gameModeSiegeTab";
            gameModeSiegeTab.Padding = new Padding(4, 3, 4, 3);
            gameModeSiegeTab.Size = new System.Drawing.Size(407, 574);
            gameModeSiegeTab.TabIndex = 1;
            gameModeSiegeTab.Text = "Siege";
            // 
            // siegeGameTabControl
            // 
            siegeGameTabControl.Controls.Add(tabPage7);
            siegeGameTabControl.Controls.Add(tabPage8);
            siegeGameTabControl.ItemSize = new System.Drawing.Size(170, 20);
            siegeGameTabControl.Location = new System.Drawing.Point(2, 65);
            siegeGameTabControl.Margin = new Padding(4, 3, 4, 3);
            siegeGameTabControl.Name = "siegeGameTabControl";
            siegeGameTabControl.SelectedIndex = 0;
            siegeGameTabControl.Size = new System.Drawing.Size(400, 502);
            siegeGameTabControl.SizeMode = TabSizeMode.Fixed;
            siegeGameTabControl.TabIndex = 88;
            // 
            // tabPage7
            // 
            tabPage7.Controls.Add(btnPlaySiegeTutorial);
            tabPage7.Controls.Add(linkLabel1);
            tabPage7.Controls.Add(label6);
            tabPage7.Controls.Add(label7);
            tabPage7.Controls.Add(maskedTextBoxJoinSiegeGameLoadout);
            tabPage7.Controls.Add(label8);
            tabPage7.Controls.Add(btnJoinSiegeGame);
            tabPage7.Controls.Add(label9);
            tabPage7.Controls.Add(maskedTextBoxJoinSiegeGameHostIP);
            tabPage7.Location = new System.Drawing.Point(4, 24);
            tabPage7.Margin = new Padding(4, 3, 4, 3);
            tabPage7.Name = "tabPage7";
            tabPage7.Padding = new Padding(4, 3, 4, 3);
            tabPage7.Size = new System.Drawing.Size(392, 474);
            tabPage7.TabIndex = 0;
            tabPage7.Text = "Join Game";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // btnPlaySiegeTutorial
            // 
            btnPlaySiegeTutorial.BackColor = System.Drawing.Color.Orange;
            btnPlaySiegeTutorial.Location = new System.Drawing.Point(126, 415);
            btnPlaySiegeTutorial.Margin = new Padding(4, 3, 4, 3);
            btnPlaySiegeTutorial.Name = "btnPlaySiegeTutorial";
            btnPlaySiegeTutorial.Size = new System.Drawing.Size(144, 47);
            btnPlaySiegeTutorial.TabIndex = 91;
            btnPlaySiegeTutorial.Text = "Play Siege Tutorial";
            btnPlaySiegeTutorial.UseVisualStyleBackColor = false;
            btnPlaySiegeTutorial.Click += btnPlaySiegeTutorial_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.ForeColor = System.Drawing.SystemColors.GrayText;
            linkLabel1.LinkArea = new LinkArea(14, 9);
            linkLabel1.LinkColor = System.Drawing.Color.Blue;
            linkLabel1.Location = new System.Drawing.Point(16, 114);
            linkLabel1.Margin = new Padding(4, 0, 4, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new System.Drawing.Size(355, 59);
            linkLabel1.TabIndex = 90;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Known Issues (Full List): \r\n - (Host) No voices, upgrades menu (close with U)\r\n - (Client) If no skills or incomplete loadout join match again\r\n";
            linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            linkLabel1.UseCompatibleTextRendering = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(13, 198);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(254, 15);
            label6.TabIndex = 89;
            label6.Text = "Enter the host IP and your loadout code below:";
            // 
            // maskedTextBoxJoinSiegeGameLoadout
            // 
            maskedTextBoxJoinSiegeGameLoadout.Location = new System.Drawing.Point(84, 225);
            maskedTextBoxJoinSiegeGameLoadout.Margin = new Padding(4, 3, 4, 3);
            maskedTextBoxJoinSiegeGameLoadout.Name = "maskedTextBoxJoinSiegeGameLoadout";
            maskedTextBoxJoinSiegeGameLoadout.Size = new System.Drawing.Size(286, 23);
            maskedTextBoxJoinSiegeGameLoadout.TabIndex = 86;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(28, 230);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(51, 15);
            label8.TabIndex = 87;
            label8.Text = "Loadout";
            // 
            // btnJoinSiegeGame
            // 
            btnJoinSiegeGame.BackColor = System.Drawing.Color.SpringGreen;
            btnJoinSiegeGame.Location = new System.Drawing.Point(229, 255);
            btnJoinSiegeGame.Margin = new Padding(4, 3, 4, 3);
            btnJoinSiegeGame.Name = "btnJoinSiegeGame";
            btnJoinSiegeGame.Size = new System.Drawing.Size(144, 69);
            btnJoinSiegeGame.TabIndex = 85;
            btnJoinSiegeGame.Text = "Join Match";
            btnJoinSiegeGame.UseVisualStyleBackColor = false;
            btnJoinSiegeGame.Click += btnJoinSiegeGame_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(29, 260);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(45, 15);
            label9.TabIndex = 84;
            label9.Text = "Host IP";
            // 
            // maskedTextBoxJoinSiegeGameHostIP
            // 
            maskedTextBoxJoinSiegeGameHostIP.Location = new System.Drawing.Point(84, 255);
            maskedTextBoxJoinSiegeGameHostIP.Margin = new Padding(4, 3, 4, 3);
            maskedTextBoxJoinSiegeGameHostIP.Name = "maskedTextBoxJoinSiegeGameHostIP";
            maskedTextBoxJoinSiegeGameHostIP.Size = new System.Drawing.Size(137, 23);
            maskedTextBoxJoinSiegeGameHostIP.TabIndex = 73;
            maskedTextBoxJoinSiegeGameHostIP.TextChanged += maskedTextBoxJoinSiegeGameHostIP_TextChanged;
            // 
            // tabPage8
            // 
            tabPage8.Controls.Add(groupBox1);
            tabPage8.Controls.Add(label21);
            tabPage8.Controls.Add(maskedTextBoxSiegeHostGamePlayer8Loadout);
            tabPage8.Controls.Add(maskedTextBoxSiegeHostGamePlayer6Loadout);
            tabPage8.Controls.Add(maskedTextBoxSiegeHostGamePlayer9Loadout);
            tabPage8.Controls.Add(maskedTextBoxSiegeHostGamePlayer7Loadout);
            tabPage8.Controls.Add(label2);
            tabPage8.Controls.Add(label4);
            tabPage8.Controls.Add(label18);
            tabPage8.Controls.Add(maskedTextBoxSiegeHostGamePlayer10Loadout);
            tabPage8.Controls.Add(label19);
            tabPage8.Controls.Add(label20);
            tabPage8.Controls.Add(label10);
            tabPage8.Controls.Add(label11);
            tabPage8.Controls.Add(maskedTextBoxSiegeHostGamePlayer3Loadout);
            tabPage8.Controls.Add(maskedTextBoxSiegeHostGamePlayer1Loadout);
            tabPage8.Controls.Add(maskedTextBoxSiegeHostGamePlayer4Loadout);
            tabPage8.Controls.Add(btnSiegeLaunch);
            tabPage8.Controls.Add(maskedTextBoxSiegeHostGamePlayer2Loadout);
            tabPage8.Controls.Add(label12);
            tabPage8.Controls.Add(label13);
            tabPage8.Controls.Add(label14);
            tabPage8.Controls.Add(maskedTextBoxSiegeHostGamePlayer5Loadout);
            tabPage8.Controls.Add(label15);
            tabPage8.Controls.Add(label16);
            tabPage8.Location = new System.Drawing.Point(4, 24);
            tabPage8.Margin = new Padding(4, 3, 4, 3);
            tabPage8.Name = "tabPage8";
            tabPage8.Padding = new Padding(4, 3, 4, 3);
            tabPage8.Size = new System.Drawing.Size(392, 474);
            tabPage8.TabIndex = 1;
            tabPage8.Text = "Host Game";
            tabPage8.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = System.Drawing.SystemColors.Control;
            groupBox1.Controls.Add(chkSiegeEnemyTeamAsBots);
            groupBox1.Controls.Add(comBoxSiegeDifficulty);
            groupBox1.Controls.Add(labelSiegeDifficulty);
            groupBox1.Controls.Add(comBoxSiegeBattleground);
            groupBox1.Controls.Add(labelSiegeMap);
            groupBox1.Location = new System.Drawing.Point(4, 6);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new System.Drawing.Size(384, 65);
            groupBox1.TabIndex = 87;
            groupBox1.TabStop = false;
            groupBox1.Text = "Battleground";
            // 
            // chkSiegeEnemyTeamAsBots
            // 
            chkSiegeEnemyTeamAsBots.AutoSize = true;
            chkSiegeEnemyTeamAsBots.Location = new System.Drawing.Point(186, 15);
            chkSiegeEnemyTeamAsBots.Margin = new Padding(4, 3, 4, 3);
            chkSiegeEnemyTeamAsBots.Name = "chkSiegeEnemyTeamAsBots";
            chkSiegeEnemyTeamAsBots.Size = new System.Drawing.Size(133, 19);
            chkSiegeEnemyTeamAsBots.TabIndex = 97;
            chkSiegeEnemyTeamAsBots.Text = "Enemy Team as Bots";
            chkSiegeEnemyTeamAsBots.UseVisualStyleBackColor = true;
            chkSiegeEnemyTeamAsBots.CheckedChanged += chkSiegeEnemyTeamAsBots_CheckedChanged;
            // 
            // comBoxSiegeDifficulty
            // 
            comBoxSiegeDifficulty.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxSiegeDifficulty.Enabled = false;
            comBoxSiegeDifficulty.FormattingEnabled = true;
            comBoxSiegeDifficulty.Location = new System.Drawing.Point(240, 36);
            comBoxSiegeDifficulty.Margin = new Padding(4, 3, 4, 3);
            comBoxSiegeDifficulty.Name = "comBoxSiegeDifficulty";
            comBoxSiegeDifficulty.Size = new System.Drawing.Size(128, 23);
            comBoxSiegeDifficulty.TabIndex = 7;
            comBoxSiegeDifficulty.SelectedIndexChanged += comBoxSiegeDifficulty_SelectedIndexChanged;
            // 
            // labelSiegeDifficulty
            // 
            labelSiegeDifficulty.AutoSize = true;
            labelSiegeDifficulty.Location = new System.Drawing.Point(183, 40);
            labelSiegeDifficulty.Margin = new Padding(4, 0, 4, 0);
            labelSiegeDifficulty.Name = "labelSiegeDifficulty";
            labelSiegeDifficulty.Size = new System.Drawing.Size(55, 15);
            labelSiegeDifficulty.TabIndex = 6;
            labelSiegeDifficulty.Text = "Difficulty";
            // 
            // comBoxSiegeBattleground
            // 
            comBoxSiegeBattleground.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxSiegeBattleground.FormattingEnabled = true;
            comBoxSiegeBattleground.Location = new System.Drawing.Point(37, 24);
            comBoxSiegeBattleground.Margin = new Padding(4, 3, 4, 3);
            comBoxSiegeBattleground.Name = "comBoxSiegeBattleground";
            comBoxSiegeBattleground.Size = new System.Drawing.Size(125, 23);
            comBoxSiegeBattleground.TabIndex = 1;
            comBoxSiegeBattleground.SelectedIndexChanged += comBoxSiegeBattleground_SelectedIndexChanged;
            // 
            // labelSiegeMap
            // 
            labelSiegeMap.AutoSize = true;
            labelSiegeMap.Location = new System.Drawing.Point(2, 28);
            labelSiegeMap.Margin = new Padding(4, 0, 4, 0);
            labelSiegeMap.Name = "labelSiegeMap";
            labelSiegeMap.Size = new System.Drawing.Size(31, 15);
            labelSiegeMap.TabIndex = 0;
            labelSiegeMap.Text = "Map";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new System.Drawing.Point(13, 243);
            label21.Margin = new Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new System.Drawing.Size(185, 15);
            label21.TabIndex = 96;
            label21.Text = "Enter Enemy Team loadout codes:";
            // 
            // maskedTextBoxSiegeHostGamePlayer8Loadout
            // 
            maskedTextBoxSiegeHostGamePlayer8Loadout.Location = new System.Drawing.Point(84, 315);
            maskedTextBoxSiegeHostGamePlayer8Loadout.Margin = new Padding(4, 3, 4, 3);
            maskedTextBoxSiegeHostGamePlayer8Loadout.Name = "maskedTextBoxSiegeHostGamePlayer8Loadout";
            maskedTextBoxSiegeHostGamePlayer8Loadout.Size = new System.Drawing.Size(288, 23);
            maskedTextBoxSiegeHostGamePlayer8Loadout.TabIndex = 88;
            // 
            // maskedTextBoxSiegeHostGamePlayer6Loadout
            // 
            maskedTextBoxSiegeHostGamePlayer6Loadout.Location = new System.Drawing.Point(84, 264);
            maskedTextBoxSiegeHostGamePlayer6Loadout.Margin = new Padding(4, 3, 4, 3);
            maskedTextBoxSiegeHostGamePlayer6Loadout.Name = "maskedTextBoxSiegeHostGamePlayer6Loadout";
            maskedTextBoxSiegeHostGamePlayer6Loadout.Size = new System.Drawing.Size(288, 23);
            maskedTextBoxSiegeHostGamePlayer6Loadout.TabIndex = 86;
            // 
            // maskedTextBoxSiegeHostGamePlayer9Loadout
            // 
            maskedTextBoxSiegeHostGamePlayer9Loadout.Location = new System.Drawing.Point(84, 340);
            maskedTextBoxSiegeHostGamePlayer9Loadout.Margin = new Padding(4, 3, 4, 3);
            maskedTextBoxSiegeHostGamePlayer9Loadout.Name = "maskedTextBoxSiegeHostGamePlayer9Loadout";
            maskedTextBoxSiegeHostGamePlayer9Loadout.Size = new System.Drawing.Size(288, 23);
            maskedTextBoxSiegeHostGamePlayer9Loadout.TabIndex = 87;
            // 
            // maskedTextBoxSiegeHostGamePlayer7Loadout
            // 
            maskedTextBoxSiegeHostGamePlayer7Loadout.Location = new System.Drawing.Point(84, 290);
            maskedTextBoxSiegeHostGamePlayer7Loadout.Margin = new Padding(4, 3, 4, 3);
            maskedTextBoxSiegeHostGamePlayer7Loadout.Name = "maskedTextBoxSiegeHostGamePlayer7Loadout";
            maskedTextBoxSiegeHostGamePlayer7Loadout.Size = new System.Drawing.Size(288, 23);
            maskedTextBoxSiegeHostGamePlayer7Loadout.TabIndex = 89;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(28, 293);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(48, 15);
            label2.TabIndex = 92;
            label2.Text = "Player 2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(28, 369);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(48, 15);
            label4.TabIndex = 95;
            label4.Text = "Player 5";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new System.Drawing.Point(28, 344);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(48, 15);
            label18.TabIndex = 93;
            label18.Text = "Player 4";
            // 
            // maskedTextBoxSiegeHostGamePlayer10Loadout
            // 
            maskedTextBoxSiegeHostGamePlayer10Loadout.Location = new System.Drawing.Point(84, 366);
            maskedTextBoxSiegeHostGamePlayer10Loadout.Margin = new Padding(4, 3, 4, 3);
            maskedTextBoxSiegeHostGamePlayer10Loadout.Name = "maskedTextBoxSiegeHostGamePlayer10Loadout";
            maskedTextBoxSiegeHostGamePlayer10Loadout.Size = new System.Drawing.Size(288, 23);
            maskedTextBoxSiegeHostGamePlayer10Loadout.TabIndex = 90;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new System.Drawing.Point(28, 268);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new System.Drawing.Size(48, 15);
            label19.TabIndex = 91;
            label19.Text = "Player 1";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new System.Drawing.Point(28, 318);
            label20.Margin = new Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(48, 15);
            label20.TabIndex = 94;
            label20.Text = "Player 3";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(14, 83);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(173, 15);
            label11.TabIndex = 84;
            label11.Text = "Enter Your Team loadout codes:";
            // 
            // maskedTextBoxSiegeHostGamePlayer3Loadout
            // 
            maskedTextBoxSiegeHostGamePlayer3Loadout.Location = new System.Drawing.Point(84, 158);
            maskedTextBoxSiegeHostGamePlayer3Loadout.Margin = new Padding(4, 3, 4, 3);
            maskedTextBoxSiegeHostGamePlayer3Loadout.Name = "maskedTextBoxSiegeHostGamePlayer3Loadout";
            maskedTextBoxSiegeHostGamePlayer3Loadout.Size = new System.Drawing.Size(288, 23);
            maskedTextBoxSiegeHostGamePlayer3Loadout.TabIndex = 76;
            // 
            // maskedTextBoxSiegeHostGamePlayer1Loadout
            // 
            maskedTextBoxSiegeHostGamePlayer1Loadout.Enabled = false;
            maskedTextBoxSiegeHostGamePlayer1Loadout.Location = new System.Drawing.Point(84, 107);
            maskedTextBoxSiegeHostGamePlayer1Loadout.Margin = new Padding(4, 3, 4, 3);
            maskedTextBoxSiegeHostGamePlayer1Loadout.Name = "maskedTextBoxSiegeHostGamePlayer1Loadout";
            maskedTextBoxSiegeHostGamePlayer1Loadout.Size = new System.Drawing.Size(288, 23);
            maskedTextBoxSiegeHostGamePlayer1Loadout.TabIndex = 73;
            // 
            // maskedTextBoxSiegeHostGamePlayer4Loadout
            // 
            maskedTextBoxSiegeHostGamePlayer4Loadout.Location = new System.Drawing.Point(84, 183);
            maskedTextBoxSiegeHostGamePlayer4Loadout.Margin = new Padding(4, 3, 4, 3);
            maskedTextBoxSiegeHostGamePlayer4Loadout.Name = "maskedTextBoxSiegeHostGamePlayer4Loadout";
            maskedTextBoxSiegeHostGamePlayer4Loadout.Size = new System.Drawing.Size(288, 23);
            maskedTextBoxSiegeHostGamePlayer4Loadout.TabIndex = 75;
            // 
            // btnSiegeLaunch
            // 
            btnSiegeLaunch.BackColor = System.Drawing.Color.SpringGreen;
            btnSiegeLaunch.Location = new System.Drawing.Point(229, 395);
            btnSiegeLaunch.Margin = new Padding(4, 3, 4, 3);
            btnSiegeLaunch.Name = "btnSiegeLaunch";
            btnSiegeLaunch.Size = new System.Drawing.Size(144, 69);
            btnSiegeLaunch.TabIndex = 0;
            btnSiegeLaunch.Text = "Launch Match";
            btnSiegeLaunch.UseVisualStyleBackColor = false;
            btnSiegeLaunch.Click += btnSiegeLaunch_Click;
            // 
            // maskedTextBoxSiegeHostGamePlayer2Loadout
            // 
            maskedTextBoxSiegeHostGamePlayer2Loadout.Location = new System.Drawing.Point(84, 133);
            maskedTextBoxSiegeHostGamePlayer2Loadout.Margin = new Padding(4, 3, 4, 3);
            maskedTextBoxSiegeHostGamePlayer2Loadout.Name = "maskedTextBoxSiegeHostGamePlayer2Loadout";
            maskedTextBoxSiegeHostGamePlayer2Loadout.Size = new System.Drawing.Size(288, 23);
            maskedTextBoxSiegeHostGamePlayer2Loadout.TabIndex = 77;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(28, 135);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(48, 15);
            label12.TabIndex = 80;
            label12.Text = "Player 2";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(28, 212);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(48, 15);
            label13.TabIndex = 83;
            label13.Text = "Player 5";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(28, 187);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(48, 15);
            label14.TabIndex = 81;
            label14.Text = "Player 4";
            // 
            // maskedTextBoxSiegeHostGamePlayer5Loadout
            // 
            maskedTextBoxSiegeHostGamePlayer5Loadout.Location = new System.Drawing.Point(84, 209);
            maskedTextBoxSiegeHostGamePlayer5Loadout.Margin = new Padding(4, 3, 4, 3);
            maskedTextBoxSiegeHostGamePlayer5Loadout.Name = "maskedTextBoxSiegeHostGamePlayer5Loadout";
            maskedTextBoxSiegeHostGamePlayer5Loadout.Size = new System.Drawing.Size(288, 23);
            maskedTextBoxSiegeHostGamePlayer5Loadout.TabIndex = 78;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new System.Drawing.Point(14, 111);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(63, 15);
            label15.TabIndex = 79;
            label15.Text = "Host (You)";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new System.Drawing.Point(28, 162);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(48, 15);
            label16.TabIndex = 82;
            label16.Text = "Player 3";
            // 
            // siegeGameSettingsGroupBox
            // 
            siegeGameSettingsGroupBox.BackColor = System.Drawing.SystemColors.Control;
            siegeGameSettingsGroupBox.Controls.Add(comBoxSiegeLanguage);
            siegeGameSettingsGroupBox.Controls.Add(labelSiegeLanguage);
            siegeGameSettingsGroupBox.Location = new System.Drawing.Point(4, 3);
            siegeGameSettingsGroupBox.Margin = new Padding(4, 3, 4, 3);
            siegeGameSettingsGroupBox.Name = "siegeGameSettingsGroupBox";
            siegeGameSettingsGroupBox.Padding = new Padding(4, 3, 4, 3);
            siegeGameSettingsGroupBox.Size = new System.Drawing.Size(399, 59);
            siegeGameSettingsGroupBox.TabIndex = 89;
            siegeGameSettingsGroupBox.TabStop = false;
            siegeGameSettingsGroupBox.Text = "Game Settings";
            // 
            // comBoxSiegeLanguage
            // 
            comBoxSiegeLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxSiegeLanguage.FormattingEnabled = true;
            comBoxSiegeLanguage.Location = new System.Drawing.Point(88, 23);
            comBoxSiegeLanguage.Margin = new Padding(4, 3, 4, 3);
            comBoxSiegeLanguage.Name = "comBoxSiegeLanguage";
            comBoxSiegeLanguage.Size = new System.Drawing.Size(92, 23);
            comBoxSiegeLanguage.TabIndex = 11;
            comBoxSiegeLanguage.SelectedIndexChanged += comBoxSiegeLanguage_SelectedIndexChanged;
            // 
            // labelSiegeLanguage
            // 
            labelSiegeLanguage.AutoSize = true;
            labelSiegeLanguage.Location = new System.Drawing.Point(16, 27);
            labelSiegeLanguage.Margin = new Padding(4, 0, 4, 0);
            labelSiegeLanguage.Name = "labelSiegeLanguage";
            labelSiegeLanguage.Size = new System.Drawing.Size(59, 15);
            labelSiegeLanguage.TabIndex = 10;
            labelSiegeLanguage.Text = "Language";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tableLayoutPanel1.Controls.Add(loadoutEditorTabControl, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Controls.Add(modsPanel, 2, 0);
            tableLayoutPanel1.Location = new System.Drawing.Point(7, 2);
            tableLayoutPanel1.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new System.Drawing.Size(1519, 687);
            tableLayoutPanel1.TabIndex = 94;
            // 
            // loadoutEditorTabControl
            // 
            loadoutEditorTabControl.Controls.Add(loadoutEditorSurvivalTab);
            loadoutEditorTabControl.Controls.Add(loadoutEditorSiegeTab);
            loadoutEditorTabControl.ItemSize = new System.Drawing.Size(287, 20);
            loadoutEditorTabControl.Location = new System.Drawing.Point(4, 3);
            loadoutEditorTabControl.Margin = new Padding(4, 3, 4, 3);
            loadoutEditorTabControl.Name = "loadoutEditorTabControl";
            loadoutEditorTabControl.SelectedIndex = 0;
            loadoutEditorTabControl.Size = new System.Drawing.Size(674, 681);
            loadoutEditorTabControl.SizeMode = TabSizeMode.Fixed;
            loadoutEditorTabControl.TabIndex = 23;
            // 
            // loadoutEditorSurvivalTab
            // 
            loadoutEditorSurvivalTab.BackColor = System.Drawing.SystemColors.Control;
            loadoutEditorSurvivalTab.Controls.Add(groupBoxLoadout);
            loadoutEditorSurvivalTab.Location = new System.Drawing.Point(4, 24);
            loadoutEditorSurvivalTab.Margin = new Padding(4, 3, 4, 3);
            loadoutEditorSurvivalTab.Name = "loadoutEditorSurvivalTab";
            loadoutEditorSurvivalTab.Padding = new Padding(4, 3, 4, 3);
            loadoutEditorSurvivalTab.Size = new System.Drawing.Size(666, 653);
            loadoutEditorSurvivalTab.TabIndex = 0;
            loadoutEditorSurvivalTab.Text = "Survival";
            // 
            // loadoutEditorSiegeTab
            // 
            loadoutEditorSiegeTab.BackColor = System.Drawing.SystemColors.Control;
            loadoutEditorSiegeTab.Controls.Add(siegeLoadoutEditorGroupBox);
            loadoutEditorSiegeTab.Location = new System.Drawing.Point(4, 24);
            loadoutEditorSiegeTab.Margin = new Padding(4, 3, 4, 3);
            loadoutEditorSiegeTab.Name = "loadoutEditorSiegeTab";
            loadoutEditorSiegeTab.Padding = new Padding(4, 3, 4, 3);
            loadoutEditorSiegeTab.Size = new System.Drawing.Size(666, 653);
            loadoutEditorSiegeTab.TabIndex = 1;
            loadoutEditorSiegeTab.Text = "Siege";
            // 
            // siegeLoadoutEditorGroupBox
            // 
            siegeLoadoutEditorGroupBox.AutoSize = true;
            siegeLoadoutEditorGroupBox.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            siegeLoadoutEditorGroupBox.BackColor = System.Drawing.SystemColors.Control;
            siegeLoadoutEditorGroupBox.Controls.Add(comBoxRole);
            siegeLoadoutEditorGroupBox.Controls.Add(roleLabel);
            siegeLoadoutEditorGroupBox.Controls.Add(comBoxSiegeBossWaveSlot2);
            siegeLoadoutEditorGroupBox.Controls.Add(label45);
            siegeLoadoutEditorGroupBox.Controls.Add(comBoxSiegeBossWaveSlot1);
            siegeLoadoutEditorGroupBox.Controls.Add(comBoxSiegeLv4WaveSlot2);
            siegeLoadoutEditorGroupBox.Controls.Add(label36);
            siegeLoadoutEditorGroupBox.Controls.Add(comBoxSiegeLv4WaveSlot1);
            siegeLoadoutEditorGroupBox.Controls.Add(comBoxSiegeLv3WaveSlot2);
            siegeLoadoutEditorGroupBox.Controls.Add(label34);
            siegeLoadoutEditorGroupBox.Controls.Add(comBoxSiegeLv3WaveSlot1);
            siegeLoadoutEditorGroupBox.Controls.Add(comBoxSiegeLv2WaveSlot2);
            siegeLoadoutEditorGroupBox.Controls.Add(label31);
            siegeLoadoutEditorGroupBox.Controls.Add(comBoxSiegeLv2WaveSlot1);
            siegeLoadoutEditorGroupBox.Controls.Add(comBoxSiegeLv1WaveSlot2);
            siegeLoadoutEditorGroupBox.Controls.Add(label30);
            siegeLoadoutEditorGroupBox.Controls.Add(comBoxSiegeLv1WaveSlot1);
            siegeLoadoutEditorGroupBox.Controls.Add(btnDeleteSiegeLoadout);
            siegeLoadoutEditorGroupBox.Controls.Add(label22);
            siegeLoadoutEditorGroupBox.Controls.Add(maskedTextBoxSiegePlayerName);
            siegeLoadoutEditorGroupBox.Controls.Add(label23);
            siegeLoadoutEditorGroupBox.Controls.Add(btnSaveSiegeLoadout);
            siegeLoadoutEditorGroupBox.Controls.Add(maskedTextBoxSiegeLoadoutName);
            siegeLoadoutEditorGroupBox.Controls.Add(btnCopySiegeLoadoutToClipboard);
            siegeLoadoutEditorGroupBox.Controls.Add(btnImportSiegeLoadout);
            siegeLoadoutEditorGroupBox.Controls.Add(label24);
            siegeLoadoutEditorGroupBox.Controls.Add(textBoxExportSiegeLoadout);
            siegeLoadoutEditorGroupBox.Controls.Add(maskedTextBoxImportSiegeLoadout);
            siegeLoadoutEditorGroupBox.Controls.Add(label25);
            siegeLoadoutEditorGroupBox.Controls.Add(comboxSiegeTraitYellowSlot);
            siegeLoadoutEditorGroupBox.Controls.Add(label26);
            siegeLoadoutEditorGroupBox.Controls.Add(comboxSiegeTraitNoBonusSlot);
            siegeLoadoutEditorGroupBox.Controls.Add(label27);
            siegeLoadoutEditorGroupBox.Controls.Add(comboxSiegeTraitGreenSlot);
            siegeLoadoutEditorGroupBox.Controls.Add(label28);
            siegeLoadoutEditorGroupBox.Controls.Add(comboxSiegeTraitBlueSlot);
            siegeLoadoutEditorGroupBox.Controls.Add(comBoxSiegeDye);
            siegeLoadoutEditorGroupBox.Controls.Add(label29);
            siegeLoadoutEditorGroupBox.Controls.Add(comBoxSiegeHero);
            siegeLoadoutEditorGroupBox.Controls.Add(comBoxSiegeSkin);
            siegeLoadoutEditorGroupBox.Controls.Add(label32);
            siegeLoadoutEditorGroupBox.Controls.Add(label33);
            siegeLoadoutEditorGroupBox.Controls.Add(comBoxSiegeLoadouts);
            siegeLoadoutEditorGroupBox.Controls.Add(label35);
            siegeLoadoutEditorGroupBox.Controls.Add(label37);
            siegeLoadoutEditorGroupBox.Controls.Add(label38);
            siegeLoadoutEditorGroupBox.Controls.Add(label39);
            siegeLoadoutEditorGroupBox.Controls.Add(label40);
            siegeLoadoutEditorGroupBox.Controls.Add(label41);
            siegeLoadoutEditorGroupBox.Controls.Add(label42);
            siegeLoadoutEditorGroupBox.Controls.Add(label43);
            siegeLoadoutEditorGroupBox.Controls.Add(label44);
            siegeLoadoutEditorGroupBox.Controls.Add(comBoxSiegeLoadoutSlot1);
            siegeLoadoutEditorGroupBox.Controls.Add(comBoxSiegeLoadoutSlot2);
            siegeLoadoutEditorGroupBox.Controls.Add(comBoxSiegeLoadoutSlot3);
            siegeLoadoutEditorGroupBox.Controls.Add(comBoxSiegeLoadoutSlot9);
            siegeLoadoutEditorGroupBox.Controls.Add(comBoxSiegeLoadoutSlot4);
            siegeLoadoutEditorGroupBox.Controls.Add(comBoxSiegeLoadoutSlot8);
            siegeLoadoutEditorGroupBox.Controls.Add(comBoxSiegeLoadoutSlot5);
            siegeLoadoutEditorGroupBox.Controls.Add(comBoxSiegeLoadoutSlot7);
            siegeLoadoutEditorGroupBox.Controls.Add(comBoxSiegeLoadoutSlot6);
            siegeLoadoutEditorGroupBox.Location = new System.Drawing.Point(0, 2);
            siegeLoadoutEditorGroupBox.Margin = new Padding(4, 3, 4, 3);
            siegeLoadoutEditorGroupBox.Name = "siegeLoadoutEditorGroupBox";
            siegeLoadoutEditorGroupBox.Padding = new Padding(4, 3, 4, 3);
            siegeLoadoutEditorGroupBox.Size = new System.Drawing.Size(664, 553);
            siegeLoadoutEditorGroupBox.TabIndex = 25;
            siegeLoadoutEditorGroupBox.TabStop = false;
            siegeLoadoutEditorGroupBox.Text = "Loadout Editor";
            // 
            // comBoxRole
            // 
            comBoxRole.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxRole.FormattingEnabled = true;
            comBoxRole.Location = new System.Drawing.Point(49, 414);
            comBoxRole.Margin = new Padding(4, 3, 4, 3);
            comBoxRole.Name = "comBoxRole";
            comBoxRole.Size = new System.Drawing.Size(188, 23);
            comBoxRole.TabIndex = 89;
            comBoxRole.SelectedIndexChanged += comBoxRole_SelectedIndexChanged;
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Location = new System.Drawing.Point(9, 418);
            roleLabel.Margin = new Padding(4, 0, 4, 0);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new System.Drawing.Size(30, 15);
            roleLabel.TabIndex = 88;
            roleLabel.Text = "Role";
            // 
            // comBoxSiegeBossWaveSlot2
            // 
            comBoxSiegeBossWaveSlot2.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxSiegeBossWaveSlot2.FormattingEnabled = true;
            comBoxSiegeBossWaveSlot2.Location = new System.Drawing.Point(504, 390);
            comBoxSiegeBossWaveSlot2.Margin = new Padding(4, 3, 4, 3);
            comBoxSiegeBossWaveSlot2.Name = "comBoxSiegeBossWaveSlot2";
            comBoxSiegeBossWaveSlot2.Size = new System.Drawing.Size(151, 23);
            comBoxSiegeBossWaveSlot2.TabIndex = 87;
            comBoxSiegeBossWaveSlot2.SelectedIndexChanged += comBoxSiegeBossWaveSlot2_SelectedIndexChanged;
            // 
            // label45
            // 
            label45.AutoSize = true;
            label45.Location = new System.Drawing.Point(264, 395);
            label45.Margin = new Padding(4, 0, 4, 0);
            label45.Name = "label45";
            label45.Size = new System.Drawing.Size(68, 15);
            label45.TabIndex = 86;
            label45.Text = "Boss Waves";
            // 
            // comBoxSiegeBossWaveSlot1
            // 
            comBoxSiegeBossWaveSlot1.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxSiegeBossWaveSlot1.FormattingEnabled = true;
            comBoxSiegeBossWaveSlot1.Location = new System.Drawing.Point(344, 390);
            comBoxSiegeBossWaveSlot1.Margin = new Padding(4, 3, 4, 3);
            comBoxSiegeBossWaveSlot1.Name = "comBoxSiegeBossWaveSlot1";
            comBoxSiegeBossWaveSlot1.Size = new System.Drawing.Size(151, 23);
            comBoxSiegeBossWaveSlot1.TabIndex = 85;
            comBoxSiegeBossWaveSlot1.SelectedIndexChanged += comBoxSiegeBossWaveSlot1_SelectedIndexChanged;
            // 
            // comBoxSiegeLv4WaveSlot2
            // 
            comBoxSiegeLv4WaveSlot2.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxSiegeLv4WaveSlot2.FormattingEnabled = true;
            comBoxSiegeLv4WaveSlot2.Location = new System.Drawing.Point(504, 353);
            comBoxSiegeLv4WaveSlot2.Margin = new Padding(4, 3, 4, 3);
            comBoxSiegeLv4WaveSlot2.Name = "comBoxSiegeLv4WaveSlot2";
            comBoxSiegeLv4WaveSlot2.Size = new System.Drawing.Size(151, 23);
            comBoxSiegeLv4WaveSlot2.TabIndex = 84;
            comBoxSiegeLv4WaveSlot2.SelectedIndexChanged += comBoxSiegeLv4WaveSlot2_SelectedIndexChanged;
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Location = new System.Drawing.Point(266, 358);
            label36.Margin = new Padding(4, 0, 4, 0);
            label36.Name = "label36";
            label36.Size = new System.Drawing.Size(64, 15);
            label36.TabIndex = 83;
            label36.Text = "Lv 4 Waves";
            // 
            // comBoxSiegeLv4WaveSlot1
            // 
            comBoxSiegeLv4WaveSlot1.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxSiegeLv4WaveSlot1.FormattingEnabled = true;
            comBoxSiegeLv4WaveSlot1.Location = new System.Drawing.Point(344, 353);
            comBoxSiegeLv4WaveSlot1.Margin = new Padding(4, 3, 4, 3);
            comBoxSiegeLv4WaveSlot1.Name = "comBoxSiegeLv4WaveSlot1";
            comBoxSiegeLv4WaveSlot1.Size = new System.Drawing.Size(151, 23);
            comBoxSiegeLv4WaveSlot1.TabIndex = 82;
            comBoxSiegeLv4WaveSlot1.SelectedIndexChanged += comBoxSiegeLv4WaveSlot1_SelectedIndexChanged;
            // 
            // comBoxSiegeLv3WaveSlot2
            // 
            comBoxSiegeLv3WaveSlot2.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxSiegeLv3WaveSlot2.FormattingEnabled = true;
            comBoxSiegeLv3WaveSlot2.Location = new System.Drawing.Point(504, 322);
            comBoxSiegeLv3WaveSlot2.Margin = new Padding(4, 3, 4, 3);
            comBoxSiegeLv3WaveSlot2.Name = "comBoxSiegeLv3WaveSlot2";
            comBoxSiegeLv3WaveSlot2.Size = new System.Drawing.Size(151, 23);
            comBoxSiegeLv3WaveSlot2.TabIndex = 81;
            comBoxSiegeLv3WaveSlot2.SelectedIndexChanged += comBoxSiegeLv3WaveSlot2_SelectedIndexChanged;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Location = new System.Drawing.Point(266, 327);
            label34.Margin = new Padding(4, 0, 4, 0);
            label34.Name = "label34";
            label34.Size = new System.Drawing.Size(64, 15);
            label34.TabIndex = 80;
            label34.Text = "Lv 3 Waves";
            // 
            // comBoxSiegeLv3WaveSlot1
            // 
            comBoxSiegeLv3WaveSlot1.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxSiegeLv3WaveSlot1.FormattingEnabled = true;
            comBoxSiegeLv3WaveSlot1.Location = new System.Drawing.Point(344, 322);
            comBoxSiegeLv3WaveSlot1.Margin = new Padding(4, 3, 4, 3);
            comBoxSiegeLv3WaveSlot1.Name = "comBoxSiegeLv3WaveSlot1";
            comBoxSiegeLv3WaveSlot1.Size = new System.Drawing.Size(151, 23);
            comBoxSiegeLv3WaveSlot1.TabIndex = 79;
            comBoxSiegeLv3WaveSlot1.SelectedIndexChanged += comBoxSiegeLv3WaveSlot1_SelectedIndexChanged;
            // 
            // comBoxSiegeLv2WaveSlot2
            // 
            comBoxSiegeLv2WaveSlot2.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxSiegeLv2WaveSlot2.FormattingEnabled = true;
            comBoxSiegeLv2WaveSlot2.Location = new System.Drawing.Point(504, 291);
            comBoxSiegeLv2WaveSlot2.Margin = new Padding(4, 3, 4, 3);
            comBoxSiegeLv2WaveSlot2.Name = "comBoxSiegeLv2WaveSlot2";
            comBoxSiegeLv2WaveSlot2.Size = new System.Drawing.Size(151, 23);
            comBoxSiegeLv2WaveSlot2.TabIndex = 78;
            comBoxSiegeLv2WaveSlot2.SelectedIndexChanged += comBoxSiegeLv2WaveSlot2_SelectedIndexChanged;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new System.Drawing.Point(266, 295);
            label31.Margin = new Padding(4, 0, 4, 0);
            label31.Name = "label31";
            label31.Size = new System.Drawing.Size(64, 15);
            label31.TabIndex = 77;
            label31.Text = "Lv 2 Waves";
            // 
            // comBoxSiegeLv2WaveSlot1
            // 
            comBoxSiegeLv2WaveSlot1.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxSiegeLv2WaveSlot1.FormattingEnabled = true;
            comBoxSiegeLv2WaveSlot1.Location = new System.Drawing.Point(344, 291);
            comBoxSiegeLv2WaveSlot1.Margin = new Padding(4, 3, 4, 3);
            comBoxSiegeLv2WaveSlot1.Name = "comBoxSiegeLv2WaveSlot1";
            comBoxSiegeLv2WaveSlot1.Size = new System.Drawing.Size(151, 23);
            comBoxSiegeLv2WaveSlot1.TabIndex = 76;
            comBoxSiegeLv2WaveSlot1.SelectedIndexChanged += comBoxSiegeLv2WaveSlot1_SelectedIndexChanged;
            // 
            // comBoxSiegeLv1WaveSlot2
            // 
            comBoxSiegeLv1WaveSlot2.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxSiegeLv1WaveSlot2.FormattingEnabled = true;
            comBoxSiegeLv1WaveSlot2.Location = new System.Drawing.Point(504, 260);
            comBoxSiegeLv1WaveSlot2.Margin = new Padding(4, 3, 4, 3);
            comBoxSiegeLv1WaveSlot2.Name = "comBoxSiegeLv1WaveSlot2";
            comBoxSiegeLv1WaveSlot2.Size = new System.Drawing.Size(151, 23);
            comBoxSiegeLv1WaveSlot2.TabIndex = 75;
            comBoxSiegeLv1WaveSlot2.SelectedIndexChanged += comBoxSiegeLv1WaveSlot2_SelectedIndexChanged;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new System.Drawing.Point(266, 264);
            label30.Margin = new Padding(4, 0, 4, 0);
            label30.Name = "label30";
            label30.Size = new System.Drawing.Size(64, 15);
            label30.TabIndex = 74;
            label30.Text = "Lv 1 Waves";
            // 
            // comBoxSiegeLv1WaveSlot1
            // 
            comBoxSiegeLv1WaveSlot1.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxSiegeLv1WaveSlot1.FormattingEnabled = true;
            comBoxSiegeLv1WaveSlot1.Location = new System.Drawing.Point(344, 260);
            comBoxSiegeLv1WaveSlot1.Margin = new Padding(4, 3, 4, 3);
            comBoxSiegeLv1WaveSlot1.Name = "comBoxSiegeLv1WaveSlot1";
            comBoxSiegeLv1WaveSlot1.Size = new System.Drawing.Size(151, 23);
            comBoxSiegeLv1WaveSlot1.TabIndex = 73;
            comBoxSiegeLv1WaveSlot1.SelectedIndexChanged += comBoxSiegeLv1WaveSlot1_SelectedIndexChanged;
            // 
            // btnDeleteSiegeLoadout
            // 
            btnDeleteSiegeLoadout.BackColor = System.Drawing.Color.Tomato;
            btnDeleteSiegeLoadout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnDeleteSiegeLoadout.Location = new System.Drawing.Point(7, 505);
            btnDeleteSiegeLoadout.Margin = new Padding(4, 3, 4, 3);
            btnDeleteSiegeLoadout.Name = "btnDeleteSiegeLoadout";
            btnDeleteSiegeLoadout.Size = new System.Drawing.Size(186, 25);
            btnDeleteSiegeLoadout.TabIndex = 72;
            btnDeleteSiegeLoadout.Text = "Delete selected Loadout";
            btnDeleteSiegeLoadout.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            btnDeleteSiegeLoadout.UseVisualStyleBackColor = false;
            btnDeleteSiegeLoadout.Click += btnDeleteSiegeLoadout_Click;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new System.Drawing.Point(7, 464);
            label22.Margin = new Padding(4, 0, 4, 0);
            label22.Name = "label22";
            label22.Size = new System.Drawing.Size(74, 15);
            label22.TabIndex = 71;
            label22.Text = "Player Name";
            // 
            // maskedTextBoxSiegePlayerName
            // 
            maskedTextBoxSiegePlayerName.Location = new System.Drawing.Point(92, 460);
            maskedTextBoxSiegePlayerName.Margin = new Padding(4, 3, 4, 3);
            maskedTextBoxSiegePlayerName.Name = "maskedTextBoxSiegePlayerName";
            maskedTextBoxSiegePlayerName.Size = new System.Drawing.Size(115, 23);
            maskedTextBoxSiegePlayerName.TabIndex = 70;
            maskedTextBoxSiegePlayerName.TextChanged += maskedTextBoxSiegePlayerName_TextChanged;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new System.Drawing.Point(215, 464);
            label23.Margin = new Padding(4, 0, 4, 0);
            label23.Name = "label23";
            label23.Size = new System.Drawing.Size(86, 15);
            label23.TabIndex = 69;
            label23.Text = "Loadout Name";
            // 
            // btnSaveSiegeLoadout
            // 
            btnSaveSiegeLoadout.BackColor = System.Drawing.Color.MediumSpringGreen;
            btnSaveSiegeLoadout.Location = new System.Drawing.Point(587, 445);
            btnSaveSiegeLoadout.Margin = new Padding(4, 3, 4, 3);
            btnSaveSiegeLoadout.Name = "btnSaveSiegeLoadout";
            btnSaveSiegeLoadout.Size = new System.Drawing.Size(69, 51);
            btnSaveSiegeLoadout.TabIndex = 67;
            btnSaveSiegeLoadout.Text = "Save Loadout";
            btnSaveSiegeLoadout.UseVisualStyleBackColor = false;
            btnSaveSiegeLoadout.Click += btnSaveSiegeLoadout_Click;
            // 
            // maskedTextBoxSiegeLoadoutName
            // 
            maskedTextBoxSiegeLoadoutName.Location = new System.Drawing.Point(312, 460);
            maskedTextBoxSiegeLoadoutName.Margin = new Padding(4, 3, 4, 3);
            maskedTextBoxSiegeLoadoutName.Name = "maskedTextBoxSiegeLoadoutName";
            maskedTextBoxSiegeLoadoutName.Size = new System.Drawing.Size(268, 23);
            maskedTextBoxSiegeLoadoutName.TabIndex = 68;
            maskedTextBoxSiegeLoadoutName.TextChanged += maskedTextBoxSiegeLoadoutName_TextChanged;
            // 
            // btnCopySiegeLoadoutToClipboard
            // 
            btnCopySiegeLoadoutToClipboard.Location = new System.Drawing.Point(607, 508);
            btnCopySiegeLoadoutToClipboard.Margin = new Padding(4, 3, 4, 3);
            btnCopySiegeLoadoutToClipboard.Name = "btnCopySiegeLoadoutToClipboard";
            btnCopySiegeLoadoutToClipboard.Size = new System.Drawing.Size(49, 23);
            btnCopySiegeLoadoutToClipboard.TabIndex = 27;
            btnCopySiegeLoadoutToClipboard.Text = "Copy";
            btnCopySiegeLoadoutToClipboard.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            btnCopySiegeLoadoutToClipboard.UseVisualStyleBackColor = true;
            btnCopySiegeLoadoutToClipboard.Click += btnCopySiegeLoadoutToClipboard_Click;
            // 
            // btnImportSiegeLoadout
            // 
            btnImportSiegeLoadout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnImportSiegeLoadout.Location = new System.Drawing.Point(603, 22);
            btnImportSiegeLoadout.Margin = new Padding(4, 3, 4, 3);
            btnImportSiegeLoadout.Name = "btnImportSiegeLoadout";
            btnImportSiegeLoadout.Size = new System.Drawing.Size(52, 23);
            btnImportSiegeLoadout.TabIndex = 28;
            btnImportSiegeLoadout.Text = "Import";
            btnImportSiegeLoadout.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            btnImportSiegeLoadout.UseVisualStyleBackColor = true;
            btnImportSiegeLoadout.Click += btnImportSiegeLoadout_Click;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new System.Drawing.Point(223, 512);
            label24.Margin = new Padding(4, 0, 4, 0);
            label24.Name = "label24";
            label24.Size = new System.Drawing.Size(41, 15);
            label24.TabIndex = 66;
            label24.Text = "Export";
            // 
            // textBoxExportSiegeLoadout
            // 
            textBoxExportSiegeLoadout.Location = new System.Drawing.Point(273, 508);
            textBoxExportSiegeLoadout.Margin = new Padding(4, 3, 4, 3);
            textBoxExportSiegeLoadout.Name = "textBoxExportSiegeLoadout";
            textBoxExportSiegeLoadout.ReadOnly = true;
            textBoxExportSiegeLoadout.Size = new System.Drawing.Size(326, 23);
            textBoxExportSiegeLoadout.TabIndex = 65;
            // 
            // maskedTextBoxImportSiegeLoadout
            // 
            maskedTextBoxImportSiegeLoadout.Location = new System.Drawing.Point(366, 22);
            maskedTextBoxImportSiegeLoadout.Margin = new Padding(4, 3, 4, 3);
            maskedTextBoxImportSiegeLoadout.Name = "maskedTextBoxImportSiegeLoadout";
            maskedTextBoxImportSiegeLoadout.Size = new System.Drawing.Size(233, 23);
            maskedTextBoxImportSiegeLoadout.TabIndex = 64;
            maskedTextBoxImportSiegeLoadout.TextChanged += maskedTextBoxImportSiegeLoadout_TextChanged;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new System.Drawing.Point(324, 215);
            label25.Margin = new Padding(4, 0, 4, 0);
            label25.Name = "label25";
            label25.Size = new System.Drawing.Size(84, 15);
            label25.TabIndex = 35;
            label25.Text = "No Bonus Trait";
            // 
            // comboxSiegeTraitYellowSlot
            // 
            comboxSiegeTraitYellowSlot.DropDownStyle = ComboBoxStyle.DropDownList;
            comboxSiegeTraitYellowSlot.FormattingEnabled = true;
            comboxSiegeTraitYellowSlot.Location = new System.Drawing.Point(422, 117);
            comboxSiegeTraitYellowSlot.Margin = new Padding(4, 3, 4, 3);
            comboxSiegeTraitYellowSlot.Name = "comboxSiegeTraitYellowSlot";
            comboxSiegeTraitYellowSlot.Size = new System.Drawing.Size(233, 23);
            comboxSiegeTraitYellowSlot.TabIndex = 32;
            comboxSiegeTraitYellowSlot.SelectedIndexChanged += comboxSiegeTraitYellowSlot_SelectedIndexChanged;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.BackColor = System.Drawing.Color.Gold;
            label26.Location = new System.Drawing.Point(324, 121);
            label26.Margin = new Padding(4, 0, 4, 0);
            label26.Name = "label26";
            label26.Size = new System.Drawing.Size(73, 15);
            label26.TabIndex = 34;
            label26.Text = "Triangle Trait";
            // 
            // comboxSiegeTraitNoBonusSlot
            // 
            comboxSiegeTraitNoBonusSlot.DropDownStyle = ComboBoxStyle.DropDownList;
            comboxSiegeTraitNoBonusSlot.FormattingEnabled = true;
            comboxSiegeTraitNoBonusSlot.Location = new System.Drawing.Point(422, 210);
            comboxSiegeTraitNoBonusSlot.Margin = new Padding(4, 3, 4, 3);
            comboxSiegeTraitNoBonusSlot.Name = "comboxSiegeTraitNoBonusSlot";
            comboxSiegeTraitNoBonusSlot.Size = new System.Drawing.Size(233, 23);
            comboxSiegeTraitNoBonusSlot.TabIndex = 33;
            comboxSiegeTraitNoBonusSlot.SelectedIndexChanged += comboxSiegeTraitNoBonusSlot_SelectedIndexChanged;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.BackColor = System.Drawing.Color.LightSkyBlue;
            label27.Location = new System.Drawing.Point(324, 183);
            label27.Margin = new Padding(4, 0, 4, 0);
            label27.Name = "label27";
            label27.Size = new System.Drawing.Size(81, 15);
            label27.TabIndex = 31;
            label27.Text = "Diamond Trait";
            // 
            // comboxSiegeTraitGreenSlot
            // 
            comboxSiegeTraitGreenSlot.DropDownStyle = ComboBoxStyle.DropDownList;
            comboxSiegeTraitGreenSlot.FormattingEnabled = true;
            comboxSiegeTraitGreenSlot.Location = new System.Drawing.Point(422, 148);
            comboxSiegeTraitGreenSlot.Margin = new Padding(4, 3, 4, 3);
            comboxSiegeTraitGreenSlot.Name = "comboxSiegeTraitGreenSlot";
            comboxSiegeTraitGreenSlot.Size = new System.Drawing.Size(233, 23);
            comboxSiegeTraitGreenSlot.TabIndex = 28;
            comboxSiegeTraitGreenSlot.SelectedIndexChanged += comboxSiegeTraitGreenSlot_SelectedIndexChanged;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.BackColor = System.Drawing.Color.LightGreen;
            label28.Location = new System.Drawing.Point(324, 152);
            label28.Margin = new Padding(4, 0, 4, 0);
            label28.Name = "label28";
            label28.Size = new System.Drawing.Size(83, 15);
            label28.TabIndex = 30;
            label28.Text = "Pentagon Trait";
            // 
            // comboxSiegeTraitBlueSlot
            // 
            comboxSiegeTraitBlueSlot.DropDownStyle = ComboBoxStyle.DropDownList;
            comboxSiegeTraitBlueSlot.FormattingEnabled = true;
            comboxSiegeTraitBlueSlot.Location = new System.Drawing.Point(422, 179);
            comboxSiegeTraitBlueSlot.Margin = new Padding(4, 3, 4, 3);
            comboxSiegeTraitBlueSlot.Name = "comboxSiegeTraitBlueSlot";
            comboxSiegeTraitBlueSlot.Size = new System.Drawing.Size(233, 23);
            comboxSiegeTraitBlueSlot.TabIndex = 29;
            comboxSiegeTraitBlueSlot.SelectedIndexChanged += comboxSiegeTraitBlueSlot_SelectedIndexChanged;
            // 
            // comBoxSiegeDye
            // 
            comBoxSiegeDye.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxSiegeDye.FormattingEnabled = true;
            comBoxSiegeDye.Location = new System.Drawing.Point(526, 69);
            comBoxSiegeDye.Margin = new Padding(4, 3, 4, 3);
            comBoxSiegeDye.Name = "comBoxSiegeDye";
            comBoxSiegeDye.Size = new System.Drawing.Size(129, 23);
            comBoxSiegeDye.TabIndex = 6;
            comBoxSiegeDye.SelectedIndexChanged += comBoxSiegeDye_SelectedIndexChanged;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new System.Drawing.Point(7, 73);
            label29.Margin = new Padding(4, 0, 4, 0);
            label29.Name = "label29";
            label29.Size = new System.Drawing.Size(33, 15);
            label29.TabIndex = 1;
            label29.Text = "Hero";
            // 
            // comBoxSiegeHero
            // 
            comBoxSiegeHero.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxSiegeHero.FormattingEnabled = true;
            comBoxSiegeHero.Location = new System.Drawing.Point(49, 69);
            comBoxSiegeHero.Margin = new Padding(4, 3, 4, 3);
            comBoxSiegeHero.Name = "comBoxSiegeHero";
            comBoxSiegeHero.Size = new System.Drawing.Size(146, 23);
            comBoxSiegeHero.TabIndex = 2;
            comBoxSiegeHero.SelectedIndexChanged += comBoxSiegeHero_SelectedIndexChanged;
            // 
            // comBoxSiegeSkin
            // 
            comBoxSiegeSkin.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxSiegeSkin.FormattingEnabled = true;
            comBoxSiegeSkin.Location = new System.Drawing.Point(245, 69);
            comBoxSiegeSkin.Margin = new Padding(4, 3, 4, 3);
            comBoxSiegeSkin.Name = "comBoxSiegeSkin";
            comBoxSiegeSkin.Size = new System.Drawing.Size(221, 23);
            comBoxSiegeSkin.TabIndex = 4;
            comBoxSiegeSkin.SelectedIndexChanged += comBoxSiegeSkin_SelectedIndexChanged;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new System.Drawing.Point(489, 73);
            label32.Margin = new Padding(4, 0, 4, 0);
            label32.Name = "label32";
            label32.Size = new System.Drawing.Size(27, 15);
            label32.TabIndex = 5;
            label32.Text = "Dye";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Location = new System.Drawing.Point(205, 73);
            label33.Margin = new Padding(4, 0, 4, 0);
            label33.Name = "label33";
            label33.Size = new System.Drawing.Size(29, 15);
            label33.TabIndex = 3;
            label33.Text = "Skin";
            // 
            // comBoxSiegeLoadouts
            // 
            comBoxSiegeLoadouts.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxSiegeLoadouts.FormattingEnabled = true;
            comBoxSiegeLoadouts.Location = new System.Drawing.Point(10, 22);
            comBoxSiegeLoadouts.Margin = new Padding(4, 3, 4, 3);
            comBoxSiegeLoadouts.Name = "comBoxSiegeLoadouts";
            comBoxSiegeLoadouts.Size = new System.Drawing.Size(293, 23);
            comBoxSiegeLoadouts.TabIndex = 23;
            comBoxSiegeLoadouts.SelectedIndexChanged += comBoxSiegeLoadouts_SelectedIndexChanged;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Location = new System.Drawing.Point(6, 369);
            label35.Margin = new Padding(4, 0, 4, 0);
            label35.Name = "label35";
            label35.Size = new System.Drawing.Size(36, 15);
            label35.TabIndex = 17;
            label35.Text = "Slot 9";
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Location = new System.Drawing.Point(6, 338);
            label37.Margin = new Padding(4, 0, 4, 0);
            label37.Name = "label37";
            label37.Size = new System.Drawing.Size(36, 15);
            label37.TabIndex = 16;
            label37.Text = "Slot 8";
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Location = new System.Drawing.Point(6, 307);
            label38.Margin = new Padding(4, 0, 4, 0);
            label38.Name = "label38";
            label38.Size = new System.Drawing.Size(36, 15);
            label38.TabIndex = 15;
            label38.Text = "Slot 7";
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Location = new System.Drawing.Point(6, 276);
            label39.Margin = new Padding(4, 0, 4, 0);
            label39.Name = "label39";
            label39.Size = new System.Drawing.Size(36, 15);
            label39.TabIndex = 14;
            label39.Text = "Slot 6";
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Location = new System.Drawing.Point(6, 245);
            label40.Margin = new Padding(4, 0, 4, 0);
            label40.Name = "label40";
            label40.Size = new System.Drawing.Size(36, 15);
            label40.TabIndex = 13;
            label40.Text = "Slot 5";
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.Location = new System.Drawing.Point(6, 213);
            label41.Margin = new Padding(4, 0, 4, 0);
            label41.Name = "label41";
            label41.Size = new System.Drawing.Size(36, 15);
            label41.TabIndex = 12;
            label41.Text = "Slot 4";
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.Location = new System.Drawing.Point(6, 182);
            label42.Margin = new Padding(4, 0, 4, 0);
            label42.Name = "label42";
            label42.Size = new System.Drawing.Size(36, 15);
            label42.TabIndex = 11;
            label42.Text = "Slot 3";
            // 
            // label43
            // 
            label43.AutoSize = true;
            label43.Location = new System.Drawing.Point(6, 151);
            label43.Margin = new Padding(4, 0, 4, 0);
            label43.Name = "label43";
            label43.Size = new System.Drawing.Size(36, 15);
            label43.TabIndex = 10;
            label43.Text = "Slot 2";
            // 
            // label44
            // 
            label44.AutoSize = true;
            label44.Location = new System.Drawing.Point(6, 120);
            label44.Margin = new Padding(4, 0, 4, 0);
            label44.Name = "label44";
            label44.Size = new System.Drawing.Size(36, 15);
            label44.TabIndex = 9;
            label44.Text = "Slot 1";
            // 
            // comBoxSiegeLoadoutSlot1
            // 
            comBoxSiegeLoadoutSlot1.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxSiegeLoadoutSlot1.FormattingEnabled = true;
            comBoxSiegeLoadoutSlot1.Location = new System.Drawing.Point(52, 117);
            comBoxSiegeLoadoutSlot1.Margin = new Padding(4, 3, 4, 3);
            comBoxSiegeLoadoutSlot1.Name = "comBoxSiegeLoadoutSlot1";
            comBoxSiegeLoadoutSlot1.Size = new System.Drawing.Size(185, 23);
            comBoxSiegeLoadoutSlot1.TabIndex = 0;
            comBoxSiegeLoadoutSlot1.SelectedIndexChanged += comBoxSiegeLoadoutSlot1_SelectedIndexChanged;
            // 
            // comBoxSiegeLoadoutSlot2
            // 
            comBoxSiegeLoadoutSlot2.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxSiegeLoadoutSlot2.FormattingEnabled = true;
            comBoxSiegeLoadoutSlot2.Location = new System.Drawing.Point(52, 148);
            comBoxSiegeLoadoutSlot2.Margin = new Padding(4, 3, 4, 3);
            comBoxSiegeLoadoutSlot2.Name = "comBoxSiegeLoadoutSlot2";
            comBoxSiegeLoadoutSlot2.Size = new System.Drawing.Size(185, 23);
            comBoxSiegeLoadoutSlot2.TabIndex = 1;
            comBoxSiegeLoadoutSlot2.SelectedIndexChanged += comBoxSiegeLoadoutSlot2_SelectedIndexChanged;
            // 
            // comBoxSiegeLoadoutSlot3
            // 
            comBoxSiegeLoadoutSlot3.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxSiegeLoadoutSlot3.FormattingEnabled = true;
            comBoxSiegeLoadoutSlot3.Location = new System.Drawing.Point(52, 179);
            comBoxSiegeLoadoutSlot3.Margin = new Padding(4, 3, 4, 3);
            comBoxSiegeLoadoutSlot3.Name = "comBoxSiegeLoadoutSlot3";
            comBoxSiegeLoadoutSlot3.Size = new System.Drawing.Size(185, 23);
            comBoxSiegeLoadoutSlot3.TabIndex = 2;
            comBoxSiegeLoadoutSlot3.SelectedIndexChanged += comBoxSiegeLoadoutSlot3_SelectedIndexChanged;
            // 
            // comBoxSiegeLoadoutSlot9
            // 
            comBoxSiegeLoadoutSlot9.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxSiegeLoadoutSlot9.FormattingEnabled = true;
            comBoxSiegeLoadoutSlot9.Location = new System.Drawing.Point(52, 366);
            comBoxSiegeLoadoutSlot9.Margin = new Padding(4, 3, 4, 3);
            comBoxSiegeLoadoutSlot9.Name = "comBoxSiegeLoadoutSlot9";
            comBoxSiegeLoadoutSlot9.Size = new System.Drawing.Size(185, 23);
            comBoxSiegeLoadoutSlot9.TabIndex = 8;
            comBoxSiegeLoadoutSlot9.SelectedIndexChanged += comBoxSiegeLoadoutSlot9_SelectedIndexChanged;
            // 
            // comBoxSiegeLoadoutSlot4
            // 
            comBoxSiegeLoadoutSlot4.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxSiegeLoadoutSlot4.FormattingEnabled = true;
            comBoxSiegeLoadoutSlot4.Location = new System.Drawing.Point(52, 210);
            comBoxSiegeLoadoutSlot4.Margin = new Padding(4, 3, 4, 3);
            comBoxSiegeLoadoutSlot4.Name = "comBoxSiegeLoadoutSlot4";
            comBoxSiegeLoadoutSlot4.Size = new System.Drawing.Size(185, 23);
            comBoxSiegeLoadoutSlot4.TabIndex = 3;
            comBoxSiegeLoadoutSlot4.SelectedIndexChanged += comBoxSiegeLoadoutSlot4_SelectedIndexChanged;
            // 
            // comBoxSiegeLoadoutSlot8
            // 
            comBoxSiegeLoadoutSlot8.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxSiegeLoadoutSlot8.FormattingEnabled = true;
            comBoxSiegeLoadoutSlot8.Location = new System.Drawing.Point(52, 335);
            comBoxSiegeLoadoutSlot8.Margin = new Padding(4, 3, 4, 3);
            comBoxSiegeLoadoutSlot8.Name = "comBoxSiegeLoadoutSlot8";
            comBoxSiegeLoadoutSlot8.Size = new System.Drawing.Size(185, 23);
            comBoxSiegeLoadoutSlot8.TabIndex = 7;
            comBoxSiegeLoadoutSlot8.SelectedIndexChanged += comBoxSiegeLoadoutSlot8_SelectedIndexChanged;
            // 
            // comBoxSiegeLoadoutSlot5
            // 
            comBoxSiegeLoadoutSlot5.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxSiegeLoadoutSlot5.FormattingEnabled = true;
            comBoxSiegeLoadoutSlot5.Location = new System.Drawing.Point(52, 241);
            comBoxSiegeLoadoutSlot5.Margin = new Padding(4, 3, 4, 3);
            comBoxSiegeLoadoutSlot5.Name = "comBoxSiegeLoadoutSlot5";
            comBoxSiegeLoadoutSlot5.Size = new System.Drawing.Size(185, 23);
            comBoxSiegeLoadoutSlot5.TabIndex = 4;
            comBoxSiegeLoadoutSlot5.SelectedIndexChanged += comBoxSiegeLoadoutSlot5_SelectedIndexChanged;
            // 
            // comBoxSiegeLoadoutSlot7
            // 
            comBoxSiegeLoadoutSlot7.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxSiegeLoadoutSlot7.FormattingEnabled = true;
            comBoxSiegeLoadoutSlot7.Location = new System.Drawing.Point(52, 303);
            comBoxSiegeLoadoutSlot7.Margin = new Padding(4, 3, 4, 3);
            comBoxSiegeLoadoutSlot7.Name = "comBoxSiegeLoadoutSlot7";
            comBoxSiegeLoadoutSlot7.Size = new System.Drawing.Size(185, 23);
            comBoxSiegeLoadoutSlot7.TabIndex = 6;
            comBoxSiegeLoadoutSlot7.SelectedIndexChanged += comBoxSiegeLoadoutSlot7_SelectedIndexChanged;
            // 
            // comBoxSiegeLoadoutSlot6
            // 
            comBoxSiegeLoadoutSlot6.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxSiegeLoadoutSlot6.FormattingEnabled = true;
            comBoxSiegeLoadoutSlot6.Location = new System.Drawing.Point(52, 272);
            comBoxSiegeLoadoutSlot6.Margin = new Padding(4, 3, 4, 3);
            comBoxSiegeLoadoutSlot6.Name = "comBoxSiegeLoadoutSlot6";
            comBoxSiegeLoadoutSlot6.Size = new System.Drawing.Size(185, 23);
            comBoxSiegeLoadoutSlot6.TabIndex = 5;
            comBoxSiegeLoadoutSlot6.SelectedIndexChanged += comBoxSiegeLoadoutSlot6_SelectedIndexChanged;
            // 
            // labelOverrideLevels
            // 
            labelOverrideLevels.AutoSize = true;
            labelOverrideLevels.BackColor = System.Drawing.Color.Thistle;
            labelOverrideLevels.Font = new System.Drawing.Font("Segoe UI", 7F);
            labelOverrideLevels.Location = new System.Drawing.Point(265, 276);
            labelOverrideLevels.Name = "labelOverrideLevels";
            labelOverrideLevels.Size = new System.Drawing.Size(130, 48);
            labelOverrideLevels.TabIndex = 80;
            labelOverrideLevels.Text = "Account Level and Trap Tiers\r\nare auto adjusted to match \r\nthe enemy and map level. \r\nBut can be overriden here.\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Pink;
            label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            label3.Location = new System.Drawing.Point(31, 19);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(319, 30);
            label3.TabIndex = 81;
            label3.Text = "Disclaimer: Using mods can lead to unexpected outcomes. \r\n                     Some of the mods won't work in multiplayer.";
            // 
            // LauncherMainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new System.Drawing.Size(1538, 700);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panelLoadoutEditor);
            Margin = new Padding(4, 3, 4, 3);
            Name = "LauncherMainForm";
            Text = "Project Rechained Launcher";
            Load += Form1_Load;
            battlegroundGroupBox.ResumeLayout(false);
            battlegroundGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)startingCoinInput).EndInit();
            modsGroupBox.ResumeLayout(false);
            modsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)inputOverrideTrapTier).EndInit();
            ((System.ComponentModel.ISupportInitialize)inputOverrideAccountLevel).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            survivalGameTabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            modsPanel.ResumeLayout(false);
            gameSettingsGroupBox.ResumeLayout(false);
            gameSettingsGroupBox.PerformLayout();
            groupBoxLoadout.ResumeLayout(false);
            groupBoxLoadout.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            gameModeTabControl.ResumeLayout(false);
            gameModeSurvivalTab.ResumeLayout(false);
            gameModeSiegeTab.ResumeLayout(false);
            siegeGameTabControl.ResumeLayout(false);
            tabPage7.ResumeLayout(false);
            tabPage7.PerformLayout();
            tabPage8.ResumeLayout(false);
            tabPage8.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            siegeGameSettingsGroupBox.ResumeLayout(false);
            siegeGameSettingsGroupBox.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            loadoutEditorTabControl.ResumeLayout(false);
            loadoutEditorSurvivalTab.ResumeLayout(false);
            loadoutEditorSurvivalTab.PerformLayout();
            loadoutEditorSiegeTab.ResumeLayout(false);
            loadoutEditorSiegeTab.PerformLayout();
            siegeLoadoutEditorGroupBox.ResumeLayout(false);
            siegeLoadoutEditorGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.ComboBox comBoxBattleground;
        private System.Windows.Forms.Label labelMap;
        private System.Windows.Forms.CheckBox chkDebug;
        private System.Windows.Forms.GroupBox battlegroundGroupBox;
        private System.Windows.Forms.ComboBox comBoxDifficulty;
        private System.Windows.Forms.Label labelDifficulty;
        private System.Windows.Forms.ComboBox comBoxGameMode;
        private System.Windows.Forms.Label labelGameMode;
        private System.Windows.Forms.ComboBox comBoxExtraDifficulty;
        private System.Windows.Forms.Label labelExtraDifficulty;

        private System.Windows.Forms.Button btnResetConfig;

        private System.Windows.Forms.CheckBox chkShowTrapDamageFlyoffs;
        private System.Windows.Forms.CheckBox chkInvincibleBarricades;
        private System.Windows.Forms.CheckBox chkNoTrapGrid;
        private System.Windows.Forms.CheckBox chkTrapsAnySurface;
        private System.Windows.Forms.CheckBox chkHardcore;
        private System.Windows.Forms.CheckBox chkNoLimitUniqueTraps;
        private System.Windows.Forms.NumericUpDown startingCoinInput;
        private System.Windows.Forms.CheckBox chkTrapsInTraps;
        private System.Windows.Forms.CheckBox chkNoTrapCap;
        private System.Windows.Forms.CheckBox chkGodMode;
        private System.Windows.Forms.GroupBox modsGroupBox;
        private System.Windows.Forms.CheckBox chk_modsEnabled;
        private System.Windows.Forms.CheckBox chkCustomStartCoin;
        private System.Windows.Forms.CheckBox chkSellTrapsAnytime;
        private System.Windows.Forms.CheckBox chkRunAs32;
        private System.Windows.Forms.CheckBox chkEnhancedTrapRotation;
        private System.Windows.Forms.ComboBox comBoxLanguage;
        private System.Windows.Forms.Label labelLanguage;
        private ErrorProvider errorProvider;
        private Label label1;
        private Button btnDiscord;
        private Button btnJoinGame;
        private Label labelJoinGameHostIP;
        private MaskedTextBox maskedTextBoxJoinGameHostIP;
        private Label labelHostGamePlayer5;
        private Label labelHostGamePlayer3;
        private Label labelHostGamePlayer4;
        private Label labelHostGamePlayer2;
        private Label labelHostGamePlayer1;
        private MaskedTextBox maskedTextBoxHostGamePlayer5Loadout;
        private MaskedTextBox maskedTextBoxHostGamePlayer2Loadout;
        private MaskedTextBox maskedTextBoxHostGamePlayer3Loadout;
        private MaskedTextBox maskedTextBoxHostGamePlayer4Loadout;
        private MaskedTextBox maskedTextBoxHostGamePlayer1Loadout;
        private MaskedTextBox maskedTextBoxJoinGameLoadout;
        private Label labelJoinGameLoadout;
        private TabControl survivalGameTabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label labelJoinGameAdditionalInfo;
        private Label labelHostGameAdditionalInfo;
        private Label labelHostGameBriefInstructions;
        private Label labelJoinGameBriefInstructions;
        private LinkLabel linkLabelJoinGameKnownIssues;
        private ToolTip toolTip1;
        private Panel modsPanel;
        private GroupBox gameSettingsGroupBox;
        private Panel panelLoadoutEditor;
        private GroupBox groupBoxLoadout;
        private Button btnDeleteLoadout;
        private Label labelPlayerName;
        private MaskedTextBox maskedTextBoxPlayerName;
        private Label labelLoadoutName;
        private MaskedTextBox maskedTextBoxLoadoutName;
        private Button btnCopyLoadoutToClipboard;
        private Button btnImportLoadout;
        private Label labelExportLoadout;
        private TextBox textBoxExportLoadout;
        private MaskedTextBox maskedTextBoxImportLoadout;
        private ComboBox comBoxTrapPartsSlot9Part3;
        private ComboBox comBoxTrapPartsSlot9Part2;
        private ComboBox comBoxTrapPartsSlot9Part1;
        private ComboBox comBoxTrapPartsSlot8Part3;
        private ComboBox comBoxTrapPartsSlot8Part2;
        private ComboBox comBoxTrapPartsSlot8Part1;
        private ComboBox comBoxTrapPartsSlot7Part3;
        private ComboBox comBoxTrapPartsSlot7Part2;
        private ComboBox comBoxTrapPartsSlot7Part1;
        private ComboBox comBoxTrapPartsSlot6Part3;
        private ComboBox comBoxTrapPartsSlot6Part2;
        private ComboBox comBoxTrapPartsSlot6Part1;
        private ComboBox comBoxTrapPartsSlot5Part3;
        private ComboBox comBoxTrapPartsSlot5Part2;
        private ComboBox comBoxTrapPartsSlot5Part1;
        private ComboBox comBoxTrapPartsSlot4Part3;
        private ComboBox comBoxTrapPartsSlot4Part2;
        private ComboBox comBoxTrapPartsSlot4Part1;
        private ComboBox comBoxTrapPartsSlot3Part3;
        private ComboBox comBoxTrapPartsSlot3Part2;
        private ComboBox comBoxTrapPartsSlot3Part1;
        private ComboBox comBoxTrapPartsSlot2Part3;
        private ComboBox comBoxTrapPartsSlot2Part2;
        private ComboBox comBoxTrapPartsSlot2Part1;
        private ComboBox comBoxTrapPartsSlot1Part3;
        private ComboBox comBoxTrapPartsSlot1Part2;
        private ComboBox comBoxTrapPartsSlot1Part1;
        private Label labelTraitNoBonusSlot;
        private ComboBox comboxTraitYellowSlot;
        private Label labelTraitYellowSlot;
        private ComboBox comboxTraitNoBonusSlot;
        private Label labelTraitBlueSlot;
        private ComboBox comboxTraitGreenSlot;
        private Label labelTraitGreenSlot;
        private ComboBox comboxTraitBlueSlot;
        private ComboBox comBoxDye;
        private Label labelHero;
        private Label labelConsumableSlot2;
        private ComboBox comBoxHero;
        private ComboBox comBoxConsumableSlot1;
        private ComboBox comBoxSkin;
        private Label labelConsumableSlot1;
        private Label labelDye;
        private ComboBox comBoxConsumableSlot2;
        private Label labelSkin;
        private Label labelGuardianSlot2;
        private ComboBox comBoxLoadouts;
        private Label labelLoadoutSlot9;
        private ComboBox comBoxGuardianSlot1;
        private Label labelGuardianSlot1;
        private Label labelLoadoutSlot8;
        private ComboBox comBoxGuardianSlot2;
        private Label labelLoadoutSlot7;
        private Label labelLoadoutSlot6;
        private Label labelLoadoutSlot5;
        private Label labelLoadoutSlot4;
        private Label labelLoadoutSlot3;
        private Label labelLoadoutSlot2;
        private Label labelLoadoutSlot1;
        private ComboBox comBoxLoadoutSlot1;
        private ComboBox comBoxLoadoutSlot2;
        private ComboBox comBoxLoadoutSlot3;
        private ComboBox comBoxLoadoutSlot9;
        private ComboBox comBoxLoadoutSlot4;
        private ComboBox comBoxLoadoutSlot8;
        private ComboBox comBoxLoadoutSlot5;
        private ComboBox comBoxLoadoutSlot7;
        private ComboBox comBoxLoadoutSlot6;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private CheckBox chkAdditionalHeroWeapon;
        private ComboBox comBoxAdditionalHeroWeapon;
        private TabControl gameModeTabControl;
        private TabPage gameModeSurvivalTab;
        private TabPage gameModeSiegeTab;
        private TabControl loadoutEditorTabControl;
        private TabPage loadoutEditorSurvivalTab;
        private TabPage loadoutEditorSiegeTab;
        private TabControl siegeGameTabControl;
        private TabPage tabPage7;
        private LinkLabel linkLabel1;
        private Label label6;
        private Label label7;
        private MaskedTextBox maskedTextBoxJoinSiegeGameLoadout;
        private Label label8;
        private Button btnJoinSiegeGame;
        private Label label9;
        private MaskedTextBox maskedTextBoxJoinSiegeGameHostIP;
        private TabPage tabPage8;
        private Label label21;
        private MaskedTextBox maskedTextBoxSiegeHostGamePlayer8Loadout;
        private MaskedTextBox maskedTextBoxSiegeHostGamePlayer6Loadout;
        private MaskedTextBox maskedTextBoxSiegeHostGamePlayer9Loadout;
        private MaskedTextBox maskedTextBoxSiegeHostGamePlayer7Loadout;
        private Label label2;
        private Label label4;
        private Label label18;
        private MaskedTextBox maskedTextBoxSiegeHostGamePlayer10Loadout;
        private Label label19;
        private Label label20;
        private Label label10;
        private Label label11;
        private MaskedTextBox maskedTextBoxSiegeHostGamePlayer3Loadout;
        private MaskedTextBox maskedTextBoxSiegeHostGamePlayer1Loadout;
        private MaskedTextBox maskedTextBoxSiegeHostGamePlayer4Loadout;
        private Button btnSiegeLaunch;
        private MaskedTextBox maskedTextBoxSiegeHostGamePlayer2Loadout;
        private Label label12;
        private Label label13;
        private Label label14;
        private MaskedTextBox maskedTextBoxSiegeHostGamePlayer5Loadout;
        private Label label15;
        private Label label16;
        private GroupBox siegeGameSettingsGroupBox;
        private ComboBox comBoxSiegeLanguage;
        private Label labelSiegeLanguage;
        private GroupBox groupBox1;
        private ComboBox comBoxSiegeDifficulty;
        private Label labelSiegeDifficulty;
        private ComboBox comBoxSiegeBattleground;
        private Label labelSiegeMap;
        private GroupBox siegeLoadoutEditorGroupBox;
        private Button btnDeleteSiegeLoadout;
        private Label label22;
        private MaskedTextBox maskedTextBoxSiegePlayerName;
        private Label label23;
        private Button btnSaveSiegeLoadout;
        private MaskedTextBox maskedTextBoxSiegeLoadoutName;
        private Button btnCopySiegeLoadoutToClipboard;
        private Button btnImportSiegeLoadout;
        private Label label24;
        private TextBox textBoxExportSiegeLoadout;
        private MaskedTextBox maskedTextBoxImportSiegeLoadout;
        private Label label25;
        private ComboBox comboxSiegeTraitYellowSlot;
        private Label label26;
        private ComboBox comboxSiegeTraitNoBonusSlot;
        private Label label27;
        private ComboBox comboxSiegeTraitGreenSlot;
        private Label label28;
        private ComboBox comboxSiegeTraitBlueSlot;
        private ComboBox comBoxSiegeDye;
        private Label label29;
        private ComboBox comBoxSiegeHero;
        private Label label32;
        private Label label33;
        private ComboBox comBoxSiegeLoadouts;
        private Label label35;
        private Label label37;
        private Label label38;
        private Label label39;
        private Label label40;
        private Label label41;
        private Label label42;
        private Label label43;
        private Label label44;
        private ComboBox comBoxSiegeLoadoutSlot1;
        private ComboBox comBoxSiegeLoadoutSlot2;
        private ComboBox comBoxSiegeLoadoutSlot3;
        private ComboBox comBoxSiegeLoadoutSlot9;
        private ComboBox comBoxSiegeLoadoutSlot4;
        private ComboBox comBoxSiegeLoadoutSlot8;
        private ComboBox comBoxSiegeLoadoutSlot5;
        private ComboBox comBoxSiegeLoadoutSlot7;
        private ComboBox comBoxSiegeLoadoutSlot6;
        private ComboBox comBoxSiegeBossWaveSlot2;
        private Label label45;
        private ComboBox comBoxSiegeBossWaveSlot1;
        private ComboBox comBoxSiegeLv4WaveSlot2;
        private Label label36;
        private ComboBox comBoxSiegeLv4WaveSlot1;
        private ComboBox comBoxSiegeLv3WaveSlot2;
        private Label label34;
        private ComboBox comBoxSiegeLv3WaveSlot1;
        private ComboBox comBoxSiegeLv2WaveSlot2;
        private Label label31;
        private ComboBox comBoxSiegeLv2WaveSlot1;
        private ComboBox comBoxSiegeLv1WaveSlot2;
        private Label label30;
        private ComboBox comBoxSiegeLv1WaveSlot1;
        private ComboBox comBoxSiegeSkin;
        private Button btnSaveLoadout;
        private ComboBox comBoxRole;
        private Label roleLabel;
        private Button btnPlaySiegeTutorial;
        private LinkLabel linkLabel2;
        private CheckBox chkSiegeEnemyTeamAsBots;
        private CheckBox chkOverrideTrapTier;
        private NumericUpDown inputOverrideTrapTier;
        private CheckBox chkOverrideAccountLevel;
        private NumericUpDown inputOverrideAccountLevel;
        private Label labelOverrideLevels;
        private Label label3;
    }
}

