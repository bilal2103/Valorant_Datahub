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
    public partial class MapsView : Form
    {
        SqlConnection con;
        SqlTransaction transaction;
        public MapsView()
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
            foreach (Control ctl in Controls)
            {
                if (ctl is TextBox)
                {
                    if(ctl.Name == "querytb") querytb.Text = "select * from maps where ";
                    else ctl.Text = "";
                }
            }
            string query = "select * from maps";
            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandTimeout = 1;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridView1, reader["map_name"].ToString(), reader["spike_sites"].ToString(),
                        reader["suited_weapon"].ToString(), reader["location_id"].ToString(),
                        reader["description"].ToString());
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

        private void insert_btn_Click(object sender, EventArgs e)
        {
            string query = "insert into maps values ('" + nametxt.Text + "', '" + sitestxt.Text + "','" + weapontxt.Text + "','" + locationtxt.Text + "','" + desctxt.Text + "')";
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.RowCount - 1)
            {
                // Get data from the selected row and fill textboxes
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                nametxt.Text = selectedRow.Cells["name"].Value.ToString();
                sitestxt.Text = selectedRow.Cells["spike_sites"].Value.ToString();
                weapontxt.Text = selectedRow.Cells["suited_weapon"].Value.ToString();
                locationtxt.Text = selectedRow.Cells["location_id"].Value.ToString();
                desctxt.Text = selectedRow.Cells["description"].Value.ToString();
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            string query = $"delete from maps where map_name = '{nametxt.Text}'";
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
            string query = $"update maps set spike_sites = '{sitestxt.Text}',suited_weapon = '{weapontxt.Text}'," +
                $"location_id = {locationtxt.Text},Description = '{desctxt.Text}' where map_name = '{nametxt.Text}'";
            try
            {
                transaction = con.BeginTransaction(IsolationLevel.ReadCommitted);
                SqlCommand cmd = new SqlCommand(query, con, transaction);
                cmd.CommandTimeout = 1;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Press commit to see your changes");
                Console.WriteLine(transaction.Connection.State);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                transaction.Rollback();
            }
        }

        private void commit_btn_Click(object sender, EventArgs e)
        {
            if (transaction != null)
            {
                try
                {
                    transaction.Commit();
                    MessageBox.Show("Commit Successful");
                    dataGridView1.Rows.Clear();
                    displaytable();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void MapsView_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            displaytable();
        }

        private void rollback_btn_Click(object sender, EventArgs e)
        {
            if (transaction != null)
            {
                try
                {
                    transaction.Rollback();
                    MessageBox.Show("Rollback Successful");
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
                            row.CreateCells(dataGridView1, reader["map_name"].ToString(), reader["spike_sites"].ToString(),
                                reader["suited_weapon"].ToString(), reader["location_id"].ToString(),
                                reader["description"].ToString());
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
            string temp = "select * from maps where ";
            if (querytb.TextLength <= temp.Length)
            {
                querytb.Text = temp;
                querytb.SelectionStart = temp.Length;
            }
        }
    }
}
