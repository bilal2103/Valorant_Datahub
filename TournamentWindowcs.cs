using System;
using System.Collections;
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
    public partial class TournamentWindow : Form
    {
        string connection;
        SqlConnection con;
        public TournamentWindow() { InitializeComponent(); }
        public TournamentWindow(Dictionary<string, List<MatchesInformation>> matches)
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml(Colors.back_color);
            this.ForeColor = ColorTranslator.FromHtml("#FFFFFF");

            foreach (Control ctl in Controls)
            {
                if (ctl is TextBox || ctl is RichTextBox)
                {
                    ctl.ForeColor = ColorTranslator.FromHtml(Colors.tb_backcolor);
                    ctl.BackColor = ColorTranslator.FromHtml(Colors.tb_forecolor);
                    ctl.Font =new Font("Franklin Gothic Medium Cond", 9, FontStyle.Regular);
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
            connection = "Data Source=BILALS-LAPPY;Initial Catalog=Valo_Data;Integrated Security=True";
            con = new SqlConnection(connection);
            con.Open();
            DisplayMatches(matches);
        }
        public void DisplayMatches(Dictionary<string, List<MatchesInformation>> matches)
        {
            string Query = "select T.team_name as 'First_Team',T1.team_name as 'Second_Team',T2.Team_name as 'Winner_Team'" +
                    " from teams T join matches on (T.team_id = Team1_id) join teams T1 on (T1.Team_Id = Team2_id) " +
                    "join Teams T2 on(T2.team_id = Winner_id) where match_id = @curr_id";
            SqlCommand cmd;
            
            SqlDataReader reader;

            int i = 1, j = 1;
            List<MatchesInformation> temp = new List<MatchesInformation>(matches["Quarter-Final"]);
            RichTextBox tb;
            string tb_name;
            try
            {
                foreach (var value in temp)
                {
                    tb_name = "Team" + i.ToString();
                    ++i;
                    cmd = new SqlCommand(Query, con);
                    cmd.CommandTimeout = 1;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("curr_id", value.match_id);

                    reader = cmd.ExecuteReader();
                    reader.Read();

                    tb = (RichTextBox)this.Controls.Find(tb_name, true)[0];
                    tb.Text = reader["First_Team"].ToString();
                    tb_name = "Team" + i.ToString();
                    i++;
                    tb = (RichTextBox)this.Controls.Find(tb_name, true)[0];
                    tb.Text = reader["Second_Team"].ToString();
                    tb_name = "Winner" + j.ToString();
                    j++;
                    tb = (RichTextBox)this.Controls.Find(tb_name, true)[0];
                    tb.Text = reader["Winner_Team"].ToString();
                    reader.Close();
                }

                temp = new List<MatchesInformation>(matches["Semi-Final"]);
                i = 5;
                foreach (var value in temp)
                {
                    tb_name = "Winner" + i;
                    i++;
                    tb = (RichTextBox)this.Controls.Find(tb_name, true)[0];
                    cmd = new SqlCommand(Query, con);
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("curr_id", value.match_id);
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    tb.Text = reader["Winner_Team"].ToString();
                    reader.Close();
                }
                temp = new List<MatchesInformation>(matches["Final"]);
                tb_name = "Winner";
                tb = (RichTextBox)this.Controls.Find(tb_name, true)[0];

                cmd = new SqlCommand(Query, con);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("curr_id", temp[0].match_id);
                reader = cmd.ExecuteReader();
                reader.Read();
                tb.Text = reader["Winner_Team"].ToString();
                reader.Close();
                con.Close();
            }
            catch(Exception)
            {
                MessageBox.Show("Dirty reads are not allowed, Please wait...");
            }

        }

        private void Tournament_Paint(object sender, PaintEventArgs e)
        {
            Color black = Color.FromArgb(255, 0, 0, 0);
            Pen BlackPen = new Pen(black);
            e.Graphics.DrawLine(BlackPen, 115, 575, 170, 575);
            e.Graphics.DrawLine(BlackPen, 115, 500, 170, 500);
            e.Graphics.DrawLine(BlackPen, 170, 500, 170, 575);
            e.Graphics.DrawLine(BlackPen, 170, 537, 245, 537);


            e.Graphics.DrawLine(BlackPen, 115, 420, 170, 420);
            e.Graphics.DrawLine(BlackPen, 115, 345, 170, 345);
            e.Graphics.DrawLine(BlackPen, 170, 345, 170, 420);
            e.Graphics.DrawLine(BlackPen, 170, 385, 245, 385);

            e.Graphics.DrawLine(BlackPen, 115, 265, 170, 265);
            e.Graphics.DrawLine(BlackPen, 115, 190, 170, 190);
            e.Graphics.DrawLine(BlackPen, 170, 190, 170, 265);
            e.Graphics.DrawLine(BlackPen, 170, 227, 245, 227);

            e.Graphics.DrawLine(BlackPen, 115, 100, 170, 100);
            e.Graphics.DrawLine(BlackPen, 115, 25, 170, 25);
            e.Graphics.DrawLine(BlackPen, 170, 25, 170, 100);
            e.Graphics.DrawLine(BlackPen, 170, 60, 245, 60);

            e.Graphics.DrawLine(BlackPen, 335, 60, 395, 60);
            e.Graphics.DrawLine(BlackPen, 335, 225, 395, 225);
            e.Graphics.DrawLine(BlackPen, 395, 60, 395, 225);
            e.Graphics.DrawLine(BlackPen, 395, 142, 470, 142);

            e.Graphics.DrawLine(BlackPen, 335, 390, 395, 390);
            e.Graphics.DrawLine(BlackPen, 335, 535, 395, 535);
            e.Graphics.DrawLine(BlackPen, 395, 390, 395, 535);
            e.Graphics.DrawLine(BlackPen, 395, 462, 470, 462);

            e.Graphics.DrawLine(BlackPen, 565, 462, 630, 462);
            e.Graphics.DrawLine(BlackPen, 565, 142, 630, 142);
            e.Graphics.DrawLine(BlackPen, 630, 142, 630, 462);
            e.Graphics.DrawLine(BlackPen, 630, 302, 700, 302);
        }

    }
}
