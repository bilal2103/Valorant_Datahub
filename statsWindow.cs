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
    public partial class statsWindow : Form
    {
        int pid;
        string connection;
        SqlConnection con;
        public statsWindow()
        {
            InitializeComponent();
        }
        public statsWindow(int pid)
        {
            InitializeComponent();
            this.pid = pid;
            this.BackColor = ColorTranslator.FromHtml(Colors.back_color);
            foreach (Control ctl in Controls)
            {
                if (ctl is TextBox || ctl is RichTextBox)
                {
                    ctl.BackColor = ColorTranslator.FromHtml(Colors.tb_backcolor);
                    ctl.ForeColor = ColorTranslator.FromHtml(Colors.tb_forecolor);
                    ctl.Font = new Font("Franklin Gothic Medium Cond", 12, FontStyle.Regular);
                }
                if (ctl is Button)
                {
                    ctl.BackColor = ColorTranslator.FromHtml(Colors.btn_color);
                    ctl.ForeColor = ColorTranslator.FromHtml(Colors.btn_fore_color);
                    ctl.Font = new Font("Franklin Gothic Medium Cond", 12, FontStyle.Bold);
                }
                if (ctl is Label)
                {
                    ctl.ForeColor = ColorTranslator.FromHtml("#000000");
                    ctl.Font = new Font("Franklin Gothic Medium Cond", 12, FontStyle.Regular);
                }
            }
            connection = "Data Source=BILALS-LAPPY;Initial Catalog=Valo_Data;Integrated Security=True";
            con = new SqlConnection(connection);
            con.Open();
            DisplayInformation();
        }
        private string getRank(int MMR)
        {
            string str = "hehe";
            string query = $"select dbo.GetRank({MMR})";
            SqlConnection con = new SqlConnection("Data Source=BILALS-LAPPY;Initial Catalog=Valo_Data;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            str = cmd.ExecuteScalar().ToString();
            con.Close();
            return str;
        }
        private void DisplayInformation()
        {
            id_tb.Text = pid.ToString();
            try
            {
                string query = "select * from player where pid = " + pid + "";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandTimeout = 1;
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                name_tb.Text = reader["Pname"].ToString();
                agent_tb.Text = reader["FaV_Agent"].ToString();
                kills_tb.Text = reader["kills"].ToString();
                double kd_ratio = Convert.ToDouble(reader["kills"]) / Convert.ToDouble(reader["deaths"]);
                kd_tb.Text = string.Format("{0:N3}", kd_ratio);
                mmr_tb.Text = reader["MMR"].ToString();
                rank_tb.Text = getRank((int)reader["MMR"]);
                reader.Close();
                Console.WriteLine("Data from player was read");
                query = "select username from users where player_id = " + pid + "";
                cmd = new SqlCommand(query, con);
                cmd.CommandTimeout = 1;
                reader = cmd.ExecuteReader();
                reader.Read();
                uname_tb.Text = reader["username"].ToString();
                reader.Close();
                Console.WriteLine("Data from users was read");
                query = "select count(1) as 'Total' from solo_matches where player_ID = " + pid + "";
                cmd = new SqlCommand(query, con);
                cmd.CommandTimeout = 1;
                reader = cmd.ExecuteReader();
                int total_matches = 0;
                int matches_won = 0;
                if(reader.HasRows)
                {
                    reader.Read();
                    total_matches = (int)reader["Total"];
                    reader.Close();
                    query = "select count(1) as 'Won' from solo_matches where player_ID = " + pid + " and Result = 'Won'";
                    cmd = new SqlCommand(query, con);
                    cmd.CommandTimeout = 1;
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    matches_won = (int)reader["Won"];
                }
                reader.Close();
                Console.WriteLine("Data from solo_matches was read");
                query = "select count(1) as 'exists',team_id from PLAYER_TEAM where player_id = " + pid + " group by team_id";
                cmd = new SqlCommand(query, con);
                cmd.CommandTimeout = 1;
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    int TeamID = (int)reader["team_id"];

                    query = "select count(1) as 'NumberOfMatches' from matches where team1_id = " + TeamID + " or team2_id = " + TeamID + "";
                    reader.Close();
                    cmd = new SqlCommand(query, con);
                    cmd.CommandTimeout = 1;
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    total_matches += (int)reader["NumberOfMatches"];
                    reader.Close();
                    query = "select count(1) as 'MatchesWon' from matches where winner_id = " + TeamID + "";
                    cmd = new SqlCommand(query, con);
                    cmd.CommandTimeout = 1;
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    matches_won += (int)reader["MatchesWon"];
                }

                totalmatches_tb.Text = total_matches.ToString();
                wonmatches_tb.Text = matches_won.ToString();
                query = "select agent_played from solo_matches where player_id = " + pid + " group by" +
                    " agent_played having sum(kills) = (select max(total_kills) from (select sum(kills) as 'Total_kills' " +
                    "from solo_matches where player_id= " + pid + " group by agent_played) as SubqueryAlias);";
                reader.Close();
                cmd = new SqlCommand(query, con);
                cmd.CommandTimeout = 1;
                reader = cmd.ExecuteReader();
                Image im;
                string image_path = "C:\\Users\\Dell\\OneDrive\\Desktop\\Valorant_Datahub\\Images\\";
                if (reader.HasRows)
                {
                    reader.Read();
                    im = Image.FromFile(image_path + reader["agent_played"].ToString() + ".jpg");
                    reader.Close();
                }
                else
                {
                    im = Image.FromFile(image_path + "Sage" + ".jpg");
                }
                
                pictureBox1.Image = im;
                this.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
            con.Close();
        }

        private void kills_tb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
