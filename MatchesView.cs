using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Valorant_Datahub
{
    public partial class MatchesView : Form
    {
        public string connection;
        public MatchesView()
        {
            InitializeComponent();
            connection = "Data Source = AIMANANANANA; Initial Catalog = Valo_Data; Integrated Security = True";
            displaytable();
        }

        private void displaytable()
        {
            string query = "select * from matches";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1, reader["match_id"].ToString(), reader["team1_id"].ToString(),
                    reader["team2_id"].ToString(), reader["winner_id"].ToString(),reader["map_name"].ToString());
                dataGridView1.Rows.Add(row);
            }
            con.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                idtxt.Text = selectedRow.Cells["match_id"].Value.ToString();
                team1txt.Text = selectedRow.Cells["team1_id"].Value.ToString();
                team2txt.Text = selectedRow.Cells["team2_id"].Value.ToString();
                winnertxt.Text = selectedRow.Cells["winner_id"].Value.ToString();
                maptxt.Text = selectedRow.Cells["map_name"].Value.ToString();
            }
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            string query = "select * from matches where match_id = '" + idtxt.Text + "'";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                MessageBox.Show("Match with this match ID already exists");
            }
            else
            {
                con.Close();
                con.Open();
                query = "select * from teams where team_id = '" + team1txt.Text + "'";
                cmd = new SqlCommand(query, con);
                reader = cmd.ExecuteReader();
                if (!reader.HasRows)
                {
                    MessageBox.Show("Team with ID " + team1txt + " does not exist.");
                }
                else
                {
                    con.Close();
                    con.Open();
                    query = "select * from teams where team_id = '" + team2txt.Text + "'";
                    cmd = new SqlCommand(query, con);
                    reader = cmd.ExecuteReader();
                    if (!reader.HasRows)
                    {
                        MessageBox.Show("Team with ID " + team2txt + " does not exist.");
                    }
                    else
                    {
                        con.Close();
                        con.Open();
                        query = "select * from maps where map_name = '" + maptxt.Text + "'";
                        cmd = new SqlCommand(query, con);
                        reader = cmd.ExecuteReader();
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("Map with this name does not exist.");
                        }
                        else
                        {
                            con.Close();
                            con.Open(); 
                            query = "insert into matches values ('" + idtxt.Text + "', '" + team1txt.Text + "','" + team2txt.Text + "','" + winnertxt.Text + "','" + maptxt.Text + "')";
                            cmd = new SqlCommand(query, con);
                            Console.WriteLine(cmd.CommandText);
                            cmd.ExecuteNonQuery();
                            con.Close();
                            dataGridView1.Rows.Clear();
                            displaytable();
                        }
                    }
                }
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            string query = "select * from matches where match_id = '" + idtxt.Text + "'";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (!reader.HasRows)
            {
                MessageBox.Show("No match with this match ID exists");
            }
            else
            {
                con.Close();
                con.Open();
                query = "delete from matches where match_id = '" + idtxt.Text + "'";
                cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1.Rows.Clear();
                displaytable();
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {

        }
    }
}
