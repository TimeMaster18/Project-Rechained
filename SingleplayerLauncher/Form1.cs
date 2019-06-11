using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using IniParser;
using IniParser.Model;

namespace SingleplayerLauncher
{
    public partial class Form1 : Form
    {
        public static Max Max;
        public Form1()
        {
            InitializeComponent();
        }

        private static string characterDataIni = "..//SpitfireGame//Config//DefaultCharacterData.ini";
        private static string defaultGameIni = "..//SpitfireGame//Config//DefaultGame.ini";
        private static string loggingArgument = " -log -ABSLOG=log.txt";
        private static string defaultArguments = " -seekfreeloadingpcconsole -writepid -Language=INT -Region=us";

        private void Form1_Load(object sender, EventArgs e)
        {            
            foreach (string m in Resources.maps.Keys)
                comBoxMap.Items.Add(m); 

            foreach (string h in Resources.heroes.Keys)
                comBoxHero.Items.Add(h);

            foreach (string d in Resources.dyes.Keys)
                comBoxDye.Items.Add(d);

            foreach (string gm in Resources.gameModes.Keys)
                comBoxGameMode.Items.Add(gm);
            foreach (string s in Resources.skins["Maximilian"].Keys)
                comBoxSkin.Items.Add(s);

            comBoxHero.SelectedItem = "Maximilian"; // Default selected "Maximillian" Main Hero of the OrcsMustDie! Saga
            comBoxDye.SelectedItem = "Normal"; // Default selected Normal dye

            comBoxMap.SelectedItem = "The Baths"; // Default Selected "The Baths" because it's well optimised and Iconic Level 
            comBoxGameMode.SelectedItem = "Survival"; // Default selected Game Mode "Survival"
                       
            chkCustomIni.Checked = true;
            chkGodMode.Enabled = true;
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            if (chkCustomIni.Checked)
            {
                createCharacterDataIni();
                modifyDefaultGameIni();
            }
            if (Max == null && !comBoxSkin.SelectedItem.ToString().Equals(""))
                Max = new Max();
            if (Max != null)
            {
                if (!comBoxSkin.SelectedItem.ToString().Equals(""))
                    Max.SetSkin(Resources.skins["Maximilian"][comBoxSkin.SelectedItem.ToString()]);

                Max.SaveHero();
            }
            Process p = new Process();
            p.StartInfo.FileName = "SpitfireGame.exe";
            p.StartInfo.Arguments = createExeArguments();

            p.Start();
        }
                
        private void createCharacterDataIni()
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
            data[RCharacterDataSection].AddKey("PawnTemplateName", Resources.heroes[comBoxHero.Text]);
            data[RCharacterDataSection].AddKey("Team", "1");

            data[RCharacterDataSection].AddKey("HeroicDyeIdx", Resources.dyes[comBoxDye.Text]);

            if (chkGodMode.Checked)
            {
                data[RCharacterDataSection].AddKey("GodMode", "TRUE");
            }

            parser.WriteFile(characterDataIni, data);
            File.WriteAllText(characterDataIni, File.ReadAllText(characterDataIni));
        }

