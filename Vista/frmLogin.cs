using CRM.Modelo;
using CRM.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM
{
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();
        }

        //Declaro la conexión
        DbConnection dbcon = new DbConnection();

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //TODO

           VerificoUsuario();

           
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                txtContrasenia.Focus();
            }
        }

        private void txtContrasenia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                VerificoUsuario();
            }
        }

        private void VerificoUsuario()
        {
            string query = "SELECT Id, Usuario,Nombre, Password, Privilegio FROM Acceso_Usuario WHERE Usuario = @Usuario";

            using (SqlConnection conn = new SqlConnection(dbcon.conn_str))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    //add a parameter to sql query
                    cmd.Parameters.AddWithValue("Usuario", txtUsuario.Text);

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            //read the first row that reader returned and save password from DB into variable
                            reader.Read();
                            string username = reader["Usuario"].ToString();
                            string password = reader["Password"].ToString();
                            string priviledgeLevel = reader["Privilegio"].ToString();

                            if (reader.Read() == true)
                            {

                                return;
                            }

                            else if (txtContrasenia.Text == password)
                            {

                                //If password entered in txtContrasenia matches the one	                                  
                                //retrieved from DB then login is successful.
                                this.Visible = false;

                                //Create new form2 and pass it the 'priviledgeLevel' parameter
                                frmMain frm2 = new frmMain();
                                frm2.ShowDialog();
                                this.Close();


                            }
                            else if (txtUsuario.Text != username || txtContrasenia.Text != password)
                            {
                                MessageBox.Show("Password Invalido", "Login de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }
                        else
                        {
                            MessageBox.Show("Acceso Invalido", "UserLogin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

       
    }
}
