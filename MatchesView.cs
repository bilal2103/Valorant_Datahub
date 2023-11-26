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
        SqlConnection con, readerCon;
        SqlTransaction transaction;
        public MatchesView()
        {
            InitializeComponent();
            connection = "Data Source=BILALS-LAPPY;Initial Catalog=Valo_Data;Integrated Security=True";
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
            
            con = new SqlConnection(connection);
            readerCon = new SqlConnection(connection);
            displaytable();
            con.Open();
        }

        private void displaytable()
        {
            reset_textbox();
            string query = "select * from matches (NOLOCK)";
            readerCon.Open();
            SqlCommand cmd = new SqlCommand(query, readerCon);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1, reader["match_id"].ToString(), reader["team1_id"].ToString(),
                    reader["team2_id"].ToString(), reader["winner_id"].ToString(),reader["map_name"].ToString());
                dataGridView1.Rows.Add(row);
            }
            readerCon.Close();
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
            string query = "select * from matches (NOLOCK) where match_id = '" + idtxt.Text + "'";
            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                try
                {
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Match with this match ID already exists");
                    }
                    else
                    {
                        query = "select * from teams (NOLOCK) where team_id = '" + team1txt.Text + "'";
                        cmd = new SqlCommand(query, con);
                        reader.Close();
                        reader = cmd.ExecuteReader();
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("Team with ID " + team1txt + " does not exist.");
                        }
                        else
                        {
                            query = "select * from teams (NOLOCK) where team_id = '" + team2txt.Text + "'";
                            cmd = new SqlCommand(query, con);
                            reader.Close();
                            reader = cmd.ExecuteReader();
                            if (!reader.HasRows)
                            {
                                MessageBox.Show("Team with ID " + team2txt + " does not exist.");
                            }
                            else
                            {
                                query = "select * from maps (NOLOCK) where map_name = '" + maptxt.Text + "'";
                                cmd = new SqlCommand(query, con);
                                reader.Close();
                                reader = cmd.ExecuteReader();
                                if (!reader.HasRows)
                                {
                                    MessageBox.Show("Map with this name does not exist.");
                                }
                                else
                                {
                                    reader.Close();
                                    Console.WriteLine("Ready to begin transaction");
                                    try
                                    {
                                        transaction = con.BeginTransaction(IsolationLevel.ReadUncommitted);
                                        query = "insert into matches values ('" + idtxt.Text + "', '" + team1txt.Text + "','" + team2txt.Text + "','" + winnertxt.Text + "','" + maptxt.Text + "')";
                                        cmd = new SqlCommand(query, con, transaction);
                                        cmd.CommandTimeout = 3;
                                        cmd.ExecuteNonQuery();
                                        dataGridView1.Rows.Clear();
                                        displaytable();
                                    }
                                    catch (SqlException ex)
                                    {
                                        MessageBox.Show("The data you're trying to access is currently locked in a transaction");
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                    }
                                }
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }    
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }

        private void commit_btn_Click(object sender, EventArgs e)
        {
            if(transaction != null)
            {
                try
                {
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    dataGridView1.Rows.Clear();
                    displaytable();
                }
            }
            
        }

        private void MatchesView_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            con.Close();
        }

        private void rollback_btn_Click(object sender, EventArgs e)
        {
            if(transaction != null)
            try
            {
                transaction.Rollback();
                dataGridView1.Rows.Clear();
                displaytable();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void reset_textbox()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                    control.Text = "";
            }

        }
    }
}
