using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SingleplayerLauncher
{
    public partial class LoadoutEditorForm : Form
    {
        List<System.Windows.Forms.ComboBox> comBoxLoadoutSlots;
        public static List<byte[]> bytes = new List<byte[]>();
        private Hero hero = Hero.Instance;

        private const int loadoutSize = 9;

        private static readonly string[] defaultLoadout =
        {   "Mending Root",     "Mage's Clover",        "Barricade",
            "Viscous Tar",      "Flip Trap",            "Wall Blades",
            "Arrow Wall",       "Concussive Pounder",   "Ceiling Ballista"
        };

        public LoadoutEditorForm()
        {        
            InitializeComponent();

            comBoxLoadoutSlots = new List<System.Windows.Forms.ComboBox>()
            {   comBoxLoadoutSlot1, comBoxLoadoutSlot2, comBoxLoadoutSlot3,
                comBoxLoadoutSlot4, comBoxLoadoutSlot5, comBoxLoadoutSlot6,
                comBoxLoadoutSlot7, comBoxLoadoutSlot8, comBoxLoadoutSlot9
            };
        }        

        private void LoadoutEditor_Load(object sender, EventArgs e)
        {
            populateTrapsGearSlots();

            // TODO implement a way of loading previous loadout used
            // Placeholder -> Default loadout
            setDefaultLoadout();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            hero.loadout = createLoadout();

            this.Close();
        }

        private void setDefaultLoadout()
        {

            for (int i = 0; i < 9; i++)
            {
                comBoxLoadoutSlots[i].SelectedItem = defaultLoadout[i];
            }
        }

        private void populateTrapsGearSlots()
        {
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
        }

        private string[] createLoadout()
        {
            string[] loadout = new string[loadoutSize];

            for (int i = 0; i < 9; i++)
            {
                loadout[i] = comBoxLoadoutSlots[i].Text;
            }

            return loadout;
        }
    }
}
