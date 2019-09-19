using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SingleplayerLauncher
{
    public partial class LoadoutEditorForm : Form
    {
        readonly List<System.Windows.Forms.ComboBox> comBoxLoadoutSlots;
        public static List<byte[]> bytes = new List<byte[]>();
        private readonly Hero hero = Hero.Instance;

        private const int loadoutSize = 9;

        public LoadoutEditorForm()
        {        
            InitializeComponent();

            comBoxLoadoutSlots = new List<System.Windows.Forms.ComboBox>()
            {   comBoxLoadoutSlot1, comBoxLoadoutSlot2, comBoxLoadoutSlot3,
                comBoxLoadoutSlot4, comBoxLoadoutSlot5, comBoxLoadoutSlot6,
                comBoxLoadoutSlot7, comBoxLoadoutSlot8, comBoxLoadoutSlot9
            };
            if (Settings.Instance.ContainsKey("loadout"))
            {
                for (int i = 0; i < 9; i++)
                {
                    comBoxLoadoutSlots[i].SelectedItem = Settings.Instance["loadout"];
                }
            }
        }        

        private void LoadoutEditor_Load(object sender, EventArgs e)
        {
            PopulateTrapsGearSlots();

            // TODO implement a way of loading previous loadout used
            // Placeholder -> Default loadout
            SetDefaultLoadoutInForm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            hero.loadout = CreateLoadout();
            Settings.Instance.Add("loadout", hero.loadout);
            this.Close();
        }

        private void SetDefaultLoadoutInForm()
        {

            for (int i = 0; i < 9; i++)
            {
                comBoxLoadoutSlots[i].SelectedItem = Resources.defaultLoadout[i];
            }
        }

        private void PopulateTrapsGearSlots()
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

        private string[] CreateLoadout()
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
