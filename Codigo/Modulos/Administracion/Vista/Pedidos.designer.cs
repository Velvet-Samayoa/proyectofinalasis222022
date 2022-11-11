
namespace ComprasVista
{
    partial class Pedidos
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Txt_costo = new System.Windows.Forms.TextBox();
            this.Txt_descripcion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Txt_linea = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_precio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btneliminar = new FontAwesome.Sharp.IconButton();
            this.btnagregar = new FontAwesome.Sharp.IconButton();
            this.Txt_cantidad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_idproducto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHelp = new FontAwesome.Sharp.IconButton();
            this.label9 = new System.Windows.Forms.Label();
            this.Dtp_fechavencimiento = new System.Windows.Forms.DateTimePicker();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btncancelar = new FontAwesome.Sharp.IconButton();
            this.btninsertar = new FontAwesome.Sharp.IconButton();
            this.Txt_idcliente = new System.Windows.Forms.TextBox();
            this.Txt_idvendedor = new System.Windows.Forms.TextBox();
            this.Txt_idpedido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Dgvpedido = new System.Windows.Forms.DataGridView();
            this.PkId_EncabezadoPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkId_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadDetalle_DetallePedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioDetalle_DetallePedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoDetalle_DetallePedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalDetalle_DetallePedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Txt_total = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgvpedido)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Txt_costo);
            this.groupBox2.Controls.Add(this.Txt_descripcion);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.Txt_linea);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.Txt_precio);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btneliminar);
            this.groupBox2.Controls.Add(this.btnagregar);
            this.groupBox2.Controls.Add(this.Txt_cantidad);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.Txt_idproducto);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(940, 137);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DetallePedido";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Txt_costo
            // 
            this.Txt_costo.Location = new System.Drawing.Point(767, 106);
            this.Txt_costo.Name = "Txt_costo";
            this.Txt_costo.Size = new System.Drawing.Size(84, 25);
            this.Txt_costo.TabIndex = 57;
            this.Txt_costo.Visible = false;
            // 
            // Txt_descripcion
            // 
            this.Txt_descripcion.Location = new System.Drawing.Point(400, 30);
            this.Txt_descripcion.Name = "Txt_descripcion";
            this.Txt_descripcion.Size = new System.Drawing.Size(131, 25);
            this.Txt_descripcion.TabIndex = 56;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(276, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 17);
            this.label10.TabIndex = 55;
            this.label10.Text = "Descripcion";
            // 
            // Txt_linea
            // 
            this.Txt_linea.Location = new System.Drawing.Point(400, 67);
            this.Txt_linea.Name = "Txt_linea";
            this.Txt_linea.Size = new System.Drawing.Size(218, 25);
            this.Txt_linea.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(299, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 53;
            this.label8.Text = "Linea";
            // 
            // Txt_precio
            // 
            this.Txt_precio.Location = new System.Drawing.Point(111, 80);
            this.Txt_precio.Name = "Txt_precio";
            this.Txt_precio.Size = new System.Drawing.Size(84, 25);
            this.Txt_precio.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 51;
            this.label5.Text = "Precio";
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
            this.btneliminar.Location = new System.Drawing.Point(797, 27);
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
            this.btnagregar.Location = new System.Drawing.Point(675, 25);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(69, 61);
            this.btnagregar.TabIndex = 45;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // Txt_cantidad
            // 
            this.Txt_cantidad.Location = new System.Drawing.Point(400, 106);
            this.Txt_cantidad.Name = "Txt_cantidad";
            this.Txt_cantidad.Size = new System.Drawing.Size(84, 25);
            this.Txt_cantidad.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(299, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Cantidad";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHelp);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.Dtp_fechavencimiento);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.btncancelar);
            this.groupBox1.Controls.Add(this.btninsertar);
            this.groupBox1.Controls.Add(this.Txt_idcliente);
            this.groupBox1.Controls.Add(this.Txt_idvendedor);
            this.groupBox1.Controls.Add(this.Txt_idpedido);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(940, 144);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pedido";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            this.btnHelp.Location = new System.Drawing.Point(854, 43);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(69, 61);
            this.btnHelp.TabIndex = 66;
            this.btnHelp.Text = "Ayuda";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(375, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 17);
            this.label9.TabIndex = 60;
            this.label9.Text = "Fecha Vencimiento";
            // 
            // Dtp_fechavencimiento
            // 
            this.Dtp_fechavencimiento.Location = new System.Drawing.Point(323, 65);
            this.Dtp_fechavencimiento.Name = "Dtp_fechavencimiento";
            this.Dtp_fechavencimiento.Size = new System.Drawing.Size(295, 25);
            this.Dtp_fechavencimiento.TabIndex = 9;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(224, 61);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(19, 23);
            this.button4.TabIndex = 59;
            this.button4.Text = "?";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(224, 100);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(19, 23);
            this.button3.TabIndex = 50;
            this.button3.Text = "?";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            this.btncancelar.Location = new System.Drawing.Point(752, 42);
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
            this.btninsertar.Location = new System.Drawing.Point(647, 42);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(69, 61);
            this.btninsertar.TabIndex = 57;
            this.btninsertar.Text = "Insertar";
            this.btninsertar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btninsertar.UseVisualStyleBackColor = true;
            this.btninsertar.Click += new System.EventHandler(this.btninsertar_Click);
            // 
            // Txt_idcliente
            // 
            this.Txt_idcliente.Location = new System.Drawing.Point(111, 98);
            this.Txt_idcliente.Name = "Txt_idcliente";
            this.Txt_idcliente.Size = new System.Drawing.Size(107, 25);
            this.Txt_idcliente.TabIndex = 8;
            // 
            // Txt_idvendedor
            // 
            this.Txt_idvendedor.Location = new System.Drawing.Point(111, 61);
            this.Txt_idvendedor.Name = "Txt_idvendedor";
            this.Txt_idvendedor.Size = new System.Drawing.Size(107, 25);
            this.Txt_idvendedor.TabIndex = 7;
            // 
            // Txt_idpedido
            // 
            this.Txt_idpedido.Location = new System.Drawing.Point(111, 29);
            this.Txt_idpedido.Name = "Txt_idpedido";
            this.Txt_idpedido.Size = new System.Drawing.Size(105, 25);
            this.Txt_idpedido.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vendedor";
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
            // Dgvpedido
            // 
            this.Dgvpedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgvpedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgvpedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PkId_EncabezadoPedido,
            this.FkId_Producto,
            this.CantidadDetalle_DetallePedido,
            this.PrecioDetalle_DetallePedido,
            this.CostoDetalle_DetallePedido,
            this.TotalDetalle_DetallePedido});
            this.Dgvpedido.Location = new System.Drawing.Point(12, 305);
            this.Dgvpedido.Name = "Dgvpedido";
            this.Dgvpedido.Size = new System.Drawing.Size(940, 273);
            this.Dgvpedido.TabIndex = 6;
            // 
            // PkId_EncabezadoPedido
            // 
            this.PkId_EncabezadoPedido.HeaderText = "IdPedido";
            this.PkId_EncabezadoPedido.Name = "PkId_EncabezadoPedido";
            // 
            // FkId_Producto
            // 
            this.FkId_Producto.HeaderText = "IdProducto";
            this.FkId_Producto.Name = "FkId_Producto";
            // 
            // CantidadDetalle_DetallePedido
            // 
            this.CantidadDetalle_DetallePedido.HeaderText = "Cantidad";
            this.CantidadDetalle_DetallePedido.Name = "CantidadDetalle_DetallePedido";
            // 
            // PrecioDetalle_DetallePedido
            // 
            this.PrecioDetalle_DetallePedido.HeaderText = "Precio";
            this.PrecioDetalle_DetallePedido.Name = "PrecioDetalle_DetallePedido";
            // 
            // CostoDetalle_DetallePedido
            // 
            this.CostoDetalle_DetallePedido.HeaderText = "Costo";
            this.CostoDetalle_DetallePedido.Name = "CostoDetalle_DetallePedido";
            // 
            // TotalDetalle_DetallePedido
            // 
            this.TotalDetalle_DetallePedido.HeaderText = "Total";
            this.TotalDetalle_DetallePedido.Name = "TotalDetalle_DetallePedido";
            // 
            // Txt_total
            // 
            this.Txt_total.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_total.Location = new System.Drawing.Point(734, 598);
            this.Txt_total.Name = "Txt_total";
            this.Txt_total.Size = new System.Drawing.Size(218, 25);
            this.Txt_total.TabIndex = 58;
            this.Txt_total.TextChanged += new System.EventHandler(this.Txt_total_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(684, 601);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 17);
            this.label11.TabIndex = 57;
            this.label11.Text = "Total";
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(964, 629);
            this.Controls.Add(this.Txt_total);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Dgvpedido);
            this.Name = "Pedidos";
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.Pedidos_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgvpedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private FontAwesome.Sharp.IconButton btneliminar;
        private FontAwesome.Sharp.IconButton btnagregar;
        private System.Windows.Forms.TextBox Txt_cantidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txt_idproducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private FontAwesome.Sharp.IconButton btncancelar;
        private FontAwesome.Sharp.IconButton btninsertar;
        private System.Windows.Forms.TextBox Txt_idcliente;
        private System.Windows.Forms.TextBox Txt_idvendedor;
        private System.Windows.Forms.TextBox Txt_idpedido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Dgvpedido;
        private System.Windows.Forms.TextBox Txt_linea;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Txt_precio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker Dtp_fechavencimiento;
        private System.Windows.Forms.TextBox Txt_descripcion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Txt_total;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn PkId_EncabezadoPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkId_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadDetalle_DetallePedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioDetalle_DetallePedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoDetalle_DetallePedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalDetalle_DetallePedido;
        private System.Windows.Forms.TextBox Txt_costo;
        private FontAwesome.Sharp.IconButton btnHelp;
    }
}