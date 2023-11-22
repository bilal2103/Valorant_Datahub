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
    public partial class PlayerView : Form
    {
        private string connection = "Data Source=BILALS-LAPPY;Initial Catalog=Valo_Data;Integrated Security=True";
        private int last_pid;
        public PlayerView()
        {
            InitializeComponent();
            displaytable();
        }
        private void reset_textboxes()
        {

            idtxt.Text = "";
            unametxt.Text = ""; nametxt.Text = ""; gendertxt.Text = ""; agetxt.Text = "";
            agentxt.Text = ""; mmrtxt.Text = ""; killstxt.Text = ""; deathstxt.Text = ""; locationtxt.Text = "";tidtxt.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get data from the selected row and fill textboxes
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                reset_textboxes();
                idtxt.Text = selectedRow.Cells["id"].Value.ToString();
                unametxt.Text = selectedRow.Cells["username"].Value.ToString();
                nametxt.Text = selectedRow.Cells["name"].Value.ToString();
                gendertxt.Text = selectedRow.Cells["gender"].Value.ToString();
                agetxt.Text = selectedRow.Cells["age"].Value.ToString();
                agentxt.Text = selectedRow.Cells["agent"].Value.ToString();
                killstxt.Text = selectedRow.Cells["kills"].Value.ToString();
                deathstxt.Text = selectedRow.Cells["deaths"].Value.ToString();
                locationtxt.Text = selectedRow.Cells["location"].Value.ToString();
                mmrtxt.Text = selectedRow.Cells["mmr"].Value.ToString();
                tidtxt.Text = selectedRow.Cells["team"].Value.ToString();
                last_pid = Convert.ToInt32(idtxt.Text);
            }
        }
        private void displaytable()
        {
            string query = "select * from player join users on(player.pid = users.player_id) left outer join " +
                "PLAYER_TEAM on(PLAYER_TEAM.Player_ID = player.pid)order by player.pid asc";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                DataGridViewRow row = new DataGridViewRow();
                string team_id = reader["team_id"].ToString();
                if (team_id.Length == 0) team_id = "-";
                row.CreateCells(dataGridView1, reader["pid"].ToString(), reader["username"].ToString(), reader["pname"].ToString(),
                    team_id,reader["gender"].ToString(), reader["age"].ToString(), reader["fav_agent"].ToString(), reader["MMR"].ToString(),
                    reader["kills"].ToString(), reader["deaths"].ToString(), reader["location_id"].ToString());
                dataGridView1.Rows.Add(row);
            }
            con.Close();
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {

            string query = "insert into player values(" + Convert.ToInt32(idtxt.Text) + ",'" + nametxt.Text + "'," +
                "" + Convert.ToInt32(locationtxt.Text) + ",'" + agentxt.Text + "','" + gendertxt.Text + "'," + Convert.ToInt32(agetxt.Text) + "," +
                "" + Convert.ToInt32(mmrtxt.Text) + "," + Convert.ToInt32(killstxt.Text) + "," + Convert.ToInt32(deathstxt.Text) + ")";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                Console.WriteLine(cmd.CommandText);
                cmd.ExecuteNonQuery();
                Console.WriteLine("First query executed");
                query = $"insert into player_team values({Convert.ToInt32(idtxt.Text)},{Convert.ToInt32(tidtxt.Text)})";
                con.Close();
                con.Open();
                cmd = new SqlCommand(query, con);
                try
                {
                    cmd.ExecuteNonQuery();
                    query = "insert into users values('" + unametxt.Text + "','default9*'," + Convert.ToInt32(idtxt.Text) + ")";
                    con.Close();
                    con.Open();
                    cmd = new SqlCommand(query, con);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"Welcome {nametxt.Text},You have been registered successfully.You can log on to the portal using " +
                        $"your username and password: 'default9*'. Make sure to update this password when you login!");
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                        query = "delete from player where pid = " + idtxt.Text + "";
                        con.Close();
                        con.Open();
                        cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch(SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                    con.Open();
                    cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            dataGridView1.Rows.Clear();
            reset_textboxes();
            displaytable();

        }
        private void deletebtn_Click(object sender, EventArgs e)
        {
            string query = "delete from player where pid = " + Convert.ToInt32(idtxt.Text) + "";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("The player and the corresponding user has been deleted successfully");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            dataGridView1.Rows.Clear();
            reset_textboxes(); displaytable();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            string query = $"update users set username = '{unametxt.Text}' where player_id = {last_pid}";
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                cmd.ExecuteNonQuery();
                query = $"update player set pid = {Convert.ToInt32(idtxt.Text)},Pname = '{nametxt.Text}'," +
                $"location_id = {Convert.ToInt32(locationtxt.Text)},fav_agent = '{agentxt.Text}',gender = '{gendertxt.Text}'," +
                $"age = {Convert.ToInt32(agetxt.Text)},mmr = {Convert.ToInt32(mmrtxt.Text)},kills = {Convert.ToInt32(killstxt.Text)}," +
                $"deaths = {Convert.ToInt32(deathstxt.Text)} where pid = {last_pid}";
                con.Close();
                con.Open();
                cmd = new SqlCommand(query, con);

                
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            query = $"select team_id from player_team where player_id = {last_pid}";
            con.Open();
            cmd = new SqlCommand(query, con);
            SqlDataReader reader= cmd.ExecuteReader();
            if(reader.HasRows)
            {
                
            }
            dataGridView1.Rows.Clear();
            reset_textboxes(); displaytable();
        }
    }
}
