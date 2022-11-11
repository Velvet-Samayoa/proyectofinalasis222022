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
    public partial class AyudaCompras : Form
    {
        csControladorF cn = new csControladorF();
        string table, ttipo;

        public AyudaCompras(string tabla, string tipo)
        {

            InitializeComponent();
            table = tabla;
            ttipo = tipo;
        }

        private void Txt_codigo_TextChanged(object sender, EventArgs e)
        {
            cn.llenarfiltro(table, Dgv_ayudapedido, ttipo, Txt_codigo.Text);
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            if (Dgv_ayudapedido.CurrentCell != null)
            {


                cn.IDS = Dgv_ayudapedido.CurrentRow.Cells[0].Value.ToString();

                this.Close();



            }
        }

        private void AyudaCompras_Load(object sender, EventArgs e)
        {
            cn.llenartablaa2(table, Dgv_ayudapedido);
        }
    }
}
