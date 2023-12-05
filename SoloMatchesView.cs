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
        SqlConnection con;
        SqlTransaction transaction;
        public SoloMatchesView()
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
            dataGridView1.RowsDefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#000000");
            con = new SqlConnection(vars.connection);
            con.Open();
            displaytable();
        }

        private void displaytable()
        {
            foreach (Control ctl in Controls)
            {
                if (ctl is TextBox) ctl.Text = "";
            }
            string query = "select * from solo_matches order by match_id";
            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandTimeout = 1;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridView1, reader["match_id"].ToString(), reader["kills"].ToString(),
                        reader["deaths"].ToString(), reader["result"].ToString(),
                        reader["agent_played"].ToString(), reader["map_name"].ToString(), reader["player_id"].ToString());
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
            string query = "insert into solo_matches values ('" + midtxt.Text + "', '" + killstxt.Text + "','" + deathstxt.Text + "', '" + resulttxt.Text + "',  '" + agenttxt.Text + "','" + maptxt.Text + "','" + pidtxt.Text + "')";
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

        private void SoloMatchesView_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
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

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            displaytable();
        }
    }
}
