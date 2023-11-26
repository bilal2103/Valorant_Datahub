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
        SqlConnection readerCon;
        SqlTransaction transaction;
        public TournamentHistoryView()
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
                if(ctl is TextBox)
                {
                    ctl.BackColor = ColorTranslator.FromHtml(Colors.tb_backcolor);
                    ctl.ForeColor = ColorTranslator.FromHtml(Colors.tb_forecolor);
                }
                if (ctl is Label)
                    ctl.ForeColor = ColorTranslator.FromHtml("#000000");
            }
            dataGridView1.RowsDefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#000000");
            try
            {
                con = new SqlConnection(connection);
                readerCon = new SqlConnection(connection);
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
            string query = "select * from tournament_history (NOLOCK)";
            readerCon.Open();
            Console.WriteLine("initializing cmd");
            try
            {
                SqlCommand cmd = new SqlCommand(query, readerCon);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridView1, reader["Tournament_id"].ToString(), reader["Match_id"].ToString(),
                        reader["match_tag"].ToString());
                    dataGridView1.Rows.Add(row);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Console.WriteLine("Done");
            
            
            readerCon.Close();
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
                MessageBox.Show("Click on commit to save your changes");
                dataGridView1.Rows.Clear();
                displaytable();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("The data that you're trying to access is locked in another transaction");
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
            if (transaction != null && transaction.Connection != null && transaction.Connection.State == System.Data.ConnectionState.Open)
                transaction.Rollback();
            con.Close();
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
