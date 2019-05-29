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
            this.SuspendLayout();
            // 
            // btnLaunch
            // 
            this.btnLaunch.Location = new System.Drawing.Point(12, 68);
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
            this.comBoxMap.Location = new System.Drawing.Point(12, 12);
            this.comBoxMap.Name = "comboBox1";
            this.comBoxMap.Size = new System.Drawing.Size(191, 21);
            this.comBoxMap.TabIndex = 1;
            this.comBoxMap.Text = "Map";
            // 
            // comBoxHero
            // 
            this.comBoxHero.FormattingEnabled = true;
            this.comBoxHero.Location = new System.Drawing.Point(12, 39);
            this.comBoxHero.Name = "cmbHero";
            this.comBoxHero.Size = new System.Drawing.Size(191, 21);
            this.comBoxHero.TabIndex = 2;
            this.comBoxHero.Text = "Hero";
            // comBoxHero            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 155);
            this.Controls.Add(this.comBoxHero);
            this.Controls.Add(this.comBoxMap);
            this.Controls.Add(this.btnLaunch);
            this.Name = "Form1";
            this.Text = "OMDU Launcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.ComboBox comBoxMap;
        private System.Windows.Forms.ComboBox comBoxHero;
    }
}

