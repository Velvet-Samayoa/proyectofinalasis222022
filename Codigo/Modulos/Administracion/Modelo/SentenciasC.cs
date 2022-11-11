using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;

namespace ComprasModelo
{
    public class SentenciasC
    {
        Conexion con = new Conexion();

        // obtener datos de una tabla CAPA MODELO

        //Consulta la BD y dichos datos estarán en un data table
        //Consultamos la tabla que nos han pasado como parametro y lo guardamos en una variable dataTable y la retornamos(lo que obtenga de la consulta que estamos haciendo)
        public OdbcDataAdapter llenarTbl(string tabla)// metodo  que obtinene el contenio de una tabla
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT PkId_Cotizaciones as IdCotizaciones ,fk_codigo_producto as IdProducto,FkId_Vendedores as IdVendedores,FkId_Clientes as IdClientes, Descripcion_Cotizaciones as Descripcion,FechaEmision_Cotizaciones as FechaEmision,FechaVencimiento_Cotizaciones  as FechaVencimiento,Cuotas_Cotizaciones as Cuota,Total_Cotizaciones as Total FROM " + tabla + "  ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }
        public OdbcDataAdapter insertarTbl(string tabla)// metodo  que obtinene el contenio de una tabla
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT * FROM " + tabla + "  ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }

        public void insertar(string dato, string tipo, string tabla)
        {
            try
            {
                string sql = "insert into " + tabla + "(" + tipo + ") values (" + dato + ")";
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                cmd.ExecuteNonQuery();
                System.Windows.MessageBox.Show("Operación correcta!");
            }
            catch (Exception e)
            {

            }
        }

        public void eliminar(int clave, string campo, string tabla)
        {
            try
            {
                string sql = "delete from " + tabla + " where " + campo + "=" + clave + ";";
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                cmd.ExecuteNonQuery();
                System.Windows.MessageBox.Show("Operación correcta!");
            }
            catch (Exception e)
            {

            }

        }
        //Codigo movimiento clientes
        public OdbcDataAdapter llenartablaMovCliente(string tabla, string tipodato, string dato)
        {
            string sql = "select * from " + tabla;
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());
            return datatable;

        }

        //Caja clientes
        public OdbcDataAdapter llenarcajaClientes(string tabla, string tipodato, string dato)
        {

            string sql = "select * from " + tabla + " where " + tipodato + " like ('" + dato + "%');";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());


            return datatable;
        }

        public string[] camposCClientes(string id)
        {
            string[] datos = new string[3];
            string sql = "select SaldoActualizado_CajaClientes, SaldoAnterior_CajaClientes, FkId_FacturaClientes from tblcajaclientes where FKId_VentasEncabezado = '" + id+ "' Order by SaldoActualizado_CajaClientes asc Limit 1";
            OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
            OdbcDataReader lr = cmd.ExecuteReader();
            while (lr.Read())
            {
                datos[0] = lr.GetString(0);
                datos[1] = lr.GetString(1);
                datos[2] = lr.GetString(2);
            }

            return datos;
        }

        public void insertarCC(string dato, string tipo, string tabla)
        {
            try
            {
                string sql = "insert into " + tabla + "(" + tipo + ") values (" + dato + ")";
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }


        }

    }
}
