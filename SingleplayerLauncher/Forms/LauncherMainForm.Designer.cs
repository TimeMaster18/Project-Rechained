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
            this.battlegroundGroupBox = new System.Windows.Forms.GroupBox();
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
            this.chkAdditionalHeroWeapon = new System.Windows.Forms.CheckBox();
            this.chkEnhancedTrapRotation = new System.Windows.Forms.CheckBox();
            this.comBoxAdditionalHeroWeapon = new System.Windows.Forms.ComboBox();
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
            this.survivalGameTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.linkLabelJoinGameKnownIssues = new System.Windows.Forms.LinkLabel();
            this.labelJoinGameBriefInstructions = new System.Windows.Forms.Label();
            this.labelJoinGameAdditionalInfo = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelHostGameAdditionalInfo = new System.Windows.Forms.Label();
            this.labelHostGameBriefInstructions = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
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
            this.gameModeTabControl = new System.Windows.Forms.TabControl();
            this.gameModeSurvivalTab = new System.Windows.Forms.TabPage();
            this.gameModeSiegeTab = new System.Windows.Forms.TabPage();
            this.siegeGameTabControl = new System.Windows.Forms.TabControl();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedTextBoxJoinSiegeGameLoadout = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnJoinSiegeGame = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.maskedTextBoxJoinSiegeGameHostIP = new System.Windows.Forms.MaskedTextBox();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comBoxSiegeDifficulty = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comBoxSiegeBattleground = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.maskedTextBoxSiegeHostGamePlayer8Loadout = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxSiegeHostGamePlayer6Loadout = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxSiegeHostGamePlayer9Loadout = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxSiegeHostGamePlayer7Loadout = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.maskedTextBoxSiegeHostGamePlayer10Loadout = new System.Windows.Forms.MaskedTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.maskedTextBoxSiegeHostGamePlayer3Loadout = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxSiegeHostGamePlayer1Loadout = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxSiegeHostGamePlayer4Loadout = new System.Windows.Forms.MaskedTextBox();
            this.btnSiegeLaunch = new System.Windows.Forms.Button();
            this.maskedTextBoxSiegeHostGamePlayer2Loadout = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.maskedTextBoxSiegeHostGamePlayer5Loadout = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.siegeGameSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.comBoxSiegeLanguage = new System.Windows.Forms.ComboBox();
            this.labelSiegeLanguage = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.loadoutEditorTabControl = new System.Windows.Forms.TabControl();
            this.loadoutEditorSurvivalTab = new System.Windows.Forms.TabPage();
            this.loadoutEditorSiegeTab = new System.Windows.Forms.TabPage();
            this.siegeLoadoutEditorGroupBox = new System.Windows.Forms.GroupBox();
            this.comBoxRole = new System.Windows.Forms.ComboBox();
            this.roleLabel = new System.Windows.Forms.Label();
            this.comBoxSiegeBossWaveSlot2 = new System.Windows.Forms.ComboBox();
            this.label45 = new System.Windows.Forms.Label();
            this.comBoxSiegeBossWaveSlot1 = new System.Windows.Forms.ComboBox();
            this.comBoxSiegeLv4WaveSlot2 = new System.Windows.Forms.ComboBox();
            this.label36 = new System.Windows.Forms.Label();
            this.comBoxSiegeLv4WaveSlot1 = new System.Windows.Forms.ComboBox();
            this.comBoxSiegeLv3WaveSlot2 = new System.Windows.Forms.ComboBox();
            this.label34 = new System.Windows.Forms.Label();
            this.comBoxSiegeLv3WaveSlot1 = new System.Windows.Forms.ComboBox();
            this.comBoxSiegeLv2WaveSlot2 = new System.Windows.Forms.ComboBox();
            this.label31 = new System.Windows.Forms.Label();
            this.comBoxSiegeLv2WaveSlot1 = new System.Windows.Forms.ComboBox();
            this.comBoxSiegeLv1WaveSlot2 = new System.Windows.Forms.ComboBox();
            this.label30 = new System.Windows.Forms.Label();
            this.comBoxSiegeLv1WaveSlot1 = new System.Windows.Forms.ComboBox();
            this.btnDeleteSiegeLoadout = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.maskedTextBoxSiegePlayerName = new System.Windows.Forms.MaskedTextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.btnSaveSiegeLoadout = new System.Windows.Forms.Button();
            this.maskedTextBoxSiegeLoadoutName = new System.Windows.Forms.MaskedTextBox();
            this.btnCopySiegeLoadoutToClipboard = new System.Windows.Forms.Button();
            this.btnImportSiegeLoadout = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.textBoxExportSiegeLoadout = new System.Windows.Forms.TextBox();
            this.maskedTextBoxImportSiegeLoadout = new System.Windows.Forms.MaskedTextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.comboxSiegeTraitYellowSlot = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.comboxSiegeTraitNoBonusSlot = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.comboxSiegeTraitGreenSlot = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.comboxSiegeTraitBlueSlot = new System.Windows.Forms.ComboBox();
            this.comBoxSiegeDye = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.comBoxSiegeHero = new System.Windows.Forms.ComboBox();
            this.comBoxSiegeSkin = new System.Windows.Forms.ComboBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.comBoxSiegeLoadouts = new System.Windows.Forms.ComboBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.comBoxSiegeLoadoutSlot1 = new System.Windows.Forms.ComboBox();
            this.comBoxSiegeLoadoutSlot2 = new System.Windows.Forms.ComboBox();
            this.comBoxSiegeLoadoutSlot3 = new System.Windows.Forms.ComboBox();
            this.comBoxSiegeLoadoutSlot9 = new System.Windows.Forms.ComboBox();
            this.comBoxSiegeLoadoutSlot4 = new System.Windows.Forms.ComboBox();
            this.comBoxSiegeLoadoutSlot8 = new System.Windows.Forms.ComboBox();
            this.comBoxSiegeLoadoutSlot5 = new System.Windows.Forms.ComboBox();
            this.comBoxSiegeLoadoutSlot7 = new System.Windows.Forms.ComboBox();
            this.comBoxSiegeLoadoutSlot6 = new System.Windows.Forms.ComboBox();
            this.battlegroundGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startingCoinInput)).BeginInit();
            this.modsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.survivalGameTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.modsPanel.SuspendLayout();
            this.gameSettingsGroupBox.SuspendLayout();
            this.groupBoxLoadout.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gameModeTabControl.SuspendLayout();
            this.gameModeSurvivalTab.SuspendLayout();
            this.gameModeSiegeTab.SuspendLayout();
            this.siegeGameTabControl.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.siegeGameSettingsGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.loadoutEditorTabControl.SuspendLayout();
            this.loadoutEditorSurvivalTab.SuspendLayout();
            this.loadoutEditorSiegeTab.SuspendLayout();
            this.siegeLoadoutEditorGroupBox.SuspendLayout();
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
            // battlegroundGroupBox
            // 
            this.battlegroundGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.battlegroundGroupBox.Controls.Add(this.comBoxExtraDifficulty);
            this.battlegroundGroupBox.Controls.Add(this.labelExtraDifficulty);
            this.battlegroundGroupBox.Controls.Add(this.comBoxDifficulty);
            this.battlegroundGroupBox.Controls.Add(this.labelDifficulty);
            this.battlegroundGroupBox.Controls.Add(this.comBoxGameMode);
            this.battlegroundGroupBox.Controls.Add(this.labelGameMode);
            this.battlegroundGroupBox.Controls.Add(this.comBoxBattleground);
            this.battlegroundGroupBox.Controls.Add(this.labelMap);
            this.battlegroundGroupBox.Location = new System.Drawing.Point(3, 3);
            this.battlegroundGroupBox.Name = "battlegroundGroupBox";
            this.battlegroundGroupBox.Size = new System.Drawing.Size(341, 182);
            this.battlegroundGroupBox.TabIndex = 8;
            this.battlegroundGroupBox.TabStop = false;
            this.battlegroundGroupBox.Text = "Battleground";
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
            this.modsGroupBox.BackColor = System.Drawing.Color.Thistle;
            this.modsGroupBox.Controls.Add(this.chkAdditionalHeroWeapon);
            this.modsGroupBox.Controls.Add(this.chkEnhancedTrapRotation);
            this.modsGroupBox.Controls.Add(this.comBoxAdditionalHeroWeapon);
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
            this.modsGroupBox.Location = new System.Drawing.Point(6, 127);
            this.modsGroupBox.Name = "modsGroupBox";
            this.modsGroupBox.Size = new System.Drawing.Size(339, 218);
            this.modsGroupBox.TabIndex = 22;
            this.modsGroupBox.TabStop = false;
            this.modsGroupBox.Text = "Mods";
            // 
            // chkAdditionalHeroWeapon
            // 
            this.chkAdditionalHeroWeapon.AutoSize = true;
            this.chkAdditionalHeroWeapon.Location = new System.Drawing.Point(7, 189);
            this.chkAdditionalHeroWeapon.Name = "chkAdditionalHeroWeapon";
            this.chkAdditionalHeroWeapon.Size = new System.Drawing.Size(139, 17);
            this.chkAdditionalHeroWeapon.TabIndex = 75;
            this.chkAdditionalHeroWeapon.Text = "Additional Hero weapon";
            this.chkAdditionalHeroWeapon.UseVisualStyleBackColor = true;
            this.chkAdditionalHeroWeapon.CheckedChanged += new System.EventHandler(this.chkAdditionalHeroWeapon_CheckedChanged);
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
            // comBoxAdditionalHeroWeapon
            // 
            this.comBoxAdditionalHeroWeapon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxAdditionalHeroWeapon.FormattingEnabled = true;
            this.comBoxAdditionalHeroWeapon.Location = new System.Drawing.Point(152, 187);
            this.comBoxAdditionalHeroWeapon.Name = "comBoxAdditionalHeroWeapon";
            this.comBoxAdditionalHeroWeapon.Size = new System.Drawing.Size(126, 21);
            this.comBoxAdditionalHeroWeapon.TabIndex = 74;
            this.comBoxAdditionalHeroWeapon.SelectedIndexChanged += new System.EventHandler(this.comBoxAdditionalHeroWeapon_SelectedIndexChanged);
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
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 10);
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
            this.btnDiscord.Location = new System.Drawing.Point(312, 4);
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
            this.btnJoinGame.Size = new System.Drawing.Size(123, 60);
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
            // survivalGameTabControl
            // 
            this.survivalGameTabControl.Controls.Add(this.tabPage1);
            this.survivalGameTabControl.Controls.Add(this.tabPage2);
            this.survivalGameTabControl.ItemSize = new System.Drawing.Size(167, 20);
            this.survivalGameTabControl.Location = new System.Drawing.Point(3, 259);
            this.survivalGameTabControl.Name = "survivalGameTabControl";
            this.survivalGameTabControl.SelectedIndex = 0;
            this.survivalGameTabControl.Size = new System.Drawing.Size(343, 232);
            this.survivalGameTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.survivalGameTabControl.TabIndex = 84;
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
            this.tabPage1.Size = new System.Drawing.Size(335, 204);
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
            this.tabPage2.Size = new System.Drawing.Size(335, 204);
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
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(7, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 41);
            this.label7.TabIndex = 88;
            this.label7.Text = "Hover for more info about multiplayer";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.label7, resources.GetString("label7.ToolTip"));
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(11, 352);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(183, 41);
            this.label10.TabIndex = 85;
            this.label10.Text = "Hover for more info about multiplayer";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.label10, resources.GetString("label10.ToolTip"));
            // 
            // modsPanel
            // 
            this.modsPanel.AutoSize = true;
            this.modsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.modsPanel.Controls.Add(this.modsGroupBox);
            this.modsPanel.Location = new System.Drawing.Point(948, 3);
            this.modsPanel.Name = "modsPanel";
            this.modsPanel.Size = new System.Drawing.Size(348, 348);
            this.modsPanel.TabIndex = 85;
            this.modsPanel.Visible = false;
            // 
            // gameSettingsGroupBox
            // 
            this.gameSettingsGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.gameSettingsGroupBox.Controls.Add(this.chk_modsEnabled);
            this.gameSettingsGroupBox.Controls.Add(this.comBoxLanguage);
            this.gameSettingsGroupBox.Controls.Add(this.labelLanguage);
            this.gameSettingsGroupBox.Controls.Add(this.chkShowTrapDamageFlyoffs);
            this.gameSettingsGroupBox.Location = new System.Drawing.Point(3, 192);
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
            this.groupBoxLoadout.Location = new System.Drawing.Point(0, 2);
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
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.gameModeTabControl);
            this.panel1.Controls.Add(this.btnDiscord);
            this.panel1.Controls.Add(this.chkDebug);
            this.panel1.Controls.Add(this.chkRunAs32);
            this.panel1.Controls.Add(this.btnResetConfig);
            this.panel1.Location = new System.Drawing.Point(587, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 588);
            this.panel1.TabIndex = 93;
            // 
            // gameModeTabControl
            // 
            this.gameModeTabControl.Controls.Add(this.gameModeSurvivalTab);
            this.gameModeTabControl.Controls.Add(this.gameModeSiegeTab);
            this.gameModeTabControl.ItemSize = new System.Drawing.Size(175, 18);
            this.gameModeTabControl.Location = new System.Drawing.Point(0, 33);
            this.gameModeTabControl.Name = "gameModeTabControl";
            this.gameModeTabControl.SelectedIndex = 0;
            this.gameModeTabControl.Size = new System.Drawing.Size(356, 520);
            this.gameModeTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.gameModeTabControl.TabIndex = 95;
            // 
            // gameModeSurvivalTab
            // 
            this.gameModeSurvivalTab.BackColor = System.Drawing.Color.PaleTurquoise;
            this.gameModeSurvivalTab.Controls.Add(this.battlegroundGroupBox);
            this.gameModeSurvivalTab.Controls.Add(this.survivalGameTabControl);
            this.gameModeSurvivalTab.Controls.Add(this.gameSettingsGroupBox);
            this.gameModeSurvivalTab.Location = new System.Drawing.Point(4, 22);
            this.gameModeSurvivalTab.Name = "gameModeSurvivalTab";
            this.gameModeSurvivalTab.Padding = new System.Windows.Forms.Padding(3);
            this.gameModeSurvivalTab.Size = new System.Drawing.Size(348, 494);
            this.gameModeSurvivalTab.TabIndex = 0;
            this.gameModeSurvivalTab.Text = "Survival";
            // 
            // gameModeSiegeTab
            // 
            this.gameModeSiegeTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(182)))), ((int)(((byte)(89)))));
            this.gameModeSiegeTab.Controls.Add(this.siegeGameTabControl);
            this.gameModeSiegeTab.Controls.Add(this.siegeGameSettingsGroupBox);
            this.gameModeSiegeTab.Location = new System.Drawing.Point(4, 22);
            this.gameModeSiegeTab.Name = "gameModeSiegeTab";
            this.gameModeSiegeTab.Padding = new System.Windows.Forms.Padding(3);
            this.gameModeSiegeTab.Size = new System.Drawing.Size(348, 494);
            this.gameModeSiegeTab.TabIndex = 1;
            this.gameModeSiegeTab.Text = "Siege";
            // 
            // siegeGameTabControl
            // 
            this.siegeGameTabControl.Controls.Add(this.tabPage7);
            this.siegeGameTabControl.Controls.Add(this.tabPage8);
            this.siegeGameTabControl.ItemSize = new System.Drawing.Size(170, 20);
            this.siegeGameTabControl.Location = new System.Drawing.Point(2, 56);
            this.siegeGameTabControl.Name = "siegeGameTabControl";
            this.siegeGameTabControl.SelectedIndex = 0;
            this.siegeGameTabControl.Size = new System.Drawing.Size(343, 435);
            this.siegeGameTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.siegeGameTabControl.TabIndex = 88;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.linkLabel1);
            this.tabPage7.Controls.Add(this.label6);
            this.tabPage7.Controls.Add(this.label7);
            this.tabPage7.Controls.Add(this.maskedTextBoxJoinSiegeGameLoadout);
            this.tabPage7.Controls.Add(this.label8);
            this.tabPage7.Controls.Add(this.btnJoinSiegeGame);
            this.tabPage7.Controls.Add(this.label9);
            this.tabPage7.Controls.Add(this.maskedTextBoxJoinSiegeGameHostIP);
            this.tabPage7.Location = new System.Drawing.Point(4, 24);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(335, 407);
            this.tabPage7.TabIndex = 0;
            this.tabPage7.Text = "Join Game";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(14, 9);
            this.linkLabel1.LinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.Location = new System.Drawing.Point(14, 99);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(304, 51);
            this.linkLabel1.TabIndex = 90;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Known Issues (Full List): \r\n - (Host) No voices, upgrades menu (close with U)\r\n -" +
    " (Client) If no skills join match again\r\n";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabel1.UseCompatibleTextRendering = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 13);
            this.label6.TabIndex = 89;
            this.label6.Text = "Enter the host IP and your loadout code below:";
            // 
            // maskedTextBoxJoinSiegeGameLoadout
            // 
            this.maskedTextBoxJoinSiegeGameLoadout.Location = new System.Drawing.Point(72, 195);
            this.maskedTextBoxJoinSiegeGameLoadout.Name = "maskedTextBoxJoinSiegeGameLoadout";
            this.maskedTextBoxJoinSiegeGameLoadout.Size = new System.Drawing.Size(246, 20);
            this.maskedTextBoxJoinSiegeGameLoadout.TabIndex = 86;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 87;
            this.label8.Text = "Loadout";
            // 
            // btnJoinSiegeGame
            // 
            this.btnJoinSiegeGame.BackColor = System.Drawing.Color.SpringGreen;
            this.btnJoinSiegeGame.Location = new System.Drawing.Point(196, 221);
            this.btnJoinSiegeGame.Name = "btnJoinSiegeGame";
            this.btnJoinSiegeGame.Size = new System.Drawing.Size(123, 60);
            this.btnJoinSiegeGame.TabIndex = 85;
            this.btnJoinSiegeGame.Text = "Join Match";
            this.btnJoinSiegeGame.UseVisualStyleBackColor = false;
            this.btnJoinSiegeGame.Click += new System.EventHandler(this.btnJoinSiegeGame_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 84;
            this.label9.Text = "Host IP";
            // 
            // maskedTextBoxJoinSiegeGameHostIP
            // 
            this.maskedTextBoxJoinSiegeGameHostIP.Location = new System.Drawing.Point(72, 221);
            this.maskedTextBoxJoinSiegeGameHostIP.Name = "maskedTextBoxJoinSiegeGameHostIP";
            this.maskedTextBoxJoinSiegeGameHostIP.Size = new System.Drawing.Size(118, 20);
            this.maskedTextBoxJoinSiegeGameHostIP.TabIndex = 73;
            this.maskedTextBoxJoinSiegeGameHostIP.TextChanged += new System.EventHandler(this.maskedTextBoxJoinSiegeGameHostIP_TextChanged);
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.groupBox1);
            this.tabPage8.Controls.Add(this.label21);
            this.tabPage8.Controls.Add(this.maskedTextBoxSiegeHostGamePlayer8Loadout);
            this.tabPage8.Controls.Add(this.maskedTextBoxSiegeHostGamePlayer6Loadout);
            this.tabPage8.Controls.Add(this.maskedTextBoxSiegeHostGamePlayer9Loadout);
            this.tabPage8.Controls.Add(this.maskedTextBoxSiegeHostGamePlayer7Loadout);
            this.tabPage8.Controls.Add(this.label2);
            this.tabPage8.Controls.Add(this.label4);
            this.tabPage8.Controls.Add(this.label18);
            this.tabPage8.Controls.Add(this.maskedTextBoxSiegeHostGamePlayer10Loadout);
            this.tabPage8.Controls.Add(this.label19);
            this.tabPage8.Controls.Add(this.label20);
            this.tabPage8.Controls.Add(this.label10);
            this.tabPage8.Controls.Add(this.label11);
            this.tabPage8.Controls.Add(this.maskedTextBoxSiegeHostGamePlayer3Loadout);
            this.tabPage8.Controls.Add(this.maskedTextBoxSiegeHostGamePlayer1Loadout);
            this.tabPage8.Controls.Add(this.maskedTextBoxSiegeHostGamePlayer4Loadout);
            this.tabPage8.Controls.Add(this.btnSiegeLaunch);
            this.tabPage8.Controls.Add(this.maskedTextBoxSiegeHostGamePlayer2Loadout);
            this.tabPage8.Controls.Add(this.label12);
            this.tabPage8.Controls.Add(this.label13);
            this.tabPage8.Controls.Add(this.label14);
            this.tabPage8.Controls.Add(this.maskedTextBoxSiegeHostGamePlayer5Loadout);
            this.tabPage8.Controls.Add(this.label15);
            this.tabPage8.Controls.Add(this.label16);
            this.tabPage8.Location = new System.Drawing.Point(4, 24);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(335, 407);
            this.tabPage8.TabIndex = 1;
            this.tabPage8.Text = "Host Game";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.comBoxSiegeDifficulty);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comBoxSiegeBattleground);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(3, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 56);
            this.groupBox1.TabIndex = 87;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Battleground";
            // 
            // comBoxSiegeDifficulty
            // 
            this.comBoxSiegeDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxSiegeDifficulty.Enabled = false;
            this.comBoxSiegeDifficulty.FormattingEnabled = true;
            this.comBoxSiegeDifficulty.Location = new System.Drawing.Point(205, 21);
            this.comBoxSiegeDifficulty.Name = "comBoxSiegeDifficulty";
            this.comBoxSiegeDifficulty.Size = new System.Drawing.Size(121, 21);
            this.comBoxSiegeDifficulty.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Difficulty";
            // 
            // comBoxSiegeBattleground
            // 
            this.comBoxSiegeBattleground.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxSiegeBattleground.FormattingEnabled = true;
            this.comBoxSiegeBattleground.Location = new System.Drawing.Point(32, 21);
            this.comBoxSiegeBattleground.Name = "comBoxSiegeBattleground";
            this.comBoxSiegeBattleground.Size = new System.Drawing.Size(108, 21);
            this.comBoxSiegeBattleground.TabIndex = 1;
            this.comBoxSiegeBattleground.SelectedIndexChanged += new System.EventHandler(this.comBoxSiegeBattleground_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Map";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(11, 211);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(170, 13);
            this.label21.TabIndex = 96;
            this.label21.Text = "Enter Enemy Team loadout codes:";
            // 
            // maskedTextBoxSiegeHostGamePlayer8Loadout
            // 
            this.maskedTextBoxSiegeHostGamePlayer8Loadout.Location = new System.Drawing.Point(72, 273);
            this.maskedTextBoxSiegeHostGamePlayer8Loadout.Name = "maskedTextBoxSiegeHostGamePlayer8Loadout";
            this.maskedTextBoxSiegeHostGamePlayer8Loadout.Size = new System.Drawing.Size(247, 20);
            this.maskedTextBoxSiegeHostGamePlayer8Loadout.TabIndex = 88;
            // 
            // maskedTextBoxSiegeHostGamePlayer6Loadout
            // 
            this.maskedTextBoxSiegeHostGamePlayer6Loadout.Location = new System.Drawing.Point(72, 229);
            this.maskedTextBoxSiegeHostGamePlayer6Loadout.Name = "maskedTextBoxSiegeHostGamePlayer6Loadout";
            this.maskedTextBoxSiegeHostGamePlayer6Loadout.Size = new System.Drawing.Size(247, 20);
            this.maskedTextBoxSiegeHostGamePlayer6Loadout.TabIndex = 86;
            // 
            // maskedTextBoxSiegeHostGamePlayer9Loadout
            // 
            this.maskedTextBoxSiegeHostGamePlayer9Loadout.Location = new System.Drawing.Point(72, 295);
            this.maskedTextBoxSiegeHostGamePlayer9Loadout.Name = "maskedTextBoxSiegeHostGamePlayer9Loadout";
            this.maskedTextBoxSiegeHostGamePlayer9Loadout.Size = new System.Drawing.Size(247, 20);
            this.maskedTextBoxSiegeHostGamePlayer9Loadout.TabIndex = 87;
            // 
            // maskedTextBoxSiegeHostGamePlayer7Loadout
            // 
            this.maskedTextBoxSiegeHostGamePlayer7Loadout.Location = new System.Drawing.Point(72, 251);
            this.maskedTextBoxSiegeHostGamePlayer7Loadout.Name = "maskedTextBoxSiegeHostGamePlayer7Loadout";
            this.maskedTextBoxSiegeHostGamePlayer7Loadout.Size = new System.Drawing.Size(247, 20);
            this.maskedTextBoxSiegeHostGamePlayer7Loadout.TabIndex = 89;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 92;
            this.label2.Text = "Player 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 95;
            this.label4.Text = "Player 5";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(24, 298);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(45, 13);
            this.label18.TabIndex = 93;
            this.label18.Text = "Player 4";
            // 
            // maskedTextBoxSiegeHostGamePlayer10Loadout
            // 
            this.maskedTextBoxSiegeHostGamePlayer10Loadout.Location = new System.Drawing.Point(72, 317);
            this.maskedTextBoxSiegeHostGamePlayer10Loadout.Name = "maskedTextBoxSiegeHostGamePlayer10Loadout";
            this.maskedTextBoxSiegeHostGamePlayer10Loadout.Size = new System.Drawing.Size(247, 20);
            this.maskedTextBoxSiegeHostGamePlayer10Loadout.TabIndex = 90;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(24, 232);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(45, 13);
            this.label19.TabIndex = 91;
            this.label19.Text = "Player 1";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(24, 276);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(45, 13);
            this.label20.TabIndex = 94;
            this.label20.Text = "Player 3";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 13);
            this.label11.TabIndex = 84;
            this.label11.Text = "Enter Your Team loadout codes:";
            // 
            // maskedTextBoxSiegeHostGamePlayer3Loadout
            // 
            this.maskedTextBoxSiegeHostGamePlayer3Loadout.Location = new System.Drawing.Point(72, 137);
            this.maskedTextBoxSiegeHostGamePlayer3Loadout.Name = "maskedTextBoxSiegeHostGamePlayer3Loadout";
            this.maskedTextBoxSiegeHostGamePlayer3Loadout.Size = new System.Drawing.Size(247, 20);
            this.maskedTextBoxSiegeHostGamePlayer3Loadout.TabIndex = 76;
            // 
            // maskedTextBoxSiegeHostGamePlayer1Loadout
            // 
            this.maskedTextBoxSiegeHostGamePlayer1Loadout.Enabled = false;
            this.maskedTextBoxSiegeHostGamePlayer1Loadout.Location = new System.Drawing.Point(72, 93);
            this.maskedTextBoxSiegeHostGamePlayer1Loadout.Name = "maskedTextBoxSiegeHostGamePlayer1Loadout";
            this.maskedTextBoxSiegeHostGamePlayer1Loadout.Size = new System.Drawing.Size(247, 20);
            this.maskedTextBoxSiegeHostGamePlayer1Loadout.TabIndex = 73;
            // 
            // maskedTextBoxSiegeHostGamePlayer4Loadout
            // 
            this.maskedTextBoxSiegeHostGamePlayer4Loadout.Location = new System.Drawing.Point(72, 159);
            this.maskedTextBoxSiegeHostGamePlayer4Loadout.Name = "maskedTextBoxSiegeHostGamePlayer4Loadout";
            this.maskedTextBoxSiegeHostGamePlayer4Loadout.Size = new System.Drawing.Size(247, 20);
            this.maskedTextBoxSiegeHostGamePlayer4Loadout.TabIndex = 75;
            // 
            // btnSiegeLaunch
            // 
            this.btnSiegeLaunch.BackColor = System.Drawing.Color.SpringGreen;
            this.btnSiegeLaunch.Location = new System.Drawing.Point(196, 342);
            this.btnSiegeLaunch.Name = "btnSiegeLaunch";
            this.btnSiegeLaunch.Size = new System.Drawing.Size(123, 60);
            this.btnSiegeLaunch.TabIndex = 0;
            this.btnSiegeLaunch.Text = "Launch Match";
            this.btnSiegeLaunch.UseVisualStyleBackColor = false;
            this.btnSiegeLaunch.Click += new System.EventHandler(this.btnSiegeLaunch_Click);
            // 
            // maskedTextBoxSiegeHostGamePlayer2Loadout
            // 
            this.maskedTextBoxSiegeHostGamePlayer2Loadout.Location = new System.Drawing.Point(72, 115);
            this.maskedTextBoxSiegeHostGamePlayer2Loadout.Name = "maskedTextBoxSiegeHostGamePlayer2Loadout";
            this.maskedTextBoxSiegeHostGamePlayer2Loadout.Size = new System.Drawing.Size(247, 20);
            this.maskedTextBoxSiegeHostGamePlayer2Loadout.TabIndex = 77;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 80;
            this.label12.Text = "Player 2";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 184);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 83;
            this.label13.Text = "Player 5";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(24, 162);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 13);
            this.label14.TabIndex = 81;
            this.label14.Text = "Player 4";
            // 
            // maskedTextBoxSiegeHostGamePlayer5Loadout
            // 
            this.maskedTextBoxSiegeHostGamePlayer5Loadout.Location = new System.Drawing.Point(72, 181);
            this.maskedTextBoxSiegeHostGamePlayer5Loadout.Name = "maskedTextBoxSiegeHostGamePlayer5Loadout";
            this.maskedTextBoxSiegeHostGamePlayer5Loadout.Size = new System.Drawing.Size(247, 20);
            this.maskedTextBoxSiegeHostGamePlayer5Loadout.TabIndex = 78;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 96);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 13);
            this.label15.TabIndex = 79;
            this.label15.Text = "Host (You)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(24, 140);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 13);
            this.label16.TabIndex = 82;
            this.label16.Text = "Player 3";
            // 
            // siegeGameSettingsGroupBox
            // 
            this.siegeGameSettingsGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.siegeGameSettingsGroupBox.Controls.Add(this.comBoxSiegeLanguage);
            this.siegeGameSettingsGroupBox.Controls.Add(this.labelSiegeLanguage);
            this.siegeGameSettingsGroupBox.Location = new System.Drawing.Point(3, 3);
            this.siegeGameSettingsGroupBox.Name = "siegeGameSettingsGroupBox";
            this.siegeGameSettingsGroupBox.Size = new System.Drawing.Size(342, 51);
            this.siegeGameSettingsGroupBox.TabIndex = 89;
            this.siegeGameSettingsGroupBox.TabStop = false;
            this.siegeGameSettingsGroupBox.Text = "Game Settings";
            // 
            // comBoxSiegeLanguage
            // 
            this.comBoxSiegeLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxSiegeLanguage.FormattingEnabled = true;
            this.comBoxSiegeLanguage.Location = new System.Drawing.Point(75, 20);
            this.comBoxSiegeLanguage.Name = "comBoxSiegeLanguage";
            this.comBoxSiegeLanguage.Size = new System.Drawing.Size(79, 21);
            this.comBoxSiegeLanguage.TabIndex = 11;
            this.comBoxSiegeLanguage.SelectedIndexChanged += new System.EventHandler(this.comBoxSiegeLanguage_SelectedIndexChanged);
            // 
            // labelSiegeLanguage
            // 
            this.labelSiegeLanguage.AutoSize = true;
            this.labelSiegeLanguage.Location = new System.Drawing.Point(14, 23);
            this.labelSiegeLanguage.Name = "labelSiegeLanguage";
            this.labelSiegeLanguage.Size = new System.Drawing.Size(55, 13);
            this.labelSiegeLanguage.TabIndex = 10;
            this.labelSiegeLanguage.Text = "Language";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.loadoutEditorTabControl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.modsPanel, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1299, 596);
            this.tableLayoutPanel1.TabIndex = 94;
            // 
            // loadoutEditorTabControl
            // 
            this.loadoutEditorTabControl.Controls.Add(this.loadoutEditorSurvivalTab);
            this.loadoutEditorTabControl.Controls.Add(this.loadoutEditorSiegeTab);
            this.loadoutEditorTabControl.ItemSize = new System.Drawing.Size(287, 20);
            this.loadoutEditorTabControl.Location = new System.Drawing.Point(3, 3);
            this.loadoutEditorTabControl.Name = "loadoutEditorTabControl";
            this.loadoutEditorTabControl.SelectedIndex = 0;
            this.loadoutEditorTabControl.Size = new System.Drawing.Size(578, 590);
            this.loadoutEditorTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.loadoutEditorTabControl.TabIndex = 23;
            // 
            // loadoutEditorSurvivalTab
            // 
            this.loadoutEditorSurvivalTab.BackColor = System.Drawing.SystemColors.Control;
            this.loadoutEditorSurvivalTab.Controls.Add(this.groupBoxLoadout);
            this.loadoutEditorSurvivalTab.Location = new System.Drawing.Point(4, 24);
            this.loadoutEditorSurvivalTab.Name = "loadoutEditorSurvivalTab";
            this.loadoutEditorSurvivalTab.Padding = new System.Windows.Forms.Padding(3);
            this.loadoutEditorSurvivalTab.Size = new System.Drawing.Size(570, 562);
            this.loadoutEditorSurvivalTab.TabIndex = 0;
            this.loadoutEditorSurvivalTab.Text = "Survival";
            // 
            // loadoutEditorSiegeTab
            // 
            this.loadoutEditorSiegeTab.BackColor = System.Drawing.SystemColors.Control;
            this.loadoutEditorSiegeTab.Controls.Add(this.siegeLoadoutEditorGroupBox);
            this.loadoutEditorSiegeTab.Location = new System.Drawing.Point(4, 24);
            this.loadoutEditorSiegeTab.Name = "loadoutEditorSiegeTab";
            this.loadoutEditorSiegeTab.Padding = new System.Windows.Forms.Padding(3);
            this.loadoutEditorSiegeTab.Size = new System.Drawing.Size(570, 562);
            this.loadoutEditorSiegeTab.TabIndex = 1;
            this.loadoutEditorSiegeTab.Text = "Siege";
            // 
            // siegeLoadoutEditorGroupBox
            // 
            this.siegeLoadoutEditorGroupBox.AutoSize = true;
            this.siegeLoadoutEditorGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.siegeLoadoutEditorGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.siegeLoadoutEditorGroupBox.Controls.Add(this.comBoxRole);
            this.siegeLoadoutEditorGroupBox.Controls.Add(this.roleLabel);
            this.siegeLoadoutEditorGroupBox.Controls.Add(this.comBoxSiegeBossWaveSlot2);
            this.siegeLoadoutEditorGroupBox.Controls.Add(this.label45);
            this.siegeLoadoutEditorGroupBox.Controls.Add(this.comBoxSiegeBossWaveSlot1);
            this.siegeLoadoutEditorGroupBox.Controls.Add(this.comBoxSiegeLv4WaveSlot2);
            this.siegeLoadoutEditorGroupBox.Controls.Add(this.label36);
            this.siegeLoadoutEditorGroupBox.Controls.Add(this.comBoxSiegeLv4WaveSlot1);
            this.siegeLoadoutEditorGroupBox.Controls.Add(this.comBoxSiegeLv3WaveSlot2);
            this.siegeLoadoutEditorGroupBox.Controls.Add(this.label34);
            this.siegeLoadoutEditorGroupBox.Controls.Add(this.comBoxSiegeLv3WaveSlot1);
            this.siegeLoadoutEditorGroupBox.Controls.Add(this.comBoxSiegeLv2WaveSlot2);
            this.siegeLoadoutEditorGroupBox.Controls.Add(this.label31);
            this.siegeLoadoutEditorGroupBox.Controls.Add(this.comBoxSiegeLv2WaveSlot1);
            this.siegeLoadoutEditorGroupBox.Controls.Add(this.comBoxSiegeLv1WaveSlot2);
            this.siegeLoadoutEditorGroupBox.Controls.Add(this.label30);
            this.siegeLoadoutEditorGroupBox.Controls.Add(this.comBoxSiegeLv1WaveSlot1);
            this.siegeLoadoutEditorGroupBox.Controls.Add(this.btnDeleteSiegeLoadout);
            this.siegeLoadoutEditorGroupBox.Controls.Add(this.label22);
            this.siegeLoadoutEditorGroupBox.Controls.Add(this.maskedTextBoxSiegePlayerName);
            this.siegeLoadoutEditorGroupBox.Controls.Add(this.label23);
            this.siegeLoadoutEditorGroupBox.Controls.Add(this.btnSaveSiegeLoadout);
            this.siegeLoadoutEditorGroupBox.Controls.Add(this.maskedTextBoxSiegeLoadoutName);
            this.siegeLoadoutEditorGroupBox.Controls.Add(this.btnCopySiegeLoadoutToClipboard);
            this.siegeLoadoutEditorGroupBox.Controls.Add(this.btnImportSiegeLoadout);
            this.siegeLoadoutEditorGroupBox.Controls.Add(this.label24);
            this.siegeLoadoutEditorGroupBox.Controls.Add(this.textBoxExportSiegeLoadout);
            this.siegeLoadoutEditorGroupBox.Controls.Add(this.maskedTextBoxImportSiegeLoadout);
            this.siegeLoadoutEditorGroupBox.Controls.Add(this.label25);
            this.siegeLoadoutEditorGroupBox.Controls.Add(this.comboxSiegeTraitYellowSlot);
            this.siegeLoadoutEditorGroupBox.Controls.Add(this.label26);
            this.siegeLoadoutEditorGroupBox.Controls.Add(this.comboxSiegeTraitNoBonusSlot);
            this.siegeLoadoutEditorGroupBox.Controls.Add(this.label27);
            this.siegeLoadoutEditorGroupBox.Controls.Add(this.comboxSiegeTraitGreenSlot);
            this.siegeLoadoutEditorGroupBox.Controls.Add(this.label28);
            this.siegeLoadoutEditorGroupBox.Controls.Add(this.comboxSiegeTraitBlueSlot);
            this.siegeLoadoutEditorGroupBox.Controls.Add(this.comBoxSiegeDye);
            this.siegeLoadoutEditorGroupBox.Controls.Add(this.label29);
            this.siegeLoadoutEditorGroupBox.Controls.Add(this.comBoxSiegeHero);
            this.siegeLoadoutEditorGroupBox.Controls.Add(this.comBoxSiegeSkin);
            this.siegeLoadoutEditorGroupBox.Controls.Add(this.label32);
            this.siegeLoadoutEditorGroupBox.Controls.Add(this.label33);
            this.siegeLoadoutEditorGroupBox.Controls.Add(this.comBoxSiegeLoadouts);
            this.siegeLoadoutEditorGroupBox.Controls.Add(this.label35);
            this.siegeLoadoutEditorGroupBox.Controls.Add(this.label37);
            this.siegeLoadoutEditorGroupBox.Controls.Add(this.label38);
            this.siegeLoadoutEditorGroupBox.Controls.Add(this.label39);
            this.siegeLoadoutEditorGroupBox.Controls.Add(this.label40);
            this.siegeLoadoutEditorGroupBox.Controls.Add(this.label41);
            this.siegeLoadoutEditorGroupBox.Controls.Add(this.label42);
            this.siegeLoadoutEditorGroupBox.Controls.Add(this.label43);
            this.siegeLoadoutEditorGroupBox.Controls.Add(this.label44);
            this.siegeLoadoutEditorGroupBox.Controls.Add(this.comBoxSiegeLoadoutSlot1);
            this.siegeLoadoutEditorGroupBox.Controls.Add(this.comBoxSiegeLoadoutSlot2);
            this.siegeLoadoutEditorGroupBox.Controls.Add(this.comBoxSiegeLoadoutSlot3);
            this.siegeLoadoutEditorGroupBox.Controls.Add(this.comBoxSiegeLoadoutSlot9);
            this.siegeLoadoutEditorGroupBox.Controls.Add(this.comBoxSiegeLoadoutSlot4);
            this.siegeLoadoutEditorGroupBox.Controls.Add(this.comBoxSiegeLoadoutSlot8);
            this.siegeLoadoutEditorGroupBox.Controls.Add(this.comBoxSiegeLoadoutSlot5);
            this.siegeLoadoutEditorGroupBox.Controls.Add(this.comBoxSiegeLoadoutSlot7);
            this.siegeLoadoutEditorGroupBox.Controls.Add(this.comBoxSiegeLoadoutSlot6);
            this.siegeLoadoutEditorGroupBox.Location = new System.Drawing.Point(0, 2);
            this.siegeLoadoutEditorGroupBox.Name = "siegeLoadoutEditorGroupBox";
            this.siegeLoadoutEditorGroupBox.Size = new System.Drawing.Size(568, 479);
            this.siegeLoadoutEditorGroupBox.TabIndex = 25;
            this.siegeLoadoutEditorGroupBox.TabStop = false;
            this.siegeLoadoutEditorGroupBox.Text = "Loadout Editor";
            // 
            // comBoxRole
            // 
            this.comBoxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxRole.FormattingEnabled = true;
            this.comBoxRole.Location = new System.Drawing.Point(42, 359);
            this.comBoxRole.Name = "comBoxRole";
            this.comBoxRole.Size = new System.Drawing.Size(162, 21);
            this.comBoxRole.TabIndex = 89;
            this.comBoxRole.SelectedIndexChanged += new System.EventHandler(this.comBoxRole_SelectedIndexChanged);
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Location = new System.Drawing.Point(8, 362);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(29, 13);
            this.roleLabel.TabIndex = 88;
            this.roleLabel.Text = "Role";
            // 
            // comBoxSiegeBossWaveSlot2
            // 
            this.comBoxSiegeBossWaveSlot2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxSiegeBossWaveSlot2.FormattingEnabled = true;
            this.comBoxSiegeBossWaveSlot2.Location = new System.Drawing.Point(432, 338);
            this.comBoxSiegeBossWaveSlot2.Name = "comBoxSiegeBossWaveSlot2";
            this.comBoxSiegeBossWaveSlot2.Size = new System.Drawing.Size(130, 21);
            this.comBoxSiegeBossWaveSlot2.TabIndex = 87;
            this.comBoxSiegeBossWaveSlot2.SelectedIndexChanged += new System.EventHandler(this.comBoxSiegeBossWaveSlot2_SelectedIndexChanged);
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(226, 342);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(67, 13);
            this.label45.TabIndex = 86;
            this.label45.Text = "Boss Waves";
            // 
            // comBoxSiegeBossWaveSlot1
            // 
            this.comBoxSiegeBossWaveSlot1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxSiegeBossWaveSlot1.FormattingEnabled = true;
            this.comBoxSiegeBossWaveSlot1.Location = new System.Drawing.Point(295, 338);
            this.comBoxSiegeBossWaveSlot1.Name = "comBoxSiegeBossWaveSlot1";
            this.comBoxSiegeBossWaveSlot1.Size = new System.Drawing.Size(130, 21);
            this.comBoxSiegeBossWaveSlot1.TabIndex = 85;
            this.comBoxSiegeBossWaveSlot1.SelectedIndexChanged += new System.EventHandler(this.comBoxSiegeBossWaveSlot1_SelectedIndexChanged);
            // 
            // comBoxSiegeLv4WaveSlot2
            // 
            this.comBoxSiegeLv4WaveSlot2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxSiegeLv4WaveSlot2.FormattingEnabled = true;
            this.comBoxSiegeLv4WaveSlot2.Location = new System.Drawing.Point(432, 306);
            this.comBoxSiegeLv4WaveSlot2.Name = "comBoxSiegeLv4WaveSlot2";
            this.comBoxSiegeLv4WaveSlot2.Size = new System.Drawing.Size(130, 21);
            this.comBoxSiegeLv4WaveSlot2.TabIndex = 84;
            this.comBoxSiegeLv4WaveSlot2.SelectedIndexChanged += new System.EventHandler(this.comBoxSiegeLv4WaveSlot2_SelectedIndexChanged);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(228, 310);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(65, 13);
            this.label36.TabIndex = 83;
            this.label36.Text = "Lv 4 Waves";
            // 
            // comBoxSiegeLv4WaveSlot1
            // 
            this.comBoxSiegeLv4WaveSlot1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxSiegeLv4WaveSlot1.FormattingEnabled = true;
            this.comBoxSiegeLv4WaveSlot1.Location = new System.Drawing.Point(295, 306);
            this.comBoxSiegeLv4WaveSlot1.Name = "comBoxSiegeLv4WaveSlot1";
            this.comBoxSiegeLv4WaveSlot1.Size = new System.Drawing.Size(130, 21);
            this.comBoxSiegeLv4WaveSlot1.TabIndex = 82;
            this.comBoxSiegeLv4WaveSlot1.SelectedIndexChanged += new System.EventHandler(this.comBoxSiegeLv4WaveSlot1_SelectedIndexChanged);
            // 
            // comBoxSiegeLv3WaveSlot2
            // 
            this.comBoxSiegeLv3WaveSlot2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxSiegeLv3WaveSlot2.FormattingEnabled = true;
            this.comBoxSiegeLv3WaveSlot2.Location = new System.Drawing.Point(432, 279);
            this.comBoxSiegeLv3WaveSlot2.Name = "comBoxSiegeLv3WaveSlot2";
            this.comBoxSiegeLv3WaveSlot2.Size = new System.Drawing.Size(130, 21);
            this.comBoxSiegeLv3WaveSlot2.TabIndex = 81;
            this.comBoxSiegeLv3WaveSlot2.SelectedIndexChanged += new System.EventHandler(this.comBoxSiegeLv3WaveSlot2_SelectedIndexChanged);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(228, 283);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(65, 13);
            this.label34.TabIndex = 80;
            this.label34.Text = "Lv 3 Waves";
            // 
            // comBoxSiegeLv3WaveSlot1
            // 
            this.comBoxSiegeLv3WaveSlot1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxSiegeLv3WaveSlot1.FormattingEnabled = true;
            this.comBoxSiegeLv3WaveSlot1.Location = new System.Drawing.Point(295, 279);
            this.comBoxSiegeLv3WaveSlot1.Name = "comBoxSiegeLv3WaveSlot1";
            this.comBoxSiegeLv3WaveSlot1.Size = new System.Drawing.Size(130, 21);
            this.comBoxSiegeLv3WaveSlot1.TabIndex = 79;
            this.comBoxSiegeLv3WaveSlot1.SelectedIndexChanged += new System.EventHandler(this.comBoxSiegeLv3WaveSlot1_SelectedIndexChanged);
            // 
            // comBoxSiegeLv2WaveSlot2
            // 
            this.comBoxSiegeLv2WaveSlot2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxSiegeLv2WaveSlot2.FormattingEnabled = true;
            this.comBoxSiegeLv2WaveSlot2.Location = new System.Drawing.Point(432, 252);
            this.comBoxSiegeLv2WaveSlot2.Name = "comBoxSiegeLv2WaveSlot2";
            this.comBoxSiegeLv2WaveSlot2.Size = new System.Drawing.Size(130, 21);
            this.comBoxSiegeLv2WaveSlot2.TabIndex = 78;
            this.comBoxSiegeLv2WaveSlot2.SelectedIndexChanged += new System.EventHandler(this.comBoxSiegeLv2WaveSlot2_SelectedIndexChanged);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(228, 256);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(65, 13);
            this.label31.TabIndex = 77;
            this.label31.Text = "Lv 2 Waves";
            // 
            // comBoxSiegeLv2WaveSlot1
            // 
            this.comBoxSiegeLv2WaveSlot1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxSiegeLv2WaveSlot1.FormattingEnabled = true;
            this.comBoxSiegeLv2WaveSlot1.Location = new System.Drawing.Point(295, 252);
            this.comBoxSiegeLv2WaveSlot1.Name = "comBoxSiegeLv2WaveSlot1";
            this.comBoxSiegeLv2WaveSlot1.Size = new System.Drawing.Size(130, 21);
            this.comBoxSiegeLv2WaveSlot1.TabIndex = 76;
            this.comBoxSiegeLv2WaveSlot1.SelectedIndexChanged += new System.EventHandler(this.comBoxSiegeLv2WaveSlot1_SelectedIndexChanged);
            // 
            // comBoxSiegeLv1WaveSlot2
            // 
            this.comBoxSiegeLv1WaveSlot2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxSiegeLv1WaveSlot2.FormattingEnabled = true;
            this.comBoxSiegeLv1WaveSlot2.Location = new System.Drawing.Point(432, 225);
            this.comBoxSiegeLv1WaveSlot2.Name = "comBoxSiegeLv1WaveSlot2";
            this.comBoxSiegeLv1WaveSlot2.Size = new System.Drawing.Size(130, 21);
            this.comBoxSiegeLv1WaveSlot2.TabIndex = 75;
            this.comBoxSiegeLv1WaveSlot2.SelectedIndexChanged += new System.EventHandler(this.comBoxSiegeLv1WaveSlot2_SelectedIndexChanged);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(228, 229);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(65, 13);
            this.label30.TabIndex = 74;
            this.label30.Text = "Lv 1 Waves";
            // 
            // comBoxSiegeLv1WaveSlot1
            // 
            this.comBoxSiegeLv1WaveSlot1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxSiegeLv1WaveSlot1.FormattingEnabled = true;
            this.comBoxSiegeLv1WaveSlot1.Location = new System.Drawing.Point(295, 225);
            this.comBoxSiegeLv1WaveSlot1.Name = "comBoxSiegeLv1WaveSlot1";
            this.comBoxSiegeLv1WaveSlot1.Size = new System.Drawing.Size(130, 21);
            this.comBoxSiegeLv1WaveSlot1.TabIndex = 73;
            this.comBoxSiegeLv1WaveSlot1.SelectedIndexChanged += new System.EventHandler(this.comBoxSiegeLv1WaveSlot1_SelectedIndexChanged);
            // 
            // btnDeleteSiegeLoadout
            // 
            this.btnDeleteSiegeLoadout.BackColor = System.Drawing.Color.Tomato;
            this.btnDeleteSiegeLoadout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteSiegeLoadout.Location = new System.Drawing.Point(6, 438);
            this.btnDeleteSiegeLoadout.Name = "btnDeleteSiegeLoadout";
            this.btnDeleteSiegeLoadout.Size = new System.Drawing.Size(159, 22);
            this.btnDeleteSiegeLoadout.TabIndex = 72;
            this.btnDeleteSiegeLoadout.Text = "Delete selected Loadout";
            this.btnDeleteSiegeLoadout.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeleteSiegeLoadout.UseVisualStyleBackColor = false;
            this.btnDeleteSiegeLoadout.Click += new System.EventHandler(this.btnDeleteSiegeLoadout_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 402);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(67, 13);
            this.label22.TabIndex = 71;
            this.label22.Text = "Player Name";
            // 
            // maskedTextBoxSiegePlayerName
            // 
            this.maskedTextBoxSiegePlayerName.Location = new System.Drawing.Point(79, 399);
            this.maskedTextBoxSiegePlayerName.Name = "maskedTextBoxSiegePlayerName";
            this.maskedTextBoxSiegePlayerName.Size = new System.Drawing.Size(99, 20);
            this.maskedTextBoxSiegePlayerName.TabIndex = 70;
            this.maskedTextBoxSiegePlayerName.TextChanged += new System.EventHandler(this.maskedTextBoxSiegePlayerName_TextChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(184, 402);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(77, 13);
            this.label23.TabIndex = 69;
            this.label23.Text = "Loadout Name";
            // 
            // btnSaveSiegeLoadout
            // 
            this.btnSaveSiegeLoadout.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnSaveSiegeLoadout.Location = new System.Drawing.Point(503, 386);
            this.btnSaveSiegeLoadout.Name = "btnSaveSiegeLoadout";
            this.btnSaveSiegeLoadout.Size = new System.Drawing.Size(59, 44);
            this.btnSaveSiegeLoadout.TabIndex = 67;
            this.btnSaveSiegeLoadout.Text = "Save Loadout";
            this.btnSaveSiegeLoadout.UseVisualStyleBackColor = false;
            this.btnSaveSiegeLoadout.Click += new System.EventHandler(this.btnSaveSiegeLoadout_Click);
            // 
            // maskedTextBoxSiegeLoadoutName
            // 
            this.maskedTextBoxSiegeLoadoutName.Location = new System.Drawing.Point(267, 399);
            this.maskedTextBoxSiegeLoadoutName.Name = "maskedTextBoxSiegeLoadoutName";
            this.maskedTextBoxSiegeLoadoutName.Size = new System.Drawing.Size(230, 20);
            this.maskedTextBoxSiegeLoadoutName.TabIndex = 68;
            this.maskedTextBoxSiegeLoadoutName.TextChanged += new System.EventHandler(this.maskedTextBoxSiegeLoadoutName_TextChanged);
            // 
            // btnCopySiegeLoadoutToClipboard
            // 
            this.btnCopySiegeLoadoutToClipboard.Location = new System.Drawing.Point(520, 440);
            this.btnCopySiegeLoadoutToClipboard.Name = "btnCopySiegeLoadoutToClipboard";
            this.btnCopySiegeLoadoutToClipboard.Size = new System.Drawing.Size(42, 20);
            this.btnCopySiegeLoadoutToClipboard.TabIndex = 27;
            this.btnCopySiegeLoadoutToClipboard.Text = "Copy";
            this.btnCopySiegeLoadoutToClipboard.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCopySiegeLoadoutToClipboard.UseVisualStyleBackColor = true;
            this.btnCopySiegeLoadoutToClipboard.Click += new System.EventHandler(this.btnCopySiegeLoadoutToClipboard_Click);
            // 
            // btnImportSiegeLoadout
            // 
            this.btnImportSiegeLoadout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImportSiegeLoadout.Location = new System.Drawing.Point(517, 19);
            this.btnImportSiegeLoadout.Name = "btnImportSiegeLoadout";
            this.btnImportSiegeLoadout.Size = new System.Drawing.Size(45, 20);
            this.btnImportSiegeLoadout.TabIndex = 28;
            this.btnImportSiegeLoadout.Text = "Import";
            this.btnImportSiegeLoadout.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImportSiegeLoadout.UseVisualStyleBackColor = true;
            this.btnImportSiegeLoadout.Click += new System.EventHandler(this.btnImportSiegeLoadout_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(191, 444);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(37, 13);
            this.label24.TabIndex = 66;
            this.label24.Text = "Export";
            // 
            // textBoxExportSiegeLoadout
            // 
            this.textBoxExportSiegeLoadout.Location = new System.Drawing.Point(234, 440);
            this.textBoxExportSiegeLoadout.Name = "textBoxExportSiegeLoadout";
            this.textBoxExportSiegeLoadout.ReadOnly = true;
            this.textBoxExportSiegeLoadout.Size = new System.Drawing.Size(280, 20);
            this.textBoxExportSiegeLoadout.TabIndex = 65;
            // 
            // maskedTextBoxImportSiegeLoadout
            // 
            this.maskedTextBoxImportSiegeLoadout.Location = new System.Drawing.Point(314, 19);
            this.maskedTextBoxImportSiegeLoadout.Name = "maskedTextBoxImportSiegeLoadout";
            this.maskedTextBoxImportSiegeLoadout.Size = new System.Drawing.Size(200, 20);
            this.maskedTextBoxImportSiegeLoadout.TabIndex = 64;
            this.maskedTextBoxImportSiegeLoadout.TextChanged += new System.EventHandler(this.maskedTextBoxImportSiegeLoadout_TextChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(278, 186);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(78, 13);
            this.label25.TabIndex = 35;
            this.label25.Text = "No Bonus Trait";
            // 
            // comboxSiegeTraitYellowSlot
            // 
            this.comboxSiegeTraitYellowSlot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxSiegeTraitYellowSlot.FormattingEnabled = true;
            this.comboxSiegeTraitYellowSlot.Location = new System.Drawing.Point(362, 101);
            this.comboxSiegeTraitYellowSlot.Name = "comboxSiegeTraitYellowSlot";
            this.comboxSiegeTraitYellowSlot.Size = new System.Drawing.Size(200, 21);
            this.comboxSiegeTraitYellowSlot.TabIndex = 32;
            this.comboxSiegeTraitYellowSlot.SelectedIndexChanged += new System.EventHandler(this.comboxSiegeTraitYellowSlot_SelectedIndexChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Gold;
            this.label26.Location = new System.Drawing.Point(278, 105);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(69, 13);
            this.label26.TabIndex = 34;
            this.label26.Text = "Triangle Trait";
            // 
            // comboxSiegeTraitNoBonusSlot
            // 
            this.comboxSiegeTraitNoBonusSlot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxSiegeTraitNoBonusSlot.FormattingEnabled = true;
            this.comboxSiegeTraitNoBonusSlot.Location = new System.Drawing.Point(362, 182);
            this.comboxSiegeTraitNoBonusSlot.Name = "comboxSiegeTraitNoBonusSlot";
            this.comboxSiegeTraitNoBonusSlot.Size = new System.Drawing.Size(200, 21);
            this.comboxSiegeTraitNoBonusSlot.TabIndex = 33;
            this.comboxSiegeTraitNoBonusSlot.SelectedIndexChanged += new System.EventHandler(this.comboxSiegeTraitNoBonusSlot_SelectedIndexChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label27.Location = new System.Drawing.Point(278, 159);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(73, 13);
            this.label27.TabIndex = 31;
            this.label27.Text = "Diamond Trait";
            // 
            // comboxSiegeTraitGreenSlot
            // 
            this.comboxSiegeTraitGreenSlot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxSiegeTraitGreenSlot.FormattingEnabled = true;
            this.comboxSiegeTraitGreenSlot.Location = new System.Drawing.Point(362, 128);
            this.comboxSiegeTraitGreenSlot.Name = "comboxSiegeTraitGreenSlot";
            this.comboxSiegeTraitGreenSlot.Size = new System.Drawing.Size(200, 21);
            this.comboxSiegeTraitGreenSlot.TabIndex = 28;
            this.comboxSiegeTraitGreenSlot.SelectedIndexChanged += new System.EventHandler(this.comboxSiegeTraitGreenSlot_SelectedIndexChanged);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.LightGreen;
            this.label28.Location = new System.Drawing.Point(278, 132);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(77, 13);
            this.label28.TabIndex = 30;
            this.label28.Text = "Pentagon Trait";
            // 
            // comboxSiegeTraitBlueSlot
            // 
            this.comboxSiegeTraitBlueSlot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxSiegeTraitBlueSlot.FormattingEnabled = true;
            this.comboxSiegeTraitBlueSlot.Location = new System.Drawing.Point(362, 155);
            this.comboxSiegeTraitBlueSlot.Name = "comboxSiegeTraitBlueSlot";
            this.comboxSiegeTraitBlueSlot.Size = new System.Drawing.Size(200, 21);
            this.comboxSiegeTraitBlueSlot.TabIndex = 29;
            this.comboxSiegeTraitBlueSlot.SelectedIndexChanged += new System.EventHandler(this.comboxSiegeTraitBlueSlot_SelectedIndexChanged);
            // 
            // comBoxSiegeDye
            // 
            this.comBoxSiegeDye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxSiegeDye.FormattingEnabled = true;
            this.comBoxSiegeDye.Location = new System.Drawing.Point(451, 60);
            this.comBoxSiegeDye.Name = "comBoxSiegeDye";
            this.comBoxSiegeDye.Size = new System.Drawing.Size(111, 21);
            this.comBoxSiegeDye.TabIndex = 6;
            this.comBoxSiegeDye.SelectedIndexChanged += new System.EventHandler(this.comBoxSiegeDye_SelectedIndexChanged);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(6, 63);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(30, 13);
            this.label29.TabIndex = 1;
            this.label29.Text = "Hero";
            // 
            // comBoxSiegeHero
            // 
            this.comBoxSiegeHero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxSiegeHero.FormattingEnabled = true;
            this.comBoxSiegeHero.Location = new System.Drawing.Point(42, 60);
            this.comBoxSiegeHero.Name = "comBoxSiegeHero";
            this.comBoxSiegeHero.Size = new System.Drawing.Size(126, 21);
            this.comBoxSiegeHero.TabIndex = 2;
            this.comBoxSiegeHero.SelectedIndexChanged += new System.EventHandler(this.comBoxSiegeHero_SelectedIndexChanged);
            // 
            // comBoxSiegeSkin
            // 
            this.comBoxSiegeSkin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxSiegeSkin.FormattingEnabled = true;
            this.comBoxSiegeSkin.Location = new System.Drawing.Point(210, 60);
            this.comBoxSiegeSkin.Name = "comBoxSiegeSkin";
            this.comBoxSiegeSkin.Size = new System.Drawing.Size(190, 21);
            this.comBoxSiegeSkin.TabIndex = 4;
            this.comBoxSiegeSkin.SelectedIndexChanged += new System.EventHandler(this.comBoxSiegeSkin_SelectedIndexChanged);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(419, 63);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(26, 13);
            this.label32.TabIndex = 5;
            this.label32.Text = "Dye";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(176, 63);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(28, 13);
            this.label33.TabIndex = 3;
            this.label33.Text = "Skin";
            // 
            // comBoxSiegeLoadouts
            // 
            this.comBoxSiegeLoadouts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxSiegeLoadouts.FormattingEnabled = true;
            this.comBoxSiegeLoadouts.Location = new System.Drawing.Point(9, 19);
            this.comBoxSiegeLoadouts.Name = "comBoxSiegeLoadouts";
            this.comBoxSiegeLoadouts.Size = new System.Drawing.Size(252, 21);
            this.comBoxSiegeLoadouts.TabIndex = 23;
            this.comBoxSiegeLoadouts.SelectedIndexChanged += new System.EventHandler(this.comBoxSiegeLoadouts_SelectedIndexChanged);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(5, 320);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(34, 13);
            this.label35.TabIndex = 17;
            this.label35.Text = "Slot 9";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(5, 293);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(34, 13);
            this.label37.TabIndex = 16;
            this.label37.Text = "Slot 8";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(5, 266);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(34, 13);
            this.label38.TabIndex = 15;
            this.label38.Text = "Slot 7";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(5, 239);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(34, 13);
            this.label39.TabIndex = 14;
            this.label39.Text = "Slot 6";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(5, 212);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(34, 13);
            this.label40.TabIndex = 13;
            this.label40.Text = "Slot 5";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(5, 185);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(34, 13);
            this.label41.TabIndex = 12;
            this.label41.Text = "Slot 4";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(5, 158);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(34, 13);
            this.label42.TabIndex = 11;
            this.label42.Text = "Slot 3";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(5, 131);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(34, 13);
            this.label43.TabIndex = 10;
            this.label43.Text = "Slot 2";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(5, 104);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(34, 13);
            this.label44.TabIndex = 9;
            this.label44.Text = "Slot 1";
            // 
            // comBoxSiegeLoadoutSlot1
            // 
            this.comBoxSiegeLoadoutSlot1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxSiegeLoadoutSlot1.FormattingEnabled = true;
            this.comBoxSiegeLoadoutSlot1.Location = new System.Drawing.Point(45, 101);
            this.comBoxSiegeLoadoutSlot1.Name = "comBoxSiegeLoadoutSlot1";
            this.comBoxSiegeLoadoutSlot1.Size = new System.Drawing.Size(159, 21);
            this.comBoxSiegeLoadoutSlot1.TabIndex = 0;
            this.comBoxSiegeLoadoutSlot1.SelectedIndexChanged += new System.EventHandler(this.comBoxSiegeLoadoutSlot1_SelectedIndexChanged);
            // 
            // comBoxSiegeLoadoutSlot2
            // 
            this.comBoxSiegeLoadoutSlot2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxSiegeLoadoutSlot2.FormattingEnabled = true;
            this.comBoxSiegeLoadoutSlot2.Location = new System.Drawing.Point(45, 128);
            this.comBoxSiegeLoadoutSlot2.Name = "comBoxSiegeLoadoutSlot2";
            this.comBoxSiegeLoadoutSlot2.Size = new System.Drawing.Size(159, 21);
            this.comBoxSiegeLoadoutSlot2.TabIndex = 1;
            this.comBoxSiegeLoadoutSlot2.SelectedIndexChanged += new System.EventHandler(this.comBoxSiegeLoadoutSlot2_SelectedIndexChanged);
            // 
            // comBoxSiegeLoadoutSlot3
            // 
            this.comBoxSiegeLoadoutSlot3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxSiegeLoadoutSlot3.FormattingEnabled = true;
            this.comBoxSiegeLoadoutSlot3.Location = new System.Drawing.Point(45, 155);
            this.comBoxSiegeLoadoutSlot3.Name = "comBoxSiegeLoadoutSlot3";
            this.comBoxSiegeLoadoutSlot3.Size = new System.Drawing.Size(159, 21);
            this.comBoxSiegeLoadoutSlot3.TabIndex = 2;
            this.comBoxSiegeLoadoutSlot3.SelectedIndexChanged += new System.EventHandler(this.comBoxSiegeLoadoutSlot3_SelectedIndexChanged);
            // 
            // comBoxSiegeLoadoutSlot9
            // 
            this.comBoxSiegeLoadoutSlot9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxSiegeLoadoutSlot9.FormattingEnabled = true;
            this.comBoxSiegeLoadoutSlot9.Location = new System.Drawing.Point(45, 317);
            this.comBoxSiegeLoadoutSlot9.Name = "comBoxSiegeLoadoutSlot9";
            this.comBoxSiegeLoadoutSlot9.Size = new System.Drawing.Size(159, 21);
            this.comBoxSiegeLoadoutSlot9.TabIndex = 8;
            this.comBoxSiegeLoadoutSlot9.SelectedIndexChanged += new System.EventHandler(this.comBoxSiegeLoadoutSlot9_SelectedIndexChanged);
            // 
            // comBoxSiegeLoadoutSlot4
            // 
            this.comBoxSiegeLoadoutSlot4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxSiegeLoadoutSlot4.FormattingEnabled = true;
            this.comBoxSiegeLoadoutSlot4.Location = new System.Drawing.Point(45, 182);
            this.comBoxSiegeLoadoutSlot4.Name = "comBoxSiegeLoadoutSlot4";
            this.comBoxSiegeLoadoutSlot4.Size = new System.Drawing.Size(159, 21);
            this.comBoxSiegeLoadoutSlot4.TabIndex = 3;
            this.comBoxSiegeLoadoutSlot4.SelectedIndexChanged += new System.EventHandler(this.comBoxSiegeLoadoutSlot4_SelectedIndexChanged);
            // 
            // comBoxSiegeLoadoutSlot8
            // 
            this.comBoxSiegeLoadoutSlot8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxSiegeLoadoutSlot8.FormattingEnabled = true;
            this.comBoxSiegeLoadoutSlot8.Location = new System.Drawing.Point(45, 290);
            this.comBoxSiegeLoadoutSlot8.Name = "comBoxSiegeLoadoutSlot8";
            this.comBoxSiegeLoadoutSlot8.Size = new System.Drawing.Size(159, 21);
            this.comBoxSiegeLoadoutSlot8.TabIndex = 7;
            this.comBoxSiegeLoadoutSlot8.SelectedIndexChanged += new System.EventHandler(this.comBoxSiegeLoadoutSlot8_SelectedIndexChanged);
            // 
            // comBoxSiegeLoadoutSlot5
            // 
            this.comBoxSiegeLoadoutSlot5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxSiegeLoadoutSlot5.FormattingEnabled = true;
            this.comBoxSiegeLoadoutSlot5.Location = new System.Drawing.Point(45, 209);
            this.comBoxSiegeLoadoutSlot5.Name = "comBoxSiegeLoadoutSlot5";
            this.comBoxSiegeLoadoutSlot5.Size = new System.Drawing.Size(159, 21);
            this.comBoxSiegeLoadoutSlot5.TabIndex = 4;
            this.comBoxSiegeLoadoutSlot5.SelectedIndexChanged += new System.EventHandler(this.comBoxSiegeLoadoutSlot5_SelectedIndexChanged);
            // 
            // comBoxSiegeLoadoutSlot7
            // 
            this.comBoxSiegeLoadoutSlot7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxSiegeLoadoutSlot7.FormattingEnabled = true;
            this.comBoxSiegeLoadoutSlot7.Location = new System.Drawing.Point(45, 263);
            this.comBoxSiegeLoadoutSlot7.Name = "comBoxSiegeLoadoutSlot7";
            this.comBoxSiegeLoadoutSlot7.Size = new System.Drawing.Size(159, 21);
            this.comBoxSiegeLoadoutSlot7.TabIndex = 6;
            this.comBoxSiegeLoadoutSlot7.SelectedIndexChanged += new System.EventHandler(this.comBoxSiegeLoadoutSlot7_SelectedIndexChanged);
            // 
            // comBoxSiegeLoadoutSlot6
            // 
            this.comBoxSiegeLoadoutSlot6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxSiegeLoadoutSlot6.FormattingEnabled = true;
            this.comBoxSiegeLoadoutSlot6.Location = new System.Drawing.Point(45, 236);
            this.comBoxSiegeLoadoutSlot6.Name = "comBoxSiegeLoadoutSlot6";
            this.comBoxSiegeLoadoutSlot6.Size = new System.Drawing.Size(159, 21);
            this.comBoxSiegeLoadoutSlot6.TabIndex = 5;
            this.comBoxSiegeLoadoutSlot6.SelectedIndexChanged += new System.EventHandler(this.comBoxSiegeLoadoutSlot6_SelectedIndexChanged);
            // 
            // LauncherMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1318, 607);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelLoadoutEditor);
            this.Name = "LauncherMainForm";
            this.Text = "Project Rechained Launcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.battlegroundGroupBox.ResumeLayout(false);
            this.battlegroundGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startingCoinInput)).EndInit();
            this.modsGroupBox.ResumeLayout(false);
            this.modsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.survivalGameTabControl.ResumeLayout(false);
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
            this.gameModeTabControl.ResumeLayout(false);
            this.gameModeSurvivalTab.ResumeLayout(false);
            this.gameModeSiegeTab.ResumeLayout(false);
            this.siegeGameTabControl.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.siegeGameSettingsGroupBox.ResumeLayout(false);
            this.siegeGameSettingsGroupBox.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.loadoutEditorTabControl.ResumeLayout(false);
            this.loadoutEditorSurvivalTab.ResumeLayout(false);
            this.loadoutEditorSurvivalTab.PerformLayout();
            this.loadoutEditorSiegeTab.ResumeLayout(false);
            this.loadoutEditorSiegeTab.PerformLayout();
            this.siegeLoadoutEditorGroupBox.ResumeLayout(false);
            this.siegeLoadoutEditorGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Label label3;
        private ComboBox comBoxSiegeBattleground;
        private Label label5;
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
    }
}

