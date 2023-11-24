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
    public partial class SoloMatchesView : Form
    {
        public string connection;
        public SoloMatchesView()
        {
            InitializeComponent();
            connection = "Data Source=BILALS-LAPPY;Initial Catalog=Valo_Data;Integrated Security=True";
            displaytable();
        }

        private void displaytable()
        {
            string query = "select * from solo_matches order by match_id";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1, reader["Match_ID"].ToString(), reader["Kills"].ToString(), reader["Deaths"].ToString(),
                    reader["Result"].ToString(), reader["Agent_Played"].ToString(), reader["Map_Name"].ToString(), reader["Player_ID"].ToString());
                dataGridView1.Rows.Add(row);
            }
            con.Close();
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            string query = "select * from solo_matches where match_id = '" + midtxt.Text + "'";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                if (reader.HasRows)
                {
                    MessageBox.Show("Match with this ID already exists");
                }
                else
                {
                    con.Close();
                    con.Open();
                    query = "select * from agents where agent_name = '" + agenttxt.Text + "'";
                    cmd = new SqlCommand(query, con);
                    reader = cmd.ExecuteReader();
                    if (!reader.HasRows)
                    {
                        MessageBox.Show("Agent with this name does not exist.");
                    }
                    else
                    {
                        con.Close();
                        con.Open();
                        query = "select * from player where pid = '" + pidtxt.Text + "'";
                        cmd = new SqlCommand(query, con);
                        reader = cmd.ExecuteReader();
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("Player with this ID does not exist.");
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
                                query = "insert into solo_matches values ('" + midtxt.Text + "', '" + killstxt.Text + "','" + deathstxt.Text + "', '" + resulttxt.Text + "',  '" + agenttxt.Text + "','" + maptxt.Text + "','" + pidtxt.Text + "')";
                                cmd = new SqlCommand(query, con);
                                cmd.ExecuteNonQuery();
                                dataGridView1.Rows.Clear();
                                displaytable();
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                midtxt.Text = selectedRow.Cells["match_id"].Value.ToString();
                killstxt.Text = selectedRow.Cells["kills"].Value.ToString();
                deathstxt.Text = selectedRow.Cells["deaths"].Value.ToString();
                resulttxt.Text = selectedRow.Cells["result"].Value.ToString();
                agenttxt.Text = selectedRow.Cells["agent_played"].Value.ToString();
                maptxt.Text = selectedRow.Cells["map_name"].Value.ToString();
                pidtxt.Text = selectedRow.Cells["player_id"].Value.ToString();
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {

        }
    }
}
