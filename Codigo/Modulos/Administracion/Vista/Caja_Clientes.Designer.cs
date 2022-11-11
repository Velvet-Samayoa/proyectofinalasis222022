
namespace ComprasVista
{
    partial class Caja_Clientes
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
            this.txtAbono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdCaja = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvCajaClientes = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSaldoActualizado = new System.Windows.Forms.TextBox();
            this.txtSaldoAnterior = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVentasE = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gpbCajaClientes = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtIdFactura = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCajaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAbono
            // 
            this.txtAbono.Location = new System.Drawing.Point(167, 133);
            this.txtAbono.Name = "txtAbono";
            this.txtAbono.Size = new System.Drawing.Size(257, 20);
            this.txtAbono.TabIndex = 50;
            this.txtAbono.Tag = "Abono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 49;
            this.label3.Text = "Abono";
            // 
            // txtIdCaja
            // 
            this.txtIdCaja.Enabled = false;
            this.txtIdCaja.Location = new System.Drawing.Point(164, 75);
            this.txtIdCaja.Name = "txtIdCaja";
            this.txtIdCaja.Size = new System.Drawing.Size(260, 20);
            this.txtIdCaja.TabIndex = 44;
            this.txtIdCaja.Tag = "PkId_CajaClientes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 17);
            this.label1.TabIndex = 43;
            this.label1.Text = "ID";
            // 
            // DgvCajaClientes
            // 
            this.DgvCajaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCajaClientes.Location = new System.Drawing.Point(446, 75);
            this.DgvCajaClientes.Name = "DgvCajaClientes";
            this.DgvCajaClientes.Size = new System.Drawing.Size(449, 248);
            this.DgvCajaClientes.TabIndex = 51;
            this.DgvCajaClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 52;
            this.label2.Text = "Saldo actualizado";
            // 
            // txtSaldoActualizado
            // 
            this.txtSaldoActualizado.Enabled = false;
            this.txtSaldoActualizado.Location = new System.Drawing.Point(167, 188);
            this.txtSaldoActualizado.Name = "txtSaldoActualizado";
            this.txtSaldoActualizado.Size = new System.Drawing.Size(257, 20);
            this.txtSaldoActualizado.TabIndex = 50;
            this.txtSaldoActualizado.Tag = "Abono";
            this.txtSaldoActualizado.TextChanged += new System.EventHandler(this.txtSaldoActualizado_TextChanged);
            // 
            // txtSaldoAnterior
            // 
            this.txtSaldoAnterior.Enabled = false;
            this.txtSaldoAnterior.Location = new System.Drawing.Point(167, 244);
            this.txtSaldoAnterior.Name = "txtSaldoAnterior";
            this.txtSaldoAnterior.Size = new System.Drawing.Size(257, 20);
            this.txtSaldoAnterior.TabIndex = 50;
            this.txtSaldoAnterior.Tag = "Abono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 52;
            this.label4.Text = "Saldo anterior";
            // 
            // txtVentasE
            // 
            this.txtVentasE.Enabled = false;
            this.txtVentasE.Location = new System.Drawing.Point(167, 295);
            this.txtVentasE.Name = "txtVentasE";
            this.txtVentasE.Size = new System.Drawing.Size(257, 20);
            this.txtVentasE.TabIndex = 50;
            this.txtVentasE.Tag = "Abono";
            this.txtVentasE.TextChanged += new System.EventHandler(this.txtVentasE_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 17);
            this.label5.TabIndex = 52;
            this.label5.Text = "Ventas encabezado";
            // 
            // gpbCajaClientes
            // 
            this.gpbCajaClientes.Location = new System.Drawing.Point(5, 52);
            this.gpbCajaClientes.Name = "gpbCajaClientes";
            this.gpbCajaClientes.Size = new System.Drawing.Size(435, 308);
            this.gpbCajaClientes.TabIndex = 53;
            this.gpbCajaClientes.TabStop = false;
            this.gpbCajaClientes.Text = "Caja Clientes ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(812, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 24);
            this.button1.TabIndex = 54;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(709, 336);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 23);
            this.button2.TabIndex = 55;
            this.button2.Text = "ConsultarVentas";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(558, 337);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 23);
            this.button3.TabIndex = 56;
            this.button3.Text = "Actualizar saldo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtIdFactura
            // 
            this.txtIdFactura.Location = new System.Drawing.Point(164, 366);
            this.txtIdFactura.Name = "txtIdFactura";
            this.txtIdFactura.Size = new System.Drawing.Size(260, 20);
            this.txtIdFactura.TabIndex = 0;
            // 
            // Caja_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(914, 415);
            this.Controls.Add(this.txtIdFactura);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DgvCajaClientes);
            this.Controls.Add(this.txtVentasE);
            this.Controls.Add(this.txtSaldoAnterior);
            this.Controls.Add(this.txtSaldoActualizado);
            this.Controls.Add(this.txtAbono);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIdCaja);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gpbCajaClientes);
            this.Name = "Caja_Clientes";
            this.Text = "Caja_Clientes";
            this.Load += new System.EventHandler(this.Caja_Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCajaClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtAbono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdCaja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvCajaClientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSaldoActualizado;
        private System.Windows.Forms.TextBox txtSaldoAnterior;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVentasE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gpbCajaClientes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtIdFactura;
    }
}