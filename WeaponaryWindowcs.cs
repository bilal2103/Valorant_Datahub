﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Valorant_Datahub
{
    public partial class WeaponaryWindow : Form
    {
        public WeaponaryWindow()
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
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string weapon_name = textBox1.Text;
            string Query = "select * from weaponary where weapon_name = @weapon_name";
            SqlConnection con = new SqlConnection(vars.connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.CommandTimeout = 1;
            cmd.Parameters.AddWithValue("@weapon_name", weapon_name);
            try
            {
                SqlDataReader result = cmd.ExecuteReader();
                if (result.Read())
                {
                    float damage = result.GetFloat(result.GetOrdinal("Damage"));
                    float fire_rate = result.GetFloat(result.GetOrdinal("fire_rate"));
                    float reload_speed = result.GetFloat(result.GetOrdinal("reload_speed"));
                    WeaponsInformation w = new WeaponsInformation(result["Weapon_Name"].ToString(), result["Weapon_Type"].ToString(),
                        result["Fire_Mode"].ToString(), (int)result["Capacity"], (int)result["Max_Range"],
                        damage, fire_rate, reload_speed);
                    Weapons wWindow = new Weapons(w);
                    wWindow.Show();

                }
                else MessageBox.Show("Weapon not found");
            }
            catch(SqlException)
            {
                MessageBox.Show("Dirty reads are not allowed, please wait...");    
            }
            con.Close();
        }
    }
}
