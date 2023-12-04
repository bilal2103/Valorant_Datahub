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
            this.BackColor = ColorTranslator.FromHtml(Colors.back_color);
            this.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            foreach (Control ctl in Controls)
            {
                if (ctl is TextBox || ctl is RichTextBox)
                {
                    ctl.ForeColor = ColorTranslator.FromHtml(Colors.tb_forecolor);
                    ctl.BackColor = ColorTranslator.FromHtml(Colors.tb_backcolor);
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
            int temp;
            if (uname_tb.TextLength > 0 && pw_tb.TextLength > 0
                && age_tb.TextLength > 0 && gender_tb.TextLength > 0 && name_tb.TextLength > 0
                && country_tb.TextLength > 0 && city_tb.TextLength > 0)
            {
                if (region_tb.TextLength == 0) region_tb.Text = "Unkown";
                if (agent_tb.TextLength == 0) agent_tb.Text = "Sage";
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
                    if (reader.HasRows == false)
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
                            Console.WriteLine("No need to add location");
                            reader.Read();
                            temp2 = Convert.ToInt32(reader["location_id"]);
                        }

                        query = "select top 1 pid from player join users on(player.pid = users.player_id) order by pid desc";
                        con.Close();
                        con.Open();
                        cmd = new SqlCommand(query, con);
                        reader = cmd.ExecuteReader();
                        reader.Read();
                        temp = Convert.ToInt32(reader["pid"]) + 1;
                        con.Close();
                        con.Open();
                        query = "insert into player values(" + temp + ",'" + name_tb.Text + "'," + temp2 + ",'" + agent_tb.Text + "'," +
                            "'" + gender_tb.Text + "'," + Convert.ToInt32(age_tb.Text) + ",0,0,0)";
                        cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        try
                        {

                            query = "insert into users values('" + uname_tb.Text + "','" + pw_tb.Text + "'," + temp + ")";
                            con.Open();
                            cmd = new SqlCommand(query, con);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show($"{name_tb.Text}, you have been registered successfully!. Your unique player_id is {temp}");
                            this.Close();
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("The password should be 8 to 10 characters long and must " +
                                "include a digit and a special character");
                            query = "delete from player where pid = " + temp + "";
                            con.Close();
                            con.Open();
                            cmd= new SqlCommand(query, con);
                            cmd.ExecuteNonQuery();
                        }

                    }
                }
                con.Close();

            }
            else MessageBox.Show("Please provide in all the required information");
        }
    }
}
