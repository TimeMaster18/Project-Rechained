﻿using SingleplayerLauncher.Model;
using System;
using System.Windows.Forms;

namespace SingleplayerLauncher
{
    public partial class ModLoaderForm : Form
    {
        readonly GameInfo GameInfo = GameInfo.Instance;

        public ModLoaderForm()
        {
            InitializeComponent();
        }

        private void ModLoaderForm_Load(object sender, EventArgs e)
        {
            chkGodMode.Checked = Settings.Instance.ContainsKey("GodMode") ? (bool)Settings.Instance["GodMode"] : false;
            chkNoTrapCap.Checked = Settings.Instance.ContainsKey("NoTrapCap") ? (bool)Settings.Instance["NoTrapCap"] : false;
            chkTrapsInTraps.Checked = Settings.Instance.ContainsKey("TrapsInTraps") ? (bool)Settings.Instance["TrapsInTraps"] : false;
            chkHardcore.Checked = Settings.Instance.ContainsKey("Hardcore") ? (bool)Settings.Instance["Hardcore"] : false;
            chkNoLimitUniqueTraps.Checked = Settings.Instance.ContainsKey("NoLimitUniqueTraps") ? (bool)Settings.Instance["NoLimitUniqueTraps"] : false;
            chkNoTrapGrid.Checked = Settings.Instance.ContainsKey("NoTrapGrid") ? (bool)Settings.Instance["NoTrapGrid"] : false;
            chkTrapsAnySurface.Checked = Settings.Instance.ContainsKey("TrapsAnySurface") ? (bool)Settings.Instance["TrapsAnySurface"] : false;
            startingCoinInput.Value = Settings.Instance.ContainsKey("StartingCoin") ? Int32.Parse((string)Settings.Instance["StartingCoin"]) : GameInfo.Battleground.Map.StartingCoin;
        }

        private void chkGodMode_CheckedChanged(object sender, EventArgs e)
        {
            Mods.Mods.GodMode.IsEnabled = chkGodMode.Checked;
            Settings.Instance["GodMode"] = chkGodMode.Checked;
            Settings.Save();
        }

        private void chkNoTrapCap_CheckedChanged(object sender, EventArgs e)
        {
            Mods.Mods.NoTrapCap.IsEnabled = chkNoTrapCap.Checked;
            Settings.Instance["NoTrapCap"] = chkNoTrapCap.Checked;
            Settings.Save();
        }

        private void chkTrapsInTraps_CheckedChanged(object sender, EventArgs e)
        {
            Mods.Mods.TrapsInTraps.IsEnabled = chkTrapsInTraps.Checked;
            Settings.Instance["TrapsInTraps"] = chkTrapsInTraps.Checked;
            Settings.Save();
        }

        private void StartingCoinInput_ValueChanged(object sender, EventArgs e)
        {
            GameInfo.Battleground.StartingCoin = (int)startingCoinInput.Value;
            Settings.Instance["StartingCoin"] = startingCoinInput.Value.ToString();
            Settings.Save();
        }

        private void chkNoLimitUniqueTraps_CheckedChanged(object sender, EventArgs e)
        {
            Mods.Mods.NoLimitUniqueTraps.IsEnabled = chkNoLimitUniqueTraps.Checked;
            Settings.Instance["NoLimitUniqueTraps"] = chkNoLimitUniqueTraps.Checked;
            Settings.Save();
        }

        private void chkTrapsAnySurface_CheckedChanged(object sender, EventArgs e)
        {
            Mods.Mods.TrapsAnySurface.IsEnabled = chkTrapsAnySurface.Checked;
            Settings.Instance["TrapsAnySurface"] = chkTrapsAnySurface.Checked;
            Settings.Save();
        }

        private void chkNoTrapGrid_CheckedChanged(object sender, EventArgs e)
        {
            Mods.Mods.NoTrapGrid.IsEnabled = chkNoTrapGrid.Checked;
            Settings.Instance["NoTrapGrid"] = chkNoTrapGrid.Checked;
            Settings.Save();
        }

        private void chkHardcore_CheckedChanged(object sender, EventArgs e)
        {
            Mods.Mods.Hardcore.IsEnabled = chkHardcore.Checked;
            Settings.Instance["Hardcore"] = chkHardcore.Checked;
            Settings.Save();
        }
    }
}