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

    public partial class Caja_Proveedores : Form
    {
        ComprasControlador.csContralador cn = new ComprasControlador.csContralador();

        public Caja_Proveedores()
        {
            InitializeComponent();
        }

        private void Caja_Proveedores_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn.fillTableMovClient("tblcajaproveedores", Dgv_CajaProveedores, "PkId_CajaProveedores", txtIdCajaProveedores.Text);
        }
    }
}
