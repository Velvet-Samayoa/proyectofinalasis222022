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
    public partial class listclientes : Form
    {
        csControladorJ AdminCn = new csControladorJ();
        public listclientes()
        {
            InitializeComponent();
        }
        public DataGridView tabla;

        private void listclientes_Load(object sender, EventArgs e)
        {
            tabla = dataGridView1;
            AdminCn.fillTableClientList(tabla.Tag.ToString(), dataGridView1);
        }
    }
}
