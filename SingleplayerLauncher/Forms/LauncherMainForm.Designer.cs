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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LauncherMainForm));
            this.btnLaunch = new System.Windows.Forms.Button();
            this.chkDebug = new System.Windows.Forms.CheckBox();
            this.mapSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.comBoxExtraDifficulty = new System.Windows.Forms.ComboBox();
            this.labelExtraDifficulty = new System.Windows.Forms.Label();
            this.comBoxDifficulty = new System.Windows.Forms.ComboBox();
            this.labelDifficulty = new System.Windows.Forms.Label();
            this.comBoxGameMode = new System.Windows.Forms.ComboBox();
            this.labelGameMode = new System.Windows.Forms.Label();
            this.comBoxBattleground = new System.Windows.Forms.ComboBox();
            this.labelMap = new System.Windows.Forms.Label();
            this.btnResetConfig = new System.Windows.Forms.Button();
            this.chkShowTrapDamageFlyoffs = new System.Windows.Forms.CheckBox();
            this.chkInvincibleBarricades = new System.Windows.Forms.CheckBox();
            this.chkNoTrapGrid = new System.Windows.Forms.CheckBox();
            this.chkTrapsAnySurface = new System.Windows.Forms.CheckBox();
            this.chkHardcore = new System.Windows.Forms.CheckBox();
            this.chkNoLimitUniqueTraps = new System.Windows.Forms.CheckBox();
            this.startingCoinInput = new System.Windows.Forms.NumericUpDown();
            this.chkTrapsInTraps = new System.Windows.Forms.CheckBox();
            this.chkNoTrapCap = new System.Windows.Forms.CheckBox();
            this.chkGodMode = new System.Windows.Forms.CheckBox();
            this.modsGroupBox = new System.Windows.Forms.GroupBox();
            this.chkEnhancedTrapRotation = new System.Windows.Forms.CheckBox();
            this.chkCustomStartCoin = new System.Windows.Forms.CheckBox();
            this.chkSellTrapsAnytime = new System.Windows.Forms.CheckBox();
            this.chk_modsEnabled = new System.Windows.Forms.CheckBox();
            this.chkRunAs32 = new System.Windows.Forms.CheckBox();
            this.comBoxLanguage = new System.Windows.Forms.ComboBox();
            this.labelLanguage = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnDiscord = new System.Windows.Forms.Button();
            this.maskedTextBoxHostGamePlayer1Loadout = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxHostGamePlayer4Loadout = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxHostGamePlayer3Loadout = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxHostGamePlayer2Loadout = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxHostGamePlayer5Loadout = new System.Windows.Forms.MaskedTextBox();
            this.labelHostGamePlayer1 = new System.Windows.Forms.Label();
            this.labelHostGamePlayer2 = new System.Windows.Forms.Label();
            this.labelHostGamePlayer4 = new System.Windows.Forms.Label();
            this.labelHostGamePlayer3 = new System.Windows.Forms.Label();
            this.labelHostGamePlayer5 = new System.Windows.Forms.Label();
            this.maskedTextBoxJoinGameHostIP = new System.Windows.Forms.MaskedTextBox();
            this.labelJoinGameHostIP = new System.Windows.Forms.Label();
            this.btnJoinGame = new System.Windows.Forms.Button();
            this.maskedTextBoxJoinGameLoadout = new System.Windows.Forms.MaskedTextBox();
            this.labelJoinGameLoadout = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.linkLabelJoinGameKnownIssues = new System.Windows.Forms.LinkLabel();
            this.labelJoinGameBriefInstructions = new System.Windows.Forms.Label();
            this.labelJoinGameAdditionalInfo = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelHostGameAdditionalInfo = new System.Windows.Forms.Label();
            this.labelHostGameBriefInstructions = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.modsPanel = new System.Windows.Forms.Panel();
            this.gameSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.panelLoadoutEditor = new System.Windows.Forms.Panel();
            this.groupBoxLoadout = new System.Windows.Forms.GroupBox();
            this.btnDeleteLoadout = new System.Windows.Forms.Button();
            this.labelPlayerName = new System.Windows.Forms.Label();
            this.maskedTextBoxPlayerName = new System.Windows.Forms.MaskedTextBox();
            this.labelLoadoutName = new System.Windows.Forms.Label();
            this.btnSaveLoadout = new System.Windows.Forms.Button();
            this.maskedTextBoxLoadoutName = new System.Windows.Forms.MaskedTextBox();
            this.btnCopyLoadoutToClipboard = new System.Windows.Forms.Button();
            this.btnImportLoadout = new System.Windows.Forms.Button();
            this.labelExportLoadout = new System.Windows.Forms.Label();
            this.textBoxExportLoadout = new System.Windows.Forms.TextBox();
            this.maskedTextBoxImportLoadout = new System.Windows.Forms.MaskedTextBox();
            this.comBoxTrapPartsSlot9Part3 = new System.Windows.Forms.ComboBox();
            this.comBoxTrapPartsSlot9Part2 = new System.Windows.Forms.ComboBox();
            this.comBoxTrapPartsSlot9Part1 = new System.Windows.Forms.ComboBox();
            this.comBoxTrapPartsSlot8Part3 = new System.Windows.Forms.ComboBox();
            this.comBoxTrapPartsSlot8Part2 = new System.Windows.Forms.ComboBox();
            this.comBoxTrapPartsSlot8Part1 = new System.Windows.Forms.ComboBox();
            this.comBoxTrapPartsSlot7Part3 = new System.Windows.Forms.ComboBox();
            this.comBoxTrapPartsSlot7Part2 = new System.Windows.Forms.ComboBox();
            this.comBoxTrapPartsSlot7Part1 = new System.Windows.Forms.ComboBox();
            this.comBoxTrapPartsSlot6Part3 = new System.Windows.Forms.ComboBox();
            this.comBoxTrapPartsSlot6Part2 = new System.Windows.Forms.ComboBox();
            this.comBoxTrapPartsSlot6Part1 = new System.Windows.Forms.ComboBox();
            this.comBoxTrapPartsSlot5Part3 = new System.Windows.Forms.ComboBox();
            this.comBoxTrapPartsSlot5Part2 = new System.Windows.Forms.ComboBox();
            this.comBoxTrapPartsSlot5Part1 = new System.Windows.Forms.ComboBox();
            this.comBoxTrapPartsSlot4Part3 = new System.Windows.Forms.ComboBox();
            this.comBoxTrapPartsSlot4Part2 = new System.Windows.Forms.ComboBox();
            this.comBoxTrapPartsSlot4Part1 = new System.Windows.Forms.ComboBox();
            this.comBoxTrapPartsSlot3Part3 = new System.Windows.Forms.ComboBox();
            this.comBoxTrapPartsSlot3Part2 = new System.Windows.Forms.ComboBox();
            this.comBoxTrapPartsSlot3Part1 = new System.Windows.Forms.ComboBox();
            this.comBoxTrapPartsSlot2Part3 = new System.Windows.Forms.ComboBox();
            this.comBoxTrapPartsSlot2Part2 = new System.Windows.Forms.ComboBox();
            this.comBoxTrapPartsSlot2Part1 = new System.Windows.Forms.ComboBox();
            this.comBoxTrapPartsSlot1Part3 = new System.Windows.Forms.ComboBox();
            this.comBoxTrapPartsSlot1Part2 = new System.Windows.Forms.ComboBox();
            this.comBoxTrapPartsSlot1Part1 = new System.Windows.Forms.ComboBox();
            this.labelTraitNoBonusSlot = new System.Windows.Forms.Label();
            this.comboxTraitYellowSlot = new System.Windows.Forms.ComboBox();
            this.labelTraitYellowSlot = new System.Windows.Forms.Label();
            this.comboxTraitNoBonusSlot = new System.Windows.Forms.ComboBox();
            this.labelTraitBlueSlot = new System.Windows.Forms.Label();
            this.comboxTraitGreenSlot = new System.Windows.Forms.ComboBox();
            this.labelTraitGreenSlot = new System.Windows.Forms.Label();
            this.comboxTraitBlueSlot = new System.Windows.Forms.ComboBox();
            this.comBoxDye = new System.Windows.Forms.ComboBox();
            this.labelHero = new System.Windows.Forms.Label();
            this.labelConsumableSlot2 = new System.Windows.Forms.Label();
            this.comBoxHero = new System.Windows.Forms.ComboBox();
            this.comBoxConsumableSlot1 = new System.Windows.Forms.ComboBox();
            this.comBoxSkin = new System.Windows.Forms.ComboBox();
            this.labelConsumableSlot1 = new System.Windows.Forms.Label();
            this.labelDye = new System.Windows.Forms.Label();
            this.comBoxConsumableSlot2 = new System.Windows.Forms.ComboBox();
            this.labelSkin = new System.Windows.Forms.Label();
            this.labelGuardianSlot2 = new System.Windows.Forms.Label();
            this.comBoxLoadouts = new System.Windows.Forms.ComboBox();
            this.labelLoadoutSlot9 = new System.Windows.Forms.Label();
            this.comBoxGuardianSlot1 = new System.Windows.Forms.ComboBox();
            this.labelGuardianSlot1 = new System.Windows.Forms.Label();
            this.labelLoadoutSlot8 = new System.Windows.Forms.Label();
            this.comBoxGuardianSlot2 = new System.Windows.Forms.ComboBox();
            this.labelLoadoutSlot7 = new System.Windows.Forms.Label();
            this.labelLoadoutSlot6 = new System.Windows.Forms.Label();
            this.labelLoadoutSlot5 = new System.Windows.Forms.Label();
            this.labelLoadoutSlot4 = new System.Windows.Forms.Label();
            this.labelLoadoutSlot3 = new System.Windows.Forms.Label();
            this.labelLoadoutSlot2 = new System.Windows.Forms.Label();
            this.labelLoadoutSlot1 = new System.Windows.Forms.Label();
            this.comBoxLoadoutSlot1 = new System.Windows.Forms.ComboBox();
            this.comBoxLoadoutSlot2 = new System.Windows.Forms.ComboBox();
            this.comBoxLoadoutSlot3 = new System.Windows.Forms.ComboBox();
            this.comBoxLoadoutSlot9 = new System.Windows.Forms.ComboBox();
            this.comBoxLoadoutSlot4 = new System.Windows.Forms.ComboBox();
            this.comBoxLoadoutSlot8 = new System.Windows.Forms.ComboBox();
            this.comBoxLoadoutSlot5 = new System.Windows.Forms.ComboBox();
            this.comBoxLoadoutSlot7 = new System.Windows.Forms.ComboBox();
            this.comBoxLoadoutSlot6 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.mapSettingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startingCoinInput)).BeginInit();
            this.modsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.modsPanel.SuspendLayout();
            this.gameSettingsGroupBox.SuspendLayout();
            this.groupBoxLoadout.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLaunch
            // 
            this.btnLaunch.BackColor = System.Drawing.Color.SpringGreen;
            this.btnLaunch.Location = new System.Drawing.Point(195, 137);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(123, 60);
            this.btnLaunch.TabIndex = 0;
            this.btnLaunch.Text = "Launch Match";
            this.btnLaunch.UseVisualStyleBackColor = false;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // chkDebug
            // 
            this.chkDebug.AutoSize = true;
            this.chkDebug.Location = new System.Drawing.Point(197, 563);
            this.chkDebug.Name = "chkDebug";
            this.chkDebug.Size = new System.Drawing.Size(58, 17);
            this.chkDebug.TabIndex = 6;
            this.chkDebug.Text = "Debug";
            this.chkDebug.UseVisualStyleBackColor = true;
            // 
            // mapSettingsGroupBox
            // 
            this.mapSettingsGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.mapSettingsGroupBox.Controls.Add(this.comBoxExtraDifficulty);
            this.mapSettingsGroupBox.Controls.Add(this.labelExtraDifficulty);
            this.mapSettingsGroupBox.Controls.Add(this.comBoxDifficulty);
            this.mapSettingsGroupBox.Controls.Add(this.labelDifficulty);
            this.mapSettingsGroupBox.Controls.Add(this.comBoxGameMode);
            this.mapSettingsGroupBox.Controls.Add(this.labelGameMode);
            this.mapSettingsGroupBox.Controls.Add(this.comBoxBattleground);
            this.mapSettingsGroupBox.Controls.Add(this.labelMap);
            this.mapSettingsGroupBox.Location = new System.Drawing.Point(3, 29);
            this.mapSettingsGroupBox.Name = "mapSettingsGroupBox";
            this.mapSettingsGroupBox.Size = new System.Drawing.Size(341, 224);
            this.mapSettingsGroupBox.TabIndex = 8;
            this.mapSettingsGroupBox.TabStop = false;
            this.mapSettingsGroupBox.Text = "Battleground";
            // 
            // comBoxExtraDifficulty
            // 
            this.comBoxExtraDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxExtraDifficulty.FormattingEnabled = true;
            this.comBoxExtraDifficulty.Location = new System.Drawing.Point(242, 48);
            this.comBoxExtraDifficulty.Name = "comBoxExtraDifficulty";
            this.comBoxExtraDifficulty.Size = new System.Drawing.Size(93, 21);
            this.comBoxExtraDifficulty.TabIndex = 9;
            this.comBoxExtraDifficulty.SelectedIndexChanged += new System.EventHandler(this.comBoxExtraDifficulty_SelectedIndexChanged);
            // 
            // labelExtraDifficulty
            // 
            this.labelExtraDifficulty.AutoSize = true;
            this.labelExtraDifficulty.Location = new System.Drawing.Point(162, 51);
            this.labelExtraDifficulty.Name = "labelExtraDifficulty";
            this.labelExtraDifficulty.Size = new System.Drawing.Size(74, 13);
            this.labelExtraDifficulty.TabIndex = 8;
            this.labelExtraDifficulty.Text = "Extra Difficulty";
            // 
            // comBoxDifficulty
            // 
            this.comBoxDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxDifficulty.Enabled = false;
            this.comBoxDifficulty.FormattingEnabled = true;
            this.comBoxDifficulty.Location = new System.Drawing.Point(215, 21);
            this.comBoxDifficulty.Name = "comBoxDifficulty";
            this.comBoxDifficulty.Size = new System.Drawing.Size(120, 21);
            this.comBoxDifficulty.TabIndex = 7;
            this.comBoxDifficulty.SelectedIndexChanged += new System.EventHandler(this.comBoxDifficulty_SelectedIndexChanged);
            // 
            // labelDifficulty
            // 
            this.labelDifficulty.AutoSize = true;
            this.labelDifficulty.Location = new System.Drawing.Point(162, 24);
            this.labelDifficulty.Name = "labelDifficulty";
            this.labelDifficulty.Size = new System.Drawing.Size(47, 13);
            this.labelDifficulty.TabIndex = 6;
            this.labelDifficulty.Text = "Difficulty";
            // 
            // comBoxGameMode
            // 
            this.comBoxGameMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxGameMode.FormattingEnabled = true;
            this.comBoxGameMode.Location = new System.Drawing.Point(40, 21);
            this.comBoxGameMode.Name = "comBoxGameMode";
            this.comBoxGameMode.Size = new System.Drawing.Size(116, 21);
            this.comBoxGameMode.TabIndex = 5;
            this.comBoxGameMode.SelectedIndexChanged += new System.EventHandler(this.comBoxGameMode_SelectedIndexChanged);
            // 
            // labelGameMode
            // 
            this.labelGameMode.AutoSize = true;
            this.labelGameMode.Location = new System.Drawing.Point(6, 26);
            this.labelGameMode.Name = "labelGameMode";
            this.labelGameMode.Size = new System.Drawing.Size(34, 13);
            this.labelGameMode.TabIndex = 2;
            this.labelGameMode.Text = "Mode";
            // 
            // comBoxBattleground
            // 
            this.comBoxBattleground.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxBattleground.FormattingEnabled = true;
            this.comBoxBattleground.Location = new System.Drawing.Point(40, 48);
            this.comBoxBattleground.Name = "comBoxBattleground";
            this.comBoxBattleground.Size = new System.Drawing.Size(116, 21);
            this.comBoxBattleground.TabIndex = 1;
            this.comBoxBattleground.SelectedIndexChanged += new System.EventHandler(this.comBoxBattleground_SelectedIndexChanged);
            // 
            // labelMap
            // 
            this.labelMap.AutoSize = true;
            this.labelMap.Location = new System.Drawing.Point(6, 51);
            this.labelMap.Name = "labelMap";
            this.labelMap.Size = new System.Drawing.Size(28, 13);
            this.labelMap.TabIndex = 0;
            this.labelMap.Text = "Map";
            // 
            // btnResetConfig
            // 
            this.btnResetConfig.Location = new System.Drawing.Point(261, 559);
            this.btnResetConfig.Name = "btnResetConfig";
            this.btnResetConfig.Size = new System.Drawing.Size(83, 23);
            this.btnResetConfig.TabIndex = 9;
            this.btnResetConfig.Text = "Reset Configs";
            this.btnResetConfig.UseVisualStyleBackColor = true;
            this.btnResetConfig.Click += new System.EventHandler(this.btnResetConfig_Click);
            // 
            // chkShowTrapDamageFlyoffs
            // 
            this.chkShowTrapDamageFlyoffs.AutoSize = true;
            this.chkShowTrapDamageFlyoffs.Location = new System.Drawing.Point(200, 38);
            this.chkShowTrapDamageFlyoffs.Name = "chkShowTrapDamageFlyoffs";
            this.chkShowTrapDamageFlyoffs.Size = new System.Drawing.Size(121, 17);
            this.chkShowTrapDamageFlyoffs.TabIndex = 21;
            this.chkShowTrapDamageFlyoffs.Text = "Show Trap Damage";
            this.chkShowTrapDamageFlyoffs.UseVisualStyleBackColor = true;
            this.chkShowTrapDamageFlyoffs.CheckedChanged += new System.EventHandler(this.chkShowTrapDamageFlyoffs_CheckedChanged);
            // 
            // chkInvincibleBarricades
            // 
            this.chkInvincibleBarricades.AutoSize = true;
            this.chkInvincibleBarricades.Location = new System.Drawing.Point(6, 42);
            this.chkInvincibleBarricades.Name = "chkInvincibleBarricades";
            this.chkInvincibleBarricades.Size = new System.Drawing.Size(124, 17);
            this.chkInvincibleBarricades.TabIndex = 20;
            this.chkInvincibleBarricades.Text = "Invincible Barricades";
            this.chkInvincibleBarricades.UseVisualStyleBackColor = true;
            this.chkInvincibleBarricades.CheckedChanged += new System.EventHandler(this.chkInvincibleBarricades_CheckedChanged);
            // 
            // chkNoTrapGrid
            // 
            this.chkNoTrapGrid.AutoSize = true;
            this.chkNoTrapGrid.Location = new System.Drawing.Point(170, 59);
            this.chkNoTrapGrid.Name = "chkNoTrapGrid";
            this.chkNoTrapGrid.Size = new System.Drawing.Size(83, 17);
            this.chkNoTrapGrid.TabIndex = 19;
            this.chkNoTrapGrid.Text = "No trap Grid";
            this.chkNoTrapGrid.UseVisualStyleBackColor = true;
            this.chkNoTrapGrid.CheckedChanged += new System.EventHandler(this.chkNoTrapGrid_CheckedChanged);
            // 
            // chkTrapsAnySurface
            // 
            this.chkTrapsAnySurface.AutoSize = true;
            this.chkTrapsAnySurface.Location = new System.Drawing.Point(170, 13);
            this.chkTrapsAnySurface.Name = "chkTrapsAnySurface";
            this.chkTrapsAnySurface.Size = new System.Drawing.Size(128, 17);
            this.chkTrapsAnySurface.TabIndex = 18;
            this.chkTrapsAnySurface.Text = "Traps on any Surface";
            this.chkTrapsAnySurface.UseVisualStyleBackColor = true;
            this.chkTrapsAnySurface.CheckedChanged += new System.EventHandler(this.chkTrapsAnySurface_CheckedChanged);
            // 
            // chkHardcore
            // 
            this.chkHardcore.AutoSize = true;
            this.chkHardcore.Location = new System.Drawing.Point(7, 136);
            this.chkHardcore.Name = "chkHardcore";
            this.chkHardcore.Size = new System.Drawing.Size(101, 17);
            this.chkHardcore.TabIndex = 17;
            this.chkHardcore.Text = "Hardcore (1 life)";
            this.chkHardcore.UseVisualStyleBackColor = true;
            this.chkHardcore.CheckedChanged += new System.EventHandler(this.chkHardcore_CheckedChanged);
            // 
            // chkNoLimitUniqueTraps
            // 
            this.chkNoLimitUniqueTraps.AutoSize = true;
            this.chkNoLimitUniqueTraps.Location = new System.Drawing.Point(6, 65);
            this.chkNoLimitUniqueTraps.Name = "chkNoLimitUniqueTraps";
            this.chkNoLimitUniqueTraps.Size = new System.Drawing.Size(131, 17);
            this.chkNoLimitUniqueTraps.TabIndex = 16;
            this.chkNoLimitUniqueTraps.Text = "No Limit Unique Traps";
            this.chkNoLimitUniqueTraps.UseVisualStyleBackColor = true;
            this.chkNoLimitUniqueTraps.CheckedChanged += new System.EventHandler(this.chkNoLimitUniqueTraps_CheckedChanged);
            // 
            // startingCoinInput
            // 
            this.startingCoinInput.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.startingCoinInput.Location = new System.Drawing.Point(248, 155);
            this.startingCoinInput.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.startingCoinInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.startingCoinInput.Name = "startingCoinInput";
            this.startingCoinInput.Size = new System.Drawing.Size(85, 20);
            this.startingCoinInput.TabIndex = 14;
            this.startingCoinInput.ValueChanged += new System.EventHandler(this.StartingCoinInput_ValueChanged);
            // 
            // chkTrapsInTraps
            // 
            this.chkTrapsInTraps.AutoSize = true;
            this.chkTrapsInTraps.Location = new System.Drawing.Point(170, 36);
            this.chkTrapsInTraps.Name = "chkTrapsInTraps";
            this.chkTrapsInTraps.Size = new System.Drawing.Size(112, 17);
            this.chkTrapsInTraps.TabIndex = 13;
            this.chkTrapsInTraps.Text = "Traps can overlap";
            this.chkTrapsInTraps.UseVisualStyleBackColor = true;
            this.chkTrapsInTraps.CheckedChanged += new System.EventHandler(this.chkTrapsInTraps_CheckedChanged);
            // 
            // chkNoTrapCap
            // 
            this.chkNoTrapCap.AutoSize = true;
            this.chkNoTrapCap.Location = new System.Drawing.Point(6, 19);
            this.chkNoTrapCap.Name = "chkNoTrapCap";
            this.chkNoTrapCap.Size = new System.Drawing.Size(87, 17);
            this.chkNoTrapCap.TabIndex = 12;
            this.chkNoTrapCap.Text = "No Trap Cap";
            this.chkNoTrapCap.UseVisualStyleBackColor = true;
            this.chkNoTrapCap.CheckedChanged += new System.EventHandler(this.chkNoTrapCap_CheckedChanged);
            // 
            // chkGodMode
            // 
            this.chkGodMode.AutoSize = true;
            this.chkGodMode.Location = new System.Drawing.Point(7, 159);
            this.chkGodMode.Name = "chkGodMode";
            this.chkGodMode.Size = new System.Drawing.Size(76, 17);
            this.chkGodMode.TabIndex = 11;
            this.chkGodMode.Text = "God Mode";
            this.chkGodMode.UseVisualStyleBackColor = true;
            this.chkGodMode.CheckedChanged += new System.EventHandler(this.chkGodMode_CheckedChanged);
            // 
            // modsGroupBox
            // 
            this.modsGroupBox.BackColor = System.Drawing.Color.Bisque;
            this.modsGroupBox.Controls.Add(this.chkEnhancedTrapRotation);
            this.modsGroupBox.Controls.Add(this.chkCustomStartCoin);
            this.modsGroupBox.Controls.Add(this.chkSellTrapsAnytime);
            this.modsGroupBox.Controls.Add(this.chkNoLimitUniqueTraps);
            this.modsGroupBox.Controls.Add(this.chkHardcore);
            this.modsGroupBox.Controls.Add(this.chkNoTrapCap);
            this.modsGroupBox.Controls.Add(this.startingCoinInput);
            this.modsGroupBox.Controls.Add(this.chkNoTrapGrid);
            this.modsGroupBox.Controls.Add(this.chkGodMode);
            this.modsGroupBox.Controls.Add(this.chkInvincibleBarricades);
            this.modsGroupBox.Controls.Add(this.chkTrapsAnySurface);
            this.modsGroupBox.Controls.Add(this.chkTrapsInTraps);
            this.modsGroupBox.Location = new System.Drawing.Point(3, 132);
            this.modsGroupBox.Name = "modsGroupBox";
            this.modsGroupBox.Size = new System.Drawing.Size(339, 181);
            this.modsGroupBox.TabIndex = 22;
            this.modsGroupBox.TabStop = false;
            this.modsGroupBox.Text = "Mods";
            // 
            // chkEnhancedTrapRotation
            // 
            this.chkEnhancedTrapRotation.AutoSize = true;
            this.chkEnhancedTrapRotation.Location = new System.Drawing.Point(170, 104);
            this.chkEnhancedTrapRotation.Name = "chkEnhancedTrapRotation";
            this.chkEnhancedTrapRotation.Size = new System.Drawing.Size(143, 17);
            this.chkEnhancedTrapRotation.TabIndex = 24;
            this.chkEnhancedTrapRotation.Text = "Enhanced Trap Rotation";
            this.chkEnhancedTrapRotation.UseVisualStyleBackColor = true;
            this.chkEnhancedTrapRotation.CheckedChanged += new System.EventHandler(this.chkEnhancedTrapRotation_CheckedChanged);
            // 
            // chkCustomStartCoin
            // 
            this.chkCustomStartCoin.AutoSize = true;
            this.chkCustomStartCoin.Location = new System.Drawing.Point(170, 156);
            this.chkCustomStartCoin.Name = "chkCustomStartCoin";
            this.chkCustomStartCoin.Size = new System.Drawing.Size(72, 17);
            this.chkCustomStartCoin.TabIndex = 23;
            this.chkCustomStartCoin.Text = "Start Coin";
            this.chkCustomStartCoin.UseVisualStyleBackColor = true;
            this.chkCustomStartCoin.CheckedChanged += new System.EventHandler(this.chkCustomStartCoin_CheckedChanged);
            // 
            // chkSellTrapsAnytime
            // 
            this.chkSellTrapsAnytime.AutoSize = true;
            this.chkSellTrapsAnytime.Location = new System.Drawing.Point(170, 82);
            this.chkSellTrapsAnytime.Name = "chkSellTrapsAnytime";
            this.chkSellTrapsAnytime.Size = new System.Drawing.Size(113, 17);
            this.chkSellTrapsAnytime.TabIndex = 22;
            this.chkSellTrapsAnytime.Text = "Sell Traps Anytime";
            this.chkSellTrapsAnytime.UseVisualStyleBackColor = true;
            this.chkSellTrapsAnytime.CheckedChanged += new System.EventHandler(this.chkSellTrapsAnytime_CheckedChanged);
            // 
            // chk_modsEnabled
            // 
            this.chk_modsEnabled.AutoSize = true;
            this.chk_modsEnabled.Location = new System.Drawing.Point(200, 15);
            this.chk_modsEnabled.Name = "chk_modsEnabled";
            this.chk_modsEnabled.Size = new System.Drawing.Size(93, 17);
            this.chk_modsEnabled.TabIndex = 25;
            this.chk_modsEnabled.Text = "Mods enabled";
            this.chk_modsEnabled.UseVisualStyleBackColor = true;
            this.chk_modsEnabled.CheckedChanged += new System.EventHandler(this.chk_modsEnabled_CheckedChanged);
            // 
            // chkRunAs32
            // 
            this.chkRunAs32.AutoSize = true;
            this.chkRunAs32.Location = new System.Drawing.Point(98, 563);
            this.chkRunAs32.Name = "chkRunAs32";
            this.chkRunAs32.Size = new System.Drawing.Size(84, 17);
            this.chkRunAs32.TabIndex = 26;
            this.chkRunAs32.Text = "Force 32bits";
            this.chkRunAs32.UseVisualStyleBackColor = true;
            // 
            // comBoxLanguage
            // 
            this.comBoxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxLanguage.FormattingEnabled = true;
            this.comBoxLanguage.Location = new System.Drawing.Point(75, 32);
            this.comBoxLanguage.Name = "comBoxLanguage";
            this.comBoxLanguage.Size = new System.Drawing.Size(79, 21);
            this.comBoxLanguage.TabIndex = 11;
            this.comBoxLanguage.SelectedIndexChanged += new System.EventHandler(this.comBoxLanguage_SelectedIndexChanged);
            // 
            // labelLanguage
            // 
            this.labelLanguage.AutoSize = true;
            this.labelLanguage.Location = new System.Drawing.Point(14, 35);
            this.labelLanguage.Name = "labelLanguage";
            this.labelLanguage.Size = new System.Drawing.Size(55, 13);
            this.labelLanguage.TabIndex = 10;
            this.labelLanguage.Text = "Language";
            this.labelLanguage.Click += new System.EventHandler(this.labelLanguage_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 13);
            this.label1.TabIndex = 73;
            this.label1.Text = "Any issues or feedback? Join our Discord:";
            // 
            // btnDiscord
            // 
            this.btnDiscord.BackColor = System.Drawing.Color.Transparent;
            this.btnDiscord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDiscord.Image = ((System.Drawing.Image)(resources.GetObject("btnDiscord.Image")));
            this.btnDiscord.Location = new System.Drawing.Point(302, 4);
            this.btnDiscord.Margin = new System.Windows.Forms.Padding(0);
            this.btnDiscord.Name = "btnDiscord";
            this.btnDiscord.Size = new System.Drawing.Size(36, 26);
            this.btnDiscord.TabIndex = 74;
            this.btnDiscord.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDiscord.UseVisualStyleBackColor = false;
            this.btnDiscord.Click += new System.EventHandler(this.btnDiscord_Click);
            // 
            // maskedTextBoxHostGamePlayer1Loadout
            // 
            this.maskedTextBoxHostGamePlayer1Loadout.Enabled = false;
            this.maskedTextBoxHostGamePlayer1Loadout.Location = new System.Drawing.Point(71, 32);
            this.maskedTextBoxHostGamePlayer1Loadout.Name = "maskedTextBoxHostGamePlayer1Loadout";
            this.maskedTextBoxHostGamePlayer1Loadout.Size = new System.Drawing.Size(247, 20);
            this.maskedTextBoxHostGamePlayer1Loadout.TabIndex = 73;
            this.maskedTextBoxHostGamePlayer1Loadout.TextChanged += new System.EventHandler(this.maskedTextBoxHostGamePlayer1Loadout_TextChanged);
            // 
            // maskedTextBoxHostGamePlayer4Loadout
            // 
            this.maskedTextBoxHostGamePlayer4Loadout.Location = new System.Drawing.Point(71, 111);
            this.maskedTextBoxHostGamePlayer4Loadout.Name = "maskedTextBoxHostGamePlayer4Loadout";
            this.maskedTextBoxHostGamePlayer4Loadout.Size = new System.Drawing.Size(247, 20);
            this.maskedTextBoxHostGamePlayer4Loadout.TabIndex = 75;
            this.maskedTextBoxHostGamePlayer4Loadout.TextChanged += new System.EventHandler(this.maskedTextBoxHostGamePlayer4Loadout_TextChanged);
            // 
            // maskedTextBoxHostGamePlayer3Loadout
            // 
            this.maskedTextBoxHostGamePlayer3Loadout.Location = new System.Drawing.Point(71, 85);
            this.maskedTextBoxHostGamePlayer3Loadout.Name = "maskedTextBoxHostGamePlayer3Loadout";
            this.maskedTextBoxHostGamePlayer3Loadout.Size = new System.Drawing.Size(247, 20);
            this.maskedTextBoxHostGamePlayer3Loadout.TabIndex = 76;
            this.maskedTextBoxHostGamePlayer3Loadout.TextChanged += new System.EventHandler(this.maskedTextBoxHostGamePlayer3Loadout_TextChanged);
            // 
            // maskedTextBoxHostGamePlayer2Loadout
            // 
            this.maskedTextBoxHostGamePlayer2Loadout.Location = new System.Drawing.Point(71, 58);
            this.maskedTextBoxHostGamePlayer2Loadout.Name = "maskedTextBoxHostGamePlayer2Loadout";
            this.maskedTextBoxHostGamePlayer2Loadout.Size = new System.Drawing.Size(247, 20);
            this.maskedTextBoxHostGamePlayer2Loadout.TabIndex = 77;
            this.maskedTextBoxHostGamePlayer2Loadout.TextChanged += new System.EventHandler(this.maskedTextBoxHostGamePlayer2Loadout_TextChanged);
            // 
            // maskedTextBoxHostGamePlayer5Loadout
            // 
            this.maskedTextBoxHostGamePlayer5Loadout.Location = new System.Drawing.Point(71, 137);
            this.maskedTextBoxHostGamePlayer5Loadout.Name = "maskedTextBoxHostGamePlayer5Loadout";
            this.maskedTextBoxHostGamePlayer5Loadout.Size = new System.Drawing.Size(118, 20);
            this.maskedTextBoxHostGamePlayer5Loadout.TabIndex = 78;
            this.maskedTextBoxHostGamePlayer5Loadout.TextChanged += new System.EventHandler(this.maskedTextBoxHostGamePlayer5Loadout_TextChanged);
            // 
            // labelHostGamePlayer1
            // 
            this.labelHostGamePlayer1.AutoSize = true;
            this.labelHostGamePlayer1.Location = new System.Drawing.Point(11, 35);
            this.labelHostGamePlayer1.Name = "labelHostGamePlayer1";
            this.labelHostGamePlayer1.Size = new System.Drawing.Size(57, 13);
            this.labelHostGamePlayer1.TabIndex = 79;
            this.labelHostGamePlayer1.Text = "Host (You)";
            // 
            // labelHostGamePlayer2
            // 
            this.labelHostGamePlayer2.AutoSize = true;
            this.labelHostGamePlayer2.Location = new System.Drawing.Point(23, 61);
            this.labelHostGamePlayer2.Name = "labelHostGamePlayer2";
            this.labelHostGamePlayer2.Size = new System.Drawing.Size(45, 13);
            this.labelHostGamePlayer2.TabIndex = 80;
            this.labelHostGamePlayer2.Text = "Player 2";
            // 
            // labelHostGamePlayer4
            // 
            this.labelHostGamePlayer4.AutoSize = true;
            this.labelHostGamePlayer4.Location = new System.Drawing.Point(23, 114);
            this.labelHostGamePlayer4.Name = "labelHostGamePlayer4";
            this.labelHostGamePlayer4.Size = new System.Drawing.Size(45, 13);
            this.labelHostGamePlayer4.TabIndex = 81;
            this.labelHostGamePlayer4.Text = "Player 4";
            // 
            // labelHostGamePlayer3
            // 
            this.labelHostGamePlayer3.AutoSize = true;
            this.labelHostGamePlayer3.Location = new System.Drawing.Point(23, 88);
            this.labelHostGamePlayer3.Name = "labelHostGamePlayer3";
            this.labelHostGamePlayer3.Size = new System.Drawing.Size(45, 13);
            this.labelHostGamePlayer3.TabIndex = 82;
            this.labelHostGamePlayer3.Text = "Player 3";
            // 
            // labelHostGamePlayer5
            // 
            this.labelHostGamePlayer5.AutoSize = true;
            this.labelHostGamePlayer5.Location = new System.Drawing.Point(23, 140);
            this.labelHostGamePlayer5.Name = "labelHostGamePlayer5";
            this.labelHostGamePlayer5.Size = new System.Drawing.Size(45, 13);
            this.labelHostGamePlayer5.TabIndex = 83;
            this.labelHostGamePlayer5.Text = "Player 5";
            // 
            // maskedTextBoxJoinGameHostIP
            // 
            this.maskedTextBoxJoinGameHostIP.Location = new System.Drawing.Point(71, 137);
            this.maskedTextBoxJoinGameHostIP.Name = "maskedTextBoxJoinGameHostIP";
            this.maskedTextBoxJoinGameHostIP.Size = new System.Drawing.Size(118, 20);
            this.maskedTextBoxJoinGameHostIP.TabIndex = 73;
            this.maskedTextBoxJoinGameHostIP.TextChanged += new System.EventHandler(this.maskedTextBoxJoinGameHostIP_TextChanged);
            // 
            // labelJoinGameHostIP
            // 
            this.labelJoinGameHostIP.AutoSize = true;
            this.labelJoinGameHostIP.Location = new System.Drawing.Point(24, 141);
            this.labelJoinGameHostIP.Name = "labelJoinGameHostIP";
            this.labelJoinGameHostIP.Size = new System.Drawing.Size(42, 13);
            this.labelJoinGameHostIP.TabIndex = 84;
            this.labelJoinGameHostIP.Text = "Host IP";
            // 
            // btnJoinGame
            // 
            this.btnJoinGame.BackColor = System.Drawing.Color.SpringGreen;
            this.btnJoinGame.Location = new System.Drawing.Point(195, 137);
            this.btnJoinGame.Name = "btnJoinGame";
            this.btnJoinGame.Size = new System.Drawing.Size(122, 60);
            this.btnJoinGame.TabIndex = 85;
            this.btnJoinGame.Text = "Join Match";
            this.btnJoinGame.UseVisualStyleBackColor = false;
            this.btnJoinGame.Click += new System.EventHandler(this.btnJoinGame_Click);
            // 
            // maskedTextBoxJoinGameLoadout
            // 
            this.maskedTextBoxJoinGameLoadout.Location = new System.Drawing.Point(71, 111);
            this.maskedTextBoxJoinGameLoadout.Name = "maskedTextBoxJoinGameLoadout";
            this.maskedTextBoxJoinGameLoadout.Size = new System.Drawing.Size(246, 20);
            this.maskedTextBoxJoinGameLoadout.TabIndex = 86;
            this.maskedTextBoxJoinGameLoadout.TextChanged += new System.EventHandler(this.maskedTextBoxJoinGamePlayerName_TextChanged);
            // 
            // labelJoinGameLoadout
            // 
            this.labelJoinGameLoadout.AutoSize = true;
            this.labelJoinGameLoadout.Location = new System.Drawing.Point(23, 115);
            this.labelJoinGameLoadout.Name = "labelJoinGameLoadout";
            this.labelJoinGameLoadout.Size = new System.Drawing.Size(46, 13);
            this.labelJoinGameLoadout.TabIndex = 87;
            this.labelJoinGameLoadout.Text = "Loadout";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.ItemSize = new System.Drawing.Size(167, 20);
            this.tabControl1.Location = new System.Drawing.Point(3, 319);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(343, 239);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 84;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.linkLabelJoinGameKnownIssues);
            this.tabPage1.Controls.Add(this.labelJoinGameBriefInstructions);
            this.tabPage1.Controls.Add(this.labelJoinGameAdditionalInfo);
            this.tabPage1.Controls.Add(this.maskedTextBoxJoinGameLoadout);
            this.tabPage1.Controls.Add(this.labelJoinGameLoadout);
            this.tabPage1.Controls.Add(this.btnJoinGame);
            this.tabPage1.Controls.Add(this.labelJoinGameHostIP);
            this.tabPage1.Controls.Add(this.maskedTextBoxJoinGameHostIP);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(335, 211);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Join Game";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // linkLabelJoinGameKnownIssues
            // 
            this.linkLabelJoinGameKnownIssues.ForeColor = System.Drawing.SystemColors.GrayText;
            this.linkLabelJoinGameKnownIssues.LinkArea = new System.Windows.Forms.LinkArea(14, 9);
            this.linkLabelJoinGameKnownIssues.LinkColor = System.Drawing.Color.Blue;
            this.linkLabelJoinGameKnownIssues.Location = new System.Drawing.Point(13, 15);
            this.linkLabelJoinGameKnownIssues.Name = "linkLabelJoinGameKnownIssues";
            this.linkLabelJoinGameKnownIssues.Size = new System.Drawing.Size(304, 51);
            this.linkLabelJoinGameKnownIssues.TabIndex = 90;
            this.linkLabelJoinGameKnownIssues.TabStop = true;
            this.linkLabelJoinGameKnownIssues.Text = "Known Issues (Full List): \r\n - (Host) No voices, movement skills, wave count (vis" +
    "ual)\r\n - (Client) If no skills join match again, no starting coin\r\n - Some mods " +
    "can cause issues";
            this.linkLabelJoinGameKnownIssues.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabelJoinGameKnownIssues.UseCompatibleTextRendering = true;
            this.linkLabelJoinGameKnownIssues.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // labelJoinGameBriefInstructions
            // 
            this.labelJoinGameBriefInstructions.AutoSize = true;
            this.labelJoinGameBriefInstructions.Location = new System.Drawing.Point(10, 88);
            this.labelJoinGameBriefInstructions.Name = "labelJoinGameBriefInstructions";
            this.labelJoinGameBriefInstructions.Size = new System.Drawing.Size(229, 13);
            this.labelJoinGameBriefInstructions.TabIndex = 89;
            this.labelJoinGameBriefInstructions.Text = "Enter the host IP and your loadout code below:";
            // 
            // labelJoinGameAdditionalInfo
            // 
            this.labelJoinGameAdditionalInfo.Location = new System.Drawing.Point(6, 160);
            this.labelJoinGameAdditionalInfo.Name = "labelJoinGameAdditionalInfo";
            this.labelJoinGameAdditionalInfo.Size = new System.Drawing.Size(183, 41);
            this.labelJoinGameAdditionalInfo.TabIndex = 88;
            this.labelJoinGameAdditionalInfo.Text = "Hover for more info about multiplayer";
            this.labelJoinGameAdditionalInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.labelJoinGameAdditionalInfo, resources.GetString("labelJoinGameAdditionalInfo.ToolTip"));
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelHostGameAdditionalInfo);
            this.tabPage2.Controls.Add(this.labelHostGameBriefInstructions);
            this.tabPage2.Controls.Add(this.maskedTextBoxHostGamePlayer3Loadout);
            this.tabPage2.Controls.Add(this.maskedTextBoxHostGamePlayer1Loadout);
            this.tabPage2.Controls.Add(this.maskedTextBoxHostGamePlayer4Loadout);
            this.tabPage2.Controls.Add(this.btnLaunch);
            this.tabPage2.Controls.Add(this.maskedTextBoxHostGamePlayer2Loadout);
            this.tabPage2.Controls.Add(this.labelHostGamePlayer2);
            this.tabPage2.Controls.Add(this.labelHostGamePlayer5);
            this.tabPage2.Controls.Add(this.labelHostGamePlayer4);
            this.tabPage2.Controls.Add(this.maskedTextBoxHostGamePlayer5Loadout);
            this.tabPage2.Controls.Add(this.labelHostGamePlayer1);
            this.tabPage2.Controls.Add(this.labelHostGamePlayer3);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(335, 211);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Host Game";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelHostGameAdditionalInfo
            // 
            this.labelHostGameAdditionalInfo.Location = new System.Drawing.Point(6, 160);
            this.labelHostGameAdditionalInfo.Name = "labelHostGameAdditionalInfo";
            this.labelHostGameAdditionalInfo.Size = new System.Drawing.Size(183, 41);
            this.labelHostGameAdditionalInfo.TabIndex = 85;
            this.labelHostGameAdditionalInfo.Text = "Hover for more info about multiplayer";
            this.labelHostGameAdditionalInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.labelHostGameAdditionalInfo, resources.GetString("labelHostGameAdditionalInfo.ToolTip"));
            // 
            // labelHostGameBriefInstructions
            // 
            this.labelHostGameBriefInstructions.AutoSize = true;
            this.labelHostGameBriefInstructions.Location = new System.Drawing.Point(11, 10);
            this.labelHostGameBriefInstructions.Name = "labelHostGameBriefInstructions";
            this.labelHostGameBriefInstructions.Size = new System.Drawing.Size(192, 13);
            this.labelHostGameBriefInstructions.TabIndex = 84;
            this.labelHostGameBriefInstructions.Text = "Enter the players\' loadout codes below:";
            // 
            // modsPanel
            // 
            this.modsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.modsPanel.Controls.Add(this.modsGroupBox);
            this.modsPanel.Location = new System.Drawing.Point(931, 3);
            this.modsPanel.Name = "modsPanel";
            this.modsPanel.Size = new System.Drawing.Size(345, 431);
            this.modsPanel.TabIndex = 85;
            this.modsPanel.Visible = false;
            // 
            // gameSettingsGroupBox
            // 
            this.gameSettingsGroupBox.Controls.Add(this.chk_modsEnabled);
            this.gameSettingsGroupBox.Controls.Add(this.comBoxLanguage);
            this.gameSettingsGroupBox.Controls.Add(this.labelLanguage);
            this.gameSettingsGroupBox.Controls.Add(this.chkShowTrapDamageFlyoffs);
            this.gameSettingsGroupBox.Location = new System.Drawing.Point(3, 253);
            this.gameSettingsGroupBox.Name = "gameSettingsGroupBox";
            this.gameSettingsGroupBox.Size = new System.Drawing.Size(341, 61);
            this.gameSettingsGroupBox.TabIndex = 86;
            this.gameSettingsGroupBox.TabStop = false;
            this.gameSettingsGroupBox.Text = "Game Settings";
            // 
            // panelLoadoutEditor
            // 
            this.panelLoadoutEditor.AutoSize = true;
            this.panelLoadoutEditor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelLoadoutEditor.Location = new System.Drawing.Point(6, 27);
            this.panelLoadoutEditor.Name = "panelLoadoutEditor";
            this.panelLoadoutEditor.Size = new System.Drawing.Size(0, 0);
            this.panelLoadoutEditor.TabIndex = 92;
            this.panelLoadoutEditor.Visible = false;
            // 
            // groupBoxLoadout
            // 
            this.groupBoxLoadout.AutoSize = true;
            this.groupBoxLoadout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxLoadout.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxLoadout.Controls.Add(this.btnDeleteLoadout);
            this.groupBoxLoadout.Controls.Add(this.labelPlayerName);
            this.groupBoxLoadout.Controls.Add(this.maskedTextBoxPlayerName);
            this.groupBoxLoadout.Controls.Add(this.labelLoadoutName);
            this.groupBoxLoadout.Controls.Add(this.btnSaveLoadout);
            this.groupBoxLoadout.Controls.Add(this.maskedTextBoxLoadoutName);
            this.groupBoxLoadout.Controls.Add(this.btnCopyLoadoutToClipboard);
            this.groupBoxLoadout.Controls.Add(this.btnImportLoadout);
            this.groupBoxLoadout.Controls.Add(this.labelExportLoadout);
            this.groupBoxLoadout.Controls.Add(this.textBoxExportLoadout);
            this.groupBoxLoadout.Controls.Add(this.maskedTextBoxImportLoadout);
            this.groupBoxLoadout.Controls.Add(this.comBoxTrapPartsSlot9Part3);
            this.groupBoxLoadout.Controls.Add(this.comBoxTrapPartsSlot9Part2);
            this.groupBoxLoadout.Controls.Add(this.comBoxTrapPartsSlot9Part1);
            this.groupBoxLoadout.Controls.Add(this.comBoxTrapPartsSlot8Part3);
            this.groupBoxLoadout.Controls.Add(this.comBoxTrapPartsSlot8Part2);
            this.groupBoxLoadout.Controls.Add(this.comBoxTrapPartsSlot8Part1);
            this.groupBoxLoadout.Controls.Add(this.comBoxTrapPartsSlot7Part3);
            this.groupBoxLoadout.Controls.Add(this.comBoxTrapPartsSlot7Part2);
            this.groupBoxLoadout.Controls.Add(this.comBoxTrapPartsSlot7Part1);
            this.groupBoxLoadout.Controls.Add(this.comBoxTrapPartsSlot6Part3);
            this.groupBoxLoadout.Controls.Add(this.comBoxTrapPartsSlot6Part2);
            this.groupBoxLoadout.Controls.Add(this.comBoxTrapPartsSlot6Part1);
            this.groupBoxLoadout.Controls.Add(this.comBoxTrapPartsSlot5Part3);
            this.groupBoxLoadout.Controls.Add(this.comBoxTrapPartsSlot5Part2);
            this.groupBoxLoadout.Controls.Add(this.comBoxTrapPartsSlot5Part1);
            this.groupBoxLoadout.Controls.Add(this.comBoxTrapPartsSlot4Part3);
            this.groupBoxLoadout.Controls.Add(this.comBoxTrapPartsSlot4Part2);
            this.groupBoxLoadout.Controls.Add(this.comBoxTrapPartsSlot4Part1);
            this.groupBoxLoadout.Controls.Add(this.comBoxTrapPartsSlot3Part3);
            this.groupBoxLoadout.Controls.Add(this.comBoxTrapPartsSlot3Part2);
            this.groupBoxLoadout.Controls.Add(this.comBoxTrapPartsSlot3Part1);
            this.groupBoxLoadout.Controls.Add(this.comBoxTrapPartsSlot2Part3);
            this.groupBoxLoadout.Controls.Add(this.comBoxTrapPartsSlot2Part2);
            this.groupBoxLoadout.Controls.Add(this.comBoxTrapPartsSlot2Part1);
            this.groupBoxLoadout.Controls.Add(this.comBoxTrapPartsSlot1Part3);
            this.groupBoxLoadout.Controls.Add(this.comBoxTrapPartsSlot1Part2);
            this.groupBoxLoadout.Controls.Add(this.comBoxTrapPartsSlot1Part1);
            this.groupBoxLoadout.Controls.Add(this.labelTraitNoBonusSlot);
            this.groupBoxLoadout.Controls.Add(this.comboxTraitYellowSlot);
            this.groupBoxLoadout.Controls.Add(this.labelTraitYellowSlot);
            this.groupBoxLoadout.Controls.Add(this.comboxTraitNoBonusSlot);
            this.groupBoxLoadout.Controls.Add(this.labelTraitBlueSlot);
            this.groupBoxLoadout.Controls.Add(this.comboxTraitGreenSlot);
            this.groupBoxLoadout.Controls.Add(this.labelTraitGreenSlot);
            this.groupBoxLoadout.Controls.Add(this.comboxTraitBlueSlot);
            this.groupBoxLoadout.Controls.Add(this.comBoxDye);
            this.groupBoxLoadout.Controls.Add(this.labelHero);
            this.groupBoxLoadout.Controls.Add(this.labelConsumableSlot2);
            this.groupBoxLoadout.Controls.Add(this.comBoxHero);
            this.groupBoxLoadout.Controls.Add(this.comBoxConsumableSlot1);
            this.groupBoxLoadout.Controls.Add(this.comBoxSkin);
            this.groupBoxLoadout.Controls.Add(this.labelConsumableSlot1);
            this.groupBoxLoadout.Controls.Add(this.labelDye);
            this.groupBoxLoadout.Controls.Add(this.comBoxConsumableSlot2);
            this.groupBoxLoadout.Controls.Add(this.labelSkin);
            this.groupBoxLoadout.Controls.Add(this.labelGuardianSlot2);
            this.groupBoxLoadout.Controls.Add(this.comBoxLoadouts);
            this.groupBoxLoadout.Controls.Add(this.labelLoadoutSlot9);
            this.groupBoxLoadout.Controls.Add(this.comBoxGuardianSlot1);
            this.groupBoxLoadout.Controls.Add(this.labelGuardianSlot1);
            this.groupBoxLoadout.Controls.Add(this.labelLoadoutSlot8);
            this.groupBoxLoadout.Controls.Add(this.comBoxGuardianSlot2);
            this.groupBoxLoadout.Controls.Add(this.labelLoadoutSlot7);
            this.groupBoxLoadout.Controls.Add(this.labelLoadoutSlot6);
            this.groupBoxLoadout.Controls.Add(this.labelLoadoutSlot5);
            this.groupBoxLoadout.Controls.Add(this.labelLoadoutSlot4);
            this.groupBoxLoadout.Controls.Add(this.labelLoadoutSlot3);
            this.groupBoxLoadout.Controls.Add(this.labelLoadoutSlot2);
            this.groupBoxLoadout.Controls.Add(this.labelLoadoutSlot1);
            this.groupBoxLoadout.Controls.Add(this.comBoxLoadoutSlot1);
            this.groupBoxLoadout.Controls.Add(this.comBoxLoadoutSlot2);
            this.groupBoxLoadout.Controls.Add(this.comBoxLoadoutSlot3);
            this.groupBoxLoadout.Controls.Add(this.comBoxLoadoutSlot9);
            this.groupBoxLoadout.Controls.Add(this.comBoxLoadoutSlot4);
            this.groupBoxLoadout.Controls.Add(this.comBoxLoadoutSlot8);
            this.groupBoxLoadout.Controls.Add(this.comBoxLoadoutSlot5);
            this.groupBoxLoadout.Controls.Add(this.comBoxLoadoutSlot7);
            this.groupBoxLoadout.Controls.Add(this.comBoxLoadoutSlot6);
            this.groupBoxLoadout.Location = new System.Drawing.Point(3, 3);
            this.groupBoxLoadout.Name = "groupBoxLoadout";
            this.groupBoxLoadout.Size = new System.Drawing.Size(568, 562);
            this.groupBoxLoadout.TabIndex = 24;
            this.groupBoxLoadout.TabStop = false;
            this.groupBoxLoadout.Text = "Loadout Editor";
            // 
            // btnDeleteLoadout
            // 
            this.btnDeleteLoadout.BackColor = System.Drawing.Color.Tomato;
            this.btnDeleteLoadout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteLoadout.Location = new System.Drawing.Point(6, 521);
            this.btnDeleteLoadout.Name = "btnDeleteLoadout";
            this.btnDeleteLoadout.Size = new System.Drawing.Size(159, 22);
            this.btnDeleteLoadout.TabIndex = 72;
            this.btnDeleteLoadout.Text = "Delete selected Loadout";
            this.btnDeleteLoadout.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeleteLoadout.UseVisualStyleBackColor = false;
            this.btnDeleteLoadout.Click += new System.EventHandler(this.btnDeleteLoadout_Click);
            // 
            // labelPlayerName
            // 
            this.labelPlayerName.AutoSize = true;
            this.labelPlayerName.Location = new System.Drawing.Point(6, 485);
            this.labelPlayerName.Name = "labelPlayerName";
            this.labelPlayerName.Size = new System.Drawing.Size(67, 13);
            this.labelPlayerName.TabIndex = 71;
            this.labelPlayerName.Text = "Player Name";
            // 
            // maskedTextBoxPlayerName
            // 
            this.maskedTextBoxPlayerName.Location = new System.Drawing.Point(79, 482);
            this.maskedTextBoxPlayerName.Name = "maskedTextBoxPlayerName";
            this.maskedTextBoxPlayerName.Size = new System.Drawing.Size(99, 20);
            this.maskedTextBoxPlayerName.TabIndex = 70;
            this.maskedTextBoxPlayerName.TextChanged += new System.EventHandler(this.maskedTextBoxPlayerName_TextChanged);
            // 
            // labelLoadoutName
            // 
            this.labelLoadoutName.AutoSize = true;
            this.labelLoadoutName.Location = new System.Drawing.Point(184, 485);
            this.labelLoadoutName.Name = "labelLoadoutName";
            this.labelLoadoutName.Size = new System.Drawing.Size(77, 13);
            this.labelLoadoutName.TabIndex = 69;
            this.labelLoadoutName.Text = "Loadout Name";
            // 
            // btnSaveLoadout
            // 
            this.btnSaveLoadout.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnSaveLoadout.Location = new System.Drawing.Point(503, 469);
            this.btnSaveLoadout.Name = "btnSaveLoadout";
            this.btnSaveLoadout.Size = new System.Drawing.Size(59, 44);
            this.btnSaveLoadout.TabIndex = 67;
            this.btnSaveLoadout.Text = "Save Loadout";
            this.btnSaveLoadout.UseVisualStyleBackColor = false;
            this.btnSaveLoadout.Click += new System.EventHandler(this.btnSaveLoadout_Click);
            // 
            // maskedTextBoxLoadoutName
            // 
            this.maskedTextBoxLoadoutName.Location = new System.Drawing.Point(267, 482);
            this.maskedTextBoxLoadoutName.Name = "maskedTextBoxLoadoutName";
            this.maskedTextBoxLoadoutName.Size = new System.Drawing.Size(230, 20);
            this.maskedTextBoxLoadoutName.TabIndex = 68;
            this.maskedTextBoxLoadoutName.TextChanged += new System.EventHandler(this.maskedTextBoxLoadoutName_TextChanged);
            // 
            // btnCopyLoadoutToClipboard
            // 
            this.btnCopyLoadoutToClipboard.Location = new System.Drawing.Point(520, 523);
            this.btnCopyLoadoutToClipboard.Name = "btnCopyLoadoutToClipboard";
            this.btnCopyLoadoutToClipboard.Size = new System.Drawing.Size(42, 20);
            this.btnCopyLoadoutToClipboard.TabIndex = 27;
            this.btnCopyLoadoutToClipboard.Text = "Copy";
            this.btnCopyLoadoutToClipboard.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCopyLoadoutToClipboard.UseVisualStyleBackColor = true;
            this.btnCopyLoadoutToClipboard.Click += new System.EventHandler(this.btnCopyLoadoutToClipboard_Click);
            // 
            // btnImportLoadout
            // 
            this.btnImportLoadout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImportLoadout.Location = new System.Drawing.Point(517, 19);
            this.btnImportLoadout.Name = "btnImportLoadout";
            this.btnImportLoadout.Size = new System.Drawing.Size(45, 20);
            this.btnImportLoadout.TabIndex = 28;
            this.btnImportLoadout.Text = "Import";
            this.btnImportLoadout.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImportLoadout.UseVisualStyleBackColor = true;
            this.btnImportLoadout.Click += new System.EventHandler(this.btnImportLoadout_Click);
            // 
            // labelExportLoadout
            // 
            this.labelExportLoadout.AutoSize = true;
            this.labelExportLoadout.Location = new System.Drawing.Point(191, 527);
            this.labelExportLoadout.Name = "labelExportLoadout";
            this.labelExportLoadout.Size = new System.Drawing.Size(37, 13);
            this.labelExportLoadout.TabIndex = 66;
            this.labelExportLoadout.Text = "Export";
            // 
            // textBoxExportLoadout
            // 
            this.textBoxExportLoadout.Location = new System.Drawing.Point(234, 523);
            this.textBoxExportLoadout.Name = "textBoxExportLoadout";
            this.textBoxExportLoadout.ReadOnly = true;
            this.textBoxExportLoadout.Size = new System.Drawing.Size(280, 20);
            this.textBoxExportLoadout.TabIndex = 65;
            // 
            // maskedTextBoxImportLoadout
            // 
            this.maskedTextBoxImportLoadout.Location = new System.Drawing.Point(314, 19);
            this.maskedTextBoxImportLoadout.Name = "maskedTextBoxImportLoadout";
            this.maskedTextBoxImportLoadout.Size = new System.Drawing.Size(200, 20);
            this.maskedTextBoxImportLoadout.TabIndex = 64;
            this.maskedTextBoxImportLoadout.TextChanged += new System.EventHandler(this.maskedTextBoxImportLoadout_TextChanged);
            // 
            // comBoxTrapPartsSlot9Part3
            // 
            this.comBoxTrapPartsSlot9Part3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxTrapPartsSlot9Part3.FormattingEnabled = true;
            this.comBoxTrapPartsSlot9Part3.Location = new System.Drawing.Point(454, 442);
            this.comBoxTrapPartsSlot9Part3.Name = "comBoxTrapPartsSlot9Part3";
            this.comBoxTrapPartsSlot9Part3.Size = new System.Drawing.Size(108, 21);
            this.comBoxTrapPartsSlot9Part3.TabIndex = 63;
            this.comBoxTrapPartsSlot9Part3.SelectedIndexChanged += new System.EventHandler(this.comBoxTrapPartsSlot9Part3_SelectedIndexChanged);
            // 
            // comBoxTrapPartsSlot9Part2
            // 
            this.comBoxTrapPartsSlot9Part2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxTrapPartsSlot9Part2.FormattingEnabled = true;
            this.comBoxTrapPartsSlot9Part2.Location = new System.Drawing.Point(344, 442);
            this.comBoxTrapPartsSlot9Part2.Name = "comBoxTrapPartsSlot9Part2";
            this.comBoxTrapPartsSlot9Part2.Size = new System.Drawing.Size(108, 21);
            this.comBoxTrapPartsSlot9Part2.TabIndex = 62;
            this.comBoxTrapPartsSlot9Part2.SelectedIndexChanged += new System.EventHandler(this.comBoxTrapPartsSlot9Part2_SelectedIndexChanged);
            // 
            // comBoxTrapPartsSlot9Part1
            // 
            this.comBoxTrapPartsSlot9Part1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxTrapPartsSlot9Part1.FormattingEnabled = true;
            this.comBoxTrapPartsSlot9Part1.Location = new System.Drawing.Point(234, 442);
            this.comBoxTrapPartsSlot9Part1.Name = "comBoxTrapPartsSlot9Part1";
            this.comBoxTrapPartsSlot9Part1.Size = new System.Drawing.Size(108, 21);
            this.comBoxTrapPartsSlot9Part1.TabIndex = 61;
            this.comBoxTrapPartsSlot9Part1.SelectedIndexChanged += new System.EventHandler(this.comBoxTrapPartsSlot9Part1_SelectedIndexChanged);
            // 
            // comBoxTrapPartsSlot8Part3
            // 
            this.comBoxTrapPartsSlot8Part3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxTrapPartsSlot8Part3.FormattingEnabled = true;
            this.comBoxTrapPartsSlot8Part3.Location = new System.Drawing.Point(454, 415);
            this.comBoxTrapPartsSlot8Part3.Name = "comBoxTrapPartsSlot8Part3";
            this.comBoxTrapPartsSlot8Part3.Size = new System.Drawing.Size(108, 21);
            this.comBoxTrapPartsSlot8Part3.TabIndex = 60;
            this.comBoxTrapPartsSlot8Part3.SelectedIndexChanged += new System.EventHandler(this.comBoxTrapPartsSlot8Part3_SelectedIndexChanged);
            // 
            // comBoxTrapPartsSlot8Part2
            // 
            this.comBoxTrapPartsSlot8Part2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxTrapPartsSlot8Part2.FormattingEnabled = true;
            this.comBoxTrapPartsSlot8Part2.Location = new System.Drawing.Point(344, 415);
            this.comBoxTrapPartsSlot8Part2.Name = "comBoxTrapPartsSlot8Part2";
            this.comBoxTrapPartsSlot8Part2.Size = new System.Drawing.Size(108, 21);
            this.comBoxTrapPartsSlot8Part2.TabIndex = 59;
            this.comBoxTrapPartsSlot8Part2.SelectedIndexChanged += new System.EventHandler(this.comBoxTrapPartsSlot8Part2_SelectedIndexChanged);
            // 
            // comBoxTrapPartsSlot8Part1
            // 
            this.comBoxTrapPartsSlot8Part1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxTrapPartsSlot8Part1.FormattingEnabled = true;
            this.comBoxTrapPartsSlot8Part1.Location = new System.Drawing.Point(234, 415);
            this.comBoxTrapPartsSlot8Part1.Name = "comBoxTrapPartsSlot8Part1";
            this.comBoxTrapPartsSlot8Part1.Size = new System.Drawing.Size(108, 21);
            this.comBoxTrapPartsSlot8Part1.TabIndex = 58;
            this.comBoxTrapPartsSlot8Part1.SelectedIndexChanged += new System.EventHandler(this.comBoxTrapPartsSlot8Part1_SelectedIndexChanged);
            // 
            // comBoxTrapPartsSlot7Part3
            // 
            this.comBoxTrapPartsSlot7Part3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxTrapPartsSlot7Part3.FormattingEnabled = true;
            this.comBoxTrapPartsSlot7Part3.Location = new System.Drawing.Point(454, 388);
            this.comBoxTrapPartsSlot7Part3.Name = "comBoxTrapPartsSlot7Part3";
            this.comBoxTrapPartsSlot7Part3.Size = new System.Drawing.Size(108, 21);
            this.comBoxTrapPartsSlot7Part3.TabIndex = 57;
            this.comBoxTrapPartsSlot7Part3.SelectedIndexChanged += new System.EventHandler(this.comBoxTrapPartsSlot7Part3_SelectedIndexChanged);
            // 
            // comBoxTrapPartsSlot7Part2
            // 
            this.comBoxTrapPartsSlot7Part2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxTrapPartsSlot7Part2.FormattingEnabled = true;
            this.comBoxTrapPartsSlot7Part2.Location = new System.Drawing.Point(344, 388);
            this.comBoxTrapPartsSlot7Part2.Name = "comBoxTrapPartsSlot7Part2";
            this.comBoxTrapPartsSlot7Part2.Size = new System.Drawing.Size(108, 21);
            this.comBoxTrapPartsSlot7Part2.TabIndex = 56;
            this.comBoxTrapPartsSlot7Part2.SelectedIndexChanged += new System.EventHandler(this.comBoxTrapPartsSlot7Part2_SelectedIndexChanged);
            // 
            // comBoxTrapPartsSlot7Part1
            // 
            this.comBoxTrapPartsSlot7Part1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxTrapPartsSlot7Part1.FormattingEnabled = true;
            this.comBoxTrapPartsSlot7Part1.Location = new System.Drawing.Point(234, 388);
            this.comBoxTrapPartsSlot7Part1.Name = "comBoxTrapPartsSlot7Part1";
            this.comBoxTrapPartsSlot7Part1.Size = new System.Drawing.Size(108, 21);
            this.comBoxTrapPartsSlot7Part1.TabIndex = 55;
            this.comBoxTrapPartsSlot7Part1.SelectedIndexChanged += new System.EventHandler(this.comBoxTrapPartsSlot7Part1_SelectedIndexChanged);
            // 
            // comBoxTrapPartsSlot6Part3
            // 
            this.comBoxTrapPartsSlot6Part3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxTrapPartsSlot6Part3.FormattingEnabled = true;
            this.comBoxTrapPartsSlot6Part3.Location = new System.Drawing.Point(454, 361);
            this.comBoxTrapPartsSlot6Part3.Name = "comBoxTrapPartsSlot6Part3";
            this.comBoxTrapPartsSlot6Part3.Size = new System.Drawing.Size(108, 21);
            this.comBoxTrapPartsSlot6Part3.TabIndex = 54;
            this.comBoxTrapPartsSlot6Part3.SelectedIndexChanged += new System.EventHandler(this.comBoxTrapPartsSlot6Part3_SelectedIndexChanged);
            // 
            // comBoxTrapPartsSlot6Part2
            // 
            this.comBoxTrapPartsSlot6Part2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxTrapPartsSlot6Part2.FormattingEnabled = true;
            this.comBoxTrapPartsSlot6Part2.Location = new System.Drawing.Point(344, 361);
            this.comBoxTrapPartsSlot6Part2.Name = "comBoxTrapPartsSlot6Part2";
            this.comBoxTrapPartsSlot6Part2.Size = new System.Drawing.Size(108, 21);
            this.comBoxTrapPartsSlot6Part2.TabIndex = 53;
            this.comBoxTrapPartsSlot6Part2.SelectedIndexChanged += new System.EventHandler(this.comBoxTrapPartsSlot6Part2_SelectedIndexChanged);
            // 
            // comBoxTrapPartsSlot6Part1
            // 
            this.comBoxTrapPartsSlot6Part1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxTrapPartsSlot6Part1.FormattingEnabled = true;
            this.comBoxTrapPartsSlot6Part1.Location = new System.Drawing.Point(234, 361);
            this.comBoxTrapPartsSlot6Part1.Name = "comBoxTrapPartsSlot6Part1";
            this.comBoxTrapPartsSlot6Part1.Size = new System.Drawing.Size(108, 21);
            this.comBoxTrapPartsSlot6Part1.TabIndex = 52;
            this.comBoxTrapPartsSlot6Part1.SelectedIndexChanged += new System.EventHandler(this.comBoxTrapPartsSlot6Part1_SelectedIndexChanged);
            // 
            // comBoxTrapPartsSlot5Part3
            // 
            this.comBoxTrapPartsSlot5Part3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxTrapPartsSlot5Part3.FormattingEnabled = true;
            this.comBoxTrapPartsSlot5Part3.Location = new System.Drawing.Point(454, 334);
            this.comBoxTrapPartsSlot5Part3.Name = "comBoxTrapPartsSlot5Part3";
            this.comBoxTrapPartsSlot5Part3.Size = new System.Drawing.Size(108, 21);
            this.comBoxTrapPartsSlot5Part3.TabIndex = 51;
            this.comBoxTrapPartsSlot5Part3.SelectedIndexChanged += new System.EventHandler(this.comBoxTrapPartsSlot5Part3_SelectedIndexChanged);
            // 
            // comBoxTrapPartsSlot5Part2
            // 
            this.comBoxTrapPartsSlot5Part2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxTrapPartsSlot5Part2.FormattingEnabled = true;
            this.comBoxTrapPartsSlot5Part2.Location = new System.Drawing.Point(344, 334);
            this.comBoxTrapPartsSlot5Part2.Name = "comBoxTrapPartsSlot5Part2";
            this.comBoxTrapPartsSlot5Part2.Size = new System.Drawing.Size(108, 21);
            this.comBoxTrapPartsSlot5Part2.TabIndex = 50;
            this.comBoxTrapPartsSlot5Part2.SelectedIndexChanged += new System.EventHandler(this.comBoxTrapPartsSlot5Part2_SelectedIndexChanged);
            // 
            // comBoxTrapPartsSlot5Part1
            // 
            this.comBoxTrapPartsSlot5Part1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxTrapPartsSlot5Part1.FormattingEnabled = true;
            this.comBoxTrapPartsSlot5Part1.Location = new System.Drawing.Point(234, 334);
            this.comBoxTrapPartsSlot5Part1.Name = "comBoxTrapPartsSlot5Part1";
            this.comBoxTrapPartsSlot5Part1.Size = new System.Drawing.Size(108, 21);
            this.comBoxTrapPartsSlot5Part1.TabIndex = 49;
            this.comBoxTrapPartsSlot5Part1.SelectedIndexChanged += new System.EventHandler(this.comBoxTrapPartsSlot5Part1_SelectedIndexChanged);
            // 
            // comBoxTrapPartsSlot4Part3
            // 
            this.comBoxTrapPartsSlot4Part3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxTrapPartsSlot4Part3.FormattingEnabled = true;
            this.comBoxTrapPartsSlot4Part3.Location = new System.Drawing.Point(454, 307);
            this.comBoxTrapPartsSlot4Part3.Name = "comBoxTrapPartsSlot4Part3";
            this.comBoxTrapPartsSlot4Part3.Size = new System.Drawing.Size(108, 21);
            this.comBoxTrapPartsSlot4Part3.TabIndex = 48;
            this.comBoxTrapPartsSlot4Part3.SelectedIndexChanged += new System.EventHandler(this.comBoxTrapPartsSlot4Part3_SelectedIndexChanged);
            // 
            // comBoxTrapPartsSlot4Part2
            // 
            this.comBoxTrapPartsSlot4Part2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxTrapPartsSlot4Part2.FormattingEnabled = true;
            this.comBoxTrapPartsSlot4Part2.Location = new System.Drawing.Point(344, 307);
            this.comBoxTrapPartsSlot4Part2.Name = "comBoxTrapPartsSlot4Part2";
            this.comBoxTrapPartsSlot4Part2.Size = new System.Drawing.Size(108, 21);
            this.comBoxTrapPartsSlot4Part2.TabIndex = 47;
            this.comBoxTrapPartsSlot4Part2.SelectedIndexChanged += new System.EventHandler(this.comBoxTrapPartsSlot4Part2_SelectedIndexChanged);
            // 
            // comBoxTrapPartsSlot4Part1
            // 
            this.comBoxTrapPartsSlot4Part1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxTrapPartsSlot4Part1.FormattingEnabled = true;
            this.comBoxTrapPartsSlot4Part1.Location = new System.Drawing.Point(234, 307);
            this.comBoxTrapPartsSlot4Part1.Name = "comBoxTrapPartsSlot4Part1";
            this.comBoxTrapPartsSlot4Part1.Size = new System.Drawing.Size(108, 21);
            this.comBoxTrapPartsSlot4Part1.TabIndex = 46;
            this.comBoxTrapPartsSlot4Part1.SelectedIndexChanged += new System.EventHandler(this.comBoxTrapPartsSlot4Part1_SelectedIndexChanged);
            // 
            // comBoxTrapPartsSlot3Part3
            // 
            this.comBoxTrapPartsSlot3Part3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxTrapPartsSlot3Part3.FormattingEnabled = true;
            this.comBoxTrapPartsSlot3Part3.Location = new System.Drawing.Point(454, 280);
            this.comBoxTrapPartsSlot3Part3.Name = "comBoxTrapPartsSlot3Part3";
            this.comBoxTrapPartsSlot3Part3.Size = new System.Drawing.Size(108, 21);
            this.comBoxTrapPartsSlot3Part3.TabIndex = 45;
            this.comBoxTrapPartsSlot3Part3.SelectedIndexChanged += new System.EventHandler(this.comBoxTrapPartsSlot3Part3_SelectedIndexChanged);
            // 
            // comBoxTrapPartsSlot3Part2
            // 
            this.comBoxTrapPartsSlot3Part2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxTrapPartsSlot3Part2.FormattingEnabled = true;
            this.comBoxTrapPartsSlot3Part2.Location = new System.Drawing.Point(344, 280);
            this.comBoxTrapPartsSlot3Part2.Name = "comBoxTrapPartsSlot3Part2";
            this.comBoxTrapPartsSlot3Part2.Size = new System.Drawing.Size(108, 21);
            this.comBoxTrapPartsSlot3Part2.TabIndex = 44;
            this.comBoxTrapPartsSlot3Part2.SelectedIndexChanged += new System.EventHandler(this.comBoxTrapPartsSlot3Part2_SelectedIndexChanged);
            // 
            // comBoxTrapPartsSlot3Part1
            // 
            this.comBoxTrapPartsSlot3Part1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxTrapPartsSlot3Part1.FormattingEnabled = true;
            this.comBoxTrapPartsSlot3Part1.Location = new System.Drawing.Point(234, 280);
            this.comBoxTrapPartsSlot3Part1.Name = "comBoxTrapPartsSlot3Part1";
            this.comBoxTrapPartsSlot3Part1.Size = new System.Drawing.Size(108, 21);
            this.comBoxTrapPartsSlot3Part1.TabIndex = 43;
            this.comBoxTrapPartsSlot3Part1.SelectedIndexChanged += new System.EventHandler(this.comBoxTrapPartsSlot3Part1_SelectedIndexChanged);
            // 
            // comBoxTrapPartsSlot2Part3
            // 
            this.comBoxTrapPartsSlot2Part3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxTrapPartsSlot2Part3.FormattingEnabled = true;
            this.comBoxTrapPartsSlot2Part3.Location = new System.Drawing.Point(454, 253);
            this.comBoxTrapPartsSlot2Part3.Name = "comBoxTrapPartsSlot2Part3";
            this.comBoxTrapPartsSlot2Part3.Size = new System.Drawing.Size(108, 21);
            this.comBoxTrapPartsSlot2Part3.TabIndex = 42;
            this.comBoxTrapPartsSlot2Part3.SelectedIndexChanged += new System.EventHandler(this.comBoxTrapPartsSlot2Part3_SelectedIndexChanged);
            // 
            // comBoxTrapPartsSlot2Part2
            // 
            this.comBoxTrapPartsSlot2Part2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxTrapPartsSlot2Part2.FormattingEnabled = true;
            this.comBoxTrapPartsSlot2Part2.Location = new System.Drawing.Point(344, 253);
            this.comBoxTrapPartsSlot2Part2.Name = "comBoxTrapPartsSlot2Part2";
            this.comBoxTrapPartsSlot2Part2.Size = new System.Drawing.Size(108, 21);
            this.comBoxTrapPartsSlot2Part2.TabIndex = 41;
            this.comBoxTrapPartsSlot2Part2.SelectedIndexChanged += new System.EventHandler(this.comBoxTrapPartsSlot2Part2_SelectedIndexChanged);
            // 
            // comBoxTrapPartsSlot2Part1
            // 
            this.comBoxTrapPartsSlot2Part1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxTrapPartsSlot2Part1.FormattingEnabled = true;
            this.comBoxTrapPartsSlot2Part1.Location = new System.Drawing.Point(234, 253);
            this.comBoxTrapPartsSlot2Part1.Name = "comBoxTrapPartsSlot2Part1";
            this.comBoxTrapPartsSlot2Part1.Size = new System.Drawing.Size(108, 21);
            this.comBoxTrapPartsSlot2Part1.TabIndex = 40;
            this.comBoxTrapPartsSlot2Part1.SelectedIndexChanged += new System.EventHandler(this.comBoxTrapPartsSlot2Part1_SelectedIndexChanged);
            // 
            // comBoxTrapPartsSlot1Part3
            // 
            this.comBoxTrapPartsSlot1Part3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxTrapPartsSlot1Part3.FormattingEnabled = true;
            this.comBoxTrapPartsSlot1Part3.Location = new System.Drawing.Point(454, 226);
            this.comBoxTrapPartsSlot1Part3.Name = "comBoxTrapPartsSlot1Part3";
            this.comBoxTrapPartsSlot1Part3.Size = new System.Drawing.Size(108, 21);
            this.comBoxTrapPartsSlot1Part3.TabIndex = 39;
            this.comBoxTrapPartsSlot1Part3.SelectedIndexChanged += new System.EventHandler(this.comBoxTrapPartsSlot1Part3_SelectedIndexChanged);
            // 
            // comBoxTrapPartsSlot1Part2
            // 
            this.comBoxTrapPartsSlot1Part2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxTrapPartsSlot1Part2.FormattingEnabled = true;
            this.comBoxTrapPartsSlot1Part2.Location = new System.Drawing.Point(344, 226);
            this.comBoxTrapPartsSlot1Part2.Name = "comBoxTrapPartsSlot1Part2";
            this.comBoxTrapPartsSlot1Part2.Size = new System.Drawing.Size(108, 21);
            this.comBoxTrapPartsSlot1Part2.TabIndex = 38;
            this.comBoxTrapPartsSlot1Part2.SelectedIndexChanged += new System.EventHandler(this.comBoxTrapPartsSlot1Part2_SelectedIndexChanged);
            // 
            // comBoxTrapPartsSlot1Part1
            // 
            this.comBoxTrapPartsSlot1Part1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxTrapPartsSlot1Part1.FormattingEnabled = true;
            this.comBoxTrapPartsSlot1Part1.Location = new System.Drawing.Point(234, 226);
            this.comBoxTrapPartsSlot1Part1.Name = "comBoxTrapPartsSlot1Part1";
            this.comBoxTrapPartsSlot1Part1.Size = new System.Drawing.Size(108, 21);
            this.comBoxTrapPartsSlot1Part1.TabIndex = 37;
            this.comBoxTrapPartsSlot1Part1.SelectedIndexChanged += new System.EventHandler(this.comBoxTrapPartsSlot1Part1_SelectedIndexChanged);
            // 
            // labelTraitNoBonusSlot
            // 
            this.labelTraitNoBonusSlot.AutoSize = true;
            this.labelTraitNoBonusSlot.Location = new System.Drawing.Point(278, 186);
            this.labelTraitNoBonusSlot.Name = "labelTraitNoBonusSlot";
            this.labelTraitNoBonusSlot.Size = new System.Drawing.Size(78, 13);
            this.labelTraitNoBonusSlot.TabIndex = 35;
            this.labelTraitNoBonusSlot.Text = "No Bonus Trait";
            // 
            // comboxTraitYellowSlot
            // 
            this.comboxTraitYellowSlot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxTraitYellowSlot.FormattingEnabled = true;
            this.comboxTraitYellowSlot.Location = new System.Drawing.Point(362, 101);
            this.comboxTraitYellowSlot.Name = "comboxTraitYellowSlot";
            this.comboxTraitYellowSlot.Size = new System.Drawing.Size(200, 21);
            this.comboxTraitYellowSlot.TabIndex = 32;
            this.comboxTraitYellowSlot.SelectedIndexChanged += new System.EventHandler(this.comboxTraitYellowSlot_SelectedIndexChanged);
            // 
            // labelTraitYellowSlot
            // 
            this.labelTraitYellowSlot.AutoSize = true;
            this.labelTraitYellowSlot.BackColor = System.Drawing.Color.Gold;
            this.labelTraitYellowSlot.Location = new System.Drawing.Point(278, 105);
            this.labelTraitYellowSlot.Name = "labelTraitYellowSlot";
            this.labelTraitYellowSlot.Size = new System.Drawing.Size(69, 13);
            this.labelTraitYellowSlot.TabIndex = 34;
            this.labelTraitYellowSlot.Text = "Triangle Trait";
            // 
            // comboxTraitNoBonusSlot
            // 
            this.comboxTraitNoBonusSlot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxTraitNoBonusSlot.FormattingEnabled = true;
            this.comboxTraitNoBonusSlot.Location = new System.Drawing.Point(362, 182);
            this.comboxTraitNoBonusSlot.Name = "comboxTraitNoBonusSlot";
            this.comboxTraitNoBonusSlot.Size = new System.Drawing.Size(200, 21);
            this.comboxTraitNoBonusSlot.TabIndex = 33;
            this.comboxTraitNoBonusSlot.SelectedIndexChanged += new System.EventHandler(this.comboxTraitNoBonusSlot_SelectedIndexChanged);
            // 
            // labelTraitBlueSlot
            // 
            this.labelTraitBlueSlot.AutoSize = true;
            this.labelTraitBlueSlot.BackColor = System.Drawing.Color.LightSkyBlue;
            this.labelTraitBlueSlot.Location = new System.Drawing.Point(278, 159);
            this.labelTraitBlueSlot.Name = "labelTraitBlueSlot";
            this.labelTraitBlueSlot.Size = new System.Drawing.Size(73, 13);
            this.labelTraitBlueSlot.TabIndex = 31;
            this.labelTraitBlueSlot.Text = "Diamond Trait";
            // 
            // comboxTraitGreenSlot
            // 
            this.comboxTraitGreenSlot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxTraitGreenSlot.FormattingEnabled = true;
            this.comboxTraitGreenSlot.Location = new System.Drawing.Point(362, 128);
            this.comboxTraitGreenSlot.Name = "comboxTraitGreenSlot";
            this.comboxTraitGreenSlot.Size = new System.Drawing.Size(200, 21);
            this.comboxTraitGreenSlot.TabIndex = 28;
            this.comboxTraitGreenSlot.SelectedIndexChanged += new System.EventHandler(this.comboxTraitGreenSlot_SelectedIndexChanged);
            // 
            // labelTraitGreenSlot
            // 
            this.labelTraitGreenSlot.AutoSize = true;
            this.labelTraitGreenSlot.BackColor = System.Drawing.Color.LightGreen;
            this.labelTraitGreenSlot.Location = new System.Drawing.Point(278, 132);
            this.labelTraitGreenSlot.Name = "labelTraitGreenSlot";
            this.labelTraitGreenSlot.Size = new System.Drawing.Size(77, 13);
            this.labelTraitGreenSlot.TabIndex = 30;
            this.labelTraitGreenSlot.Text = "Pentagon Trait";
            // 
            // comboxTraitBlueSlot
            // 
            this.comboxTraitBlueSlot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxTraitBlueSlot.FormattingEnabled = true;
            this.comboxTraitBlueSlot.Location = new System.Drawing.Point(362, 155);
            this.comboxTraitBlueSlot.Name = "comboxTraitBlueSlot";
            this.comboxTraitBlueSlot.Size = new System.Drawing.Size(200, 21);
            this.comboxTraitBlueSlot.TabIndex = 29;
            this.comboxTraitBlueSlot.SelectedIndexChanged += new System.EventHandler(this.comboxTraitBlueSlot_SelectedIndexChanged);
            // 
            // comBoxDye
            // 
            this.comBoxDye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxDye.FormattingEnabled = true;
            this.comBoxDye.Location = new System.Drawing.Point(451, 60);
            this.comBoxDye.Name = "comBoxDye";
            this.comBoxDye.Size = new System.Drawing.Size(111, 21);
            this.comBoxDye.TabIndex = 6;
            this.comBoxDye.SelectedIndexChanged += new System.EventHandler(this.comBoxDye_SelectedIndexChanged);
            // 
            // labelHero
            // 
            this.labelHero.AutoSize = true;
            this.labelHero.Location = new System.Drawing.Point(6, 63);
            this.labelHero.Name = "labelHero";
            this.labelHero.Size = new System.Drawing.Size(30, 13);
            this.labelHero.TabIndex = 1;
            this.labelHero.Text = "Hero";
            // 
            // labelConsumableSlot2
            // 
            this.labelConsumableSlot2.AutoSize = true;
            this.labelConsumableSlot2.Location = new System.Drawing.Point(5, 185);
            this.labelConsumableSlot2.Name = "labelConsumableSlot2";
            this.labelConsumableSlot2.Size = new System.Drawing.Size(74, 13);
            this.labelConsumableSlot2.TabIndex = 27;
            this.labelConsumableSlot2.Text = "Consumable 2";
            // 
            // comBoxHero
            // 
            this.comBoxHero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxHero.FormattingEnabled = true;
            this.comBoxHero.Location = new System.Drawing.Point(42, 60);
            this.comBoxHero.Name = "comBoxHero";
            this.comBoxHero.Size = new System.Drawing.Size(126, 21);
            this.comBoxHero.TabIndex = 2;
            this.comBoxHero.SelectedIndexChanged += new System.EventHandler(this.comBoxHero_SelectedIndexChanged);
            // 
            // comBoxConsumableSlot1
            // 
            this.comBoxConsumableSlot1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxConsumableSlot1.FormattingEnabled = true;
            this.comBoxConsumableSlot1.Location = new System.Drawing.Point(85, 155);
            this.comBoxConsumableSlot1.Name = "comBoxConsumableSlot1";
            this.comBoxConsumableSlot1.Size = new System.Drawing.Size(176, 21);
            this.comBoxConsumableSlot1.TabIndex = 24;
            this.comBoxConsumableSlot1.SelectedIndexChanged += new System.EventHandler(this.comBoxConsumableSlot1_SelectedIndexChanged);
            // 
            // comBoxSkin
            // 
            this.comBoxSkin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxSkin.FormattingEnabled = true;
            this.comBoxSkin.Location = new System.Drawing.Point(210, 60);
            this.comBoxSkin.Name = "comBoxSkin";
            this.comBoxSkin.Size = new System.Drawing.Size(190, 21);
            this.comBoxSkin.TabIndex = 4;
            this.comBoxSkin.SelectedIndexChanged += new System.EventHandler(this.comBoxSkin_SelectedIndexChanged);
            // 
            // labelConsumableSlot1
            // 
            this.labelConsumableSlot1.AutoSize = true;
            this.labelConsumableSlot1.Location = new System.Drawing.Point(5, 158);
            this.labelConsumableSlot1.Name = "labelConsumableSlot1";
            this.labelConsumableSlot1.Size = new System.Drawing.Size(74, 13);
            this.labelConsumableSlot1.TabIndex = 26;
            this.labelConsumableSlot1.Text = "Consumable 1";
            // 
            // labelDye
            // 
            this.labelDye.AutoSize = true;
            this.labelDye.Location = new System.Drawing.Point(419, 63);
            this.labelDye.Name = "labelDye";
            this.labelDye.Size = new System.Drawing.Size(26, 13);
            this.labelDye.TabIndex = 5;
            this.labelDye.Text = "Dye";
            // 
            // comBoxConsumableSlot2
            // 
            this.comBoxConsumableSlot2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxConsumableSlot2.FormattingEnabled = true;
            this.comBoxConsumableSlot2.Location = new System.Drawing.Point(85, 182);
            this.comBoxConsumableSlot2.Name = "comBoxConsumableSlot2";
            this.comBoxConsumableSlot2.Size = new System.Drawing.Size(176, 21);
            this.comBoxConsumableSlot2.TabIndex = 25;
            this.comBoxConsumableSlot2.SelectedIndexChanged += new System.EventHandler(this.comBoxConsumableSlot2_SelectedIndexChanged);
            // 
            // labelSkin
            // 
            this.labelSkin.AutoSize = true;
            this.labelSkin.Location = new System.Drawing.Point(176, 63);
            this.labelSkin.Name = "labelSkin";
            this.labelSkin.Size = new System.Drawing.Size(28, 13);
            this.labelSkin.TabIndex = 3;
            this.labelSkin.Text = "Skin";
            // 
            // labelGuardianSlot2
            // 
            this.labelGuardianSlot2.AutoSize = true;
            this.labelGuardianSlot2.Location = new System.Drawing.Point(5, 131);
            this.labelGuardianSlot2.Name = "labelGuardianSlot2";
            this.labelGuardianSlot2.Size = new System.Drawing.Size(59, 13);
            this.labelGuardianSlot2.TabIndex = 21;
            this.labelGuardianSlot2.Text = "Guardian 2";
            // 
            // comBoxLoadouts
            // 
            this.comBoxLoadouts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxLoadouts.FormattingEnabled = true;
            this.comBoxLoadouts.Location = new System.Drawing.Point(9, 19);
            this.comBoxLoadouts.Name = "comBoxLoadouts";
            this.comBoxLoadouts.Size = new System.Drawing.Size(252, 21);
            this.comBoxLoadouts.TabIndex = 23;
            this.comBoxLoadouts.SelectedIndexChanged += new System.EventHandler(this.comBoxLoadouts_SelectedIndexChanged);
            // 
            // labelLoadoutSlot9
            // 
            this.labelLoadoutSlot9.AutoSize = true;
            this.labelLoadoutSlot9.Location = new System.Drawing.Point(5, 445);
            this.labelLoadoutSlot9.Name = "labelLoadoutSlot9";
            this.labelLoadoutSlot9.Size = new System.Drawing.Size(34, 13);
            this.labelLoadoutSlot9.TabIndex = 17;
            this.labelLoadoutSlot9.Text = "Slot 9";
            // 
            // comBoxGuardianSlot1
            // 
            this.comBoxGuardianSlot1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxGuardianSlot1.FormattingEnabled = true;
            this.comBoxGuardianSlot1.Location = new System.Drawing.Point(70, 101);
            this.comBoxGuardianSlot1.Name = "comBoxGuardianSlot1";
            this.comBoxGuardianSlot1.Size = new System.Drawing.Size(191, 21);
            this.comBoxGuardianSlot1.TabIndex = 18;
            this.comBoxGuardianSlot1.SelectedIndexChanged += new System.EventHandler(this.comBoxGuardianSlot1_SelectedIndexChanged);
            // 
            // labelGuardianSlot1
            // 
            this.labelGuardianSlot1.AutoSize = true;
            this.labelGuardianSlot1.Location = new System.Drawing.Point(5, 104);
            this.labelGuardianSlot1.Name = "labelGuardianSlot1";
            this.labelGuardianSlot1.Size = new System.Drawing.Size(59, 13);
            this.labelGuardianSlot1.TabIndex = 20;
            this.labelGuardianSlot1.Text = "Guardian 1";
            // 
            // labelLoadoutSlot8
            // 
            this.labelLoadoutSlot8.AutoSize = true;
            this.labelLoadoutSlot8.Location = new System.Drawing.Point(5, 418);
            this.labelLoadoutSlot8.Name = "labelLoadoutSlot8";
            this.labelLoadoutSlot8.Size = new System.Drawing.Size(34, 13);
            this.labelLoadoutSlot8.TabIndex = 16;
            this.labelLoadoutSlot8.Text = "Slot 8";
            // 
            // comBoxGuardianSlot2
            // 
            this.comBoxGuardianSlot2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxGuardianSlot2.FormattingEnabled = true;
            this.comBoxGuardianSlot2.Location = new System.Drawing.Point(70, 128);
            this.comBoxGuardianSlot2.Name = "comBoxGuardianSlot2";
            this.comBoxGuardianSlot2.Size = new System.Drawing.Size(191, 21);
            this.comBoxGuardianSlot2.TabIndex = 19;
            this.comBoxGuardianSlot2.SelectedIndexChanged += new System.EventHandler(this.comBoxGuardianSlot2_SelectedIndexChanged);
            // 
            // labelLoadoutSlot7
            // 
            this.labelLoadoutSlot7.AutoSize = true;
            this.labelLoadoutSlot7.Location = new System.Drawing.Point(5, 391);
            this.labelLoadoutSlot7.Name = "labelLoadoutSlot7";
            this.labelLoadoutSlot7.Size = new System.Drawing.Size(34, 13);
            this.labelLoadoutSlot7.TabIndex = 15;
            this.labelLoadoutSlot7.Text = "Slot 7";
            // 
            // labelLoadoutSlot6
            // 
            this.labelLoadoutSlot6.AutoSize = true;
            this.labelLoadoutSlot6.Location = new System.Drawing.Point(5, 364);
            this.labelLoadoutSlot6.Name = "labelLoadoutSlot6";
            this.labelLoadoutSlot6.Size = new System.Drawing.Size(34, 13);
            this.labelLoadoutSlot6.TabIndex = 14;
            this.labelLoadoutSlot6.Text = "Slot 6";
            // 
            // labelLoadoutSlot5
            // 
            this.labelLoadoutSlot5.AutoSize = true;
            this.labelLoadoutSlot5.Location = new System.Drawing.Point(5, 337);
            this.labelLoadoutSlot5.Name = "labelLoadoutSlot5";
            this.labelLoadoutSlot5.Size = new System.Drawing.Size(34, 13);
            this.labelLoadoutSlot5.TabIndex = 13;
            this.labelLoadoutSlot5.Text = "Slot 5";
            // 
            // labelLoadoutSlot4
            // 
            this.labelLoadoutSlot4.AutoSize = true;
            this.labelLoadoutSlot4.Location = new System.Drawing.Point(5, 310);
            this.labelLoadoutSlot4.Name = "labelLoadoutSlot4";
            this.labelLoadoutSlot4.Size = new System.Drawing.Size(34, 13);
            this.labelLoadoutSlot4.TabIndex = 12;
            this.labelLoadoutSlot4.Text = "Slot 4";
            // 
            // labelLoadoutSlot3
            // 
            this.labelLoadoutSlot3.AutoSize = true;
            this.labelLoadoutSlot3.Location = new System.Drawing.Point(5, 283);
            this.labelLoadoutSlot3.Name = "labelLoadoutSlot3";
            this.labelLoadoutSlot3.Size = new System.Drawing.Size(34, 13);
            this.labelLoadoutSlot3.TabIndex = 11;
            this.labelLoadoutSlot3.Text = "Slot 3";
            // 
            // labelLoadoutSlot2
            // 
            this.labelLoadoutSlot2.AutoSize = true;
            this.labelLoadoutSlot2.Location = new System.Drawing.Point(5, 256);
            this.labelLoadoutSlot2.Name = "labelLoadoutSlot2";
            this.labelLoadoutSlot2.Size = new System.Drawing.Size(34, 13);
            this.labelLoadoutSlot2.TabIndex = 10;
            this.labelLoadoutSlot2.Text = "Slot 2";
            // 
            // labelLoadoutSlot1
            // 
            this.labelLoadoutSlot1.AutoSize = true;
            this.labelLoadoutSlot1.Location = new System.Drawing.Point(5, 229);
            this.labelLoadoutSlot1.Name = "labelLoadoutSlot1";
            this.labelLoadoutSlot1.Size = new System.Drawing.Size(34, 13);
            this.labelLoadoutSlot1.TabIndex = 9;
            this.labelLoadoutSlot1.Text = "Slot 1";
            // 
            // comBoxLoadoutSlot1
            // 
            this.comBoxLoadoutSlot1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxLoadoutSlot1.FormattingEnabled = true;
            this.comBoxLoadoutSlot1.Location = new System.Drawing.Point(45, 226);
            this.comBoxLoadoutSlot1.Name = "comBoxLoadoutSlot1";
            this.comBoxLoadoutSlot1.Size = new System.Drawing.Size(159, 21);
            this.comBoxLoadoutSlot1.TabIndex = 0;
            this.comBoxLoadoutSlot1.SelectedIndexChanged += new System.EventHandler(this.comBoxLoadoutSlot1_SelectedIndexChanged);
            // 
            // comBoxLoadoutSlot2
            // 
            this.comBoxLoadoutSlot2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxLoadoutSlot2.FormattingEnabled = true;
            this.comBoxLoadoutSlot2.Location = new System.Drawing.Point(45, 253);
            this.comBoxLoadoutSlot2.Name = "comBoxLoadoutSlot2";
            this.comBoxLoadoutSlot2.Size = new System.Drawing.Size(159, 21);
            this.comBoxLoadoutSlot2.TabIndex = 1;
            this.comBoxLoadoutSlot2.SelectedIndexChanged += new System.EventHandler(this.comBoxLoadoutSlot2_SelectedIndexChanged);
            // 
            // comBoxLoadoutSlot3
            // 
            this.comBoxLoadoutSlot3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxLoadoutSlot3.FormattingEnabled = true;
            this.comBoxLoadoutSlot3.Location = new System.Drawing.Point(45, 280);
            this.comBoxLoadoutSlot3.Name = "comBoxLoadoutSlot3";
            this.comBoxLoadoutSlot3.Size = new System.Drawing.Size(159, 21);
            this.comBoxLoadoutSlot3.TabIndex = 2;
            this.comBoxLoadoutSlot3.SelectedIndexChanged += new System.EventHandler(this.comBoxLoadoutSlot3_SelectedIndexChanged);
            // 
            // comBoxLoadoutSlot9
            // 
            this.comBoxLoadoutSlot9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxLoadoutSlot9.FormattingEnabled = true;
            this.comBoxLoadoutSlot9.Location = new System.Drawing.Point(45, 442);
            this.comBoxLoadoutSlot9.Name = "comBoxLoadoutSlot9";
            this.comBoxLoadoutSlot9.Size = new System.Drawing.Size(159, 21);
            this.comBoxLoadoutSlot9.TabIndex = 8;
            this.comBoxLoadoutSlot9.SelectedIndexChanged += new System.EventHandler(this.comBoxLoadoutSlot9_SelectedIndexChanged);
            // 
            // comBoxLoadoutSlot4
            // 
            this.comBoxLoadoutSlot4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxLoadoutSlot4.FormattingEnabled = true;
            this.comBoxLoadoutSlot4.Location = new System.Drawing.Point(45, 307);
            this.comBoxLoadoutSlot4.Name = "comBoxLoadoutSlot4";
            this.comBoxLoadoutSlot4.Size = new System.Drawing.Size(159, 21);
            this.comBoxLoadoutSlot4.TabIndex = 3;
            this.comBoxLoadoutSlot4.SelectedIndexChanged += new System.EventHandler(this.comBoxLoadoutSlot4_SelectedIndexChanged);
            // 
            // comBoxLoadoutSlot8
            // 
            this.comBoxLoadoutSlot8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxLoadoutSlot8.FormattingEnabled = true;
            this.comBoxLoadoutSlot8.Location = new System.Drawing.Point(45, 415);
            this.comBoxLoadoutSlot8.Name = "comBoxLoadoutSlot8";
            this.comBoxLoadoutSlot8.Size = new System.Drawing.Size(159, 21);
            this.comBoxLoadoutSlot8.TabIndex = 7;
            this.comBoxLoadoutSlot8.SelectedIndexChanged += new System.EventHandler(this.comBoxLoadoutSlot8_SelectedIndexChanged);
            // 
            // comBoxLoadoutSlot5
            // 
            this.comBoxLoadoutSlot5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxLoadoutSlot5.FormattingEnabled = true;
            this.comBoxLoadoutSlot5.Location = new System.Drawing.Point(45, 334);
            this.comBoxLoadoutSlot5.Name = "comBoxLoadoutSlot5";
            this.comBoxLoadoutSlot5.Size = new System.Drawing.Size(159, 21);
            this.comBoxLoadoutSlot5.TabIndex = 4;
            this.comBoxLoadoutSlot5.SelectedIndexChanged += new System.EventHandler(this.comBoxLoadoutSlot5_SelectedIndexChanged);
            // 
            // comBoxLoadoutSlot7
            // 
            this.comBoxLoadoutSlot7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxLoadoutSlot7.FormattingEnabled = true;
            this.comBoxLoadoutSlot7.Location = new System.Drawing.Point(45, 388);
            this.comBoxLoadoutSlot7.Name = "comBoxLoadoutSlot7";
            this.comBoxLoadoutSlot7.Size = new System.Drawing.Size(159, 21);
            this.comBoxLoadoutSlot7.TabIndex = 6;
            this.comBoxLoadoutSlot7.SelectedIndexChanged += new System.EventHandler(this.comBoxLoadoutSlot7_SelectedIndexChanged);
            // 
            // comBoxLoadoutSlot6
            // 
            this.comBoxLoadoutSlot6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxLoadoutSlot6.FormattingEnabled = true;
            this.comBoxLoadoutSlot6.Location = new System.Drawing.Point(45, 361);
            this.comBoxLoadoutSlot6.Name = "comBoxLoadoutSlot6";
            this.comBoxLoadoutSlot6.Size = new System.Drawing.Size(159, 21);
            this.comBoxLoadoutSlot6.TabIndex = 5;
            this.comBoxLoadoutSlot6.SelectedIndexChanged += new System.EventHandler(this.comBoxLoadoutSlot6_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnDiscord);
            this.panel1.Controls.Add(this.chkDebug);
            this.panel1.Controls.Add(this.chkRunAs32);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.btnResetConfig);
            this.panel1.Controls.Add(this.gameSettingsGroupBox);
            this.panel1.Controls.Add(this.mapSettingsGroupBox);
            this.panel1.Location = new System.Drawing.Point(577, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 588);
            this.panel1.TabIndex = 93;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxLoadout, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.modsPanel, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1279, 594);
            this.tableLayoutPanel1.TabIndex = 94;
            // 
            // LauncherMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1328, 671);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelLoadoutEditor);
            this.Name = "LauncherMainForm";
            this.Text = "Project Rechained Launcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mapSettingsGroupBox.ResumeLayout(false);
            this.mapSettingsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startingCoinInput)).EndInit();
            this.modsGroupBox.ResumeLayout(false);
            this.modsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.modsPanel.ResumeLayout(false);
            this.gameSettingsGroupBox.ResumeLayout(false);
            this.gameSettingsGroupBox.PerformLayout();
            this.groupBoxLoadout.ResumeLayout(false);
            this.groupBoxLoadout.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.ComboBox comBoxBattleground;
        private System.Windows.Forms.Label labelMap;
        private System.Windows.Forms.CheckBox chkDebug;
        private System.Windows.Forms.GroupBox mapSettingsGroupBox;
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
        private TabControl tabControl1;
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
        private Button btnSaveLoadout;
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
    }
}

