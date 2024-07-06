using System.Collections.Generic;
using static SingleplayerLauncher.Names.Dye;

namespace SingleplayerLauncher.Model
{
    public class Dye : LoadoutItem
    {
        public int SpitfireGameIdBytes { get; private set; } // integer used in the .ini config

        // private constructor
        Dye() { }

        // static members
        public static Dye Normal = new Dye()
        {
            Id = 1,
            Name = NORMAL,
            SpitfireGameIdBytes = 0
        };
        public static Dye Heroic = new Dye()
        {
            Id = 2,
            Name = HEROIC,
            SpitfireGameIdBytes = 1
        };
        public static Dye Legendary = new Dye()
        {
            Id = 3,
            Name = LEGENDARY,
            SpitfireGameIdBytes = 2
        };

        public static Dictionary<string, Dye> Dyes = new Dictionary<string, Dye>
        {
            { NORMAL, Normal },
            { HEROIC, Heroic },
            { LEGENDARY, Legendary },
        };

        public static Dictionary<int, Dye> DyesById = new Dictionary<int, Dye>
        {
            { Normal.Id, Normal },
            { Heroic.Id, Heroic },
            { Legendary.Id, Legendary },
        };

        public static Dye GetById(int id)
        {
            if (DyesById.TryGetValue(id, out var dye))
            {
                return dye;
            }
            return new Dye { Id = 0, Name = "Unknown" };
        }

    }
}
