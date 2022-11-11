using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace ComprasModelo
{
    public class SentenciasJason
    {
        Conexion con = new Conexion();

        //Codigo movimiento clientes
        public OdbcDataAdapter llenartablaMovCliente(string tabla, string tipodato, string dato)
        {
            string sql = "select cli.PkId_Clientes, cli.Nombre_Clientes, caja.abono_CajaClientes, caja.SaldoAnterior_CajaClientes, caja.SaldoActualizado_CajaClientes, cli.status_Cliente from " + tabla + " as caja inner join tblVentasEncabezado as v on caja.FKId_VentasEncabezado = v.PkId_VentasEncabezado inner join tblasociacion as aso on v.FkId_Asociacion = aso.FkId_Clientes inner join tblclientes as cli on aso.FkId_Clientes = cli.PkId_Clientes where " + tipodato + " like ('" + dato + "%');";
            /*string sql = "select * from " + tabla + " where " + tipodato + " like ('" + dato + "%');"; */
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());
            return datatable;

        }
    }
}
