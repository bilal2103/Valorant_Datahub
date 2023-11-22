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
    public partial class AdminWindow : Form
    {
        public AdminWindow()
        {
            InitializeComponent();
        }

        private void agentsbtn_Click(object sender, EventArgs e)
        {
            AgentsView a = new AgentsView();
            a.Show();
        }

        private void playersbtn_Click(object sender, EventArgs e)
        {
            PlayerView p = new PlayerView();
            p.Show();
        }

        private void weaponrybtn_Click(object sender, EventArgs e)
        {
            WeaponsView w = new WeaponsView();
            w.Show();
        }
    }
}
