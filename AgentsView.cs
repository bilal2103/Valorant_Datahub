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
        public AgentsView()
        {
            InitializeComponent();
            connection = "Data Source=BILALS-LAPPY;Initial Catalog=Valo_Data;Integrated Security=True";
            displaytable();
            
        }
        private void displaytable()
        {
            string query = "select * from agents";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1, reader["Agent_name"].ToString(), reader["Pick_pct"].ToString(), reader["Win_pct"].ToString(),
                    reader["Tier"].ToString(), reader["Role"].ToString(), reader["Suited_Weapon"].ToString(), reader["Ultimate"].ToString(),
                     reader["Description"].ToString(), reader["Voiced_by"].ToString()); 
                dataGridView1.Rows.Add(row);
            }
            con.Close();
        }
        private void AgentsView_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
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
            string query = "select * from agents where agent_name = '" + nametxt.Text + "'";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                if (reader.HasRows)
                {
                    MessageBox.Show("Agent Name has already been taken");
                }
                else
                {
                    con.Close();
                    con.Open();
                    query = "select * from weaponary where weapon_name = '" + weapontxt.Text + "'";
                    cmd = new SqlCommand(query, con);
                    reader = cmd.ExecuteReader();
                    if (!reader.HasRows)
                    {
                        MessageBox.Show("Weapon with this name does not exist.");
                    }
                    else
                    {
                        con.Close();
                        con.Open();
                        query = "insert into agents values ('" + nametxt.Text + "', '" + picktxt.Text + "','" + wintxt.Text + "', '" + tiertxt.Text + "',  '" + roletxt.Text + "','" + weapontxt.Text + "','" + ultimatetxt.Text + "','" + desctxt.Text + "','" + voicetxt.Text + "')";
                        cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                        dataGridView1.Rows.Clear();
                        displaytable();
                    }
                    con.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            string query = "select * from agents where agent_name = '" + nametxt.Text + "'";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (!reader.HasRows)
            {
              MessageBox.Show("No agent with this name exists");
            }
            else
            {
                con.Close();
                con.Open();
                query = "delete from agents where agent_name = '" + nametxt.Text + "'"; 
                cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1.Rows.Clear();
                displaytable();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void voicetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void desctxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ultimatetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void weapontxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void roletxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void tiertxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void winlbl_Click(object sender, EventArgs e)
        {

        }

        private void picklbl_Click(object sender, EventArgs e)
        {

        }

        private void namelbl_Click(object sender, EventArgs e)
        {

        }

        private void wintxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void picktxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void nametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            string query = "update agents set pick_pct = '" + picktxt.Text + "'," +
                "win_pct = '" + wintxt.Text + "',tier = '" + tiertxt.Text + "',Role='" + roletxt.Text + "',Suited_weapon='" + weapontxt.Text + "'," +
                "Description = '" + desctxt.Text + "',Voiced_by = '" + voicetxt.Text + "' where agent_name = '" + last_Agent_clicked + "'";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException E)
            {
                MessageBox.Show(E.Message);
            }
            con.Close();
            dataGridView1.Rows.Clear();
            displaytable();
        }
    }   
}
