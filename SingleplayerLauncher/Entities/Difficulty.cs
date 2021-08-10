using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static SingleplayerLauncher.Names.Difficulty;

namespace SingleplayerLauncher.Model
{
    public class Difficulty
    {
        public string Name { get; private set; }
        public int AccountLevel { get; set; } = 1;
        public int EnemyLevel { get; set; } = 1;
        public int PlayerCount { get; set; } = 1;
        public int TrapTier { get; set; } = 1;

        // static members
        // SURVIVAL 
        public static Difficulty Apprentice = new Difficulty()
        {
            Name = APPRENTICE,
            AccountLevel = 1,
            EnemyLevel = 1,
            TrapTier = 1,
        };

        public static Difficulty WarMage = new Difficulty()
        {
            Name = WAR_MAGE,
            AccountLevel = 11,
            EnemyLevel = 11,
            TrapTier = 2,
        };

        public static Difficulty Master = new Difficulty()
        {
            Name = MASTER,
            AccountLevel = 26,
            EnemyLevel = 26,
            TrapTier = 4,
        };

        public static Difficulty RiftLord = new Difficulty()
        {
            Name = RIFT_LORD,
            AccountLevel = 46,
            EnemyLevel = 46,
            TrapTier = 6,
        };

        public static Dictionary<string, Difficulty> SurvivalDifficulties = new Dictionary<string, Difficulty>
        {
            { APPRENTICE, Difficulty.Apprentice },
            { WAR_MAGE, Difficulty.WarMage },
            { MASTER, Difficulty.Master },
            { RIFT_LORD, Difficulty.RiftLord },
        };

        // EXTRA SURVIVAL
        public static Difficulty ApprenticePlus = new Difficulty()
        {
            Name = APPRENTICE_PLUS,
            AccountLevel = 1,
            EnemyLevel = 10,
            TrapTier = 1,
            PlayerCount = 3,
        };

        public static Difficulty WarMagePlus = new Difficulty()
        {
            Name = WAR_MAGE_PLUS,
            AccountLevel = 1,
            EnemyLevel = 25,
            TrapTier = 1,
            PlayerCount = 3,
        };

        public static Difficulty MasterPlus = new Difficulty()
        {
            Name = MASTER_PLUS,
            AccountLevel = 15,
            EnemyLevel = 35,
            TrapTier = 2,
            PlayerCount = 3,
        };

        public static Difficulty MasterPlus2 = new Difficulty()
        {
            Name = MASTER_PLUS_2,
            AccountLevel = 1,
            EnemyLevel = 45,
            TrapTier = 1,
            PlayerCount = 3,
        };

        public static Difficulty RiftLordPlus = new Difficulty()
        {
            Name = RIFT_LORD_PLUS,
            AccountLevel = 35,
            EnemyLevel = 55,
            TrapTier = 5,
            PlayerCount = 3,
        };

        public static Difficulty RiftLordPlus2 = new Difficulty()
        {
            Name = RIFT_LORD_PLUS_2,
            AccountLevel = 25,
            EnemyLevel = 65,
            TrapTier = 4,
            PlayerCount = 3,
        };

        public static Difficulty RiftLordPlus3 = new Difficulty()
        {
            Name = RIFT_LORD_PLUS_3,
            AccountLevel = 15,
            EnemyLevel = 75,
            TrapTier = 3,
            PlayerCount = 3,
        };

        public static Difficulty RiftLordPlus4 = new Difficulty()
        {
            Name = RIFT_LORD_PLUS_4,
            AccountLevel = 5,
            EnemyLevel = 85,
            TrapTier = 2,
            PlayerCount = 3,
        };

        public static Difficulty RiftLordPlus5 = new Difficulty()
        {
            Name = RIFT_LORD_PLUS_5,
            AccountLevel = 1,
            EnemyLevel = 100,
            TrapTier = 1,
            PlayerCount = 3,
        };

        public static Dictionary<string, Difficulty> ApprenticeExtraDifficulties = new Dictionary<string, Difficulty>
        {
            { APPRENTICE_PLUS, ApprenticePlus },
        };

        public static Dictionary<string, Difficulty> WarMageExtraDifficulties = new Dictionary<string, Difficulty>
        {
            { WAR_MAGE_PLUS, Difficulty.WarMagePlus },
        };

        public static Dictionary<string, Difficulty> MasterExtraDifficulties = new Dictionary<string, Difficulty>
        {
            { MASTER_PLUS, Difficulty.MasterPlus },
            { MASTER_PLUS_2, Difficulty.MasterPlus2 },
        };

        public static Dictionary<string, Difficulty> RiftLordExtraDifficulties = new Dictionary<string, Difficulty>
        {
            { RIFT_LORD_PLUS, Difficulty.RiftLordPlus },
            { RIFT_LORD_PLUS_2, Difficulty.RiftLordPlus2 },
            { RIFT_LORD_PLUS_3, Difficulty.RiftLordPlus3 },
            { RIFT_LORD_PLUS_4, Difficulty.RiftLordPlus4 },
            { RIFT_LORD_PLUS_5, Difficulty.RiftLordPlus5 },
        };

