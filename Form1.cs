using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Valorant_Datahub
{
    
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            
            pictureBox1.SendToBack();
            
        }
        
        private void GuestButton_Click(object sender, EventArgs e)
        {
            UserForm u = new UserForm("guest");
            u.Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            r.Show();
        }
    }
}
