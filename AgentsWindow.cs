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
    public partial class AgentsWindow : Form
    {
        public AgentsWindow()
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
                    ctl.Font = new Font("Franklin Gothic Medium Cond", 13, FontStyle.Regular);
                }
            }

        }
        public string agent_name;
        private void button1_Click(object sender, EventArgs e)
        {
            agent_name = textBox1.Text;
            string Query = "select * from agents where agent_name = @agent_name";
            SqlConnection con = new SqlConnection(vars.connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.CommandTimeout = 1;
            cmd.Parameters.AddWithValue("@agent_name", agent_name);
            try
            {
                SqlDataReader result = cmd.ExecuteReader();
                if (result.Read())
                {
                    float win_pct = result.GetFloat(result.GetOrdinal("win_pct"));
                    float pick_pct = result.GetFloat(result.GetOrdinal("pick_pct"));
                    AgentInformation obj = new AgentInformation(result["Agent_name"].ToString(), pick_pct, win_pct,
                        result["Tier"].ToString(), result["Role"].ToString(), result["Suited_Weapon"].ToString(), result["Ultimate"].ToString(), result["Description"].ToString(),
                        result["Voiced_by"].ToString());
                    Agent a = new Agent(obj);
                    a.Show();
                }
                else MessageBox.Show("Agent not found");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Close();


        }
    }
}
