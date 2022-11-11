using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComprasModelo;
using System.Data.Odbc;
using System.Data;
using System.Windows.Forms;

namespace ComprasControlador
{
    
    public class ControladorR
    {
        SentenciasR sn = new SentenciasR();

        public void reporte(string id1)
        {

            string ubicacion1 = "";
            string estado1 = "";
            estado1 = sn.reporteestado(id1);
            ubicacion1 = sn.reporteestado1(id1);
            if (estado1 == "Visible")
            {
                CapaVistaReporteria.visualizar b = new CapaVistaReporteria.visualizar(ubicacion1);
                b.Show();
            }
            else if (ubicacion1 == "")
            {
                MessageBox.Show("No se encuentra guardado el reporte de la aplicación =  " + id1);
            }
            else
            {
                MessageBox.Show("No esta habilitado el reporte");
            }





        }

    }
}
