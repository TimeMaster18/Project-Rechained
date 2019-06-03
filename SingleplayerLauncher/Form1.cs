using System;
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

        private static string characterDataIni = "..//SpitfireGame//Config//DefaultCharacterData.ini";
        private static string loggingArgument = " -log -ABSLOG=log.txt";
        private static string defaultArguments = " -seekfreeloadingpcconsole -writepid -Language=INT -Region=us";

        private void Form1_Load(object sender, EventArgs e)
        {            
            foreach (string m in Resources.maps.Keys)
                comBoxMap.Items.Add(m);

            comBoxMap.SelectedItem = "The Baths"; // Default Selected "The Baths" because it's well optimised and Iconic Level          
                        

            foreach (string h in Resources.heroes.Keys)
                comBoxHero.Items.Add(h);

            comBoxHero.SelectedItem = "Maximilian"; // Default selected "Maximillian" Main Hero of the OrcsMustDie! Saga
                                    

            foreach (string h in Resources.dyes.Keys)
                comBoxDye.Items.Add(h);

            comBoxDye.SelectedItem = "Normal"; // Default selected Normal dye

            chkCustomIni.Checked = true;
            chkGodMode.Enabled = true;
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            if (chkCustomIni.Checked)
            {
                createCustomIni(); 
            }

            Process p = new Process();
            p.StartInfo.FileName = "SpitfireGame.exe";
            p.StartInfo.Arguments = createExeArguments();

            p.Start();
        }
                
        private void createCustomIni()
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
    }
}
