using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PF
{
    public partial class Flog : Form
    {
        public Flog()
        {
            InitializeComponent();
        }

        private void btnlogadm_Click(object sender, EventArgs e)
        {
            Form logadmin = new logadmin();
            logadmin.Show();
            this.Hide();
        }

        private void btnlogemp_Click(object sender, EventArgs e)
        {
            Form logemp = new logemp();
            logemp.Show();
            this.Hide();
        }

        private void pbclo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
