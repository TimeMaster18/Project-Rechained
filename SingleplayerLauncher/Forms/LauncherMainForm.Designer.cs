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
            this.btnLaunch = new System.Windows.Forms.Button();
            this.chkDebug = new System.Windows.Forms.CheckBox();
            this.characterSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.comBoxDye = new System.Windows.Forms.ComboBox();
            this.labelHero = new System.Windows.Forms.Label();
            this.comBoxHero = new System.Windows.Forms.ComboBox();
            this.comBoxSkin = new System.Windows.Forms.ComboBox();
            this.labelDye = new System.Windows.Forms.Label();
            this.labelSkin = new System.Windows.Forms.Label();
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
            this.labelGuardianSlot1 = new System.Windows.Forms.Label();
            this.comBoxGuardianSlot1 = new System.Windows.Forms.ComboBox();
            this.labelGuardianSlot2 = new System.Windows.Forms.Label();
            this.comBoxGuardianSlot2 = new System.Windows.Forms.ComboBox();
            this.groupBoxLoadout = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelLoadoutSlot9 = new System.Windows.Forms.Label();
            this.labelLoadoutSlot8 = new System.Windows.Forms.Label();
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
            this.chk_modsEnabled = new System.Windows.Forms.CheckBox();
            this.chkRunAs32 = new System.Windows.Forms.CheckBox();
            this.comBoxLanguage = new System.Windows.Forms.ComboBox();
            this.labelLanguage = new System.Windows.Forms.Label();
            this.characterSettingsGroupBox.SuspendLayout();
            this.mapSettingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startingCoinInput)).BeginInit();
            this.modsGroupBox.SuspendLayout();
            this.groupBoxLoadout.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLaunch
            // 
            this.btnLaunch.BackColor = System.Drawing.Color.SpringGreen;
            this.btnLaunch.Location = new System.Drawing.Point(395, 438);
            this.btnLaunch.Margin = new System.Windows.Forms.Padding(4);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(455, 92);
            this.btnLaunch.TabIndex = 0;
            this.btnLaunch.Text = "Launch";
            this.btnLaunch.UseVisualStyleBackColor = false;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // chkDebug
            // 
            this.chkDebug.AutoSize = true;
            this.chkDebug.Location = new System.Drawing.Point(657, 542);
            this.chkDebug.Margin = new System.Windows.Forms.Padding(4);
            this.chkDebug.Name = "chkDebug";
            this.chkDebug.Size = new System.Drawing.Size(67, 20);
            this.chkDebug.TabIndex = 6;
            this.chkDebug.Text = "Debug";
            this.chkDebug.UseVisualStyleBackColor = true;
            // 
            // characterSettingsGroupBox
            // 
            this.characterSettingsGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.characterSettingsGroupBox.Controls.Add(this.comBoxDye);
            this.characterSettingsGroupBox.Controls.Add(this.labelHero);
            this.characterSettingsGroupBox.Controls.Add(this.comBoxHero);
            this.characterSettingsGroupBox.Controls.Add(this.comBoxSkin);
            this.characterSettingsGroupBox.Controls.Add(this.labelDye);
            this.characterSettingsGroupBox.Controls.Add(this.labelSkin);
            this.characterSettingsGroupBox.Location = new System.Drawing.Point(16, 15);
            this.characterSettingsGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.characterSettingsGroupBox.Name = "characterSettingsGroupBox";
            this.characterSettingsGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.characterSettingsGroupBox.Size = new System.Drawing.Size(364, 96);
            this.characterSettingsGroupBox.TabIndex = 3;
            this.characterSettingsGroupBox.TabStop = false;
            this.characterSettingsGroupBox.Text = "Character Settings";
            // 
            // comBoxDye
            // 
            this.comBoxDye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxDye.FormattingEnabled = true;
            this.comBoxDye.Location = new System.Drawing.Point(248, 63);
            this.comBoxDye.Margin = new System.Windows.Forms.Padding(4);
            this.comBoxDye.Name = "comBoxDye";
            this.comBoxDye.Size = new System.Drawing.Size(99, 24);
            this.comBoxDye.TabIndex = 6;
            this.comBoxDye.SelectedIndexChanged += new System.EventHandler(this.comBoxDye_SelectedIndexChanged);
            // 
            // labelHero
            // 
            this.labelHero.AutoSize = true;
            this.labelHero.Location = new System.Drawing.Point(8, 33);
            this.labelHero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHero.Name = "labelHero";
            this.labelHero.Size = new System.Drawing.Size(37, 16);
            this.labelHero.TabIndex = 1;
            this.labelHero.Text = "Hero";
            // 
            // comBoxHero
            // 
            this.comBoxHero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxHero.FormattingEnabled = true;
            this.comBoxHero.Location = new System.Drawing.Point(60, 30);
            this.comBoxHero.Margin = new System.Windows.Forms.Padding(4);
            this.comBoxHero.Name = "comBoxHero";
            this.comBoxHero.Size = new System.Drawing.Size(287, 24);
            this.comBoxHero.TabIndex = 2;
            this.comBoxHero.SelectedIndexChanged += new System.EventHandler(this.comBoxHero_SelectedIndexChanged);
            // 
            // comBoxSkin
            // 
            this.comBoxSkin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxSkin.FormattingEnabled = true;
            this.comBoxSkin.Location = new System.Drawing.Point(60, 63);
            this.comBoxSkin.Margin = new System.Windows.Forms.Padding(4);
            this.comBoxSkin.Name = "comBoxSkin";
            this.comBoxSkin.Size = new System.Drawing.Size(147, 24);
            this.comBoxSkin.TabIndex = 4;
            this.comBoxSkin.SelectedIndexChanged += new System.EventHandler(this.comBoxSkin_SelectedIndexChanged);
            // 
            // labelDye
            // 
            this.labelDye.AutoSize = true;
            this.labelDye.Location = new System.Drawing.Point(211, 66);
            this.labelDye.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDye.Name = "labelDye";
            this.labelDye.Size = new System.Drawing.Size(32, 16);
            this.labelDye.TabIndex = 5;
            this.labelDye.Text = "Dye";
            // 
            // labelSkin
            // 
            this.labelSkin.AutoSize = true;
            this.labelSkin.Location = new System.Drawing.Point(7, 66);
            this.labelSkin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSkin.Name = "labelSkin";
            this.labelSkin.Size = new System.Drawing.Size(33, 16);
            this.labelSkin.TabIndex = 3;
            this.labelSkin.Text = "Skin";
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
            this.mapSettingsGroupBox.Location = new System.Drawing.Point(395, 15);
            this.mapSettingsGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.mapSettingsGroupBox.Name = "mapSettingsGroupBox";
            this.mapSettingsGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.mapSettingsGroupBox.Size = new System.Drawing.Size(455, 128);
            this.mapSettingsGroupBox.TabIndex = 8;
            this.mapSettingsGroupBox.TabStop = false;
            this.mapSettingsGroupBox.Text = "Battleground";
            // 
            // comBoxExtraDifficulty
            // 
            this.comBoxExtraDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxExtraDifficulty.FormattingEnabled = true;
            this.comBoxExtraDifficulty.Location = new System.Drawing.Point(341, 92);
            this.comBoxExtraDifficulty.Margin = new System.Windows.Forms.Padding(4);
            this.comBoxExtraDifficulty.Name = "comBoxExtraDifficulty";
            this.comBoxExtraDifficulty.Size = new System.Drawing.Size(104, 24);
            this.comBoxExtraDifficulty.TabIndex = 9;
            this.comBoxExtraDifficulty.SelectedIndexChanged += new System.EventHandler(this.comBoxExtraDifficulty_SelectedIndexChanged);
            // 
            // labelExtraDifficulty
            // 
            this.labelExtraDifficulty.AutoSize = true;
            this.labelExtraDifficulty.Location = new System.Drawing.Point(241, 97);
            this.labelExtraDifficulty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelExtraDifficulty.Name = "labelExtraDifficulty";
            this.labelExtraDifficulty.Size = new System.Drawing.Size(89, 16);
            this.labelExtraDifficulty.TabIndex = 8;
            this.labelExtraDifficulty.Text = "Extra Difficulty";
            // 
            // comBoxDifficulty
            // 
            this.comBoxDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxDifficulty.Enabled = false;
            this.comBoxDifficulty.FormattingEnabled = true;
            this.comBoxDifficulty.Location = new System.Drawing.Point(280, 26);
            this.comBoxDifficulty.Margin = new System.Windows.Forms.Padding(4);
            this.comBoxDifficulty.Name = "comBoxDifficulty";
            this.comBoxDifficulty.Size = new System.Drawing.Size(165, 24);
            this.comBoxDifficulty.TabIndex = 7;
            this.comBoxDifficulty.SelectedIndexChanged += new System.EventHandler(this.comBoxDifficulty_SelectedIndexChanged);
            // 
            // labelDifficulty
            // 
            this.labelDifficulty.AutoSize = true;
            this.labelDifficulty.Location = new System.Drawing.Point(216, 30);
            this.labelDifficulty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDifficulty.Name = "labelDifficulty";
            this.labelDifficulty.Size = new System.Drawing.Size(56, 16);
            this.labelDifficulty.TabIndex = 6;
            this.labelDifficulty.Text = "Difficulty";
            // 
            // comBoxGameMode
            // 
            this.comBoxGameMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxGameMode.FormattingEnabled = true;
            this.comBoxGameMode.Location = new System.Drawing.Point(53, 26);
            this.comBoxGameMode.Margin = new System.Windows.Forms.Padding(4);
            this.comBoxGameMode.Name = "comBoxGameMode";
            this.comBoxGameMode.Size = new System.Drawing.Size(153, 24);
            this.comBoxGameMode.TabIndex = 5;
            this.comBoxGameMode.SelectedIndexChanged += new System.EventHandler(this.comBoxGameMode_SelectedIndexChanged);
            // 
            // labelGameMode
            // 
            this.labelGameMode.AutoSize = true;
            this.labelGameMode.Location = new System.Drawing.Point(8, 32);
            this.labelGameMode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGameMode.Name = "labelGameMode";
            this.labelGameMode.Size = new System.Drawing.Size(42, 16);
            this.labelGameMode.TabIndex = 2;
            this.labelGameMode.Text = "Mode";
            // 
            // comBoxBattleground
            // 
            this.comBoxBattleground.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxBattleground.FormattingEnabled = true;
            this.comBoxBattleground.Location = new System.Drawing.Point(53, 59);
            this.comBoxBattleground.Margin = new System.Windows.Forms.Padding(4);
            this.comBoxBattleground.Name = "comBoxBattleground";
            this.comBoxBattleground.Size = new System.Drawing.Size(393, 24);
            this.comBoxBattleground.TabIndex = 1;
            this.comBoxBattleground.SelectedIndexChanged += new System.EventHandler(this.comBoxBattleground_SelectedIndexChanged);
            // 
            // labelMap
            // 
            this.labelMap.AutoSize = true;
            this.labelMap.Location = new System.Drawing.Point(8, 63);
            this.labelMap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMap.Name = "labelMap";
            this.labelMap.Size = new System.Drawing.Size(34, 16);
            this.labelMap.TabIndex = 0;
            this.labelMap.Text = "Map";
            // 
            // btnResetConfig
            // 
            this.btnResetConfig.Location = new System.Drawing.Point(732, 538);
            this.btnResetConfig.Margin = new System.Windows.Forms.Padding(4);
            this.btnResetConfig.Name = "btnResetConfig";
            this.btnResetConfig.Size = new System.Drawing.Size(111, 27);
            this.btnResetConfig.TabIndex = 9;
            this.btnResetConfig.Text = "Reset Configs";
            this.btnResetConfig.UseVisualStyleBackColor = true;
            this.btnResetConfig.Click += new System.EventHandler(this.btnResetConfig_Click);
            // 
            // chkShowTrapDamageFlyoffs
            // 
            this.chkShowTrapDamageFlyoffs.AutoSize = true;
            this.chkShowTrapDamageFlyoffs.Location = new System.Drawing.Point(8, 108);
            this.chkShowTrapDamageFlyoffs.Margin = new System.Windows.Forms.Padding(4);
            this.chkShowTrapDamageFlyoffs.Name = "chkShowTrapDamageFlyoffs";
            this.chkShowTrapDamageFlyoffs.Size = new System.Drawing.Size(147, 20);
            this.chkShowTrapDamageFlyoffs.TabIndex = 21;
            this.chkShowTrapDamageFlyoffs.Text = "Show Trap Damage";
            this.chkShowTrapDamageFlyoffs.UseVisualStyleBackColor = true;
            this.chkShowTrapDamageFlyoffs.CheckedChanged += new System.EventHandler(this.chkShowTrapDamageFlyoffs_CheckedChanged);
            // 
            // chkInvincibleBarricades
            // 
            this.chkInvincibleBarricades.AutoSize = true;
            this.chkInvincibleBarricades.Location = new System.Drawing.Point(8, 52);
            this.chkInvincibleBarricades.Margin = new System.Windows.Forms.Padding(4);
            this.chkInvincibleBarricades.Name = "chkInvincibleBarricades";
            this.chkInvincibleBarricades.Size = new System.Drawing.Size(151, 20);
            this.chkInvincibleBarricades.TabIndex = 20;
            this.chkInvincibleBarricades.Text = "Invincible Barricades";
            this.chkInvincibleBarricades.UseVisualStyleBackColor = true;
            this.chkInvincibleBarricades.CheckedChanged += new System.EventHandler(this.chkInvincibleBarricades_CheckedChanged);
            // 
            // chkNoTrapGrid
            // 
            this.chkNoTrapGrid.AutoSize = true;
            this.chkNoTrapGrid.Location = new System.Drawing.Point(227, 73);
            this.chkNoTrapGrid.Margin = new System.Windows.Forms.Padding(4);
            this.chkNoTrapGrid.Name = "chkNoTrapGrid";
            this.chkNoTrapGrid.Size = new System.Drawing.Size(98, 20);
            this.chkNoTrapGrid.TabIndex = 19;
            this.chkNoTrapGrid.Text = "No trap Grid";
            this.chkNoTrapGrid.UseVisualStyleBackColor = true;
            this.chkNoTrapGrid.CheckedChanged += new System.EventHandler(this.chkNoTrapGrid_CheckedChanged);
            // 
            // chkTrapsAnySurface
            // 
            this.chkTrapsAnySurface.AutoSize = true;
            this.chkTrapsAnySurface.Location = new System.Drawing.Point(227, 16);
            this.chkTrapsAnySurface.Margin = new System.Windows.Forms.Padding(4);
            this.chkTrapsAnySurface.Name = "chkTrapsAnySurface";
            this.chkTrapsAnySurface.Size = new System.Drawing.Size(154, 20);
            this.chkTrapsAnySurface.TabIndex = 18;
            this.chkTrapsAnySurface.Text = "Traps on any Surface";
            this.chkTrapsAnySurface.UseVisualStyleBackColor = true;
            this.chkTrapsAnySurface.CheckedChanged += new System.EventHandler(this.chkTrapsAnySurface_CheckedChanged);
            // 
            // chkHardcore
            // 
            this.chkHardcore.AutoSize = true;
            this.chkHardcore.Location = new System.Drawing.Point(9, 183);
            this.chkHardcore.Margin = new System.Windows.Forms.Padding(4);
            this.chkHardcore.Name = "chkHardcore";
            this.chkHardcore.Size = new System.Drawing.Size(121, 20);
            this.chkHardcore.TabIndex = 17;
            this.chkHardcore.Text = "Hardcore (1 life)";
            this.chkHardcore.UseVisualStyleBackColor = true;
            this.chkHardcore.CheckedChanged += new System.EventHandler(this.chkHardcore_CheckedChanged);
            // 
            // chkNoLimitUniqueTraps
            // 
            this.chkNoLimitUniqueTraps.AutoSize = true;
            this.chkNoLimitUniqueTraps.Location = new System.Drawing.Point(8, 80);
            this.chkNoLimitUniqueTraps.Margin = new System.Windows.Forms.Padding(4);
            this.chkNoLimitUniqueTraps.Name = "chkNoLimitUniqueTraps";
            this.chkNoLimitUniqueTraps.Size = new System.Drawing.Size(159, 20);
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
            this.startingCoinInput.Location = new System.Drawing.Point(331, 180);
            this.startingCoinInput.Margin = new System.Windows.Forms.Padding(4);
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
            this.startingCoinInput.Size = new System.Drawing.Size(113, 22);
            this.startingCoinInput.TabIndex = 14;
            this.startingCoinInput.ValueChanged += new System.EventHandler(this.StartingCoinInput_ValueChanged);
            // 
            // chkTrapsInTraps
            // 
            this.chkTrapsInTraps.AutoSize = true;
            this.chkTrapsInTraps.Location = new System.Drawing.Point(227, 44);
            this.chkTrapsInTraps.Margin = new System.Windows.Forms.Padding(4);
            this.chkTrapsInTraps.Name = "chkTrapsInTraps";
            this.chkTrapsInTraps.Size = new System.Drawing.Size(136, 20);
            this.chkTrapsInTraps.TabIndex = 13;
            this.chkTrapsInTraps.Text = "Traps can overlap";
            this.chkTrapsInTraps.UseVisualStyleBackColor = true;
            this.chkTrapsInTraps.CheckedChanged += new System.EventHandler(this.chkTrapsInTraps_CheckedChanged);
            // 
            // chkNoTrapCap
            // 
            this.chkNoTrapCap.AutoSize = true;
            this.chkNoTrapCap.Location = new System.Drawing.Point(8, 23);
            this.chkNoTrapCap.Margin = new System.Windows.Forms.Padding(4);
            this.chkNoTrapCap.Name = "chkNoTrapCap";
            this.chkNoTrapCap.Size = new System.Drawing.Size(104, 20);
            this.chkNoTrapCap.TabIndex = 12;
            this.chkNoTrapCap.Text = "No Trap Cap";
            this.chkNoTrapCap.UseVisualStyleBackColor = true;
            this.chkNoTrapCap.CheckedChanged += new System.EventHandler(this.chkNoTrapCap_CheckedChanged);
            // 
            // chkGodMode
            // 
            this.chkGodMode.AutoSize = true;
            this.chkGodMode.Location = new System.Drawing.Point(9, 212);
            this.chkGodMode.Margin = new System.Windows.Forms.Padding(4);
            this.chkGodMode.Name = "chkGodMode";
            this.chkGodMode.Size = new System.Drawing.Size(90, 20);
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
            this.modsGroupBox.Controls.Add(this.chkShowTrapDamageFlyoffs);
            this.modsGroupBox.Controls.Add(this.chkNoTrapCap);
            this.modsGroupBox.Controls.Add(this.startingCoinInput);
            this.modsGroupBox.Controls.Add(this.chkNoTrapGrid);
            this.modsGroupBox.Controls.Add(this.chkGodMode);
            this.modsGroupBox.Controls.Add(this.chkInvincibleBarricades);
            this.modsGroupBox.Controls.Add(this.chkTrapsAnySurface);
            this.modsGroupBox.Controls.Add(this.chkTrapsInTraps);
            this.modsGroupBox.Location = new System.Drawing.Point(397, 188);
            this.modsGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.modsGroupBox.Name = "modsGroupBox";
            this.modsGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.modsGroupBox.Size = new System.Drawing.Size(452, 242);
            this.modsGroupBox.TabIndex = 22;
            this.modsGroupBox.TabStop = false;
            this.modsGroupBox.Text = "Mods";
            // 
            // chkEnhancedTrapRotation
            // 
            this.chkEnhancedTrapRotation.AutoSize = true;
            this.chkEnhancedTrapRotation.Location = new System.Drawing.Point(227, 128);
            this.chkEnhancedTrapRotation.Margin = new System.Windows.Forms.Padding(4);
            this.chkEnhancedTrapRotation.Name = "chkEnhancedTrapRotation";
            this.chkEnhancedTrapRotation.Size = new System.Drawing.Size(172, 20);
            this.chkEnhancedTrapRotation.TabIndex = 24;
            this.chkEnhancedTrapRotation.Text = "Enhanced Trap Rotation";
            this.chkEnhancedTrapRotation.UseVisualStyleBackColor = true;
            this.chkEnhancedTrapRotation.CheckedChanged += new System.EventHandler(this.chkEnhancedTrapRotation_CheckedChanged);
            // 
            // chkCustomStartCoin
            // 
            this.chkCustomStartCoin.AutoSize = true;
            this.chkCustomStartCoin.Location = new System.Drawing.Point(227, 183);
            this.chkCustomStartCoin.Margin = new System.Windows.Forms.Padding(4);
            this.chkCustomStartCoin.Name = "chkCustomStartCoin";
            this.chkCustomStartCoin.Size = new System.Drawing.Size(83, 20);
            this.chkCustomStartCoin.TabIndex = 23;
            this.chkCustomStartCoin.Text = "Start Coin";
            this.chkCustomStartCoin.UseVisualStyleBackColor = true;
            this.chkCustomStartCoin.CheckedChanged += new System.EventHandler(this.chkCustomStartCoin_CheckedChanged);
            // 
            // chkSellTrapsAnytime
            // 
            this.chkSellTrapsAnytime.AutoSize = true;
            this.chkSellTrapsAnytime.Location = new System.Drawing.Point(227, 101);
            this.chkSellTrapsAnytime.Margin = new System.Windows.Forms.Padding(4);
            this.chkSellTrapsAnytime.Name = "chkSellTrapsAnytime";
            this.chkSellTrapsAnytime.Size = new System.Drawing.Size(139, 20);
            this.chkSellTrapsAnytime.TabIndex = 22;
            this.chkSellTrapsAnytime.Text = "Sell Traps Anytime";
            this.chkSellTrapsAnytime.UseVisualStyleBackColor = true;
            this.chkSellTrapsAnytime.CheckedChanged += new System.EventHandler(this.chkSellTrapsAnytime_CheckedChanged);
            // 
            // labelGuardianSlot1
            // 
            this.labelGuardianSlot1.AutoSize = true;
            this.labelGuardianSlot1.Location = new System.Drawing.Point(7, 411);
            this.labelGuardianSlot1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGuardianSlot1.Name = "labelGuardianSlot1";
            this.labelGuardianSlot1.Size = new System.Drawing.Size(72, 16);
            this.labelGuardianSlot1.TabIndex = 21;
            this.labelGuardianSlot1.Text = "Guardian 2";
            // 
            // comBoxGuardianSlot1
            // 
            this.comBoxGuardianSlot1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxGuardianSlot1.FormattingEnabled = true;
            this.comBoxGuardianSlot1.Location = new System.Drawing.Point(93, 374);
            this.comBoxGuardianSlot1.Margin = new System.Windows.Forms.Padding(4);
            this.comBoxGuardianSlot1.Name = "comBoxGuardianSlot1";
            this.comBoxGuardianSlot1.Size = new System.Drawing.Size(253, 24);
            this.comBoxGuardianSlot1.TabIndex = 18;
            this.comBoxGuardianSlot1.SelectedIndexChanged += new System.EventHandler(this.comBoxGuardianSlot1_SelectedIndexChanged);
            // 
            // labelGuardianSlot2
            // 
            this.labelGuardianSlot2.AutoSize = true;
            this.labelGuardianSlot2.Location = new System.Drawing.Point(7, 378);
            this.labelGuardianSlot2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGuardianSlot2.Name = "labelGuardianSlot2";
            this.labelGuardianSlot2.Size = new System.Drawing.Size(72, 16);
            this.labelGuardianSlot2.TabIndex = 20;
            this.labelGuardianSlot2.Text = "Guardian 1";
            // 
            // comBoxGuardianSlot2
            // 
            this.comBoxGuardianSlot2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxGuardianSlot2.FormattingEnabled = true;
            this.comBoxGuardianSlot2.Location = new System.Drawing.Point(93, 407);
            this.comBoxGuardianSlot2.Margin = new System.Windows.Forms.Padding(4);
            this.comBoxGuardianSlot2.Name = "comBoxGuardianSlot2";
            this.comBoxGuardianSlot2.Size = new System.Drawing.Size(253, 24);
            this.comBoxGuardianSlot2.TabIndex = 19;
            this.comBoxGuardianSlot2.SelectedIndexChanged += new System.EventHandler(this.comBoxGuardianSlot2_SelectedIndexChanged);
            // 
            // groupBoxLoadout
            // 
            this.groupBoxLoadout.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxLoadout.Controls.Add(this.labelGuardianSlot1);
            this.groupBoxLoadout.Controls.Add(this.comboBox1);
            this.groupBoxLoadout.Controls.Add(this.labelLoadoutSlot9);
            this.groupBoxLoadout.Controls.Add(this.comBoxGuardianSlot1);
            this.groupBoxLoadout.Controls.Add(this.labelGuardianSlot2);
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
            this.groupBoxLoadout.Location = new System.Drawing.Point(16, 118);
            this.groupBoxLoadout.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxLoadout.Name = "groupBoxLoadout";
            this.groupBoxLoadout.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxLoadout.Size = new System.Drawing.Size(364, 442);
            this.groupBoxLoadout.TabIndex = 24;
            this.groupBoxLoadout.TabStop = false;
            this.groupBoxLoadout.Text = "Loadout";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 23);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(335, 24);
            this.comboBox1.TabIndex = 23;
            // 
            // labelLoadoutSlot9
            // 
            this.labelLoadoutSlot9.AutoSize = true;
            this.labelLoadoutSlot9.Location = new System.Drawing.Point(7, 336);
            this.labelLoadoutSlot9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLoadoutSlot9.Name = "labelLoadoutSlot9";
            this.labelLoadoutSlot9.Size = new System.Drawing.Size(40, 16);
            this.labelLoadoutSlot9.TabIndex = 17;
            this.labelLoadoutSlot9.Text = "Slot 9";
            // 
            // labelLoadoutSlot8
            // 
            this.labelLoadoutSlot8.AutoSize = true;
            this.labelLoadoutSlot8.Location = new System.Drawing.Point(7, 303);
            this.labelLoadoutSlot8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLoadoutSlot8.Name = "labelLoadoutSlot8";
            this.labelLoadoutSlot8.Size = new System.Drawing.Size(40, 16);
            this.labelLoadoutSlot8.TabIndex = 16;
            this.labelLoadoutSlot8.Text = "Slot 8";
            // 
            // labelLoadoutSlot7
            // 
            this.labelLoadoutSlot7.AutoSize = true;
            this.labelLoadoutSlot7.Location = new System.Drawing.Point(8, 270);
            this.labelLoadoutSlot7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLoadoutSlot7.Name = "labelLoadoutSlot7";
            this.labelLoadoutSlot7.Size = new System.Drawing.Size(40, 16);
            this.labelLoadoutSlot7.TabIndex = 15;
            this.labelLoadoutSlot7.Text = "Slot 7";
            // 
            // labelLoadoutSlot6
            // 
            this.labelLoadoutSlot6.AutoSize = true;
            this.labelLoadoutSlot6.Location = new System.Drawing.Point(7, 236);
            this.labelLoadoutSlot6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLoadoutSlot6.Name = "labelLoadoutSlot6";
            this.labelLoadoutSlot6.Size = new System.Drawing.Size(40, 16);
            this.labelLoadoutSlot6.TabIndex = 14;
            this.labelLoadoutSlot6.Text = "Slot 6";
            // 
            // labelLoadoutSlot5
            // 
            this.labelLoadoutSlot5.AutoSize = true;
            this.labelLoadoutSlot5.Location = new System.Drawing.Point(7, 203);
            this.labelLoadoutSlot5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLoadoutSlot5.Name = "labelLoadoutSlot5";
            this.labelLoadoutSlot5.Size = new System.Drawing.Size(40, 16);
            this.labelLoadoutSlot5.TabIndex = 13;
            this.labelLoadoutSlot5.Text = "Slot 5";
            // 
            // labelLoadoutSlot4
            // 
            this.labelLoadoutSlot4.AutoSize = true;
            this.labelLoadoutSlot4.Location = new System.Drawing.Point(7, 170);
            this.labelLoadoutSlot4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLoadoutSlot4.Name = "labelLoadoutSlot4";
            this.labelLoadoutSlot4.Size = new System.Drawing.Size(40, 16);
            this.labelLoadoutSlot4.TabIndex = 12;
            this.labelLoadoutSlot4.Text = "Slot 4";
            // 
            // labelLoadoutSlot3
            // 
            this.labelLoadoutSlot3.AutoSize = true;
            this.labelLoadoutSlot3.Location = new System.Drawing.Point(7, 137);
            this.labelLoadoutSlot3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLoadoutSlot3.Name = "labelLoadoutSlot3";
            this.labelLoadoutSlot3.Size = new System.Drawing.Size(40, 16);
            this.labelLoadoutSlot3.TabIndex = 11;
            this.labelLoadoutSlot3.Text = "Slot 3";
            // 
            // labelLoadoutSlot2
            // 
            this.labelLoadoutSlot2.AutoSize = true;
            this.labelLoadoutSlot2.Location = new System.Drawing.Point(7, 103);
            this.labelLoadoutSlot2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLoadoutSlot2.Name = "labelLoadoutSlot2";
            this.labelLoadoutSlot2.Size = new System.Drawing.Size(40, 16);
            this.labelLoadoutSlot2.TabIndex = 10;
            this.labelLoadoutSlot2.Text = "Slot 2";
            // 
            // labelLoadoutSlot1
            // 
            this.labelLoadoutSlot1.AutoSize = true;
            this.labelLoadoutSlot1.Location = new System.Drawing.Point(7, 70);
            this.labelLoadoutSlot1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLoadoutSlot1.Name = "labelLoadoutSlot1";
            this.labelLoadoutSlot1.Size = new System.Drawing.Size(40, 16);
            this.labelLoadoutSlot1.TabIndex = 9;
            this.labelLoadoutSlot1.Text = "Slot 1";
            // 
            // comBoxLoadoutSlot1
            // 
            this.comBoxLoadoutSlot1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxLoadoutSlot1.FormattingEnabled = true;
            this.comBoxLoadoutSlot1.Location = new System.Drawing.Point(60, 66);
            this.comBoxLoadoutSlot1.Margin = new System.Windows.Forms.Padding(4);
            this.comBoxLoadoutSlot1.Name = "comBoxLoadoutSlot1";
            this.comBoxLoadoutSlot1.Size = new System.Drawing.Size(287, 24);
            this.comBoxLoadoutSlot1.TabIndex = 0;
            this.comBoxLoadoutSlot1.SelectedIndexChanged += new System.EventHandler(this.comBoxLoadoutSlot1_SelectedIndexChanged);
            // 
            // comBoxLoadoutSlot2
            // 
            this.comBoxLoadoutSlot2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxLoadoutSlot2.FormattingEnabled = true;
            this.comBoxLoadoutSlot2.Location = new System.Drawing.Point(60, 100);
            this.comBoxLoadoutSlot2.Margin = new System.Windows.Forms.Padding(4);
            this.comBoxLoadoutSlot2.Name = "comBoxLoadoutSlot2";
            this.comBoxLoadoutSlot2.Size = new System.Drawing.Size(287, 24);
            this.comBoxLoadoutSlot2.TabIndex = 1;
            this.comBoxLoadoutSlot2.SelectedIndexChanged += new System.EventHandler(this.comBoxLoadoutSlot2_SelectedIndexChanged);
            // 
            // comBoxLoadoutSlot3
            // 
            this.comBoxLoadoutSlot3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxLoadoutSlot3.FormattingEnabled = true;
            this.comBoxLoadoutSlot3.Location = new System.Drawing.Point(60, 133);
            this.comBoxLoadoutSlot3.Margin = new System.Windows.Forms.Padding(4);
            this.comBoxLoadoutSlot3.Name = "comBoxLoadoutSlot3";
            this.comBoxLoadoutSlot3.Size = new System.Drawing.Size(287, 24);
            this.comBoxLoadoutSlot3.TabIndex = 2;
            this.comBoxLoadoutSlot3.SelectedIndexChanged += new System.EventHandler(this.comBoxLoadoutSlot3_SelectedIndexChanged);
            // 
            // comBoxLoadoutSlot9
            // 
            this.comBoxLoadoutSlot9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxLoadoutSlot9.FormattingEnabled = true;
            this.comBoxLoadoutSlot9.Location = new System.Drawing.Point(60, 332);
            this.comBoxLoadoutSlot9.Margin = new System.Windows.Forms.Padding(4);
            this.comBoxLoadoutSlot9.Name = "comBoxLoadoutSlot9";
            this.comBoxLoadoutSlot9.Size = new System.Drawing.Size(287, 24);
            this.comBoxLoadoutSlot9.TabIndex = 8;
            this.comBoxLoadoutSlot9.SelectedIndexChanged += new System.EventHandler(this.comBoxLoadoutSlot9_SelectedIndexChanged);
            // 
            // comBoxLoadoutSlot4
            // 
            this.comBoxLoadoutSlot4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxLoadoutSlot4.FormattingEnabled = true;
            this.comBoxLoadoutSlot4.Location = new System.Drawing.Point(60, 166);
            this.comBoxLoadoutSlot4.Margin = new System.Windows.Forms.Padding(4);
            this.comBoxLoadoutSlot4.Name = "comBoxLoadoutSlot4";
            this.comBoxLoadoutSlot4.Size = new System.Drawing.Size(287, 24);
            this.comBoxLoadoutSlot4.TabIndex = 3;
            this.comBoxLoadoutSlot4.SelectedIndexChanged += new System.EventHandler(this.comBoxLoadoutSlot4_SelectedIndexChanged);
            // 
            // comBoxLoadoutSlot8
            // 
            this.comBoxLoadoutSlot8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxLoadoutSlot8.FormattingEnabled = true;
            this.comBoxLoadoutSlot8.Location = new System.Drawing.Point(60, 299);
            this.comBoxLoadoutSlot8.Margin = new System.Windows.Forms.Padding(4);
            this.comBoxLoadoutSlot8.Name = "comBoxLoadoutSlot8";
            this.comBoxLoadoutSlot8.Size = new System.Drawing.Size(287, 24);
            this.comBoxLoadoutSlot8.TabIndex = 7;
            this.comBoxLoadoutSlot8.SelectedIndexChanged += new System.EventHandler(this.comBoxLoadoutSlot8_SelectedIndexChanged);
            // 
            // comBoxLoadoutSlot5
            // 
            this.comBoxLoadoutSlot5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxLoadoutSlot5.FormattingEnabled = true;
            this.comBoxLoadoutSlot5.Location = new System.Drawing.Point(60, 199);
            this.comBoxLoadoutSlot5.Margin = new System.Windows.Forms.Padding(4);
            this.comBoxLoadoutSlot5.Name = "comBoxLoadoutSlot5";
            this.comBoxLoadoutSlot5.Size = new System.Drawing.Size(287, 24);
            this.comBoxLoadoutSlot5.TabIndex = 4;
            this.comBoxLoadoutSlot5.SelectedIndexChanged += new System.EventHandler(this.comBoxLoadoutSlot5_SelectedIndexChanged);
            // 
            // comBoxLoadoutSlot7
            // 
            this.comBoxLoadoutSlot7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxLoadoutSlot7.FormattingEnabled = true;
            this.comBoxLoadoutSlot7.Location = new System.Drawing.Point(60, 266);
            this.comBoxLoadoutSlot7.Margin = new System.Windows.Forms.Padding(4);
            this.comBoxLoadoutSlot7.Name = "comBoxLoadoutSlot7";
            this.comBoxLoadoutSlot7.Size = new System.Drawing.Size(287, 24);
            this.comBoxLoadoutSlot7.TabIndex = 6;
            this.comBoxLoadoutSlot7.SelectedIndexChanged += new System.EventHandler(this.comBoxLoadoutSlot7_SelectedIndexChanged);
            // 
            // comBoxLoadoutSlot6
            // 
            this.comBoxLoadoutSlot6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxLoadoutSlot6.FormattingEnabled = true;
            this.comBoxLoadoutSlot6.Location = new System.Drawing.Point(60, 233);
            this.comBoxLoadoutSlot6.Margin = new System.Windows.Forms.Padding(4);
            this.comBoxLoadoutSlot6.Name = "comBoxLoadoutSlot6";
            this.comBoxLoadoutSlot6.Size = new System.Drawing.Size(287, 24);
            this.comBoxLoadoutSlot6.TabIndex = 5;
            this.comBoxLoadoutSlot6.SelectedIndexChanged += new System.EventHandler(this.comBoxLoadoutSlot6_SelectedIndexChanged);
            // 
            // chk_modsEnabled
            // 
            this.chk_modsEnabled.AutoSize = true;
            this.chk_modsEnabled.Location = new System.Drawing.Point(397, 160);
            this.chk_modsEnabled.Margin = new System.Windows.Forms.Padding(4);
            this.chk_modsEnabled.Name = "chk_modsEnabled";
            this.chk_modsEnabled.Size = new System.Drawing.Size(113, 20);
            this.chk_modsEnabled.TabIndex = 25;
            this.chk_modsEnabled.Text = "Mods enabled";
            this.chk_modsEnabled.UseVisualStyleBackColor = true;
            this.chk_modsEnabled.CheckedChanged += new System.EventHandler(this.chk_modsEnabled_CheckedChanged);
            // 
            // chkRunAs32
            // 
            this.chkRunAs32.AutoSize = true;
            this.chkRunAs32.Location = new System.Drawing.Point(537, 542);
            this.chkRunAs32.Margin = new System.Windows.Forms.Padding(4);
            this.chkRunAs32.Name = "chkRunAs32";
            this.chkRunAs32.Size = new System.Drawing.Size(99, 20);
            this.chkRunAs32.TabIndex = 26;
            this.chkRunAs32.Text = "Force 32bits";
            this.chkRunAs32.UseVisualStyleBackColor = true;
            // 
            // comBoxLanguage
            // 
            this.comBoxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxLanguage.FormattingEnabled = true;
            this.comBoxLanguage.Location = new System.Drawing.Point(737, 151);
            this.comBoxLanguage.Margin = new System.Windows.Forms.Padding(4);
            this.comBoxLanguage.Name = "comBoxLanguage";
            this.comBoxLanguage.Size = new System.Drawing.Size(104, 24);
            this.comBoxLanguage.TabIndex = 11;
            this.comBoxLanguage.SelectedIndexChanged += new System.EventHandler(this.comBoxLanguage_SelectedIndexChanged);
            // 
            // label2
            // 
            this.labelLanguage.AutoSize = true;
            this.labelLanguage.Location = new System.Drawing.Point(657, 154);
            this.labelLanguage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLanguage.Name = "label2";
            this.labelLanguage.Size = new System.Drawing.Size(68, 16);
            this.labelLanguage.TabIndex = 10;
            this.labelLanguage.Text = "Language";
            // 
            // LauncherMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 575);
            this.Controls.Add(this.labelLanguage);
            this.Controls.Add(this.comBoxLanguage);
            this.Controls.Add(this.chkRunAs32);
            this.Controls.Add(this.chk_modsEnabled);
            this.Controls.Add(this.groupBoxLoadout);
            this.Controls.Add(this.modsGroupBox);
            this.Controls.Add(this.btnResetConfig);
            this.Controls.Add(this.mapSettingsGroupBox);
            this.Controls.Add(this.btnLaunch);
            this.Controls.Add(this.chkDebug);
            this.Controls.Add(this.characterSettingsGroupBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LauncherMainForm";
            this.Text = "OMDU Offline Launcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.characterSettingsGroupBox.ResumeLayout(false);
            this.characterSettingsGroupBox.PerformLayout();
            this.mapSettingsGroupBox.ResumeLayout(false);
            this.mapSettingsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startingCoinInput)).EndInit();
            this.modsGroupBox.ResumeLayout(false);
            this.modsGroupBox.PerformLayout();
            this.groupBoxLoadout.ResumeLayout(false);
            this.groupBoxLoadout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.ComboBox comBoxBattleground;
        private System.Windows.Forms.ComboBox comBoxHero;
        private System.Windows.Forms.GroupBox characterSettingsGroupBox;
        private System.Windows.Forms.Label labelHero;
        private System.Windows.Forms.Label labelMap;
        private System.Windows.Forms.CheckBox chkDebug;
        private System.Windows.Forms.Label labelSkin;
        private System.Windows.Forms.ComboBox comBoxSkin;
        private System.Windows.Forms.Label labelDye;
        private System.Windows.Forms.ComboBox comBoxDye;
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
        private System.Windows.Forms.Label labelGuardianSlot1;
        private System.Windows.Forms.ComboBox comBoxGuardianSlot1;
        private System.Windows.Forms.Label labelGuardianSlot2;
        private System.Windows.Forms.ComboBox comBoxGuardianSlot2;
        private System.Windows.Forms.GroupBox groupBoxLoadout;
        private System.Windows.Forms.Label labelLoadoutSlot9;
        private System.Windows.Forms.Label labelLoadoutSlot8;
        private System.Windows.Forms.Label labelLoadoutSlot7;
        private System.Windows.Forms.Label labelLoadoutSlot6;
        private System.Windows.Forms.Label labelLoadoutSlot5;
        private System.Windows.Forms.Label labelLoadoutSlot4;
        private System.Windows.Forms.Label labelLoadoutSlot3;
        private System.Windows.Forms.Label labelLoadoutSlot2;
        private System.Windows.Forms.Label labelLoadoutSlot1;
        private System.Windows.Forms.ComboBox comBoxLoadoutSlot1;
        private System.Windows.Forms.ComboBox comBoxLoadoutSlot2;
        private System.Windows.Forms.ComboBox comBoxLoadoutSlot3;
        private System.Windows.Forms.ComboBox comBoxLoadoutSlot9;
        private System.Windows.Forms.ComboBox comBoxLoadoutSlot4;
        private System.Windows.Forms.ComboBox comBoxLoadoutSlot8;
        private System.Windows.Forms.ComboBox comBoxLoadoutSlot5;
        private System.Windows.Forms.ComboBox comBoxLoadoutSlot7;
        private System.Windows.Forms.ComboBox comBoxLoadoutSlot6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox chk_modsEnabled;
        private System.Windows.Forms.CheckBox chkCustomStartCoin;
        private System.Windows.Forms.CheckBox chkSellTrapsAnytime;
        private System.Windows.Forms.CheckBox chkRunAs32;
        private System.Windows.Forms.CheckBox chkEnhancedTrapRotation;
        private System.Windows.Forms.ComboBox comBoxLanguage;
        private System.Windows.Forms.Label labelLanguage;
    }
}

