using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CRM.Controlador;

namespace CRM.Modelo
{
    internal class DAEstado
    {

        DbConnection dbconnection = new DbConnection();

        private SqlConnection conn;
        private SqlDataAdapter sqlda;
        private DataTable dt;

       private BOEstado est;
       

        private const string Tabla = "EstadoCliente";
        //private const string ID = "ID";
        // private const string EstadoCliente = "ESTADO_TIPO";

        public DAEstado(BOEstado Estado)
        {
            est = Estado;
        }

        private void OpenCnn()//Conectar la Base de Datos
        {

            conn = new SqlConnection(dbconnection.conn_str);

            conn.Open();
        }

        public void CloseConnection()//Cierra la Conexión
        {
            conn.Close();
        }

        public DataSet BuscaEstado()//Busca los estados del cliente en la BBDD
        {
            DataSet ds = null;

            try
            {
                OpenCnn();

                String selectStr = "select * from " + Tabla + "";
                SqlDataAdapter da = new SqlDataAdapter(selectStr, conn);
                ds = new DataSet();
                da.Fill(ds, Tabla);

                CloseConnection();


            }
            catch (Exception e)
            {
                String Str = e.Message;
            }

            return ds;
        }
    }
}
