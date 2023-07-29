using System.Collections.Generic;
using static SingleplayerLauncher.Names.Gear;
using static SingleplayerLauncher.Names.Hero;

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
            IdByHeroName = new Dictionary<string, byte[]> {
                { BIONKA, new byte[] { 0x02, 0xC4, 0x00, 0x00 } },
                { GABRIELLA, new byte[] { 0x02, 0xC4, 0x00, 0x00 } },
                { HOGARTH, new byte[] { 0x02, 0xC4, 0x00, 0x00 } },
                { IVY, new byte[] { 0x02, 0xC4, 0x00, 0x00 } },
                { MAXIMILIAN, new byte[] { 0x02, 0xC4, 0x00, 0x00 } },
                { SMOLDER, new byte[] { 0x02, 0xC4, 0x00, 0x00 } },
                { OZIEL, new byte[] { 0x89, 0xFD, 0xFF, 0xFF } },
                { BLOODSPIKE, new byte[] { 0x1D, 0xFE, 0xFF, 0xFF } },
                { BLACKPAW, new byte[] { 0x5E, 0xFE, 0xFF, 0xFF } },
                { BRASS, new byte[] { 0x47, 0xFD, 0xFF, 0xFF } },
            }
        };
        public static Gear ArcaneBubbleBlower = new Gear()
        {
            Name = ARCANE_BUBBLE_BLOWER,
            IdByHeroName = new Dictionary<string, byte[]> {
                { BIONKA, new byte[] { 0xE3, 0xC4, 0x00, 0x00 } },
                { GABRIELLA, new byte[] { 0xE3, 0xC4, 0x00, 0x00 } },
                { HOGARTH, new byte[] { 0xE3, 0xC4, 0x00, 0x00 } },
                { IVY, new byte[] { 0xE3, 0xC4, 0x00, 0x00 } },
                { MAXIMILIAN, new byte[] { 0xE3, 0xC4, 0x00, 0x00 } },
                { SMOLDER, new byte[] { 0xE3, 0xC4, 0x00, 0x00 } },
                { OZIEL, new byte[] { 0x4F, 0xFD, 0xFF, 0xFF } },
                { BLOODSPIKE, new byte[] { 0xDD, 0xFD, 0xFF, 0xFF } },
                { BLACKPAW, new byte[] { 0x1E, 0xFE, 0xFF, 0xFF } },
                { BRASS, new byte[] { 0x07, 0xFD, 0xFF, 0xFF } },
            }
        };
        public static Gear FireWallBracers = new Gear()
        {
            Name = FIRE_WALL_BRACERS,
            IdByHeroName = new Dictionary<string, byte[]> {
                { BIONKA, new byte[] { 0xE5, 0xC4, 0x00, 0x00 } },
                { GABRIELLA, new byte[] { 0xE5, 0xC4, 0x00, 0x00 } },
                { HOGARTH, new byte[] { 0xE5, 0xC4, 0x00, 0x00 } },
                { IVY, new byte[] { 0xE5, 0xC4, 0x00, 0x00 } },
                { MAXIMILIAN, new byte[] { 0xE5, 0xC4, 0x00, 0x00 } },
                { SMOLDER, new byte[] { 0xE5, 0xC4, 0x00, 0x00 } },
                { OZIEL, new byte[] { 0x4E, 0xFD, 0xFF, 0xFF } },
                { BLOODSPIKE, new byte[] { 0xDC, 0xFD, 0xFF, 0xFF } },
                { BLACKPAW, new byte[] { 0x1D, 0xFE, 0xFF, 0xFF } },
                { BRASS, new byte[] { 0x06, 0xFD, 0xFF, 0xFF } },
            }
        };
        public static Gear FreedomTrinket = new Gear()
        {
            Name = FREEDOM_TRINKET,
            IdByHeroName = new Dictionary<string, byte[]> {
                { BIONKA, new byte[] { 0xCE, 0xC4, 0x00, 0x00 } },
                { GABRIELLA, new byte[] { 0xCE, 0xC4, 0x00, 0x00 } },
                { HOGARTH, new byte[] { 0xCE, 0xC4, 0x00, 0x00 } },
                { IVY, new byte[] { 0xCE, 0xC4, 0x00, 0x00 } },
                { MAXIMILIAN, new byte[] { 0xCE, 0xC4, 0x00, 0x00 } },
                { SMOLDER, new byte[] { 0xCE, 0xC4, 0x00, 0x00 } },
                { OZIEL, new byte[] { 0x56, 0xFD, 0xFF, 0xFF } },
                { BLOODSPIKE, new byte[] { 0xE6, 0xFD, 0xFF, 0xFF } },
                { BLACKPAW, new byte[] { 0x27, 0xFE, 0xFF, 0xFF } },
                { BRASS, new byte[] { 0x10, 0xFD, 0xFF, 0xFF } },
            }
        };
        public static Gear GnomishRepairKit = new Gear()
        {
            Name = GNOMISH_REPAIR_KIT,
            IdByHeroName = new Dictionary<string, byte[]> {
                { BIONKA, new byte[] { 0xDC, 0xC4, 0x00, 0x00 } },
                { GABRIELLA, new byte[] { 0xDC, 0xC4, 0x00, 0x00 } },
                { HOGARTH, new byte[] { 0xDC, 0xC4, 0x00, 0x00 } },
                { IVY, new byte[] { 0xDC, 0xC4, 0x00, 0x00 } },
                { MAXIMILIAN, new byte[] { 0xDC, 0xC4, 0x00, 0x00 } },
                { SMOLDER, new byte[] { 0xDC, 0xC4, 0x00, 0x00 } },
                { OZIEL, new byte[] { 0x51, 0xFD, 0xFF, 0xFF } },
                { BLOODSPIKE, new byte[] { 0xDF, 0xFD, 0xFF, 0xFF } },
                { BLACKPAW, new byte[] { 0x20, 0xFE, 0xFF, 0xFF } },
                { BRASS, new byte[] { 0x09, 0xFD, 0xFF, 0xFF } },
            }
        };
        public static Gear GreaterFreedomTrinket = new Gear()
        {
            Name = GREATER_FREEDOM_TRINKET,
            IdByHeroName = new Dictionary<string, byte[]> {
                { BIONKA, new byte[] { 0xD0, 0xC4, 0x00, 0x00 } },
                { GABRIELLA, new byte[] { 0xD0, 0xC4, 0x00, 0x00 } },
                { HOGARTH, new byte[] { 0xD0, 0xC4, 0x00, 0x00 } },
                { IVY, new byte[] { 0xD0, 0xC4, 0x00, 0x00 } },
                { MAXIMILIAN, new byte[] { 0xD0, 0xC4, 0x00, 0x00 } },
                { SMOLDER, new byte[] { 0xD0, 0xC4, 0x00, 0x00 } },
                { OZIEL, new byte[] { 0x55, 0xFD, 0xFF, 0xFF } },
                { BLOODSPIKE, new byte[] { 0xE5, 0xFD, 0xFF, 0xFF } },
                { BLACKPAW, new byte[] { 0x26, 0xFE, 0xFF, 0xFF } },
                { BRASS, new byte[] { 0x0F, 0xFD, 0xFF, 0xFF } },
            }
        };
        public static Gear HobgoblinCharm = new Gear()
        {
            Name = HOBGOBLIN_CHARM,
            IdByHeroName = new Dictionary<string, byte[]> {
                { BIONKA, new byte[] { 0xD4, 0xC4, 0x00, 0x00 } },
                { GABRIELLA, new byte[] { 0xD4, 0xC4, 0x00, 0x00 } },
                { HOGARTH, new byte[] { 0xD4, 0xC4, 0x00, 0x00 } },
                { IVY, new byte[] { 0xD4, 0xC4, 0x00, 0x00 } },
                { MAXIMILIAN, new byte[] { 0xD4, 0xC4, 0x00, 0x00 } },
                { SMOLDER, new byte[] { 0xD4, 0xC4, 0x00, 0x00 } },
                { OZIEL, new byte[] { 0x54, 0xFD, 0xFF, 0xFF } },
                { BLOODSPIKE, new byte[] { 0xE3, 0xFD, 0xFF, 0xFF } },
                { BLACKPAW, new byte[] { 0x24, 0xFE, 0xFF, 0xFF } },
                { BRASS, new byte[] { 0x0D, 0xFD, 0xFF, 0xFF } },
            }
        };
        public static Gear IceAmulet = new Gear()
        {
            Name = ICE_AMULET,
            IdByHeroName = new Dictionary<string, byte[]> {
                { BIONKA, new byte[] { 0xE7, 0xC4, 0x00, 0x00 } },
                { GABRIELLA, new byte[] { 0xE7, 0xC4, 0x00, 0x00 } },
                { HOGARTH, new byte[] { 0xE7, 0xC4, 0x00, 0x00 } },
                { IVY, new byte[] { 0xE7, 0xC4, 0x00, 0x00 } },
                { MAXIMILIAN, new byte[] { 0xE7, 0xC4, 0x00, 0x00 } },
                { SMOLDER, new byte[] { 0xE7, 0xC4, 0x00, 0x00 } },
                { OZIEL, new byte[] { 0x4D, 0xFD, 0xFF, 0xFF } },
                { BLOODSPIKE, new byte[] { 0xDB, 0xFD, 0xFF, 0xFF } },
                { BLACKPAW, new byte[] { 0x1C, 0xFE, 0xFF, 0xFF } },
                { BRASS, new byte[] { 0x05, 0xFD, 0xFF, 0xFF } },
            }
        };
        public static Gear LightningRing = new Gear()
        {
            Name = LIGHTNING_RING,
            IdByHeroName = new Dictionary<string, byte[]> {
                { BIONKA, new byte[] { 0xEB, 0xC4, 0x00, 0x00 } },
                { GABRIELLA, new byte[] { 0xEB, 0xC4, 0x00, 0x00 } },
                { HOGARTH, new byte[] { 0xEB, 0xC4, 0x00, 0x00 } },
                { IVY, new byte[] { 0xEB, 0xC4, 0x00, 0x00 } },
                { MAXIMILIAN, new byte[] { 0xEB, 0xC4, 0x00, 0x00 } },
                { SMOLDER, new byte[] { 0xEB, 0xC4, 0x00, 0x00 } },
                { OZIEL, new byte[] { 0x4B, 0xFD, 0xFF, 0xFF } },
                { BLOODSPIKE, new byte[] { 0xD9, 0xFD, 0xFF, 0xFF } },
                { BLACKPAW, new byte[] { 0x1A, 0xFE, 0xFF, 0xFF } },
                { BRASS, new byte[] { 0x03, 0xFD, 0xFF, 0xFF } },
            }
        };
        public static Gear MagesClover = new Gear()
        {
            Name = MAGES_CLOVER,
            IdByHeroName = new Dictionary<string, byte[]> {
                { BIONKA, new byte[] { 0xDA, 0xC4, 0x00, 0x00 } },
                { GABRIELLA, new byte[] { 0xDA, 0xC4, 0x00, 0x00 } },
                { HOGARTH, new byte[] { 0xDA, 0xC4, 0x00, 0x00 } },
                { IVY, new byte[] { 0xDA, 0xC4, 0x00, 0x00 } },
                { MAXIMILIAN, new byte[] { 0xDA, 0xC4, 0x00, 0x00 } },
                { SMOLDER, new byte[] { 0xDA, 0xC4, 0x00, 0x00 } },
                { OZIEL, new byte[] { 0x70, 0xFF, 0xFF, 0xFF } },
                { BLOODSPIKE, new byte[] { 0xE0, 0xFD, 0xFF, 0xFF } },
                { BLACKPAW, new byte[] { 0x21, 0xFE, 0xFF, 0xFF } },
                { BRASS, new byte[] { 0x0A, 0xFD, 0xFF, 0xFF } },
            }
        };
        public static Gear MagesPicnic = new Gear()
        {
            Name = MAGES_PICNIC,
            IdByHeroName = new Dictionary<string, byte[]> {
                { BIONKA, new byte[] { 0xD8, 0xC4, 0x00, 0x00 } },
                { GABRIELLA, new byte[] { 0xD8, 0xC4, 0x00, 0x00 } },
                { HOGARTH, new byte[] { 0xD8, 0xC4, 0x00, 0x00 } },
                { IVY, new byte[] { 0xD8, 0xC4, 0x00, 0x00 } },
                { MAXIMILIAN, new byte[] { 0xD8, 0xC4, 0x00, 0x00 } },
                { SMOLDER, new byte[] { 0xD8, 0xC4, 0x00, 0x00 } },
                { OZIEL, new byte[] { 0x52, 0xFD, 0xFF, 0xFF } },
                { BLOODSPIKE, new byte[] { 0xE1, 0xFD, 0xFF, 0xFF } },
                { BLACKPAW, new byte[] { 0x22, 0xFE, 0xFF, 0xFF } },
                { BRASS, new byte[] { 0x0B, 0xFD, 0xFF, 0xFF } },
            }
        };
        public static Gear MendingRoot = new Gear()
        {
            Name = MENDING_ROOT,
            IdByHeroName = new Dictionary<string, byte[]> {
                { BIONKA, new byte[] { 0xD2, 0xC4, 0x00, 0x00 } },
                { GABRIELLA, new byte[] { 0xD2, 0xC4, 0x00, 0x00 } },
                { HOGARTH, new byte[] { 0xD2, 0xC4, 0x00, 0x00 } },
                { IVY, new byte[] { 0xD2, 0xC4, 0x00, 0x00 } },
                { MAXIMILIAN, new byte[] { 0xD2, 0xC4, 0x00, 0x00 } },
                { SMOLDER, new byte[] { 0xD2, 0xC4, 0x00, 0x00 } },
                { OZIEL, new byte[] { 0x71, 0xFF, 0xFF, 0xFF } },
                { BLOODSPIKE, new byte[] { 0xE4, 0xFD, 0xFF, 0xFF } },
                { BLACKPAW, new byte[] { 0x25, 0xFE, 0xFF, 0xFF } },
                { BRASS, new byte[] { 0x0E, 0xFD, 0xFF, 0xFF } },
            }
        };
        public static Gear RingOfLastStand = new Gear()
        {
            Name = RING_OF_LAST_STAND,
            IdByHeroName = new Dictionary<string, byte[]> {
                { BIONKA, new byte[] { 0xD6, 0xC4, 0x00, 0x00 } },
                { GABRIELLA, new byte[] { 0xD6, 0xC4, 0x00, 0x00 } },
                { HOGARTH, new byte[] { 0xD6, 0xC4, 0x00, 0x00 } },
                { IVY, new byte[] { 0xD6, 0xC4, 0x00, 0x00 } },
                { MAXIMILIAN, new byte[] { 0xD6, 0xC4, 0x00, 0x00 } },
                { SMOLDER, new byte[] { 0xD6, 0xC4, 0x00, 0x00 } },
                { OZIEL, new byte[] { 0x53, 0xFD, 0xFF, 0xFF } },
                { BLOODSPIKE, new byte[] { 0xE2, 0xFD, 0xFF, 0xFF } },
                { BLACKPAW, new byte[] { 0x23, 0xFE, 0xFF, 0xFF } },
                { BRASS, new byte[] { 0x0C, 0xFD, 0xFF, 0xFF } },
            }
        };
        public static Gear RingOfStorms = new Gear()
        {
            Name = RING_OF_STORMS,
            IdByHeroName = new Dictionary<string, byte[]> {
                { BIONKA, new byte[] { 0xE9, 0xC4, 0x00, 0x00 } },
                { GABRIELLA, new byte[] { 0xE9, 0xC4, 0x00, 0x00 } },
                { HOGARTH, new byte[] { 0xE9, 0xC4, 0x00, 0x00 } },
                { IVY, new byte[] { 0xE9, 0xC4, 0x00, 0x00 } },
                { MAXIMILIAN, new byte[] { 0xE9, 0xC4, 0x00, 0x00 } },
                { SMOLDER, new byte[] { 0xE9, 0xC4, 0x00, 0x00 } },
                { OZIEL, new byte[] { 0x4C, 0xFD, 0xFF, 0xFF } },
                { BLOODSPIKE, new byte[] { 0xDA, 0xFD, 0xFF, 0xFF } },
                { BLACKPAW, new byte[] { 0x1B, 0xFE, 0xFF, 0xFF } },
                { BRASS, new byte[] { 0x04, 0xFD, 0xFF, 0xFF } },
            }
        };
        public static Gear TeleportationRing = new Gear()
        {
            Name = TELEPORTATION_RING,
            IdByHeroName = new Dictionary<string, byte[]> {
                { BIONKA, new byte[] { 0xDE, 0xC4, 0x00, 0x00 } },
                { GABRIELLA, new byte[] { 0xDE, 0xC4, 0x00, 0x00 } },
                { HOGARTH, new byte[] { 0xDE, 0xC4, 0x00, 0x00 } },
                { IVY, new byte[] { 0xDE, 0xC4, 0x00, 0x00 } },
                { MAXIMILIAN, new byte[] { 0xDE, 0xC4, 0x00, 0x00 } },
                { SMOLDER, new byte[] { 0xDE, 0xC4, 0x00, 0x00 } },
                { OZIEL, new byte[] { 0x50, 0xFD, 0xFF, 0xFF } },
                { BLOODSPIKE, new byte[] { 0xDE, 0xFD, 0xFF, 0xFF } },
                { BLACKPAW, new byte[] { 0x1F, 0xFE, 0xFF, 0xFF } },
                { BRASS, new byte[] { 0x08, 0xFD, 0xFF, 0xFF } },
            }
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
