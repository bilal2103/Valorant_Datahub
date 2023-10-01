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
        }
        Form1 f;
        GuestForm g;
        UserForm u;
        private void Form1_Load(object sender, EventArgs e)
        {
            f = new Form1();
            g = new GuestForm();
            u = new UserForm();
        }
        
        private void GuestButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            g.Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            u.Show();
        }
    }
}
