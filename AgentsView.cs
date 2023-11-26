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
        SqlConnection con,ReaderCon;
        SqlTransaction transaction;
        public AgentsView()
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
            dataGridView1.RowsDefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#000000");
            con = new SqlConnection(connection);
            ReaderCon = new SqlConnection(connection);
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
            string query = "select * from agents (NOLOCK)";
            ReaderCon.Open();
            
            SqlCommand cmd = new SqlCommand(query, ReaderCon);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1, reader["Agent_name"].ToString(), reader["Pick_pct"].ToString(), reader["Win_pct"].ToString(),
                    reader["Tier"].ToString(), reader["Role"].ToString(), reader["Suited_Weapon"].ToString(), reader["Ultimate"].ToString(),
                     reader["Voiced_by"].ToString(), reader["Description"].ToString()); 
                dataGridView1.Rows.Add(row);
            }
            ReaderCon.Close();
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
                transaction = con.BeginTransaction(IsolationLevel.ReadUncommitted);
                SqlCommand cmd = new SqlCommand(query, con, transaction);
                cmd.CommandTimeout = 3;
                cmd.ExecuteNonQuery();
                dataGridView1.Rows.Clear();
                displaytable();

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

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
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
                    transaction = con.BeginTransaction(IsolationLevel.ReadUncommitted);
                    cmd = new SqlCommand(query, con, transaction);
                    cmd.CommandTimeout = 3;
                    cmd.ExecuteNonQuery();
                    dataGridView1.Rows.Clear();
                    displaytable();
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
                transaction = con.BeginTransaction(IsolationLevel.ReadUncommitted);
                SqlCommand cmd = new SqlCommand(query, con, transaction);
                cmd.CommandTimeout = 3;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException E)
            {
                MessageBox.Show(E.Message);
                transaction.Rollback();
            }
            
            dataGridView1.Rows.Clear();
            displaytable();
        }
    }   
}
