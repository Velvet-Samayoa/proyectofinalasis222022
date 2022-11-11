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
    public partial class Traslados : Form
    {
        public Traslados()
        {
            InitializeComponent();
        }
        Controlador cn = new Controlador();
        string table = "tbl_traslados";
        int cont = 1;

        public void getId()
        {
            try
            {
                string dato;
                dato = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtIdBodega.Text = dato;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nError en obtener el valor");
            }
        }
        public void getId1()
        {
            try
            {
                string dato;
                dato = dataGridView3.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = dato;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nError en obtener el valor");
            }
        }

        public void getIds()
        {
            try
            {
                string dato;
                dato = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                if (txtIdProducto.Text == "")
                {
                    txtIdProducto.Text = dato;
                }
                else
                {
                    string valor = txtIdProducto.Text;
                    txtIdProducto.Text = valor + "," + dato;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nError en obtener las aplicaciones del perfil");
            }
        }


        private void navegador1_Load(object sender, EventArgs e)
        {
         
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            getId();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            getId1();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            getIds();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            cont = 1;
            // dataGridView1.Columns.Clear();
            cn.llenarListPuestos(dataGridView1.Tag.ToString(), dataGridView1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            cont = 1;
            // dataGridView1.Columns.Clear();
            cn.llenarListPuestos(dataGridView3.Tag.ToString(), dataGridView3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            cont = 2;
            // dataGridView1.Columns.Clear();
            cn.producto(dataGridView2.Tag.ToString(), dataGridView2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cn.llenartablaa(DtgTraslados.Tag.ToString(), DtgTraslados);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] delimiterChars = { ',' };
            string text = txtIdProducto.Text;
            string[] words = text.Split(delimiterChars);

            foreach (var word in words)
            {
                textBox1.Text = word;
                TextBox[] textbox = { textBox2, txtIdBodega, textBox1, TxtCantidad };
                cn.ingresar(textbox, table);
            }
            string message = "Registro Guardado";
            //actualizardatagriew();

            MessageBox.Show(message);
        }
    }
}
