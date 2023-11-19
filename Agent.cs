using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;

namespace Valorant_Datahub
{
    public partial class Agent : Form
    {

        int Location_id;
        public Agent(AgentInformation obj)
        {
            InitializeComponent();
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

            string image_path = "C:\\Users\\Dell\\OneDrive\\Desktop\\Valorant_Datahub_GIT\\Valorant_Datahub\\Images\\";
            switch (obj.agent_name)
            {
                case "Sage":
                case "sage":
                    image_path += "sage.jpg";
                    break;
                case "Jett":
                case "jett":
                    image_path += "jett.jpg";
                    break;
                case "Neon":
                case "neon":
                    image_path += "neon.jpg";
                    break;
            }
            System.Drawing.Image im = System.Drawing.Image.FromFile(image_path);
            agent_picture.Image = im;
            agent_picture.SizeMode = PictureBoxSizeMode.Zoom;

        }
        


    }
}
