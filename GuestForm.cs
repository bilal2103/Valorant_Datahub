using System;
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
    public partial class GuestForm : Form
    {
        public GuestForm()
        {
            InitializeComponent();
        }



        private void GuestForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            GuestForm g = new GuestForm();
            g.Close();
            Form1 f = new Form1();
            f.Show();
        }

        private void Tournaments_Click(object sender, EventArgs e)
        {
            this.Hide();
            Before_TournamentWindow t = new Before_TournamentWindow("Guest");
            t.Show();
        }

        private void Agents_Click(object sender, EventArgs e)
        {
            this.Hide();
            AgentsWindow agents = new AgentsWindow("Guest");
            agents.Show();
        }

        private void Leaderboards_btn_Click(object sender, EventArgs e)
        {

        }

        private void Maps_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MapsWindow maps = new MapsWindow("Guest");
            maps.Show();
        }

        private void weaponary_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            WeaponaryWindow w = new WeaponaryWindow("Guest");
            w.Show();
        }
    }
}
