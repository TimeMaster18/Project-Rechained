using ProjectRechained.Entities;
using SingleplayerLauncher.Model;
using SingleplayerLauncher.Utils;
using System;
using System.IO;
using System.Windows.Forms;

namespace SingleplayerLauncher.GameFiles
{
    public static class DefaultGame
    {
        // TODO: make singleton

        private const string RDisplayColorInfoSection = "SpitfireGame.RDisplayColorInfo";
        private const string RGameReplicationInfoSection = "SpitfireGame.RGameReplicationInfo";
        private const string RHUDBaseSection = "SpitfireGame.RHUDBase";
        private const string RGameStateSection = "SpitfireGame.RGameState";

        private const string GameReplicationInfoKeyGameMode = "DefaultOfflineDifficulty";
        private const string GameReplicationInfoKeyMapLevel = "DefaultOfflineSuggestedLevel";
        private const string GameReplicationInfoKeyPlayerLevel = "DefaultOfflinePlayerLevel";
        private const string GameReplicationInfoKeyPlayerCount = "PlayerCountOverride";
        private const string GameReplicationInfoKeyPauseTimerInSeconds = "DefaultOfflinePauseTimerDurationInSeconds";
        private const string RHUDBaseKeyShowFlyoffsForTrapDamage = "ShowFlyoffsForTrapDamage";
        private const string DebugBotPlayerIDs = ".DebugBotPlayerIDs";

        private const string DefaultPauseTimerInSeconds = "999999";
        private const int MAX_BOT_COUNT = 10;

        public static void ApplySurvival()
        {
            _ = GameInfo.Instance.SurvivalBattleground ?? throw new ArgumentNullException(nameof(Battleground), "Mandatory parameter");
            _ = GameInfo.Instance.SurvivalBattleground.Difficulty ?? throw new ArgumentNullException(nameof(Battleground.Difficulty), "Mandatory parameter");
            _ = Mods.Mods.ShowTrapDamageFlyoffs ?? throw new ArgumentNullException(nameof(Mods.Mods.ShowTrapDamageFlyoffs), "Mandatory parameter");
            _ = Mods.Mods.AccountLevelOverride ?? throw new ArgumentNullException(nameof(Mods.Mods.AccountLevelOverride), "Mandatory parameter");

            ConfigFile defaultGame = new(Path.Combine(Settings.Instance.RootGamePath, FileUtils.INI_CONFIGS_FOLDER_RELATIVE_PATH, FileUtils.INI_DEFAULT_GAME_FILENAME));
            IniFile data = defaultGame.data;

            data.UpdateEntry(RHUDBaseSection, RHUDBaseKeyShowFlyoffsForTrapDamage, Mods.Mods.ShowTrapDamageFlyoffs.IsEnabled.ToString());
            data.UpdateEntry(RGameReplicationInfoSection, GameReplicationInfoKeyGameMode, GameInfo.Instance.SurvivalBattleground.GameMode.Id.ToString());
            data.UpdateEntry(RGameReplicationInfoSection, GameReplicationInfoKeyMapLevel, GameInfo.Instance.SurvivalBattleground.Difficulty.EnemyLevel.ToString());
            int accountLevel = Mods.Mods.AccountLevelOverride.IsEnabled ? Mods.Mods.AccountLevelOverride.Value : GameInfo.Instance.SurvivalBattleground.Difficulty.AccountLevel;
            data.UpdateEntry(RGameReplicationInfoSection, GameReplicationInfoKeyPlayerLevel, accountLevel.ToString());
            data.UpdateEntry(RGameReplicationInfoSection, GameReplicationInfoKeyPlayerCount, GameInfo.Instance.SurvivalBattleground.Difficulty.PlayerCount.ToString());

            defaultGame.Write();
        }

        public static void ApplySurvivalSettings()
        {
            _ = Mods.Mods.ShowTrapDamageFlyoffs ?? throw new ArgumentNullException(nameof(Mods.Mods.ShowTrapDamageFlyoffs), "Mandatory parameter");

            ConfigFile defaultGame = new(Path.Combine(Settings.Instance.RootGamePath, FileUtils.INI_CONFIGS_FOLDER_RELATIVE_PATH, FileUtils.INI_DEFAULT_GAME_FILENAME));
            IniFile data = defaultGame.data;

            data.UpdateEntry(RHUDBaseSection, RHUDBaseKeyShowFlyoffsForTrapDamage, Mods.Mods.ShowTrapDamageFlyoffs.IsEnabled.ToString());

            defaultGame.Write();
        }

        public static void ApplySiegeBots(bool isSiegeAllyBots = false)
        {
            _ = GameConfig.Instance.SiegeEnemyTeamAsBots ? true : throw new ArgumentNullException(nameof(GameConfig.Instance.SiegeEnemyTeamAsBots), "Mandatory parameter");
            _ = GameConfig.Instance.SiegeBotDifficulty ?? throw new ArgumentNullException(nameof(GameConfig.Instance.SiegeBotDifficulty), "Mandatory parameter");

            ConfigFile defaultGame = new(Path.Combine(Settings.Instance.RootGamePath, FileUtils.INI_CONFIGS_FOLDER_RELATIVE_PATH, FileUtils.INI_DEFAULT_GAME_FILENAME));
            IniFile data = defaultGame.data;

            String botDifficultyName = GameConfig.Instance.SiegeBotDifficulty;
            BotDifficulty botDifficulty = BotDifficulty.BotDifficultiesByName[botDifficultyName];

            data.UpdateEntry(RGameReplicationInfoSection, GameReplicationInfoKeyGameMode, botDifficulty.BotLevel.ToString());

            data.RemoveSection(RGameStateSection);

            int botCount = 0;
            foreach (SiegeLoadout botLoadout in botDifficulty.botLoadouts)
            {
                data.UpdateEntry(RGameStateSection, DebugBotPlayerIDs, botLoadout.PlayerName, botCount);
                botCount++;
            }

            if (isSiegeAllyBots)
            {
                foreach (SiegeLoadout allyBotLoadout in GameInfo.Instance.AllyBotsLoadouts)
                {
                    data.UpdateEntry(RGameStateSection, DebugBotPlayerIDs, allyBotLoadout.PlayerName, botCount);
                    botCount++;
                }
            }

            defaultGame.Write();
        }

        private static void ClearBotsConfiguration(IniFile data)
        {
            for (int i = 0; i < MAX_BOT_COUNT; i++)
            {
                data.UpdateEntry(RGameStateSection, DebugBotPlayerIDs, "", i);
            }
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
