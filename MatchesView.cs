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
        SqlConnection con;
        SqlTransaction transaction;
        public MatchesView()
        {
            InitializeComponent();
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
            con = new SqlConnection(vars.connection);
            
            con.Open();
            displaytable();
        }

        private void displaytable()
        {
            reset_textbox();
            string query = "select * from matches";
            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandTimeout = 1;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridView1, reader["match_id"].ToString(), reader["team1_id"].ToString(),
                        reader["team2_id"].ToString(), reader["winner_id"].ToString(),
                        reader["map_name"].ToString());
                    dataGridView1.Rows.Add(row);
                }
                reader.Close();
                this.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Dirty reads are not allowed. Please wait...");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.RowCount - 1)
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
                        query = "select * from teams  where team_id = '" + team1txt.Text + "'";
                        cmd = new SqlCommand(query, con);
                        reader.Close();
                        reader = cmd.ExecuteReader();
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("Team with ID " + team1txt + " does not exist.");
                        }
                        else
                        {
                            query = "select * from teams where team_id = '" + team2txt.Text + "'";
                            cmd = new SqlCommand(query, con);
                            reader.Close();
                            reader = cmd.ExecuteReader();
                            if (!reader.HasRows)
                            {
                                MessageBox.Show("Team with ID " + team2txt + " does not exist.");
                            }
                            else
                            {
                                query = "select * from maps where map_name = '" + maptxt.Text + "'";
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
                                        transaction = con.BeginTransaction(IsolationLevel.ReadCommitted);
                                        query = "insert into matches values ('" + idtxt.Text + "', '" + team1txt.Text + "','" + team2txt.Text + "','" + winnertxt.Text + "','" + maptxt.Text + "')";
                                        cmd = new SqlCommand(query, con, transaction);
                                        cmd.CommandTimeout = 1;
                                        cmd.ExecuteNonQuery();
                                        MessageBox.Show("Press commit to see your changes");
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                        transaction.Rollback();
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
                    MessageBox.Show("Commit successful");
                    dataGridView1.Rows.Clear();
                    displaytable();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    
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
                    MessageBox.Show("Rollback successful");
                    dataGridView1.Rows.Clear();
                displaytable();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            displaytable();
        }

        private void reset_textbox()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    if(control.Name == "querytb") querytb.Text = "select * from matches where ";
                    else control.Text = "";
                }
            }

        }

        private void querytb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string query = querytb.Text;
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandTimeout = 1;
                SqlDataReader reader;
                try
                {
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        dataGridView1.Rows.Clear();
                        while (reader.Read())
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            row.CreateCells(dataGridView1, reader["match_id"].ToString(), reader["team1_id"].ToString(),
                        reader["team2_id"].ToString(), reader["winner_id"].ToString(),
                        reader["map_name"].ToString());
                            dataGridView1.Rows.Add(row);
                        }
                        reader.Close();
                    }
                    else
                    {
                        reader.Close();
                        dataGridView1.Rows.Clear();
                        displaytable();
                        MessageBox.Show("Query has no rows");
                        
                    }
                        
                        
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
        private void querytb_TextChanged(object sender, EventArgs e)
        {
            if (querytb.TextLength <= 28)
            {
                querytb.Text = "select * from matches where ";
                querytb.SelectionStart = 28;
            }
        }
    }
}
