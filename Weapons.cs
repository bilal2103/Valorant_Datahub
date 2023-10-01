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
    public partial class Weapons : Form
    {
        string view;
        public Weapons()
        {
            InitializeComponent();
        }
        public Weapons(string str)
        {
            view = str;
            InitializeComponent();
        }
        private void Weapons_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                Weapons w = new Weapons();
                WeaponaryWindow hehe = new WeaponaryWindow(view);
                hehe.Show();
                w.Close();
                
            }
        }
    }
}
