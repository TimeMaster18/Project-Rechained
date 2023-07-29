using System.Collections.Generic;

namespace SingleplayerLauncher.Model
{
    public abstract class SlotItem
    {
        public string Name { get; protected set; }
        public Dictionary<string, byte[]> IdByHeroName { get; protected set; } // id linking the item, in the respective upk file. i.e: SpitfireGame.upk        
    }

    public class Loadout
    {
        public const int SLOT_ITEMS_COUNT = 9;
        public const int GUARDIAN_SLOT_COUNT = 2;

        public Hero Hero { get; set; } = Hero.Maximilian;
        public Skin Skin { get; set; } = Skin.MaximillianDefault;
        public Dye Dye { get; set; } = Dye.Normal;

        // public Trait[] Traits { get; set; }

        public SlotItem[] SlotItems { get; set; } = { Gear.MendingRoot, Gear.MagesClover, Trap.Barricade, Trap.ViscousTar, Trap.FlipTrap, Trap.WallBlades, Trap.ArrowWall, Trap.ConcussivePounder, Trap.CeilingBallista };

        public Guardian[] Guardians { get; set; } = { Guardian.DragonGuardian, Guardian.MoonGuardian };

        // public Consumable[] Consumables { get; set; }
    }

}
