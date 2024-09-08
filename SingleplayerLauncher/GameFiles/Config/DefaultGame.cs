using SingleplayerLauncher.Model;
using SingleplayerLauncher.Utils;
using System;
using System.IO;

namespace SingleplayerLauncher.GameFiles
{
    public static class DefaultGame
    {
        // TODO: make singleton

        private static readonly GameInfo GameInfo = GameInfo.Instance;

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
            _ = GameInfo.SurvivalBattleground ?? throw new ArgumentNullException(nameof(Battleground), "Mandatory parameter");
            _ = GameInfo.SurvivalBattleground.Difficulty ?? throw new ArgumentNullException(nameof(Battleground.Difficulty), "Mandatory parameter");
            _ = Mods.Mods.ShowTrapDamageFlyoffs ?? throw new ArgumentNullException(nameof(Mods.Mods.ShowTrapDamageFlyoffs), "Mandatory parameter");
            _ = Mods.Mods.AccountLevelOverride ?? throw new ArgumentNullException(nameof(Mods.Mods.AccountLevelOverride), "Mandatory parameter");

            ConfigFile defaultGame = new(Path.Combine(Settings.Instance.RootGamePath, FileUtils.INI_CONFIGS_FOLDER_RELATIVE_PATH, FileUtils.INI_DEFAULT_GAME_FILENAME));
            IniFile data = defaultGame.data;

            data.UpdateEntry(RHUDBaseSection, RHUDBaseKeyShowFlyoffsForTrapDamage, Mods.Mods.ShowTrapDamageFlyoffs.IsEnabled.ToString());
            data.UpdateEntry(RGameReplicationInfoSection, GameReplicationInfoKeyGameMode, GameInfo.SurvivalBattleground.GameMode.Id.ToString());
            data.UpdateEntry(RGameReplicationInfoSection, GameReplicationInfoKeyMapLevel, GameInfo.SurvivalBattleground.Difficulty.EnemyLevel.ToString());
            int accountLevel = Mods.Mods.AccountLevelOverride.IsEnabled ? Mods.Mods.AccountLevelOverride.Value : GameInfo.SurvivalBattleground.Difficulty.AccountLevel;
            data.UpdateEntry(RGameReplicationInfoSection, GameReplicationInfoKeyPlayerLevel, accountLevel.ToString());
            data.UpdateEntry(RGameReplicationInfoSection, GameReplicationInfoKeyPlayerCount, GameInfo.SurvivalBattleground.Difficulty.PlayerCount.ToString());

            defaultGame.Write();
        }

        public static void ApplySettings()
        {
            _ = Mods.Mods.ShowTrapDamageFlyoffs ?? throw new ArgumentNullException(nameof(Mods.Mods.ShowTrapDamageFlyoffs), "Mandatory parameter");

            ConfigFile defaultGame = new(Path.Combine(Settings.Instance.RootGamePath, FileUtils.INI_CONFIGS_FOLDER_RELATIVE_PATH, FileUtils.INI_DEFAULT_GAME_FILENAME));
            IniFile data = defaultGame.data;

            data.UpdateEntry(RHUDBaseSection, RHUDBaseKeyShowFlyoffsForTrapDamage, Mods.Mods.ShowTrapDamageFlyoffs.IsEnabled.ToString());

            defaultGame.Write();
        }

        public static void Initialize()
        {
            ConfigFile defaultGame = new(Path.Combine(Settings.Instance.RootGamePath, FileUtils.INI_CONFIGS_FOLDER_RELATIVE_PATH, FileUtils.INI_DEFAULT_GAME_FILENAME));
            IniFile data = defaultGame.data;

            data.UpdateEntry(RGameReplicationInfoSection, GameReplicationInfoKeyPauseTimerInSeconds, DefaultPauseTimerInSeconds);

            defaultGame.Write();
        }
    }


}