        public static Dictionary<string, Difficulty> SurvivalExtraDifficulties = 
            new List<Dictionary<string, Difficulty>>() { ApprenticeExtraDifficulties, WarMageExtraDifficulties, MasterExtraDifficulties, RiftLordExtraDifficulties }
                .SelectMany(dict => dict)
                .ToDictionary(pair => pair.Key, pair => pair.Value);

        public static Dictionary<string, Difficulty> SurvivalAllDifficulties =
            new List<Dictionary<string, Difficulty>>() { SurvivalDifficulties, SurvivalExtraDifficulties }
                .SelectMany(dict => dict)
                .ToDictionary(pair => pair.Key, pair => pair.Value);

        // ENDLESS
        public static Difficulty Endless = new Difficulty()
        {
            Name = ENDLESS,
            AccountLevel = 75,
            EnemyLevel = 75,
            TrapTier = 7,
            PlayerCount = 1,
        };

        // EXTRA ENDLESS 
        public static Difficulty EndlessPlus = new Difficulty()
        {
            Name = ENDLESS_PLUS,
            AccountLevel = 75,
            EnemyLevel = 90,
            TrapTier = 7,
            PlayerCount = 3,
        };

        public static Difficulty EndlessPlus2 = new Difficulty()
        {
            Name = ENDLESS_PLUS_2,
            AccountLevel = 75,
            EnemyLevel = 105,
            TrapTier = 7,
            PlayerCount = 3,
        };

        public static Difficulty EndlessPlus3 = new Difficulty()
        {
            Name = ENDLESS_PLUS_3,
            AccountLevel = 75,
            EnemyLevel = 120,
            TrapTier = 7,
            PlayerCount = 3,
        };

        public static Difficulty EndlessPlus4 = new Difficulty()
        {
            Name = ENDLESS_PLUS_4,
            AccountLevel = 75,
            EnemyLevel = 135,
            TrapTier = 7,
            PlayerCount = 3,
        };

        public static Difficulty EndlessPlus5 = new Difficulty()
        {
            Name = ENDLESS_PLUS_5,
            AccountLevel = 75,
            EnemyLevel = 150,
            TrapTier = 7,
            PlayerCount = 3,
        };

        public static Difficulty EndlessPlus6 = new Difficulty()
        {
            Name = ENDLESS_PLUS_6,
            AccountLevel = 75,
            EnemyLevel = 170,
            TrapTier = 7,
            PlayerCount = 3,
        };

        public static Difficulty EndlessPlus7 = new Difficulty()
        {
            Name = ENDLESS_PLUS_7,
            AccountLevel = 75,
            EnemyLevel = 195,
            TrapTier = 7,
            PlayerCount = 3,
        };

        public static Difficulty EndlessPlus8 = new Difficulty()
        {
            Name = ENDLESS_PLUS_8,
            AccountLevel = 75,
            EnemyLevel = 225,
            TrapTier = 7,
            PlayerCount = 3,
        };

        public static Difficulty EndlessPlus9 = new Difficulty()
        {
            Name = ENDLESS_PLUS_9,
            AccountLevel = 75,
            EnemyLevel = 255,
            TrapTier = 7,
            PlayerCount = 3,
        };

        public static Difficulty EndlessPlus10 = new Difficulty()
        {
            Name = ENDLESS_PLUS_10,
            AccountLevel = 75,
            EnemyLevel = 300,
            TrapTier = 7,
            PlayerCount = 3,
        };

        public static Dictionary<string, Difficulty> EndlessExtraDifficulties = new Dictionary<string, Difficulty>
        {
            { ENDLESS_PLUS, Difficulty.EndlessPlus },
            { ENDLESS_PLUS_2, Difficulty.EndlessPlus2 },
            { ENDLESS_PLUS_3, Difficulty.EndlessPlus3 },
            { ENDLESS_PLUS_4, Difficulty.EndlessPlus4 },
            { ENDLESS_PLUS_5, Difficulty.EndlessPlus5 },
            { ENDLESS_PLUS_6, Difficulty.EndlessPlus6 },
            { ENDLESS_PLUS_7, Difficulty.EndlessPlus7 },
            { ENDLESS_PLUS_8, Difficulty.EndlessPlus8 },
            { ENDLESS_PLUS_9, Difficulty.EndlessPlus9 },
            { ENDLESS_PLUS_10, Difficulty.EndlessPlus10 },
        };

        public static Dictionary<string, Difficulty> EndlessAllDifficulties =
            new List<Dictionary<string, Difficulty>>() { new Dictionary<string, Difficulty> { { ENDLESS, Difficulty.Endless } }, EndlessExtraDifficulties }
                .SelectMany(dict => dict)
                .ToDictionary(pair => pair.Key, pair => pair.Value);



        public static Dictionary<string, Difficulty> Difficulties =
            new List<Dictionary<string, Difficulty>>() {  EndlessAllDifficulties, SurvivalAllDifficulties }
                .SelectMany(dict => dict)
                .ToDictionary(pair => pair.Key, pair => pair.Value);

    }
}
