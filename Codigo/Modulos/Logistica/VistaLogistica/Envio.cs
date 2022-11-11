using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ControladorLogistica;

namespace VistaLogistica
{
    public partial class Envio : Form
    {


        Controlador cn = new Controlador();
        string table = "tbl_envio";
        public Envio()
        {
            InitializeComponent();
        }

        private void Envio_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;

            // dataGridView1.Columns.Clear();
            cn.llenartablaa(dataGridView1.Tag.ToString(), dataGridView1);
           // cn.llenarListPuestos(dataGridView1.Tag.ToString(), dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdTransporte.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;

            // dataGridView1.Columns.Clear();
            cn.llenartablaa(dataGridView2.Tag.ToString(), dataGridView2);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdRuta.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdConductor.Text = dataGridView4.CurrentRow.Cells[0].Value.ToString();
        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdLote.Text = dataGridView5.CurrentRow.Cells[0].Value.ToString();
        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdBodega.Text = dataGridView6.CurrentRow.Cells[0].Value.ToString();
        }

        private void dataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdCliente.Text = dataGridView7.CurrentRow.Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;

            // dataGridView1.Columns.Clear();
            cn.llenartablaa(dataGridView4.Tag.ToString(), dataGridView4);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;

            // dataGridView1.Columns.Clear();
            cn.llenartablaa(dataGridView5.Tag.ToString(), dataGridView5);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;

            // dataGridView1.Columns.Clear();
            cn.llenartablaa(dataGridView6.Tag.ToString(), dataGridView6);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;

            // dataGridView1.Columns.Clear();
            cn.llenartablaa(dataGridView7.Tag.ToString(), dataGridView7);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            cn.llenartablaa(dataGridView3.Tag.ToString(), dataGridView3);
        }

        private void button8_Click(object sender, EventArgs e)
        {

                TextBox[] textbox = { txtBuscar, txtIdTransporte, txtIdRuta, txtIdConductor, txtTiempoEstimado,
                TxtFecha, txtIdLote, txtIdBodega, txtIdCliente, txtObservaciones, txtDestino};
                cn.ingresar(textbox, table);
            
            string message = "Registro Guardado";
            //actualizardatagriew();

            MessageBox.Show(message);
        }

        private void navegador1_Load_1(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "2103";
            TextBox[] Grupotextbox = { txtBuscar, txtIdTransporte, txtIdRuta, txtIdConductor, txtTiempoEstimado,
                TxtFecha, txtIdLote, txtIdBodega, txtIdCliente, txtObservaciones, txtDestino };
            TextBox[] Idtextbox = { txtBuscar };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = dataGridView3;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(dataGridView3, Grupotextbox, "colchoneria");
        }
    }
}
