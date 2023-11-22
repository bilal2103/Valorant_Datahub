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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uname = textBox1.Text;
            string pw = textBox2.Text;
            string query = "select username from users where username = '"+uname+"' and password = '"+pw+"'";
            string connection = "Data Source=BILALS-LAPPY;Initial Catalog=Valo_Data;Integrated Security=True";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            
            SqlCommand cmd = new SqlCommand(query, con);
            Console.WriteLine(cmd.CommandText);
            SqlDataReader reader = cmd.ExecuteReader(); 
            if(reader.HasRows)
            {
                UserForm u = new UserForm(uname);
                u.Show();
            }
            else if(uname=="admin" && pw== "admin"){
                AdminWindow a = new AdminWindow();
                a.Show();
            }
            else
            {
                MessageBox.Show("Username or password is incorrect");
            }
            con.Close();
        }
    }
}
