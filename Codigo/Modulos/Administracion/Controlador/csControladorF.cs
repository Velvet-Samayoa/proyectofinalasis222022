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
    public class csControladorF
    {
        SentenciasF sn = new SentenciasF();
        //Compras
        private static string ids;
        public string IDS
        {
            get { return ids; }
            set { ids = value; }
        }

        static DataTable inventario = new DataTable();
        // insertar2
        public void insertardbencabezado(TextBox[] textbox, DateTimePicker dtp, DateTimePicker dtf, GroupBox groupBox)
        {

            bool permiso = Verificarcamposvacios(groupBox);
            if (permiso == true)
            {
                


                string consultaenpedido = textbox[0].Text + ", '" + textbox[1].Text + "', '" + dtp.Value.ToString("yyyyMMdd") + "',  '" +dtf.Value.ToString("yyyyMMdd")+ "', 1, '" + textbox[2].Text + "' ";
                string consultaenpedido_campos = "PkId_EncabezadoOrdenCompra, FkId_Proveedores, FechaEntrega_EncabezadoOrdenCompra, FechaVencimiento_EncabezadoOrdenCompra, Estatus_EncabezadoOrdenCompra, Total_EncabezadoOrdenCompra";
                sn.insertar(consultaenpedido, consultaenpedido_campos, "tblencabezadoordencompra");
                string mensaje = "Orden Exitoso, tiene hasta: " + dtp.Value.ToString("dd-MM-YY") + " para recibir el producto por la cantidad de: Q" + textbox[2].Text;
                MessageBox.Show(mensaje, " Orden de Compra Exitoso  ", MessageBoxButtons.OK, MessageBoxIcon.Information);


                

                textbox[2].Clear();
            }





        }
        // insertar Compra 
        public void insertardbencabezado2(TextBox[] textbox, DateTimePicker dtp, GroupBox groupBox)
        {

            bool permiso = Verificarcamposvacios(groupBox);
            if (permiso == true)
            {



                string consultaenpedido = "'"+textbox[0].Text + "', '" + textbox[1].Text + "', '"+textbox[2].Text+"', '" + dtp.Value.ToString("yyyyMMdd") + "', '" + textbox[3].Text + "' ";
                string consultaenpedido_campos = "PkId_ComprasEncabezado, FkId_EncabezadoOrdenCompra, FkId_Proveedores, FechaCompra_ComprasEncabezado, Total_ComprasEncabezado";
                sn.insertar(consultaenpedido, consultaenpedido_campos, "tblcomprasencabezado");
                string mensaje = "Compra Exitoso para recibir el producto es por la cantidad de: Q" + textbox[3].Text;
                MessageBox.Show(mensaje, " Compra Exitosa  ", MessageBoxButtons.OK, MessageBoxIcon.Information);




                textbox[3].Clear();
            }





        }
        //Detalle2
        public void insertarbddetalle2(DataGridView tabla, string id, string orden)
        {

            if (tabla.Rows.Count > 1)
            {
                string idpedidoo = tabla.Rows[0].Cells[0].Value.ToString();
                for (int x = 0; x < tabla.Rows.Count - 1; x++)
                {
                    string idpedido = id;
                    string idorden = orden;
                    string idproducto = tabla.Rows[x].Cells[0].Value.ToString();
                    string cantidad = tabla.Rows[x].Cells[1].Value.ToString();
                    string precio = tabla.Rows[x].Cells[2].Value.ToString();
                    string costo = tabla.Rows[x].Cells[3].Value.ToString();
                    string total = tabla.Rows[x].Cells[4].Value.ToString();

                    string consultadetallepe = "'" + idpedido + "', '"+ idproducto + "','" + idorden + "', '" +  precio + "', '" + cantidad + "', '" + costo + "', '" + total + "'";
                    string consultadetallepe_campos = "PkId_ComprasEncabezado, FkId_Producto, FkId_EncabezadoOrdenCompra, Precio_DetalleCompra, Cantidad_DetalleCompra, Costo_DetalleCompra, Total_DetalleCompra";
                    sn.insertar(consultadetallepe, consultadetallepe_campos, "tbldetallecompra");
                }
            }
        }

        //Detalle
        public void insertarbddetalle(DataGridView tabla, string id)
        {

            if (tabla.Rows.Count > 1)
            {
                string idpedidoo = tabla.Rows[0].Cells[0].Value.ToString();
                for (int x = 0; x < tabla.Rows.Count - 1; x++)
                {
                    string idpedido = id;
                    string idproducto = tabla.Rows[x].Cells[0].Value.ToString();
                    string cantidad = tabla.Rows[x].Cells[1].Value.ToString();
                    string precio = tabla.Rows[x].Cells[2].Value.ToString();
                    string costo = tabla.Rows[x].Cells[3].Value.ToString();
                    string total = tabla.Rows[x].Cells[4].Value.ToString();

                    string consultadetallepe = "'" + idpedido + "', '" + idproducto + "', '" + cantidad + "', '" + precio + "', '" + costo + "', '" + total + "'";
                    string consultadetallepe_campos = "PkId_EncabezadoOrdenCompra, FkId_Producto, Cantidad_DetalleOrdenCompra, Precio_DetalleOrdenCompra, Costo_DetalleOrdenCompra, Total_DetalleOrdenCompra";
                    sn.insertar(consultadetallepe, consultadetallepe_campos, "tbldetalleordencompra");
                }
            }
        }

                // Insertar 
                public void llenardatoscombo( TextBox textbox, TextBox text2, string id)
        {
            try
            {

                
                string[] datos = sn.llenarcompra(id);
                textbox.Text = datos[0];
                text2.Text = datos[1];
            }
            catch (Exception e)
            {
                MessageBox.Show("Error:" + e);

            }

        }
        //Inicio
        public void inicio(DateTimePicker vencimineto, DateTimePicker entrega, TextBox id,  TextBox precio, TextBox costo, TextBox total)
        {
      
            precio.Enabled = false;
            costo.Enabled = false;
            total.Enabled = false;
            vencimineto.Value = fechavencimineto();

            vencimineto.Enabled = false;
            entrega.Value = fechavencimineto();

            entrega.Enabled = false;


            id.Enabled = false;

            //crearid(id, "tbl_Producto","p");
            crearid(id, "tblencabezadoordencompra", " ", "PkId_EncabezadoOrdenCompra");


        }
        //Inicio Compras
        public void inicio2( TextBox id, TextBox precio, TextBox costo, TextBox total)
        {

            precio.Enabled = false;
            costo.Enabled = false;
            total.Enabled = false;
           /* vencimineto.Value = fechavencimineto();

            vencimineto.Enabled = false;
            entrega.Value = fechavencimineto();

            entrega.Enabled = false;*/


            id.Enabled = false;

            //crearid(id, "tbl_Producto","p");
            crearid(id, "tblcomprasencabezado", " ", "PkId_ComprasEncabezado");


        }
        // Id
        public void crearid(TextBox textbox, string tabla, string codigo, string campo)//Crea el id siguiente a ingresar
        {

            try
            {
                int incremento = 0;

                int permiso = comprobacionvacio(tabla);
                if (permiso != 0)
                {
                    string resultado = sn.buscarid(tabla, campo);
                    incremento = Convert.ToInt32(resultado) + 1;
                    textbox.Text = incremento.ToString();
                }
                else
                {
                    incremento = 1;
                    textbox.Text = incremento.ToString();
                }



            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }

        }

        public int comprobacionvacio(string tabla)
        {
            int resultado = 0;
            resultado = sn.estadotabla(tabla);

            return resultado;
        }

        //Date
        DateTime fechavencimineto()
        {
            DateTime fechaactual = DateTime.Now.Date;
            DateTime fechavencimineto = fechaactual.AddDays(7);

            return fechavencimineto;
        }
        // Crear Id

        //Limpiar
        public void limpiarpedido(GroupBox[] group)
        {
            limpiardetallepedido(group[0]);
            limpiardetallepedido(group[1]);
            inventario.Clear();
        }
        //Ayuda Compras
        public void llenartablaa2(string ntabla, DataGridView tabla)//Funcion para llenar tabla
        {
            try
            {
                OdbcDataAdapter dt = sn.llenartabla2(ntabla);
                DataTable table = new DataTable();
                dt.Fill(table);
                tabla.DataSource = table;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error:" + e);
            }

        }

        public void llenarfiltro(string ntabla, DataGridView tabla, string tipo, string dato)//Funcion para llenar tabla
        {
            try
            {
                OdbcDataAdapter dt = sn.filtro(ntabla, tipo, dato);
                DataTable table = new DataTable();
                dt.Fill(table);
                tabla.DataSource = table;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error:" + e);
            }

        }
        //Enorme
        public void insertardatagrid(DataGridView tabla, TextBox[] textBoxes, TextBox total,  GroupBox group)
        {

            string[] datos = new string[5];
            bool permiso = Verificarcamposvacios(group);

            if (permiso == true)
            {
                datos[0] = textBoxes[0].Text;
                datos[1] = textBoxes[1].Text;
                datos[2] = textBoxes[2].Text;
                datos[3] = textBoxes[3].Text;
                double precio = Convert.ToDouble(textBoxes[1].Text) * Convert.ToDouble(textBoxes[2].Text);
                datos[4] = precio.ToString();




                tabla.Rows.Add(datos[0], datos[1], datos[2], datos[3], datos[4]);
                double suma = 0;
                foreach (DataGridViewRow row in tabla.Rows)
                {
                    suma += Convert.ToDouble(row.Cells["Total"].Value);
                    total.Text = suma.ToString();
                }

            }


               

                

               

                limpiardetallepedido(group);
            


        }
        //Eliminar
        public void eliminarfilagrid(DataGridView tabla, TextBox total, GroupBox group)
        {
            int fila = tabla.Rows.Count - 1;

            if (fila > 0 && tabla.CurrentRow.Index < fila)
            {
                
                tabla.Rows.RemoveAt(tabla.CurrentRow.Index);

                double suma = 0;
                foreach (DataGridViewRow row in tabla.Rows)
                {
                    suma += Convert.ToDouble(row.Cells["Total"].Value);
                    total.Text = suma.ToString();
                }

            }
            limpiardetallepedido(group);

        }

        //Verificación
        void limpiardetallepedido(GroupBox group)
        {


            foreach (Control c in group.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }

            }
        }
        bool Verificarcamposvacios(GroupBox group)
        {
            bool permiso = false;

            foreach (Control c in group.Controls)
            {
                if (c is TextBox)
                {
                    if (c.Text.Length == 0)
                    {
                        string mensaje = "Por Favor llenar Todos los campos";
                        MessageBox.Show(mensaje, " Campos Vacios  ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        permiso = false;
                        break;
                    }
                    else
                    {
                        permiso = true;
                    }
                }
                if (c is ComboBox)
                {
                    if (c.Text.Length == 0)
                    {

                        string mensaje = "Por Favor llenar Todos los campos";
                        MessageBox.Show(mensaje, " Campos Vacios  ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        permiso = false;
                        break;
                    }
                    else
                    {
                        permiso = true;
                    }

                }

            }
            return permiso;
        }


        //Comisiones
        public void llenartablaa( DataGridView tabla)//Funcion para llenar tabla
        {
            try
            {
                OdbcDataAdapter dt = sn.llenardatagrid();
                DataTable table = new DataTable();
                dt.Fill(table);
                tabla.DataSource = table;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error:" + e);
            }

        }
        //Puesto Trabajo
        public void llenarcombopuestotra(ComboBox combo)
        {
            try
            {



                OdbcDataAdapter dt = sn.llenartabla3("tbl_puestosdetrabajo", "pk_id_puesto","VENDEDOR");
                DataTable table = new DataTable();
                dt.Fill(table);

                int contador = 0;
                combo.Items.Clear();
                foreach (DataRow row in table.Rows)
                {
                    combo.Items.Add(table.Rows[contador][0].ToString());

                    contador++;
                }


            }
            catch (Exception e)
            {
                MessageBox.Show(" " + e);
            }
        }

        //Asignación Puesto Trabajador
        public void llenarcomboasigpuestraba( ComboBox combo, TextBox textBox)
        {
            try
            {

                

                OdbcDataAdapter dt = sn.llenartabla2("tbl_asignacion_puestotrabajador", "fk_id_trabajador",textBox.Text);
                DataTable table = new DataTable();
                dt.Fill(table);

                int contador = 0;
                combo.Items.Clear();
                foreach (DataRow row in table.Rows)
                {
                    combo.Items.Add(table.Rows[contador][0].ToString());

                    contador++;
                }


            }
            catch (Exception e)
            {
                MessageBox.Show("Por Favor llenar número de Puesto" + e);
            }
        }
        //Ventas

        public void llenarcombo2(ComboBox combo)
        {
            try
            {



                OdbcDataAdapter dt = sn.llenartabla("tblventasencabezado", "PkId_VentasEncabezado");
                DataTable table = new DataTable();
                dt.Fill(table);

                int contador = 0;
                combo.Items.Clear();

                foreach (DataRow row in table.Rows)
                {
                    combo.Items.Add(table.Rows[contador][0].ToString());

                    contador++;
                }


            }
            catch (Exception e)
            {
                MessageBox.Show(" " + e);
            }
        }

        public void Vendedor(string id2, TextBox[] textBox)
        {

            string[] campovendedor = new string[2];
            try
            {
                campovendedor = sn.vendedor(id2);
                for(int x=0; x<2; x++)
                {
                    if (x == 0)
                    {
                        textBox[x].Text = campovendedor[x];
                    }
                    if (x == 1)
                    {

                        if (campovendedor[x] == "1")
                        {
                            textBox[x].Text = "Activo";
                        }
                        else
                        {
                            textBox[x].Text = "Inactivo";
                        }
                    }
                }
            }catch (Exception e)
            {
                MessageBox.Show("Error al consultar"+e);
            }
            
        }
        
        public void Ventas(string id3, TextBox[] textbox)
        {
            string campoVenta = "";
            try
            {
                campoVenta = sn.ventas(id3);
                textbox[0].Text = campoVenta;
            }catch(Exception e)
            {
                MessageBox.Show("Error al consultar" + e);
            }
        }

        public void Puestoventas(string idpuesto, TextBox[] textbox)
        {
            string vendedor = "";
            try
            {
                vendedor = sn.puesto2(idpuesto);
                textbox[0].Text = vendedor;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al consultar" + e);
            }
        }


    }
}
