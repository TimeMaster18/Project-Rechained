![image](https://github.com/user-attachments/assets/813d7459-3b98-41a0-9ed7-10ab71884319)# Project Rechained

The aim of this project is to provide the game of **Orcs Must Die! Unchained** a way to be played again. This is achieved by applying modifications to the game.

**This mod will modify your game files**. But it will also create backups for the original files automatically.


If you want to give feedback, contribute, participate in testing or just hang around and talk about OMDU, **feel free to join our Discord server** clicking the label below:

[![OMD Modding Discord Server](https://img.shields.io/discord/583432386960818227?color=%237289da&logo=discord&logoColor=white&label=Join%20the%20Discord%20Server)](https://discord.gg/xkZskPXtwm)

### How to install:

#### Prerequisites:

1. **Download and Install .NET SDK**:
    - Go to the [.NET download page](https://dotnet.microsoft.com/download/dotnet).
    - Download and install the latest **.NET SDK 8** suitable for your operating system. [Windows x64 Direct Link](https://download.visualstudio.microsoft.com/download/pr/f5f1c28d-7bc9-431e-98da-3e2c1bbd1228/864e152e374b5c9ca6d58ee953c5a6ed/dotnet-sdk-8.0.401-win-x64.exe)

#### How to install for Survival:

1. Download Game from: [Steam](https://intradeus.github.io/http-protocol-redirector?r=steam://rungameid/427270) (If link doesn't work, ask for help at the Discord server)
2. Download the Project Rechained Launcher latest release from: [Latest release .zip](https://github.com/TimeMaster18/Project-Rechained/releases/latest/download/Project_Rechained_Launcher.zip)
3. Extract the downloaded Project_Rechained_Launcher.zip contents inside the root folder of your game installation. (Same folder that contains "Binaries", "Engine", etc)
4. Run the "ProjectRechainedLauncher.exe" inside the ProjectRechained folder.
5. (Optional) Close the Launcher and launch from Steam

Note: Once installed, it can be launched from Steam by Pressing play on the Orcs Must Die! Unchained Game in your library.

#### How to install for Siege:
[Siege installation instructions](Siege_installation_instructions.md)

### Features:
- Launch the game from **Steam**
- **Peer to peer multiplayer**
  - Survival **up to 5 players**, **Survival** or **Endless** modes
  - Siege 5 vs 5 players
- Fully customisable loadouts, including Trap Parts
  - **Save your loadouts and share them with other players**
- In Survival, Hero and **Trap Tiers** are matched with enemy/map level
- **New Survival extra difficulties** for every map
- **New Survival Mods**:
  - Remove Trap Cap
  - Invincible barricades
  - Custom intial Coin
  - God Mode
  - Show Trap Damage
  - Sell Traps during waves
  - and more!
- Settings and mods are saved between executions

### Coming Next
- Campaign Mode
- Loadout randomizer
- Fix Coop issues

### Known Problems
- UI of the launcher is simple

#### Survival
- Host player has no enemy / guardian / hero voices
- (Coop) Client sometimes needs to rejoin to get all skills 
- (Coop) Client traits "stack up" when reconnecting
- Host player hero mobility skills (Gabriella teleport, Mdnight dash, etc) partially work
- (Coop) Some mods create issues for Client
- (Visual only) Host player wave count at top of screen is wrong (press Tab to see actual wave limit)
- (Visual only) Host player Unchained meter (right side of screen) stuck after first activation 
  - The **indicator over the hero icon at the bottom left of the screen works correctly**
- (Visual only) Crogon Keep textures can be black
- (Visual only) Host player own Midnight "invisibility" not showing properly

#### Siege
- Host player doesn't have all sounds (mostly hero and minion related)
- Host Hero Upgrades popup doesn't close automatically (requires pressing U) after picking upgrade
- (Visual only) Host player own Midnight "invisibility" not showing properly

## Acknowledgements

This project would not have been possible without the help and support of several people and projects:

A big thank you to all the people who contributed to this project:

- **DaTeddy** - Contributed with reverse-engineering, testing, documenting and much more.

This project makes use of the following open-source projects:

- **[Unreal Package Decompressor by gildor](https://github.com/gildor2/UEViewer)** - Used to decompress upk files.
- **[Newtonsoft.Json](https://github.com/JamesNK/Newtonsoft.Json)** - Used to handle the settings and save state.
- **[OMDU Hook by trumank](https://github.com/trumank/omdu-hook)** - Unlocks the possibility of multiplayer and further loadout customisation.

## Contact

If you have any questions, suggestions, or feedback, feel free to reach out:

- **Project Maintainer:** [TimeMaster](https://github.com/TimeMaster18) - Discord: timemaster
- **Discord Server:** [OMD Modding Server](https://discord.gg/xkZskPXtwm)
