using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using CRM.Modelo;

namespace CRM
{
   
    class DACustomer
    {
        DbConnection dbconnection = new DbConnection();

        private SqlConnection conn;
        private SqlDataAdapter sqlda;
        private DataTable dt;


        private BOCustomer cus;
        

        //initialies Variable
        private String strTable = "";
        private String strFields = "";
        private String strValues = "";
        private String insertStr = "";
        //

        
        //private String strT = "";
        //private String strF = "";
        //private String strV = "";
        //private String inser = "";

        // This is variable for customer Details.....
        private const String thisTable = "Customer";
        private const String cus_ID = "CID";
        private const String cus_Name = "Customer_Name";
        private const String cus_Dbirth = "FNAC";
        private const String cus_Strname = "Street_Name";
        private const String cus_City = "City";
        private const String cus_Email = "EMail";
        private const String cus_Mobile = "Mobile";
        private const String cus_Lnumber = "Land_Number";
        private const String cus_Product = "Product";
        private const String str_FIngreso = "FIngreso";
        private const String Cus_Coment = "Cus_Coment";
        private const String Cus_Orig_Dato = "Orig_Dato";
        private const String Cus_Estado = "Estado";

      

        //Variable for add user
        private const String tbluser = "Access";
        private const String U_Id = "Id";
        private const String U_UName = "Name";
        private const String U_Name = "Username";
        private const String U_Password = "Password";
        private const String U_VPass = "VPassword";
        private const String U_Privilage = "PriviledgeLvl";


        public DACustomer(BOCustomer customer)
        {
            cus = customer;
        }

        public DACustomer()
        {
            // TODO: Complete member initialization
        }
        public void Add(BOCustomer cus)//Execute Customer Details.
        {
            String str = AddStr(cus);
            OpenCnn();
          
            SqlCommand command = new SqlCommand(str,conn);
            command.ExecuteNonQuery();
            CloseConnection();
        }

        public void AddUserAcc(BOCustomer cus)// Execute Addusers For insert Data
        {
            String str = AddUser(cus);
            OpenCnn();

            SqlCommand command = new SqlCommand(str, conn);

            command.ExecuteNonQuery();
            CloseConnection();
        }

        private void OpenCnn()//DataBase connection open
        {
            // 1- initialise connection
         
            conn = new SqlConnection(dbconnection.conn_str);
           
            conn.Open();
        }
      

        public void CloseConnection()//Close Connection
        {
            conn.Close();
        }

        private String AddStr(BOCustomer cus)//Insert Customer Details
        {
            strTable = "INSERT INTO " + thisTable;

            strFields = "("+cus_Name+","+cus_Dbirth+","+cus_Strname+","+cus_City+","+cus_Email+","+cus_Mobile+","+cus_Lnumber+","+cus_Product+","+ str_FIngreso + ","+ Cus_Coment + ","+Cus_Orig_Dato+","+Cus_Estado+")";

            strValues="VALUES('"+cus.NAME+"','"+cus.FNAC+"','"+cus.ADRESS+"','"+cus.CITY+"','"+cus.EMAIL+"','"+cus.MOBILE+"','"+cus.LNUMBER+"','"+cus.PRODUCT+"','"+cus.FINGRESO+"','"+cus.COMENT+"','"+cus.ORIGEN_DATO+"','"+cus.ESTADO+"')";

            insertStr = strTable + strFields + strValues;

            return insertStr;
        }

        private String AddUser(BOCustomer cus)//Insert User Details
        {
            strTable = "INSERT INTO " + tbluser;

          

            strFields = "(" + U_Id +
               "," + U_UName + "," + U_Name + "," + U_Password + "," + U_VPass + "," + U_Privilage + ")";

            strValues = "VALUES('" + cus.UID + "','" + cus.UNAME + "','" + cus.UUNAME + "','" + cus.PASS + "','" + cus.VPASS + "','" + cus.PRVL + "')";

            insertStr = strTable + strFields + strValues;

            return insertStr;
        }
      


        public void Update() //Update Detalles Cliente
        {
            OpenCnn();

            String selectStr = "UPDATE " + thisTable +
                " set " + cus_Name + " = '" + cus.NAME + "'" +
                ", " + cus_Dbirth + " = '" + cus.FNAC + "'" +
                ", " + cus_Strname + " = '" + cus.ADRESS + "'" +
                ", " + cus_City + " = '" + cus.CITY + "'" +
                 ", " + cus_Email + " = '" + cus.EMAIL + "' " +
                 ", " + cus_Mobile + " = '" + cus.MOBILE + "' " +
                  ", " + cus_Lnumber + " = '" + cus.LNUMBER + "' " +
                  ", " + cus_Product + " = '" + cus.PRODUCT + "' " +
                  ", " + str_FIngreso + " = '" + cus.FINGRESO + "' " +
                  ", " + Cus_Coment + " = '" + cus.COMENT + "' " +
                  "," + Cus_Orig_Dato + " = '"+ cus.ORIGEN_DATO + "'"+
                  ","+ Cus_Estado + " = '"+cus.ESTADO+"'"+
                " where CID = '" + cus.CID + "'";


            SqlCommand cmd = new SqlCommand(selectStr, conn);

            cmd.ExecuteNonQuery();

            CloseConnection();
        }


