using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;

namespace ComprasModelo
{
    public class SentenciasR
    {
        Conexion con = new Conexion();
        public string reporteestado(string id)
        {

            string estado = "";
            string sql1 = "select * from tbl_regreporteria where aplicacion=" + id + ";";
            OdbcCommand cmd = new OdbcCommand(sql1, con.conexion());
            OdbcDataReader s = cmd.ExecuteReader();
            while (s.Read())
            {
                for (int x = 0; x < 5; x++)
                {

                    if (x == 4)
                    {
                        estado = s.GetString(x);
                    }
                }
            }


            return estado;

        }
        public string reporteestado1(string id)
        {

            string ubicacion = "";
            string sql1 = "select * from tbl_regreporteria where aplicacion=" + id + ";";
            OdbcCommand cmd = new OdbcCommand(sql1, con.conexion());
            OdbcDataReader s = cmd.ExecuteReader();
            while (s.Read())
            {
                for (int x = 0; x < 5; x++)
                {

                    if (x == 1)
                    {
                        ubicacion = s.GetString(x);
                    }
                }
            }


            return ubicacion;

        }
    }
}
