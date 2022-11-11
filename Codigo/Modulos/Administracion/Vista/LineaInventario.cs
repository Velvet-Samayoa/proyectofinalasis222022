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
    public partial class LineaInventario : Form
    {
        csControladorJ AdminCn = new csControladorJ();
        public LineaInventario()
        {
            InitializeComponent();
        }
        public DataGridView tabla;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LineaInventario_Load(object sender, EventArgs e)
        {
            tabla = Dgv_lineaInventario;
            AdminCn.fillTableLine(tabla.Tag.ToString(), Dgv_lineaInventario);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
