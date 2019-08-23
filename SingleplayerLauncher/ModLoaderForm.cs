using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SingleplayerLauncher
{
    public partial class ModLoaderForm : Form
    {
        public ModLoaderForm()
        {
            InitializeComponent();
        }
        

        private void ModLoaderForm_Load(object sender, EventArgs e)
        {
            chkGodMode.Checked = Settings.Instance.ContainsKey("GodMode")? (bool)Settings.Instance["GodMode"] : false;
            chkNoTrapCap.Checked = Settings.Instance.ContainsKey("NoTrapCap") ? (bool)Settings.Instance["NoTrapCap"] : false;
        }
        private void chkGodMode_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGodMode.Checked)
            {
                Settings.Instance["GodMode"] = true;
                Settings.Save();
            }
            else
            {
                Settings.Instance["GodMode"] = false;
                Settings.Save();
            }
        }

        private void chkNoTrapCap_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNoTrapCap.Checked)
            {
                Settings.Instance["NoTrapCap"] = true;
                Settings.Save();
            }
            else
            {
                Settings.Instance["NoTrapCap"] = false;
                Settings.Save();
            }
        }
    }
}
