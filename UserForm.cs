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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void weaponary_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            WeaponaryWindow w = new WeaponaryWindow("User");
            w.Show();
        }

        private void Leaderboards_btn_Click(object sender, EventArgs e)
        {

        }

        private void Agents_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AgentsWindow agents = new AgentsWindow("User");
            agents.Show();
        }

        private void Tournament_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Before_TournamentWindow t = new Before_TournamentWindow("User");
            t.Show();
        }

        private void Maps_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MapsWindow maps = new MapsWindow("User");
            maps.Show();
        }

        private void personal_btn_Click(object sender, EventArgs e)
        {

        }

        private void UserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }
    }
}
