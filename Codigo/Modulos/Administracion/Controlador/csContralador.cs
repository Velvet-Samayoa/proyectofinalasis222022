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
    public class csContralador
    {
        Sentencias sn = new Sentencias();
        public DataTable llenarTbl(string tabla)
        {
            //llenamos nuestro dataTable, entre consulta y el datagridview

            OdbcDataAdapter dt = sn.llenarTbl(tabla);
            DataTable table = new DataTable();
            //la llenamos con los datos obtenidos
            dt.Fill(table);
            return table;
        }
        public DataTable llenarTbl2(string tabla)
        {
            //llenamos nuestro dataTable, entre consulta y el datagridview

            OdbcDataAdapter dt = sn.llenarTbl2(tabla);
            DataTable table = new DataTable();
            //la llenamos con los datos obtenidos
            dt.Fill(table);
            return table;
        }

        public void ingresar(TextBox[] textbox, DataGridView tabla)//Crea cadenas de datos para la insercion
        {
            try
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

                sn.insertar(dato, tipo, tabla.Tag.ToString());
                
            }

            catch (Exception e)
            {
                System.Windows.MessageBox.Show("Error: " + e);
            }

        }

        public void delete(TextBox[] textbox, DataGridView tabla)
        {
            try
            {
                    string campo = textbox[0].Tag.ToString();
                    int clave = int.Parse(textbox[0].Text);
                    sn.eliminar(clave, campo, tabla.Tag.ToString());
                    


            }
            catch (Exception e)
            {
                System.Windows.MessageBox.Show("Error: " + e);
            }

        }

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
