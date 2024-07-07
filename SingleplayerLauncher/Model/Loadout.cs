using SingleplayerLauncher.Names;
using SingleplayerLauncher.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingleplayerLauncher.Model
{
    public abstract class LoadoutItem
    {
        public int Id { get; protected set; }
        public string Name { get; protected set; }
        public string Description { get; protected set; }
    }

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
    }

    public class Loadout
    {
        public const int SLOT_ITEMS_COUNT = 9;
        public const int GUARDIAN_SLOT_COUNT = 2;
        public const int CONSUMABLE_SLOT_COUNT = 2;
        public const int TRAIT_SLOT_COUNT = 4;
        public const int TRAIT_BONUS_SLOT_COUNT = 3;
        public const int TRAP_PART_SLOT_COUNT = 3;

        public const int TRAIT_GREEN_SLOT_IDX = 0;
        public const int TRAIT_BLUE_SLOT_IDX = 1;
        public const int TRAIT_YELLOW_SLOT_IDX = 2;
        public const int TRAIT_NO_BONUS_SLOT_IDX = 3;
        private const bool FORCE_LENGTH_TWO = true;

        public string Name { get; set; } = "";
        public string PlayerName { get; set; } = "TimeMaster";

        public Hero Hero { get; set; } = Hero.Maximilian;
        public Skin Skin { get; set; } = Skin.MaximillianDefault;
        public Dye Dye { get; set; } = Dye.Normal;

        public SlotItem[] SlotItems { get; set; } = new SlotItem[SLOT_ITEMS_COUNT]  { Gear.MendingRoot, Gear.MagesClover, Trap.Barricade, Trap.ViscousTar, Trap.FlipTrap, Trap.WallBlades, Trap.ArrowWall, Trap.ConcussivePounder, Trap.CeilingBallista };

        public Guardian[] Guardians { get; set; } = new Guardian[GUARDIAN_SLOT_COUNT] { Guardian.DragonGuardian, Guardian.MoonGuardian };

        public Consumable[] Consumables { get; set; } = new Consumable[CONSUMABLE_SLOT_COUNT] { Consumable.LuckPotion, Consumable.UnchainedScroll };

        public Trait[] Traits { get; set; } = new Trait[TRAIT_SLOT_COUNT] { Trait.TakesLessonsFromCygnus, Trait.RiftRocket, Trait.Overachiever, Trait.WallBuildingPhD};

        public TrapPart[,] TrapParts { get; set; } = new TrapPart[SLOT_ITEMS_COUNT, TRAP_PART_SLOT_COUNT];


        public bool isTraitMatchingBonus(int traitIdx)
        {
            if (traitIdx == TRAIT_NO_BONUS_SLOT_IDX) return false;            
            Trait trait = Traits[traitIdx];

            if (traitIdx == TRAIT_BLUE_SLOT_IDX && trait.MatchingSlot == Trait.DIAMOND_BONUS_SLOT ||
                traitIdx == TRAIT_GREEN_SLOT_IDX && trait.MatchingSlot == Trait.PENTAGON_BONUS_SLOT ||
                traitIdx == TRAIT_YELLOW_SLOT_IDX && trait.MatchingSlot == Trait.TRIANGLE_BONUS_SLOT)
            {
                return true;
            }

            return false;
        }

        public TrapPart[] GetTrapPartsForLoadout(int loadoutSlotIdx)
        {
            int row = (loadoutSlotIdx - 1) / TRAP_PART_SLOT_COUNT;  // Calculate row based on index and number of columns
            int col = (loadoutSlotIdx - 1) % TRAP_PART_SLOT_COUNT;  // Calculate column based on index and number of columns

            return Enumerable.Range(0, TRAP_PART_SLOT_COUNT)
                             .Select(c => GameInfo.Loadout.TrapParts[row, c])
                             .ToArray();
        }

        /// <summary>
        /// Encodes a Loadout object into a string representation.
        /// </summary>
        /// <param name="loadout">The Loadout object to encode.</param>
        /// <returns>A string representation of the encoded Loadout.</returns>
        public static string EncodeLoadout(Loadout loadout)
        {
            var encodedString = new StringBuilder();

            // Encode PlayerName
            encodedString.Append($"{loadout.PlayerName}-");

            // Encode basic properties
            encodedString.Append($"{Base62Converter.Encode(loadout.Hero.Id)}{Base62Converter.Encode(loadout.Skin.Id, FORCE_LENGTH_TWO)}{Base62Converter.Encode(loadout.Dye.Id)}-");

            // Encode SlotItems
            foreach (var slotItem in loadout.SlotItems)
            {
                encodedString.Append(slotItem != null ? Base62Converter.Encode(slotItem.Id, FORCE_LENGTH_TWO) : "00");
            }
            encodedString.Append("-");

            // Encode Guardians
            foreach (var guardian in loadout.Guardians)
            {
                encodedString.Append(guardian != null ? Base62Converter.Encode(guardian.Id) : "0");
            }
            encodedString.Append("-");

            // Encode Consumables
            foreach (var consumable in loadout.Consumables)
            {
                encodedString.Append(consumable != null ? Base62Converter.Encode(consumable.Id) : "0");
            }
            encodedString.Append("-");

            // Encode Traits
            foreach (var trait in loadout.Traits)
            {
                encodedString.Append(trait != null ? Base62Converter.Encode(trait.Id) : "0");
            }
            encodedString.Append("-");

            // Encode TrapParts
            for (int i = 0; i < Loadout.SLOT_ITEMS_COUNT; i++)
            {
                for (int j = 0; j < Loadout.TRAP_PART_SLOT_COUNT; j++)
                {
                    var trapPart = loadout.TrapParts[i, j];
                    encodedString.Append(trapPart != null ? Base62Converter.Encode(trapPart.Id) : "0");
                }
            }

            return encodedString.ToString();
        }

        /// <summary>
        /// Decodes a string representation of a Loadout into a Loadout object.
        /// </summary>
        /// <param name="encodedString">The encoded string representation of a Loadout.</param>
        /// <returns>A Loadout object decoded from the input string.</returns>
        public static Loadout DecodeLoadout(string encodedString)
        {
            var code = encodedString.Split('-');
            int codeIdx = 0;

            // Decode PlayerName
            var playerName = code[codeIdx++];

            // Decode basic properties
            var basicParts = code[codeIdx++];
            var loadout = new Loadout
            {
                PlayerName = playerName,
                Hero = Hero.GetById(Base62Converter.Decode(basicParts.Substring(0, 1))),
                Skin = Skin.GetById(Base62Converter.Decode(basicParts.Substring(1, 2))), // Forced to be 2 chars
                Dye = Dye.GetById(Base62Converter.Decode(basicParts.Substring(3, 1)))
            };

            // Decode SlotItems
            var slotItemParts = code[codeIdx++];
            loadout.SlotItems = new SlotItem[Loadout.SLOT_ITEMS_COUNT];
            for (int i = 0; i < Loadout.SLOT_ITEMS_COUNT; i++)
            {
                var slotItem = slotItemParts.Substring(i * 2, 2);
                loadout.SlotItems[i] = slotItem != "00" ? SlotItem.GetById(Base62Converter.Decode(slotItem)) : null; // Forced to be 2 chars
            }

            // Decode Guardians
            var guardianParts = code[codeIdx++];
            loadout.Guardians = new Guardian[Loadout.GUARDIAN_SLOT_COUNT];
            for (int i = 0; i < Loadout.GUARDIAN_SLOT_COUNT; i++)
            {
                var guardian = guardianParts.Substring(i, 1);
                loadout.Guardians[i] = guardian != "0" ? Guardian.GetById(Base62Converter.Decode(guardian)) : null;
            }

            // Decode Consumables
            var consumableParts = code[codeIdx++];
            loadout.Consumables = new Consumable[Loadout.CONSUMABLE_SLOT_COUNT];
            for (int i = 0; i < Loadout.CONSUMABLE_SLOT_COUNT; i++)
            {
                var consumable = consumableParts.Substring(i, 1);
                loadout.Consumables[i] = consumable != "0" ? Consumable.GetById(Base62Converter.Decode(consumable)) : null;
            }

            // Decode Traits
            var traitParts = code[codeIdx++];
            loadout.Traits = new Trait[Loadout.TRAIT_SLOT_COUNT];
            for (int i = 0; i < Loadout.TRAIT_SLOT_COUNT; i++)
            {
                var trait = traitParts.Substring(i, 1);
                loadout.Traits[i] = trait != "0" ? Trait.GetById(Base62Converter.Decode(trait)) : null;
            }

            // Decode TrapParts
            var trapPartParts = code[codeIdx];
            loadout.TrapParts = new TrapPart[Loadout.SLOT_ITEMS_COUNT, Loadout.TRAP_PART_SLOT_COUNT];
            int trapPartIndex = 0;
            for (int i = 0; i < Loadout.SLOT_ITEMS_COUNT; i++)
            {
                for (int j = 0; j < Loadout.TRAP_PART_SLOT_COUNT; j++)
                {
                    var trapPartChar = trapPartParts.Substring(trapPartIndex++, 1);
                    loadout.TrapParts[i, j] = trapPartChar != "0" ? TrapPart.GetById(Base62Converter.Decode(trapPartChar)) : null;
                }
            }

            return loadout;
        }
    }

}
