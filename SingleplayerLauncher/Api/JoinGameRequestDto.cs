namespace ProjectRechained.Api
{
    public class JoinGameRequestDto
    {
        /// <summary>
        /// Language setting for the game, default is "English".
        /// </summary>
        public string GameLanguage { get; set; } = "English";

        /// <summary>
        /// Encoded loadout.
        /// Represents the selected weapons, traps, guardians, etc for the player.
        /// </summary>
        public string Loadout { get; set; }

        /// <summary>
        /// Determines whether trap damage numbers should be displayed on screen.
        /// Defaults to `false`.
        /// </summary>
        public bool ShowTrapDamage { get; set; } = false;

        /// <summary>
        /// The IP address of the host in a multiplayer session.
        /// Used to connect clients to the host. Example format: "127.0.0.1"
        /// </summary>
        public string HostIP { get; set; }


        // Add function to pretty print the object
        public override string ToString()
        {
            return $"GameLanguage: {GameLanguage}, Loadout: {Loadout}, ShowTrapDamage: {ShowTrapDamage}, HostIP: {HostIP}";
        }
    }

}
