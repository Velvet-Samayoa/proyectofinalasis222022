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
    public partial class FacturaVentas : Form
    {
        csControladort cn = new csControladort();
        public FacturaVentas()
        {
            InitializeComponent();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DateTimePicker[] fechas = {Dtp_inicio, Dtp_fin };
            cn.llenartablaf("tblfacturaclientes", Dgv_factura, fechas);
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            Crv_factura.Visible = true;
            btncancelar.Visible = true;
            ReporteFactura rp = new ReporteFactura();
            facturaventas dsfactura = new facturaventas();
            int filas = Dgv_factura.Rows.Count - 1;

            for(int x = 0; x < filas; x++)
            {
                dsfactura.Tables[0].Rows.Add(
                    new object[]
                    {
                    Dgv_factura[0, x].Value.ToString(),
                    Dgv_factura[1, x].Value.ToString(),
                    Dgv_factura[2, x].Value.ToString(),
                    Dgv_factura[3, x].Value.ToString(),
                    Dgv_factura[4, x].Value.ToString(),
                    Dgv_factura[5, x].Value.ToString(),
                    Dgv_factura[6, x].Value.ToString(),
                    Dgv_factura[7, x].Value.ToString()
                     
                    }
                    ); 

            }
            rp.Load(@"C:\Users\Developer\Desktop\proyectofinalasis222022\Codigo\Modulos\Administracion\Vista\ReporteFactura.rpt");
            rp.SetDataSource(dsfactura);
            Crv_factura.ReportSource = rp;

            

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Crv_factura.Visible = false;
            btncancelar.Visible = false;
        }
    }
}
