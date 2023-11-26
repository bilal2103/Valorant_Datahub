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
    public partial class MapsView : Form
    {
        public string connection;
        public MapsView()
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
            displaytable();
        }
        private void displaytable()
        {
            string query = "select * from maps";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1, reader["Map_name"].ToString(), reader["Spike_sites"].ToString(), 
                    reader["Suited_Weapon"].ToString(), reader["Location_id"].ToString(),
                     reader["Description"].ToString());
                dataGridView1.Rows.Add(row);
            }
            con.Close();
        }

        private void weapontxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            string query = "select * from maps where map_name = '" + nametxt.Text + "'";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                if (reader.HasRows)
                {
                    MessageBox.Show("Map Name has already been taken");
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
                            query = "insert into maps values ('" + nametxt.Text + "', '" + sitestxt.Text + "','" + weapontxt.Text + "','" + locationtxt.Text + "','" + desctxt.Text + "')";
                            cmd = new SqlCommand(query, con);
                            cmd.ExecuteNonQuery();
                            dataGridView1.Rows.Clear();
                            displaytable();
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get data from the selected row and fill textboxes
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                
                nametxt.Text = selectedRow.Cells["name"].Value.ToString();
                sitestxt.Text = selectedRow.Cells["spike_sites"].Value.ToString();
                weapontxt.Text = selectedRow.Cells["suited_weapon"].Value.ToString();
                locationtxt.Text = selectedRow.Cells["location_id"].Value.ToString();
                desctxt.Text = selectedRow.Cells["description"].Value.ToString();
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            string query = "select * from maps where map_name = '" + nametxt.Text + "'";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (!reader.HasRows)
            {
                MessageBox.Show("No map with this name exists");
            }
            else
            {
                con.Close();
                con.Open();
                query = "delete from maps where map_name = '" + nametxt.Text + "'";
                cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                dataGridView1.Rows.Clear();
                displaytable();
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            string query = $"update maps set spike_sites = '{sitestxt.Text}',suited_weapon = '{weapontxt.Text}'," +
                $"location_id = {locationtxt.Text},Description = '{desctxt.Text}' where map_name = '{nametxt.Text}'";
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
    }
}
