using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SingleplayerLauncher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<string, string> maps = new Dictionary<string, string>();
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
                comboBox1.Items.Add(m);
            comboBox1.SelectedIndex = 0;
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo.FileName = "SpitfireGame.exe";
            p.StartInfo.Arguments = $"{maps[comboBox1.Text]}?Team=1&AutoTests=1?AutoClientPerfTest=1 -seekfreeloadingpcconsole -writepid -Language=INT -Region=us";
            p.Start();
        }
    }
}
