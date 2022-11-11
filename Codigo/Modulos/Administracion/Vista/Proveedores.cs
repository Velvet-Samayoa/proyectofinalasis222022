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
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();
        }
        public string activo = "";
        public string inactivo = "";
        public string inter = "";
        private void navegador1_Load(object sender, EventArgs e)
        {
            
        }

        private void navegador1_Load_1(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "3002";
            TextBox[] Grupotextbox = { txtid,txtnombre,txtnit,txttelefono,txtdomicilio,
            txtcorreo,txtRubro, TxtEstado};
            TextBox[] Idtextbox = { txtid, txtnombre };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = dataGridView1;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(dataGridView1, Grupotextbox, "colchoneria");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            inter = Convert.ToString(comboBox1.SelectedItem);
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
        }

        private void TxtEstado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
