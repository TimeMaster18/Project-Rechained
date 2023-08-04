using Newtonsoft.Json.Linq;
using SingleplayerLauncher.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SingleplayerLauncher
{
    public partial class LoadoutEditorForm : Form
    {
        private readonly GameInfo GameInfo = GameInfo.Instance;

        private readonly List<ComboBox> ComBoxLoadoutSlots;
        private readonly List<ComboBox> ComBoxGuardianSlots;

        public LoadoutEditorForm()
        {
            InitializeComponent();

            ComBoxLoadoutSlots = new List<ComboBox>()
            {
                comBoxLoadoutSlot1, comBoxLoadoutSlot2, comBoxLoadoutSlot3,
                comBoxLoadoutSlot4, comBoxLoadoutSlot5, comBoxLoadoutSlot6,
                comBoxLoadoutSlot7, comBoxLoadoutSlot8, comBoxLoadoutSlot9
            };

            ComBoxGuardianSlots = new List<ComboBox>()
            {
                comBoxGuardianSlot1, comBoxGuardianSlot2
            };
        }

        private void LoadoutEditor_Load(object sender, EventArgs e)
        {
            PopulateSlots(ComBoxLoadoutSlots, Model.Trap.Traps.Keys.ToList());
            PopulateSlots(ComBoxLoadoutSlots, Model.Gear.Gears.Keys.ToList());
            PopulateSlots(ComBoxGuardianSlots, Model.Guardian.Guardians.Keys.ToList());

            if (Settings.Instance.ContainsKey("loadout"))
            {
                GameInfo.Loadout.SlotItems = ((JArray)Settings.Instance["loadout"]).ToObject<string[]>().Select(lsi => SlotItems[lsi]).ToArray();
            }

            if (Settings.Instance.ContainsKey("guardians"))
            {
                GameInfo.Loadout.Guardians = ((JArray)Settings.Instance["guardians"]).ToObject<string[]>().Select(lgi => Model.Guardian.Guardians[lgi]).ToArray();
            }

            SetCurrentLoadout();
            SetCurrenGuardians();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveLoadout();
            SaveGuardians();
            Settings.Instance["loadout"] = ComBoxLoadoutSlots.Select(cls => cls.SelectedItem.ToString());
            Settings.Instance["guardians"] = ComBoxGuardianSlots.Select(cgs => cgs.SelectedItem.ToString());
            Settings.Save();
            Close();
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

        private void SetCurrenGuardians()
        {
            for (int i = 0; i < Loadout.GUARDIAN_SLOT_COUNT; i++)
            {
                ComBoxGuardianSlots[i].SelectedItem = GameInfo.Loadout.Guardians[i].Name;
            }
        }

        private void SaveGuardians()
        {
            for (int i = 0; i < Loadout.GUARDIAN_SLOT_COUNT; i++)
            {
                GameInfo.Loadout.Guardians[i] = Guardian.Guardians[ComBoxGuardianSlots[i].Text];
            }
        }

        private void SetCurrentLoadout()
        {
            for (int i = 0; i < Loadout.SLOT_ITEMS_COUNT; i++)
            {
                ComBoxLoadoutSlots[i].SelectedItem = GameInfo.Loadout.SlotItems[i].Name;
            }
        }

        private static readonly Dictionary<string, SlotItem> SlotItems =
            new List<Dictionary<string, SlotItem>>() { Gear.Gears, Trap.Traps }
                .SelectMany(dict => dict)
                .ToDictionary(pair => pair.Key, pair => pair.Value);

        private void SaveLoadout()
        {
            for (int i = 0; i < Loadout.SLOT_ITEMS_COUNT; i++)
            {
                GameInfo.Loadout.SlotItems[i] = SlotItems[ComBoxLoadoutSlots[i].Text];
            }
        }
    }

}
