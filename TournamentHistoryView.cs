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
        
        SqlConnection con;
        SqlTransaction transaction;
        public TournamentHistoryView()
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
            dataGridView1.RowsDefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#000000");
            try
            {
                con = new SqlConnection(connection);
                con.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            displaytable();
        }
        private void reset_textbox()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                    control.Text = "";
            }

        }
        private void displaytable()
        {
            reset_textbox();
            string query = "select * from tournament_history";
            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandTimeout = 1;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridView1, reader["Tournament_id"].ToString(), reader["Match_id"].ToString(),
                        reader["match_tag"].ToString());
                    dataGridView1.Rows.Add(row);
                }
                reader.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Dirty reads are not allowed. Please wait...");
            }
        }
        private void insert_btn_Click(object sender, EventArgs e)
        {
            string query = $"insert into tournament_history values({tidtxt.Text},{midtxt.Text},'{tagtxt.Text}')";

            try
            {
                transaction = con.BeginTransaction(IsolationLevel.ReadUncommitted);
                SqlCommand cmd = new SqlCommand(query, con, transaction);
                cmd.CommandTimeout = 3;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Press commit to see your changes");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                transaction.Rollback();
            }

        }
        private void rollback_btn_Click(object sender, EventArgs e)
        {
            if(transaction != null)
            try 
            { 
                transaction.Rollback();
                dataGridView1.Rows.Clear();
                displaytable();
                MessageBox.Show("Rolled back successfully");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            
        }

        private void TournamentHistoryView_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            displaytable();
        }

        private void commitbtn_Click(object sender, EventArgs e)
        {
            if(transaction != null)
            try
            {
                transaction.Commit();
                dataGridView1.Rows.Clear();
                displaytable();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

    }
}
