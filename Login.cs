using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace Valorant_Datahub
{
    public partial class Login : Form
    {
        public Login()
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
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uname = textBox1.Text;
            string pw = textBox2.Text;
            string query = "select username from users where username = '"+uname+ "' COLLATE SQL_Latin1_General_CP1_CS_AS and password = '" + pw+"'";
            SqlConnection con = new SqlConnection(vars.connection);
            con.Open();
            if (uname == "admin" && pw == "admin")
            {
                AdminWindow a = new AdminWindow();
                a.Show();
            }
            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandTimeout = 1;
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        UserForm u = new UserForm(uname);
                        u.Show();
                    }
                    else
                    {
                        MessageBox.Show("Username or password is incorrect");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Dirty reads are not allowed, please wait...");
                }
            }
            con.Close();
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
