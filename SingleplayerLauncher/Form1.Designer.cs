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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkCustomIni = new System.Windows.Forms.CheckBox();
            this.chkGodMode = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLaunch
            // 
            this.btnLaunch.Location = new System.Drawing.Point(88, 105);
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
            this.comBoxMap.Location = new System.Drawing.Point(44, 24);
            this.comBoxMap.Name = "comBoxMap";
            this.comBoxMap.Size = new System.Drawing.Size(191, 21);
            this.comBoxMap.TabIndex = 1;
            this.comBoxMap.Text = "Map";
            // 
            // comBoxHero
            // 
            this.comBoxHero.FormattingEnabled = true;
            this.comBoxHero.Location = new System.Drawing.Point(44, 52);
            this.comBoxHero.Name = "comBoxHero";
            this.comBoxHero.Size = new System.Drawing.Size(191, 21);
            this.comBoxHero.TabIndex = 2;
            this.comBoxHero.Text = "Hero";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comBoxHero);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comBoxMap);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 87);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Match Settings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Map";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hero";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 188);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkCustomIni;
        private System.Windows.Forms.CheckBox chkGodMode;
    }
}

