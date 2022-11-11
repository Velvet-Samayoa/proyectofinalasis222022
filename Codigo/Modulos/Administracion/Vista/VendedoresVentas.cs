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
    public partial class VendedoresVentas : Form
    {
        csControladorF cf = new csControladorF();
        public Form actual = new Form();
        public string idventa;
        public string idtotal;
        public string idPuesto;
        public string comison;
        public TextBox[] textvende = { };
        public TextBox[] textventas = { };
        public TextBox[] textpuesto = { };


       
        public VendedoresVentas()
        {
            InitializeComponent();
            TextBox[] textven = { txtname, txtEstado  };
            textvende = textven;
            TextBox[] textotal = { txtTotal };
            textventas = textotal;
            TextBox[] txtpuestotra = { txtPuesto };
            textpuesto = txtpuestotra;
        }
        
       
        private void VendedoresVentas_Load(object sender, EventArgs e)
        {
           
            cf.llenarcombopuestotra(cbxPuesto);
            cf.llenarcombo2(cbxVenta);
            
            



        }
        
        private void cbxIdv_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            txtIdVendedor.Text = Convert.ToString(cbxIdv.SelectedItem);
            idventa = Convert.ToString(cbxIdv.SelectedItem);
            cf.Vendedor(idventa, textvende);
            
            /* inter = Convert.ToString(comboBox1.SelectedItem);
             if (inter == "Activo")
             {
                 activo = "1";
                 TxtEstado.Text = activo;
             }
             else
             {
                 inactivo = "0";
                 TxtEstado.Text = inactivo;
             }
             /*TxtEstado.Text = Convert.ToString(comboBox1.SelectedItem);*/

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void cbxVenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCodVenta.Text = Convert.ToString(cbxVenta.SelectedItem);
            idtotal = Convert.ToString(cbxVenta.SelectedItem);
            cf.Ventas(idtotal, textventas);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text=="" && txtPor.Text=="")
            {
                MessageBox.Show("Campo Vacio, por favor llenar Total Venta y Porcentaje Comisión");
            }
            else if (txtTotal.Text == "")
            {
                MessageBox.Show("Campo Vacio, por favor llenar Total Venta ");
            }
            else if (txtPor.Text == "")
            {
                MessageBox.Show("Campo Vacio, por favor llenar Porcentaje Comisión ");
            }
            else
            {
                
                float tl = 0;
                float porcen = 0;
                float com = 0;

                tl = float.Parse(txtTotal.Text);
                porcen = float.Parse(txtPor.Text);
               
                com = tl * (porcen / 100);

                comison = Convert.ToString(com);

                txtComision.Text = comison;

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            actual.Close();
        }

        private void cbxPuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIdPuesto.Text = Convert.ToString(cbxPuesto.SelectedItem);
            idPuesto = Convert.ToString(cbxPuesto.SelectedItem);
            cf.Puestoventas(idPuesto, textpuesto);
            cf.llenarcomboasigpuestraba(cbxIdv, txtIdPuesto);


        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "3106";
            TextBox[] Grupotextbox = { txtId, txtIdVendedor, txtPor, txtComision, txtCodVenta };
            TextBox[] Idtextbox = { txtId, txtIdVendedor };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = dataGridView1;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(dataGridView1, Grupotextbox, "colchoneria");
        }

        private void txtCodVenta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
