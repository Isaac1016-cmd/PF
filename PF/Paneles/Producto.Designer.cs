
namespace PF.Paneles
{
    partial class Producto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Producto));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btneli = new System.Windows.Forms.Button();
            this.btnlok = new System.Windows.Forms.Button();
            this.btnnuev = new System.Windows.Forms.Button();
            this.txtpre = new System.Windows.Forms.TextBox();
            this.txtcant = new System.Windows.Forms.TextBox();
            this.cbid = new System.Windows.Forms.ComboBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(266, 295);
            this.dataGridView1.TabIndex = 28;
            // 
            // btneli
            // 
            this.btneli.FlatAppearance.BorderSize = 0;
            this.btneli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneli.Image = ((System.Drawing.Image)(resources.GetObject("btneli.Image")));
            this.btneli.Location = new System.Drawing.Point(638, 219);
            this.btneli.Name = "btneli";
            this.btneli.Size = new System.Drawing.Size(82, 85);
            this.btneli.TabIndex = 27;
            this.btneli.Text = "Eliminar";
            this.btneli.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btneli.UseVisualStyleBackColor = true;
            // 
            // btnlok
            // 
            this.btnlok.FlatAppearance.BorderSize = 0;
            this.btnlok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlok.Image = ((System.Drawing.Image)(resources.GetObject("btnlok.Image")));
            this.btnlok.Location = new System.Drawing.Point(646, 120);
            this.btnlok.Name = "btnlok";
            this.btnlok.Size = new System.Drawing.Size(74, 93);
            this.btnlok.TabIndex = 26;
            this.btnlok.Text = "Buscar";
            this.btnlok.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnlok.UseVisualStyleBackColor = true;
            // 
            // btnnuev
            // 
            this.btnnuev.FlatAppearance.BorderSize = 0;
            this.btnnuev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnuev.Image = ((System.Drawing.Image)(resources.GetObject("btnnuev.Image")));
            this.btnnuev.Location = new System.Drawing.Point(646, 25);
            this.btnnuev.Name = "btnnuev";
            this.btnnuev.Size = new System.Drawing.Size(74, 85);
            this.btnnuev.TabIndex = 25;
            this.btnnuev.Text = "Nuevo";
            this.btnnuev.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnnuev.UseVisualStyleBackColor = true;
            // 
            // txtpre
            // 
            this.txtpre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpre.Location = new System.Drawing.Point(452, 252);
            this.txtpre.Name = "txtpre";
            this.txtpre.Size = new System.Drawing.Size(131, 20);
            this.txtpre.TabIndex = 23;
            // 
            // txtcant
            // 
            this.txtcant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcant.Location = new System.Drawing.Point(452, 195);
            this.txtcant.Name = "txtcant";
            this.txtcant.Size = new System.Drawing.Size(131, 20);
            this.txtcant.TabIndex = 22;
            // 
            // cbid
            // 
            this.cbid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbid.FormattingEnabled = true;
            this.cbid.Location = new System.Drawing.Point(452, 58);
            this.cbid.Name = "cbid";
            this.cbid.Size = new System.Drawing.Size(131, 26);
            this.cbid.TabIndex = 21;
            // 
            // txtnom
            // 
            this.txtnom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnom.Location = new System.Drawing.Point(452, 122);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(131, 20);
            this.txtnom.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(347, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Cantidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Precio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(371, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID:";
            // 
            // Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(221)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(764, 351);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btneli);
            this.Controls.Add(this.btnlok);
            this.Controls.Add(this.btnnuev);
            this.Controls.Add(this.txtpre);
            this.Controls.Add(this.txtcant);
            this.Controls.Add(this.cbid);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Producto";
            this.Text = "Producto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btneli;
        private System.Windows.Forms.Button btnlok;
        private System.Windows.Forms.Button btnnuev;
        private System.Windows.Forms.TextBox txtpre;
        private System.Windows.Forms.TextBox txtcant;
        private System.Windows.Forms.ComboBox cbid;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}