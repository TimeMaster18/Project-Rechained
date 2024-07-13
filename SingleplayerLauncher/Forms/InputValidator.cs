using System.Net;
using System.Text.RegularExpressions;
using SingleplayerLauncher.Model;

public static class InputValidator
{
    public static (bool isValid, string errorMessage) ValidateLoadoutName(string loadoutName)
    {
        if (loadoutName.Length < 3)
        {
            return (false, "Loadout name must be at least 3 characters long.");
        }

        if (loadoutName.Length > 32)
        {
            return (false, "Loadout name must be at most 32 characters long.");
        }

        if (!Regex.IsMatch(loadoutName, "^[a-zA-Z0-9 _-]+$"))
        {
            return (false, "Loadout name must be alphanumeric and can include spaces, hyphens, and underscores.");
        }

        return (true, string.Empty);
    }

    public static (bool isValid, string errorMessage) ValidatePlayerName(string playerName)
    {
        if (playerName.Length < 3)
        {
            return (false, "Player name must be at least 3 characters long.");
        }

        if (playerName.Length > 12)
        {
            return (false, "Player name must be at most 12 characters long.");
        }

        if (!Regex.IsMatch(playerName, "^[a-zA-Z0-9]+$"))
        {
            return (false, "Player name must be alphanumeric.");
        }

        return (true, string.Empty);
    }

    public static (bool isValid, string errorMessage) ValidateLoadoutCode(string loadoutCode)
    {
        try
        {
            Loadout.DecodeLoadout(loadoutCode);
            return (true, string.Empty);
        }
        catch
        {
            return (false, "Invalid loadout code.");
        }
    }

    public static (bool isValid, string errorMessage) ValidateIpAddress(string ipAddress)
    {
        string pattern = @"^(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\." +
                         @"(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\." +
                         @"(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\." +
                         @"(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";

        if (Regex.IsMatch(ipAddress, pattern))
        {
            return (true, string.Empty);
        }

        return (false, "Invalid IP address format.");
    }
}
