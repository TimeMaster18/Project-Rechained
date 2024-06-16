using SingleplayerLauncher.Model;
using SingleplayerLauncher.Utils;
using System;

namespace SingleplayerLauncher.GameFiles
{
    public static class DefaultGame
    {
        // TODO: make singleton

        private static readonly GameInfo GameInfo = GameInfo.Instance;

        private const string DefaultGameIniFileName = "DefaultGame.ini";
        private const string DefaultGameIniPath = "..//SpitfireGame//Config//DefaultGame.ini";

        private const string RDisplayColorInfoSection = "SpitfireGame.RDisplayColorInfo";
        private const string RGameReplicationInfoSection = "SpitfireGame.RGameReplicationInfo";
        private const string RHUDBaseSection = "SpitfireGame.RHUDBase";

        private const string GameReplicationInfoKeyGameMode = "DefaultOfflineDifficulty";
        private const string GameReplicationInfoKeyMapLevel = "DefaultOfflineSuggestedLevel";
        private const string GameReplicationInfoKeyPlayerLevel = "DefaultOfflinePlayerLevel";
        private const string GameReplicationInfoKeyPlayerCount = "PlayerCountOverride";
        private const string GameReplicationInfoKeyPauseTimerInSeconds = "DefaultOfflinePauseTimerDurationInSeconds";
        private const string RHUDBaseKeyShowFlyoffsForTrapDamage = "ShowFlyoffsForTrapDamage";

        private const string DefaultPauseTimerInSeconds = "999999";

        public static void Apply()
        {
            _ = GameInfo.Battleground ?? throw new ArgumentNullException(nameof(Battleground), "Mandatory parameter");
            _ = GameInfo.Battleground.Difficulty ?? throw new ArgumentNullException(nameof(Battleground.Difficulty), "Mandatory parameter");
            _ = Mods.Mods.ShowTrapDamageFlyoffs ?? throw new ArgumentNullException(nameof(Mods.Mods.ShowTrapDamageFlyoffs), "Mandatory parameter");

            ConfigFile defaultGame = new ConfigFile(DefaultGameIniPath);
            IniFile data = defaultGame.data;

            data.UpdateEntry(RHUDBaseSection, RHUDBaseKeyShowFlyoffsForTrapDamage, Mods.Mods.ShowTrapDamageFlyoffs.IsEnabled.ToString());
            data.UpdateEntry(RGameReplicationInfoSection, GameReplicationInfoKeyGameMode, GameInfo.Battleground.GameMode.Id.ToString());
            data.UpdateEntry(RGameReplicationInfoSection, GameReplicationInfoKeyMapLevel, GameInfo.Battleground.Difficulty.EnemyLevel.ToString());
            data.UpdateEntry(RGameReplicationInfoSection, GameReplicationInfoKeyPlayerLevel, GameInfo.Battleground.Difficulty.AccountLevel.ToString());
            data.UpdateEntry(RGameReplicationInfoSection, GameReplicationInfoKeyPlayerCount, GameInfo.Battleground.Difficulty.PlayerCount.ToString());

            defaultGame.Write();
        }

        public static void ApplyMods(bool areEnabled)
        {
            _ = Mods.Mods.ShowTrapDamageFlyoffs ?? throw new ArgumentNullException(nameof(Mods.Mods.ShowTrapDamageFlyoffs), "Mandatory parameter");

            ConfigFile defaultGame = new ConfigFile(DefaultGameIniPath);
            IniFile data = defaultGame.data;

            data.UpdateEntry(RHUDBaseSection, RHUDBaseKeyShowFlyoffsForTrapDamage, areEnabled ? false.ToString() : Mods.Mods.ShowTrapDamageFlyoffs.IsEnabled.ToString());

            defaultGame.Write();
        }

        public static void Initialize()
        {
            FileUtils.CreateBackup(DefaultGameIniFileName, DefaultGameIniPath);

            ConfigFile defaultGame = new ConfigFile(DefaultGameIniPath);
            IniFile data = defaultGame.data;

            data.UpdateEntry(RGameReplicationInfoSection, GameReplicationInfoKeyPauseTimerInSeconds, DefaultPauseTimerInSeconds);

            defaultGame.Write();
        }
    }


}
