using System.Collections.Generic;
using System.Linq;

namespace SingleplayerLauncher.Model
{
    public abstract class SlotItem : LoadoutItem
    {
        public string ItemTemplateName { get; protected set; }

        public static Dictionary<int, SlotItem> SlotItemsById = new Dictionary<int, SlotItem>();

        public static SlotItem GetById(int id)
        {
            SlotItemsById = Trap.TrapsById
                .Concat(Gear.GearsById)
                .ToDictionary(pair => pair.Key, pair => pair.Value);

            if (SlotItemsById.TryGetValue(id, out var slotItem))
            {
                return slotItem;
            }
            return new Trap { Id = 0, ItemTemplateName = "Unknown", Description = "Unknown" };
        }

        public static Dictionary<string, SlotItem> GetAllSlotItems()
        {
            return new List<Dictionary<string, SlotItem>>() { Gear.Gears, Trap.Traps }
                .SelectMany(dict => dict)
                .ToDictionary(pair => pair.Key, pair => pair.Value);
        }

        public static Dictionary<string, SlotItem> GetAllSiegeSlotItems()
        {
            return new List<Dictionary<string, SlotItem>>() { Gear.Gears, Trap.SiegeTraps }
                .SelectMany(dict => dict)
                .ToDictionary(pair => pair.Key, pair => pair.Value);
        }
    }
}
