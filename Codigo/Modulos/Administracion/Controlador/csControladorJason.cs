using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using ComprasModelo;
using System.Windows;
using System.Windows.Forms;

namespace ComprasControlador
{
    public class csControladorJason         
    {
        SentenciasJason sn = new SentenciasJason();


        //Codigo movimiento clientes
        public void fillTableMovClient(string ntabla, DataGridView tabla, string tipo, string dato)//Funcion para llenar tabla
        {
            try
            {
                OdbcDataAdapter dt = sn.llenartablaMovCliente(ntabla, tipo, dato);
                DataTable table = new DataTable();
                dt.Fill(table);
                tabla.DataSource = table;
            }
            catch (Exception e)
            {
                System.Windows.MessageBox.Show("Error:" + e);
            }

        } //Fin codigo movimiento Clientes
    }
}
