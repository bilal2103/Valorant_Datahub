using System;
using System.Collections;
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
    public partial class Leaderboards : Form
    {
        int pid;
        public Leaderboards()
        {
            InitializeComponent();
            displayLeaderboard();
        }
        public Leaderboards(int pid)
        {
            InitializeComponent();
            displayLeaderboard();
            this.pid = pid;
        }
        private void displayLeaderboard()
        {
            string query = "select * from player_leaderboard_users order by mmr desc,kd_ratio desc";
            string connection = "Data Source=BILALS-LAPPY;Initial Catalog=Valo_Data;Integrated Security=True";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader= cmd.ExecuteReader();
            while(reader.Read())
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1, reader["username"].ToString(), reader["Pname"].ToString(), Form1.getRank((int)reader["MMR"]),
                    reader["fav_agent"].ToString(), string.Format("{0:N3}", Convert.ToDouble(reader["kd_ratio"])), reader["Country"]);
                dataGridView1.Rows.Add(row);
            }
            con.Close();
        }

        private void Leaderboards_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(pid == -1)
            {
                GuestForm g = new GuestForm();
                g.Show();
                this.Hide();
            }
            else
            {
                string connection = "Data Source=BILALS-LAPPY;Initial Catalog=Valo_Data;Integrated Security=True";
                string query = "select username from users where player_id = "+pid+"";
                SqlConnection con = new SqlConnection(connection);
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader= cmd.ExecuteReader();
                reader.Read();
                UserForm u = new UserForm(reader["username"].ToString());
                this.Hide();
                con.Close();
                u.Show();
            }
        }
    }
}
