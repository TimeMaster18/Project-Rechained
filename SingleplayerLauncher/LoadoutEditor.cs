using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
        List<System.Windows.Forms.ComboBox> comBoxLoadoutSlots;
        public static List<byte[]> bytes = new List<byte[]>();

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
            cmbHero.SelectedItem = "Maximilian";
            //cmbHero.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
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
            bytes = loadoutSlotsBytes;
        }
        
    }
}
