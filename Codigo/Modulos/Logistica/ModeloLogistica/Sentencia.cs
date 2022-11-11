using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloLogistica
{
    public class Sentencia
    {
        Conexion con = new Conexion();

        public OdbcDataAdapter llenartabla(string tabla)
        {
            Conexion con = new Conexion();

            string sql = "select * from " + tabla + ";";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());

            return datatable;
        }


        public OdbcDataAdapter llenarListaPuesto(string tabla)
        {
            string sql = "select  pk_codigo_bodega as ID, nombre_bodega AS Bodega, estado_bodega as Estado from tbl_bodega where estado_bodega != 0;";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());
            return datatable;
        }

        public OdbcDataAdapter producto(string tabla)
        {
            string sql = "select  pk_codigo_producto as ID, descripcion AS Producto, estado_producto as Estado from tbl_producto where estado_producto != 0;";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());
            return datatable;
        }

        public OdbcDataAdapter existencia(string tabla)
        {
            string sql = "select  fk_codigo_bodega as ID_BODEGA, fk_codigo_producto AS Producto, existencia_producto as CANTIDAD from tbl_exisbodega ;";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());
            return datatable;
        }

        public void insertar(string dato, string tipo, string tabla)
        {
            string sql = "insert into " + tabla + "(" + tipo + ") values (" + dato + ")";
            try
            {

                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nError en obtener");
            }
        }

        

    }
}