        internal DataSet Finds(string str)
        {
            throw new NotImplementedException();
        }

        public DataSet Find(String arg)//Busca Detalles del cliente
        {
            DataSet ds = null;

            try
            {
                OpenCnn();

                String selectStr = "select * from " + thisTable + " where CID = '" + arg + "'";
                SqlDataAdapter da = new SqlDataAdapter(selectStr, conn);
                ds = new DataSet();
                da.Fill(ds, thisTable);

                CloseConnection();


            }
            catch (Exception e)
            {
                String Str = e.Message;
            }

            return ds;
        }

        public DataSet BuscaClientesXEstado(String arg)//Busca Clientes por estado
        {
            DataSet ds = null;

            try
            {
                OpenCnn();

                String selectStr = "select CID as ID, Customer_Name as Nombre,Cus_Coment as Comentario,Product as Plan_Ahorro ,Mobile as Celular,FIngreso as Fecha_Ingreso,Estado from " + thisTable + " where Estado = '" + arg + "'";
                SqlDataAdapter da = new SqlDataAdapter(selectStr, conn);
                ds = new DataSet();
                da.Fill(ds, thisTable);

                CloseConnection();


            }
            catch (Exception e)
            {
                String Str = e.Message;
            }

            return ds;
        }

        public DataSet BuscaFullDataXEstado(String arg, String fDesde, String fHasta)//Busca Clientes por estado
        {
            DataSet ds = null;

            try
            {
                OpenCnn();

                String selectStr = "select Customer.Customer_Name, " +
                    "Customer.Street_Name, Customer.City, Customer.Email, Customer.Mobile, " +
                    "Customer.Land_Number, Customer.Product, Customer.FIngreso, Customer.Estado, " +
                    "Cliente_Origen.Origen_Cliente from " + thisTable + " INNER JOIN Cliente_Origen " +
                    "ON Customer.Orig_Dato = Cliente_Origen.ID AND Customer.Orig_Dato = Cliente_Origen.ID " +
                    "where Estado = '" + arg +"' " +
                    "and FIngreso between '" + fDesde +"' and '"+fHasta+"'";
                SqlDataAdapter da = new SqlDataAdapter(selectStr, conn);
                ds = new DataSet();
                da.Fill(ds, thisTable);

                CloseConnection();


            }
            catch (Exception e)
            {
                String Str = e.Message;
            }

            return ds;
        }

        public DataSet BuscaFullDataXOrigen(int orig, String fDesde, String fHasta)//Busca Clientes por Origen
        {
            DataSet ds = null;

            try
            {
                OpenCnn();

                String selectStr = "select Customer.Customer_Name," +
                    " Customer.Street_Name, Customer.City, Customer.Email, Customer.Mobile," +
                    " Customer.Land_Number, Customer.Product, Customer.FIngreso, Customer.Estado," +
                    " Cliente_Origen.Origen_Cliente from " + thisTable + " INNER JOIN Cliente_Origen" +
                    " ON Customer.Orig_Dato = Cliente_Origen.ID AND Customer.Orig_Dato = Cliente_Origen.ID " +
                    "where Orig_Dato = '" + orig + "' " +
                    "and FIngreso between '" + fDesde + "' and '" + fHasta + "'";
                SqlDataAdapter da = new SqlDataAdapter(selectStr, conn);
                ds = new DataSet();
                da.Fill(ds, thisTable);

                CloseConnection();


            }
            catch (Exception e)
            {
                String Str = e.Message;
            }

            return ds;
        }

        public DataSet Eliminar(String arg)//Elimina un cliente de la BBDD
        {
            DataSet ds = null;

            try
            {
                OpenCnn();

                String selectStr = "delete from " + thisTable + " where CID = '" + arg + "'";
                SqlDataAdapter da = new SqlDataAdapter(selectStr, conn);
                ds = new DataSet();
                da.Fill(ds, thisTable);

                CloseConnection();
            }
            catch (Exception e)
            {
                String Str = e.Message;
            }

            return ds;
        }

        //Add values for Gridview
        public DataTable GetRecords(string Query)
        {
            conn = new SqlConnection(dbconnection.conn_str);
            conn.Open();
            sqlda = new SqlDataAdapter(Query, conn);
            dt = new DataTable();
            sqlda.Fill(dt);
            conn.Close();
            return dt;
        }
    }
}
