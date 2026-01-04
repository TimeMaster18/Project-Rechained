## FAQ / Troubleshooting

### Launcher Issues

#### Project Rechained launcher doesn’t open

* The first step of the installation was likely skipped or failed.
* Reinstall **.NET** strictly following the installation instructions.

---

### Antivirus / Security Warnings

#### Project Rechained is detected as a virus or blocked by antivirus

* There is nothing we can do about this.
* Getting a Microsoft whitelisting license is extremely expensive.
* Many users run the project without any issues.
* If you don’t trust it, the project is **open source** — review the code and build it yourself.

---

### Missing DLL Errors

#### Missing `MSVCP100.dll` or similar errors when launching or joining a match

* You are missing required **C++ Redistributables**.
* Install them using the all-in-one package:
  [https://www.techpowerup.com/download/visual-c-redistributable-runtime-package-all-in-one/](https://www.techpowerup.com/download/visual-c-redistributable-runtime-package-all-in-one/)

---

### Loadout Problems

#### Loadout is empty or not applied

**Host or Solo Player**

* Reinstall the mod.
* If the issue persists:

  * Verify that `ProjectRechained/Hooks/` contains `.dll` files.
  * If the folder is empty, your antivirus is blocking or deleting them.
* If the `.dll` files exist but the issue remains:

  * Your antivirus may still be removing files from the game’s `Win64/Binaries` folder.

**Client**

* Close the game.
* Rejoin the match.

---

### Connectivity Issues

#### Can’t connect to host / game stuck in loading loop

* This is almost always a **network or firewall issue**.
* Ensure firewall rules allow incoming connections for:

  * The game
  * Radmin VPN
* If using Radmin:

  * Make sure both players can ping each other
    (`Right-click → Ping` in Radmin).
* If problems persist:

  * Change who is hosting.

---

### Website Launch Issues

#### Game doesn’t open when launching from the Project Rechained website

* Make sure the **Project Rechained Desktop App** launcher is still running.
* Ensure a **valid loadout** is selected before launching.

---

### Progression & Unlocks

#### Is there account progression or unlocks?

* Not currently.
* All maps and difficulties automatically balance:

  * Traps
  * Account level
* This applies unless override-level mods are used.

---

### Co-op Setup (Radmin VPN)

#### How to play co-op with Radmin

Both players must:

1. Download Radmin VPN:
   [https://www.radmin-vpn.com/](https://www.radmin-vpn.com/)
2. Restart the PC.
3. Open Radmin:

   * Press the red **Power** button to enable it.
   * Go to **Network → Connect to network → Gaming Network**
   * Search for and join: **Orcs Must Die! Unchained**

---

### LAN / Alternative Networking

#### Can co-op be played in LAN or without Radmin?

* Yes.
* This requires advanced networking knowledge.
* No support or troubleshooting will be provided.
* Radmin simply simulates LAN — real LAN or port forwarding also works.

---

### Achievements

#### Can I still earn achievements?

* No.

---

### Future Features

#### Will progression or other modes be added?

* Maybe.
* Progression is feasible.
* Other modes would require significant development time.

---

### (Siege) The map specifieed "..." could not be found

* Make sure that:
  * Launching the game from the Siege installation ProjectRechained Launcher
  * Have installed the ProjectRechained folder from scratch / fresh download
    * Copying the ProjectRechained folder from a previous installation (or from a friend) won't work

---

### Known Issues (Won’t Be Fixed)

* No sound / missing sounds
* Zoey’s pet missing (Host or Solo)
* Weird animations or mobility skills (Host or Solo)
* Unchained meter not filling correctly (visual issue only)

These issues are known.
They are unlikely to be fixed, and the cause is not clearly understood.

## Contact

If you have any further questions, suggestions, or feedback, feel free to reach out:

- **Project Maintainer:** [TimeMaster](https://github.com/TimeMaster18) - Discord: timemaster
- **Discord Server:** [OMD Modding Server](https://discord.gg/xkZskPXtwm)
