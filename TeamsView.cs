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
    public partial class TeamsView : Form
    {
        public string connection;
        SqlConnection con;
        SqlTransaction transaction;
        public TeamsView()
        {
            InitializeComponent();
            connection = "Data Source=BILALS-LAPPY;Initial Catalog=Valo_Data;Integrated Security=True";
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
            con = new SqlConnection(connection);
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
            string query = "select * from teams";
            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandTimeout = 1;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridView1, reader["team_id"].ToString(), reader["team_name"].ToString(),
                        reader["matches_won"].ToString(), reader["matches_played"].ToString(),
                        reader["tournaments_won"].ToString(), reader["tournaments_played"].ToString());
                    dataGridView1.Rows.Add(row);
                }
                reader.Close();
            }
            catch(Exception)
            {
                MessageBox.Show("Dirty reads are not allowed. Please wait...");
            }

        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            string query = "insert into teams values ('" + idtxt.Text + "', '" + nametxt.Text + "','" + mwontxt.Text + "','" + mplayedtxt.Text + "','" + twontxt.Text + "','" + tplayedtxt.Text + "')";
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
            string query = "delete from teams where team_id = '" + idtxt.Text + "'";
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
            string query = $"update teams set team_name = '{nametxt.Text}',matches_played = {mplayedtxt.Text},matches_won = {mwontxt.Text}," +
                $"tournaments_won = {twontxt.Text},tournaments_played = {tplayedtxt.Text} where team_id = {idtxt.Text}";
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
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.RowCount-1)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                idtxt.Text = selectedRow.Cells["team_id"].Value.ToString();
                nametxt.Text = selectedRow.Cells["team_name"].Value.ToString();
                mwontxt.Text = selectedRow.Cells["matches_won"].Value.ToString();
                mplayedtxt.Text = selectedRow.Cells["matches_played"].Value.ToString();
                twontxt.Text = selectedRow.Cells["tournaments_won"].Value.ToString();
                tplayedtxt.Text = selectedRow.Cells["tournaments_played"].Value.ToString();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

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

        private void TeamsView_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }
    }
}
