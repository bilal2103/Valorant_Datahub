using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
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

            this.BackColor = ColorTranslator.FromHtml(Colors.back_color);
            foreach (Control ctl in Controls)
            {
                if (ctl is TextBox || ctl is RichTextBox)
                {
                    ctl.BackColor = ColorTranslator.FromHtml(Colors.tb_backcolor);
                    ctl.ForeColor = ColorTranslator.FromHtml(Colors.tb_forecolor);
                    ctl.Font = new Font("Franklin Gothic Medium Cond", 12, FontStyle.Regular);
                }
                if (ctl is Button)
                {
                    ctl.BackColor = ColorTranslator.FromHtml(Colors.btn_color);
                    ctl.ForeColor = ColorTranslator.FromHtml(Colors.btn_fore_color);
                    ctl.Font = new Font("Franklin Gothic Medium Cond", 12, FontStyle.Bold);
                }
                if (ctl is Label)
                {
                    ctl.ForeColor = ColorTranslator.FromHtml("#000000");
                }
            }
        }

        private void agentsbtn_Click(object sender, EventArgs e)
        {
            AgentsView a = new AgentsView();
        }

        private void mapsbtn_Click(object sender, EventArgs e)
        {
            MapsView maps = new MapsView();
        }

        private void locationbtn_Click(object sender, EventArgs e)
        {
            LocationView location = new LocationView();
        }

        private void teamsbtn_Click(object sender, EventArgs e)
        {
            TeamsView team = new TeamsView();
        }

        private void matchesbtn_Click(object sender, EventArgs e)
        {
            MatchesView match = new MatchesView();
        }

        private void tournamentsbtn_Click(object sender, EventArgs e)
        {
            TournamentsView t = new TournamentsView();
        }

        private void weaponrybtn_Click(object sender, EventArgs e)
        {
            WeaponsView w = new WeaponsView();
        }

        private void playersbtn_Click(object sender, EventArgs e)
        {
            PlayerView p = new PlayerView();
        }

        private void solobtn_Click(object sender, EventArgs e)
        {
            SoloMatchesView solo = new SoloMatchesView();
        }

        private void THbtn_Click(object sender, EventArgs e)
        {
            TournamentHistoryView th = new TournamentHistoryView();
        }
    }
}
