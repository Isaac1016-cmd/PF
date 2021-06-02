
namespace PF.Paneles
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.lisb = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btneli = new System.Windows.Forms.Button();
            this.btnlok = new System.Windows.Forms.Button();
            this.btnnuev = new System.Windows.Forms.Button();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.cbid = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lisb
            // 
            this.lisb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lisb.FormattingEnabled = true;
            this.lisb.ItemHeight = 18;
            this.lisb.Location = new System.Drawing.Point(456, 123);
            this.lisb.Name = "lisb";
            this.lisb.Size = new System.Drawing.Size(131, 108);
            this.lisb.TabIndex = 51;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(266, 295);
            this.dataGridView1.TabIndex = 50;
            // 
            // btneli
            // 
            this.btneli.FlatAppearance.BorderSize = 0;
            this.btneli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneli.Image = ((System.Drawing.Image)(resources.GetObject("btneli.Image")));
            this.btneli.Location = new System.Drawing.Point(642, 222);
            this.btneli.Name = "btneli";
            this.btneli.Size = new System.Drawing.Size(82, 85);
            this.btneli.TabIndex = 49;
            this.btneli.Text = "Eliminar";
            this.btneli.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btneli.UseVisualStyleBackColor = true;
            // 
            // btnlok
            // 
            this.btnlok.FlatAppearance.BorderSize = 0;
            this.btnlok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlok.Image = ((System.Drawing.Image)(resources.GetObject("btnlok.Image")));
            this.btnlok.Location = new System.Drawing.Point(650, 123);
            this.btnlok.Name = "btnlok";
            this.btnlok.Size = new System.Drawing.Size(74, 93);
            this.btnlok.TabIndex = 48;
            this.btnlok.Text = "Buscar";
            this.btnlok.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnlok.UseVisualStyleBackColor = true;
            // 
            // btnnuev
            // 
            this.btnnuev.FlatAppearance.BorderSize = 0;
            this.btnnuev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnuev.Image = ((System.Drawing.Image)(resources.GetObject("btnnuev.Image")));
            this.btnnuev.Location = new System.Drawing.Point(650, 28);
            this.btnnuev.Name = "btnnuev";
            this.btnnuev.Size = new System.Drawing.Size(74, 85);
            this.btnnuev.TabIndex = 47;
            this.btnnuev.Text = "Nuevo";
            this.btnnuev.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnnuev.UseVisualStyleBackColor = true;
            // 
            // txttotal
            // 
            this.txttotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttotal.Location = new System.Drawing.Point(456, 255);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(131, 20);
            this.txttotal.TabIndex = 46;
            // 
            // cbid
            // 
            this.cbid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbid.FormattingEnabled = true;
            this.cbid.Location = new System.Drawing.Point(456, 61);
            this.cbid.Name = "cbid";
            this.cbid.Size = new System.Drawing.Size(131, 26);
            this.cbid.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(354, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 44;
            this.label5.Text = "Venta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 43;
            this.label3.Text = "Total:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(375, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 18);
            this.label1.TabIndex = 42;
            this.label1.Text = "ID:";
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(221)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(764, 351);
            this.Controls.Add(this.lisb);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btneli);
            this.Controls.Add(this.btnlok);
            this.Controls.Add(this.btnnuev);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.cbid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registro";
            this.Text = "Registro";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lisb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btneli;
        private System.Windows.Forms.Button btnlok;
        private System.Windows.Forms.Button btnnuev;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.ComboBox cbid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}