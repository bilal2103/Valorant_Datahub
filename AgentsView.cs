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
        public string connection;
        public AgentsView()
        {
            InitializeComponent();
            connection = "Data Source = AIMANANANANA; Initial Catalog = Valo_Data; Integrated Security = True";
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
            }
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            string query = "select * from agents where agent_name = '" + nametxt.Text + "'";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                MessageBox.Show("Agent Name has already been taken");
            }
            else
            {
                con.Close();
                con.Open();
                query = "insert into agents values ('" + nametxt.Text + "', '" + picktxt.Text + "','" + wintxt.Text + "', '" + tiertxt.Text + "',  '" + roletxt.Text + "','" + weapontxt.Text + "','" + ultimatetxt.Text + "','" + desctxt.Text + "','" + voicetxt.Text + "')";
                cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1.Rows.Clear();
                displaytable();
            }
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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }   
}
