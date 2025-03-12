using SingleplayerLauncher.Api.Controllers;
using System.Collections.Generic;

namespace ProjectRechained.Api
{

    public class LaunchGameRequestDto
    {
        /// <summary>
        /// Language setting for the game, default is "English".
        /// </summary>
        public string GameLanguage { get; set; } = "English";

        /// <summary>
        /// Host or local player's name.
        /// </summary>
        public string PlayerName { get; set; }

        /// <summary>
        /// "Survival", "Endless", etc.
        /// </summary>
        public string GameMode { get; set; }

        /// <summary>
        /// For Survival, this would be "APPRENTICE", "WAR_MAGE", "MASTER", or "RIFT_LORD".
        /// For Endless, can be ignored.
        /// </summary>
        public string Difficulty { get; set; }

        /// <summary>
        /// Additional difficulty settings, if applicable.
        /// This may include modifiers or custom challenge settings.
        /// </summary>
        public string ExtraDifficulty { get; set; }

        /// <summary>
        /// Name of the map, e.g. "Cliffside Clash", "The Baths", etc.
        /// </summary>
        public string MapName { get; set; }

        /// <summary>
        /// Encoded loadouts for each player, or at least the host/local player.
        /// Represents selected weapons, traps, guardians, etc.
        /// </summary>
        public List<string> Loadouts { get; set; }

        /// <summary>
        /// Names of mods to enable. They must match the internal
        /// `Mods.ModList` items by name.
        /// e.g. [ "No Trap Cap", "God Mode", "Show Trap Damage Flyoffs" ]
        /// </summary>
        public List<string> ActiveMods { get; set; }

        /// <summary>
        /// Whether to display trap damage numbers on screen.
        /// </summary>
        public bool ShowTrapDamage { get; set; } = false;

        /// <summary>
        /// The amount of starting in-game currency for the player.
        /// Defaults to `GameController.DEFAULT_INVALID_VALUE` if not set.
        /// </summary>
        public int StartingCoin { get; set; } = GameController.DEFAULT_INVALID_VALUE;

        /// <summary>
        /// Overrides the default trap tier level if specified.
        /// Defaults to `GameController.DEFAULT_INVALID_VALUE` if not set.
        /// </summary>
        public int OverrideTrapTier { get; set; } = GameController.DEFAULT_INVALID_VALUE;

        /// <summary>
        /// Overrides the player's account level if specified.
        /// Defaults to `GameController.DEFAULT_INVALID_VALUE` if not set.
        /// </summary>
        public int OverrideAccountLevel { get; set; } = GameController.DEFAULT_INVALID_VALUE;


        // Add function to pretty print the object
        public override string ToString()
        {
            return $"GameLanguage: {GameLanguage}, PlayerName: {PlayerName}, GameMode: {GameMode}, Difficulty: {Difficulty}, ExtraDifficulty: {ExtraDifficulty}, MapName: {MapName}, Loadouts: {string.Join(", ", Loadouts)}, ActiveMods: {string.Join(", ", ActiveMods)}, ShowTrapDamage: {ShowTrapDamage}, StartingCoin: {StartingCoin}, OverrideTrapTier: {OverrideTrapTier}, OverrideAccountLevel: {OverrideAccountLevel}";
        }

    }

}
