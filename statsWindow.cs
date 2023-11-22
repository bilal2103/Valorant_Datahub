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
        public statsWindow()
        {
            InitializeComponent();
        }
        public statsWindow(int pid)
        {
            InitializeComponent();
            this.pid = pid;
            DisplayInformation();
        }
        SqlDataReader ExecuteQuery(ref SqlConnection con,string query)
        {
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            return reader;
        }
        private string getRank(int MMR)
        {
            string str = "hehe";
            switch(MMR)
            {
                
            }
            return str;
        }
        private void DisplayInformation()
        {
            SqlConnection con = new SqlConnection("Data Source=BILALS-LAPPY;Initial Catalog=Valo_Data;Integrated Security=True");
            id_tb.Text = pid.ToString();
            string query = "select * from player where pid = "+pid+"";
            con.Open();
            SqlDataReader reader = ExecuteQuery(ref con,query);
            name_tb.Text = reader["Pname"].ToString();
            agent_tb.Text = reader["FaV_Agent"].ToString();
            kills_tb.Text = reader["kills"].ToString();
            double kd_ratio = Convert.ToDouble(reader["kills"]) / Convert.ToDouble(reader["deaths"]);
            kd_tb.Text = string.Format("{0:N3}", kd_ratio);
            mmr_tb.Text = reader["MMR"].ToString();
            rank_tb.Text = getRank((int)reader["MMR"]);
            con.Close();
            con.Open();
            query = "select username from users where player_id = "+pid+"";
            reader = ExecuteQuery(ref con, query);

            uname_tb.Text = reader["username"].ToString();
            con.Close();
            con.Open();
            query = "select count(1) as 'Total' from solo_matches where player_ID = " + pid + "";
            reader = ExecuteQuery(ref con, query);
            
            int total_matches = (int)reader["Total"];
            con.Close();
            con.Open();
            query = "select count(1) as 'Won' from solo_matches where player_ID = " + pid + " and Result = 'Won'";
            reader = ExecuteQuery(ref con, query);
            
            int matches_won = (int)reader["Won"];
            
            con.Close();
            con.Open();
            query = "select count(1) as 'exists',team_id from PLAYER_TEAM where player_id = " + pid + " group by team_id";
            reader = ExecuteQuery(ref con, query);
            if (reader.HasRows)
            {
                int TeamID = (int)reader["team_id"];
                con.Close();
                con.Open();
                query = "select count(1) as 'NumberOfMatches' from matches where team1_id = " + TeamID + " or team2_id = "+TeamID+"";
                reader = ExecuteQuery(ref con, query);
                total_matches += (int)reader["NumberOfMatches"];
                con.Close();
                con.Open();
                query = "select count(1) as 'MatchesWon' from matches where winner_id = " + TeamID + "";
                reader = ExecuteQuery(ref con, query);
                matches_won += (int)reader["MatchesWon"];
                con.Close();
            }
            con.Close();
            totalmatches_tb.Text = total_matches.ToString();
            wonmatches_tb.Text = matches_won.ToString();
            query = "select agent_played from solo_matches where player_id = "+pid+" group by" +
                " agent_played having sum(kills) = (select max(total_kills) from (select sum(kills) as 'Total_kills' " +
                "from solo_matches where player_id= "+pid+" group by agent_played) as SubqueryAlias);";
            con.Open();
            reader = ExecuteQuery(ref con, query);
            if(reader.HasRows)
            textBox9.Text = reader["agent_played"].ToString();
            con.Close();
        }
    }
}
