using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace ComprasModelo
{
    public class Sentencias
    {
        Conexion con = new Conexion();

        // obtener datos de una tabla CAPA MODELO

        //Consulta la BD y dichos datos estarán en un data table
        //Consultamos la tabla que nos han pasado como parametro y lo guardamos en una variable dataTable y la retornamos(lo que obtenga de la consulta que estamos haciendo)
        public OdbcDataAdapter llenarTbl(string tabla)// metodo  que obtinene el contenio de una tabla
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "select PkId_Cotizaciones as IdCotizaciones ,fk_codigo_producto as IdProducto,tbl_producto.descripcion as Producto, tbl_producto.tipo as Tipo, tbl_producto.fk_marca as Marca,tbl_producto.estado_producto as Estado, Descripcion_Cotizaciones as DescripcionCotizacion,FechaEmision_Cotizaciones as FechaEmision,FechaVencimiento_Cotizaciones  as FechaVencimiento, tbl_producto.precio_venta as Precio, Cuotas_Cotizaciones as Cuota,Total_Cotizaciones as Total from " + tabla + " inner join tbl_producto on tblcotizaciones.fk_codigo_producto = tbl_producto.pk_codigo_producto; ";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }
        public OdbcDataAdapter llenarTbl2(string tabla)// metodo  que obtinene el contenio de una tabla
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "select PkId_CajaProveedores as IdCajaProveedores, FkId_ComprasEncabezado as IdComprasEncabezado,tblcomprasencabezado.FkId_Proveedores as IdProveedores,tblcomprasencabezado.FechaCompra_ComprasEncabezado as FechaCompra,tblcomprasencabezado.Total_ComprasEncabezado as TotalCompra, Saldo_CajaProveedores as Saldo  from " + tabla + " inner join tblcomprasencabezado on tblcajaproveedores.FkId_ComprasEncabezado = tblcomprasencabezado.PkId_ComprasEncabezado;";
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
            string sql = "select * from " + tabla + " where " + tipodato + " like ('" + dato + "%');";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());
            return datatable;

        }
    }
 }
