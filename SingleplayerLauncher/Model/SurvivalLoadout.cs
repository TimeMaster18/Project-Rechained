using SingleplayerLauncher.Utils;
using System.Linq;
using System.Text;

namespace SingleplayerLauncher.Model
{
    public class SurvivalLoadout : BaseLoadout
    {
        public const int GUARDIAN_SLOT_COUNT = 2;
        public const int CONSUMABLE_SLOT_COUNT = 2;
        public const int TRAP_PART_SLOT_COUNT = 3;

        public SurvivalLoadout()
        {
            SlotItems = new SlotItem[SLOT_ITEMS_COUNT] { Gear.MendingRoot, Gear.MagesClover, Trap.Barricade, Trap.ViscousTar, Trap.FlipTrap, Trap.WallBlades, Trap.ArrowWall, Trap.ConcussivePounder, Trap.CeilingBallista
};
        }

        public Guardian[] Guardians { get; set; } = new Guardian[GUARDIAN_SLOT_COUNT] { Guardian.DragonGuardian, Guardian.MoonGuardian };

        public Consumable[] Consumables { get; set; } = new Consumable[CONSUMABLE_SLOT_COUNT] { Consumable.LuckPotion, Consumable.UnchainedScroll };        

        public TrapPart[,] TrapParts { get; set; } = new TrapPart[SLOT_ITEMS_COUNT, TRAP_PART_SLOT_COUNT];

        public TrapPart[] GetTrapPartsForLoadout(int loadoutSlotIdx)
        {
            return Enumerable.Range(0, TRAP_PART_SLOT_COUNT)
                             .Select(c => TrapParts[loadoutSlotIdx, c])
                             .ToArray();
        }

        public override string Encode()
        {
            var encodedString = new StringBuilder(EncodeBase());

            // Encode SlotItems
            foreach (var slotItem in SlotItems)
            {
                encodedString.Append(slotItem != null ? Base62Converter.Encode(slotItem.Id, FORCE_LENGTH_TWO) : "00");
            }
            encodedString.Append("-");

            // Encode Guardians
            foreach (var guardian in Guardians)
            {
                encodedString.Append(guardian != null ? Base62Converter.Encode(guardian.Id) : "0");
            }
            encodedString.Append("-");

            // Encode Consumables
            foreach (var consumable in Consumables)
            {
                encodedString.Append(consumable != null ? Base62Converter.Encode(consumable.Id) : "0");
            }
            encodedString.Append("-");

            // Encode Traits
            foreach (var trait in Traits)
            {
                encodedString.Append(trait != null ? Base62Converter.Encode(trait.Id) : "0");
            }
            encodedString.Append("-");

            // Encode TrapParts
            for (int i = 0; i < SLOT_ITEMS_COUNT; i++)
            {
                for (int j = 0; j < TRAP_PART_SLOT_COUNT; j++)
                {
                    var trapPart = TrapParts[i, j];
                    encodedString.Append(trapPart != null ? Base62Converter.Encode(trapPart.Id) : "0");
                }
            }

            return encodedString.ToString();
        }

        public override BaseLoadout Decode(string encodedString)
        {
            DecodeBase(encodedString);
            var code = encodedString.Split('-');
            int codeIdx = 2;

            // Decode SlotItems
            var slotItemParts = code[codeIdx++];
            SlotItems = new SlotItem[SLOT_ITEMS_COUNT];
            for (int i = 0; i < SLOT_ITEMS_COUNT; i++)
            {
                var slotItem = slotItemParts.Substring(i * 2, 2);
                SlotItems[i] = slotItem != "00" ? SlotItem.GetById(Base62Converter.Decode(slotItem)) : null; // Forced to be 2 chars
            }

            // Decode Guardians
            var guardianParts = code[codeIdx++];
            Guardians = new Guardian[GUARDIAN_SLOT_COUNT];
            for (int i = 0; i < GUARDIAN_SLOT_COUNT; i++)
            {
                var guardian = guardianParts.Substring(i, 1);
                Guardians[i] = guardian != "0" ? Guardian.GetById(Base62Converter.Decode(guardian)) : null;
            }

            // Decode Consumables
            var consumableParts = code[codeIdx++];
            Consumables = new Consumable[CONSUMABLE_SLOT_COUNT];
            for (int i = 0; i < CONSUMABLE_SLOT_COUNT; i++)
            {
                var consumable = consumableParts.Substring(i, 1);
                Consumables[i] = consumable != "0" ? Consumable.GetById(Base62Converter.Decode(consumable)) : null;
            }

            // Decode Traits
            var traitParts = code[codeIdx++];
            Traits = new SurvivalTrait[TRAIT_SLOT_COUNT];
            for (int i = 0; i < TRAIT_SLOT_COUNT; i++)
            {
                var trait = traitParts.Substring(i, 1);
                Traits[i] = trait != "0" ? SurvivalTrait.GetById(Base62Converter.Decode(trait)) : null;
            }

            // Decode TrapParts
            var trapPartParts = code[codeIdx];
            TrapParts = new TrapPart[SLOT_ITEMS_COUNT, TRAP_PART_SLOT_COUNT];
            int trapPartIndex = 0;
            for (int i = 0; i < SLOT_ITEMS_COUNT; i++)
            {
                for (int j = 0; j < TRAP_PART_SLOT_COUNT; j++)
                {
                    var trapPartChar = trapPartParts.Substring(trapPartIndex++, 1);
                    TrapParts[i, j] = trapPartChar != "0" ? TrapPart.GetById(Base62Converter.Decode(trapPartChar)) : null;
                }
            }

            return this;
        }
    }
}
