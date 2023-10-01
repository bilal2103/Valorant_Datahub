using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Valorant_Datahub
{
    public partial class Tournament_Alternate : Form
    {
        string view;
        public Tournament_Alternate()
        {
            InitializeComponent();
        }
        public Tournament_Alternate(string str)
        {
            this.view = str;
            InitializeComponent();
        }
        private void search_btn_Click(object sender, EventArgs e)
        {
            string titles = title_tb.Text;
            string location = location_tb.Text;
            string prizes = prize_tb.Text; 
            //compare lengths, if length == 0 then dont include that attribute in searching criteria.
        }

        private void Tournament_Alternate_FormClosing(object sender, FormClosingEventArgs e)
        {
            Before_TournamentWindow hehe = new Before_TournamentWindow(view);
            hehe.Show();
        }
    }
}
