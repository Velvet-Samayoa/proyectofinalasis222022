
namespace ComprasVista
{
    partial class FacturaVentas
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
            this.Dgv_factura = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.Dtp_inicio = new System.Windows.Forms.DateTimePicker();
            this.Dtp_fin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new FontAwesome.Sharp.IconButton();
            this.btnReporte = new FontAwesome.Sharp.IconButton();
            this.Crv_factura = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btncancelar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_factura)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_factura
            // 
            this.Dgv_factura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_factura.Location = new System.Drawing.Point(24, 145);
            this.Dgv_factura.Name = "Dgv_factura";
            this.Dgv_factura.Size = new System.Drawing.Size(653, 216);
            this.Dgv_factura.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fecha Inicio";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // Dtp_inicio
            // 
            this.Dtp_inicio.Location = new System.Drawing.Point(109, 20);
            this.Dtp_inicio.Name = "Dtp_inicio";
            this.Dtp_inicio.Size = new System.Drawing.Size(200, 20);
            this.Dtp_inicio.TabIndex = 11;
            // 
            // Dtp_fin
            // 
            this.Dtp_fin.Location = new System.Drawing.Point(109, 66);
            this.Dtp_fin.Name = "Dtp_fin";
            this.Dtp_fin.Size = new System.Drawing.Size(200, 20);
            this.Dtp_fin.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Fecha de Fin";
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnUpdate.FlatAppearance.BorderSize = 2;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.IconChar = FontAwesome.Sharp.IconChar.ArrowRotateForward;
            this.btnUpdate.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(180)))), ((int)(((byte)(227)))));
            this.btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnUpdate.IconSize = 40;
            this.btnUpdate.Location = new System.Drawing.Point(363, 24);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(69, 61);
            this.btnUpdate.TabIndex = 48;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.btnReporte.Location = new System.Drawing.Point(470, 24);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(69, 61);
            this.btnReporte.TabIndex = 50;
            this.btnReporte.Text = "Reportes";
            this.btnReporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // Crv_factura
            // 
            this.Crv_factura.ActiveViewIndex = -1;
            this.Crv_factura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Crv_factura.Cursor = System.Windows.Forms.Cursors.Default;
            this.Crv_factura.Location = new System.Drawing.Point(12, 105);
            this.Crv_factura.Name = "Crv_factura";
            this.Crv_factura.Size = new System.Drawing.Size(665, 271);
            this.Crv_factura.TabIndex = 51;
            this.Crv_factura.Visible = false;
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
            this.btncancelar.Location = new System.Drawing.Point(587, 24);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(69, 61);
            this.btncancelar.TabIndex = 59;
            this.btncancelar.Text = "Cerrar";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Visible = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // FacturaVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(696, 388);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.Crv_factura);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.Dtp_fin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dtp_inicio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Dgv_factura);
            this.Name = "FacturaVentas";
            this.Text = "FacturaVentas";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_factura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Dgv_factura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker Dtp_inicio;
        private System.Windows.Forms.DateTimePicker Dtp_fin;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private FontAwesome.Sharp.IconButton btnReporte;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer Crv_factura;
        private FontAwesome.Sharp.IconButton btncancelar;
    }
}