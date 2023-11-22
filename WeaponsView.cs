using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Valorant_Datahub
{
    public partial class WeaponsView : Form
    {
        private string connection, last_weapon_clicked;
        public WeaponsView()
        {
            InitializeComponent();
            this.connection = "Data Source=BILALS-LAPPY;Initial Catalog=Valo_Data;Integrated Security=True";
            displaytable();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get data from the selected row and fill textboxes
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                reset_textboxes();
                wnametxt.Text = selectedRow.Cells["wname"].Value.ToString();
                wtypetxt.Text = selectedRow.Cells["wtype"].Value.ToString();
                capacitytxt.Text = selectedRow.Cells["capacity"].Value.ToString();
                dmgtxt.Text = selectedRow.Cells["dmg"].Value.ToString();
                fratetxt.Text = selectedRow.Cells["frate"].Value.ToString();
                m_rangetxt.Text = selectedRow.Cells["max_range"].Value.ToString();
                fmodetxt.Text = selectedRow.Cells["fmode"].Value.ToString();
                rspeedtxt.Text = selectedRow.Cells["rspeed"].Value.ToString();
                last_weapon_clicked = wnametxt.Text;
            }
        }
        private void reset_textboxes()
        {
            wnametxt.Text = "";
            wtypetxt.Text = ""; capacitytxt.Text = ""; dmgtxt.Text = ""; fratetxt.Text = "";
            m_rangetxt.Text = ""; fmodetxt.Text = ""; rspeedtxt.Text = "";
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection);
            string query = $"insert into weaponary values('{wnametxt.Text}','{wtypetxt.Text}',{Convert.ToInt32(capacitytxt.Text)}," +
                $"{Convert.ToInt32(dmgtxt.Text)},{Convert.ToDouble(fratetxt.Text)},{Convert.ToDouble(rspeedtxt.Text)},'{fmodetxt.Text}'," +
                $"{Convert.ToInt32(m_rangetxt.Text)})";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            Console.WriteLine(cmd.CommandText);
            try
            {
                cmd.ExecuteNonQuery();
                reset_textboxes();
                dataGridView1.Rows.Clear();
                displaytable();

            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            string query = $"delete from weaponary where weapon_name = '{last_weapon_clicked}'";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                cmd.ExecuteNonQuery();
                reset_textboxes();
                dataGridView1.Rows.Clear();
                displaytable();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            string query = $"update weaponary set weapon_name = '{wnametxt.Text}',weapon_type = '{wtypetxt.Text}'," +
                $"capacity = {Convert.ToInt32(capacitytxt.Text)},damage = {Convert.ToInt32(dmgtxt.Text)},fire_rate = {Convert.ToDouble(fratetxt.Text)}," +
                $"reload_speed = {Convert.ToDouble(rspeedtxt.Text)},fire_mode = '{fmodetxt.Text}'," +
                $"max_range = {Convert.ToInt32(m_rangetxt.Text)} where weapon_name = '{last_weapon_clicked}'";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            Console.WriteLine(cmd.CommandText);
            try
            {
                cmd.ExecuteNonQuery();
                reset_textboxes();
                dataGridView1.Rows.Clear();
                displaytable();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void displaytable()
        {
            string query = "select * from weaponary";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1, reader["weapon_name"].ToString(), reader["weapon_type"].ToString(), reader["capacity"].ToString(),
                    reader["Damage"].ToString(), reader["fire_rate"].ToString(), reader["reload_speed"].ToString(), reader["fire_mode"].ToString(),
                    reader["max_range"].ToString());
                dataGridView1.Rows.Add(row);
            }
            con.Close();
        }
    }
}
