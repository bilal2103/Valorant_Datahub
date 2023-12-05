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
        private string last_weapon_clicked;
        SqlConnection con;
        SqlTransaction transaction;
        public WeaponsView()
        {
            InitializeComponent();
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
            con = new SqlConnection(vars.connection);
            con.Open();
            displaytable();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.RowCount - 1)
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
            string query = $"insert into weaponary values('{wnametxt.Text}','{wtypetxt.Text}',{Convert.ToInt32(capacitytxt.Text)}," +
                $"{Convert.ToInt32(dmgtxt.Text)},{Convert.ToDouble(fratetxt.Text)},{Convert.ToDouble(rspeedtxt.Text)},'{fmodetxt.Text}'," +
                $"{Convert.ToInt32(m_rangetxt.Text)})";
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

        private void deletebtn_Click(object sender, EventArgs e)
        {
            string query = $"delete from weaponary where weapon_name = '{last_weapon_clicked}'";
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

        private void updatebtn_Click(object sender, EventArgs e)
        {
            string query = $"update weaponary set weapon_name = '{wnametxt.Text}',weapon_type = '{wtypetxt.Text}'," +
                $"capacity = {Convert.ToInt32(capacitytxt.Text)},damage = {Convert.ToInt32(dmgtxt.Text)},fire_rate = {Convert.ToDouble(fratetxt.Text)}," +
                $"reload_speed = {Convert.ToDouble(rspeedtxt.Text)},fire_mode = '{fmodetxt.Text}'," +
                $"max_range = {Convert.ToInt32(m_rangetxt.Text)} where weapon_name = '{last_weapon_clicked}'";
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

        private void commitbtn_Click(object sender, EventArgs e)
        {
            if (transaction != null)
            {
                try
                {
                    transaction.Commit();
                    MessageBox.Show("Commit Successful");
                    dataGridView1.Rows.Clear();
                    displaytable();
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

        private void rollbackbtn_Click(object sender, EventArgs e)
        {
            if (transaction != null)
            {
                try
                {
                    transaction.Rollback();
                    MessageBox.Show("Rollback Successful");
                    dataGridView1.Rows.Clear();
                    displaytable();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void WeaponsView_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }

        private void displaytable()
        {
            reset_textboxes();
            string query = "select * from weaponary";
            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandTimeout = 1;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridView1, reader["weapon_name"].ToString(), reader["weapon_type"].ToString(), reader["capacity"].ToString(),
                    reader["Damage"].ToString(), reader["fire_rate"].ToString(), reader["reload_speed"].ToString(), reader["fire_mode"].ToString(),
                    reader["max_range"].ToString());
                    dataGridView1.Rows.Add(row);
                }
                reader.Close();
                this.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Dirty reads are not allowed. Please wait...");
            }
            
        }
    }
}
