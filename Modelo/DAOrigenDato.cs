using CRM.Controlador;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CRM.Modelo
{
    internal class DAOrigenDato
    {
        DbConnection dbconnection = new DbConnection();

        private SqlConnection conn;
        private SqlDataAdapter sqlda;
        private DataTable dt;

        private BOOrigenDato origen;

        //iniciar Variables
        private String strTable = "";
        private String strFields = "";
        private String strValues = "";
        private String insertStr = "";
        //

        //Constantes para Origen Cliente
        private const String Origen_Cliente = "Origen_Cliente";


        private const string Tabla = "[dbo].[Cliente_Origen]";
        //private const string ID = "ID";
        // private const string EstadoCliente = "ESTADO_TIPO";

        public DAOrigenDato(BOOrigenDato _OrigenDato)
        {
            origen = _OrigenDato;
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

        public DataSet BuscaOrigen()//Busca el origen del cliente en la BBDD
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

        public DataSet BuscaOrigen(int i)//Busca el origen del cliente en la BBDD
        {
            DataSet ds = null;

            try
            {
                OpenCnn();

                String selectStr = "select * from " + Tabla + "where ID = "+i+"";
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

        public void Update() //Update Origen
        {
            OpenCnn();

            String selectStr = "UPDATE " + Tabla +
                " set Origen_Cliente"+  " = '" + origen.OrigDato + "'" +
               
                " where ID = '" + origen.Id + "'";

            SqlCommand cmd = new SqlCommand(selectStr, conn);

            cmd.ExecuteNonQuery();

            CloseConnection();
        }

        public void Guardar()//Guarda Origen
        {

            try
            {
                OpenCnn();

                String selectStr = "INSERT INTO " + Tabla +
                "(Origen_Cliente) " + "VALUES " + "('" + origen.OrigDato + "')";

                SqlCommand cmd = new SqlCommand(selectStr, conn);

                cmd.ExecuteNonQuery();

                CloseConnection();
            }
            catch (Exception e)
            {
                String Str = e.Message;
            }

        }

        public DataSet Eliminar(String arg)//Elimina un origen de cliente 
        {
            DataSet ds = null;

            try
            {
                OpenCnn();

                String selectStr = "delete from " + Tabla + " where ID = '" + arg + "'";
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
