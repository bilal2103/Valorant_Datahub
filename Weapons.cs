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
    public partial class Weapons : Form
    {
        string view;
        public Weapons()
        {
            InitializeComponent();
        }
        public void Display(WeaponsInformation w)
        {
            textBox1.Text = w.weapon_name;
            textBox2.Text = w.weapon_type;
            textBox3.Text = string.Format("{0:N3}", w.damage) + " (Headshot)";
            textBox4.Text = w.capacity.ToString();
            textBox5.Text = string.Format("{0:N3}", w.max_range) + " meters";
            frate_tb.Text = string.Format("{0:N3}", w.fire_rate) + " rounds/sec";
            cspeed_tb.Text = string.Format("{0:N3}", w.run_speed) + " meters/sec";
            fmode_tb.Text = w.fire_mode;
        }
        public Weapons(string str,WeaponsInformation w)
        {
            view = str;
            InitializeComponent();
            Display(w);
        }
        private void Weapons_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                Weapons w = new Weapons();
                WeaponaryWindow hehe = new WeaponaryWindow(view);
                hehe.Show();
                w.Close();
                
            }
        }
    }
}
