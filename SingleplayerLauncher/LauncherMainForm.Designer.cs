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
            this.comBoxMap = new System.Windows.Forms.ComboBox();
            this.comBoxHero = new System.Windows.Forms.ComboBox();
            this.characterSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.comBoxDye = new System.Windows.Forms.ComboBox();
            this.labelDye = new System.Windows.Forms.Label();
            this.labelSkin = new System.Windows.Forms.Label();
            this.comBoxSkin = new System.Windows.Forms.ComboBox();
            this.labelHero = new System.Windows.Forms.Label();
            this.labelMap = new System.Windows.Forms.Label();
            this.chkCustomIni = new System.Windows.Forms.CheckBox();
            this.chkLog = new System.Windows.Forms.CheckBox();
            this.btnLoadoutEditor = new System.Windows.Forms.Button();
            this.mapSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.comBoxExtraDifficulty = new System.Windows.Forms.ComboBox();
            this.labelExtraDifficulty = new System.Windows.Forms.Label();
            this.comBoxDifficulty = new System.Windows.Forms.ComboBox();
            this.labelDifficulty = new System.Windows.Forms.Label();
            this.comBoxGameMode = new System.Windows.Forms.ComboBox();
            this.labelGameMode = new System.Windows.Forms.Label();
            this.btnResetConfig = new System.Windows.Forms.Button();
            this.btnMods = new System.Windows.Forms.Button();
            this.characterSettingsGroupBox.SuspendLayout();
            this.mapSettingsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLaunch
            // 
            this.btnLaunch.Location = new System.Drawing.Point(157, 205);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(191, 75);
            this.btnLaunch.TabIndex = 0;
            this.btnLaunch.Text = "Launch";
            this.btnLaunch.UseVisualStyleBackColor = true;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // comBoxMap
            // 
            this.comBoxMap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxMap.FormattingEnabled = true;
            this.comBoxMap.Location = new System.Drawing.Point(39, 19);
            this.comBoxMap.Name = "comBoxMap";
            this.comBoxMap.Size = new System.Drawing.Size(296, 21);
            this.comBoxMap.TabIndex = 1;
            this.comBoxMap.SelectedIndexChanged += new System.EventHandler(this.comBoxMap_SelectedIndexChanged);
            // 
            // comBoxHero
            // 
            this.comBoxHero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxHero.FormattingEnabled = true;
            this.comBoxHero.Location = new System.Drawing.Point(40, 21);
            this.comBoxHero.Name = "comBoxHero";
            this.comBoxHero.Size = new System.Drawing.Size(216, 21);
            this.comBoxHero.TabIndex = 2;
            this.comBoxHero.SelectedIndexChanged += new System.EventHandler(this.comBoxHero_SelectedIndexChanged);
            // 
            // characterSettingsGroupBox
            // 
            this.characterSettingsGroupBox.Controls.Add(this.comBoxDye);
            this.characterSettingsGroupBox.Controls.Add(this.labelDye);
            this.characterSettingsGroupBox.Controls.Add(this.labelSkin);
            this.characterSettingsGroupBox.Controls.Add(this.comBoxSkin);
            this.characterSettingsGroupBox.Controls.Add(this.labelHero);
            this.characterSettingsGroupBox.Controls.Add(this.comBoxHero);
            this.characterSettingsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.characterSettingsGroupBox.Name = "characterSettingsGroupBox";
            this.characterSettingsGroupBox.Size = new System.Drawing.Size(262, 78);
            this.characterSettingsGroupBox.TabIndex = 3;
            this.characterSettingsGroupBox.TabStop = false;
            this.characterSettingsGroupBox.Text = "Character Settings";
            // 
            // comBoxDye
            // 
            this.comBoxDye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxDye.FormattingEnabled = true;
            this.comBoxDye.Location = new System.Drawing.Point(181, 48);
            this.comBoxDye.Name = "comBoxDye";
            this.comBoxDye.Size = new System.Drawing.Size(75, 21);
            this.comBoxDye.TabIndex = 6;
            // 
            // labelDye
            // 
            this.labelDye.AutoSize = true;
            this.labelDye.Location = new System.Drawing.Point(153, 51);
            this.labelDye.Name = "labelDye";
            this.labelDye.Size = new System.Drawing.Size(26, 13);
            this.labelDye.TabIndex = 5;
            this.labelDye.Text = "Dye";
            // 
            // labelSkin
            // 
            this.labelSkin.AutoSize = true;
            this.labelSkin.Location = new System.Drawing.Point(6, 51);
            this.labelSkin.Name = "labelSkin";
            this.labelSkin.Size = new System.Drawing.Size(28, 13);
            this.labelSkin.TabIndex = 3;
            this.labelSkin.Text = "Skin";
            // 
            // comBoxSkin
            // 
            this.comBoxSkin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxSkin.FormattingEnabled = true;
            this.comBoxSkin.Location = new System.Drawing.Point(40, 48);
            this.comBoxSkin.Name = "comBoxSkin";
            this.comBoxSkin.Size = new System.Drawing.Size(111, 21);
            this.comBoxSkin.TabIndex = 4;
            // 
            // labelHero
            // 
            this.labelHero.AutoSize = true;
            this.labelHero.Location = new System.Drawing.Point(6, 24);
            this.labelHero.Name = "labelHero";
            this.labelHero.Size = new System.Drawing.Size(30, 13);
            this.labelHero.TabIndex = 1;
            this.labelHero.Text = "Hero";
            // 
            // labelMap
            // 
            this.labelMap.AutoSize = true;
            this.labelMap.Location = new System.Drawing.Point(5, 22);
            this.labelMap.Name = "labelMap";
            this.labelMap.Size = new System.Drawing.Size(28, 13);
            this.labelMap.TabIndex = 0;
            this.labelMap.Text = "Map";
            // 
            // chkCustomIni
            // 
            this.chkCustomIni.AutoSize = true;
            this.chkCustomIni.Location = new System.Drawing.Point(13, 205);
            this.chkCustomIni.Name = "chkCustomIni";
            this.chkCustomIni.Size = new System.Drawing.Size(77, 17);
            this.chkCustomIni.TabIndex = 4;
            this.chkCustomIni.Text = "Custom .ini";
            this.chkCustomIni.UseVisualStyleBackColor = true;
            this.chkCustomIni.CheckedChanged += new System.EventHandler(this.chkCustomIni_CheckedChanged);
            // 
            // chkLog
            // 
            this.chkLog.AutoSize = true;
            this.chkLog.Location = new System.Drawing.Point(12, 228);
            this.chkLog.Name = "chkLog";
            this.chkLog.Size = new System.Drawing.Size(44, 17);
            this.chkLog.TabIndex = 6;
            this.chkLog.Text = "Log";
            this.chkLog.UseVisualStyleBackColor = true;
            // 
            // btnLoadoutEditor
            // 
            this.btnLoadoutEditor.Location = new System.Drawing.Point(280, 17);
            this.btnLoadoutEditor.Name = "btnLoadoutEditor";
            this.btnLoadoutEditor.Size = new System.Drawing.Size(74, 73);
            this.btnLoadoutEditor.TabIndex = 7;
            this.btnLoadoutEditor.Text = "Loadout editor";
            this.btnLoadoutEditor.UseVisualStyleBackColor = true;
            this.btnLoadoutEditor.Click += new System.EventHandler(this.btnLoadoutEditor_Click);
            // 
            // mapSettingsGroupBox
            // 
            this.mapSettingsGroupBox.Controls.Add(this.comBoxExtraDifficulty);
            this.mapSettingsGroupBox.Controls.Add(this.labelExtraDifficulty);
            this.mapSettingsGroupBox.Controls.Add(this.comBoxDifficulty);
            this.mapSettingsGroupBox.Controls.Add(this.labelDifficulty);
            this.mapSettingsGroupBox.Controls.Add(this.comBoxGameMode);
            this.mapSettingsGroupBox.Controls.Add(this.labelGameMode);
            this.mapSettingsGroupBox.Controls.Add(this.comBoxMap);
            this.mapSettingsGroupBox.Controls.Add(this.labelMap);
            this.mapSettingsGroupBox.Location = new System.Drawing.Point(13, 96);
            this.mapSettingsGroupBox.Name = "mapSettingsGroupBox";
            this.mapSettingsGroupBox.Size = new System.Drawing.Size(341, 103);
            this.mapSettingsGroupBox.TabIndex = 8;
            this.mapSettingsGroupBox.TabStop = false;
            this.mapSettingsGroupBox.Text = "Map Settings";
            // 
            // comBoxExtraDifficulty
            // 
            this.comBoxExtraDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxExtraDifficulty.Enabled = false;
            this.comBoxExtraDifficulty.FormattingEnabled = true;
            this.comBoxExtraDifficulty.Location = new System.Drawing.Point(256, 73);
            this.comBoxExtraDifficulty.Name = "comBoxExtraDifficulty";
            this.comBoxExtraDifficulty.Size = new System.Drawing.Size(79, 21);
            this.comBoxExtraDifficulty.TabIndex = 9;
            // 
            // labelExtraDifficulty
            // 
            this.labelExtraDifficulty.AutoSize = true;
            this.labelExtraDifficulty.Location = new System.Drawing.Point(181, 77);
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
            this.comBoxDifficulty.Location = new System.Drawing.Point(53, 73);
            this.comBoxDifficulty.Name = "comBoxDifficulty";
            this.comBoxDifficulty.Size = new System.Drawing.Size(125, 21);
            this.comBoxDifficulty.TabIndex = 7;
            this.comBoxDifficulty.SelectedIndexChanged += new System.EventHandler(this.comBoxDifficulty_SelectedIndexChanged);
            // 
            // labelDifficulty
            // 
            this.labelDifficulty.AutoSize = true;
            this.labelDifficulty.Location = new System.Drawing.Point(5, 76);
            this.labelDifficulty.Name = "labelDifficulty";
            this.labelDifficulty.Size = new System.Drawing.Size(47, 13);
            this.labelDifficulty.TabIndex = 6;
            this.labelDifficulty.Text = "Difficulty";
            // 
            // comBoxGameMode
            // 
            this.comBoxGameMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxGameMode.Enabled = false;
            this.comBoxGameMode.FormattingEnabled = true;
            this.comBoxGameMode.Location = new System.Drawing.Point(39, 46);
            this.comBoxGameMode.Name = "comBoxGameMode";
            this.comBoxGameMode.Size = new System.Drawing.Size(139, 21);
            this.comBoxGameMode.TabIndex = 5;
            this.comBoxGameMode.SelectedIndexChanged += new System.EventHandler(this.comBoxGameMode_SelectedIndexChanged);
            // 
            // labelGameMode
            // 
            this.labelGameMode.AutoSize = true;
            this.labelGameMode.Location = new System.Drawing.Point(5, 49);
            this.labelGameMode.Name = "labelGameMode";
            this.labelGameMode.Size = new System.Drawing.Size(34, 13);
            this.labelGameMode.TabIndex = 2;
            this.labelGameMode.Text = "Mode";
            // 
            // btnResetConfig
            // 
            this.btnResetConfig.Location = new System.Drawing.Point(259, 286);
            this.btnResetConfig.Name = "btnResetConfig";
            this.btnResetConfig.Size = new System.Drawing.Size(89, 24);
            this.btnResetConfig.TabIndex = 9;
            this.btnResetConfig.Text = "Reset Configs";
            this.btnResetConfig.UseVisualStyleBackColor = true;
            this.btnResetConfig.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMods
            // 
            this.btnMods.Location = new System.Drawing.Point(6, 263);
            this.btnMods.Name = "btnMods";
            this.btnMods.Size = new System.Drawing.Size(90, 85);
            this.btnMods.TabIndex = 10;
            this.btnMods.Text = "Mods";
            this.btnMods.UseVisualStyleBackColor = true;
            this.btnMods.Click += new System.EventHandler(this.btnMods_Click);
            // 
            // LauncherMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 376);
            this.Controls.Add(this.btnMods);
            this.Controls.Add(this.btnResetConfig);
            this.Controls.Add(this.mapSettingsGroupBox);
            this.Controls.Add(this.btnLoadoutEditor);
            this.Controls.Add(this.chkLog);
            this.Controls.Add(this.chkCustomIni);
            this.Controls.Add(this.characterSettingsGroupBox);
            this.Controls.Add(this.btnLaunch);
            this.Name = "LauncherMainForm";
            this.Text = "OMDU Offline Launcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.characterSettingsGroupBox.ResumeLayout(false);
            this.characterSettingsGroupBox.PerformLayout();
            this.mapSettingsGroupBox.ResumeLayout(false);
            this.mapSettingsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.ComboBox comBoxMap;
        private System.Windows.Forms.ComboBox comBoxHero;
        private System.Windows.Forms.GroupBox characterSettingsGroupBox;
        private System.Windows.Forms.Label labelHero;
        private System.Windows.Forms.Label labelMap;
        private System.Windows.Forms.CheckBox chkCustomIni;
        private System.Windows.Forms.CheckBox chkLog;
        private System.Windows.Forms.Label labelSkin;
        private System.Windows.Forms.ComboBox comBoxSkin;
        private System.Windows.Forms.Label labelDye;
        private System.Windows.Forms.ComboBox comBoxDye;
        private System.Windows.Forms.Button btnLoadoutEditor;
        private System.Windows.Forms.GroupBox mapSettingsGroupBox;
        private System.Windows.Forms.ComboBox comBoxDifficulty;
        private System.Windows.Forms.Label labelDifficulty;
        private System.Windows.Forms.ComboBox comBoxGameMode;
        private System.Windows.Forms.Label labelGameMode;
        private System.Windows.Forms.ComboBox comBoxExtraDifficulty;
        private System.Windows.Forms.Label labelExtraDifficulty;
        private System.Windows.Forms.Button btnResetConfig;
        private System.Windows.Forms.Button btnMods;
    }
}

