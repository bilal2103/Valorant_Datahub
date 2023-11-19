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
    public partial class UserForm : Form
    {
        int pid;
        public UserForm()
        {
            InitializeComponent();
        }
        public UserForm(string uname)
        {
            InitializeComponent();
            update_welcome_label(uname);
        }
        private void update_welcome_label(string uname)
        {
            string query = "select player_id from users where username = @uname";
            string connection = "Data Source=BILALS-LAPPY;Initial Catalog=Valo_Data;Integrated Security=True";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("uname", uname);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int temp = Convert.ToInt32(reader["player_id"]);
            con.Close();
            con.Open();
            query = "select Pname from player where pid = @val";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("val", temp);
            reader = cmd.ExecuteReader();
            reader.Read();
            welcome_lbl.Text += $" {reader["Pname"].ToString()}!";
            con.Close();
            pid = temp;
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
            statsWindow s = new statsWindow(pid);
            s.Show();
            this.Hide();
        }

        private void UserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void pwUpdate_Click(object sender, EventArgs e)
        {
            this.Hide();
            pwUpdatecs p = new pwUpdatecs(pid);
            p.Show();
        }
    }
}
