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
    public partial class MapsWindow : Form
    {
        string view;
        public MapsWindow()
        {
            InitializeComponent();
        }
        public MapsWindow(string str)
        {
            InitializeComponent();
            view = str;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //if exists
            string map_name = name_tb.Text;
            Maps map = new Maps(view);
            this.Hide();
            map.Show();
        }

        private void MapsWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                if(view == "Guest")
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
