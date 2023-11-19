﻿using System;
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
            string image_path = "C:\\Users\\Dell\\OneDrive\\Desktop\\Valorant_Datahub_GIT\\Valorant_Datahub\\Images\\";
            System.Drawing.Image im;
            switch (w.weapon_name)
            {
                case "vandal":
                case "Vandal":
                    im = System.Drawing.Image.FromFile(image_path+"vandal1.jpg");
                    pictureBox1.Image = im;
                    im = System.Drawing.Image.FromFile(image_path + "vandal2.jpg");
                    pictureBox2.Image = im;
                    im = System.Drawing.Image.FromFile(image_path + "vandal3.png");
                    pictureBox3.Image = im;
                    break;
                case "phantom":
                case "Phantom":
                    set_image("phantom");
                    break;
                case "sheriff":
                case "Sheriff":
                    set_image("sheriff");
                    break;
                case "operator":
                case "Operator":
                    set_image("operator");
                    break;
                case "Bulldog":
                case "bulldog":
                    set_image("bulldog");
                    break;
            }
        }
        private void set_image(string initial)
        {
            string image_path = "C:\\Users\\Dell\\OneDrive\\Desktop\\Valorant_Datahub_GIT\\Valorant_Datahub\\Images\\";
            System.Drawing.Image im;
            im = System.Drawing.Image.FromFile(image_path + $"{initial}1.jpg");
            pictureBox1.Image = im;
            im = System.Drawing.Image.FromFile(image_path + $"{initial}2.jpg");
            pictureBox2.Image = im;
            im = System.Drawing.Image.FromFile(image_path + $"{initial}3.jpg");
            pictureBox3.Image = im;
        }
        
    }
}
