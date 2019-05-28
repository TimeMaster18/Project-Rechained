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
            maps.Add("2Lane", "PvE_2Lane.umap");
            maps.Add("AcademyCanals", "PvE_AcademyCanals.umap");
            maps.Add("AcademyDungeon", "PvE_AcademyDungeon.umap");
            maps.Add("AcademyLibrary", "PvE_AcademyLibrary.umap");
            maps.Add("AcademyTemple", "PvE_AcademyTemple.umap");
            maps.Add("ASN_CastleGates", "PvE_ASN_CastleGates.umap");
            maps.Add("ASN_NightMarket", "PvE_ASN_NightMarket.umap");
            maps.Add("ASN_WaterGarden", "PvE_ASN_WaterGarden.umap");
            maps.Add("Avalanche", "PvE_Avalanche.umap");
            maps.Add("BanquetHall", "PvE_BanquetHall.umap");
            maps.Add("Baths", "PvE_Baths.umap");
            maps.Add("Corridors", "PvE_Corridors.umap");
            maps.Add("CrogonKeep", "PvE_CrogonKeep.umap");
            maps.Add("Flushed", "PvE_Flushed.umap");
            maps.Add("FrostBite", "PvE_FrostBite.umap");
            maps.Add("Gap", "PvE_Gap.umap");
            maps.Add("Highlands", "PvE_Highlands.umap");
            maps.Add("Mausoleum", "PvE_Mausoleum.umap");
            maps.Add("OneWay", "PvE_OneWay.umap");
            maps.Add("Orcatraz", "PvE_Orcatraz.umap");
            maps.Add("OrcVil_Temple", "PvE_OrcVil_Temple.umap");
            maps.Add("RestrictedSection", "PvE_RestrictedSection.umap");
            maps.Add("Sewers", "PvE_Sewers.umap");
            maps.Add("SharkIsle", "PvE_SharkIsle.umap");
            maps.Add("SUR_JungleTribe", "PvE_SUR_JungleTribe.umap");
            maps.Add("SUR_NorthernClans", "PvE_SUR_NorthernClans.umap");
            maps.Add("SUR_Pirates", "PvE_SUR_Pirates.umap");
            maps.Add("Surrounded", "PvE_Surrounded.umap");
            maps.Add("TheWall", "PvE_TheWall.umap");
            maps.Add("ThroneRoom", "PvE_ThroneRoom.umap");
            maps.Add("Towering", "PvE_Towering.umap");
            maps.Add("TrainingGrounds", "PvE_TrainingGrounds.umap");
            maps.Add("SpitfireFrontEndMap", "SpitfireFrontEndMap.umap");
            maps.Add("TutorialSurvival", "TutorialSurvival.umap");
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
