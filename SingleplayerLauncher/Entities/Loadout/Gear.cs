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
            Id = 200,
            Name = ANTITRAP_VAMBRACE,
            ItemTemplateName = "SpitfireGame.RItemDisableTrapVambrace",
            Description = "Negates control effects for a short time after use."
        };
        public static Gear ArcaneBubbleBlower = new Gear()
        {
            Id = 201,
            Name = ARCANE_BUBBLE_BLOWER,
            ItemTemplateName = "SpitfireGame.RItemWeaponArcaneBubbleBlower",
            Description = "Creates a bomb that explodes after a time, dealing Arcane damage in that area. It's targets are susceptible to Arcane damage."
        };
        public static Gear FireWallBracers = new Gear()
        {
            Id = 202,
            Name = FIRE_WALL_BRACERS,
            ItemTemplateName = "SpitfireGame.RItemWeaponFlameWallBracers",
            Description = "Creates a wall of Fire igniting enemies who walk through it. Fire damage from the same Hero or Trap-type does not stack."
        };
        public static Gear FreedomTrinket = new Gear()
        {
            Id = 203,
            Name = FREEDOM_TRINKET,
            ItemTemplateName = "SpitfireGame.RItemTrinketFreedom",
            Description = "Negates control effects for a short time after use."
        };
        public static Gear GnomishRepairKit = new Gear()
        {
            Id = 204,
            Name = GNOMISH_REPAIR_KIT,
            ItemTemplateName = "SpitfireGame.RItemTrinketOrcToolkit",
            Description = "Activates a targeted Trap even if it is on cooldown."
        };
        public static Gear GreaterFreedomTrinket = new Gear()
        {
            Id = 205,
            Name = GREATER_FREEDOM_TRINKET,
            ItemTemplateName = "SpitfireGame.RItemTrinketFreedomGreater",
            Description = "Negates control effects for you and nearby allies/minions for a short time after use."
        };
        public static Gear HobgoblinCharm = new Gear()
        {
            Id = 206,
            Name = HOBGOBLIN_CHARM,
            ItemTemplateName = "SpitfireGame.RItemTrinketHobgoblinCharm",
            Description = "Heals an allied minion. Siege gear but can work on summoned allied minions."
        };
        public static Gear IceAmulet = new Gear()
        {
            Id = 207,
            Name = ICE_AMULET,
            ItemTemplateName = "SpitfireGame.RItemWeaponIceAmulet",
            Description = "Fires three projectiles at once. Frost damage applies chilled to enemies, which can cause them to become frozen."
        };
        public static Gear LightningRing = new Gear()
        {
            Id = 208,
            Name = LIGHTNING_RING,
            ItemTemplateName = "SpitfireGame.RItemWeaponLightningRing",
            Description = "Fires a short burst of Lightning damage to enemies in range."
        };
        public static Gear MagesClover = new Gear()
        {
            Id = 209,
            Name = MAGES_CLOVER,
            ItemTemplateName = "SpitfireGame.RItemTrinketManaRegen",
            Description = "Grants a short period of increased mana regeneration. Effect is canceled upon taking damage."
        };
        public static Gear MagesPicnic = new Gear()
        {
            Id = 210,
            Name = MAGES_PICNIC,
            ItemTemplateName = "SpitfireGame.RItemTrinketMagesPicnic",
            Description = "Creates a totem that increases mana regeneration for nearby allied players."
        };
        public static Gear MendingRoot = new Gear()
        {
            Id = 211,
            Name = MENDING_ROOT,
            ItemTemplateName = "SpitfireGame.RItemTrinketHealing",
            Description = "Grants a short duration of increased health regeneration. Being attacked cancels the regeneration."
        };
        public static Gear RingOfLastStand = new Gear()
        {
            Id = 212,
            Name = RING_OF_LAST_STAND,
            ItemTemplateName = "SpitfireGame.RItemTrinketLastStand",
            Description = "Grants the Hero damage immunity for a short duration."
        };
        public static Gear RingOfStorms = new Gear()
        {
            Id = 213,
            Name = RING_OF_STORMS,
            ItemTemplateName = "SpitfireGame.RItemWeaponLightningCloudRing",
            Description = "Creates a storm that deals Lightning damage to enemies in range. Enemies killed by Lightning explode, dealing damage in an area around them."
        };
        public static Gear TeleportationRing = new Gear()
        {
            Id = 214,
            Name = TELEPORTATION_RING,
            ItemTemplateName = "SpitfireGame.RItemTrinketTeleport",
            Description = "Teleports the Hero back to its allied rift. Ring takes 1s to cast. Taking damage interrupts cast."
        };
        public static Gear FlameBracers = new Gear()
        {
            Id = 215,
            Name = FLAME_BRACERS,
            ItemTemplateName = "gear_firebracers.gear_firebracers",
            Description = "Launches a Fireball that deals significant damage over time to the first target hit. Fire damage from the same hero or trap-type does not stack.."
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
            { TELEPORTATION_RING, TeleportationRing },
            { FLAME_BRACERS, FlameBracers }
        };


        public static Dictionary<int, SlotItem> GearsById = new Dictionary<int, SlotItem>
        {
            {  AntitrapVambrace.Id, AntitrapVambrace },
            {  ArcaneBubbleBlower.Id, ArcaneBubbleBlower },
            {  FireWallBracers.Id, FireWallBracers },
            {  FreedomTrinket.Id, FreedomTrinket },
            {  GnomishRepairKit.Id, GnomishRepairKit },
            {  GreaterFreedomTrinket.Id, GreaterFreedomTrinket },
            {  HobgoblinCharm.Id, HobgoblinCharm },
            {  IceAmulet.Id, IceAmulet },
            {  LightningRing.Id, LightningRing },
            {  MagesClover.Id, MagesClover },
            {  MagesPicnic.Id, MagesPicnic },
            {  MendingRoot.Id, MendingRoot },
            {  RingOfLastStand.Id, RingOfLastStand },
            {  RingOfStorms.Id, RingOfStorms },
            {  TeleportationRing.Id, TeleportationRing },
            {  FlameBracers.Id, FlameBracers }
        };
    }
}
