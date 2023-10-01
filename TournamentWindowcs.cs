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
    public partial class TournamentWindow : Form
    {
        string Opened_by;
        public TournamentWindow(string str)
        {
            this.Opened_by = str;
            InitializeComponent();
            
        }
        public TournamentWindow() { }

        private void Tournament_Paint(object sender, PaintEventArgs e)
        {
            Color black = Color.FromArgb(255, 0, 0, 0);
            Pen BlackPen = new Pen(black);
            e.Graphics.DrawLine(BlackPen, 115, 575, 170, 575);
            e.Graphics.DrawLine(BlackPen, 115, 500, 170, 500);
            e.Graphics.DrawLine(BlackPen, 170, 500, 170, 575);
            e.Graphics.DrawLine(BlackPen, 170, 537, 245, 537);


            e.Graphics.DrawLine(BlackPen, 115, 420, 170, 420);
            e.Graphics.DrawLine(BlackPen, 115, 345, 170, 345);
            e.Graphics.DrawLine(BlackPen, 170, 345, 170, 420);
            e.Graphics.DrawLine(BlackPen, 170, 385, 245, 385);

            e.Graphics.DrawLine(BlackPen, 115, 265, 170, 265);
            e.Graphics.DrawLine(BlackPen, 115, 190, 170, 190);
            e.Graphics.DrawLine(BlackPen, 170, 190, 170, 265);
            e.Graphics.DrawLine(BlackPen, 170, 227, 245, 227);

            e.Graphics.DrawLine(BlackPen, 115, 100, 170, 100);
            e.Graphics.DrawLine(BlackPen, 115, 25, 170, 25);
            e.Graphics.DrawLine(BlackPen, 170, 25, 170, 100);
            e.Graphics.DrawLine(BlackPen, 170, 60, 245, 60);

            e.Graphics.DrawLine(BlackPen, 335, 60, 395, 60);
            e.Graphics.DrawLine(BlackPen, 335, 225, 395, 225);
            e.Graphics.DrawLine(BlackPen, 395, 60, 395, 225);
            e.Graphics.DrawLine(BlackPen, 395, 142, 470, 142);

            e.Graphics.DrawLine(BlackPen, 335, 390, 395, 390);
            e.Graphics.DrawLine(BlackPen, 335, 535, 395, 535);
            e.Graphics.DrawLine(BlackPen, 395, 390, 395, 535);
            e.Graphics.DrawLine(BlackPen, 395, 462, 470, 462);

            e.Graphics.DrawLine(BlackPen, 565, 462, 630, 462);
            e.Graphics.DrawLine(BlackPen, 565, 142, 630, 142);
            e.Graphics.DrawLine(BlackPen, 630, 142, 630, 462);
            e.Graphics.DrawLine(BlackPen, 630, 302, 700, 302);





        }

        private void Winner1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TournamentWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                TournamentWindow t = new TournamentWindow();
                if(Opened_by == "Guest")
                {
                    GuestForm g = new GuestForm();
                    g.Show();
                }
                else
                {
                    //UserForm u = new UserForm();
                    //u.Show();
                }
                t.Close();

            }
        }
    }
}
