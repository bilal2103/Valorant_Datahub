using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Valorant_Datahub
{
    public partial class Agent : Form
    {

        int Location_id;
        public Agent(AgentInformation obj)
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
                }
            }
            About_tb.BackColor = ColorTranslator.FromHtml(Colors.back_color);
            About_tb.ForeColor = ColorTranslator.FromHtml("#000000");
            DisplayStats(obj);
        }
        public Agent()
        {
            InitializeComponent();
        }
        public void DisplayStats(AgentInformation obj)
        {
            name_tb.Text = obj.agent_name;
            win_tb.Text = string.Format("{0:N3}", obj.win_pct) + "%";
            pick_tb.Text = string.Format("{0:N3}", obj.pick_pct) + "%";
            tier_tb.Text = obj.tier;
            category_tb.Text = obj.category;
            textBox1.Text = obj.voiced_by;
            ult_tb.Text = obj.ultimate;
            weapon_tb.Text = obj.suited_weapon;
            About_tb.Text = obj.Description;
            System.Drawing.Image im;
            if(obj.agent_name == "KAY/O" || obj.agent_name == "kay/o")
                im = System.Drawing.Image.FromFile(vars.image_path  + "kayo.jpg");
            else
                im = System.Drawing.Image.FromFile(vars.image_path + obj.agent_name + ".jpg");
            agent_picture.Image = im;
            agent_picture.SizeMode = PictureBoxSizeMode.Zoom;

        }
        


    }
}
