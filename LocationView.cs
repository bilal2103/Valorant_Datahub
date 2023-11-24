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
    public partial class LocationView : Form
    {
        public string connection;
        public LocationView()
        {
            InitializeComponent();
            connection = "Data Source=BILALS-LAPPY;Initial Catalog=Valo_Data;Integrated Security=True";
            displaytable();
        }
        private void ResetTextboxes()
        {
            foreach(Control ctr in this.Controls)
            {
                if (ctr is TextBox)
                    ctr.Text = "";
            }
        }
        private void displaytable()
        {
            ResetTextboxes();
            string query = "select * from location";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1, reader["location_id"].ToString(), reader["country"].ToString(),
                    reader["region"].ToString(), reader["city"].ToString());
                dataGridView1.Rows.Add(row);
            }
            con.Close();
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            string query = "select * from location where location_id = '" + locationtxt.Text + "'";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                if (reader.HasRows)
                {
                    MessageBox.Show("Location with location id " + locationtxt.Text + " already exists");
                }
                else
                {
                    con.Close();
                    con.Open();
                    query = "insert into location values ('" + locationtxt.Text + "', '" + countrytxt.Text + "','" + regiontxt.Text + "','" + citytxt.Text + "')";
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
            string query = "select * from location where location_id = '" + locationtxt.Text + "'";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (!reader.HasRows)
            {
                MessageBox.Show("No location with location ID "+locationtxt.Text+" exists");
            }
            else
            {
                con.Close();
                con.Open();
                query = "delete from location where location_id = '" + locationtxt.Text + "'";
                cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1.Rows.Clear();
                displaytable();
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            string query = $"update location set country = '{countrytxt.Text}', region = '{regiontxt.Text}', city = '{citytxt.Text}'" +
                $" where location_id = {locationtxt.Text}";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            dataGridView1.Rows.Clear();
            displaytable();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                locationtxt.Text = selectedRow.Cells["location_id"].Value.ToString();
                countrytxt.Text = selectedRow.Cells["country"].Value.ToString();
                regiontxt.Text = selectedRow.Cells["region"].Value.ToString();
                citytxt.Text = selectedRow.Cells["city"].Value.ToString();
            }
        }
    }
}
