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
            About_tb.BackColor = ColorTranslator.FromHtml("#E2D1F9");
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
            
            string image_path = "C:\\Users\\Dell\\OneDrive\\Desktop\\Valorant_Datahub\\Images\\";
            System.Drawing.Image im;
            if(obj.agent_name == "KAY/O" || obj.agent_name == "kay/o")
                im = System.Drawing.Image.FromFile(image_path  + "kayo.jpg");
            else
                im = System.Drawing.Image.FromFile(image_path + obj.agent_name + ".jpg");
            agent_picture.Image = im;
            agent_picture.SizeMode = PictureBoxSizeMode.Zoom;

        }
        


    }
}
