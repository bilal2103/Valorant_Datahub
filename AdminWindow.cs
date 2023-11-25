﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Valorant_Datahub
{
    public partial class AdminWindow : Form
    {
        public AdminWindow()
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#E2D1F9");
            this.ForeColor = ColorTranslator.FromHtml("#317773");
            foreach (Control ctl in Controls)
            {
                if (ctl is TextBox || ctl is Button)
                {
                    ctl.BackColor = ColorTranslator.FromHtml("#317773");
                    ctl.ForeColor = ColorTranslator.FromHtml("#E2D1F9");
                }
            }
        }

        private void agentsbtn_Click(object sender, EventArgs e)
        {
            AgentsView a = new AgentsView();
            a.Show();
        }

        private void mapsbtn_Click(object sender, EventArgs e)
        {
            MapsView maps = new MapsView();
            maps.Show();
        }

        private void locationbtn_Click(object sender, EventArgs e)
        {
            LocationView location = new LocationView();
            location.Show();
        }

        private void teamsbtn_Click(object sender, EventArgs e)
        {
            TeamsView team = new TeamsView();
            team.Show();
        }

        private void matchesbtn_Click(object sender, EventArgs e)
        {
            MatchesView match = new MatchesView();
            match.Show();
        }

        private void tournamentsbtn_Click(object sender, EventArgs e)
        {
            TournamentsView t = new TournamentsView();
            t.Show();
        }

        private void weaponrybtn_Click(object sender, EventArgs e)
        {
            WeaponsView w = new WeaponsView();
            w.Show();
        }

        private void playersbtn_Click(object sender, EventArgs e)
        {
            PlayerView p = new PlayerView();
            p.Show();
        }

        private void solobtn_Click(object sender, EventArgs e)
        {
            SoloMatchesView solo = new SoloMatchesView();
            solo.Show();
        }

        private void THbtn_Click(object sender, EventArgs e)
        {
            TournamentHistoryView th = new TournamentHistoryView();
            th.Show();
        }
    }
}
