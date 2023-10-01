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
    public partial class Before_TournamentWindow : Form
    {
        string view;
        public Before_TournamentWindow()
        {
            InitializeComponent();
        }
        public Before_TournamentWindow(string str)
        {
            view = str;
            InitializeComponent();
        }
        private void alternate_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tournament_Alternate t = new Tournament_Alternate(view);
            t.Show();
        }

        private void Before_TournamentWindow_FormClosing(object sender, FormClosingEventArgs e)
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
            this.Hide();
        }
    }
}
