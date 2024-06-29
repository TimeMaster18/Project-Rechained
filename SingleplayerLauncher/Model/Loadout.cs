using System.Collections.Generic;

namespace SingleplayerLauncher.Model
{
    public abstract class SlotItem
    {
        public string Name { get; protected set; }
        public string ItemTemplateName { get; protected set; }
        public string Description { get; protected set; }
        public Dictionary<string, byte[]> IdByHeroName { get; protected set; } // id linking the item, in the respective upk file. i.e: SpitfireGame.upk        
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

        public Hero Hero { get; set; } = Hero.Maximilian;
        public Skin Skin { get; set; } = Skin.MaximillianDefault;
        public Dye Dye { get; set; } = Dye.Normal;

        public SlotItem[] SlotItems { get; set; } = { Gear.MendingRoot, Gear.MagesClover, Trap.Barricade, Trap.ViscousTar, Trap.FlipTrap, Trap.WallBlades, Trap.ArrowWall, Trap.ConcussivePounder, Trap.CeilingBallista };

        public Guardian[] Guardians { get; set; } = { Guardian.DragonGuardian, Guardian.MoonGuardian };

        public Consumable[] Consumables { get; set; } = { Consumable.LuckPotion, Consumable.UnchainedScroll };

        public Trait[] Traits { get; set; } = { Trait.TakesLessonsFromCygnus, Trait.RiftRocket, Trait.Overachiever, Trait.WallBuildingPhD};

        public TrapPart[][] TrapParts { get; set; } = new TrapPart[SLOT_ITEMS_COUNT][];


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
    }

}
