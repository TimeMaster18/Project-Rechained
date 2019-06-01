namespace SingleplayerLauncher
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comBoxDye = new System.Windows.Forms.ComboBox();
            this.labelDye = new System.Windows.Forms.Label();
            this.labelSkin = new System.Windows.Forms.Label();
            this.comBoxSkin = new System.Windows.Forms.ComboBox();
            this.labelHero = new System.Windows.Forms.Label();
            this.labelMap = new System.Windows.Forms.Label();
            this.chkCustomIni = new System.Windows.Forms.CheckBox();
            this.chkGodMode = new System.Windows.Forms.CheckBox();
            this.chkLog = new System.Windows.Forms.CheckBox();
            this.btnLoadoutEditor = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLaunch
            // 
            this.btnLaunch.Location = new System.Drawing.Point(77, 127);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(191, 75);
            this.btnLaunch.TabIndex = 0;
            this.btnLaunch.Text = "Launch";
            this.btnLaunch.UseVisualStyleBackColor = true;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // comBoxMap
            // 
            this.comBoxMap.FormattingEnabled = true;
            this.comBoxMap.Location = new System.Drawing.Point(40, 24);
            this.comBoxMap.Name = "comBoxMap";
            this.comBoxMap.Size = new System.Drawing.Size(216, 21);
            this.comBoxMap.TabIndex = 1;
            this.comBoxMap.Text = "Map";
            // 
            // comBoxHero
            // 
            this.comBoxHero.FormattingEnabled = true;
            this.comBoxHero.Location = new System.Drawing.Point(40, 52);
            this.comBoxHero.Name = "comBoxHero";
            this.comBoxHero.Size = new System.Drawing.Size(216, 21);
            this.comBoxHero.TabIndex = 2;
            this.comBoxHero.Text = "Hero";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comBoxDye);
            this.groupBox1.Controls.Add(this.labelDye);
            this.groupBox1.Controls.Add(this.labelSkin);
            this.groupBox1.Controls.Add(this.comBoxSkin);
            this.groupBox1.Controls.Add(this.labelHero);
            this.groupBox1.Controls.Add(this.comBoxHero);
            this.groupBox1.Controls.Add(this.labelMap);
            this.groupBox1.Controls.Add(this.comBoxMap);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 109);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Match Settings";
            // 
            // comBoxDye
            // 
            this.comBoxDye.FormattingEnabled = true;
            this.comBoxDye.Location = new System.Drawing.Point(181, 79);
            this.comBoxDye.Name = "comBoxDye";
            this.comBoxDye.Size = new System.Drawing.Size(75, 21);
            this.comBoxDye.TabIndex = 6;
            this.comBoxDye.Text = "Normal";
            // 
            // labelDye
            // 
            this.labelDye.AutoSize = true;
            this.labelDye.Location = new System.Drawing.Point(153, 82);
            this.labelDye.Name = "labelDye";
            this.labelDye.Size = new System.Drawing.Size(26, 13);
            this.labelDye.TabIndex = 5;
            this.labelDye.Text = "Dye";
            // 
            // labelSkin
            // 
            this.labelSkin.AutoSize = true;
            this.labelSkin.Location = new System.Drawing.Point(6, 82);
            this.labelSkin.Name = "labelSkin";
            this.labelSkin.Size = new System.Drawing.Size(28, 13);
            this.labelSkin.TabIndex = 3;
            this.labelSkin.Text = "Skin";
            // 
            // comBoxSkin
            // 
            this.comBoxSkin.Enabled = false;
            this.comBoxSkin.FormattingEnabled = true;
            this.comBoxSkin.Location = new System.Drawing.Point(40, 79);
            this.comBoxSkin.Name = "comBoxSkin";
            this.comBoxSkin.Size = new System.Drawing.Size(111, 21);
            this.comBoxSkin.TabIndex = 4;
            this.comBoxSkin.Text = "Default";
            // 
            // labelHero
            // 
            this.labelHero.AutoSize = true;
            this.labelHero.Location = new System.Drawing.Point(6, 55);
            this.labelHero.Name = "labelHero";
            this.labelHero.Size = new System.Drawing.Size(30, 13);
            this.labelHero.TabIndex = 1;
            this.labelHero.Text = "Hero";
            // 
            // labelMap
            // 
            this.labelMap.AutoSize = true;
            this.labelMap.Location = new System.Drawing.Point(6, 27);
            this.labelMap.Name = "labelMap";
            this.labelMap.Size = new System.Drawing.Size(28, 13);
            this.labelMap.TabIndex = 0;
            this.labelMap.Text = "Map";
            // 
            // chkCustomIni
            // 
            this.chkCustomIni.AutoSize = true;
            this.chkCustomIni.Location = new System.Drawing.Point(280, 40);
            this.chkCustomIni.Name = "chkCustomIni";
            this.chkCustomIni.Size = new System.Drawing.Size(77, 17);
            this.chkCustomIni.TabIndex = 4;
            this.chkCustomIni.Text = "Custom .ini";
            this.chkCustomIni.UseVisualStyleBackColor = true;
            this.chkCustomIni.CheckedChanged += new System.EventHandler(this.chkCustomIni_CheckedChanged);
            // 
            // chkGodMode
            // 
            this.chkGodMode.AutoSize = true;
            this.chkGodMode.Location = new System.Drawing.Point(280, 21);
            this.chkGodMode.Name = "chkGodMode";
            this.chkGodMode.Size = new System.Drawing.Size(76, 17);
            this.chkGodMode.TabIndex = 5;
            this.chkGodMode.Text = "God Mode";
            this.chkGodMode.UseVisualStyleBackColor = true;
            // 
            // chkLog
            // 
            this.chkLog.AutoSize = true;
            this.chkLog.Location = new System.Drawing.Point(13, 127);
            this.chkLog.Name = "chkLog";
            this.chkLog.Size = new System.Drawing.Size(44, 17);
            this.chkLog.TabIndex = 6;
            this.chkLog.Text = "Log";
            this.chkLog.UseVisualStyleBackColor = true;
            // 
            // btnLoadoutEditor
            // 
            this.btnLoadoutEditor.Location = new System.Drawing.Point(280, 127);
            this.btnLoadoutEditor.Name = "btnLoadoutEditor";
            this.btnLoadoutEditor.Size = new System.Drawing.Size(74, 75);
            this.btnLoadoutEditor.TabIndex = 7;
            this.btnLoadoutEditor.Text = "Loadout editor";
            this.btnLoadoutEditor.UseVisualStyleBackColor = true;
            this.btnLoadoutEditor.Click += new System.EventHandler(this.btnLoadoutEditor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 208);
            this.Controls.Add(this.btnLoadoutEditor);
            this.Controls.Add(this.chkLog);
            this.Controls.Add(this.chkGodMode);
            this.Controls.Add(this.chkCustomIni);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLaunch);
            this.Name = "Form1";
            this.Text = "OMDU Launcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.ComboBox comBoxMap;
        private System.Windows.Forms.ComboBox comBoxHero;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelHero;
        private System.Windows.Forms.Label labelMap;
        private System.Windows.Forms.CheckBox chkCustomIni;
        private System.Windows.Forms.CheckBox chkGodMode;
        private System.Windows.Forms.CheckBox chkLog;
        private System.Windows.Forms.Label labelSkin;
        private System.Windows.Forms.ComboBox comBoxSkin;
        private System.Windows.Forms.Label labelDye;
        private System.Windows.Forms.ComboBox comBoxDye;
        private System.Windows.Forms.Button btnLoadoutEditor;
    }
}

