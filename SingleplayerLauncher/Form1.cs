using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using IniParser;
using IniParser.Model;
namespace SingleplayerLauncher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<string, string> maps = new Dictionary<string, string>();
        Dictionary<string, string> heroes = new Dictionary<string, string>();
        Dictionary<string, string> dyes = new Dictionary<string, string>();
        string characterDataIni = "..//SpitfireGame//Config//DefaultCharacterData.ini";
        string loggingArgument = " -log -ABSLOG=log.txt";
        private void Form1_Load(object sender, EventArgs e)
        {
            maps.Add("Academy Sewers", "PvE_Sewers.umap");
            maps.Add("Archmage Library", "PvE_AcademyLibrary.umap");
            maps.Add("Avalanche", "PvE_Avalanche.umap");
            maps.Add("Banquet Hall", "PvE_BanquetHall.umap");
            maps.Add("Castle Gates", "PvE_ASN_CastleGates.umap");
            maps.Add("Cliffside Clash", "PvE_2Lane.umap");
            maps.Add("Confluence", "PvE_AcademyCanals.umap");
            maps.Add("Crogon Keep", "PvE_CrogonKeep.umap");
            maps.Add("Docks at Eventide", "PvE_SUR_Pirates.umap");
            maps.Add("Eventide Fortress", "PvE_Surrounded.umap");
            maps.Add("Eventide Ramparts", "PvE_SUR_NorthernClans.umap");
            maps.Add("Frostbite", "PvE_FrostBite.umap");
            maps.Add("Gates of Thuricvod", "PvE_Corridors.umap");
            maps.Add("Highlands", "PvE_Highlands.umap");
            maps.Add("Maximum Security", "PvE_AcademyDungeon.umap");
            maps.Add("Midnight Market", "PvE_ASN_NightMarket.umap");
            maps.Add("Orcatraz", "PvE_Orcatraz.umap");
            maps.Add("Orcri-La", "PvE_OrcVil_Temple.umap");
            maps.Add("Restricted Section", "PvE_RestrictedSection.umap");
            maps.Add("Riftmaker's Temple (Snow Temple Graveyard Prologue)", "PvE_AcademyTemple.umap");
            maps.Add("Shark Island", "PvE_SharkIsle.umap");
            maps.Add("Stables at Eventide", "PvE_SUR_JungleTribe.umap");
            maps.Add("Storm Drain", "PvE_Flushed.umap");
            maps.Add("Temple Graveyard", "PvE_Mausoleum.umap");
            maps.Add("The Baths", "PvE_Baths.umap");
            maps.Add("The Falling Folly", "PvE_Towering.umap");
            maps.Add("The Wall", "PvE_TheWall.umap");
            maps.Add("Throne Room", "PvE_ThroneRoom.umap");
            maps.Add("Thuricvod Village", "PvE_Gap.umap");
            maps.Add("Training Grounds", "PvE_TrainingGrounds.umap");
            maps.Add("Unchained Fortress", "PvE_OneWay.umap");
            maps.Add("Water Garden", "PvE_ASN_WaterGarden.umap");
            maps.Add("Prologue 1 (Grand Foyer)", "NPE_1.umap");
            maps.Add("Prologue 2 (Archmage Library)", "NPE_2.umap");
            maps.Add("Prologue 3 (Dungeon)", "NPE_3.umap");
            maps.Add("Prologue 4 (Canals)", "NPE_4.umap");
            maps.Add("Prologue 5 (Riftmaker's Temple)", "NPE_5.umap");
            //maps.Add("SpitfireFrontEndMap", "SpitfireFrontEndMap.umap"); 
            maps.Add("Survival Tutorial", "TutorialSurvival.umap");
            maps.Add("Basics Tutorial", "NewbieTutorial.umap");

            foreach (string m in maps.Keys)
                comBoxMap.Items.Add(m);

            comBoxMap.SelectedItem = "The Baths"; // Default Selected "The Baths" because it's well optimised and Iconic Level

            heroes.Add("Blackpaw", "PawnWeapon_Blackpaw.Pawn_Blackpaw");
            heroes.Add("Bloodspike", "PawnWeapon_Bloodspike.Pawn_Bloodspike");
            heroes.Add("Brass", "PawnWeapon_Brass.Pawn_Brass");
            heroes.Add("Cygnus", "PawnWeapon_Cygnus.Pawn_Cygnus");
            heroes.Add("Deadeye", "PawnWeapon_Deadeye.Pawn_Deadeye");
            heroes.Add("Dobbin", "PawnWeapon_Dobbin.Pawn_Dobbin");
            heroes.Add("Gabriella", "PawnWeapon_Sorceress.Pawn_Sorceress");
            heroes.Add("Hogarth", "PawnWeapon_Hogarth.Pawn_Hogarth");
            heroes.Add("Ivy", "PawnWeapon_Ivy.Pawn_Ivy");
            heroes.Add("Maximilian", "PawnWeapon_Warmage.Pawn_Warmage");
            heroes.Add("Midnight", "PawnWeapon_Midnight.Pawn_Midnight");
            heroes.Add("Oziel", "PawnWeapon_Oziel.Pawn_Oziel");
            heroes.Add("Smolder", "PawnWeapon_Smolder.Pawn_Smolder");
            heroes.Add("Stinkeye", "PawnWeapon_Stinkeye.Pawn_Stinkeye");
            heroes.Add("Temper", "PawnWeapon_Temper.Pawn_Temper");
            heroes.Add("Tundra", "PawnWeapon_Tundra.Pawn_Tundra");
            heroes.Add("Yi-Lin", "PawnWeapon_hooksword.hooksword");
            heroes.Add("Zoey", "PawnWeapon_Zoey.Pawn_Zoey");

            foreach (string h in heroes.Keys)
                comBoxHero.Items.Add(h);

            comBoxHero.SelectedItem = "Maximilian"; // Default selected "Maximillian" Main Hero of the OrcsMustDie! Saga


            dyes.Add("Normal", "0");
            dyes.Add("Heroic", "1");
            dyes.Add("Legendary", "2");

            foreach (string h in dyes.Keys)
                comBoxDye.Items.Add(h);

            comBoxDye.SelectedItem = "Normal"; // Default selected Normal dye


            chkGodMode.Enabled = false;
        }
        private void btnLaunch_Click(object sender, EventArgs e)
        {           

            if (!chkCustomIni.Checked)
            {
                FileIniDataParser parser = new FileIniDataParser();

                IniData data = new IniData();
                data.Configuration.AssigmentSpacer = "";

                //Add a new section and some keys
                string RCharacterDataSection = "RCharacterData_0 RCharacterData";

                data.Sections.AddSection(RCharacterDataSection);
                data[RCharacterDataSection].AddKey("PlayerName", "Savitar");
                data[RCharacterDataSection].AddKey("GuildTag", "~(^-^)~");
                data[RCharacterDataSection].AddKey("GuildName", "");
                data[RCharacterDataSection].AddKey("PawnTemplateName", heroes[comBoxHero.Text]);
                data[RCharacterDataSection].AddKey("Team", "1");

                data[RCharacterDataSection].AddKey("HeroicDyeIdx", dyes[comBoxDye.Text]);

                if (chkGodMode.Checked)
                {
                    data[RCharacterDataSection].AddKey("GodMode", "TRUE");
                }

                parser.WriteFile(characterDataIni, data);
                File.WriteAllText(characterDataIni, File.ReadAllText(characterDataIni));

                
            }            

            Process p = new Process();
            p.StartInfo.FileName = "SpitfireGame.exe";
            p.StartInfo.Arguments = $"{maps[comBoxMap.Text]} -seekfreeloadingpcconsole -writepid -Language=INT -Region=us";

            if (chkLog.Checked)
            {
                p.StartInfo.Arguments += loggingArgument;
            }

            p.Start();
        }

        private void chkCustomIni_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCustomIni.Checked)
            {
                comBoxHero.Enabled = false;
                chkGodMode.Enabled = false;
                comBoxDye.Enabled = false;

                chkGodMode.Checked = false;
            }
            else
            {
                comBoxHero.Enabled = true;
                chkGodMode.Enabled = true;
                comBoxDye.Enabled = true;
            }
        }
    }
}
