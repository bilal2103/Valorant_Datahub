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
        
        string name, Tier, Category, Suited_Weapon,ult,About;
        float pick_pct, win_pct;
        string view;
        private void Agent_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                AgentsWindow hehe = new AgentsWindow(view);
                hehe.Show();
            }
        }

        int Location_id;
        public void DisplayStats()
        {

        }
        public Agent(string view,string name)
        {
            this.view = view;
            this.name = name;
            InitializeComponent();
            DisplayStats();
        }
        public Agent()
        {
            InitializeComponent();
        }


    }
}
