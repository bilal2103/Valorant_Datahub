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
        string username;
        public Leaderboards()
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#E2D1F9");
            this.ForeColor = ColorTranslator.FromHtml("#317773");
            dataGridView1.BackgroundColor = ColorTranslator.FromHtml("#E2D1F9");
            displayLeaderboard();
        }
        public Leaderboards(int pid,string username)
        {
            InitializeComponent();
            this.pid = pid;
            this.username = username;
            this.BackColor = ColorTranslator.FromHtml(Colors.back_color);
            foreach (Control ctl in Controls)
            {
                if (ctl is Button)
                {
                    ctl.BackColor = ColorTranslator.FromHtml(Colors.btn_color);
                    ctl.ForeColor = ColorTranslator.FromHtml(Colors.btn_fore_color);

                }
                if (ctl is TextBox)
                {
                    ctl.BackColor = ColorTranslator.FromHtml(Colors.tb_backcolor);
                    ctl.ForeColor = ColorTranslator.FromHtml(Colors.tb_forecolor);
                }
                if (ctl is Label)
                    ctl.ForeColor = ColorTranslator.FromHtml("#000000");
            }
            displayLeaderboard();
        }
        private string getRank(int mmr)
        {
            string query = $"select dbo.getRank({mmr})";
            string connection = "Data Source=BILALS-LAPPY;Initial Catalog=Valo_Data;Integrated Security=True";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(query,con);
            string res =  cmd.ExecuteScalar().ToString();
            con.Close();
            return res;
        }
        private void displayLeaderboard()
        {
            string query = "";
            string connection = "Data Source=BILALS-LAPPY;Initial Catalog=Valo_Data;Integrated Security=True";
            SqlCommand cmd;
            SqlDataReader reader;
            SqlConnection con = new SqlConnection(connection);
            if (pid == -1)
            {
                label2.Text = "Get registered today to see yourself in the table below!";
            }
            query = "select * from player_leaderboard_users order by mmr desc,kd_ratio desc";
            con.Open();
            cmd = new SqlCommand(query, con);
            reader= cmd.ExecuteReader();
            int index = 1;
            while(reader.Read())
            {
                DataGridViewRow row = new DataGridViewRow();
                
                row.CreateCells(dataGridView1, reader["username"].ToString(), reader["Pname"].ToString(), getRank((int)reader["MMR"]),
                    reader["fav_agent"].ToString(), string.Format("{0:N3}", Convert.ToDouble(reader["kd_ratio"])), reader["Country"]);
                if (reader["username"].ToString() == this.username)
                {
                    label2.Text = $"{username}, you are currently ranked number {index}!";
                }
                dataGridView1.Rows.Add(row);
                index++;
            }
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Leaderboards_Load(object sender, EventArgs e)
        {

        }
    }
}
