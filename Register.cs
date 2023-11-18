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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int temp;
            if (uname_tb.TextLength > 0 && pw_tb.TextLength > 0 && region_tb.TextLength > 0
                && age_tb.TextLength > 0 && gender_tb.TextLength > 0 && name_tb.TextLength > 0
                && country_tb.TextLength > 0 && city_tb.TextLength > 0 && agent_tb.TextLength > 0)
            {
                if (pw_tb.TextLength >= 8 && pw_tb.TextLength <= 10)
                {
                    string query = "select * from users where username = '" + uname_tb.Text + "'";
                    string connection = "Data Source=BILALS-LAPPY;Initial Catalog=Valo_Data;Integrated Security=True";
                    SqlConnection con = new SqlConnection(connection);
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Username has already been taken");
                    }
                    else
                    {
                        con.Close();
                        con.Open();
                        query = "select * from agents where agent_name = '" + agent_tb.Text + "'";
                        cmd = new SqlCommand(query, con);
                        reader = cmd.ExecuteReader();
                        if(reader.HasRows == false)
                        {
                            MessageBox.Show("Invalid agent name");
                        }
                        else
                        {
                            con.Close();
                            con.Open();
                            query = "select location_id from location where city = '" + city_tb.Text + "' and " +
                                "country = '" + country_tb.Text + "' and Region = '" + region_tb.Text + "'";
                            cmd = new SqlCommand(query, con);
                            reader = cmd.ExecuteReader();
                            int temp2;
                            if (reader.HasRows == false)
                            {
                                con.Close();
                                con.Open();
                                query = "select TOP 1 location_id from location order by location_id desc;";
                                cmd = new SqlCommand(query, con);
                                reader = cmd.ExecuteReader();
                                reader.Read();
                                temp2 = Convert.ToInt32(reader["location_id"]) + 1;
                                query = "insert into location values(" + temp2 + ",'" + country_tb.Text + "','" + region_tb.Text + "'" +
                                    ",'" + city_tb.Text + "')";
                                con.Close();
                                con.Open();
                                cmd = new SqlCommand(query, con);
                                cmd.ExecuteNonQuery();
                            }
                            else
                            {
                                reader.Read();
                                temp2 = Convert.ToInt32(reader["location_id"]);
                            }
                                
                            query = "select top 1 pid from player order by pid desc";
                            con.Close();
                            con.Open();
                            cmd = new SqlCommand(query, con);
                            reader = cmd.ExecuteReader();
                            reader.Read();
                            temp = Convert.ToInt32(reader["pid"]) + 1;
                            query = "insert into player values(" + temp + ",'" + name_tb.Text + "',0," + temp2 + ",'" + agent_tb.Text + "'," +
                                "'" + gender_tb.Text + "'," + Convert.ToInt32(age_tb.Text) + ")";
                            con.Close();
                            con.Open();
                            cmd = new SqlCommand(query, con);
                            cmd.ExecuteNonQuery();
                            query = "insert into users values('" + uname_tb.Text + "','"+pw_tb.Text+"',"+temp+")";
                            con.Close();
                            con.Open();
                            cmd = new SqlCommand(query, con);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show($"{name_tb.Text}, you have been registered successfully!. Your unique player_id is {temp}");
                        }
                    }
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Password's length must be between 8 to 10 characters");
                }
            }
            else MessageBox.Show("Please provide in all the required information");
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }
    }
}
