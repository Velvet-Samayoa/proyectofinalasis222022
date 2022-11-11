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
    public partial class Caja_Clientes : Form
    {

        csContraladorC AdminCn = new csContraladorC();
        //ComprasControlador.csContraladorC AdminCn = new ComprasControlador.csContraladorC();

        public Caja_Clientes()
        {
            InitializeComponent();
        }

        public DataGridView tabla;


        private void Caja_Clientes_Load(object sender, EventArgs e)
        {
                        TextBox[] textBoxes2 = { txtIdCaja, txtVentasE, txtAbono, txtSaldoActualizado, txtIdFactura, txtSaldoAnterior };

            AdminCn.inicioCaja(txtIdCaja, DgvCajaClientes, textBoxes2);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminCn.fillTableMovClient("tblcajaclientes", DgvCajaClientes, "PkId_CajaClientes", txtIdCaja.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AyudaPedido a = new AyudaPedido("tblventasencabezado", "PkId_VentasEncabezado");


            if (AdminCn.IDS == null && txtVentasE.Text.Length == 0)
            {
                AdminCn.IDS = null;
                a.Show();
            }
            else
            {
                txtVentasE.Text = AdminCn.IDS;
                AdminCn.IDS = null;
            }
        }

        private void txtVentasE_TextChanged(object sender, EventArgs e)
        {
            TextBox[] textBoxes = { txtSaldoActualizado, txtSaldoAnterior, txtIdFactura };
            if(txtVentasE.Text != "")
            {
                AdminCn.llenarCajaCliente(textBoxes, txtVentasE.Text);
            }

        }

        private void txtSaldoActualizado_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = { txtIdCaja, txtVentasE, txtAbono, txtSaldoActualizado, txtIdFactura };
            TextBox[] textBoxes2 = { txtIdCaja, txtVentasE, txtAbono, txtSaldoActualizado, txtIdFactura, txtSaldoAnterior };
            double restaCClientes = Convert.ToDouble(txtSaldoActualizado.Text) - Convert.ToDouble(txtAbono.Text);
            MessageBox.Show("La resta es: " + restaCClientes);
            AdminCn.insertarCajaClientes(textBoxes,restaCClientes.ToString());
            AdminCn.inicioCaja(txtIdCaja, DgvCajaClientes, textBoxes2);
            //string cadena = "Update tblcajaclientes set SaldoActualizado_CajaClientes = '" +this.txtSaldoActualizado.Text+ "' Where FKId_VentasEncabezado = '"+this.txtVentasE.Text+"'";
            // string cadena = "insert into tblcajaclientes values ( "+ txtIdCaja.Text+ " ";

        }
    }
}
