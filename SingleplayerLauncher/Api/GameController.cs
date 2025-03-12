using Microsoft.AspNetCore.Mvc;
using SingleplayerLauncher.Model;
using System.Linq;
using System.Collections.Generic;
using SingleplayerLauncher.Names;
using ProjectRechained.Api;
using System.Windows.Forms;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;

namespace SingleplayerLauncher.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GameController : ControllerBase
    {
        public static int DEFAULT_INVALID_VALUE = int.MinValue;
        public static bool isGameRunning = false;

        [HttpGet("status")]
        public IActionResult GetStatus()
        {
            return Ok(new { message = "API is running inside Windows Forms!" });
        }

        [HttpPost("launch")]
        public IActionResult LaunchGame([FromBody] LaunchGameRequestDto request)
        {
            if (isGameRunning)
            {
                return BadRequest(new { message = "Game is already running" });
            }

            // Map / Battleground / Difficulty
            IBattleground chosenBattleground = null;
            if (Model.GameMode.GameModes.TryGetValue(request.GameMode, out _))
            {
                GameInfo.Instance.SurvivalBattleground.GameMode = Model.GameMode.GameModes[request.GameMode];
                Model.Difficulty extraDifficultySelected = null;

                // Determine which battleground object to use based on GameMode + Difficulty + MapName
                if (request.GameMode == Names.GameMode.ENDLESS)
                {
                    if (!Model.Endless.EndlessBattlegrounds.TryGetValue(request.MapName, out Endless endlessMap))
                    {
                        return BadRequest(new { message = $"Map '{request.MapName}' not found in Endless maps." });
                    }

                    if (request.ExtraDifficulty != null && !Model.Difficulty.EndlessExtraDifficulties.TryGetValue(request.ExtraDifficulty, out extraDifficultySelected))
                    {
                        return BadRequest(new { message = $"Difficulty '{request.ExtraDifficulty}' is not valid for endless." });
                    }

                    if (extraDifficultySelected != null)
                    {
                        endlessMap.Difficulty = extraDifficultySelected;
                    }

                    chosenBattleground = endlessMap;
                }
                else if (request.GameMode == Names.GameMode.SURVIVAL)
                {
                    if (!Model.Survival.SurvivalBattlegroundsByDifficulty.TryGetValue(request.Difficulty, out var battlegroundsOfDifficultySelectedByName))
                    {
                        return BadRequest(new { message = $"Difficulty '{request.Difficulty}' is not valid for survival." });
                    }

                    if (!battlegroundsOfDifficultySelectedByName.TryGetValue(request.MapName, out Survival survivalMap))
                    {
                        return BadRequest(new { message = $"Map '{request.MapName}' not found under '{request.Difficulty}'." });
                    }

                    if (request.ExtraDifficulty != null)
                    {
                        if (!Model.Difficulty.ExtraDifficultiesByDifficulty.TryGetValue(request.Difficulty, out var extraDifficulties) || extraDifficulties == null)
                        {
                            return BadRequest(new { message = $"Difficulty '{request.Difficulty}' does not support extra difficulties." });
                        }

                        if (!extraDifficulties.TryGetValue(request.ExtraDifficulty, out extraDifficultySelected))
                        {
                            return BadRequest(new { message = $"Extra difficulty '{request.ExtraDifficulty}' is not valid for survival." });
                        }

                        survivalMap.Difficulty = extraDifficultySelected;
                    }

                    chosenBattleground = survivalMap;
                }
                else
                {
                    return BadRequest(new { message = "Invalid difficulty" });
                }
                GameInfo.Instance.SurvivalBattleground = chosenBattleground;
                GameInfo.Instance.SurvivalBattleground.Difficulty = chosenBattleground.Difficulty;
            }
            else
            {
                return BadRequest(new { message = "Invalid game mode" });
            }


            // IMPORTANT: Apply Mods before loadouts
            // First, disable all mods:
            foreach (var mod in Mods.Mods.ModList)
            {
                mod.IsEnabled = false;
            }

            // Then enable only those that are in the request
            if (request.ActiveMods != null && request.ActiveMods.Any())
            {
                GameConfig.Instance.ModsEnabled = true;

                foreach (var modName in request.ActiveMods)
                {
                    Mods.Mod matchedMod = Mods.Mods.ModsByName.GetValueOrDefault(modName, null);
                    if (matchedMod != null)
                    {
                        matchedMod.IsEnabled = true;
                    }
                    // else ignore unknown mod name
                }
            }

            if (request.OverrideAccountLevel != DEFAULT_INVALID_VALUE)
            {
                Mods.Mods.AccountLevelOverride.Value = request.OverrideAccountLevel;
                Mods.Mods.AccountLevelOverride.IsEnabled = true;
            }

            if (request.OverrideTrapTier != DEFAULT_INVALID_VALUE)
            {
                Mods.Mods.TrapTierOverride.Value = request.OverrideTrapTier;
                Mods.Mods.TrapTierOverride.IsEnabled = true;
            }

            if (request.StartingCoin != DEFAULT_INVALID_VALUE)
            {
                Mods.Mods.StartingCoinOverride.Value = request.StartingCoin;
                Mods.Mods.StartingCoinOverride.IsEnabled = true;
            }

            // Loadouts
            var invalidLoadouts = new List<string>();
            var decodedLoadouts = new List<SurvivalLoadout>();

            if (request.Loadouts == null || request.Loadouts.Count == 0)
            {
                return BadRequest(new { message = "Loadouts are required" });
            }

            foreach (var loadoutCode in request.Loadouts)
            {
                if (!string.IsNullOrWhiteSpace(loadoutCode))
                {
                    try
                    {
                        SurvivalLoadout tempLoadout = new();
                        tempLoadout.Decode(loadoutCode);
                        decodedLoadouts.Add(tempLoadout);
                        GameFiles.CharacterData.ApplyLoadout(tempLoadout);
                    }
                    catch
                    {
                        invalidLoadouts.Add(loadoutCode);
                    }
                }
            }

            if (invalidLoadouts.Count > 0)
            {
                return BadRequest(new
                {
                    message = "Some loadouts are invalid",
                    invalidLoadouts
                });
            }

            if (decodedLoadouts.Any())
            {
                for (int i = 0; i < decodedLoadouts.Count; i++)
                {
                    if (decodedLoadouts[i].PlayerName == request.PlayerName)
                    {
                        GameInfo.SurvivalLoadout = decodedLoadouts[i];
                        break;
                    }
                }

                if (GameInfo.SurvivalLoadout == null || GameInfo.SurvivalLoadout.PlayerName != request.PlayerName)
                {
                    return BadRequest(new { message = "Host PlayerName does not match any loadout" });
                }
            }

            // Game Config
            GameInfo.Instance.PlayerCount = decodedLoadouts.Count;

            if (!Language.survivalLanguageMap.ContainsKey(request.GameLanguage))
            {
                request.GameLanguage = "English";
            }
            Settings.Instance.Language = request.GameLanguage;

            GameConfig.Instance.ShowTrapDamage = request.ShowTrapDamage;

            // Apply changes and launch the game
            GameLauncher.ApplyChanges(
                isHost: true,
                parTimeSeconds: (int)chosenBattleground.ParTime.TotalSeconds);

            // Run the game in a separate thread
            Task.Run(() =>
            {
                isGameRunning = true;
                GameLauncher.StartGame(
                    playerName: request.PlayerName,
                    isHost: true,
                    mapCode: chosenBattleground.Map.UmapCode,
                    playerCount: GameInfo.Instance.PlayerCount
                );
                isGameRunning = false; // Mark game as finished
            });

            return Ok(new { message = $"Game launch initiated for player '{request.PlayerName}' on map '{request.MapName}' with options: {request}" });
        }

        [HttpPost("join")]
        public IActionResult JoinGame([FromBody] JoinGameRequestDto request)
        {
            if (isGameRunning)
            {
                return BadRequest(new { message = "Game is already running" });
            }

            var (isIPValid, errorMessageIp) = InputValidator.ValidateIpAddress(request.HostIP);

            if (!isIPValid)
            {
                return BadRequest(new { message = errorMessageIp });
            }

            // Loadouts
            if (string.IsNullOrWhiteSpace(request.Loadout))
            {
                return BadRequest(new { message = "Loadout is required" });
            }

            try
            {
                SurvivalLoadout tempLoadout = new();
                tempLoadout.Decode(request.Loadout);
                string playerName = tempLoadout.PlayerName;
                tempLoadout.PlayerName = "0";
                GameFiles.CharacterData.ApplyLoadout(tempLoadout);
                tempLoadout.PlayerName = playerName;
                GameInfo.SurvivalLoadout = tempLoadout;
            }
            catch
            {
                return BadRequest(new { message = "Loadout is invalid" });
            }

            // Game Config
            if (!Language.survivalLanguageMap.ContainsKey(request.GameLanguage))
            {
                request.GameLanguage = "English";
            }
            Settings.Instance.Language = request.GameLanguage;

            GameConfig.Instance.ShowTrapDamage = request.ShowTrapDamage;

            // Apply changes and launch the game
            GameLauncher.ApplyChanges(isHost: false);

            // Run the game in a separate thread
            Task.Run(() =>
            {
                isGameRunning = true;
                GameLauncher.StartGame(
                    playerName: GameInfo.SurvivalLoadout.PlayerName,
                    isHost: false,
                    hostIP: request.HostIP
                );
                isGameRunning = false;
            });

            return Ok(new { message = $"Game join initiated with options: {request}" });
        }
    }
}
