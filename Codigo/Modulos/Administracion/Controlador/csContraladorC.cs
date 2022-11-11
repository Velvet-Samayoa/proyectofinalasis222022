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
using MessageBox = System.Windows.Forms.MessageBox;

namespace ComprasControlador
{
    public class csContraladorC
    {
        SentenciasC sn = new SentenciasC();
        csControladort cn = new csControladort();
        private static string ids;

        public string IDS
        {
            get { return ids; }
            set { ids = value; }
        }
        public DataTable llenarTbl(string tabla)
        {
            //llenamos nuestro dataTable, entre consulta y el datagridview

            OdbcDataAdapter dt = sn.llenarTbl(tabla);
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

        //Caja clientes
 public void fillCajaCliente(string ntabla, DataGridView tabla, string tipo, string dato)//Funcion para llenar tabla
        {
            try
            {
                OdbcDataAdapter dt = sn.llenarcajaClientes(ntabla, tipo, dato);
                DataTable table = new DataTable();
                dt.Fill(table);
                tabla.DataSource = table;
            }
            catch (Exception e)
            {
                System.Windows.MessageBox.Show("Error:" + e);
            }

        }

        public void llenarCajaCliente(TextBox[] textbox, string idventas)
        {
            try
            {

                string[] datos = sn.camposCClientes(idventas);

                for (int x = 0; x < datos.Length; x++)
                {
                    textbox[x].Text = datos[x];
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Error:" + e);

            }

        }

        public void inicioCaja(TextBox id, DataGridView tabla, TextBox[] textBoxes)
        {
            limpiarTxbx(textBoxes);
            cn.crearid(id, "tblcajaclientes", " ", "PkId_CajaClientes");
            fillTableMovClient("tblcajaclientes", tabla, "PkId_CajaClientes", id.Text);
          

        }

        public void insertarCajaClientes(TextBox[] textBox, string saldoactualizado)
        {
            /*string[] datosCC = new string[5];

            datosCC[0] = idcaja.Text;
            datosCC[1] = abono.Text;*/

            //string consultacaja = textBox[0].Text + ", 2, '" + textBox[1].Text + "',  '" + textBox[3].Text + "',  '" + textBox[2].Text + "',1 ";
            MessageBox.Show(textBox[4].Text);
            string consultacaja = "'" + textBox[0].Text + "', '" + textBox[1].Text + "', '" + textBox[2].Text + "' , '" + textBox[3].Text + "' , '" + saldoactualizado + "' , '" + textBox[4].Text + "'";
            string consultacaja_campos = "PkId_CajaClientes, FKId_VentasEncabezado, abono_CajaClientes, SaldoAnterior_CajaClientes, SaldoActualizado_CajaClientes, FkId_FacturaClientes";
            sn.insertarCC(consultacaja, consultacaja_campos, "tblcajaclientes");

        }
     
        public void limpiarTxbx(TextBox[] textBoxes)
        {
            for(int x = 0; x < textBoxes.Length; x++)
            {
                textBoxes[x].Clear();
            }
        }


    }
}
