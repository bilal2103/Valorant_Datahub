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
    public partial class Maps : Form
    {
        string view;
        public Maps()
        {
            InitializeComponent();
        }
        public Maps(string view)
        {
            this.view = view;
            InitializeComponent();
        }

        private void Maps_FormClosing(object sender, FormClosingEventArgs e)
        {
            MapsWindow m = new MapsWindow(view);
            m.Show();
            
            
        }
    }
}
