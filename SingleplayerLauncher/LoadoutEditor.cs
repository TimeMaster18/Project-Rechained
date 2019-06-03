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
        List<System.Windows.Forms.ComboBox> comBoxLoadoutSlots;


        private void LoadoutEditor_Load(object sender, EventArgs e)
        {
            comBoxLoadoutSlots = new List<System.Windows.Forms.ComboBox>()
            {   comBoxLoadoutSlot1, comBoxLoadoutSlot2, comBoxLoadoutSlot3,
                comBoxLoadoutSlot4, comBoxLoadoutSlot5, comBoxLoadoutSlot6,
                comBoxLoadoutSlot7, comBoxLoadoutSlot8, comBoxLoadoutSlot9
            };

            foreach (var comBoxLoadoutSlot in comBoxLoadoutSlots)
            {
                foreach (var trap in Resources.traps)
                {
                    comBoxLoadoutSlot.Items.Add(trap.Key);
                }
                foreach (var gear in Resources.gear)
                {
                    comBoxLoadoutSlot.Items.Add(gear.Key);
                }
            }

            // TODO implement a way of loading previous loadout used
            // Placeholder -> Default loadout
            comBoxLoadoutSlot1.SelectedItem = "Mending Root";
            comBoxLoadoutSlot2.SelectedItem = "Mage's Clover";
            comBoxLoadoutSlot3.SelectedItem = "Barricade";
            comBoxLoadoutSlot4.SelectedItem = "Viscous Tar";
            comBoxLoadoutSlot5.SelectedItem = "Flip Trap";
            comBoxLoadoutSlot6.SelectedItem = "Wall Blades";
            comBoxLoadoutSlot7.SelectedItem = "Arrow Wall";
            comBoxLoadoutSlot8.SelectedItem = "Concussive Pounder";
            comBoxLoadoutSlot9.SelectedItem = "Ceiling Ballista";

            //TODO implement other heroes
            //foreach (string h in Form1.heroes.Keys)
            //    cmbHero.Items.Add(h);
            cmbHero.Items.Add("Maximilian");
            //cmbHero.Items.Add("Smolder");//Smolder editor is broken, do not select her it will crash game
            cmbHero.SelectedItem = "Maximilian";
            //cmbHero.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saving your loadout. Please wait.");
            FileInfo info = new FileInfo(Hero.SpitfireGameUPK);
            if (info.Length == 100225213)
            {
                if (!File.Exists(@".//UE Extractor//SpitfireGame.upk"))
                {
                    File.Copy(Hero.SpitfireGameUPK, @".//UE Extractor//SpitfireGame.upk");
                    ProcessStartInfo psi = new ProcessStartInfo();
                    psi.FileName = Path.GetFileName(".//UE Extractor//decompress.exe");
                    psi.WorkingDirectory = Path.GetDirectoryName(".//UE Extractor//decompress.exe");
                    psi.Arguments = "\"" + Path.GetFileName(@".//UE Extractor//SpitfireGame.upk") + "\"";
                    Process process = Process.Start(psi);
                    process.WaitForExit();
                    File.Delete(Hero.SpitfireGameUPK);
                    File.Move(".//UE Extractor//unpacked//SpitfireGame.upk", Hero.SpitfireGameUPK);
                }
            }

            saveLoadout("Maximilian");
            
            MessageBox.Show("Finished!.");
        }

        private void saveLoadout(string hero)
        {
            List<byte[]> loadoutSlotsBytes = new List<byte[]>();

            foreach (var loadoutSlot in comBoxLoadoutSlots)
            {
                var selected = loadoutSlot.Text;
                if (Resources.traps.ContainsKey(selected))
                {
                    loadoutSlotsBytes.Add(Resources.traps[selected]);
                }
                else
                {
                    loadoutSlotsBytes.Add(Resources.gear[selected]);
                }
                
            }

            max.SetTraps(loadoutSlotsBytes);

            // TODO other heroes

        }
    }
}
