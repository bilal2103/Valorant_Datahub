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
    public partial class TournamentHistoryView : Form
    {
        public string connection, last_clicked_match, last_clicked_tournament;
        public TournamentHistoryView()
        {
            InitializeComponent();
            connection = "Data Source = AIMANANANANA; Initial Catalog = Valo_Data; Integrated Security = True";
            displaytable();
        }

        private void displaytable()
        {
            string query = "select * from tournament_history";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1, reader["Tournament_id"].ToString(), reader["Match_id"].ToString(),
                    reader["match_tag"].ToString());
                dataGridView1.Rows.Add(row);
            }
            con.Close();
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            string query = "select * from tournament_history where tournament_id = '" + tidtxt.Text + "'";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                if (reader.HasRows)
                {
                    con.Close();
                    query = "select * from tournament_history where match_id = '" + midtxt.Text + "'";
                    con = new SqlConnection(connection);
                    con.Open();
                    cmd = new SqlCommand(query, con);
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("This record already exists");
                    }
                    else
                    {
                        con.Close();
                        con.Open();
                        query = "select * from matches where match_id = '" + midtxt.Text + "'";
                        cmd = new SqlCommand(query, con);
                        reader = cmd.ExecuteReader();
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("Match with this ID does not exist.");
                        }
                        else
                        {
                            con.Close();
                            con.Open();
                            query = "insert into tournament_history values ('" + tidtxt.Text + "', '" + midtxt.Text + "','" + tagtxt.Text + "')";
                            cmd = new SqlCommand(query, con);
                            cmd.ExecuteNonQuery();
                            dataGridView1.Rows.Clear();
                            displaytable();
                        }
                    }
                }
                else
                {
                    con.Close();
                    con.Open();
                    query = "select * from tournaments where tournament_id = '" + tidtxt.Text + "'";
                    cmd = new SqlCommand(query, con);
                    reader = cmd.ExecuteReader();
                    if (!reader.HasRows)
                    {
                        MessageBox.Show("Tournament with this ID does not exist.");
                    }
                    else
                    {
                        con.Close();
                        con.Open();
                        query = "select * from matches where match_id = '" + midtxt.Text + "'";
                        cmd = new SqlCommand(query, con);
                        reader = cmd.ExecuteReader();
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("Match with this ID does not exist.");
                        }
                        else
                        {
                            con.Close();
                            con.Open();
                            query = "insert into tournament_history values ('" + tidtxt.Text + "', '" + midtxt.Text + "','" + tagtxt.Text + "')";
                            cmd = new SqlCommand(query, con);
                            cmd.ExecuteNonQuery();
                            dataGridView1.Rows.Clear();
                            displaytable();
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
                tidtxt.Text = selectedRow.Cells["tournament_id"].Value.ToString();
                tagtxt.Text = selectedRow.Cells["match_tag"].Value.ToString();
                last_clicked_match = midtxt.Text;
                last_clicked_tournament = tidtxt.Text;
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            string query = "select * from tournament_history where match_id = '" + midtxt.Text + "'";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (!reader.HasRows)
            {
                MessageBox.Show("No match with this ID exists");
            }
            else
            {
                con.Close();
                con.Open();
                query = "select * from tournament_history where tournament_id = '" + tidtxt.Text + "'";
                cmd = new SqlCommand(query, con);
                reader = cmd.ExecuteReader();
                if (!reader.HasRows)
                {
                    MessageBox.Show("No tournament with this ID exists");
                }
                else
                {
                    con.Close();
                    con.Open();
                    query = "delete from solo_matches where match_id = '" + midtxt.Text + "' and tournament_id = '"+tidtxt.Text+"'";
                    cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    dataGridView1.Rows.Clear();
                    displaytable();
                }
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {

        }
    }
}
