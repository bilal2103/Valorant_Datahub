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
    public partial class WeaponaryWindow : Form
    {
        string view;
        public WeaponaryWindow()
        {
            InitializeComponent();
        }
        public WeaponaryWindow(string str)
        {
            view = str;
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string weapon_name = textBox1.Text;
            //if Exists
            this.Hide();
            Weapons w = new Weapons(view);
            w.Show();
        }

        private void WeaponaryWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                if(this.view == "Guest")
                {
                    GuestForm g = new GuestForm();
                    g.Show();
                }
                else
                {
                    UserForm u = new UserForm();
                    u.Show();
                }
            }
        }
    }
}
