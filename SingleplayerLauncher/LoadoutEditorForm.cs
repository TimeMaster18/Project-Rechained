using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SingleplayerLauncher
{
    public partial class LoadoutEditorForm : Form
    {
        readonly List<ComboBox> comBoxLoadoutSlots;
        readonly List<ComboBox> comBoxGuardianSlots;
        public static List<byte[]> bytes = new List<byte[]>();
        private readonly Hero hero = Hero.Instance;

        private const int nLoadoutSlots = 9;
        private const int nGuardianSlots = 2;

        //TODO move defaults to a resource file
        readonly string[] defaultLoadout =
        {
            "Mending Root",     "Mage's Clover",        "Barricade",
            "Viscous Tar",      "Flip Trap",            "Wall Blades",
            "Arrow Wall",       "Concussive Pounder",   "Ceiling Ballista"
        };

        readonly string[] defaultGuardians =
        {
            "Dragon Guardian",     "Serpent Guardian"
        };

        public LoadoutEditorForm()
        {
            InitializeComponent();

            comBoxLoadoutSlots = new List<ComboBox>()
            {
                comBoxLoadoutSlot1, comBoxLoadoutSlot2, comBoxLoadoutSlot3,
                comBoxLoadoutSlot4, comBoxLoadoutSlot5, comBoxLoadoutSlot6,
                comBoxLoadoutSlot7, comBoxLoadoutSlot8, comBoxLoadoutSlot9
            };

            comBoxGuardianSlots = new List<ComboBox>()
            {
                comBoxGuardianSlot1, comBoxGuardianSlot2
            };
        }

        private void LoadoutEditor_Load(object sender, EventArgs e)
        {
            PopulateSlots(this.comBoxLoadoutSlots, Resources.traps.Keys.ToList());
            PopulateSlots(this.comBoxLoadoutSlots, Resources.gear.Keys.ToList());
            PopulateSlots(this.comBoxGuardianSlots, Resources.guardians.Keys.ToList());

            // TODO implement a way of loading previous loadout used
            // Placeholder -> Default loadout
            SetDefaultSlots(this.comBoxLoadoutSlots, this.defaultLoadout);
            SetDefaultSlots(this.comBoxGuardianSlots, this.defaultGuardians);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SetDefaultLoadoutInForm();
            Settings.Instance["loadout"] = hero.Loadout;
            Settings.Save();
            this.Close();
        }

        private void SetDefaultLoadoutInForm()
        {
            hero.Loadout = SaveLoadout();
            hero.Guardians = SaveGuardians();

            this.Close();
        }

        private void PopulateSlots(List<ComboBox> comBoxSlotList, List<String> entryList)
        {
            foreach (ComboBox comBoxSlot in comBoxSlotList)
            {
                foreach (string entry in entryList)
                {
                    comBoxSlot.Items.Add(entry);
                }
            }
        }

        private void SetDefaultSlots(List<ComboBox> comBoxSlotList, string[] defaultEntryList)
        {
            int i = 0;
            foreach (ComboBox comBoxSlot in comBoxSlotList)
            {
                comBoxSlot.SelectedItem = defaultEntryList[i];
                i++;
            }
        }

        private string[] SaveLoadout()
        {
            string[] loadout = new string[nLoadoutSlots];

            for (int i = 0; i < nLoadoutSlots; i++)
            {
                loadout[i] = comBoxLoadoutSlots[i].Text;
            }

            return loadout;
        }

        private string[] SaveGuardians()
        {
            string[] guardians = new string[nGuardianSlots];

            for (int i = 0; i < nGuardianSlots; i++)
            {
                guardians[i] = comBoxGuardianSlots[i].Text;
            }

            return guardians;
        }
    }

}
