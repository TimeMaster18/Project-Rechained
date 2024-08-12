using System;
using System.Collections.Generic;
using static SingleplayerLauncher.Model.Map;

namespace SingleplayerLauncher.Model
{
    class Endless : IBattleground
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public Map Map { get; set; }

        public GameMode GameMode { get; set; } = GameMode.Endless;

        public Difficulty Difficulty { get; set; }

        public int StartingCoin { get; set; }

        public TimeSpan ParTime { get; set; }

        public static Endless TheBathsEndless = new()
        {
            Id = 1,
            Name = "The Baths",
            Map = TheBaths,
            Difficulty = Difficulty.Endless,
        };

        public static Endless BanquetHallEndless = new()
        {
            Id = 2,
            Name = "Banquet Hall",
            Map = BanquetHall,
            Difficulty = Difficulty.Endless,
        };

        public static Endless ThroneRoomEndless = new()
        {
            Id = 3,
            Name = "Throne Room",
            Map = ThroneRoom,
            Difficulty = Difficulty.Endless,
        };

        public static Endless HighlandsEndless = new()
        {
            Id = 4,
            Name = "Highlands",
            Map = Highlands,
            Difficulty = Difficulty.Endless,
        };

        public static Endless TheWallEndless = new()
        {
            Id = 5,
            Name = "The Wall",
            Map = TheWall,
            Difficulty = Difficulty.Endless,
        };

        public static Endless ThuricvodVillageEndless = new()
        {
            Id = 6,
            Name = "Thuricvod Village",
            Map = ThuricvodVillage,
            Difficulty = Difficulty.Endless,
        };

        public static Endless CrogonKeepEndless = new()
        {
            Id = 7,
            Name = "Crogon Keep",
            Map = CrogonKeep,
            Difficulty = Difficulty.Endless,
        };

        public static Endless SharkIslandEndless = new()
        {
            Id = 8,
            Name = "Shark Island",
            Map = SharkIsland,
            Difficulty = Difficulty.Endless,
        };

        public static Endless FrostbiteEndless = new()
        {
            Id = 9,
            Name = "Frostbite",
            Map = Frostbite,
            Difficulty = Difficulty.Endless,
        };

        public static Endless AvalancheEndless = new()
        {
            Id = 10,
            Name = "Avalanche",
            Map = Avalanche,
            Difficulty = Difficulty.Endless,
        };

        public static Endless CastleGatesEndless = new()
        {
            Id = 11,
            Name = "Castle Gates",
            Map = CastleGates,
            Difficulty = Difficulty.Endless,
        };

        public static Endless EventideFortressEndless = new()
        {
            Id = 12,
            Name = "Eventide Fortress",
            Map = EventideFortress,
            Difficulty = Difficulty.Endless,
        };

        public static Dictionary<string, Endless> EndlessBattlegrounds = new()
        {
                { TheBaths.Name, TheBathsEndless },
                { BanquetHall.Name, BanquetHallEndless },
                { ThroneRoom.Name, ThroneRoomEndless },
                { Highlands.Name, HighlandsEndless },
                { TheWall.Name, TheWallEndless },
                { ThuricvodVillage.Name, ThuricvodVillageEndless },
                { CrogonKeep.Name, CrogonKeepEndless },
                { SharkIsland.Name, SharkIslandEndless },
                { Frostbite.Name, FrostbiteEndless },
                { Avalanche.Name, AvalancheEndless },
                { CastleGates.Name, CastleGatesEndless },
                { EventideFortress.Name, EventideFortressEndless },
            };
    }
}
