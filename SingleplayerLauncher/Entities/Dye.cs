using System.Collections.Generic;
using static SingleplayerLauncher.Names.Dye;

namespace SingleplayerLauncher.Model
{
    public class Dye : LoadoutItem
    {
        public int CodeName { get; private set; }

        // private constructor
        Dye() { }

        // static members
        public static Dye Normal = new()
        {
            Id = 1,
            Name = NORMAL,
            CodeName = 0
        };
        public static Dye Heroic = new()
        {
            Id = 2,
            Name = HEROIC,
            CodeName = 1
        };
        public static Dye Legendary = new()
        {
            Id = 3,
            Name = LEGENDARY,
            CodeName = 2
        };

        public static Dictionary<string, Dye> Dyes = new()
        {
            { NORMAL, Normal },
            { HEROIC, Heroic },
            { LEGENDARY, Legendary },
        };

        public static Dictionary<int, Dye> DyesById = new()
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
