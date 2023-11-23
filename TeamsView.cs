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
        public TeamsView()
        {
            InitializeComponent();
            connection = "Data Source = AIMANANANANA; Initial Catalog = Valo_Data; Integrated Security = True";
            displaytable();
        }

        private void displaytable()
        {
            string query = "select * from teams";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1, reader["team_id"].ToString(), reader["team_name"].ToString(),
                    reader["matches_won"].ToString(), reader["matches_played"].ToString(),
                    reader["tournaments_won"].ToString(), reader["tournaments_played"].ToString());
                dataGridView1.Rows.Add(row);
            }
            con.Close();
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            string query = "select * from teams where team_id = '" + idtxt.Text + "'";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                if (reader.HasRows)
                {
                    MessageBox.Show("Team ID has already been taken");
                }
                else
                {
                    con.Close();
                    con.Open();
                    query = "insert into teams values ('" + idtxt.Text + "', '" + nametxt.Text + "','" + mwontxt.Text + "','" + mplayedtxt.Text + "','" + twontxt.Text + "','" + tplayedtxt.Text + "')";
                    cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    dataGridView1.Rows.Clear();
                    displaytable();
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
            string query = "select * from teams where team_id = '" + idtxt.Text + "'";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (!reader.HasRows)
            {
                MessageBox.Show("No team with this team ID exists");
            }
            else
            {
                con.Close();
                con.Open();
                query = "delete from teams where team_id = '" + idtxt.Text + "'";
                cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1.Rows.Clear();
                displaytable();
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tplayedtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void twontxt_TextChanged(object sender, EventArgs e)
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

        private void mplayedtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void mwontxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void picklbl_Click(object sender, EventArgs e)
        {

        }

        private void namelbl_Click(object sender, EventArgs e)
        {

        }

        private void nametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void idtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
