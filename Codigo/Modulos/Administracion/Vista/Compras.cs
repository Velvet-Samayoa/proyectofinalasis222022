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
    public partial class Compras : Form
    {
        csControladorF cn = new csControladorF();
        ControladorR cnr = new ControladorR();
        public TextBox[] textDetalle = { };
        public static string idApp;
        
        public Compras()
        {
            InitializeComponent();
            TextBox[] txtDetalleOrden = { Txt_idproducto, TxtCantidad, Txt_precio, Txt_Costo };
            textDetalle = txtDetalleOrden;
            idApp = "3110";
        }

        private void grpOrden_Enter(object sender, EventArgs e)
        {

        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = { Txt_idpedido, txtOrden, Txt_proveedores, txtTotalF };
            GroupBox[] groupBoxes = { grpcompra, grpDetalle };
            cn.insertardbencabezado2(textBoxes, Dtp_fechaentrega, grpcompra);
            cn.insertarbddetalle2(dataGridView1, Txt_idpedido.Text, txtOrden.Text);
            cn.limpiarpedido(groupBoxes);
            dataGridView1.Rows.Clear();
            cn.inicio2(Txt_idpedido, Txt_precio, Txt_Costo, txtTotalF);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AyudaCompras a = new AyudaCompras("tblencabezadoordencompra", "PkId_EncabezadoOrdenCompra");


            if (cn.IDS == null && txtOrden.Text.Length == 0)
            {
                cn.IDS = null;
                a.Show();
            }
            else
            {
                txtOrden.Text = cn.IDS;
                cn.IDS = null;
            }
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            AyudaCompras a = new AyudaCompras("tblproveedores", "PkId_Proveedores");


            if (cn.IDS == null && Txt_proveedores.Text.Length == 0)
            {
                cn.IDS = null;
                a.Show();
            }
            else
            {
                Txt_proveedores.Text = cn.IDS;
                cn.IDS = null;
            }
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            AyudaCompras a = new AyudaCompras("tbl_producto", "pk_codigo_producto");


            if (cn.IDS == null && Txt_idproducto.Text.Length == 0)
            {
                cn.IDS = null;
                a.Show();
            }
            else
            {
                Txt_idproducto.Text = cn.IDS;
                cn.IDS = null;
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (Txt_idproducto.Text.Length != 0 && TxtCantidad.Text.Length != 0 && Txt_Costo.Text.Length != 0 && Txt_precio.Text.Length != 0)
            {
                //DataGridView tabla, TextBox[] textBoxes, TextBox total, GroupBox group



                cn.insertardatagrid(dataGridView1, textDetalle, txtTotalF, grpDetalle);


            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            cn.eliminarfilagrid(dataGridView1, txtTotalF, grpDetalle);
        }

        private void Compras_Load(object sender, EventArgs e)
        {
            cn.inicio2(Txt_idpedido, Txt_precio, Txt_Costo, txtTotalF);
        }

        private void Txt_idproducto_TextChanged(object sender, EventArgs e)
        {
            if (Txt_idproducto.TextLength != 0)
            {
                cn.llenardatoscombo(Txt_Costo, Txt_precio, Txt_idproducto.Text);
            }
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            Report();
        }
        public void Report()
        {

            cnr.reporte(idApp);

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            GroupBox[] groupBoxes = { grpcompra, grpDetalle };
            cn.limpiarpedido(groupBoxes);
            dataGridView1.Rows.Clear();
            txtTotalF.Clear();
            cn.inicio2(Txt_idpedido, Txt_precio, Txt_Costo, txtTotalF);
        }
    }
}
