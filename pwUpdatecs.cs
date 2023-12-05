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
    public partial class pwUpdatecs : Form
    {
        int pid;
        public pwUpdatecs()
        {
            InitializeComponent();
        }
        public pwUpdatecs(int pid)
        {
            InitializeComponent();
            this.pid = pid;
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
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(vars.connection);
            string query = "select password from users where player_id = "+pid+"";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandTimeout = 1;
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader["password"].ToString() == textBox1.Text)
                {
                    reader.Close();
                    if (textBox2.Text == textBox3.Text)
                    {
                        query = "update users set password = '" + textBox2.Text + "' where player_id = " + pid + "";
                        cmd = new SqlCommand(query, con);
                        try
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Your password has been updated successfully");
                            this.Close();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("The password's length should be eight to ten characters " +
                                "and must include a special character and a digit");
                        }
                    }
                    else
                    {
                        MessageBox.Show("The new passwords don't match");
                    }
                }
                else
                {
                    MessageBox.Show("Old password incorrcet");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Dirty reads are not allowed, please wait...");
            }
            con.Close();
        }
    }
}
