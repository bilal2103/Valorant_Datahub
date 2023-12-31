﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Valorant_Datahub
{
    public partial class Tournament_Alternate : Form
    {
        public Tournament_Alternate()
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml(Colors.back_color);
            this.ForeColor = ColorTranslator.FromHtml("#FFFFFF");

            foreach (Control ctl in Controls)
            {
                if (ctl is TextBox || ctl is RichTextBox)
                {
                    ctl.BackColor = ColorTranslator.FromHtml(Colors.tb_backcolor);
                    ctl.ForeColor = ColorTranslator.FromHtml(Colors.tb_forecolor);
                    ctl.Font = new Font("Franklin Gothic Medium Cond", 9, FontStyle.Regular);
                }
                if (ctl is Button)
                {
                    ctl.BackColor = ColorTranslator.FromHtml(Colors.btn_color);
                    ctl.ForeColor = ColorTranslator.FromHtml(Colors.btn_fore_color);
                    ctl.Font = new Font("Franklin Gothic Medium Cond", 10, FontStyle.Bold);
                }
                if (ctl is Label)
                {
                    ctl.ForeColor = ColorTranslator.FromHtml("#000000");
                    ctl.Font = new Font("Franklin Gothic Medium Cond", 11, FontStyle.Regular);
                }
            }

        }
        private void AddQuotes(ref string str)
        {
            char ch = '\'';
            StringBuilder s = new StringBuilder(str);
            for(int i=0;i<s.Length;i++)
            {
                s.Insert(i, ch);
                while (i<s.Length && s[i] != ',') i++;
                s.Insert(i, ch);
                i++;
            }
            str = s.ToString();
        }
        private void search_btn_Click(object sender, EventArgs e)
        {
            string titles = title_tb.Text;
            string locations = location_tb.Text;
            string prizes = prize_tb.Text;
            dataGridView1.Rows.Clear();
            dataGridView1.Visible = false;
            AddQuotes(ref locations);
            AddQuotes(ref titles);
            string query = "";
            
            SqlConnection con = new SqlConnection(vars.connection);
            con.Open();
            query = "select location_id from location where Country in (" + locations + ")";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandTimeout = 1;
            string location_ids = "";
            SqlDataReader reader;
            try
            {
                if (locations.Length > 0)
                {
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {

                        while (reader.Read())
                        {
                            location_ids += reader["location_id"].ToString();
                            location_ids += ",";
                        }
                        location_ids = location_ids.Substring(0, location_ids.Length - 1);
                    }
                    else Console.WriteLine("No corresponding locations");
                }
                con.Close();
                con.Open();
                if (titles.Length > 0) titles = ',' + titles;
                if (prizes.Length > 0) prizes = ',' + prizes;
                if (location_ids.Length > 0) location_ids = ',' + location_ids;
                query = "select * from tournaments where location_id in (''" + location_ids + ") or " +
                    "prize_pool in(''" + prizes + ") or tournament_title in (''" + titles + ")";
                cmd = new SqlCommand(query, con);
                cmd.CommandTimeout = 1;
                Console.WriteLine(cmd.CommandText);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    dataGridView1.Visible = true;
                    while (reader.Read())
                    {

                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(dataGridView1, reader["Tid"].ToString(), reader["Tournament_title"].ToString());
                        dataGridView1.Rows.Add(row);
                    }
                }
                con.Close();
            }
            catch(Exception)
            {
                MessageBox.Show("Dirty reads are not allowed, please wait...");
            }
            
        }
    }
}
