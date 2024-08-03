using SingleplayerLauncher.Utils;
using System.Text;

namespace SingleplayerLauncher.Model
{
    public abstract class BaseLoadout
    {
        public string Name { get; set; } = "";
        public string PlayerName { get; set; } = "TimeMaster";
        public Hero Hero { get; set; } = Hero.Maximilian;
        public Skin Skin { get; set; } = Skin.MaximillianDefault;
        public Dye Dye { get; set; } = Dye.Normal;
        public SlotItem[] SlotItems { get; set; } = new SlotItem[] { };

        public Trait[] Traits { get; set; } = new Trait[] {};

        public const int SLOT_ITEMS_COUNT = 9;
        public const int TRAIT_SLOT_COUNT = 4;
        public const int TRAIT_BONUS_SLOT_COUNT = 3;

        public const int TRAIT_GREEN_SLOT_IDX = 0;
        public const int TRAIT_BLUE_SLOT_IDX = 1;
        public const int TRAIT_YELLOW_SLOT_IDX = 2;
        public const int TRAIT_NO_BONUS_SLOT_IDX = 3;

        protected const bool FORCE_LENGTH_TWO = true;

        public abstract string Encode();
        public abstract BaseLoadout Decode(string encodedString);

        public bool IsTraitMatchingBonus(int traitIdx)
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

        protected string EncodeBase()
        {
            var encodedString = new StringBuilder();

            // Encode PlayerName
            encodedString.Append($"{PlayerName}-");

            // Encode basic properties
            encodedString.Append($"{Base62Converter.Encode(Hero.Id)}{Base62Converter.Encode(Skin.Id, FORCE_LENGTH_TWO)}{Base62Converter.Encode(Dye.Id)}-");

            return encodedString.ToString();
        }

        protected void DecodeBase(string encodedString)
        {
            var code = encodedString.Split('-');
            int codeIdx = 0;

            // Decode PlayerName
            PlayerName = code[codeIdx++];

            // Decode basic properties
            var basicParts = code[codeIdx++];
            Hero = Hero.GetById(Base62Converter.Decode(basicParts.Substring(0, 1)));
            Skin = Skin.GetById(Base62Converter.Decode(basicParts.Substring(1, 2))); // Forced to be 2 chars
            Dye = Dye.GetById(Base62Converter.Decode(basicParts.Substring(3, 1)));
        }
    }
}
