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
        private int last_pid;
        SqlConnection con;
        SqlTransaction transaction;
        string last_op;
        public PlayerView()
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
            dataGridView1.RowsDefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#000000");
            con = new SqlConnection(vars.connection);
            con.Open();
            displaytable();
        }
        private void reset_textboxes()
        {

            idtxt.Text = "";
            unametxt.Text = ""; nametxt.Text = ""; gendertxt.Text = ""; agetxt.Text = "";
            agentxt.Text = ""; mmrtxt.Text = ""; killstxt.Text = ""; deathstxt.Text = ""; locationtxt.Text = ""; tidtxt.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.RowCount - 1)
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
            foreach(Control ctl in Controls)
            {
                if (ctl is TextBox) ctl.Text = "";
            }
            string query = "select * from player  join users  on(player.pid = users.player_id) left outer join " +
                "PLAYER_TEAM on(PLAYER_TEAM.Player_ID = player.pid)order by player.pid asc";
            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandTimeout = 1;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DataGridViewRow row = new DataGridViewRow();
                    string team_id = reader["team_id"].ToString();
                    if (team_id.Length == 0) team_id = "-";
                    row.CreateCells(dataGridView1, reader["pid"].ToString(), reader["username"].ToString(), reader["pname"].ToString(),
                        team_id, reader["gender"].ToString(), reader["age"].ToString(), reader["fav_agent"].ToString(), reader["MMR"].ToString(),
                        reader["kills"].ToString(), reader["deaths"].ToString(), reader["location_id"].ToString());
                    dataGridView1.Rows.Add(row);
                }
                reader.Close();
                    this.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Dirty reads are not allowed. Please wait...");
            }
            
            
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            string query = "insert into player values(" + Convert.ToInt32(idtxt.Text) + ",'" + nametxt.Text + "'," +
               "" + Convert.ToInt32(locationtxt.Text) + ",'" + agentxt.Text + "','" + gendertxt.Text + "'," + Convert.ToInt32(agetxt.Text) + "," +
               "" + Convert.ToInt32(mmrtxt.Text) + "," + Convert.ToInt32(killstxt.Text) + "," + Convert.ToInt32(deathstxt.Text) + ")";
            try
            {
                transaction = con.BeginTransaction(IsolationLevel.ReadCommitted);
                SqlCommand cmd = new SqlCommand(query, con, transaction);
                cmd.CommandTimeout = 10;
                cmd.ExecuteNonQuery();
                if (tidtxt.Text != "-")
                {
                    query = $"insert into player_team values({Convert.ToInt32(idtxt.Text)},{Convert.ToInt32(tidtxt.Text)})";
                    cmd = new SqlCommand(query, con, transaction);
                    cmd.ExecuteNonQuery();
                }
                query = "insert into users values('" + unametxt.Text + "','default9*'," + Convert.ToInt32(idtxt.Text) + ")";
                cmd = new SqlCommand(query, con, transaction);
                cmd.ExecuteNonQuery();
                
                MessageBox.Show("Press commit to see your changes");
                last_op = "insert";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                transaction.Rollback();
            }
        }
        private void deletebtn_Click(object sender, EventArgs e)
        {
            string query = "delete from player where pid = " + Convert.ToInt32(idtxt.Text) + "";
            try
            {
                transaction = con.BeginTransaction(IsolationLevel.ReadCommitted);
                SqlCommand cmd = new SqlCommand(query, con, transaction);
                cmd.CommandTimeout = 1;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Press commit to see your changes");
                last_op = "delete";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                transaction.Rollback();
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            string query = $"update player set pid = {Convert.ToInt32(idtxt.Text)},Pname = '{nametxt.Text}'," +
                $"location_id = {Convert.ToInt32(locationtxt.Text)},fav_agent = '{agentxt.Text}',gender = '{gendertxt.Text}'," +
                $"age = {Convert.ToInt32(agetxt.Text)},mmr = {Convert.ToInt32(mmrtxt.Text)},kills = {Convert.ToInt32(killstxt.Text)}," +
                $"deaths = {Convert.ToInt32(deathstxt.Text)} where pid = {last_pid}";
            try
            {
                transaction = con.BeginTransaction(IsolationLevel.ReadCommitted);
                SqlCommand cmd = new SqlCommand(query, con, transaction);
                cmd.CommandTimeout = 1;
                cmd.ExecuteNonQuery();
                query = $"select team_id from player_team where player_id = {last_pid}";
                cmd = new SqlCommand(query, con, transaction);
                SqlDataReader reader = cmd.ExecuteReader();
                query = "";
                if (reader.HasRows)
                {
                    if (tidtxt.Text == "-")
                        query = $"delete from player_team where player_id = {last_pid}";
                    else
                        query = $"update player_team set team_id = {tidtxt.Text} where player_id = {last_pid}";
                }
                else if (tidtxt.Text != "-")
                {
                    query = $"insert into player_team values({last_pid},{tidtxt.Text})";
                }
                reader.Close();
                if (query != "")
                {
                    cmd = new SqlCommand(query, con, transaction);
                    cmd.ExecuteNonQuery();
                }
                query = $"update users set username = '{unametxt.Text}' where player_id = {idtxt.Text}";
                cmd = new SqlCommand(query, con, transaction);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Press commit to see your changes");
                last_op = "update";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                transaction.Rollback();
            }
        }

        private void commit_btn_Click(object sender, EventArgs e)
        {
            if (transaction != null)
            {
                try
                {
                    transaction.Commit();
                    if(last_op == "insert")
                    MessageBox.Show($"{nametxt.Text} has been registered successfully.they can log on to the portal using " +
                    $"the username and password: 'default9*'. they should update this password upon login!");
                    dataGridView1.Rows.Clear();
                    displaytable();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            displaytable();
        }

        private void rollback_btn_Click(object sender, EventArgs e)
        {
            if (transaction != null)
            {
                try
                {
                    transaction.Rollback();
                    MessageBox.Show("Rollback Successful");
                    dataGridView1.Rows.Clear();
                    displaytable();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
