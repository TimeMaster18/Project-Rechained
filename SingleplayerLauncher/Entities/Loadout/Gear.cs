using System.Collections.Generic;
using static SingleplayerLauncher.Names.Gear;

namespace SingleplayerLauncher.Model
{
    public class Gear : SlotItem
    {
        public string UnlockingDifficulty { get; private set; }

        // private constructor
        Gear() { }

        // static members
        public static Gear AntitrapVambrace = new Gear()
        {
            Name = ANTITRAP_VAMBRACE,
            Id = new byte[] { 0x02, 0xC4, 0x00, 0x00 }
        };
        public static Gear ArcaneBubbleBlower = new Gear()
        {
            Name = ARCANE_BUBBLE_BLOWER,
            Id = new byte[] { 0xE3, 0xC4, 0x00, 0x00 }
        };
        public static Gear FireWallBracers = new Gear()
        {
            Name = FIRE_WALL_BRACERS,
            Id = new byte[] { 0xE5, 0xC4, 0x00, 0x00 }
        };
        public static Gear FreedomTrinket = new Gear()
        {
            Name = FREEDOM_TRINKET,
            Id = new byte[] { 0xCE, 0xC4, 0x00, 0x00 }
        };
        public static Gear GnomishRepairKit = new Gear()
        {
            Name = GNOMISH_REPAIR_KIT,
            Id = new byte[] { 0xDC, 0xC4, 0x00, 0x00 }
        };
        public static Gear GreaterFreedomTrinket = new Gear()
        {
            Name = GREATER_FREEDOM_TRINKET,
            Id = new byte[] { 0xD0, 0xC4, 0x00, 0x00 }
        };
        public static Gear HobgoblinCharm = new Gear()
        {
            Name = HOBGOBLIN_CHARM,
            Id = new byte[] { 0xD4, 0xC4, 0x00, 0x00 }
        };
        public static Gear IceAmulet = new Gear()
        {
            Name = ICE_AMULET,
            Id = new byte[] { 0xE7, 0xC4, 0x00, 0x00 }
        };
        public static Gear LightningRing = new Gear()
        {
            Name = LIGHTNING_RING,
            Id = new byte[] { 0xEB, 0xC4, 0x00, 0x00 }
        };
        public static Gear MagesClover = new Gear()
        {
            Name = MAGES_CLOVER,
            Id = new byte[] { 0xDA, 0xC4, 0x00, 0x00 }
        };
        public static Gear MagesPicnic = new Gear()
        {
            Name = MAGES_PICNIC,
            Id = new byte[] { 0xD8, 0xC4, 0x00, 0x00 }
        };
        public static Gear MendingRoot = new Gear()
        {
            Name = MENDING_ROOT,
            Id = new byte[] { 0xD2, 0xC4, 0x00, 0x00 }
        };
        public static Gear RingOfLastStand = new Gear()
        {
            Name = RING_OF_LAST_STAND,
            Id = new byte[] { 0xD6, 0xC4, 0x00, 0x00 }
        };
        public static Gear RingOfStorms = new Gear()
        {
            Name = RING_OF_STORMS,
            Id = new byte[] { 0xE9, 0xC4, 0x00, 0x00 }
        };
        public static Gear TeleportationRing = new Gear()
        {
            Name = TELEPORTATION_RING,
            Id = new byte[] { 0xDE, 0xC4, 0x00, 0x00 }
        };


        public static Dictionary<string, SlotItem> Gears = new Dictionary<string, SlotItem>
        {
            { ANTITRAP_VAMBRACE, AntitrapVambrace },
            { ARCANE_BUBBLE_BLOWER, ArcaneBubbleBlower },
            { FIRE_WALL_BRACERS, FireWallBracers },
            { FREEDOM_TRINKET, FreedomTrinket },
            { GNOMISH_REPAIR_KIT, GnomishRepairKit },
            { GREATER_FREEDOM_TRINKET, GreaterFreedomTrinket },
            { HOBGOBLIN_CHARM, HobgoblinCharm },
            { ICE_AMULET, IceAmulet },
            { LIGHTNING_RING, LightningRing },
            { MAGES_CLOVER, MagesClover },
            { MAGES_PICNIC, MagesPicnic },
            { MENDING_ROOT, MendingRoot },
            { RING_OF_LAST_STAND, RingOfLastStand },
            { RING_OF_STORMS, RingOfStorms },
            { TELEPORTATION_RING, TeleportationRing }
        };
    }
}
