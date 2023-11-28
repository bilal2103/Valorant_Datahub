using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Valorant_Datahub
{
    public partial class MapsWindow : Form
    {
        public MapsWindow()
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
                    ctl.Font = new Font("Franklin Gothic Medium Cond", 12, FontStyle.Regular);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string map_name = name_tb.Text;
            string Connection = "Data Source=BILALS-LAPPY;Initial Catalog=Valo_Data;Integrated Security=True";
            SqlConnection con = new SqlConnection(Connection);
            con.Open();
            string Query = $"Select map_name,spike_sites,suited_weapon,country,description" +
                $" from maps join location on(maps.Location_id = location.Location_id) where map_name='{map_name}'";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.CommandTimeout= 1;
            Console.WriteLine(map_name);
            Console.WriteLine(cmd.CommandText);
            try
            {
                SqlDataReader result = cmd.ExecuteReader();
                if (result.Read())
                {
                    MapInformation obj = new MapInformation(result["Map_name"].ToString(), (int)result["Spike_sites"]
                    , result["Suited_Weapon"].ToString(), result["country"].ToString(), result["Description"].ToString());
                    Maps m = new Maps(obj);
                    m.Show();
                }
                else MessageBox.Show("Map not found");
            }
            catch(Exception)
            {
                MessageBox.Show("Dirty reads are not allowed, Please wait...");
            }
            con.Close();
        }
    }
}
