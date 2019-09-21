using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SingleplayerLauncher
{
    public partial class LoadoutEditorForm : Form
    {
        readonly List<System.Windows.Forms.ComboBox> comBoxLoadoutSlots;
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
            
        }        

        private void LoadoutEditor_Load(object sender, EventArgs e)
        {
            PopulateTrapsGearSlots();

            // TODO implement a way of loading previous loadout used
            // Placeholder -> Default loadout
            SetDefaultLoadoutInForm();
            if (Settings.Instance.ContainsKey("loadout"))
            {
                var savedLoadOut = ((JArray)Settings.Instance["loadout"]).ToObject<string[]>();
                for (int i = 0; i < 9; i++)
                {
                    comBoxLoadoutSlots[i].SelectedItem = savedLoadOut[i];
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            hero.loadout = CreateLoadout();
            Settings.Instance["loadout"] =  hero.loadout;
            Settings.Save();
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
