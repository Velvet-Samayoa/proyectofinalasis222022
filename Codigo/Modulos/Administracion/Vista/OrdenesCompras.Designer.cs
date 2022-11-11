
namespace ComprasVista
{
    partial class OrdenesCompras
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
            this.ID_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpDetalle = new System.Windows.Forms.GroupBox();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.Txt_Costo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Txt_precio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btneliminar = new FontAwesome.Sharp.IconButton();
            this.btnagregar = new FontAwesome.Sharp.IconButton();
            this.Txt_idproducto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grpOrden = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Dtp_fechavencimiento = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.Dtp_fechaentrega = new System.Windows.Forms.DateTimePicker();
            this.button4 = new System.Windows.Forms.Button();
            this.btncancelar = new FontAwesome.Sharp.IconButton();
            this.btninsertar = new FontAwesome.Sharp.IconButton();
            this.Txt_proveedores = new System.Windows.Forms.TextBox();
            this.Txt_idpedido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalF = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnReporte = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpDetalle.SuspendLayout();
            this.grpOrden.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Producto,
            this.Cantidad,
            this.Precio,
            this.Costo,
            this.Total});
            this.dataGridView1.Location = new System.Drawing.Point(12, 388);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1060, 197);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID_Producto
            // 
            this.ID_Producto.HeaderText = "ID_Producto";
            this.ID_Producto.Name = "ID_Producto";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Catidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Costo
            // 
            this.Costo.HeaderText = "Costo";
            this.Costo.Name = "Costo";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // grpDetalle
            // 
            this.grpDetalle.Controls.Add(this.TxtCantidad);
            this.grpDetalle.Controls.Add(this.Txt_Costo);
            this.grpDetalle.Controls.Add(this.label10);
            this.grpDetalle.Controls.Add(this.Txt_precio);
            this.grpDetalle.Controls.Add(this.label5);
            this.grpDetalle.Controls.Add(this.label4);
            this.grpDetalle.Controls.Add(this.button1);
            this.grpDetalle.Controls.Add(this.btneliminar);
            this.grpDetalle.Controls.Add(this.btnagregar);
            this.grpDetalle.Controls.Add(this.Txt_idproducto);
            this.grpDetalle.Controls.Add(this.label6);
            this.grpDetalle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDetalle.Location = new System.Drawing.Point(12, 191);
            this.grpDetalle.Name = "grpDetalle";
            this.grpDetalle.Size = new System.Drawing.Size(1060, 170);
            this.grpDetalle.TabIndex = 10;
            this.grpDetalle.TabStop = false;
            this.grpDetalle.Text = "Detalle Orden de Compra";
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(111, 66);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(109, 25);
            this.TxtCantidad.TabIndex = 57;
            this.TxtCantidad.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Txt_Costo
            // 
            this.Txt_Costo.Location = new System.Drawing.Point(400, 30);
            this.Txt_Costo.Name = "Txt_Costo";
            this.Txt_Costo.Size = new System.Drawing.Size(131, 25);
            this.Txt_Costo.TabIndex = 56;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(299, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 17);
            this.label10.TabIndex = 55;
            this.label10.Text = "Costo";
            // 
            // Txt_precio
            // 
            this.Txt_precio.Location = new System.Drawing.Point(111, 106);
            this.Txt_precio.Name = "Txt_precio";
            this.Txt_precio.Size = new System.Drawing.Size(109, 25);
            this.Txt_precio.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 51;
            this.label5.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 50;
            this.label4.Text = "Cantidad";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(19, 23);
            this.button1.TabIndex = 48;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btneliminar.FlatAppearance.BorderSize = 2;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btneliminar.IconColor = System.Drawing.Color.DimGray;
            this.btneliminar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btneliminar.IconSize = 40;
            this.btneliminar.Location = new System.Drawing.Point(969, 24);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(69, 61);
            this.btneliminar.TabIndex = 47;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnagregar.FlatAppearance.BorderSize = 2;
            this.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnagregar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(180)))), ((int)(((byte)(227)))));
            this.btnagregar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnagregar.IconSize = 40;
            this.btnagregar.Location = new System.Drawing.Point(864, 22);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(69, 61);
            this.btnagregar.TabIndex = 45;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // Txt_idproducto
            // 
            this.Txt_idproducto.Location = new System.Drawing.Point(111, 27);
            this.Txt_idproducto.Name = "Txt_idproducto";
            this.Txt_idproducto.Size = new System.Drawing.Size(109, 25);
            this.Txt_idproducto.TabIndex = 12;
            this.Txt_idproducto.TextChanged += new System.EventHandler(this.Txt_idproducto_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Producto";
            // 
            // grpOrden
            // 
            this.grpOrden.Controls.Add(this.btnReporte);
            this.grpOrden.Controls.Add(this.label11);
            this.grpOrden.Controls.Add(this.Dtp_fechavencimiento);
            this.grpOrden.Controls.Add(this.label9);
            this.grpOrden.Controls.Add(this.Dtp_fechaentrega);
            this.grpOrden.Controls.Add(this.button4);
            this.grpOrden.Controls.Add(this.btncancelar);
            this.grpOrden.Controls.Add(this.btninsertar);
            this.grpOrden.Controls.Add(this.Txt_proveedores);
            this.grpOrden.Controls.Add(this.Txt_idpedido);
            this.grpOrden.Controls.Add(this.label2);
            this.grpOrden.Controls.Add(this.label1);
            this.grpOrden.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOrden.Location = new System.Drawing.Point(12, 12);
            this.grpOrden.Name = "grpOrden";
            this.grpOrden.Size = new System.Drawing.Size(1060, 164);
            this.grpOrden.TabIndex = 9;
            this.grpOrden.TabStop = false;
            this.grpOrden.Text = "Orden de Compra";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(422, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 17);
            this.label11.TabIndex = 62;
            this.label11.Text = "Fecha Vencimiento";
            // 
            // Dtp_fechavencimiento
            // 
            this.Dtp_fechavencimiento.Location = new System.Drawing.Point(370, 107);
            this.Dtp_fechavencimiento.Name = "Dtp_fechavencimiento";
            this.Dtp_fechavencimiento.Size = new System.Drawing.Size(295, 25);
            this.Dtp_fechavencimiento.TabIndex = 61;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(422, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 17);
            this.label9.TabIndex = 60;
            this.label9.Text = "Fecha Entrega";
            // 
            // Dtp_fechaentrega
            // 
            this.Dtp_fechaentrega.Location = new System.Drawing.Point(370, 42);
            this.Dtp_fechaentrega.Name = "Dtp_fechaentrega";
            this.Dtp_fechaentrega.Size = new System.Drawing.Size(295, 25);
            this.Dtp_fechaentrega.TabIndex = 9;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(240, 61);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(19, 23);
            this.button4.TabIndex = 59;
            this.button4.Text = "?";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btncancelar.FlatAppearance.BorderSize = 2;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            this.btncancelar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.btncancelar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btncancelar.IconSize = 40;
            this.btncancelar.Location = new System.Drawing.Point(969, 20);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(69, 61);
            this.btncancelar.TabIndex = 58;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btninsertar
            // 
            this.btninsertar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btninsertar.FlatAppearance.BorderSize = 2;
            this.btninsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsertar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btninsertar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(180)))), ((int)(((byte)(227)))));
            this.btninsertar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btninsertar.IconSize = 40;
            this.btninsertar.Location = new System.Drawing.Point(864, 20);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(69, 61);
            this.btninsertar.TabIndex = 57;
            this.btninsertar.Text = "Insertar";
            this.btninsertar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btninsertar.UseVisualStyleBackColor = true;
            this.btninsertar.Click += new System.EventHandler(this.btninsertar_Click);
            // 
            // Txt_proveedores
            // 
            this.Txt_proveedores.Location = new System.Drawing.Point(127, 61);
            this.Txt_proveedores.Name = "Txt_proveedores";
            this.Txt_proveedores.Size = new System.Drawing.Size(107, 25);
            this.Txt_proveedores.TabIndex = 7;
            // 
            // Txt_idpedido
            // 
            this.Txt_idpedido.Location = new System.Drawing.Point(127, 29);
            this.Txt_idpedido.Name = "Txt_idpedido";
            this.Txt_idpedido.Size = new System.Drawing.Size(105, 25);
            this.Txt_idpedido.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Proveedor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // txtTotalF
            // 
            this.txtTotalF.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalF.Location = new System.Drawing.Point(854, 624);
            this.txtTotalF.Name = "txtTotalF";
            this.txtTotalF.Size = new System.Drawing.Size(218, 25);
            this.txtTotalF.TabIndex = 60;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(789, 627);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 59;
            this.label7.Text = "Total";
            // 
            // btnReporte
            // 
            this.btnReporte.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnReporte.FlatAppearance.BorderSize = 2;
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnReporte.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(180)))), ((int)(((byte)(227)))));
            this.btnReporte.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnReporte.IconSize = 36;
            this.btnReporte.Location = new System.Drawing.Point(920, 87);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(69, 61);
            this.btnReporte.TabIndex = 67;
            this.btnReporte.Text = "Reportes";
            this.btnReporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // OrdenesCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.txtTotalF);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.grpDetalle);
            this.Controls.Add(this.grpOrden);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OrdenesCompras";
            this.Text = "OrdenesCompras";
            this.Load += new System.EventHandler(this.OrdenesCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpDetalle.ResumeLayout(false);
            this.grpDetalle.PerformLayout();
            this.grpOrden.ResumeLayout(false);
            this.grpOrden.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grpDetalle;
        private System.Windows.Forms.TextBox Txt_Costo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Txt_precio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private FontAwesome.Sharp.IconButton btneliminar;
        private FontAwesome.Sharp.IconButton btnagregar;
        private System.Windows.Forms.TextBox Txt_idproducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpOrden;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker Dtp_fechaentrega;
        private System.Windows.Forms.Button button4;
        private FontAwesome.Sharp.IconButton btncancelar;
        private FontAwesome.Sharp.IconButton btninsertar;
        private System.Windows.Forms.TextBox Txt_proveedores;
        private System.Windows.Forms.TextBox Txt_idpedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker Dtp_fechavencimiento;
        private System.Windows.Forms.TextBox txtTotalF;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private FontAwesome.Sharp.IconButton btnReporte;
    }
}