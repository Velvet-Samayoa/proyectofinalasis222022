using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloLogistica;
using System.Data.Odbc;
using System.Data;
using System.Windows.Forms;

namespace ControladorLogistica
{

    

    public class Controlador
    {
       Sentencia sn = new Sentencia();

        public void llenartablaa(string ntabla, DataGridView tabla)//Funcion para llenar tabla
        {
            try
            {
                OdbcDataAdapter dt = sn.llenartabla(ntabla);
                DataTable table = new DataTable();
                dt.Fill(table);
                tabla.DataSource = table;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error:" + e);
            }



        }

        public void llenarListPuestos(string ntabla, DataGridView tabla)
        {
            OdbcDataAdapter dt = sn.llenarListaPuesto(ntabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            tabla.DataSource = table;
        }

        public void producto(string ntabla, DataGridView tabla)
        {
            OdbcDataAdapter dt = sn.producto(ntabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            tabla.DataSource = table;
        }

        public void existencia(string ntabla, DataGridView tabla)
        {
            OdbcDataAdapter dt = sn.existencia(ntabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            tabla.DataSource = table;
        }

        public void ingresar(TextBox[] textbox, string tabla)
        {
            string dato = " ";
            string tipo = " ";

            for (int x = 0; x < textbox.Length; x++)
            {

                if (x == textbox.Length - 1)
                {
                    dato += "'" + textbox[x].Text + "'";
                    tipo += textbox[x].Tag.ToString();
                }
                else
                {
                    dato += "'" + textbox[x].Text + "',";
                    tipo += textbox[x].Tag.ToString() + ",";
                }

            }
            sn.insertar(dato, tipo, tabla);
        }

        /*public void llenarListAsignaciones(string ntabla, DataGridView tabla, string id)
        {
            OdbcDataAdapter dt = sn.llenarListaAsignaciones(ntabla, id);
            DataTable table = new DataTable();
            dt.Fill(table);
            tabla.DataSource = table;
        }*/




    }
}
