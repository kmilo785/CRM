using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace CRM
{
    class BOCustomer
    {
        //Variable para los detalles del cliente
        private String cusCid;
        private String cusName;
        private String cusFNac;
        private String cusStrtname;
        private String cusCity;
        private String cusEmail;
        private String cusMobile;
        private String cusLnumber;
        private String cusProduct;
        private String cusComent;
        private DateTime cusFIngreso = DateTime.Today;
        private String strFIngreso;
        private String cusEstado;
        private int cusOrigenDato;
        
        private DACustomer cusdatafull;

        

        //variable for user
        private String uid;
        private String uuname;
        private String uname;
        private String upassword;
        private String uvpass;
        private String uprivldg;

     

        private String txf;

        public BOCustomer()
        {
            cusdatafull = new DACustomer(this);
        }
        //Property for Customer details...........
        public String CID
        {
            get
            {
                return cusCid;

            }
            set
            {
                try
                {
                    cusCid = value;

                    //if(this.cusCid=="")
                    //{
                    //    MessageBox.Show("Please Provide a Customer ID", "Dealer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //    throw new Exception("Please Provide a ID");
                    //}
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message.ToString());                   
                }
            }
        }
        public String NAME
        {

            get
            {
                return cusName;

            }
            set
            {
                try
                {
                    cusName = value;

                  
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message.ToString());
                }
            }
        }
        public String FNAC
        {

            get
            {
                return cusFNac;
            }
            set
            {

                cusFNac = value;          
            }
        }
        public String ADRESS
        {

            get
            {
                return cusStrtname;
            }
            set
            {

                cusStrtname = value;
            }
        }

        //public DateTime FechaIngreso
        //{
        //    get
        //    {
        //        return cusFIngreso;
        //    }
        //    set
        //    {
        //        cusFIngreso = value;
        //        strFIngreso = cusFIngreso.ToString();
        //    }
        //}

        public String FINGRESO
        {
            get
            {
               
                return strFIngreso;
            }
            set
            {

                strFIngreso = value;
            }
        }

        public String CITY
        {

            get
            {
                return cusCity;
            }
            set
            {

                cusCity = value;
            }
        }
        public String EMAIL
        {

            get
            {
                return cusEmail;
            }
            set
            {

                cusEmail = value;
            }
        }
        public String MOBILE
        {

            get
            {
                return cusMobile;
            }
            set
            {

                cusMobile = value;
            }
        }
        public String LNUMBER
        {

            get
            {
                return cusLnumber;
            }
            set
            {

                cusLnumber = value;
            }
        }

        public String PRODUCT
        {

            get
            {
                return cusProduct;
            }
            set
            {

                cusProduct = value;
            }
        }

        public String COMENT { get => cusComent; set => cusComent = value; }
        public String ESTADO { get => cusEstado; set => cusEstado = value; }
        public int ORIGEN_DATO { get => cusOrigenDato; set => cusOrigenDato = value; }

        public String UID
        {
            get
            {
                return uid;
            }
            set
            {
                try
                {
                    uid = value;
                    if (this.uid == "")
                    {
                        MessageBox.Show("Please Provide ID","User",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        throw new Exception("Please Provide a ID");
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message.ToString());
                }
            }
        }

        public String UUNAME
        {
            get
            {
                return uuname;
            }
            set
            {
                try
                {
                    uuname = value;
                    if (this.uuname == "")
                    {
                        MessageBox.Show("Please Provide Name", "User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        throw new Exception("Please Provide a Name");
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message.ToString());
                }
            }
        }


        public String UNAME
        {
            get
            {
                return uname;
            }
            set
            {
                try
                {
                    uname = value;
                    if (this.uname == "")
                    {
                        MessageBox.Show("Please Provide User Name", "User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        throw new Exception("Please Provide User Name");
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message.ToString());
                }
            }
        }

        public String PASS
        {
            get
            {
                return upassword;
            }
            set
            {
                try
                {
                    upassword = value;
                    if (this.upassword == "")
                    {
                        MessageBox.Show("Please Provide Password", "User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        throw new Exception("Please Provide Password");
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message.ToString());
                }
            }
        }

        public String VPASS
        {
            get
            {
                return uvpass;
            }
            set
            {
                try
                {
                    uvpass = value;
                    if (this.uvpass == "")
                    {
                        MessageBox.Show("Please Provide Password", "User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        throw new Exception("Please Provide Password");
                    }
                    else if (uvpass != upassword)
                    {
                        MessageBox.Show("Password Not Match Please Check", "User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        throw new Exception("Password Not Match Please Check");
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message.ToString());
                }
            }
        }

        public String PRVL
        {
            get
            {
                return uprivldg;
            }
            set
            {
                try
                {
                    uprivldg = value;
                    if (this.uprivldg == "")
                    {
                        MessageBox.Show("Please Provide User Level", "User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        throw new Exception("Please Provide User Level");
                    }
                    //else if (this.uprivldg != "ADMIN" || this.uprivldg != "USER")
                    //{
                    //    MessageBox.Show("Invalid Privilage Category","User",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    //    throw new Exception("Invalid User Level");
                    //}
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message.ToString());
                }
            }
        }

        public void Add()//Customer
        {
            cusdatafull.Add(this);
        }

        public void Users()//user acc
        {
            cusdatafull.AddUserAcc(this);
        }

        public DataSet Find(String str)
        {
            DataSet data = null;

            data = cusdatafull.Find(str);

            return data;

        }

        public DataSet BuscaClientesXEstado(String str)
        {
            DataSet data = null;

            data = cusdatafull.BuscaClientesXEstado(str);

            return data;

        }

        public DataSet BuscaFullDataXEstado(String str, String fDesde, String fHasta)
        {
            DataSet data = null;

            data = cusdatafull.BuscaFullDataXEstado(str,fDesde,fHasta);

            return data;
        }

        public DataSet BuscaFullDataXOrigen(int orig, String fDesde, String fHasta)
        {
            DataSet data = null;

            data = cusdatafull.BuscaFullDataXOrigen(orig, fDesde, fHasta);

            return data;
        }

        public DataSet Eliminar(String str)
        {
            DataSet data = null;

            data = cusdatafull.Eliminar(str);

            return data;
        }


        public void Update()//Update Customer
        {
            cusdatafull.Update();
        }

    }
}
