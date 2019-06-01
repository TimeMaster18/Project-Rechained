using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace SingleplayerLauncher
{

    public static class Traps
    {
        //Map out all hex values of traps
        public static byte[] Acid_Sprayer = { 0x5A, 0xC4, 0x00, 0x00 };
        public static byte[] Arcane_Bowling_Ball = { 0x62, 0xC4, 0x00, 0x00 };
        public static byte[] Arcane_Phaser = { 0x64, 0xC4, 0x00, 0x00 };
        public static byte[] Arrow_Wall = { 0x66, 0xC4, 0x00, 0x00 };
        public static byte[] BGH_Arrow_Wall = { 0x68, 0xC4, 0x00, 0x00 };
        public static byte[] Ceiling_Ballista = { 0x6A, 0xC4, 0x00, 0x00 };
        public static byte[] Dragons_Lance = { 0x6C, 0xC4, 0x00, 0x00 };
        public static byte[] BGH_Ceiling_Ballista = { 0x6E, 0xC4, 0x00, 0x00 };
        public static byte[] Barricade = { 0x70, 0xC4, 0x00, 0x00 };
        public static byte[] Great_Wall_Barricade = { 0x72, 0xC4, 0x00, 0x00 };
        public static byte[] Boom_Barrel = { 0x74, 0xC4, 0x00, 0x00 };
        public static byte[] Boom_Barrel_Roller = { 0x76, 0xC4, 0x00, 0x00 };
        public static byte[] Boulder_Chute = { 0x78, 0xC4, 0x00, 0x00 };
        public static byte[] Icicle_Impaler = { 0x7A, 0xC4, 0x00, 0x00 };
        public static byte[] Brimstone = { 0x7C, 0xC4, 0x00, 0x00 };
        public static byte[] Coin_Forge = { 0x7E, 0xC4, 0x00, 0x00 };
        public static byte[] Cursed_Ground = { 0x80, 0xC4, 0x00, 0x00 };
        public static byte[] Decoy = { 0x82, 0xC4, 0x00, 0x00 };
        public static byte[] Spitfire_Wall = { 0x84, 0xC4, 0x00, 0x00 };
        public static byte[] Fire_Cracker = { 0x86, 0xC4, 0x00, 0x00 };
        public static byte[] Flip_Trap = { 0x88, 0xC4, 0x00, 0x00 };
        public static byte[] Floor_Scorcher = { 0x8A, 0xC4, 0x00, 0x00 };
        public static byte[] Temple_Alarm_Gong = { 0x8C, 0xC4, 0x00, 0x00 };
        public static byte[] Grinder = { 0x8E, 0xC4, 0x00, 0x00 };
        public static byte[] Quarter_Pounder = { 0x90, 0xC4, 0x00, 0x00 };
        public static byte[] Haymaker = { 0x92, 0xC4, 0x00, 0x00 };
        public static byte[] Healing_Well = { 0x94, 0xC4, 0x00, 0x00 };
        public static byte[] Ice_Shard = { 0x96, 0xC4, 0x00, 0x00 };
        public static byte[] Ice_Vent = { 0x98, 0xC4, 0x00, 0x00 };
        public static byte[] Lightning_Rod = { 0x9A, 0xC4, 0x00, 0x00 };
        public static byte[] Mana_Well = { 0x9C, 0xC4, 0x00, 0x00 };
        public static byte[] Summoner_Trap = { 0x9E, 0xC4, 0x00, 0x00 };
        public static byte[] Naphtha_Sprayer = { 0xA0, 0xC4, 0x00, 0x00 };
        public static byte[] Overload_Trap = { 0xA2, 0xC4, 0x00, 0x00 };
        public static byte[] Powerup_Damage = { 0xA4, 0xC4, 0x00, 0x00 };
        public static byte[] Pounder = { 0xA6, 0xC4, 0x00, 0x00 };
        public static byte[] Conscussive_Pounder = { 0xA8, 0xC4, 0x00, 0x00 };
        public static byte[] Power_Generator = { 0xAA, 0xC4, 0x00, 0x00 };
        public static byte[] Projectile_Shield = { 0xAC, 0xC4, 0x00, 0x00 };
        public static byte[] Push_Trap = { 0xAE, 0xC4, 0x00, 0x00 };
        public static byte[] Saw_Of_Arctos = { 0xB0, 0xC4, 0x00, 0x00 };
        public static byte[] Shield_Powerup = { 0xB2, 0xC4, 0x00, 0x00 };
        public static byte[] Speed_Pad = { 0xB4, 0xC4, 0x00, 0x00 };
        public static byte[] Floor_Spikes = { 0xB6, 0xC4, 0x00, 0x00 };
        public static byte[] Spike_Wall = { 0xB8, 0xC4, 0x00, 0x00 };
        public static byte[] Steam_Vent = { 0xBA, 0xC4, 0x00, 0x00 };
        public static byte[] Swinging_Mace = { 0xBC, 0xC4, 0x00, 0x00 };
        public static byte[] Tar_Trap = { 0xBE, 0xC4, 0x00, 0x00 };
        public static byte[] Viscous_Tar = { 0xC0, 0xC4, 0x00, 0x00 };
        public static byte[] Shock_Zapper = { 0xC2, 0xC4, 0x00, 0x00 };
        public static byte[] BGH_Shock_Zapper = { 0xC4, 0xC4, 0x00, 0x00 };
        public static byte[] Trip_Wire = { 0xC6, 0xC4, 0x00, 0x00 };
        public static byte[] Wall_Blades = { 0xC8, 0xC4, 0x00, 0x00 };
        public static byte[] Wall_Charger = { 0xCA, 0xC4, 0x00, 0x00 };
        public static byte[] Web_Spinner = { 0xCC, 0xC4, 0x00, 0x00 };
        public static byte[] Freedom_Trinket = { 0xCE, 0xC4, 0x00, 0x00 };
        public static byte[] Greater_Freedom_Trinket = { 0xD0, 0xC4, 0x00, 0x00 };
        public static byte[] Mending_Root = { 0xD2, 0xC4, 0x00, 0x00 };
        public static byte[] Hobgoblin_Charm = { 0xD4, 0xC4, 0x00, 0x00 };
        public static byte[] Ring_of_Last_Stand = { 0xD6, 0xC4, 0x00, 0x00 };
        public static byte[] Mages_Picnic = { 0xD8, 0xC4, 0x00, 0x00 };
        public static byte[] Mages_Clover = { 0xDA, 0xC4, 0x00, 0x00 };
        public static byte[] Gnomish_Repair_Kit = { 0xDC, 0xC4, 0x00, 0x00 };
        public static byte[] Teleportation_Ring = { 0xDE, 0xC4, 0x00, 0x00 };
        public static byte[] Arcane_Bubble_Blower = { 0xE3, 0xC4, 0x00, 0x00 };
        public static byte[] Fire_Wall_Bracers = { 0xE5, 0xC4, 0x00, 0x00 };
        public static byte[] Ice_Amulet = { 0xE7, 0xC4, 0x00, 0x00 };
        public static byte[] Ring_of_Storms = { 0xE9, 0xC4, 0x00, 0x00 };
        public static byte[] Lightning_Ring = { 0xEB, 0xC4, 0x00, 0x00 };
        public static byte[] AntiTrap_Vambrace = { 0x02, 0xC4, 0x00, 0x00 };
        private static Dictionary<byte[], string> allTraps = new Dictionary<byte[], string>();

        //Store all traps in a dictionary for easy usage
        public static Dictionary<byte[], string> AllTraps
        {
            get
            {
                if (allTraps.Count() == 0)
                {
                    Type myType = typeof(Traps);
                    FieldInfo[] myField = myType.GetFields().Where(_ => _.FieldType == typeof(byte[])).ToArray();
                    foreach (var t in myField)
                    {
                        allTraps.Add((byte[])t.GetValue(null), t.Name);
                    }
                }
                return allTraps;
            }
        }
    }
}
