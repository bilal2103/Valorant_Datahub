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
    public partial class UserForm : Form
    {
        string uname;
        private int pid;
        
        public UserForm()
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#E2D1F9");
            this.ForeColor = ColorTranslator.FromHtml("#317773");
            foreach (Control ctl in Controls)
            {
                if (ctl is TextBox)
                {
                    ctl.BackColor = ColorTranslator.FromHtml("#317773");
                    ctl.ForeColor = ColorTranslator.FromHtml("#E2D1F9");
                }
                if(ctl is Button)
                {
                    ctl.BackColor = ColorTranslator.FromHtml("#317773");
                    ctl.ForeColor = ColorTranslator.FromHtml("#E2D1F9");
                    
                }
            }
        }
        public UserForm(string uname)
        {
            InitializeComponent();
            this.uname = uname;
            if(uname != "guest")
                update_welcome_label(uname);   
            else
            {
                pw_update.Enabled= false;
                personal_btn.Enabled= false;
                pid = -1;
            }
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
        }
        private void update_welcome_label(string uname)
        {
            string query = "select player_id from users where username = @uname";
            string connection = "Data Source=BILALS-LAPPY;Initial Catalog=Valo_Data;Integrated Security=True";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("uname", uname);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int temp = Convert.ToInt32(reader["player_id"]);
            con.Close();
            con.Open();
            query = "select Pname from player where pid = @val";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("val", temp);
            reader = cmd.ExecuteReader();
            reader.Read();
            welcome_lbl.Text += $" {reader["Pname"].ToString()}!";
            con.Close();
            pid = temp;
        }
        private void weaponary_btn_Click(object sender, EventArgs e)
        {
            WeaponaryWindow w = new WeaponaryWindow();
            w.Show();
        }

        private void Leaderboards_btn_Click(object sender, EventArgs e)
        {
            Leaderboards l = new Leaderboards(pid,uname);
            l.Show();
        }

        private void Agents_btn_Click(object sender, EventArgs e)
        {
            AgentsWindow agents = new AgentsWindow();
            agents.Show();
        }

        private void Tournament_btn_Click(object sender, EventArgs e)
        {
            Before_TournamentWindow t = new Before_TournamentWindow();
            t.Show();
        }

        private void Maps_btn_Click(object sender, EventArgs e)
        {
            MapsWindow maps = new MapsWindow();
            maps.Show();
        }

        private void personal_btn_Click(object sender, EventArgs e)
        {
            statsWindow s = new statsWindow(pid);
            s.Show();
        }


        private void pwUpdate_Click(object sender, EventArgs e)
        {
            pwUpdatecs p = new pwUpdatecs(pid);
            p.Show();
        }
    }
}
