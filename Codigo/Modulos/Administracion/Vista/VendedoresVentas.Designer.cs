
namespace ComprasVista
{
    partial class VendedoresVentas
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.txtComision = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxVenta = new System.Windows.Forms.ComboBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxIdv = new System.Windows.Forms.ComboBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdVendedor = new System.Windows.Forms.TextBox();
            this.txtCodVenta = new System.Windows.Forms.TextBox();
            this.btnCalcular = new FontAwesome.Sharp.IconPictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIdPuesto = new System.Windows.Forms.TextBox();
            this.cbxPuesto = new System.Windows.Forms.ComboBox();
            this.txtPuesto = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.navegador1 = new NavegadorVista.Navegador();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCalcular)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 420);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1060, 229);
            this.dataGridView1.TabIndex = 50;
            this.dataGridView1.Tag = "tblcomision";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(860, 259);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 15);
            this.label9.TabIndex = 114;
            this.label9.Text = "%";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtComision
            // 
            this.txtComision.Location = new System.Drawing.Point(689, 357);
            this.txtComision.Name = "txtComision";
            this.txtComision.Size = new System.Drawing.Size(190, 20);
            this.txtComision.TabIndex = 113;
            this.txtComision.Tag = "LiquidezComision";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(529, 358);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 15);
            this.label8.TabIndex = 112;
            this.label8.Text = "Liquidez de Comisión";
            // 
            // txtPor
            // 
            this.txtPor.Location = new System.Drawing.Point(781, 258);
            this.txtPor.Name = "txtPor";
            this.txtPor.Size = new System.Drawing.Size(73, 20);
            this.txtPor.TabIndex = 111;
            this.txtPor.Tag = "PorcentajeComision";
            this.txtPor.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(529, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 15);
            this.label7.TabIndex = 110;
            this.label7.Text = "Porcentaje Comisión";
            // 
            // cbxVenta
            // 
            this.cbxVenta.FormattingEnabled = true;
            this.cbxVenta.Location = new System.Drawing.Point(633, 174);
            this.cbxVenta.Margin = new System.Windows.Forms.Padding(2);
            this.cbxVenta.Name = "cbxVenta";
            this.cbxVenta.Size = new System.Drawing.Size(119, 21);
            this.cbxVenta.TabIndex = 109;
            this.cbxVenta.SelectedIndexChanged += new System.EventHandler(this.cbxVenta_SelectedIndexChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(633, 206);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(246, 20);
            this.txtTotal.TabIndex = 108;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(529, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 15);
            this.label6.TabIndex = 107;
            this.label6.Text = "Total Venta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(529, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 15);
            this.label5.TabIndex = 106;
            this.label5.Text = "Código Venta";
            // 
            // cbxIdv
            // 
            this.cbxIdv.FormattingEnabled = true;
            this.cbxIdv.Location = new System.Drawing.Point(232, 279);
            this.cbxIdv.Margin = new System.Windows.Forms.Padding(2);
            this.cbxIdv.Name = "cbxIdv";
            this.cbxIdv.Size = new System.Drawing.Size(118, 21);
            this.cbxIdv.TabIndex = 105;
            this.cbxIdv.SelectedIndexChanged += new System.EventHandler(this.cbxIdv_SelectedIndexChanged);
            // 
            // txtEstado
            // 
            this.txtEstado.Enabled = false;
            this.txtEstado.Location = new System.Drawing.Point(232, 349);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(118, 20);
            this.txtEstado.TabIndex = 104;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(166, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 103;
            this.label4.Text = "Estado";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(232, 172);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(118, 20);
            this.txtId.TabIndex = 102;
            this.txtId.Tag = "PkId_Comision";
            this.txtId.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(145, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 101;
            this.label3.Text = "Id Comisión";
            // 
            // txtname
            // 
            this.txtname.Enabled = false;
            this.txtname.Location = new System.Drawing.Point(231, 315);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(246, 20);
            this.txtname.TabIndex = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(161, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 99;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 98;
            this.label1.Text = "Id Vendedor";
            // 
            // txtIdVendedor
            // 
            this.txtIdVendedor.Location = new System.Drawing.Point(35, 281);
            this.txtIdVendedor.Name = "txtIdVendedor";
            this.txtIdVendedor.Size = new System.Drawing.Size(100, 20);
            this.txtIdVendedor.TabIndex = 115;
            this.txtIdVendedor.Tag = "fk_id_trabajador";
            this.txtIdVendedor.Visible = false;
            // 
            // txtCodVenta
            // 
            this.txtCodVenta.Location = new System.Drawing.Point(418, 175);
            this.txtCodVenta.Name = "txtCodVenta";
            this.txtCodVenta.Size = new System.Drawing.Size(100, 20);
            this.txtCodVenta.TabIndex = 116;
            this.txtCodVenta.Tag = "FkId_VentasEncabezado";
            this.txtCodVenta.Visible = false;
            this.txtCodVenta.TextChanged += new System.EventHandler(this.txtCodVenta_TextChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(253)))));
            this.btnCalcular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCalcular.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.btnCalcular.IconColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCalcular.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCalcular.IconSize = 37;
            this.btnCalcular.Location = new System.Drawing.Point(612, 285);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(40, 37);
            this.btnCalcular.TabIndex = 117;
            this.btnCalcular.TabStop = false;
            this.btnCalcular.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(609, 325);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 15);
            this.label10.TabIndex = 118;
            this.label10.Text = "Calcular";
            // 
            // txtIdPuesto
            // 
            this.txtIdPuesto.Location = new System.Drawing.Point(35, 208);
            this.txtIdPuesto.Name = "txtIdPuesto";
            this.txtIdPuesto.Size = new System.Drawing.Size(100, 20);
            this.txtIdPuesto.TabIndex = 137;
            this.txtIdPuesto.Visible = false;
            // 
            // cbxPuesto
            // 
            this.cbxPuesto.FormattingEnabled = true;
            this.cbxPuesto.Location = new System.Drawing.Point(232, 206);
            this.cbxPuesto.Margin = new System.Windows.Forms.Padding(2);
            this.cbxPuesto.Name = "cbxPuesto";
            this.cbxPuesto.Size = new System.Drawing.Size(118, 21);
            this.cbxPuesto.TabIndex = 136;
            this.cbxPuesto.SelectedIndexChanged += new System.EventHandler(this.cbxPuesto_SelectedIndexChanged);
            // 
            // txtPuesto
            // 
            this.txtPuesto.Enabled = false;
            this.txtPuesto.Location = new System.Drawing.Point(231, 242);
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.Size = new System.Drawing.Size(246, 20);
            this.txtPuesto.TabIndex = 135;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(161, 245);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 15);
            this.label11.TabIndex = 134;
            this.label11.Text = "Puesto";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(145, 206);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 15);
            this.label12.TabIndex = 133;
            this.label12.Text = "Id Puesto";
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(232, 12);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(574, 152);
            this.navegador1.TabIndex = 138;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // VendedoresVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.txtIdPuesto);
            this.Controls.Add(this.cbxPuesto);
            this.Controls.Add(this.txtPuesto);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtCodVenta);
            this.Controls.Add(this.txtIdVendedor);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtComision);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbxVenta);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxIdv);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VendedoresVentas";
            this.Text = "VendedoresVentas";
            this.Load += new System.EventHandler(this.VendedoresVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCalcular)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtComision;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxVenta;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxIdv;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdVendedor;
        private System.Windows.Forms.TextBox txtCodVenta;
        private FontAwesome.Sharp.IconPictureBox btnCalcular;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIdPuesto;
        private System.Windows.Forms.ComboBox cbxPuesto;
        private System.Windows.Forms.TextBox txtPuesto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private NavegadorVista.Navegador navegador1;
    }
}