
namespace PF
{
    partial class Flog
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Flog));
            this.pnlog = new System.Windows.Forms.Panel();
            this.pbmin = new System.Windows.Forms.PictureBox();
            this.pbclo = new System.Windows.Forms.PictureBox();
            this.pblog = new System.Windows.Forms.PictureBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.btnlogadm = new System.Windows.Forms.Button();
            this.btnlogemp = new System.Windows.Forms.Button();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.pnlog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbclo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pblog)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlog
            // 
            this.pnlog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(191)))), ((int)(((byte)(134)))));
            this.pnlog.Controls.Add(this.pbmin);
            this.pnlog.Controls.Add(this.pbclo);
            this.pnlog.Controls.Add(this.pblog);
            this.pnlog.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlog.Location = new System.Drawing.Point(0, 0);
            this.pnlog.Name = "pnlog";
            this.pnlog.Size = new System.Drawing.Size(550, 128);
            this.pnlog.TabIndex = 0;
            // 
            // pbmin
            // 
            this.pbmin.Image = ((System.Drawing.Image)(resources.GetObject("pbmin.Image")));
            this.pbmin.Location = new System.Drawing.Point(491, 0);
            this.pbmin.Name = "pbmin";
            this.pbmin.Size = new System.Drawing.Size(26, 26);
            this.pbmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbmin.TabIndex = 11;
            this.pbmin.TabStop = false;
            this.pbmin.Click += new System.EventHandler(this.pbmin_Click);
            // 
            // pbclo
            // 
            this.pbclo.Image = ((System.Drawing.Image)(resources.GetObject("pbclo.Image")));
            this.pbclo.Location = new System.Drawing.Point(523, 0);
            this.pbclo.Name = "pbclo";
            this.pbclo.Size = new System.Drawing.Size(27, 26);
            this.pbclo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbclo.TabIndex = 10;
            this.pbclo.TabStop = false;
            this.pbclo.Click += new System.EventHandler(this.pbclo_Click);
            // 
            // pblog
            // 
            this.pblog.Image = ((System.Drawing.Image)(resources.GetObject("pblog.Image")));
            this.pblog.Location = new System.Drawing.Point(200, 12);
            this.pblog.Name = "pblog";
            this.pblog.Size = new System.Drawing.Size(140, 105);
            this.pblog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pblog.TabIndex = 0;
            this.pblog.TabStop = false;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb1.Location = new System.Drawing.Point(200, 144);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(128, 25);
            this.lb1.TabIndex = 1;
            this.lb1.Text = "Bienvenido";
            this.lb1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Verdana", 13.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl2.Location = new System.Drawing.Point(150, 190);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(230, 23);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Seleccione un usuario:";
            // 
            // btnlogadm
            // 
            this.btnlogadm.AutoSize = true;
            this.btnlogadm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnlogadm.BackgroundImage")));
            this.btnlogadm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnlogadm.FlatAppearance.BorderSize = 0;
            this.btnlogadm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogadm.Location = new System.Drawing.Point(103, 276);
            this.btnlogadm.Name = "btnlogadm";
            this.btnlogadm.Size = new System.Drawing.Size(87, 78);
            this.btnlogadm.TabIndex = 3;
            this.btnlogadm.UseVisualStyleBackColor = true;
            this.btnlogadm.Click += new System.EventHandler(this.btnlogadm_Click);
            // 
            // btnlogemp
            // 
            this.btnlogemp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnlogemp.BackgroundImage")));
            this.btnlogemp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnlogemp.FlatAppearance.BorderSize = 0;
            this.btnlogemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogemp.Location = new System.Drawing.Point(332, 273);
            this.btnlogemp.Margin = new System.Windows.Forms.Padding(1);
            this.btnlogemp.Name = "btnlogemp";
            this.btnlogemp.Size = new System.Drawing.Size(97, 81);
            this.btnlogemp.TabIndex = 4;
            this.btnlogemp.UseVisualStyleBackColor = true;
            this.btnlogemp.Click += new System.EventHandler(this.btnlogemp_Click);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl3.Location = new System.Drawing.Point(96, 357);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(94, 14);
            this.lbl3.TabIndex = 5;
            this.lbl3.Text = "Administrador";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl4.Location = new System.Drawing.Point(347, 355);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(69, 14);
            this.lbl4.TabIndex = 6;
            this.lbl4.Text = "Empleado";
            // 
            // Flog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(221)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(550, 443);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.btnlogemp);
            this.Controls.Add(this.btnlogadm);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.pnlog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Flog";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.pnlog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbclo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pblog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlog;
        private System.Windows.Forms.PictureBox pblog;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button btnlogadm;
        private System.Windows.Forms.Button btnlogemp;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.PictureBox pbmin;
        private System.Windows.Forms.PictureBox pbclo;
    }
}

