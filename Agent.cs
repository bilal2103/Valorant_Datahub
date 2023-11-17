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
        public void DisplayStats(AgentInformation obj)
        {
            name_tb.Text = obj.agent_name;
            win_tb.Text = string.Format("{0:N3}", obj.win_pct) + "%";
            pick_tb.Text = string.Format("{0:N3}", obj.pick_pct) + "%";
            tier_tb.Text = obj.tier;
            category_tb.Text = obj.category;
            textBox1.Text = obj.voiced_by;
            ult_tb.Text = obj.ultimate;
            weapon_tb.Text = obj.suited_weapon;
            About_tb.Text = obj.Description;

        }
        public Agent(string view,AgentInformation obj)
        {
            this.view = view;
            InitializeComponent();
            DisplayStats(obj);
        }
        public Agent()
        {
            InitializeComponent();
        }


    }
}
