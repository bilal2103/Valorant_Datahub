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
    public partial class TournamentsView : Form
    {
        public string connection;
        public TournamentsView()
        {
            InitializeComponent();
            connection = "Data Source = AIMANANANANA; Initial Catalog = Valo_Data; Integrated Security = True";
            displaytable();
        }

        private void displaytable()
        {
            string query = "select * from tournaments";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1, reader["tid"].ToString(), reader["tournament_title"].ToString(),
                    reader["prize_pool"].ToString(), reader["location_id"].ToString());
                dataGridView1.Rows.Add(row);
            }
            con.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                idtxt.Text = selectedRow.Cells["tid"].Value.ToString();
                titletxt.Text = selectedRow.Cells["tournament_title"].Value.ToString();
                prizetxt.Text = selectedRow.Cells["prize_pool"].Value.ToString();
                locationtxt.Text = selectedRow.Cells["location_id"].Value.ToString();
            }
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            string query = "select * from tournaments where tid = '" + idtxt.Text + "'";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                MessageBox.Show("Tournament with TID "+idtxt.Text+" already exists");
            }
            else
            {
                con.Close();
                con.Open();
                query = "select * from location where location_id = '" + locationtxt.Text + "'";
                cmd = new SqlCommand(query, con);
                reader = cmd.ExecuteReader();
                if (!reader.HasRows)
                {
                    MessageBox.Show("Location with location id " + locationtxt.Text + " does not exist.");
                }
                else
                {
                    con.Close();
                    con.Open();
                    query = "insert into tournaments values ('" + idtxt.Text + "', '" + prizetxt.Text + "','" + locationtxt.Text + "','" + titletxt.Text + "')";
                    cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    dataGridView1.Rows.Clear();
                    displaytable();
                }
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            string query = "select * from tournaments where tid = '" + idtxt.Text + "'";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (!reader.HasRows)
            {
                MessageBox.Show("No tournament with this TID exists");
            }
            else
            {
                con.Close();
                con.Open();
                query = "delete from tournaments where tid = '" + idtxt.Text + "'";
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
    }
}
