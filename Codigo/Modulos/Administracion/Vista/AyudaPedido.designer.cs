
namespace ComprasVista
{
    partial class AyudaPedido
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
            this.Dgv_ayudapedido = new System.Windows.Forms.DataGridView();
            this.btninsertar = new FontAwesome.Sharp.IconButton();
            this.Txt_codigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ayudapedido)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_ayudapedido
            // 
            this.Dgv_ayudapedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_ayudapedido.Location = new System.Drawing.Point(12, 164);
            this.Dgv_ayudapedido.Name = "Dgv_ayudapedido";
            this.Dgv_ayudapedido.Size = new System.Drawing.Size(759, 274);
            this.Dgv_ayudapedido.TabIndex = 0;
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
            this.btninsertar.Location = new System.Drawing.Point(339, 24);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(69, 61);
            this.btninsertar.TabIndex = 58;
            this.btninsertar.Text = "Insertar";
            this.btninsertar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btninsertar.UseVisualStyleBackColor = true;
            this.btninsertar.Click += new System.EventHandler(this.btninsertar_Click);
            // 
            // Txt_codigo
            // 
            this.Txt_codigo.Location = new System.Drawing.Point(217, 112);
            this.Txt_codigo.Name = "Txt_codigo";
            this.Txt_codigo.Size = new System.Drawing.Size(316, 20);
            this.Txt_codigo.TabIndex = 59;
            this.Txt_codigo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "Codigo";
            // 
            // AyudaPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(789, 462);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_codigo);
            this.Controls.Add(this.btninsertar);
            this.Controls.Add(this.Dgv_ayudapedido);
            this.Name = "AyudaPedido";
            this.Text = "AyudaPedido";
            this.Load += new System.EventHandler(this.AyudaPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ayudapedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_ayudapedido;
        private FontAwesome.Sharp.IconButton btninsertar;
        private System.Windows.Forms.TextBox Txt_codigo;
        private System.Windows.Forms.Label label1;
    }
}