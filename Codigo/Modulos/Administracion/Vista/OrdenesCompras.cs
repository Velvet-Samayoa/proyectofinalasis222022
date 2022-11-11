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
    public partial class OrdenesCompras : Form
    {
        csControladorF cn = new csControladorF();
        ControladorR cnr = new ControladorR();
        public TextBox[] textDetalle = { };
        public TextBox[] texproductos = { };
        public static string idApp;

        public OrdenesCompras()
        {
            InitializeComponent();
            TextBox[] txtDetalleOrden = { Txt_idproducto, TxtCantidad, Txt_precio, Txt_Costo };
            textDetalle = txtDetalleOrden;
            TextBox[] txtproducto = { Txt_Costo, Txt_precio };
            texproductos = txtproducto;
            idApp = "3109";
        }

        private void OrdenesCompras_Load(object sender, EventArgs e)
        {
            cn.inicio(Dtp_fechavencimiento, Dtp_fechaentrega, Txt_idpedido, Txt_precio, Txt_Costo, txtTotalF);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
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

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (Txt_idproducto.Text.Length != 0 && TxtCantidad.Text.Length !=0 &&Txt_Costo.Text.Length != 0 && Txt_precio.Text.Length != 0 )
            {
                //DataGridView tabla, TextBox[] textBoxes, TextBox total, GroupBox group

                    

                    cn.insertardatagrid(dataGridView1, textDetalle, txtTotalF, grpDetalle);
                

            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            
            cn.eliminarfilagrid(dataGridView1, txtTotalF, grpDetalle);
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            GroupBox[] groupBoxes = { grpOrden, grpDetalle };
            cn.limpiarpedido(groupBoxes);
            dataGridView1.Rows.Clear();
            txtTotalF.Clear();
            cn.inicio(Dtp_fechavencimiento, Dtp_fechaentrega, Txt_idpedido, Txt_precio, Txt_Costo, txtTotalF);
        }

        private void Txt_idproducto_TextChanged(object sender, EventArgs e)
        {
            if (Txt_idproducto.TextLength != 0)
            {
                cn.llenardatoscombo(Txt_Costo, Txt_precio, Txt_idproducto.Text);
            }
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = {Txt_idpedido,Txt_proveedores, txtTotalF };
            GroupBox[] groupBoxes = { grpOrden, grpDetalle };
            cn.insertardbencabezado(textBoxes, Dtp_fechavencimiento, Dtp_fechaentrega, grpOrden);
            cn.insertarbddetalle(dataGridView1, Txt_idpedido.Text);
            cn.limpiarpedido(groupBoxes);
            dataGridView1.Rows.Clear();
            cn.inicio(Dtp_fechavencimiento, Dtp_fechaentrega, Txt_idpedido, Txt_precio, Txt_Costo, txtTotalF);
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            Report();
        }
        public void Report()
        {

            cnr.reporte(idApp);

        }
    }
}
