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
    public partial class Maps : Form
    {
        string view;
        public Maps()
        {
            InitializeComponent();
        }
        public Maps(string view, MapInformation minfo)
        {
            this.view = view;
            InitializeComponent();
            name_tb.Text = minfo.map_name;
            sites_tb.Text = minfo.spikesites.ToString();
            teleportation_tb.Text = minfo.teleportation;
            location_tb.Text = minfo.location;
            weapon_tb.Text = minfo.suited_weapon;
            richTextBox1.Text = minfo.description;
        }

        private void Maps_FormClosing(object sender, FormClosingEventArgs e)
        {
            MapsWindow m = new MapsWindow(view);
            m.Show();
            
            
        }
    }
}
