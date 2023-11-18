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
    public partial class WeaponaryWindow : Form
    {
        string view;
        public WeaponaryWindow()
        {
            InitializeComponent();
        }
        public WeaponaryWindow(string str)
        {
            view = str;
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string weapon_name = textBox1.Text;
            string Query = "select * from weaponary where weapon_name = @weapon_name";
            string Connection = "Data Source=BILALS-LAPPY;Initial Catalog=Valo_Data;Integrated Security=True";
            SqlConnection con = new SqlConnection(Connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.Parameters.AddWithValue("@weapon_name", weapon_name);
            SqlDataReader result = cmd.ExecuteReader();
            if (result.Read())
            {
                float damage = result.GetFloat(result.GetOrdinal("Damage"));
                float fire_rate = result.GetFloat(result.GetOrdinal("fire_rate"));
                float run_speed = result.GetFloat(result.GetOrdinal("reload_speed"));
                WeaponsInformation w = new WeaponsInformation(result["Weapon_Name"].ToString(), result["Weapon_Type"].ToString(),
                    result["Fire_Mode"].ToString(), (int)result["Capacity"], (int)result["Max_Range"],
                    damage, fire_rate, run_speed);
                Weapons wWindow = new Weapons(view, w);
                wWindow.Show();
                this.Hide();
                
            }
            else MessageBox.Show("Weapon not found");
            con.Close();
        }

        private void WeaponaryWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                if(this.view == "Guest")
                {
                    GuestForm g = new GuestForm();
                    g.Show();
                }
                else
                {
                    UserForm u = new UserForm();
                    u.Show();
                }
            }
        }
    }
}
