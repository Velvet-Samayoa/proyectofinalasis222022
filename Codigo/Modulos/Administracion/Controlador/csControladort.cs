using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using ComprasModelo;
using System.Data;
using System.Windows.Forms;

namespace ComprasControlador
{

    public class csControladort
    {
        Sentenciast sn = new Sentenciast();
        private static string ids;
        public string IDS
        {
            get { return ids; }
            set { ids = value; }
        }


      public static DataTable inventario = new DataTable();
        DataTable detalleventa = new DataTable();





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
        public void llenartablaa(string ntabla, DataGridView tabla, string status)//Funcion para llenar tabla
        {
            try
            {
                OdbcDataAdapter dt = sn.llenartabla(ntabla, status);
                DataTable table = new DataTable();
                dt.Fill(table);
                tabla.DataSource = table;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error:" + e);
            }

        }

        /*public void llenartablaa(DataGridView tabla)//Funcion para llenar tabla
        {
            try
            {
                OdbcDataAdapter dt = sn.tablavendedor("1");
                DataTable table = new DataTable();
                dt.Fill(table);
                tabla.DataSource = table;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error:" + e);
            }

        }*/

        public void llenarcombo(string nombre, ComboBox combo)
        {
            try
            {

                string descripcion = sn.buscardescripcion(nombre);

                OdbcDataAdapter dt = sn.llenarcomboproducto(descripcion);
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

        public void llenardatoscombo(string medida, TextBox[] textbox, string nombre)
        {
            try
            {

                string descripcion = sn.buscardescripcion(nombre);
                string[] datos = sn.camposcombo(medida, descripcion);
                for (int x = 0; x < 4; x++)
                {
                    textbox[x].Text = datos[x];
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Error:" + e);

            }

        }
        public void llenardatostextbox(TextBox[] textbox, string id)
        {
            try
            {

               
                string[] datos = sn.campostextbox(id);
                for (int x = 0; x < 4; x++)
                {
                    textbox[x].Text = datos[x];
                }

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

        public void insertardatagrid(DataGridView tabla, string scantidad, string sprecio, string idproducto, string descripcion, TextBox total, string idpedido, GroupBox group, string costo)
        {

            string[] datos = new string[6];
            bool permiso = Verificarcamposvacios(group);

            if (permiso == true)
            {
                datos[1] = idproducto;
                string existencia = verificarexistencia(datos[1]);
                double cantidad = Convert.ToDouble(scantidad);
                double cantidadactual;

                if (existencia.Equals(0))
                {
                    cantidadactual = 0;
                }
                else if (Convert.ToDouble(existencia) < cantidad)
                {
                    cantidadactual = -1;
                }
                else
                {
                    bool verificacion = verificarvaciodatatable();

                    if (verificacion == true)//existen datos
                    {
                        var (cantidadactualtabla, acceso) = disminuircantidad(datos[1], cantidad);

                        if (acceso == true)
                        {
                            cantidadactual = cantidadactualtabla;
                        }
                        else
                        {
                            cantidadactual = Convert.ToDouble(existencia) - cantidad;
                            llenartablaconstante(datos[1], Convert.ToDouble(existencia), cantidadactual);
                        }

                    }
                    else
                    {
                        cantidadactual = Convert.ToDouble(existencia) - cantidad;
                        llenartablaconstante(datos[1], Convert.ToDouble(existencia), cantidadactual);


                    }
                }


                datos[0] = idpedido;
                datos[2] = cantidad.ToString();
                datos[3] = sprecio.ToString();
                double precio = Convert.ToDouble(sprecio);
                datos[4] = costo;
                datos[5] = (cantidad * precio).ToString();

                if (existencia.Equals(0))
                {
                    string mensaje = "El Producto: " + descripcion + " no tiene existencia";
                    MessageBox.Show(mensaje, " Falta de Existencia  ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (cantidadactual >= 0)
                {
                    tabla.Rows.Add(datos[0], datos[1], datos[2], datos[3], datos[4], datos[5]);
                    double suma = 0;
                    foreach (DataGridViewRow row in tabla.Rows)
                    {
                        suma += Convert.ToDouble(row.Cells["TotalDetalle_DetallePedido"].Value);
                        total.Text = suma.ToString();
                    }

                }

                else
                {

                    string mensaje = "El Producto: " + descripcion + " no tiene existencia";
                    MessageBox.Show(mensaje, " Falta de Existencia  ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                limpiardetallepedido(group);
            }


        }

        public void eliminarfilagrid(DataGridView tabla, TextBox total, GroupBox group)
        {
            int fila = tabla.Rows.Count - 1;

            if (fila > 0 && tabla.CurrentRow.Index < fila)
            {
                aumentarcantidad(tabla);
                tabla.Rows.RemoveAt(tabla.CurrentRow.Index);

                double suma = 0;
                foreach (DataGridViewRow row in tabla.Rows)
                {
                    suma += Convert.ToDouble(row.Cells["TotalDetalle_DetallePedido"].Value);
                    total.Text = suma.ToString();
                }

            }
            limpiardetallepedido(group);

        }

        public string verificarexistencia(string codigo)
        {
            string existencia = sn.verificarexistencia(codigo);

            return existencia;
        }

        void llenartablaconstante(string idproducto, double existencia, double nuevaexistencia)
        {


            int fila = inventario.Rows.Count;
            inventario.Rows.Add();

            inventario.Rows[fila][0] = idproducto;
            inventario.Rows[fila][1] = existencia;
            inventario.Rows[fila][2] = nuevaexistencia;

        }

        bool verificarvaciodatatable()
        {
            int fila = inventario.Rows.Count;
            bool permiso = false;
            if (fila > 0)
            {
                permiso = true;
            }

            return permiso;
        }

        (double, bool) disminuircantidad(string idproducto, double cantidad)
        {
            double nuevacantidad = 0;
            bool acceso = false; //no encontro el id

            for (int x = 0; x < inventario.Rows.Count; x++)
            {
                if (inventario.Rows[x][0].Equals(idproducto))
                {

                    if (cantidad > Convert.ToDouble(inventario.Rows[x][2]))
                    {


                        nuevacantidad = -1;
                    }
                    else if (cantidad == Convert.ToDouble(inventario.Rows[x][2]))
                    {
                        inventario.Rows[x][2] = 0;
                        nuevacantidad = 0;
                    }
                    else
                    {
                        nuevacantidad = Convert.ToDouble(inventario.Rows[x][2]) - cantidad;
                        inventario.Rows[x][2] = nuevacantidad;


                    }
                    acceso = true;
                }
                else
                {
                    acceso = false;
                }

            }



            return (nuevacantidad, acceso);
        }

        public void llenarcolumnasdatatable()
        {
            inventario.Clear();
            inventario.Columns.Clear();
            inventario.Columns.Add("Idproducto");
            inventario.Columns.Add("Existenciaincial");
            inventario.Columns.Add("Existencianueva");

        }

        void aumentarcantidad(DataGridView tabla)
        {
            double nuevacantidad;

            for (int x = 0; x < inventario.Rows.Count; x++)
            {

                if (inventario.Rows[x][0].Equals(tabla.CurrentRow.Cells[1].Value.ToString()))
                {
                    nuevacantidad = Convert.ToDouble(inventario.Rows[x][2]) + Convert.ToDouble(tabla.CurrentRow.Cells[2].Value);
                    inventario.Rows[x][2] = nuevacantidad;



                }

            }

        }

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

        void bloqueargroup(GroupBox group)
        {


            foreach (Control c in group.Controls)
            {
                if (c is TextBox)
                {
                    c.Enabled = false;
                }
                if(c is DateTimePicker)
                {
                    c.Enabled = false;
                }

            }
        }
        void desbloqueargroup(GroupBox group)
        {


            foreach (Control c in group.Controls)
            {
                if (c is TextBox)
                {
                    c.Enabled = true;
                }
                if (c is DateTimePicker)
                {
                    c.Enabled = true;
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


        DateTime fechavencimineto()
        {
            DateTime fechaactual = DateTime.Now.Date;
            DateTime fechavencimineto = fechaactual.AddDays(7);

            return fechavencimineto;
        }

        public void inicio(DateTimePicker vencimineto, TextBox id, TextBox descripcion, TextBox precio, TextBox linea, TextBox total, TextBox vendedor, TextBox cliente, TextBox producto)
        {
            descripcion.Enabled = false;
            precio.Enabled = false;
            linea.Enabled = false;
            total.Enabled = false;
            vencimineto.Value = fechavencimineto();
            vencimineto.Enabled = false;
            vendedor.Enabled = false;
            producto.Enabled = false;
            cliente.Enabled = false;


            id.Enabled = false;

            //crearid(id, "tbl_Producto","p");
            crearid(id, "tblencabezadopedido", " ", "PkId_EncabezadoPedido");


        }

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

        public string crearidwo( string tabla, string campo)//Crea el id siguiente a ingresar
        {
            string textbox = "";
            try
            {
                int incremento = 0;
              
                int permiso = comprobacionvacio(tabla);
                if (permiso != 0)
                {
                    string resultado = sn.buscarid(tabla, campo);
                    incremento = Convert.ToInt32(resultado) + 1;
                    textbox = incremento.ToString();
                }
                else
                {
                    incremento = 1;
                    textbox = incremento.ToString();
                }

             

            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }
            return textbox;
        }

        public void crearidstring(TextBox textbox, string tabla, string codigo, string campo)//Crea el id siguiente a ingresar
        {

            try
            {
                int incremento = 0;
                textbox.Enabled = false;
                int permiso = comprobacionvacio(tabla);
                if (permiso != 0)
                {
                    string resultado = sn.buscarid(tabla, campo);
                    string numero = resultado.Substring(1, 1);
                    codigo = resultado.Substring(0, 1);


                    incremento = Convert.ToInt32(numero) + 1;
                    textbox.Text = codigo + incremento.ToString();
                }
                else
                {

                    textbox.Text = codigo;
                }



            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }
        }



        public string crearidstring(string textbox, string tabla, string codigo, string campo)//Crea el id siguiente a ingresar
        {

            try
            {
                int incremento = 0;

                int permiso = comprobacionvacio(tabla);
                if (permiso != 0)
                {
                    string resultado = sn.buscarid(tabla, campo);
                    resultado += "   ";
                    codigo = resultado.Substring(0, 3);
                    string numero = resultado.Substring(3, 4);



                    incremento = Convert.ToInt32(numero) + 1;
                    textbox = codigo + incremento.ToString();
                }
                else
                {

                    textbox = codigo + "1";

                }

                return textbox;


            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }
            return textbox;
        }
        public int comprobacionvacio(string tabla)
        {
            int resultado = 0;
            resultado = sn.estadotabla(tabla);

            return resultado;
        }

        public void insertarbddetalle(DataGridView tabla)
        {

            if (tabla.Rows.Count > 1)
            {
                string idpedidoo = tabla.Rows[0].Cells[0].Value.ToString();
                for (int x = 0; x < tabla.Rows.Count - 1; x++)
                {
                    string idpedido = tabla.Rows[x].Cells[0].Value.ToString();
                    string idproducto = tabla.Rows[x].Cells[1].Value.ToString();
                    string cantidad = tabla.Rows[x].Cells[2].Value.ToString();
                    string precio = tabla.Rows[x].Cells[3].Value.ToString();
                    string costo = tabla.Rows[x].Cells[4].Value.ToString();
                    string total = tabla.Rows[x].Cells[5].Value.ToString();
                    string fila = x.ToString();
                    string consultadetallepe = "'" + idpedido + "', '" + idproducto + "', '" + cantidad + "', '" + precio + "', '" + costo + "', '" + total + "', '" + fila + "'";
                    string consultadetallepe_campos = "PkId_EncabezadoPedido, FkId_Producto, CantidadDetalle_DetallePedido, PrecioDetalle_DetallePedido, CostoDetalle_DetallePedido,TotalDetalle_DetallePedido, linea";
                    sn.insertar(consultadetallepe, consultadetallepe_campos, "tblDetallePedido");
                }

                OdbcDataAdapter dt = sn.formadortablareserva(idpedidoo);
                DataTable table = new DataTable();
                dt.Fill(table);

                string[] idsproductos = new string[table.Rows.Count];
                int[] cantidadesproducto = new int[table.Rows.Count];
                int[] existenciaproducto = new int[table.Rows.Count];



                int current = 0;
                foreach (DataRow row in table.Rows)
                {
                    string idproducto = row[1].ToString();
                    int cantidad = Convert.ToInt32(row[2]);
                    int existencia = Convert.ToInt32(row[4]);

                    idsproductos[current] = idproducto;
                    cantidadesproducto[current] = cantidad;
                    existenciaproducto[current] = existencia;
                    current++;
                }

                for (int y = 0; y < idsproductos.Length; y++)
                {
                    for (int z = 0; z < idsproductos.Length; z++)
                    {
                        if (idsproductos[z].Equals(idsproductos[y]) && y < z)
                        {

                            cantidadesproducto[y] += cantidadesproducto[z];
                            idsproductos[z] = "";
                            cantidadesproducto[z] = 0;


                        }

                    }

                }

                string idreserva = sn.buscarid("tblEncabezadoReservacionPedido", "PkId_Reserva");
                for (int x = 0; x < idsproductos.Length; x++)
                {

                    if (idsproductos[x] != null && idsproductos[x] != "")
                    {
                        string consultadetallereserva = "'" + idreserva + "', '" + idsproductos[x] + "', " + cantidadesproducto[x] + ", " + existenciaproducto[x] + ", " + (existenciaproducto[x] - cantidadesproducto[x]) + ", " + x;
                        string consultadetallereserva_campos = "Pk_Reserva, Id_producto, CantidadDescontar_DetalleReservacionPedido, ExistenciaAnterior_DetalleReservacionPedido, ExistenciaNueva_DetalleReservacionPedido, linea_DetalleReservacionPedido";
                        sn.insertar(consultadetallereserva, consultadetallereserva_campos, "tbldetallereservacionpedido");
                        sn.actualizarexistenciaproducto(idsproductos[x], (existenciaproducto[x] - cantidadesproducto[x]).ToString());
                    }



                }
            }

        }

        public void insertardbencabezado(TextBox[] textbox, DateTimePicker dtp, GroupBox groupBox)
        {

            bool permiso = Verificarcamposvacios(groupBox);
            if (permiso == true)
            {
                string idasociado = verificarasociacion(textbox[0].Text, textbox[1].Text);


                string consultaenpedido = textbox[2].Text + ", '" + idasociado + "', '" + dtp.Value.ToString("yyyyMMdd") + "',  '" + DateTime.Now.Date.ToString("yyyyMMdd") + "', " + textbox[3].Text + ", 1";
                string consultaenpedido_campos = "PkId_EncabezadoPedido, FkIdAsociacion, FechaVencimineto_EncabezadoPedido, FechaEmision_EncabezadoPedido, Total_EncabezadoPedido, Estatus_EncabezadoPedido";
                sn.insertar(consultaenpedido, consultaenpedido_campos, "tblencabezadopedido");
                string mensaje = "Pedido Exitoso, tiene hasta: " + dtp.Value.ToString("dd/MM/yyyy") + " para realizar el pago de: Q" + textbox[3].Text;
                MessageBox.Show(mensaje, " Pedido Exitoso  ", MessageBoxButtons.OK, MessageBoxIcon.Information);


                //Reservacion de producto

                string idencabezadopedido = crearidstring("", "tblEncabezadoReservacionPedido", "Rsp", "PkId_Reserva");
                string consultaencabezadopedido = "'" + idencabezadopedido + "', '" + textbox[2].Text + "', 1";
                string consultaencabezadopedido_campos = "PkId_Reserva, FkId_pedido, estatus_Reserva";
                sn.insertar(consultaencabezadopedido, consultaencabezadopedido_campos, "tblEncabezadoReservacionPedido");

                textbox[3].Clear();
            }





        }

        public string verificarasociacion(string empleado, string cliente)
        {
            string idasociado;
            string verificador = sn.verificarexistenciaasociacion(empleado, cliente);

            if (verificador == "")
            {
                idasociado = crearidstring("", "tblasociacion", "Asc", "PkId_Asociacion");
                string consulta = "'" + idasociado + "' , " + empleado + " , " + cliente;
                string consulta_campos = "PkId_Asociacion, fk_id_trabajador, FkId_Clientes";

                sn.insertar(consulta, consulta_campos, "tblasociacion");
            }
            else
            {
                idasociado = verificador;
            }



            return idasociado;
        }


        public void limpiarpedido(GroupBox[] group)
        {
            limpiardetallepedido(group[0]);
            limpiardetallepedido(group[1]);
            inventario.Clear();
        }


        


        //metodo inicioventa
        public void inicioventa(TextBox id, TextBox pedido, GroupBox venta, TextBox total, TextBox subtotal)
        {

            limpiardetallepedido(venta);
            bloqueargroup(venta);
            pedido.Enabled = false;
            total.Enabled = false;
            subtotal.Enabled = false;
            crearid(id, "tblventasencabezado", " ", "PkId_VentasEncabezado");
            

        }


       public void llenarventaydetalle(string id, TextBox nombrecliente, DateTimePicker[] fechas, DataGridView tabla, TextBox subtotal, TextBox nit )
        {
            string verificadorpedido = sn.verificarexistenciapedido(id);
            nit.Enabled = true;
            nit.Focus();
            if(verificadorpedido != "")
            {
                string[] datos = new string[3];
                datos = sn.llenarventa(id);
                for(int x = 0; x  < datos.Length; x++)
                {
                    if (datos[x] != "")
                    {
                        fechas[0].Value = Convert.ToDateTime(datos[0]);
                        fechas[1].Value = Convert.ToDateTime(datos[1]);
                        subtotal.Text = datos[2];
                        nombrecliente.Text = datos[3];
                        OdbcDataAdapter dt = sn.formadortabladetalleventainterna(id);
                        detalleventa.Clear();
                        dt.Fill(detalleventa);

                        OdbcDataAdapter dt2 = sn.formadortabladetalleventaexterna(id);
                        DataTable table = new DataTable();
                        dt2.Fill(table);
                        tabla.DataSource = table;
                    }
                }
            
               

            }
            /*else
            {
                string mensaje = "El pedido no existe ó ya a expirado";
                MessageBox.Show(mensaje, " Pedido  ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/


        }

        public void preestablecido(GroupBox[] groupBoxes, TextBox id, TextBox abono, TextBox pedido, DataGridView tabla, TextBox nit)
        {
            limpiardetallepedido(groupBoxes[0]);
            limpiardetallepedido(groupBoxes[1]);
          
            pedido.Enabled = false;
            abono.Enabled = true;
            nit.Enabled = true;
            crearid(id, "tblventasencabezado", " ", "PkId_VentasEncabezado");
            tabla.DataSource = "";
            
        }


        public void eliminarpedido(TextBox idpedido)
        {
            if(idpedido.Text.Length != 0)
            {

            
            sn.eliminarpedidostatuspedido(idpedido.Text);
            sn.eliminarpedidostatusreservapedido(idpedido.Text);
            string idreserva = sn.buscardato("tblencabezadoreservacionpedido", "FkId_pedido", "PkId_Reserva", idpedido.Text);
            
            int lineas = sn.estadotabladrp( idreserva);
                

            for (int x = 0; x < lineas; x++)
            {
              string[] datos =   sn.devolverainventario(idreserva, x.ToString());

              string existencia = sn.buscardato("tbl_producto", "pk_codigo_producto", "existencia",datos[0]);
                    
                    double nuevaexistenica = Convert.ToDouble(existencia) + Convert.ToDouble(datos[1]);
                    
                    sn.actualizarexistenciaproducto(datos[0], nuevaexistenica.ToString());
                
            }
                sn.eliminar(idreserva, "Pk_Reserva", "tbldetallereservacionpedido");
                sn.eliminar(idreserva, "PkId_Reserva", "tblencabezadoreservacionpedido");
                sn.eliminar(idpedido.Text, "PkId_EncabezadoPedido", "tbldetallepedido");
                
                sn.eliminar(idpedido.Text, "PkId_EncabezadoPedido", "tblencabezadopedido");
                string mensaje = "Pedido Eliminado Exitosamente";
                MessageBox.Show(mensaje, " Pedido  ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                string mensaje = "Seleccione un pedido para eliminar";
                MessageBox.Show(mensaje, " Pedido  ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void convertirmoneda(TextBox txtsubtotal, string moneda, TextBox txttotal)
        {
            double total;
        
           double subtotal = Convert.ToDouble(txtsubtotal.Text);
            if (moneda.Equals("$"))//$ cambio Q7.84
            {
               total = subtotal / 7.84;
            }
            else if(moneda.Equals("€"))//€ ambio Q7.75
            {
                
                total = subtotal / 7.75;
            }
            else 
            {
                total = subtotal;
              
            }
            
            txttotal.Text = total.ToString();
        }

        public void calculototalventa( string combotipopago,  TextBox[] textBoxes, string combotipoplazo)
        {
            double descuento = 0, subtotal, valordescuento=0, Total = 0;

            if(combotipopago.Equals("Contado"))
            {
                descuento = 0.13;
            }
            else if(combotipopago.Equals("Plazos"))
            {
                if(combotipoplazo.Equals("15 – 29 días"))
                {
                    descuento = 0.12;
                }
               else if (combotipoplazo.Equals("30 días"))
                {
                    descuento = 0.10;
                }
                else if (combotipoplazo.Equals("31 – 60 días"))
                {
                    descuento = 0.08;
                }
                else if (combotipoplazo.Equals("61 – 90 días"))
                {
                    descuento = 0.06;
                }

            }

            subtotal = Convert.ToDouble(textBoxes[0].Text);
            if(descuento != 0)
            {
                valordescuento = subtotal * descuento;
            }
            
           
            Total = subtotal - valordescuento;
            textBoxes[1].Text = Total.ToString();
        }

        public void calculototalventa(string combotipopago, TextBox[] textBoxes)
        {
            double descuento = 0, subtotal, valordescuento = 0, Total = 0;

            if (combotipopago.Equals("Contado"))
            {
                descuento = 0.13;
            }
            

            subtotal = Convert.ToDouble(textBoxes[0].Text);
            if (descuento != 0)
            {
                valordescuento = subtotal * descuento;
            }


            Total = subtotal - valordescuento;
            textBoxes[1].Text = Total.ToString();
        }

         string[] generarcertificacion()
        {
            string[] datos = new string[3];
            Random r = new Random();
            string idcertificacion = crearidwo("tblcertificacionfacturacion", "PkId_CertificacionFacturacion");
            datos[0] = idcertificacion;
            datos[1] = r.Next(1, 10000).ToString();
            datos[2] = r.Next(1, 10000).ToString();
            string consultaencabezadocertificacion = "'" + idcertificacion + "', '" + datos[1] + "', '" + datos[2] + "'";
            string consultaencabezadocertificacion_campos = "PkId_CertificacionFacturacion, NoDocumento_CertificacionFacturacion, Serie_CertificacionFacturacion";
            sn.insertar(consultaencabezadocertificacion, consultaencabezadocertificacion_campos, "tblcertificacionfacturacion");
            return datos;
        }
        public void insertarventa( TextBox[] textbox, GroupBox[] groupBoxes, ComboBox combo )
        {

           bool verificardorv;
            bool verificardorp;
            bool verificardorvdp;

            if(combo.SelectedItem.ToString().Equals("Contado"))
            {
                verificardorv = Verificarcamposvacios(groupBoxes[0]);
                verificardorp = true;
                verificardorvdp = Verificarcamposvacios(groupBoxes[2]);
                
            }
            else
            {
                verificardorv = Verificarcamposvacios(groupBoxes[0]);
                verificardorp = Verificarcamposvacios(groupBoxes[1]);
                verificardorvdp = Verificarcamposvacios(groupBoxes[2]);
            }

            if (verificardorp == true && verificardorv == true && verificardorvdp == true)
            {
                string asociacion = sn.buscardato("tblencabezadopedido", "PkId_EncabezadoPedido", "FkIdAsociacion", textbox[1].Text);
                string consultaencabezadoventa = "'" + textbox[0].Text + "', '" + textbox[1].Text + "', '" + asociacion + "','" + DateTime.Now.Date.ToString("yyyyMMdd") + "','" + textbox[3].Text + "'";
                string consultaencabezadoventa_campos = "PkId_VentasEncabezado, FKId_Pedido, FkId_Asociacion, FechaVenta_VentasEncabezado, Total_VentasEncabezado";
                sn.insertar(consultaencabezadoventa, consultaencabezadoventa_campos, "tblventasencabezado");

                //ingreso factura
                string[] encabezado = generarcertificacion();
                string idfactura = crearidwo("tblfacturaclientes", "PkId_FacturaClientes");
                string consultaencabezadofactura = "'" + idfactura + "', '" + textbox[0].Text + "', '" + encabezado[0] + "', '" + encabezado[1] + "', '" + encabezado[2] + "', '" + textbox[4].Text + "', '" + DateTime.Now.Date.ToString("yyyyMMdd") + "','" + textbox[3].Text + "'";
                string consultaencabezadovfactura_campos = "PkId_FacturaClientes, FkId_VentasEncabezado, FkId_CertificacionFacturacion, Serie_FacturaClientes, NoDocumento_FacturaClientes, Nit_FacturaClientes, FechaEmision_FacturaClientes, Total_FacturaClientes";
                sn.insertar(consultaencabezadofactura, consultaencabezadovfactura_campos, "tblfacturaclientes");


                //caja clientes
                double saldo = Convert.ToDouble(textbox[3].Text);
                double abono = Convert.ToDouble(textbox[5].Text);
                double saldonuevo = saldo - abono;
                string idcaja = crearidwo("tblcajaclientes", "PkId_CajaClientes");
                string consultaencabezadocaja = "'" + idcaja + "', '" + textbox[0].Text + "', '" + textbox[5].Text + "','" + textbox[3].Text + "','" + saldonuevo + "','" + idfactura + "'";
                string consultaencabezadovcaja_campos = "PkId_CajaClientes, FKId_VentasEncabezado, abono_CajaClientes, SaldoAnterior_CajaClientes, SaldoActualizado_CajaClientes, FkId_FacturaClientes";
                sn.insertar(consultaencabezadocaja, consultaencabezadovcaja_campos, "tblcajaclientes");

                insertardetalleventa(textbox[0].Text, idfactura);
                string dato = " set Estatus_EncabezadoPedido = 0 ";
                string condicion = " where PkId_EncabezadoPedido = '" + textbox[0].Text + "'";
                sn.actualizar("tblencabezadopedido", dato, condicion);

                sn.eliminarpedidostatuspedido(textbox[0].Text);
                string mensaje = "Venta realizada exitosamente";
                MessageBox.Show(mensaje, " Venta  ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            

        }


         void insertardetalleventa(string idventa, string idfactura)
        {
            foreach (DataRow row in detalleventa.Rows)
            {
              

                string consultaencabezadoventadetalle = "'" + idventa + "', '" + row[0] + "', '" + row[1] + "','" + row[2] + "','" + row[3] + "','" + row[4] + "','" + row[5] + "'";
                string consultaencabezadoventadetalle_campos = "PkId_DetalleVenta, FkId_Producto, FkId_EncabezadoPedido, PrecioProducto_DetalleVenta, Cantidad_DetalleVenta, Costo_DetalleVenta, Total_DetalleVenta";
                sn.insertar(consultaencabezadoventadetalle, consultaencabezadoventadetalle_campos, "tbldetalleventa");


                string consultaencabezadofechadetalle = "'" + idfactura + "', '" + row[0] + "', '" + row[3] + "','" + row[2] + "','" + row[4] + "','" + (Convert.ToDouble(row[5]) / 1.12) + "','" + row[5] + "'";
                string consultaencabezadofechadetalle_campos = "PkId_FacturaClientes, FkId_Producto, CantidadProducto_DetalleFacturaClientes, PrecioProducto_DetalleFacturaClientes, Costo_DetalleFacturaClientes, IvaPorCobrar_DetalleFacturaCliente, Total_DetalleFacturaClientes";
                sn.insertar(consultaencabezadofechadetalle, consultaencabezadofechadetalle_campos, "tbldetallefacturaclientes");

            }
            
        }
        public void llenartablaf(string ntabla, DataGridView tabla, DateTimePicker[] fechas)//Funcion para llenar tablafactura
        {
            try
            {
                OdbcDataAdapter dt = sn.llenartablafactura(ntabla, fechas[0].Value.ToString("yyyyMMdd"), fechas[1].Value.ToString("yyyyMMdd"));
                DataTable table = new DataTable();
                dt.Fill(table);
                tabla.DataSource = table;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error:" + e);
            }

        }
        public void llenarcomboformapago( ComboBox combo)
        {
            try
            {



                OdbcDataAdapter dt = sn.llenarcomboformapago();
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

        void limpiargroup(GroupBox group)
        {


            foreach (Control c in group.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }

            }
        }

        public void limpiarventa(GroupBox[] groupBoxes, DataGridView tabla)
        {
            limpiargroup(groupBoxes[0]);
            limpiargroup(groupBoxes[1]);
            limpiargroup(groupBoxes[2]);
            tabla.DataSource = "";

        }

        public void eliminarpedidocaducado()
        {
            OdbcDataAdapter dt = sn.idscaducados();
            DataTable tablacaducados = new DataTable();
            dt.Fill(tablacaducados);
            
            foreach(DataRow r in tablacaducados.Rows)
            {
                sn.eliminarpedidostatuspedido(r[0].ToString());
                sn.eliminarpedidostatusreservapedido(r[0].ToString());
                string idreserva = sn.buscardato("tblencabezadoreservacionpedido", "FkId_pedido", "PkId_Reserva", r[0].ToString());

                int lineas = sn.estadotabladrp(idreserva);


                for (int x = 0; x < lineas; x++)
                {
                    string[] datos = sn.devolverainventario(idreserva, x.ToString());

                    string existencia = sn.buscardato("tbl_producto", "pk_codigo_producto", "existencia", datos[0]);
                    double nuevaexistenica = Convert.ToDouble(existencia) + Convert.ToDouble(datos[1]);
                     sn.actualizarexistenciaproducto(datos[0], nuevaexistenica.ToString());
                   
                }
                sn.eliminar(idreserva, "Pk_Reserva", "tbldetallereservacionpedido");
           
                sn.eliminar(idreserva, "PkId_Reserva", "tblencabezadoreservacionpedido");
                sn.eliminar(r[0].ToString(), "PkId_EncabezadoPedido", "tbldetallepedido");
                sn.eliminar(r[0].ToString(), "PkId_EncabezadoPedido", "tblencabezadopedido");
            }
          
               
        }

    }

}

