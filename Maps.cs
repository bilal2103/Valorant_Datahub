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
            this.BackColor = ColorTranslator.FromHtml(Colors.back_color);
            foreach (Control ctl in Controls)
            {
                if (ctl is TextBox || ctl is RichTextBox)
                {
                    ctl.BackColor = ColorTranslator.FromHtml(Colors.tb_backcolor);
                    ctl.ForeColor = ColorTranslator.FromHtml(Colors.tb_forecolor);
                    ctl.Font = new Font("Franklin Gothic Medium Cond", 12, FontStyle.Regular);
                }
                if (ctl is Button)
                {
                    ctl.BackColor = ColorTranslator.FromHtml(Colors.btn_color);
                    ctl.ForeColor = ColorTranslator.FromHtml(Colors.btn_fore_color);
                    ctl.Font = new Font("Franklin Gothic Medium Cond", 12, FontStyle.Bold);
                }
                if (ctl is Label)
                {
                    ctl.ForeColor = ColorTranslator.FromHtml("#000000");
                    ctl.Font = new Font("Franklin Gothic Medium Cond", 12, FontStyle.Regular);
                }
            }
            richTextBox1.BackColor = ColorTranslator.FromHtml(Colors.back_color);
            richTextBox1.ForeColor = ColorTranslator.FromHtml("#000000");
            name_tb.Text = minfo.map_name;
            sites_tb.Text = minfo.spikesites.ToString();
            location_tb.Text = minfo.location;
            weapon_tb.Text = minfo.suited_weapon;
            richTextBox1.Text = minfo.description;

            System.Drawing.Image im = Image.FromFile(vars.image_path + minfo.map_name + ".jpg");
            pictureBox1.Image= im;
        }
    }
}
