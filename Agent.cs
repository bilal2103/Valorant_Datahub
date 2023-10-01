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
    public partial class Agent : Form
    {
        
        string name, Tier, Category, Suited_Weapon;
        float pick_pct, win_pct;

        private void Agent_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                Agent a = new Agent();
                a.Close();
                AgentsWindow hehe = new AgentsWindow();
                hehe.Show();
            }
        }

        int Location_id;
        public void DisplayStats()
        {

        }
        public Agent(string name)
        {
            this.name = name;
            InitializeComponent();
            DisplayStats();
        }
        public Agent() { }


    }
}
