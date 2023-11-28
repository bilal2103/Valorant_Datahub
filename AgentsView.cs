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
    public partial class AgentsView : Form
    {
        public string connection, last_Agent_clicked;
        SqlConnection con;
        SqlTransaction transaction;
        public AgentsView()
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
            con = new SqlConnection(connection);
            con.Open();
            displaytable();
            
        }
        private void ResetTextBoxes()
        {
            foreach(Control c in Controls)
            {
                if (c is TextBox) c.Text = "";
            }
        }
        private void displaytable()
        {
            ResetTextBoxes();
            string query = "select * from agents";
            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandTimeout = 1;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridView1, reader["agent_name"].ToString(), reader["pick_pct"].ToString(),
                        reader["win_pct"].ToString(), reader["tier"].ToString(),
                        reader["role"].ToString(), reader["suited_weapon"].ToString(), reader["ultimate"].ToString()
                        , reader["voiced_by"].ToString(), reader["description"].ToString());
                    dataGridView1.Rows.Add(row);
                }
                reader.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Dirty reads are not allowed. Please wait...");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get data from the selected row and fill textboxes
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                nametxt.Text = "";
                picktxt.Text = ""; wintxt.Text = ""; tiertxt.Text = ""; roletxt.Text = "";
                weapontxt.Text = ""; ultimatetxt.Text = ""; desctxt.Text = ""; voicetxt.Text = "";
                nametxt.Text = selectedRow.Cells["name"].Value.ToString();
                picktxt.Text = selectedRow.Cells["pick_pct"].Value.ToString();
                wintxt.Text = selectedRow.Cells["win_pct"].Value.ToString();
                tiertxt.Text = selectedRow.Cells["tier"].Value.ToString();
                roletxt.Text = selectedRow.Cells["role"].Value.ToString();
                weapontxt.Text = selectedRow.Cells["suited_weapon"].Value.ToString();
                ultimatetxt.Text = selectedRow.Cells["ultimate"].Value.ToString();
                desctxt.Text = selectedRow.Cells["description"].Value.ToString();
                voicetxt.Text = selectedRow.Cells["voiced_by"].Value.ToString();
                last_Agent_clicked = nametxt.Text;
            }
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            string query = $"insert into agents values('{nametxt.Text}',{picktxt.Text},{wintxt.Text}," +
                $"'{tiertxt.Text}','{roletxt.Text}','{weapontxt.Text}','{ultimatetxt.Text}','{desctxt.Text}','{voicetxt.Text}')";
            
            try
            {
                transaction = con.BeginTransaction(IsolationLevel.ReadCommitted);
                SqlCommand cmd = new SqlCommand(query, con, transaction);
                cmd.CommandTimeout = 1;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Press commit to see your changes");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                transaction.Rollback(); 
            }
        }

        private void AgentsView_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }

        private void commit_btn_Click(object sender, EventArgs e)
        {
            if(transaction != null)
            {
                try
                {
                    transaction.Commit();
                    dataGridView1.Rows.Clear();
                    displaytable();
                    MessageBox.Show("Commit successful");

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void rollback_btn_Click(object sender, EventArgs e)
        {
            if (transaction != null)
            {
                try
                {
                    transaction.Rollback();
                    dataGridView1.Rows.Clear();
                    displaytable();
                    MessageBox.Show("Rollback successful");

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

        private void deletebtn_Click(object sender, EventArgs e)
        {
            string query = "select * from agents (NOLOCK) where agent_name = '" + nametxt.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (!reader.HasRows)
            {
              MessageBox.Show("No agent with this name exists");
            }
            else
            {
                reader.Close();
                query = "delete from agents where agent_name = '" + nametxt.Text + "'";
                try
                {
                    transaction = con.BeginTransaction(IsolationLevel.ReadCommitted);
                    cmd = new SqlCommand(query, con, transaction);
                    cmd.CommandTimeout = 1;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Press commit to see your changes");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    transaction.Rollback();
                }
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            string query = "update agents set pick_pct = '" + picktxt.Text + "'," +
                "win_pct = '" + wintxt.Text + "',tier = '" + tiertxt.Text + "',Role='" + roletxt.Text + "',Suited_weapon='" + weapontxt.Text + "'," +
                "Description = '" + desctxt.Text + "',Voiced_by = '" + voicetxt.Text + "' where agent_name = '" + last_Agent_clicked + "'";
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
    }   
}
