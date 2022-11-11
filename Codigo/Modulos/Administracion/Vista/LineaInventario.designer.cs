
namespace ComprasVista
{
    partial class LineaInventario
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
            this.Dgv_lineaInventario = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_lineaInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_lineaInventario
            // 
            this.Dgv_lineaInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_lineaInventario.Location = new System.Drawing.Point(13, 92);
            this.Dgv_lineaInventario.Name = "Dgv_lineaInventario";
            this.Dgv_lineaInventario.Size = new System.Drawing.Size(260, 159);
            this.Dgv_lineaInventario.TabIndex = 0;
            this.Dgv_lineaInventario.Tag = "tbl_linea";
            this.Dgv_lineaInventario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Linea de invetario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LineaInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 265);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dgv_lineaInventario);
            this.Name = "LineaInventario";
            this.Text = "LineaInventario";
            this.Load += new System.EventHandler(this.LineaInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_lineaInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_lineaInventario;
        private System.Windows.Forms.Label label1;
    }
}