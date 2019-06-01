using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace SingleplayerLauncher
{
    public partial class LoadoutEditor : Form
    {
        public LoadoutEditor()
        {
            InitializeComponent();
        }

        Max max = new Max();
        Smolder smolder = new Smolder();
        private void LoadoutEditor_Load(object sender, EventArgs e)
        {
            foreach(var trap in Traps.AllTraps)
            {
                cmbTrap1.Items.Add(trap.Value);
                cmbTrap2.Items.Add(trap.Value);
                cmbTrap3.Items.Add(trap.Value);
                cmbTrap4.Items.Add(trap.Value);
                cmbTrap5.Items.Add(trap.Value);
                cmbTrap6.Items.Add(trap.Value);
                cmbTrap7.Items.Add(trap.Value);
                cmbTrap8.Items.Add(trap.Value);
                cmbTrap9.Items.Add(trap.Value);
            }
            cmbTrap1.SelectedIndex = 0;
            cmbTrap2.SelectedIndex = 1;
            cmbTrap3.SelectedIndex = 2;
            cmbTrap4.SelectedIndex = 3;
            cmbTrap5.SelectedIndex = 4;
            cmbTrap6.SelectedIndex = 5;
            cmbTrap7.SelectedIndex = 6;
            cmbTrap8.SelectedIndex = 7;
            cmbTrap9.SelectedIndex = 8;
            //foreach (string h in Form1.heroes.Keys)
            //    cmbHero.Items.Add(h);
            cmbHero.Items.Add("Maximilian");
            //cmbHero.Items.Add("Smolder");//Smolder editor is broken, do not select her it will crash game
            cmbHero.SelectedItem = "Maximilian";
            //cmbHero.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FileInfo info = new FileInfo(Hero.SpitfireGameUPK);
            if (info.Length == 100225213)
            {
                MessageBox.Show("Decompressing your file");
                if(!File.Exists(@".//UE Extractor//SpitfireGame.upk"))
                File.Copy(Hero.SpitfireGameUPK, @".//UE Extractor//SpitfireGame.upk");
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = Path.GetFileName(".//UE Extractor//decompress.exe");
                psi.WorkingDirectory = Path.GetDirectoryName(".//UE Extractor//decompress.exe");
                psi.Arguments = "\"" + Path.GetFileName(@".//UE Extractor//SpitfireGame.upk")+"\"";
                Process process = Process.Start(psi);
                process.WaitForExit();
                File.Delete(Hero.SpitfireGameUPK);
                File.Move(".//UE Extractor//unpacked//SpitfireGame.upk", Hero.SpitfireGameUPK);
            }
            var trap1 = Traps.AllTraps.Where(_ => _.Value == cmbTrap1.Text).First().Key;
            var trap2 = Traps.AllTraps.Where(_ => _.Value == cmbTrap2.Text).First().Key;
            var trap3 = Traps.AllTraps.Where(_ => _.Value == cmbTrap3.Text).First().Key;
            var trap4 = Traps.AllTraps.Where(_ => _.Value == cmbTrap4.Text).First().Key;
            var trap5 = Traps.AllTraps.Where(_ => _.Value == cmbTrap5.Text).First().Key;
            var trap6 = Traps.AllTraps.Where(_ => _.Value == cmbTrap6.Text).First().Key;
            var trap7 = Traps.AllTraps.Where(_ => _.Value == cmbTrap7.Text).First().Key;
            var trap8 = Traps.AllTraps.Where(_ => _.Value == cmbTrap8.Text).First().Key;
            var trap9 = Traps.AllTraps.Where(_ => _.Value == cmbTrap9.Text).First().Key;
            if (cmbHero.Text == "Maximilian")
            {
                max.SetTraps(new List<byte[]>() { trap1, trap2, trap3, trap4, trap5, trap6, trap7, trap8, trap9 });
            }
            else if (cmbHero.Text == "Smolder")
            {
                smolder.SetTraps(new List<byte[]>() { trap1, trap2, trap3, trap4, trap5, trap6, trap7, trap8, trap9 });
            }
        }
    }
}
