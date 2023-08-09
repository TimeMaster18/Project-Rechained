using System;

namespace SingleplayerLauncher.Model
{
    class Prologue : IBattleground
    {
        /*
        { "Prologue 1 (Grand Foyer)", "NPE_1.umap" },
        { "Prologue 2 (Archmage Library)", "NPE_2.umap" },
        { "Prologue 3 (Dungeon)", "NPE_3.umap" },
        { "Prologue 4 (Canals)", "NPE_4.umap" },
        { "Prologue 5 (Riftmaker's Temple)", "NPE_5.umap" },
        //{ "SpitfireFrontEndMap", "SpitfireFrontEndMap.umap" },
        { "Survival Tutorial", "TutorialSurvival.umap" },
        { "Basics Tutorial", "NewbieTutorial.umap" }
        */
        public string Name { get; private set; }

        public Map Map { get; set; }

        public GameMode GameMode { get; set; }

        public Difficulty Difficulty { get; set; }

        public int StartingCoin { get; set; }

        public TimeSpan ParTime => throw new NotImplementedException();
    }
}
