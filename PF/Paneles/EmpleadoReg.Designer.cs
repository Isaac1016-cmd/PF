
namespace PF.Paneles
{
    partial class EmpleadoReg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpleadoReg));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtpat = new System.Windows.Forms.TextBox();
            this.txtmat = new System.Windows.Forms.TextBox();
            this.cbid = new System.Windows.Forms.ComboBox();
            this.btnnue = new System.Windows.Forms.Button();
            this.btnbus = new System.Windows.Forms.Button();
            this.btneli = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido paterno:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellido materno:";
            // 
            // txtnom
            // 
            this.txtnom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnom.Location = new System.Drawing.Point(497, 149);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(133, 20);
            this.txtnom.TabIndex = 5;
            // 
            // txtpat
            // 
            this.txtpat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpat.Location = new System.Drawing.Point(497, 210);
            this.txtpat.Name = "txtpat";
            this.txtpat.Size = new System.Drawing.Size(133, 20);
            this.txtpat.TabIndex = 6;
            // 
            // txtmat
            // 
            this.txtmat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmat.Location = new System.Drawing.Point(497, 276);
            this.txtmat.Name = "txtmat";
            this.txtmat.Size = new System.Drawing.Size(133, 20);
            this.txtmat.TabIndex = 7;
            // 
            // cbid
            // 
            this.cbid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbid.FormattingEnabled = true;
            this.cbid.Location = new System.Drawing.Point(497, 79);
            this.cbid.Name = "cbid";
            this.cbid.Size = new System.Drawing.Size(133, 26);
            this.cbid.TabIndex = 8;
            // 
            // btnnue
            // 
            this.btnnue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(221)))), ((int)(((byte)(191)))));
            this.btnnue.FlatAppearance.BorderSize = 0;
            this.btnnue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnue.Image = ((System.Drawing.Image)(resources.GetObject("btnnue.Image")));
            this.btnnue.Location = new System.Drawing.Point(660, 33);
            this.btnnue.Name = "btnnue";
            this.btnnue.Size = new System.Drawing.Size(91, 79);
            this.btnnue.TabIndex = 10;
            this.btnnue.Text = "Nuevo";
            this.btnnue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnnue.UseVisualStyleBackColor = false;
            // 
            // btnbus
            // 
            this.btnbus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(221)))), ((int)(((byte)(191)))));
            this.btnbus.FlatAppearance.BorderSize = 0;
            this.btnbus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbus.Image = ((System.Drawing.Image)(resources.GetObject("btnbus.Image")));
            this.btnbus.Location = new System.Drawing.Point(660, 134);
            this.btnbus.Name = "btnbus";
            this.btnbus.Size = new System.Drawing.Size(91, 79);
            this.btnbus.TabIndex = 11;
            this.btnbus.Text = "Buscar";
            this.btnbus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnbus.UseVisualStyleBackColor = false;
            // 
            // btneli
            // 
            this.btneli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(221)))), ((int)(((byte)(191)))));
            this.btneli.FlatAppearance.BorderSize = 0;
            this.btneli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneli.Image = ((System.Drawing.Image)(resources.GetObject("btneli.Image")));
            this.btneli.Location = new System.Drawing.Point(660, 233);
            this.btneli.Name = "btneli";
            this.btneli.Size = new System.Drawing.Size(91, 79);
            this.btneli.TabIndex = 12;
            this.btneli.Text = "Eliminar";
            this.btneli.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btneli.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(295, 318);
            this.dataGridView1.TabIndex = 13;
            // 
            // EmpleadoReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(221)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(780, 390);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btneli);
            this.Controls.Add(this.btnbus);
            this.Controls.Add(this.btnnue);
            this.Controls.Add(this.cbid);
            this.Controls.Add(this.txtmat);
            this.Controls.Add(this.txtpat);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmpleadoReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleado";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.TextBox txtpat;
        private System.Windows.Forms.TextBox txtmat;
        private System.Windows.Forms.ComboBox cbid;
        private System.Windows.Forms.Button btnnue;
        private System.Windows.Forms.Button btnbus;
        private System.Windows.Forms.Button btneli;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}