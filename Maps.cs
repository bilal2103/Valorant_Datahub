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
        public Maps()
        {
            InitializeComponent();
        }
        public Maps(MapInformation minfo)
        {
            InitializeComponent();
            name_tb.Text = minfo.map_name;
            sites_tb.Text = minfo.spikesites.ToString();
            location_tb.Text = minfo.location;
            weapon_tb.Text = minfo.suited_weapon;
            richTextBox1.Text = minfo.description;
        }
    }
}
