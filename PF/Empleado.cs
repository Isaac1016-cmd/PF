using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PF
{
    public partial class Empleado : Form
    {

        private Button btnctual;
        private Random random;
        private int tempI;
        private Form Formactiv;
        public Empleado()
        {
            InitializeComponent();
            random = new Random();
            btnclo.Visible = false;
            timer1.Enabled = true;
        }

        private Color Seleccionacolor()
        {
            int ind = random.Next(ThemeColor.ColorList.Count);
            while (tempI == ind)
            {
                ind = random.Next(ThemeColor.ColorList.Count);
            }
            tempI = ind;
            string col = ThemeColor.ColorList[ind];
            return ColorTranslator.FromHtml(col);
        }

        private void BtnActivo(object btnSender)
        {
            if (btnSender != null)
            {
                if (btnctual != (Button)btnSender)
                {
                    btndisble();
                    Color color = Seleccionacolor();
                    btnctual = (Button)btnSender;
                    btnctual.BackColor = color;
                    btnctual.ForeColor = Color.White;
                    btnctual.Font = new System.Drawing.Font("Verdana", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                    pntit.BackColor = color;
                    pnlogem.BackColor = ThemeColor.CambioBrillo(color, -0.3);
                    btnclo.Visible = true;
                }
            }
        }

        private void btndisble()
        {
            foreach (Control prevbtn in pnlmenem.Controls)
            {
                if (prevbtn.GetType() == typeof(Button))
                {
                    prevbtn.BackColor = Color.FromArgb(151, 191, 134);
                    prevbtn.ForeColor = Color.Black;
                    prevbtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                }
            }
        }

        private void formasgene(Form Formhij, object btnSender)
        {
            if (Formactiv != null)
            {
                Formactiv.Close();
            }
            BtnActivo(btnSender);
            Formactiv = Formhij;
            Formhij.TopLevel = false;
            Formhij.FormBorderStyle = FormBorderStyle.None;
            Formhij.Dock = DockStyle.Fill;
            this.pnfor.Controls.Add(Formhij);
            this.pnfor.Tag = Formhij;
            Formhij.BringToFront();
            Formhij.Show();
            lbltil.Text = Formhij.Text;
        }

        private void btnpro_Click(object sender, EventArgs e)
        {
            formasgene(new Paneles.Producto(), sender);
        }

        private void btnvent_Click(object sender, EventArgs e)
        {
            formasgene(new Paneles.Venta(), sender);
        }

        private void btnreg_Click(object sender, EventArgs e)
        {
            formasgene(new Paneles.Registro(), sender);
        }

        private void btnclo_Click(object sender, EventArgs e)
        {
            if (Formactiv != null)
            {
                Formactiv.Close();
            }
            Reset();
        }

        private void Reset()
        {
            btndisble();
            lbltil.Text = "Empleado";
            pntit.BackColor = Color.FromArgb(115, 156, 98);
            pnlogem.BackColor = Color.FromArgb(115, 156, 98);
            btnctual = null;
            btnclo.Visible = false;
        }

        private void pbexi_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhor.Text = DateTime.Now.ToString("hh:mm:ss");
            lblf.Text = DateTime.Now.ToLongDateString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form f = new Flog();
            f.Show();
            this.Close();
        }
    }
}
