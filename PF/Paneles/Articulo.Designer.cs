
namespace PF.Paneles
{
    partial class Articulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Articulo));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.cbid = new System.Windows.Forms.ComboBox();
            this.txtcant = new System.Windows.Forms.TextBox();
            this.txtpre = new System.Windows.Forms.TextBox();
            this.cbmed = new System.Windows.Forms.ComboBox();
            this.btnnuev = new System.Windows.Forms.Button();
            this.btnlok = new System.Windows.Forms.Button();
            this.btneli = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(403, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(349, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Unidad medida:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(359, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nombre:";
            // 
            // txtnom
            // 
            this.txtnom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnom.Location = new System.Drawing.Point(468, 115);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(131, 20);
            this.txtnom.TabIndex = 5;
            // 
            // cbid
            // 
            this.cbid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbid.FormattingEnabled = true;
            this.cbid.Location = new System.Drawing.Point(468, 50);
            this.cbid.Name = "cbid";
            this.cbid.Size = new System.Drawing.Size(131, 26);
            this.cbid.TabIndex = 6;
            // 
            // txtcant
            // 
            this.txtcant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcant.Location = new System.Drawing.Point(468, 211);
            this.txtcant.Name = "txtcant";
            this.txtcant.Size = new System.Drawing.Size(131, 20);
            this.txtcant.TabIndex = 8;
            // 
            // txtpre
            // 
            this.txtpre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpre.Location = new System.Drawing.Point(468, 258);
            this.txtpre.Name = "txtpre";
            this.txtpre.Size = new System.Drawing.Size(131, 20);
            this.txtpre.TabIndex = 9;
            // 
            // cbmed
            // 
            this.cbmed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbmed.FormattingEnabled = true;
            this.cbmed.Location = new System.Drawing.Point(468, 160);
            this.cbmed.Name = "cbmed";
            this.cbmed.Size = new System.Drawing.Size(131, 26);
            this.cbmed.TabIndex = 10;
            // 
            // btnnuev
            // 
            this.btnnuev.FlatAppearance.BorderSize = 0;
            this.btnnuev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnuev.Image = ((System.Drawing.Image)(resources.GetObject("btnnuev.Image")));
            this.btnnuev.Location = new System.Drawing.Point(650, 20);
            this.btnnuev.Name = "btnnuev";
            this.btnnuev.Size = new System.Drawing.Size(74, 85);
            this.btnnuev.TabIndex = 11;
            this.btnnuev.Text = "Nuevo";
            this.btnnuev.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnnuev.UseVisualStyleBackColor = true;
            // 
            // btnlok
            // 
            this.btnlok.FlatAppearance.BorderSize = 0;
            this.btnlok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlok.Image = ((System.Drawing.Image)(resources.GetObject("btnlok.Image")));
            this.btnlok.Location = new System.Drawing.Point(650, 115);
            this.btnlok.Name = "btnlok";
            this.btnlok.Size = new System.Drawing.Size(74, 93);
            this.btnlok.TabIndex = 12;
            this.btnlok.Text = "Buscar";
            this.btnlok.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnlok.UseVisualStyleBackColor = true;
            // 
            // btneli
            // 
            this.btneli.FlatAppearance.BorderSize = 0;
            this.btneli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneli.Image = ((System.Drawing.Image)(resources.GetObject("btneli.Image")));
            this.btneli.Location = new System.Drawing.Point(642, 214);
            this.btneli.Name = "btneli";
            this.btneli.Size = new System.Drawing.Size(82, 85);
            this.btneli.TabIndex = 13;
            this.btneli.Text = "Eliminar";
            this.btneli.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btneli.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(266, 295);
            this.dataGridView1.TabIndex = 14;
            // 
            // Articulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(221)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(764, 351);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btneli);
            this.Controls.Add(this.btnlok);
            this.Controls.Add(this.btnnuev);
            this.Controls.Add(this.cbmed);
            this.Controls.Add(this.txtpre);
            this.Controls.Add(this.txtcant);
            this.Controls.Add(this.cbid);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Articulo";
            this.Text = "Articulo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.ComboBox cbid;
        private System.Windows.Forms.TextBox txtcant;
        private System.Windows.Forms.TextBox txtpre;
        private System.Windows.Forms.ComboBox cbmed;
        private System.Windows.Forms.Button btnnuev;
        private System.Windows.Forms.Button btnlok;
        private System.Windows.Forms.Button btneli;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}