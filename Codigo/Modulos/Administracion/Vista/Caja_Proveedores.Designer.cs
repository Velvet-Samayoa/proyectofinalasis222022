
namespace ComprasVista
{
    partial class Caja_Proveedores
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdCajaProveedores = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Dgv_CajaProveedores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_CajaProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 139);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id Caja Proveedores";
            // 
            // txtIdCajaProveedores
            // 
            this.txtIdCajaProveedores.Location = new System.Drawing.Point(145, 260);
            this.txtIdCajaProveedores.Name = "txtIdCajaProveedores";
            this.txtIdCajaProveedores.Size = new System.Drawing.Size(100, 20);
            this.txtIdCajaProveedores.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(145, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 34);
            this.button1.TabIndex = 12;
            this.button1.Text = "Mostrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dgv_CajaProveedores
            // 
            this.Dgv_CajaProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_CajaProveedores.Location = new System.Drawing.Point(435, 211);
            this.Dgv_CajaProveedores.Name = "Dgv_CajaProveedores";
            this.Dgv_CajaProveedores.Size = new System.Drawing.Size(413, 263);
            this.Dgv_CajaProveedores.TabIndex = 13;
            // 
            // Caja_Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.Dgv_CajaProveedores);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtIdCajaProveedores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Caja_Proveedores";
            this.Text = "Caja_Proveedores";
            this.Load += new System.EventHandler(this.Caja_Proveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_CajaProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdCajaProveedores;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView Dgv_CajaProveedores;
    }
}