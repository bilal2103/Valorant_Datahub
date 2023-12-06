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
    public partial class TournamentsView : Form
    {
        SqlConnection con;
        SqlTransaction transaction;
        public TournamentsView()
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml(Colors.back_color);
            this.ForeColor = ColorTranslator.FromHtml("#FFFFFF");

            foreach (Control ctl in Controls)
            {
                if (ctl is TextBox || ctl is RichTextBox)
                {
                    ctl.BackColor = ColorTranslator.FromHtml(Colors.tb_backcolor);
                    ctl.ForeColor = ColorTranslator.FromHtml(Colors.tb_forecolor);
                    ctl.Font = new Font("Franklin Gothic Medium Cond", 9, FontStyle.Regular);
                }
                if (ctl is Button)
                {
                    ctl.BackColor = ColorTranslator.FromHtml(Colors.btn_color);
                    ctl.ForeColor = ColorTranslator.FromHtml(Colors.btn_fore_color);
                    ctl.Font = new Font("Franklin Gothic Medium Cond", 10, FontStyle.Bold);
                }
                if (ctl is Label)
                {
                    ctl.ForeColor = ColorTranslator.FromHtml("#000000");
                    ctl.Font = new Font("Franklin Gothic Medium Cond", 11, FontStyle.Regular);
                }
            }
            dataGridView1.RowsDefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#000000");
            con = new SqlConnection(vars.connection);
            con.Open();
            displaytable();
        }

        private void displaytable()
        {
            foreach (Control ctl in Controls)
            {
                if (ctl is TextBox)
                {
                    if (ctl.Name == "querytb") ctl.Text = "select * from tournaments where ";
                    else
                    ctl.Text = "";
                }   
            }
            string query = "select * from tournaments";
            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandTimeout = 1;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridView1, reader["tid"].ToString(), reader["tournament_title"].ToString(), reader["prize_pool"].ToString(), reader["location_id"].ToString());
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
                idtxt.Text = selectedRow.Cells["tid"].Value.ToString();
                titletxt.Text = selectedRow.Cells["tournament_title"].Value.ToString();
                prizetxt.Text = selectedRow.Cells["prize_pool"].Value.ToString();
                locationtxt.Text = selectedRow.Cells["location_id"].Value.ToString();
            }
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            string query = $"insert into tournaments values({idtxt.Text},{prizetxt.Text},{locationtxt.Text},'{titletxt.Text}')";
            try
            {
                transaction = con.BeginTransaction(IsolationLevel.ReadCommitted);
                SqlCommand cmd = new SqlCommand(query, con, transaction);
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

        private void deletebtn_Click(object sender, EventArgs e)
        {
            string query = "delete from tournaments where tid = '" + idtxt.Text + "'";
            try
            {
                transaction = con.BeginTransaction(IsolationLevel.ReadCommitted);
                SqlCommand cmd = new SqlCommand(query, con, transaction);
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

        private void updatebtn_Click(object sender, EventArgs e)
        {
            string query = $"update tournaments set prize_pool = {prizetxt.Text},tournament_title = '{titletxt.Text}',location_id = {locationtxt.Text} where tid = {idtxt.Text}";
            try
            {
                transaction = con.BeginTransaction(IsolationLevel.ReadCommitted);
                SqlCommand cmd = new SqlCommand(query, con, transaction);
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

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            displaytable();
        }

        private void TournamentsView_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }

        private void commitbtn_Click(object sender, EventArgs e)
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
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void rollbackbtn_Click(object sender, EventArgs e)
        {
            if (transaction != null)
            {
                try
                {
                    transaction.Rollback();
                    MessageBox.Show("Rollback successful");
                    dataGridView1.Rows.Clear();
                    displaytable();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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
                            row.CreateCells(dataGridView1, reader["tid"].ToString(), reader["tournament_title"].ToString(), reader["prize_pool"].ToString(), reader["location_id"].ToString());

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
            string temp = "select * from tournaments where ";
            if (querytb.TextLength <= temp.Length)
            {
                querytb.Text = temp;
                querytb.SelectionStart = temp.Length + 1;
            }
        }
    }
}

