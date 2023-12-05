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
    public partial class LocationView : Form
    {
        SqlConnection con;
        SqlTransaction transaction;
        public LocationView()
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
                }
            }
            con = new SqlConnection(vars.connection);
            con.Open();
            displaytable();
        }
        private void ResetTextboxes()
        {
            foreach (Control ctr in this.Controls)
            {
                if (ctr is TextBox)
                    ctr.Text = "";
            }
        }
        private void displaytable()
        {
            ResetTextboxes();
            string query = "select * from location where location_id != 999";
            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandTimeout = 1;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridView1, reader["location_id"].ToString(), reader["country"].ToString(),
                    reader["region"].ToString(), reader["city"].ToString());
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
            string query = "insert into location values ('" + locationtxt.Text + "', '" + countrytxt.Text + "','" + regiontxt.Text + "','" + citytxt.Text + "')";
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
            string query = "delete from location where location_id = '" + locationtxt.Text + "'";
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
            string query = $"update location set country = '{countrytxt.Text}', region = '{regiontxt.Text}', city = '{citytxt.Text}'" +
                $" where location_id = {locationtxt.Text}";
            try
            {
                transaction = con.BeginTransaction(IsolationLevel.ReadCommitted);
                SqlCommand cmd = new SqlCommand(query, con,transaction);
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

        private void LocationView_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
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

        private void rollback_btn_Click(object sender, EventArgs e)
        {
            if(transaction != null)
            {
                try
                {
                    transaction.Rollback();
                    MessageBox.Show("Rollback Successful");
                    dataGridView1.Rows.Clear();
                    displaytable();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            displaytable();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.RowCount - 1)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                locationtxt.Text = selectedRow.Cells["location_id"].Value.ToString();
                countrytxt.Text = selectedRow.Cells["country"].Value.ToString();
                regiontxt.Text = selectedRow.Cells["region"].Value.ToString();
                citytxt.Text = selectedRow.Cells["city"].Value.ToString();
            }
        }
    }
}
