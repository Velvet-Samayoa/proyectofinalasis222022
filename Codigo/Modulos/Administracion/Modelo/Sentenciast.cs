using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;

namespace ComprasModelo
{
    public class Sentenciast
    {
        Conexion con = new Conexion();

        public OdbcDataAdapter llenartabla(string tabla)
        {


            string sql = "select * from " + tabla + ";";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());



            return datatable;
        }
        public OdbcDataAdapter llenartabla(string tabla, string status)
        {


            string sql = "select * from " + tabla + " where Estatus_EncabezadoPedido = '1' ;";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());



            return datatable;
        }

        public OdbcDataAdapter llenarcomboproducto(string nombre)
        {


            string sql = "select medidas from tbl_Producto where descripcion = '" + nombre + "';";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());



            return datatable;
        }

        public string[] camposcombo(string dato, string dato2)
        {

            string[] datos = new string[4];
            string sql = "select c.descripcion, c.precio_venta, a.nombre_linea, c.costo_compra from tbl_Producto as c inner join tbl_linea as a  on c.fk_linea_inventario = a.pk_codigo_linea  where  c.medidas = '" + dato + "' and c.descripcion = '" + dato2 + "'";
            OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
            OdbcDataReader lr = cmd.ExecuteReader();
            while (lr.Read())
            {

                datos[0] = lr.GetString(0);
                datos[1] = lr.GetString(1);
                datos[2] = lr.GetString(2);
                datos[3] = lr.GetString(3);

            }



            return datos;
        }

        public string[] campostextbox(string id)
        {

            string[] datos = new string[4];
            string sql = "select c.descripcion, c.precio_venta, a.nombre_linea, c.costo_compra from tbl_Producto as c inner join tbl_linea as a  on c.fk_linea_inventario = a.pk_codigo_linea  where  c.pk_codigo_producto = '" + id +  "'";
            OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
            OdbcDataReader lr = cmd.ExecuteReader();
            while (lr.Read())
            {

                datos[0] = lr.GetString(0);
                datos[1] = lr.GetString(1);
                datos[2] = lr.GetString(2);
                datos[3] = lr.GetString(3);

            }



            return datos;
        }

        public OdbcDataAdapter filtro(string tabla, string tipodato, string dato)
        {


            string sql = "select * from " + tabla + " where " + tipodato + " like ('" + dato + "%');";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());



            return datatable;
        }
        public string buscardescripcion(string dato)
        {

            string datos = "";
            string sql = "select descripcion from tbl_producto where pk_codigo_producto = '" + dato + "'";
            OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
            OdbcDataReader lr = cmd.ExecuteReader();
            while (lr.Read())
            {
                datos = lr.GetString(0);
            }

            return datos;
        }

        public string buscaridproducto(string medicion, string descripcion)
        {

            string datos = "";
            string sql = "select pk_codigo_producto from tbl_producto where medidas = '" + medicion + "' and descripcion = '" + descripcion + "'";
            OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
            OdbcDataReader lr = cmd.ExecuteReader();
            while (lr.Read())
            {
                datos = lr.GetString(0);
            }

            return datos;
        }

        public OdbcDataAdapter tablavendedor(string dato)
        {

            string sql = "select * from tbl_trabajador where FKId_Tipoempleado = '" + dato + "'";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());

            return datatable;
        }

        public string verificarexistencia(string codigo)
        {

            string datos = "";
            string sql = "select existencia from tbl_Producto where pk_codigo_producto = '" + codigo + "'";
            OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
            OdbcDataReader lr = cmd.ExecuteReader();
            while (lr.Read())
            {
                datos = lr.GetString(0);
            }

            return datos;
        }

        public int estadotabla(string tabla)
        {
            int dato = 0;
            string sql = "select count(*) as total from " + tabla;
            OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
            OdbcDataReader lr = cmd.ExecuteReader();
            while (lr.Read())
            {

                dato = lr.GetInt32(0);


            }
            return dato;
        }

        public string buscarid(string tabla, string tipo)
        {
            string dato = " ";
            try
            {

                string sql = "select " + tipo + " from " + tabla + " Order by " + tipo + " Desc Limit 1";
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                OdbcDataReader lr = cmd.ExecuteReader();
                while (lr.Read())
                {
                    dato = lr.GetString(0);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }


            return dato;
        }
        public void insertar(string dato, string tipo, string tabla)
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

        public OdbcDataAdapter formadortablareserva(string dato)
        {

            string sql = "select pe.PkId_EncabezadoPedido, dpe.FkId_Producto, dpe.CantidadDetalle_DetallePedido, dpe.TotalDetalle_DetallePedido, pro.existencia from tblDetallePedido as dpe inner join tblencabezadopedido as pe on dpe.PkId_EncabezadoPedido = pe.PkId_EncabezadoPedido inner join tbl_producto as pro on dpe.FkId_Producto = pro.pk_codigo_producto where dpe.PkId_EncabezadoPedido = '" + dato + "'";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());

            return datatable;
        }

        public string verificarexistenciaasociacion(string empleado, string cliente)
        {

            string datos = "";
            string sql = "select PkId_Asociacion from tblasociacion where fk_id_trabajador = '" + empleado + "' and FkId_Clientes = '" + cliente + "'";
            OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
            OdbcDataReader lr = cmd.ExecuteReader();
            while (lr.Read())
            {
                datos = lr.GetString(0);
            }

            return datos;
        }

        public void actualizarexistenciaproducto(string dato, string existencia)
        {
            try
            {
                string sql = "update tbl_producto set existencia = '" + existencia + "' where pk_codigo_producto = '" + dato + "'";
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }


        }
        public string verificarexistenciapedido(string idpedido)
        {

            string datos = "";
            string sql = "select PkId_EncabezadoPedido from tblencabezadopedido where PkId_EncabezadoPedido = '" + idpedido + "' and Estatus_EncabezadoPedido = 1";
            OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
            OdbcDataReader lr = cmd.ExecuteReader();
            while (lr.Read())
            {
                datos = lr.GetString(0);
            }

            return datos;
        }

        public string[] llenarventa(string idpedido)
        {

            string[] datos = new string[4];
            string sql = "select pe.FechaVencimineto_EncabezadoPedido, pe.FechaEmision_EncabezadoPedido, pe.Total_EncabezadoPedido, cli.Nombre_Clientes from tblencabezadopedido as pe inner join tblasociacion as aso on pe.FkIdAsociacion = aso.PkId_Asociacion inner join tblclientes as cli on cli.PkId_Clientes = aso.FkId_Clientes where pe.PkId_EncabezadoPedido like ('" + idpedido + "%');";
            OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
            OdbcDataReader lr = cmd.ExecuteReader();
            while (lr.Read())
            {
                datos[0] = lr.GetString(0);
                datos[1] = lr.GetString(1);
                datos[2] = lr.GetString(2);
                datos[3] = lr.GetString(3);
            }

            return datos;
        }
        public OdbcDataAdapter formadortabladetalleventainterna(string idpedido)
        {

            string sql = "select drp.Id_producto, rp.FkId_pedido, pro.precio_venta, drp.CantidadDescontar_DetalleReservacionPedido, pro.costo_compra, (pro.precio_venta *  drp.CantidadDescontar_DetalleReservacionPedido) as total from tbldetallereservacionpedido as drp inner join tblencabezadoreservacionpedido as rp on rp.PkId_Reserva = drp.Pk_Reserva inner join tbl_producto as pro on pro.pk_codigo_producto = drp.Id_producto where rp.FkId_pedido like ('" + idpedido + "%');";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());

            return datatable;
        }

        public OdbcDataAdapter formadortabladetalleventaexterna(string idpedido)
        {

            string sql = "select rp.FkId_pedido as Pedido, pro.descripcion as Producto,  pro.precio_venta as Precio, drp.CantidadDescontar_DetalleReservacionPedido as Cantidad, (pro.precio_venta *  drp.CantidadDescontar_DetalleReservacionPedido) as total from tbldetallereservacionpedido as drp inner join tblencabezadoreservacionpedido as rp on rp.PkId_Reserva = drp.Pk_Reserva inner join tbl_producto as pro on pro.pk_codigo_producto = drp.Id_producto where rp.FkId_pedido like ('" + idpedido + "%');";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());

            return datatable;
        }

        public void eliminarpedidostatuspedido(string dato)
        {
            try
            {
                string sql = "update tblencabezadopedido set Estatus_EncabezadoPedido = 0 where PkId_EncabezadoPedido = '" + dato + "'";
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }
        }
        public void eliminarpedidostatusreservapedido(string dato)
        {
            try
            {
                string sql = "update tblencabezadoreservacionpedido set estatus_Reserva = 0 where FkId_pedido = '" + dato + "'";
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }
        }

        public string[] devolverainventario(string id, string linea)
        {
            string[] datos = new string[2];
            string sql = "select drp.Id_producto, drp.CantidadDescontar_DetalleReservacionPedido from tbldetallereservacionpedido as drp inner join tblencabezadoreservacionpedido as rp on rp.PkId_Reserva = drp.Pk_Reserva inner join tblencabezadopedido as pe on pe.PkId_EncabezadoPedido = rp.FkId_pedido where rp.estatus_Reserva = 0 and rp.PkId_Reserva = '" + id + "' and drp.linea_DetalleReservacionPedido = '" + linea + "';";
            OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
            OdbcDataReader lr = cmd.ExecuteReader();
            while (lr.Read())
            {
                datos[0] = lr.GetString(0);
                datos[1] = lr.GetString(1);
                
            }

            return datos;
        }


        public int estadotabladrp(string id)
        {
            int dato = 0;
            string sql = "select count(*) as total from tbldetallereservacionpedido where  Pk_Reserva = '"+ id +"'";
            OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
            OdbcDataReader lr = cmd.ExecuteReader();
            while (lr.Read())
            {

                dato = lr.GetInt32(0);


            }
            return dato;
        }

        public string buscardato(string tabla, string id, string campo, string valor)
        {
            string dato = "";
            string sql = "select "+ campo + " from " + tabla + " where  " + id + " = '" + valor + "'";
            OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
            OdbcDataReader lr = cmd.ExecuteReader();
            while (lr.Read())
            {

                dato = lr.GetString(0);


            }
            return dato;
        }

        public void eliminar(string clave, string campo, string tabla)
        {
            try
            {
                string sql = "delete from " + tabla + " where " + campo + "= '" + clave + "' ;";
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }

        }
        public void eliminarreserva(string clave, string campo, string tabla )
        {
            try
            {
                string sql = "delete from " + tabla + " where " + campo + " = '" + clave + "' ;";
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

            }

        }
        public void actualizar(string dato, string condicion, string tabla)
        {
            try
            {
                string sql = "Update " + tabla + " " + dato + " where " + condicion;
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

            }


        }
        public OdbcDataAdapter llenartablafactura(string tabla, string fechai, string fechaf)
        {


            string sql = "select * from " + tabla + " where FechaEmision_FacturaClientes >= '" + fechai + "' and FechaEmision_FacturaClientes <= '" + fechaf + "' ;";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());



            return datatable;
        }
        public OdbcDataAdapter llenarcomboformapago()
        {


            string sql = "select Concepto_Tipo from Tbl_tiposPagos ;";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());



            return datatable;
        }

        public OdbcDataAdapter idscaducados()
        {


            string sql = "select PkId_EncabezadoPedido from tblencabezadopedido where FechaVencimineto_EncabezadoPedido < '"+ DateTime.Now.Date.ToString("yyyyMMdd") + "' and Estatus_EncabezadoPedido = 1;";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());



            return datatable;
        }

    }

}
