namespace SingleplayerLauncher
{
    partial class LoadoutEditor
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
            this.cmbTrap1 = new System.Windows.Forms.ComboBox();
            this.cmbTrap2 = new System.Windows.Forms.ComboBox();
            this.cmbTrap3 = new System.Windows.Forms.ComboBox();
            this.cmbTrap4 = new System.Windows.Forms.ComboBox();
            this.cmbTrap5 = new System.Windows.Forms.ComboBox();
            this.cmbTrap6 = new System.Windows.Forms.ComboBox();
            this.cmbTrap7 = new System.Windows.Forms.ComboBox();
            this.cmbTrap8 = new System.Windows.Forms.ComboBox();
            this.cmbTrap9 = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbHero = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmbTrap1
            // 
            this.cmbTrap1.FormattingEnabled = true;
            this.cmbTrap1.Location = new System.Drawing.Point(12, 37);
            this.cmbTrap1.Name = "cmbTrap1";
            this.cmbTrap1.Size = new System.Drawing.Size(216, 21);
            this.cmbTrap1.TabIndex = 0;
            // 
            // cmbTrap2
            // 
            this.cmbTrap2.FormattingEnabled = true;
            this.cmbTrap2.Location = new System.Drawing.Point(12, 64);
            this.cmbTrap2.Name = "cmbTrap2";
            this.cmbTrap2.Size = new System.Drawing.Size(216, 21);
            this.cmbTrap2.TabIndex = 1;
            // 
            // cmbTrap3
            // 
            this.cmbTrap3.FormattingEnabled = true;
            this.cmbTrap3.Location = new System.Drawing.Point(12, 91);
            this.cmbTrap3.Name = "cmbTrap3";
            this.cmbTrap3.Size = new System.Drawing.Size(216, 21);
            this.cmbTrap3.TabIndex = 2;
            // 
            // cmbTrap4
            // 
            this.cmbTrap4.FormattingEnabled = true;
            this.cmbTrap4.Location = new System.Drawing.Point(12, 118);
            this.cmbTrap4.Name = "cmbTrap4";
            this.cmbTrap4.Size = new System.Drawing.Size(216, 21);
            this.cmbTrap4.TabIndex = 3;
            // 
            // cmbTrap5
            // 
            this.cmbTrap5.FormattingEnabled = true;
            this.cmbTrap5.Location = new System.Drawing.Point(12, 145);
            this.cmbTrap5.Name = "cmbTrap5";
            this.cmbTrap5.Size = new System.Drawing.Size(216, 21);
            this.cmbTrap5.TabIndex = 4;
            // 
            // cmbTrap6
            // 
            this.cmbTrap6.FormattingEnabled = true;
            this.cmbTrap6.Location = new System.Drawing.Point(12, 172);
            this.cmbTrap6.Name = "cmbTrap6";
            this.cmbTrap6.Size = new System.Drawing.Size(216, 21);
            this.cmbTrap6.TabIndex = 5;
            // 
            // cmbTrap7
            // 
            this.cmbTrap7.FormattingEnabled = true;
            this.cmbTrap7.Location = new System.Drawing.Point(12, 199);
            this.cmbTrap7.Name = "cmbTrap7";
            this.cmbTrap7.Size = new System.Drawing.Size(216, 21);
            this.cmbTrap7.TabIndex = 6;
            // 
            // cmbTrap8
            // 
            this.cmbTrap8.FormattingEnabled = true;
            this.cmbTrap8.Location = new System.Drawing.Point(12, 226);
            this.cmbTrap8.Name = "cmbTrap8";
            this.cmbTrap8.Size = new System.Drawing.Size(216, 21);
            this.cmbTrap8.TabIndex = 7;
            // 
            // cmbTrap9
            // 
            this.cmbTrap9.FormattingEnabled = true;
            this.cmbTrap9.Location = new System.Drawing.Point(12, 253);
            this.cmbTrap9.Name = "cmbTrap9";
            this.cmbTrap9.Size = new System.Drawing.Size(216, 21);
            this.cmbTrap9.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 280);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(216, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbHero
            // 
            this.cmbHero.FormattingEnabled = true;
            this.cmbHero.Location = new System.Drawing.Point(12, 12);
            this.cmbHero.Name = "cmbHero";
            this.cmbHero.Size = new System.Drawing.Size(216, 21);
            this.cmbHero.TabIndex = 10;
            // 
            // LoadoutEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 315);
            this.Controls.Add(this.cmbHero);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbTrap9);
            this.Controls.Add(this.cmbTrap8);
            this.Controls.Add(this.cmbTrap7);
            this.Controls.Add(this.cmbTrap6);
            this.Controls.Add(this.cmbTrap5);
            this.Controls.Add(this.cmbTrap4);
            this.Controls.Add(this.cmbTrap3);
            this.Controls.Add(this.cmbTrap2);
            this.Controls.Add(this.cmbTrap1);
            this.Name = "LoadoutEditor";
            this.Text = "Loadout Editor";
            this.Load += new System.EventHandler(this.LoadoutEditor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTrap1;
        private System.Windows.Forms.ComboBox cmbTrap2;
        private System.Windows.Forms.ComboBox cmbTrap3;
        private System.Windows.Forms.ComboBox cmbTrap4;
        private System.Windows.Forms.ComboBox cmbTrap5;
        private System.Windows.Forms.ComboBox cmbTrap6;
        private System.Windows.Forms.ComboBox cmbTrap7;
        private System.Windows.Forms.ComboBox cmbTrap8;
        private System.Windows.Forms.ComboBox cmbTrap9;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbHero;
    }
}