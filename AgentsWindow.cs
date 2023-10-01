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
    public partial class AgentsWindow : Form
    {
        public AgentsWindow()
        {
            InitializeComponent();
        }
        public string agent_name;
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            agent_name = textBox1.Text;
            Agent hehe = new Agent(agent_name);
            hehe.Show();
        }

        private void AgentsWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            AgentsWindow a = new AgentsWindow();
            a.Close();
            GuestForm g = new GuestForm();
            g.Show();
        }
    }
}
