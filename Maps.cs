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
            this.BackColor = ColorTranslator.FromHtml("#E2D1F9");
            this.ForeColor = ColorTranslator.FromHtml("#317773");
            foreach (Control ctl in Controls)
            {
                if (ctl is TextBox || ctl is Button)
                {
                    ctl.BackColor = ColorTranslator.FromHtml("#317773");
                    ctl.ForeColor = ColorTranslator.FromHtml("#E2D1F9");
                }
            }
            richTextBox1.BackColor = ColorTranslator.FromHtml("#E2D1F9");
            name_tb.Text = minfo.map_name;
            sites_tb.Text = minfo.spikesites.ToString();
            location_tb.Text = minfo.location;
            weapon_tb.Text = minfo.suited_weapon;
            richTextBox1.Text = minfo.description;
            string image_path = "C:\\Users\\Dell\\OneDrive\\Desktop\\Valorant_Datahub\\Images\\";

            System.Drawing.Image im = Image.FromFile(image_path + minfo.map_name + ".jpg");
            pictureBox1.Image= im;
        }
    }
}
