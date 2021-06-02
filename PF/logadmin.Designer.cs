
namespace PF
{
    partial class logadmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(logadmin));
            this.pnlog = new System.Windows.Forms.Panel();
            this.pblog = new System.Windows.Forms.PictureBox();
            this.pbadm = new System.Windows.Forms.PictureBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtadm = new System.Windows.Forms.TextBox();
            this.txtcon = new System.Windows.Forms.TextBox();
            this.btncan = new System.Windows.Forms.Button();
            this.btning = new System.Windows.Forms.Button();
            this.pbclo = new System.Windows.Forms.PictureBox();
            this.pbmin = new System.Windows.Forms.PictureBox();
            this.pnlog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pblog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbadm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbclo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmin)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlog
            // 
            this.pnlog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(191)))), ((int)(((byte)(134)))));
            this.pnlog.Controls.Add(this.pblog);
            this.pnlog.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlog.Location = new System.Drawing.Point(0, 0);
            this.pnlog.Name = "pnlog";
            this.pnlog.Size = new System.Drawing.Size(250, 330);
            this.pnlog.TabIndex = 0;
            // 
            // pblog
            // 
            this.pblog.Image = ((System.Drawing.Image)(resources.GetObject("pblog.Image")));
            this.pblog.Location = new System.Drawing.Point(44, 92);
            this.pblog.Name = "pblog";
            this.pblog.Size = new System.Drawing.Size(159, 131);
            this.pblog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pblog.TabIndex = 0;
            this.pblog.TabStop = false;
            // 
            // pbadm
            // 
            this.pbadm.Image = ((System.Drawing.Image)(resources.GetObject("pbadm.Image")));
            this.pbadm.Location = new System.Drawing.Point(438, 12);
            this.pbadm.Name = "pbadm";
            this.pbadm.Size = new System.Drawing.Size(109, 79);
            this.pbadm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbadm.TabIndex = 1;
            this.pbadm.TabStop = false;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl1.Location = new System.Drawing.Point(272, 129);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(129, 18);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Administrador:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl2.Location = new System.Drawing.Point(293, 191);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(108, 18);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "Contraseña:";
            // 
            // txtadm
            // 
            this.txtadm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(221)))), ((int)(((byte)(191)))));
            this.txtadm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtadm.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtadm.Location = new System.Drawing.Point(416, 129);
            this.txtadm.Name = "txtadm";
            this.txtadm.Size = new System.Drawing.Size(195, 20);
            this.txtadm.TabIndex = 4;
            this.txtadm.Text = "_______________";
            // 
            // txtcon
            // 
            this.txtcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(221)))), ((int)(((byte)(191)))));
            this.txtcon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcon.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtcon.Location = new System.Drawing.Point(416, 188);
            this.txtcon.Name = "txtcon";
            this.txtcon.Size = new System.Drawing.Size(195, 20);
            this.txtcon.TabIndex = 5;
            this.txtcon.Tag = "";
            this.txtcon.Text = "_______________";
            this.txtcon.UseSystemPasswordChar = true;
            // 
            // btncan
            // 
            this.btncan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
            this.btncan.FlatAppearance.BorderSize = 0;
            this.btncan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncan.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btncan.Location = new System.Drawing.Point(293, 254);
            this.btncan.Name = "btncan";
            this.btncan.Size = new System.Drawing.Size(113, 29);
            this.btncan.TabIndex = 6;
            this.btncan.Text = "Cancel";
            this.btncan.UseVisualStyleBackColor = false;
            this.btncan.Click += new System.EventHandler(this.btncan_Click);
            // 
            // btning
            // 
            this.btning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(225)))), ((int)(((byte)(131)))));
            this.btning.FlatAppearance.BorderSize = 0;
            this.btning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btning.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btning.Location = new System.Drawing.Point(498, 254);
            this.btning.Name = "btning";
            this.btning.Size = new System.Drawing.Size(113, 29);
            this.btning.TabIndex = 7;
            this.btning.Text = "Aceptar";
            this.btning.UseVisualStyleBackColor = false;
            this.btning.Click += new System.EventHandler(this.btning_Click);
            // 
            // pbclo
            // 
            this.pbclo.Image = ((System.Drawing.Image)(resources.GetObject("pbclo.Image")));
            this.pbclo.Location = new System.Drawing.Point(703, 0);
            this.pbclo.Name = "pbclo";
            this.pbclo.Size = new System.Drawing.Size(27, 26);
            this.pbclo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbclo.TabIndex = 8;
            this.pbclo.TabStop = false;
            this.pbclo.Click += new System.EventHandler(this.pbclo_Click);
            // 
            // pbmin
            // 
            this.pbmin.Image = ((System.Drawing.Image)(resources.GetObject("pbmin.Image")));
            this.pbmin.Location = new System.Drawing.Point(663, 0);
            this.pbmin.Name = "pbmin";
            this.pbmin.Size = new System.Drawing.Size(34, 26);
            this.pbmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbmin.TabIndex = 9;
            this.pbmin.TabStop = false;
            this.pbmin.Click += new System.EventHandler(this.pbmin_Click);
            // 
            // logadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(221)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(730, 330);
            this.Controls.Add(this.pbmin);
            this.Controls.Add(this.pbclo);
            this.Controls.Add(this.btning);
            this.Controls.Add(this.btncan);
            this.Controls.Add(this.txtcon);
            this.Controls.Add(this.txtadm);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.pbadm);
            this.Controls.Add(this.pnlog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "logadmin";
            this.Opacity = 0.93D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.pnlog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pblog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbadm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbclo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlog;
        private System.Windows.Forms.PictureBox pblog;
        private System.Windows.Forms.PictureBox pbadm;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txtadm;
        private System.Windows.Forms.TextBox txtcon;
        private System.Windows.Forms.Button btncan;
        private System.Windows.Forms.Button btning;
        private System.Windows.Forms.PictureBox pbclo;
        private System.Windows.Forms.PictureBox pbmin;
    }
}