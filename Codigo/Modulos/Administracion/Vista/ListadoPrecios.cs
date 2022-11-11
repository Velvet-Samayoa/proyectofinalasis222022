using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComprasVista
{
    public partial class ListadoPrecios : Form
    {
        ComprasControlador.csControladorJ AdminCn = new ComprasControlador.csControladorJ();
        public ListadoPrecios()
        {
            InitializeComponent();
        }
        public DataGridView tabla;

        private void ListadoPrecios_Load(object sender, EventArgs e)
        {
            tabla = Dgv_ListadoPrecios;
            AdminCn.fillTablePriceList(tabla.Tag.ToString(), Dgv_ListadoPrecios, "pk_codigo_producto", txtIdLineaProducto.Text);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string texto = txtIdLineaProducto.Text;
            if (texto == "")
            {
                string message = "Debe Ingresar un Id de linea de inventario";
                MessageBox.Show(message);
            }
            else
            {
                tabla = Dgv_ListadoPrecios;
                AdminCn.fillTablePriceList(tabla.Tag.ToString(), Dgv_ListadoPrecios, "pk_codigo_producto", txtIdLineaProducto.Text);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtIdLineaProducto.Text = " ";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LineaInventario frm = new LineaInventario();
            frm.Show();
        }

    }
}
