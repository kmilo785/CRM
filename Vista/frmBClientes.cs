using CRM.Modelo;
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

namespace CRM.Vista
{
   
    public partial class frmBClientes : Form
    {
        public frmBClientes()
        {
            InitializeComponent();
            this.Autocomplte();
        }

        String estado;
        BOCustomer cus;
        DACustomer das;
        DbConnection con = new DbConnection();
        DataSet dsdata = new DataSet();
        AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();


        #region "Procedimientos"

        private void CambiaColores()
        {
            for (int i = 0; i < dtGrid1.Rows.Count - 1; i++)
            {
                if (dtGrid1.Rows[i].Cells[6].Value.ToString() == "Vendido")
                {
                    dtGrid1.Rows[i].DefaultCellStyle.BackColor = rbVendido.BackColor;
                    dtGrid1.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                }
                else if (dtGrid1.Rows[i].Cells[6].Value.ToString() == "Sin Contacto")
                {
                    dtGrid1.Rows[i].DefaultCellStyle.BackColor = rbSinContacto.BackColor;
                    dtGrid1.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                }
                else if (dtGrid1.Rows[i].Cells[6].Value.ToString() == "Eliminado")
                {
                    dtGrid1.Rows[i].DefaultCellStyle.BackColor = rbEliminado.BackColor;
                    dtGrid1.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                }
                else if (dtGrid1.Rows[i].Cells[6].Value.ToString() == "Stand By")
                {
                    dtGrid1.Rows[i].DefaultCellStyle.BackColor = rbStandBy.BackColor;
                    dtGrid1.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                }
                else if (dtGrid1.Rows[i].Cells[6].Value.ToString() == "En Gestión")
                {
                    dtGrid1.Rows[i].DefaultCellStyle.BackColor = rbEnGestion.BackColor;
                    dtGrid1.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                }
                else if (dtGrid1.Rows[i].Cells[6].Value.ToString() == "Llamar Despues")
                {
                    dtGrid1.Rows[i].DefaultCellStyle.BackColor = rbLlamarDespues.BackColor;
                    dtGrid1.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                }
                else
                {
                    dtGrid1.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }

        private void BuscaEstados()
        {

            if (rbSinContacto.Checked) { estado = "Sin Contacto"; }
            else if (rbEliminado.Checked) { estado = "Eliminado"; }
            else if (rbStandBy.Checked ) { estado = "Stand By"; }
            else if (rbVendido.Checked ) { estado = "Vendido"; }
            else if (rbEnGestion.Checked ) { estado = "En Gestión"; }
            else if (rbEliminado.Checked ) { estado = "Eliminado"; }
            else if (rbLlamarDespues.Checked ) { estado = "Llamar Despues"; }

            String clienteEstado = estado;

            BOCustomer thisCus = new BOCustomer();

            DataSet ds = thisCus.BuscaClientesXEstado(clienteEstado);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No hay resultados","Clientes",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    dtGrid1.DataSource = ds.Tables[0];
                    dtGrid1.Update();

                    CambiaColores();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        #endregion

        #region Auto

        private void Autocomplte()
        {
            SqlDataReader dReader;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = con.conn_str;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select distinct [Customer_Name] from [Customer] order by [Customer_Name] asc";
            conn.Open();
            dReader = cmd.ExecuteReader();
            if (dReader.HasRows == true)
            {
                while (dReader.Read())
                    namesCollection.Add(dReader["Customer_Name"].ToString());

            }
            else
            {
                MessageBox.Show("Data not found");
            }
            dReader.Close();

           this.txtNombre.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtNombre.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtNombre.AutoCompleteCustomSource = namesCollection;

        }
        #endregion

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

            try
            {
                das = new DACustomer();
               dtGrid1.DataSource = das.GetRecords("select CID as ID, Customer_Name as Nombre,Cus_Coment as Comentario,Product as Plan_Ahorro ,Mobile as Celular,FIngreso as Fecha_Ingreso, Estado from Customer where Customer_Name Like '%" + txtNombre.Text + "%' ");

               CambiaColores();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "GridView Bind error");
            }

            finally
            {
                dtGrid1.Refresh();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCelular_TextChanged(object sender, EventArgs e)
        {
            try
            {
                das = new DACustomer();
                dtGrid1.DataSource = das.GetRecords("select cid as ID, Customer_Name as Nombre,Cus_Coment as Comentario,Product as Plan_Ahorro ,Mobile as Celular,FIngreso as Fecha_Ingreso, Estado from Customer where Mobile Like '%" + txtCelular.Text + "%' ");
                CambiaColores();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "GridView Bind error");
            }

            finally
            {
                dtGrid1.Refresh();
            }
        }
        private void dtGrid1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String cusID = dtGrid1.CurrentRow.Cells[0].Value.ToString();
            this.Close();
            Form frm = new frmABMClientes(cusID);
           
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtCelular.Text = "";
            BuscaEstados();

        }
    }
}
