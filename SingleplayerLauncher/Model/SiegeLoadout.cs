using SingleplayerLauncher.Utils;
using System.Text;

namespace SingleplayerLauncher.Model
{
    public class SiegeLoadout : BaseLoadout
    {
        public const int WAVES_SLOT_COUNT = 10;
        public Wave[] Waves { get; set; } = new Wave[WAVES_SLOT_COUNT];
        public SiegeRole Role { get; set; } = SiegeRole.RoleDefender;

        public SiegeLoadout()
        {
            SlotItems = [Gear.MendingRoot, Gear.MagesClover, Trap.Barricade, Trap.ViscousTar, Trap.FlipTrap, Trap.WallBlades, Trap.ArrowWall, Trap.ConcussivePounder, Trap.CeilingBallista];
            Traits = new SiegeTrait[TRAIT_SLOT_COUNT];
        }


        public override string Encode()
        {
            var encodedString = new StringBuilder(EncodeBase());

            // Encode Role
            encodedString.Append(Role != null ? Base62Converter.Encode(Role.Id) : "0");
            encodedString.Append('-');

            // Encode SlotItems
            foreach (var slotItem in SlotItems)
            {
                encodedString.Append(slotItem != null ? Base62Converter.Encode(slotItem.Id, FORCE_LENGTH_TWO) : "00");
            }
            encodedString.Append('-');

            // Encode Waves
            for (int i = 0; i < WAVES_SLOT_COUNT; i++)
            {
                Wave wave = Waves[i];
                encodedString.Append(wave != null ? Base62Converter.Encode(wave.Id) : "0");
            }
            encodedString.Append('-');

            // Encode Traits
            foreach (var trait in Traits)
            {
                encodedString.Append(trait != null ? Base62Converter.Encode(trait.Id) : "0");
            }

            return encodedString.ToString();
        }

        public override BaseLoadout Decode(string encodedString)
        {
            DecodeBase(encodedString);
            var code = encodedString.Split('-');
            int codeIdx = 2;

            // Decode Role
            var role = code[codeIdx++];
            Role = SiegeRole.GetById(Base62Converter.Decode(role));

            // Decode SlotItems
            var slotItemParts = code[codeIdx++];
            SlotItems = new SlotItem[SLOT_ITEMS_COUNT];
            for (int i = 0; i < SLOT_ITEMS_COUNT; i++)
            {
                var slotItem = slotItemParts.Substring(i * 2, 2);
                SlotItems[i] = slotItem != "00" ? SlotItem.GetById(Base62Converter.Decode(slotItem)) : null; // Forced to be 2 chars
            }

            // Decode Waves
            var waveParts = code[codeIdx++];
            Waves = new Wave[WAVES_SLOT_COUNT];
            for (int i = 0; i < WAVES_SLOT_COUNT; i++)
            {
                var wave = waveParts.Substring(i, 1);
                Waves[i] = wave != "0" ? Wave.GetById(Base62Converter.Decode(wave)) : null;
            }

            // Decode Traits
            var traitParts = code[codeIdx++];
            Traits = new SiegeTrait[TRAIT_SLOT_COUNT];
            for (int i = 0; i < TRAIT_SLOT_COUNT; i++)
            {
                var trait = traitParts.Substring(i, 1);
                Traits[i] = trait != "0" ? SiegeTrait.GetById(Base62Converter.Decode(trait)) : null;
            }

            return this;
        }
    }
}


