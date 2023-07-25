using System.Collections.Generic;
using static SingleplayerLauncher.Names.Dye;

namespace SingleplayerLauncher.Model
{
    public class Dye
    {

        public string Name { get; private set; }
        public int Id { get; private set; } // integer used in the .ini config

        // private constructor
        Dye() { }

        // static members
        public static Dye Normal = new Dye()
        {
            Name = NORMAL,
            Id = 0
        };
        public static Dye Heroic = new Dye()
        {
            Name = HEROIC,
            Id = 1
        };
        public static Dye Legendary = new Dye()
        {
            Name = LEGENDARY,
            Id = 2
        };

        public static Dictionary<string, Dye> Dyes = new Dictionary<string, Dye>
        {
            { NORMAL, Normal },
            { HEROIC, Heroic },
            { LEGENDARY, Legendary },
        };

    }
}