        private void modifyDefaultGameIni()
        {
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile(defaultGameIni);

            parser.Parser.Configuration.AssigmentSpacer = "";
            data.Configuration.AssigmentSpacer = "";

            string RGameReplicationInfoSection = "SpitfireGame.RGameReplicationInfo";

            string selectedGameMode = comBoxGameMode.SelectedItem.ToString();
            string selectedExtraDifficulty = comBoxExtraDifficulty.SelectedItem.ToString();

            data[RGameReplicationInfoSection]["DefaultOfflineDifficulty"] = Resources.gameModes[selectedGameMode];
            data[RGameReplicationInfoSection]["PlayerCountOverride"] = "1";

            if (selectedGameMode.Equals("Survival"))
            {
                string selectedDifficulty = comBoxDifficulty.SelectedItem.ToString();

                if (selectedExtraDifficulty.Equals("No"))
                {
                    data[RGameReplicationInfoSection]["DefaultOfflineSuggestedLevel"] = Resources.survivalDifficulties[selectedDifficulty];
                    data[RGameReplicationInfoSection]["DefaultOfflinePlayerLevel"] = Resources.survivalDifficulties[selectedDifficulty];
                }
                else
                {               
                    data[RGameReplicationInfoSection]["DefaultOfflinePlayerLevel"] = Resources.survivalExtraDifficulties[selectedDifficulty][selectedExtraDifficulty][0].ToString();
                    data[RGameReplicationInfoSection]["DefaultOfflineSuggestedLevel"] = Resources.survivalExtraDifficulties[selectedDifficulty][selectedExtraDifficulty][1].ToString();
                    data[RGameReplicationInfoSection]["PlayerCountOverride"] = "3";
                }
            }
            else
            {

                data[RGameReplicationInfoSection]["DefaultOfflinePlayerLevel"] = "1";

                if (selectedExtraDifficulty.Equals("No"))
                {
                    data[RGameReplicationInfoSection]["DefaultOfflineSuggestedLevel"] = "1";
                }
                else
                {
                    data[RGameReplicationInfoSection]["DefaultOfflineSuggestedLevel"] = Resources.endlessDifficulties[selectedExtraDifficulty];
                    data[RGameReplicationInfoSection]["PlayerCountOverride"] = "3";
                }
            }

            parser.WriteFile(defaultGameIni, data);      
        }

        private string createExeArguments()
        {
            string arguments = "";

            string map = Resources.maps[comBoxMap.Text];
            string defaultArgs = defaultArguments;

            arguments += map;
            arguments += defaultArgs;

            if (chkLog.Checked)
                arguments += loggingArgument;

            return arguments;
        }

        private void chkCustomIni_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkCustomIni.Checked)
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

        private void btnLoadoutEditor_Click(object sender, EventArgs e)
        {
            LoadoutEditor ld = new LoadoutEditor();
            ld.Show();
        }

        private void comBoxGameMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            comBoxDifficulty.Items.Clear();

            comBoxExtraDifficulty.Items.Clear();
            comBoxExtraDifficulty.Items.Add("No");
            comBoxExtraDifficulty.SelectedItem = "No";

            switch (comBoxGameMode.SelectedItem)
            {
                case "Endless":
                    comBoxDifficulty.Enabled = false;

                    foreach (string ed in Resources.endlessDifficulties.Keys)
                        comBoxExtraDifficulty.Items.Add(ed);

                    break;

                case "Survival":
                    comBoxDifficulty.Enabled = true;

                    string selectedMap = comBoxMap.SelectedItem.ToString();

                    foreach (string md in Resources.mapSurvivalDifficulties[selectedMap])
                        comBoxDifficulty.Items.Add(md);

                    comBoxDifficulty.SelectedIndex = 0;

                    break;

                default:
                    break;                
            }

        }

        private void comBoxMap_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMap = comBoxMap.SelectedItem.ToString();
            if (selectedMap.Contains("Tutorial" ) || selectedMap.Contains("Prologue"))
            {
                comBoxGameMode.Enabled = false;
                comBoxDifficulty.Enabled = false;
                comBoxExtraDifficulty.Enabled = false;
            }
            else
            {
                comBoxGameMode.Enabled = true;
                comBoxDifficulty.Enabled = true;
                comBoxExtraDifficulty.Enabled = true;

                // Manual refresh of possible difficulties
                var modeSelected = comBoxGameMode.SelectedItem;
                comBoxGameMode.SelectedIndex = -1;
                comBoxGameMode.SelectedItem = modeSelected;
            }            
        }

        
        private void comBoxDifficulty_SelectedIndexChanged(object sender, EventArgs e)
        {
            comBoxExtraDifficulty.Items.Clear();
            comBoxExtraDifficulty.Items.Add("No");
            comBoxExtraDifficulty.SelectedItem = "No";

            string selectedDifficulty = comBoxDifficulty.SelectedItem.ToString();

            foreach (string ef in Resources.survivalExtraDifficulties[selectedDifficulty].Keys)
            {
                comBoxExtraDifficulty.Items.Add(ef);
            }
        }

        private void comBoxHero_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comBoxHero.SelectedItem.Equals("Maximilian"))
            {
                comBoxSkin.Enabled = true;
            }
            else
            {
                comBoxSkin.Enabled = false;
                comBoxSkin.SelectedIndex = -1;
            }
        }
    }
}
