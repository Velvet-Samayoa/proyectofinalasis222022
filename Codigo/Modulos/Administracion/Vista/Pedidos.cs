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
    public partial class Pedidos : Form
    {
        
        csControladort cn = new csControladort();
        public Pedidos()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
           
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AyudaPedido a = new AyudaPedido("tbl_producto","pk_codigo_producto");
            

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

        private void button4_Click(object sender, EventArgs e)
        {
            AyudaPedido a = new AyudaPedido("tbl_trabajador", "pk_id_trabajador");
           


            if (cn.IDS == null && Txt_idvendedor.Text.Length == 0)
            {
                cn.IDS = null;
                a.Show();
            }
            else
            {
                Txt_idvendedor.Text = cn.IDS;
                cn.IDS = null;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AyudaPedido a = new AyudaPedido("tblClientes", "PkId_Clientes");
           

            if (cn.IDS == null && Txt_idcliente.Text.Length == 0)
            {
                cn.IDS = null;
                a.Show();
            }
            else
            {
                Txt_idcliente.Text = cn.IDS;
                cn.IDS = null;
            }
        }

        private void Txt_idproducto_TextChanged(object sender, EventArgs e)
        {
            TextBox[] campos = { Txt_descripcion, Txt_precio, Txt_linea, Txt_costo };
            if (Txt_idproducto.TextLength != 0 )
            {
                
                cn.llenardatostextbox(campos,Txt_idproducto.Text);
            }
           
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if(Txt_idproducto.Text.Length != 0 && Txt_descripcion.Text.Length != 0 && Txt_precio.Text.Length != 0 && Txt_linea.Text.Length != 0 && Txt_cantidad.Text.Length != 0)
            {
                
                    cn.insertardatagrid(Dgvpedido, Txt_cantidad.Text, Txt_precio.Text, Txt_idproducto.Text, Txt_descripcion.Text, Txt_total, Txt_idpedido.Text, groupBox2, Txt_costo.Text);
                
               
            }
           




        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            TextBox[] limpiar = { Txt_idproducto, Txt_descripcion, Txt_precio, Txt_linea, Txt_cantidad, Txt_costo};
            cn.eliminarfilagrid(Dgvpedido, Txt_total, groupBox2);
        }

        private void Pedidos_Load(object sender, EventArgs e)
        {
            cn.eliminarpedidocaducado();
            cn.llenarcolumnasdatatable();
            cn.inicio(Dtp_fechavencimiento,Txt_idpedido, Txt_descripcion,Txt_precio,Txt_linea, Txt_total, Txt_idvendedor, Txt_idproducto, Txt_idcliente);
        }

        private void Txt_total_TextChanged(object sender, EventArgs e)
        {
            

            
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            if(Dgvpedido.Rows.Count > 1)
            {
                TextBox[] textBoxes = { Txt_idvendedor, Txt_idcliente, Txt_idpedido, Txt_total };
                GroupBox[] groupBoxes = { groupBox1, groupBox2 };
                cn.insertardbencabezado(textBoxes, Dtp_fechavencimiento, groupBox1);
                cn.insertarbddetalle(Dgvpedido);
                cn.limpiarpedido(groupBoxes);
                Dgvpedido.Rows.Clear();

                cn.inicio(Dtp_fechavencimiento, Txt_idpedido, Txt_descripcion, Txt_precio, Txt_linea, Txt_total, Txt_idvendedor, Txt_idproducto, Txt_idcliente);
            }
           
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            GroupBox[] groupBoxes = { groupBox1, groupBox2 };
            cn.limpiarpedido(groupBoxes);
            Dgvpedido.Rows.Clear();
         
            Txt_total.Clear();
            cn.inicio(Dtp_fechavencimiento, Txt_idpedido, Txt_descripcion, Txt_precio, Txt_linea, Txt_total, Txt_idvendedor, Txt_idproducto, Txt_idcliente);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"C:\Users\Developer\Desktop\proyectofinalasis222022\Codigo\Modulos\Administracion\Ayudast\ayudast.chm", "AyudaPedido.html");
        }
    }
}
