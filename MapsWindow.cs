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
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string map_name = name_tb.Text;
            string Connection = "Data Source=BILALS-LAPPY;Initial Catalog=Valo_Data;Integrated Security=True";
            SqlConnection con = new SqlConnection(Connection);
            con.Open();
            string Query = "Select map_name,spike_sites,suited_weapon,country,description" +
                " from maps join location on(maps.Location_id = location.Location_id) where map_name=@map_name";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.Parameters.AddWithValue("@map_name", map_name);
            SqlDataReader result = cmd.ExecuteReader();
            if (result.Read())
            {
                MapInformation obj = new MapInformation(result["Map_name"].ToString(), (int)result["Spike_sites"]
                , result["Suited_Weapon"].ToString(), result["country"].ToString(), result["Description"].ToString());
                Maps m = new Maps(obj);
                m.Show();
            }
            else MessageBox.Show("Map not found");
            con.Close();
        }
    }
}
