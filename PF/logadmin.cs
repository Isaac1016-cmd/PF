using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PF
{
    public partial class logadmin : Form
    {
        public logadmin()
        {
            InitializeComponent();
        }

        private void btncan_Click(object sender, EventArgs e)
        {
            Form Form1 = new Flog();
            Form1.Show();
            this.Close();
        }

        private void pbclo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btning_Click(object sender, EventArgs e)
        {
            Form admun = new Admin();
            admun.Show();
            this.Close();
        }
    }
}
