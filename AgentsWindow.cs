using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Valorant_Datahub
{
    public partial class AgentsWindow : Form
    {
        string view;
        public AgentsWindow()
        {
            InitializeComponent();
        }
        public AgentsWindow(string str)
        {
            view = str;
            InitializeComponent();
        }
        public string agent_name;
        private void button1_Click(object sender, EventArgs e)
        {
            agent_name = textBox1.Text;
            string Query = "select * from agents where agent_name = @agent_name";
            string Connection = "Data Source=BILALS-LAPPY;Initial Catalog=Valo_Data;Integrated Security=True";
            SqlConnection con = new SqlConnection(Connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.Parameters.AddWithValue("@agent_name", agent_name);
            SqlDataReader result = cmd.ExecuteReader();
            if (result.Read())
            {
                float win_pct = result.GetFloat(result.GetOrdinal("win_pct"));
                float pick_pct = result.GetFloat(result.GetOrdinal("pick_pct"));
                AgentInformation obj = new AgentInformation(result["Agent_name"].ToString(), pick_pct, win_pct,
                    result["Tier"].ToString(), result["Role"].ToString(), result["Suited_Weapon"].ToString(), result["Ultimate"].ToString(), result["Description"].ToString(),
                    result["Voiced_by"].ToString());
                Agent a = new Agent(view, obj);
                this.Hide();
                a.Show();
            }
            else MessageBox.Show("Agent not found");
            con.Close();

            
        }

        private void AgentsWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(view == "Guest")
            {
                GuestForm g = new GuestForm();
                g.Show();
            }
            else
            {
                UserForm u = new UserForm();
                u.Show();
            }
            this.Hide();
        }
    }
}
