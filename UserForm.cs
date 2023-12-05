using System;
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
            
        }
        public UserForm(string uname)
        {
            InitializeComponent();
            this.uname = uname;
            
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
            if (uname != "guest")
                update_welcome_label(uname);
            else
            {
                pw_update.Enabled = false;
                personal_btn.Enabled = false;
                pid = -1;
            }
        }
        private void update_welcome_label(string uname)
        {
            string query = "select player_id from users where username = @uname";
            SqlConnection con = new SqlConnection(vars.connection);
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
        }


        private void pwUpdate_Click(object sender, EventArgs e)
        {
            pwUpdatecs p = new pwUpdatecs(pid);
            p.Show();
        }
    }
}
