using System;
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
            chkGodMode.Checked = Settings.Instance.ContainsKey("GodMode") ? (bool)Settings.Instance["GodMode"] : false;
            chkNoTrapCap.Checked = Settings.Instance.ContainsKey("NoTrapCap") ? (bool)Settings.Instance["NoTrapCap"] : false;
            chkTrapsInTraps.Checked = Settings.Instance.ContainsKey("TrapsInTraps") ? (bool)Settings.Instance["TrapsInTraps"] : false;
            startingCoinInput.Value = Settings.Instance.ContainsKey("StartingCoin") ? Int32.Parse((string)Settings.Instance["StartingCoin"]) : 6000;
        }

        private void chkGodMode_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGodMode.Checked)
            {
                Settings.Instance["GodMode"] = true;
            }
            else
            {
                Settings.Instance["GodMode"] = false;
            }
            Settings.Save();
        }

        private void chkNoTrapCap_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNoTrapCap.Checked)
            {
                Settings.Instance["NoTrapCap"] = true;
            }
            else
            {
                Settings.Instance["NoTrapCap"] = false;
            }
            Settings.Save();
        }

        private void chkTrapsInTraps_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTrapsInTraps.Checked)
            {
                Settings.Instance["TrapsInTraps"] = true;
            }
            else
            {
                Settings.Instance["TrapsInTraps"] = false;
            }
            Settings.Save();
        }

        private void StartingCoinInput_ValueChanged(object sender, EventArgs e)
        {
            Settings.Instance["StartingCoin"] = startingCoinInput.Value.ToString();
            Settings.Save();
        }
    }
}
