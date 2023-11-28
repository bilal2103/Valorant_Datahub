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
        public Weapons()
        {
            InitializeComponent();
        }
        public Weapons(WeaponsInformation w)
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
            Display(w);
        }
        public void Display(WeaponsInformation w)
        {
            textBox1.Text = w.weapon_name;
            textBox2.Text = w.weapon_type;
            textBox3.Text = string.Format("{0:N3}", w.damage) + " (Headshot)";
            textBox4.Text = w.capacity.ToString();
            textBox5.Text = string.Format("{0:N3}", w.max_range) + " meters";
            frate_tb.Text = string.Format("{0:N3}", w.fire_rate) + " rounds/sec";
            cspeed_tb.Text = string.Format("{0:N3}", w.reload_speed) + " sec";
            fmode_tb.Text = w.fire_mode;
            set_image(w.weapon_name);
        }
        private void set_image(string initial)
        {
            string image_path = "C:\\Users\\Dell\\OneDrive\\Desktop\\Valorant_Datahub\\Images\\";
            System.Drawing.Image im;
            im = System.Drawing.Image.FromFile(image_path + $"{initial}1.jpg");
            pictureBox1.Image = im;
            im = System.Drawing.Image.FromFile(image_path + $"{initial}2.jpg");
            pictureBox2.Image = im;
            im = System.Drawing.Image.FromFile(image_path + $"{initial}3.jpg");
            pictureBox3.Image = im;
        }

        private void Weapons_Load(object sender, EventArgs e)
        {

        }
    }
}
