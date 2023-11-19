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
    public partial class Before_TournamentWindow : Form
    {
        public Before_TournamentWindow()
        {
            InitializeComponent();
        }
        private void alternate_btn_Click(object sender, EventArgs e)
        {
            Tournament_Alternate t = new Tournament_Alternate();
            t.Show();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            if(textBox1.TextLength > 0)
            {
                int Tournament_id = Convert.ToInt32(textBox1.Text);
                string Query = "select Tid from tournaments where Tid = @Tournament_id";
                string Connection = "Data Source=BILALS-LAPPY;Initial Catalog=Valo_Data;Integrated Security=True";
                SqlConnection con = new SqlConnection(Connection);
                con.Open();
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.Parameters.AddWithValue("tournament_id", Tournament_id);
                Console.WriteLine(cmd.CommandText);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    Query = "select match_id,match_tag from tournament_history where tournament_id = @tournament_id";
                    con.Close();
                    con.Open();
                    cmd = new SqlCommand(Query, con);
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("tournament_id", Tournament_id);
                    reader = cmd.ExecuteReader();
                    MatchesInformation[] Matches = new MatchesInformation[7];
                    int i = 0;
                    Dictionary<string, List<MatchesInformation>> MatchesDictionary = new Dictionary<string, List<MatchesInformation>>();
                    MatchesDictionary["Quarter-Final"] = new List<MatchesInformation>();
                    MatchesDictionary["Semi-Final"] = new List<MatchesInformation>();
                    MatchesDictionary["Final"] = new List<MatchesInformation>();
                    while (reader.Read())
                    {
                        int a = Convert.ToInt32(reader["match_id"].ToString());
                        string b = reader["match_tag"].ToString();
                        Matches[i] = new MatchesInformation(a);
                        MatchesDictionary[b].Add(Matches[i]);
                        i++;
                    }
                    con.Close();
                    TournamentWindow t = new TournamentWindow(MatchesDictionary);
                    t.Show();
                }
                else MessageBox.Show("Tournament with this id not found");
                con.Close();

            }
            else MessageBox.Show("Tournament with this id not found");
        }
    }
}
