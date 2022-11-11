
namespace ComprasVista
{
    partial class Ventas
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
            this.Gpo_venta = new System.Windows.Forms.GroupBox();
            this.btnHelp = new FontAwesome.Sharp.IconButton();
            this.btneliminarpedido = new FontAwesome.Sharp.IconButton();
            this.Dgvdetalleventa = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Dtp_fechavencimiento = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.Dtp_fechapedido = new System.Windows.Forms.DateTimePicker();
            this.btnpedido = new System.Windows.Forms.Button();
            this.Txt_nombrecliente = new System.Windows.Forms.TextBox();
            this.Txt_idpedido = new System.Windows.Forms.TextBox();
            this.Txt_idventa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_nit = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnventa = new FontAwesome.Sharp.IconButton();
            this.Cbo_tipopago = new System.Windows.Forms.ComboBox();
            this.btncancelarventa = new FontAwesome.Sharp.IconButton();
            this.label6 = new System.Windows.Forms.Label();
            this.Gbo_tipopago = new System.Windows.Forms.GroupBox();
            this.Txt_total = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Txt_subtotal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Txt_abono = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Cbo_tipoplazo = new System.Windows.Forms.ComboBox();
            this.lbl_tipoplazo = new System.Windows.Forms.Label();
            this.Gbo_pago = new System.Windows.Forms.GroupBox();
            this.Gpo_venta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgvdetalleventa)).BeginInit();
            this.Gbo_tipopago.SuspendLayout();
            this.Gbo_pago.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gpo_venta
            // 
            this.Gpo_venta.Controls.Add(this.btnHelp);
            this.Gpo_venta.Controls.Add(this.btneliminarpedido);
            this.Gpo_venta.Controls.Add(this.Dgvdetalleventa);
            this.Gpo_venta.Controls.Add(this.label1);
            this.Gpo_venta.Controls.Add(this.Dtp_fechavencimiento);
            this.Gpo_venta.Controls.Add(this.label9);
            this.Gpo_venta.Controls.Add(this.Dtp_fechapedido);
            this.Gpo_venta.Controls.Add(this.btnpedido);
            this.Gpo_venta.Controls.Add(this.Txt_nombrecliente);
            this.Gpo_venta.Controls.Add(this.Txt_idpedido);
            this.Gpo_venta.Controls.Add(this.Txt_idventa);
            this.Gpo_venta.Controls.Add(this.label3);
            this.Gpo_venta.Controls.Add(this.label2);
            this.Gpo_venta.Controls.Add(this.label4);
            this.Gpo_venta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpo_venta.Location = new System.Drawing.Point(26, 23);
            this.Gpo_venta.Name = "Gpo_venta";
            this.Gpo_venta.Size = new System.Drawing.Size(899, 342);
            this.Gpo_venta.TabIndex = 63;
            this.Gpo_venta.TabStop = false;
            this.Gpo_venta.Text = "Venta";
            this.Gpo_venta.Enter += new System.EventHandler(this.Gpo_venta_Enter);
            // 
            // btnHelp
            // 
            this.btnHelp.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnHelp.FlatAppearance.BorderSize = 2;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.IconChar = FontAwesome.Sharp.IconChar.Question;
            this.btnHelp.IconColor = System.Drawing.Color.DimGray;
            this.btnHelp.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnHelp.IconSize = 40;
            this.btnHelp.Location = new System.Drawing.Point(812, 57);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(69, 61);
            this.btnHelp.TabIndex = 65;
            this.btnHelp.Text = "Ayuda";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btneliminarpedido
            // 
            this.btneliminarpedido.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btneliminarpedido.FlatAppearance.BorderSize = 2;
            this.btneliminarpedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminarpedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminarpedido.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btneliminarpedido.IconColor = System.Drawing.Color.DimGray;
            this.btneliminarpedido.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btneliminarpedido.IconSize = 40;
            this.btneliminarpedido.Location = new System.Drawing.Point(697, 57);
            this.btneliminarpedido.Name = "btneliminarpedido";
            this.btneliminarpedido.Size = new System.Drawing.Size(69, 61);
            this.btneliminarpedido.TabIndex = 65;
            this.btneliminarpedido.Text = "Eliminar";
            this.btneliminarpedido.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btneliminarpedido.UseVisualStyleBackColor = true;
            this.btneliminarpedido.Click += new System.EventHandler(this.btneliminarpedido_Click);
            // 
            // Dgvdetalleventa
            // 
            this.Dgvdetalleventa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgvdetalleventa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgvdetalleventa.Location = new System.Drawing.Point(20, 163);
            this.Dgvdetalleventa.Name = "Dgvdetalleventa";
            this.Dgvdetalleventa.Size = new System.Drawing.Size(861, 168);
            this.Dgvdetalleventa.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(406, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 62;
            this.label1.Text = "Fecha Vencimiento";
            // 
            // Dtp_fechavencimiento
            // 
            this.Dtp_fechavencimiento.Location = new System.Drawing.Point(344, 117);
            this.Dtp_fechavencimiento.Name = "Dtp_fechavencimiento";
            this.Dtp_fechavencimiento.Size = new System.Drawing.Size(295, 25);
            this.Dtp_fechavencimiento.TabIndex = 61;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(406, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 17);
            this.label9.TabIndex = 60;
            this.label9.Text = "Fecha Pedido";
            // 
            // Dtp_fechapedido
            // 
            this.Dtp_fechapedido.Location = new System.Drawing.Point(344, 49);
            this.Dtp_fechapedido.Name = "Dtp_fechapedido";
            this.Dtp_fechapedido.Size = new System.Drawing.Size(295, 25);
            this.Dtp_fechapedido.TabIndex = 9;
            // 
            // btnpedido
            // 
            this.btnpedido.Location = new System.Drawing.Point(224, 74);
            this.btnpedido.Name = "btnpedido";
            this.btnpedido.Size = new System.Drawing.Size(19, 23);
            this.btnpedido.TabIndex = 59;
            this.btnpedido.Text = "?";
            this.btnpedido.UseVisualStyleBackColor = true;
            this.btnpedido.Click += new System.EventHandler(this.btnpedido_Click);
            // 
            // Txt_nombrecliente
            // 
            this.Txt_nombrecliente.Location = new System.Drawing.Point(111, 117);
            this.Txt_nombrecliente.Name = "Txt_nombrecliente";
            this.Txt_nombrecliente.Size = new System.Drawing.Size(188, 25);
            this.Txt_nombrecliente.TabIndex = 8;
            // 
            // Txt_idpedido
            // 
            this.Txt_idpedido.Location = new System.Drawing.Point(111, 72);
            this.Txt_idpedido.Name = "Txt_idpedido";
            this.Txt_idpedido.Size = new System.Drawing.Size(107, 25);
            this.Txt_idpedido.TabIndex = 7;
            this.Txt_idpedido.TextChanged += new System.EventHandler(this.Txt_idpedido_TextChanged);
            // 
            // Txt_idventa
            // 
            this.Txt_idventa.Location = new System.Drawing.Point(111, 29);
            this.Txt_idventa.Name = "Txt_idventa";
            this.Txt_idventa.Size = new System.Drawing.Size(105, 25);
            this.Txt_idventa.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pedido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "ID";
            // 
            // Txt_nit
            // 
            this.Txt_nit.Location = new System.Drawing.Point(193, 21);
            this.Txt_nit.Name = "Txt_nit";
            this.Txt_nit.Size = new System.Drawing.Size(107, 25);
            this.Txt_nit.TabIndex = 78;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(74, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 17);
            this.label14.TabIndex = 77;
            this.label14.Text = "Nit";
            // 
            // btnventa
            // 
            this.btnventa.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnventa.FlatAppearance.BorderSize = 2;
            this.btnventa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnventa.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnventa.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnventa.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(180)))), ((int)(((byte)(227)))));
            this.btnventa.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnventa.IconSize = 40;
            this.btnventa.Location = new System.Drawing.Point(132, 173);
            this.btnventa.Name = "btnventa";
            this.btnventa.Size = new System.Drawing.Size(65, 61);
            this.btnventa.TabIndex = 57;
            this.btnventa.Text = "Insertar";
            this.btnventa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnventa.UseVisualStyleBackColor = true;
            this.btnventa.Click += new System.EventHandler(this.btnventa_Click);
            // 
            // Cbo_tipopago
            // 
            this.Cbo_tipopago.FormattingEnabled = true;
            this.Cbo_tipopago.Items.AddRange(new object[] {
            "Contado",
            "Plazos"});
            this.Cbo_tipopago.Location = new System.Drawing.Point(193, 66);
            this.Cbo_tipopago.Name = "Cbo_tipopago";
            this.Cbo_tipopago.Size = new System.Drawing.Size(121, 25);
            this.Cbo_tipopago.TabIndex = 50;
            this.Cbo_tipopago.SelectedIndexChanged += new System.EventHandler(this.Cbo_tipopago_SelectedIndexChanged);
            // 
            // btncancelarventa
            // 
            this.btncancelarventa.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btncancelarventa.FlatAppearance.BorderSize = 2;
            this.btncancelarventa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelarventa.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelarventa.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            this.btncancelarventa.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.btncancelarventa.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btncancelarventa.IconSize = 40;
            this.btncancelarventa.Location = new System.Drawing.Point(245, 173);
            this.btncancelarventa.Name = "btncancelarventa";
            this.btncancelarventa.Size = new System.Drawing.Size(69, 61);
            this.btncancelarventa.TabIndex = 58;
            this.btncancelarventa.Text = "Cancelar";
            this.btncancelarventa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncancelarventa.UseVisualStyleBackColor = true;
            this.btncancelarventa.Click += new System.EventHandler(this.btncancelarventa_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(74, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 17);
            this.label6.TabIndex = 65;
            this.label6.Text = "Tipo de Pago";
            // 
            // Gbo_tipopago
            // 
            this.Gbo_tipopago.Controls.Add(this.Txt_total);
            this.Gbo_tipopago.Controls.Add(this.label12);
            this.Gbo_tipopago.Controls.Add(this.Txt_subtotal);
            this.Gbo_tipopago.Controls.Add(this.label11);
            this.Gbo_tipopago.Controls.Add(this.Txt_abono);
            this.Gbo_tipopago.Controls.Add(this.label8);
            this.Gbo_tipopago.Location = new System.Drawing.Point(440, 14);
            this.Gbo_tipopago.Name = "Gbo_tipopago";
            this.Gbo_tipopago.Size = new System.Drawing.Size(386, 241);
            this.Gbo_tipopago.TabIndex = 68;
            this.Gbo_tipopago.TabStop = false;
            this.Gbo_tipopago.Enter += new System.EventHandler(this.Gbo_tipopago_Enter);
            // 
            // Txt_total
            // 
            this.Txt_total.Location = new System.Drawing.Point(142, 191);
            this.Txt_total.Name = "Txt_total";
            this.Txt_total.Size = new System.Drawing.Size(107, 25);
            this.Txt_total.TabIndex = 76;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(26, 199);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 17);
            this.label12.TabIndex = 75;
            this.label12.Text = "Total";
            // 
            // Txt_subtotal
            // 
            this.Txt_subtotal.Location = new System.Drawing.Point(142, 147);
            this.Txt_subtotal.Name = "Txt_subtotal";
            this.Txt_subtotal.Size = new System.Drawing.Size(107, 25);
            this.Txt_subtotal.TabIndex = 74;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(26, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 17);
            this.label11.TabIndex = 73;
            this.label11.Text = "Subtotal";
            // 
            // Txt_abono
            // 
            this.Txt_abono.Location = new System.Drawing.Point(142, 24);
            this.Txt_abono.Name = "Txt_abono";
            this.Txt_abono.Size = new System.Drawing.Size(107, 25);
            this.Txt_abono.TabIndex = 66;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 17);
            this.label8.TabIndex = 65;
            this.label8.Text = "Abono";
            // 
            // Cbo_tipoplazo
            // 
            this.Cbo_tipoplazo.FormattingEnabled = true;
            this.Cbo_tipoplazo.Items.AddRange(new object[] {
            "15 – 29 días",
            "30 días",
            "31 – 60 días",
            "61 – 90 días"});
            this.Cbo_tipoplazo.Location = new System.Drawing.Point(193, 110);
            this.Cbo_tipoplazo.Name = "Cbo_tipoplazo";
            this.Cbo_tipoplazo.Size = new System.Drawing.Size(121, 25);
            this.Cbo_tipoplazo.TabIndex = 71;
            this.Cbo_tipoplazo.SelectedIndexChanged += new System.EventHandler(this.Cbo_tipoplazo_SelectedIndexChanged);
            // 
            // lbl_tipoplazo
            // 
            this.lbl_tipoplazo.AutoSize = true;
            this.lbl_tipoplazo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipoplazo.Location = new System.Drawing.Point(74, 113);
            this.lbl_tipoplazo.Name = "lbl_tipoplazo";
            this.lbl_tipoplazo.Size = new System.Drawing.Size(105, 17);
            this.lbl_tipoplazo.TabIndex = 72;
            this.lbl_tipoplazo.Text = "Tipo de Plazo";
            // 
            // Gbo_pago
            // 
            this.Gbo_pago.Controls.Add(this.Txt_nit);
            this.Gbo_pago.Controls.Add(this.Gbo_tipopago);
            this.Gbo_pago.Controls.Add(this.label14);
            this.Gbo_pago.Controls.Add(this.label6);
            this.Gbo_pago.Controls.Add(this.lbl_tipoplazo);
            this.Gbo_pago.Controls.Add(this.btncancelarventa);
            this.Gbo_pago.Controls.Add(this.Cbo_tipopago);
            this.Gbo_pago.Controls.Add(this.Cbo_tipoplazo);
            this.Gbo_pago.Controls.Add(this.btnventa);
            this.Gbo_pago.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gbo_pago.Location = new System.Drawing.Point(26, 371);
            this.Gbo_pago.Name = "Gbo_pago";
            this.Gbo_pago.Size = new System.Drawing.Size(899, 261);
            this.Gbo_pago.TabIndex = 64;
            this.Gbo_pago.TabStop = false;
            this.Gbo_pago.Text = "Pago";
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(933, 635);
            this.Controls.Add(this.Gbo_pago);
            this.Controls.Add(this.Gpo_venta);
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            this.Gpo_venta.ResumeLayout(false);
            this.Gpo_venta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgvdetalleventa)).EndInit();
            this.Gbo_tipopago.ResumeLayout(false);
            this.Gbo_tipopago.PerformLayout();
            this.Gbo_pago.ResumeLayout(false);
            this.Gbo_pago.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gpo_venta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Dtp_fechavencimiento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker Dtp_fechapedido;
        private System.Windows.Forms.Button btnpedido;
        private System.Windows.Forms.TextBox Txt_nombrecliente;
        private System.Windows.Forms.TextBox Txt_idpedido;
        private System.Windows.Forms.TextBox Txt_idventa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView Dgvdetalleventa;
        private FontAwesome.Sharp.IconButton btneliminarpedido;
        private System.Windows.Forms.TextBox Txt_nit;
        private System.Windows.Forms.Label label14;
        private FontAwesome.Sharp.IconButton btnventa;
        private System.Windows.Forms.ComboBox Cbo_tipopago;
        private FontAwesome.Sharp.IconButton btncancelarventa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox Gbo_tipopago;
        private System.Windows.Forms.TextBox Txt_total;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Txt_subtotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_tipoplazo;
        private System.Windows.Forms.TextBox Txt_abono;
        private System.Windows.Forms.ComboBox Cbo_tipoplazo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox Gbo_pago;
        private FontAwesome.Sharp.IconButton btnHelp;
    }
}