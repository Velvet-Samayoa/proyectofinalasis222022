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
    public partial class Cotizaciones : Form
    {
        string emp = "tblcotizaciones";
        //Estamos instanciando
        csContralador cn = new csContralador();
        public Cotizaciones()
        {
            InitializeComponent();
        }
        public void actualizardatagriew()
        {
            //le pasamos el parametro de la tabla a consultar
            DataTable dt = cn.llenarTbl(emp);
            dataGridView1.DataSource = dt;

        }

        public void limpiar()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox3.Clear();
            dateTimePicker1.CustomFormat = " ";
            dateTimePicker2.CustomFormat = " ";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            textBox5.Text = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            textBox6.Text = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            TextBox[] Grupo = { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8};
            cn.ingresar(Grupo, dataGridView1);
            actualizardatagriew();
            limpiar();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            textBox5.Text = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            textBox6.Text = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            TextBox[] Grupo = { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8};
            cn.delete(Grupo, dataGridView1);
            actualizardatagriew();
            limpiar();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            actualizardatagriew();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            textBox5.Text = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            textBox6.Text = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            TextBox[] Grupo = { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8};
            cn.delete(Grupo, dataGridView1);
            cn.ingresar(Grupo, dataGridView1);
            actualizardatagriew();
            limpiar();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
