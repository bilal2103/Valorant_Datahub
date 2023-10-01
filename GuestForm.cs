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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            TournamentWindow t = new TournamentWindow();
            t.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AgentsWindow agents = new AgentsWindow();
            agents.Show();
        }

        private void GuestForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            GuestForm g = new GuestForm();
            g.Close();
            Form1 f = new Form1();
            f.Show();
        }
    }
}
