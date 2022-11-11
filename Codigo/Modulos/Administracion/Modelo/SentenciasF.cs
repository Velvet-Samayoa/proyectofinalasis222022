using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;

namespace ComprasModelo
{
    public class SentenciasF
    {
        Conexion con = new Conexion();
        // Comprobacion
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

        //insertar 

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



        //id
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
        //LLENAR
        
            public string[] llenarcompra(string id)
        {
            string[] dato = new string[2];
            try
            {

                string sql = "select costo_compra, precio_venta  from tbl_producto where pk_codigo_producto = '" + id + "';";
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                OdbcDataReader lr = cmd.ExecuteReader();
                while (lr.Read())
                {
                    dato[0] = lr.GetString(0);
                    dato[1] = lr.GetString(1);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }


            return dato;
        }
        //AyudaCompras
        public OdbcDataAdapter llenartabla2(string tabla)
        {


            string sql = "select * from " + tabla + ";";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());



            return datatable;
        }
        //Compras
        public OdbcDataAdapter filtro(string tabla, string tipodato, string dato)
        {


            string sql = "select * from " + tabla + " where " + tipodato + " like ('" + dato + "%');";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());



            return datatable;
        }


        //Comisiones

        public OdbcDataAdapter llenardatagrid()
        {
            string sql = "select tblcomision.PkId_Comision, tblcomision.fk_id_trabajador, tbl_trabajador.nombre_trabajador,tbl_trabajador.estado_trabajador, tblcomision.PorcentajeComision, tblcomision.LiquidezComision, tblcomision.FkId_VentasEncabezado," +
                "tblventasencabezado.Total_VentasEncabezado from tblcomision inner join tbl_trabajador on tblcomision.fk_id_trabajador = tbl_trabajador.pk_id_trabajador inner join tblventasencabezado on tblcomision.FkId_VentasEncabezado = tblventasencabezado.PkId_VentasEncabezado; ";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());
            return datatable;
        }
        public OdbcDataAdapter llenartabla(string tabla, string campo)
        {


            string sql = "select " + campo + " from " + tabla + ";";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());



            return datatable;
        }
        public OdbcDataAdapter llenartabla3(string tabla, string campo, string campo2)
        {


            string sql = "select " + campo + " from " + tabla + " where nombre_puesto = '" + campo2 + "';";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());



            return datatable;
        }
        public OdbcDataAdapter llenartabla2(string tabla, string campo, string campo2)
        {


            string sql = "select " + campo + " from " + tabla + " where fk_id_puesto = "+campo2+";";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());



            return datatable;
        }
        public string [] vendedor(string id)
        {
            string[] campo = new string[2];
            string sql1 = "select * from tbl_trabajador where pk_id_trabajador ="+id+";";
            OdbcCommand cmd = new OdbcCommand(sql1, con.conexion());
            OdbcDataReader s = cmd.ExecuteReader();
            while (s.Read())
            {
                for(int x=0; x<7; x++)
                {
                    if(x==2)
                    {
                        campo[0] = s.GetString(x);
                    }
                    if(x==6)
                    {
                        campo[1] = s.GetString(x);
                    }
                }
            }

            return campo;
        }
        public string[] puesto(string id)
        {
            string[] campo = new string[1];
            string sql1 = "select * from tbl_trabajador where pk_id_trabajador =" + id + ";";
            OdbcCommand cmd = new OdbcCommand(sql1, con.conexion());
            OdbcDataReader s = cmd.ExecuteReader();
            while (s.Read())
            {
                for (int x = 0; x < 7; x++)
                {
                    if (x == 2)
                    {
                        campo[0] = s.GetString(x);
                    }
                    if (x == 6)
                    {
                        campo[1] = s.GetString(x);
                    }
                }
            }

            return campo;
        }




        public string ventas(string id)
        {
            string campo = "";
            string sql1 = "select * from tblventasencabezado where PkId_VentasEncabezado =" + id + ";";
            OdbcCommand cmd = new OdbcCommand(sql1, con.conexion());
            OdbcDataReader s = cmd.ExecuteReader();
            while (s.Read())
            {
                for (int x = 0; x < 5; x++)
                {
                    if (x == 4)
                    {
                        campo = s.GetString(x);
                    }
                }
            }

            return campo;
        }
        public string puesto2(string id)
        {
            string campo = "";
            string sql1 = "select * from tbl_puestosdetrabajo where pk_id_puesto =" + id + ";";
            OdbcCommand cmd = new OdbcCommand(sql1, con.conexion());
            OdbcDataReader s = cmd.ExecuteReader();
            while (s.Read())
            {
                for (int x = 0; x < 3; x++)
                {
                    if (x == 1)
                    {
                        campo = s.GetString(x);
                    }
                }
            }

            return campo;
        }
    }
}
