
namespace PF
{
    partial class Empleado
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Empleado));
            this.pnlmenem = new System.Windows.Forms.Panel();
            this.btnreg = new System.Windows.Forms.Button();
            this.btnvent = new System.Windows.Forms.Button();
            this.btnpro = new System.Windows.Forms.Button();
            this.pnlogem = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pntit = new System.Windows.Forms.Panel();
            this.pbmin = new System.Windows.Forms.PictureBox();
            this.pbexi = new System.Windows.Forms.PictureBox();
            this.btnclo = new System.Windows.Forms.Button();
            this.lbltil = new System.Windows.Forms.Label();
            this.pnfor = new System.Windows.Forms.Panel();
            this.lblf = new System.Windows.Forms.Label();
            this.lblhor = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlmenem.SuspendLayout();
            this.pnlogem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pntit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbexi)).BeginInit();
            this.pnfor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlmenem
            // 
            this.pnlmenem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(191)))), ((int)(((byte)(134)))));
            this.pnlmenem.Controls.Add(this.btnreg);
            this.pnlmenem.Controls.Add(this.btnvent);
            this.pnlmenem.Controls.Add(this.btnpro);
            this.pnlmenem.Controls.Add(this.pnlogem);
            this.pnlmenem.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlmenem.Location = new System.Drawing.Point(0, 0);
            this.pnlmenem.Name = "pnlmenem";
            this.pnlmenem.Size = new System.Drawing.Size(220, 470);
            this.pnlmenem.TabIndex = 0;
            // 
            // btnreg
            // 
            this.btnreg.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnreg.FlatAppearance.BorderSize = 0;
            this.btnreg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreg.Image = ((System.Drawing.Image)(resources.GetObject("btnreg.Image")));
            this.btnreg.Location = new System.Drawing.Point(0, 224);
            this.btnreg.Name = "btnreg";
            this.btnreg.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnreg.Size = new System.Drawing.Size(220, 72);
            this.btnreg.TabIndex = 3;
            this.btnreg.Text = "Registro";
            this.btnreg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnreg.UseVisualStyleBackColor = true;
            this.btnreg.Click += new System.EventHandler(this.btnreg_Click);
            // 
            // btnvent
            // 
            this.btnvent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnvent.FlatAppearance.BorderSize = 0;
            this.btnvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvent.Image = ((System.Drawing.Image)(resources.GetObject("btnvent.Image")));
            this.btnvent.Location = new System.Drawing.Point(0, 152);
            this.btnvent.Name = "btnvent";
            this.btnvent.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnvent.Size = new System.Drawing.Size(220, 72);
            this.btnvent.TabIndex = 2;
            this.btnvent.Text = "Ventas";
            this.btnvent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnvent.UseVisualStyleBackColor = true;
            this.btnvent.Click += new System.EventHandler(this.btnvent_Click);
            // 
            // btnpro
            // 
            this.btnpro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnpro.FlatAppearance.BorderSize = 0;
            this.btnpro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpro.Image = ((System.Drawing.Image)(resources.GetObject("btnpro.Image")));
            this.btnpro.Location = new System.Drawing.Point(0, 80);
            this.btnpro.Name = "btnpro";
            this.btnpro.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnpro.Size = new System.Drawing.Size(220, 72);
            this.btnpro.TabIndex = 1;
            this.btnpro.Text = "Productos";
            this.btnpro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnpro.UseVisualStyleBackColor = true;
            this.btnpro.Click += new System.EventHandler(this.btnpro_Click);
            // 
            // pnlogem
            // 
            this.pnlogem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(156)))), ((int)(((byte)(98)))));
            this.pnlogem.Controls.Add(this.pictureBox1);
            this.pnlogem.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlogem.Location = new System.Drawing.Point(0, 0);
            this.pnlogem.Name = "pnlogem";
            this.pnlogem.Size = new System.Drawing.Size(220, 80);
            this.pnlogem.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(57, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pntit
            // 
            this.pntit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(156)))), ((int)(((byte)(98)))));
            this.pntit.Controls.Add(this.pbmin);
            this.pntit.Controls.Add(this.pbexi);
            this.pntit.Controls.Add(this.btnclo);
            this.pntit.Controls.Add(this.lbltil);
            this.pntit.Dock = System.Windows.Forms.DockStyle.Top;
            this.pntit.Location = new System.Drawing.Point(220, 0);
            this.pntit.Name = "pntit";
            this.pntit.Size = new System.Drawing.Size(780, 80);
            this.pntit.TabIndex = 1;
            // 
            // pbmin
            // 
            this.pbmin.Image = ((System.Drawing.Image)(resources.GetObject("pbmin.Image")));
            this.pbmin.Location = new System.Drawing.Point(721, 0);
            this.pbmin.Name = "pbmin";
            this.pbmin.Size = new System.Drawing.Size(26, 26);
            this.pbmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbmin.TabIndex = 15;
            this.pbmin.TabStop = false;
            this.pbmin.Click += new System.EventHandler(this.pbmin_Click);
            // 
            // pbexi
            // 
            this.pbexi.Image = ((System.Drawing.Image)(resources.GetObject("pbexi.Image")));
            this.pbexi.Location = new System.Drawing.Point(753, 0);
            this.pbexi.Name = "pbexi";
            this.pbexi.Size = new System.Drawing.Size(27, 26);
            this.pbexi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbexi.TabIndex = 14;
            this.pbexi.TabStop = false;
            this.pbexi.Click += new System.EventHandler(this.pbexi_Click);
            // 
            // btnclo
            // 
            this.btnclo.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnclo.FlatAppearance.BorderSize = 0;
            this.btnclo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclo.Image = ((System.Drawing.Image)(resources.GetObject("btnclo.Image")));
            this.btnclo.Location = new System.Drawing.Point(0, 0);
            this.btnclo.Name = "btnclo";
            this.btnclo.Size = new System.Drawing.Size(35, 80);
            this.btnclo.TabIndex = 2;
            this.btnclo.UseVisualStyleBackColor = true;
            this.btnclo.Click += new System.EventHandler(this.btnclo_Click);
            // 
            // lbltil
            // 
            this.lbltil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbltil.AutoSize = true;
            this.lbltil.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbltil.Location = new System.Drawing.Point(300, 26);
            this.lbltil.Name = "lbltil";
            this.lbltil.Size = new System.Drawing.Size(130, 29);
            this.lbltil.TabIndex = 1;
            this.lbltil.Text = "Empleado";
            // 
            // pnfor
            // 
            this.pnfor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(221)))), ((int)(((byte)(191)))));
            this.pnfor.Controls.Add(this.lblf);
            this.pnfor.Controls.Add(this.lblhor);
            this.pnfor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnfor.Location = new System.Drawing.Point(220, 80);
            this.pnfor.Name = "pnfor";
            this.pnfor.Size = new System.Drawing.Size(780, 390);
            this.pnfor.TabIndex = 2;
            // 
            // lblf
            // 
            this.lblf.AutoSize = true;
            this.lblf.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(56)))), ((int)(((byte)(53)))));
            this.lblf.Location = new System.Drawing.Point(189, 144);
            this.lblf.Name = "lblf";
            this.lblf.Size = new System.Drawing.Size(98, 35);
            this.lblf.TabIndex = 3;
            this.lblf.Text = "Fecha";
            // 
            // lblhor
            // 
            this.lblhor.AutoSize = true;
            this.lblhor.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblhor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(95)))), ((int)(((byte)(146)))));
            this.lblhor.Location = new System.Drawing.Point(180, 99);
            this.lblhor.Name = "lblhor";
            this.lblhor.Size = new System.Drawing.Size(107, 45);
            this.lblhor.TabIndex = 2;
            this.lblhor.Text = "Hora";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1000, 470);
            this.Controls.Add(this.pnfor);
            this.Controls.Add(this.pntit);
            this.Controls.Add(this.pnlmenem);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Empleado";
            this.Opacity = 0.97D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleado";
            this.pnlmenem.ResumeLayout(false);
            this.pnlogem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pntit.ResumeLayout(false);
            this.pntit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbexi)).EndInit();
            this.pnfor.ResumeLayout(false);
            this.pnfor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlmenem;
        private System.Windows.Forms.Panel pnlogem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pntit;
        private System.Windows.Forms.Label lbltil;
        private System.Windows.Forms.Button btnclo;
        private System.Windows.Forms.Panel pnfor;
        private System.Windows.Forms.Button btnreg;
        private System.Windows.Forms.Button btnvent;
        private System.Windows.Forms.Button btnpro;
        private System.Windows.Forms.Label lblf;
        private System.Windows.Forms.Label lblhor;
        private System.Windows.Forms.PictureBox pbmin;
        private System.Windows.Forms.PictureBox pbexi;
        private System.Windows.Forms.Timer timer1;
    }
}