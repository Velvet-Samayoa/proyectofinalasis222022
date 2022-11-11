using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComprasControlador;
namespace ComprasVista
{
    public partial class AyudaVenta : Form
    {
        csControladort cn = new csControladort();
        string table, ttipo;
        public AyudaVenta(string tabla, string tipo)
        {
            InitializeComponent();
            table = tabla;
            ttipo = tipo;
        }

        private void Txt_codigo_TextChanged(object sender, EventArgs e)
        {
            cn.llenarfiltro(table, Dgv_ayudapedido, ttipo, Txt_codigo.Text);
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            if (Dgv_ayudapedido.CurrentCell != null)
            {


                cn.IDS = Dgv_ayudapedido.CurrentRow.Cells[0].Value.ToString();

                this.Close();



            }
        }

        private void AyudaVenta_Load(object sender, EventArgs e)
        {
            cn.llenartablaa(table, Dgv_ayudapedido,"1");
        }
    }
}
