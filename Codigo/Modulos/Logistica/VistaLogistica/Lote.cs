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
    public partial class Lote : Form
    {
        public Lote()
        {
            InitializeComponent();
        }

        Controlador cn = new Controlador();
        string table = "tbl_lote";



        public void getIds()
        {
            try
            {
                string dato;
                dato = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                if (textBox5.Text == "")
                {
                    textBox5.Text = dato;
                }
                else
                {
                    string valor = textBox5.Text;
                    textBox5.Text = valor + "," + dato;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nError en obtener las aplicaciones del perfil");
            }
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Lote_Load(object sender, EventArgs e)
        {

        }

        private void navegador1_Load(object sender, EventArgs e)
        {
           
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            getIds();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            //cont = 2;
            // dataGridView1.Columns.Clear();
            cn.producto(dataGridView2.Tag.ToString(), dataGridView2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            char[] delimiterChars = { ',' };
            string text = textBox5.Text;
            string[] words = text.Split(delimiterChars);

            foreach (var word in words)
            {
                textBox3.Text = word;
                TextBox[] textbox = { textBox6, textBox3, textBox4 };
                cn.ingresar(textbox, table);
            }
            string message = "Registro Guardado";
            //actualizardatagriew();

            MessageBox.Show(message);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cn.llenartablaa(dataGridView1.Tag.ToString(), dataGridView1);
        }
    }
}
