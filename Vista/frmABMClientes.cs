using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CRM.Modelo;
using CRM.Controlador;

namespace CRM.Vista
{
    public partial class frmABMClientes : Form
    {
        int a;
        bool habilitar = false;
        bool existe = false;
        BOCustomer cus;
        DbConnection con = new DbConnection();
        DataSet dsdata = new DataSet();
        AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();

        public frmABMClientes()
        {
            InitializeComponent();
        }

        public frmABMClientes(string cusID)//Función que se llama desde el formulario FrmBClientes
        {
            InitializeComponent();
            txtID .Text = cusID.ToString();
            CargarControles();
            habilitar = false;
            btnEditar.Visible = true;
            btnGuardar.Visible = false;
            this.ShowDialog();
        }

        private void frmABMClientes_Load(object sender, EventArgs e)
        {
            FormatoControles();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtNombre.Text == String.Empty || txtCelular.Text == String.Empty)
                {
                    MessageBox.Show("Debe cargar el nombre del Cliente y un Celular", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (existe == true)
                {
                    cus = new BOCustomer();
                    cus.CID = txtID.Text;
                    cus.NAME = txtNombre.Text;
                    cus.ORIGEN_DATO = cbOrigen.SelectedIndex;
                    cus.FNAC = dtFechaNacimiento.Text;
                    cus.CITY = txtCiudad.Text;
                    cus.EMAIL = txtEmail.Text;
                    cus.MOBILE = txtCelular.Text;
                    cus.LNUMBER = txtTelefono.Text;
                    cus.PRODUCT = txtTipoPlan.Text;
                    cus.COMENT = txtComentarios.Text;
                    cus.ADRESS = txtDireccion.Text;
                    cus.FINGRESO = DateTime.Now.ToString();

                    if (rbSinContacto.Checked == true) { cus.ESTADO = "Sin Contacto"; }
                    else if (rbEliminado.Checked == true) { cus.ESTADO = "Eliminado"; }
                    else if (rbStandBy.Checked == true) { cus.ESTADO = "Stand By"; }
                    else if (rbVendido.Checked == true) { cus.ESTADO = "Vendido"; }
                    else if (rbEnGestion.Checked == true) { cus.ESTADO = "En Gestión"; }
                    else if (rbLlamarDespues.Checked == true) { cus.ESTADO = "Llamar Despues"; }

                    cus.Update();
                    MessageBox.Show("Cliente Modificado Correctamente", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarControles();

                }
                else
                {

                    cus = new BOCustomer();
                    cus.CID = txtID.Text;
                    cus.NAME = txtNombre.Text;
                    cus.ORIGEN_DATO = cbOrigen.SelectedIndex;
                    cus.FNAC = dtFechaNacimiento.Text;
                    cus.CITY = txtCiudad.Text;
                    cus.EMAIL = txtEmail.Text;
                    cus.MOBILE = txtCelular.Text;
                    cus.LNUMBER = txtTelefono.Text;
                    cus.PRODUCT = txtTipoPlan.Text;
                    cus.COMENT = txtComentarios.Text;
                    cus.ADRESS = txtDireccion.Text;
                    cus.FINGRESO = DateTime.Now.ToString();

                    if (rbSinContacto.Checked == true) { cus.ESTADO = "Sin Contacto"; }
                    else if (rbEliminado.Checked == true) { cus.ESTADO = "Eliminado"; }
                    else if (rbStandBy.Checked == true) { cus.ESTADO = "Stand By"; }
                    else if (rbVendido.Checked == true) { cus.ESTADO = "Vendido"; }
                    else if (rbEnGestion.Checked == true) { cus.ESTADO = "En Gestión"; }
                    else if (rbLlamarDespues.Checked == true) { cus.ESTADO = "Llamar Despues"; }

                    cus.Add();
                    increment();
                    MessageBox.Show("Cliente Guardado Correctamente", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarControles();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error, Cliente no agregado");
            }
            existe = false;
            habilitar = false;
            FormatoControles();
        }

        #region increment
        private void increment()
        {
            a = int.Parse(txtID.Text);
            a = a + 1;
            txtID.Text = a.ToString();
            //  clearsale();
        }
        #endregion

        #region LimpiarControles
        private void LimpiarControles()
        {
            txtNombre.Clear();
            txtCelular.Clear();
            cbOrigen.SelectedItem = 1;
            cbEstados.SelectedItem = 7;
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtCiudad.Clear();
            txtTipoPlan.Clear();
            dtFechaNacimiento.Text = DateTime.Now.ToShortDateString();
            txtFechaIngreso.Clear();
            txtComentarios.Clear();
            rbSinContacto.Checked = false;
            rbEliminado.Checked = false;
            rbEnGestion.Checked = false;
            rbLlamarDespues.Checked = false;
            rbStandBy.Checked = false;
            rbVendido.Checked = false;
        }
        #endregion

        private void CargarCombo()
        {
            BOOrigenDato cargaCombo = new BOOrigenDato();

            DataSet ds = cargaCombo.ComboOrigenDato();
            cbOrigen.DataSource = ds.Tables[0];
            cbOrigen.SelectedIndex = 0;
            cbOrigen.DisplayMember = "Origen_Cliente";
            cbOrigen.ValueMember = "ID";
        }

        private void CargarCombo(int i)
        {
            BOOrigenDato cargaCombo = new BOOrigenDato(i);

            DataSet ds = cargaCombo.ComboOrigenDato(i);
            cbOrigen.DataSource = ds.Tables[0];
            cbOrigen.SelectedIndex = 0;
            cbOrigen.DisplayMember = "Origen_Cliente";
            cbOrigen.ValueMember = "ID";
        }

        private void FormatoControles()
        {
            if (habilitar == true)
            {
                txtNombre.Enabled = true;
                txtCelular.Enabled = true;
                txtDireccion.Enabled = true;
                cbOrigen.Enabled = true;
                txtTelefono.Enabled = true;
                txtEmail.Enabled = true;
                txtCiudad.Enabled = true;
                txtTipoPlan.Enabled = true;
                dtFechaNacimiento.Enabled = true;
                txtComentarios.Enabled = true;
                panel1.Enabled = true;

                btnGuardar.Visible = true;
                btnEditar.Visible = false;
                btnNuevo.Visible = false;

            }
            else
            {
                txtID.Enabled = false;
                txtNombre.Enabled = false;
                txtCelular.Enabled = false;
                txtDireccion.Enabled = false;
                cbOrigen.Enabled = false;
                txtTelefono.Enabled = false;
                txtEmail.Enabled = false;
                txtCiudad.Enabled = false;
                txtTipoPlan.Enabled = false;
                dtFechaNacimiento.Enabled = false;
                txtComentarios.Enabled = false;
                panel1.Enabled = false;
            }

        }


        private void CargarControles()
        {
            try
            {
                CargarCombo();
                int indiceCombo;
                String cusID = txtID.Text;

                BOCustomer thisCus = new BOCustomer();

                DataSet ds = thisCus.Find(cusID);

                DataRow row;
                row = ds.Tables[0].Rows[0];

                foreach (DataRow rows in ds.Tables[0].Rows)
                {
                    cus = new BOCustomer();

                    txtID.Text = rows["CID"].ToString();
                    txtNombre.Text = rows["Customer_Name"].ToString();
                    txtCelular.Text = rows["MOBILE"].ToString();
                    indiceCombo = int.Parse(rows["Orig_Dato"].ToString());
                    CargarCombo(indiceCombo);
                    txtDireccion.Text = rows["Street_Name"].ToString();
                    txtCiudad.Text = rows["City"].ToString();
                    txtEmail.Text = rows["EMAIL"].ToString();
                    txtTelefono.Text = rows["Land_Number"].ToString();
                    txtTipoPlan.Text = rows["Product"].ToString();
                    txtComentarios.Text = rows["Cus_Coment"].ToString();
                    txtFechaIngreso.Text = rows["FIngreso"].ToString();
                    dtFechaNacimiento.Text = rows["FNAC"].ToString();

                    if (rows["Estado"].ToString() == "Sin Contacto") { rbSinContacto.Checked = true; }
                    else if (rows["Estado"].ToString() == "Eliminado") { rbEliminado.Checked = true; }
                    else if (rows["Estado"].ToString() == "Stand By") { rbStandBy.Checked = true; }
                    else if (rows["Estado"].ToString() == "Vendido") { rbVendido.Checked = true; }
                    else if (rows["Estado"].ToString() == "En Gestión") { rbEnGestion.Checked = true; }
                    else if (rows["Estado"].ToString() == "Llamar Despues") { rbLlamarDespues.Checked = true; }
                }
                existe = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                habilitar = true;
            }
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                //String cusID = dtgrid1.CurrentRow.Cells[0].Value.ToString();
                String cusID = txtID.Text;

                BOCustomer thisCus = new BOCustomer();

                DataSet ds = thisCus.Find(cusID);

                DataRow row;
                row = ds.Tables[0].Rows[0];

                foreach (DataRow rows in ds.Tables[0].Rows)
                {
                    cus = new BOCustomer();

                    txtID.Text = rows["CID"].ToString();
                    txtNombre.Text = rows["Customer_Name"].ToString();
                    txtCelular.Text = rows["MOBILE"].ToString();
                    txtDireccion.Text = rows["Street_Name"].ToString();
                    txtCiudad.Text = rows["City"].ToString();
                    txtEmail.Text = rows["EMAIL"].ToString();
                    txtTelefono.Text = rows["Land_Number"].ToString();
                    txtTipoPlan.Text = rows["Product"].ToString();
                    txtComentarios.Text = rows["Cus_Coment"].ToString();
                    txtFechaIngreso.Text = rows["FIngreso"].ToString();
                    dtFechaNacimiento.Text = rows["FNAC"].ToString();


                    if (rows["Estado"].ToString() == "Sin Contacto") { rbSinContacto.Checked = true; }
                    else if (rows["Estado"].ToString() == "Eliminado") { rbEliminado.Checked = true; }
                    else if (rows["Estado"].ToString() == "Stand By") { rbStandBy.Checked = true; }
                    else if (rows["Estado"].ToString() == "Vendido") { rbVendido.Checked = true; }
                    else if (rows["Estado"].ToString() == "En Gestión") { rbEnGestion.Checked = true; }
                    else if (rows["Estado"].ToString() == "Llamar Despues") { rbLlamarDespues.Checked = true; }
                }
                existe = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                habilitar = true;
                FormatoControles();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            habilitar = false;
            FormatoControles();
            btnEditar.Visible = true;

            try
            {
                // String cusID = dtgrid1.CurrentRow.Cells[0].Value.ToString();
                String cusID = txtID.Text;

                BOCustomer thisCus = new BOCustomer();

                DataSet ds = thisCus.Find(cusID);

                DataRow row;
                row = ds.Tables[0].Rows[0];

                foreach (DataRow rows in ds.Tables[0].Rows)
                {
                    cus = new BOCustomer();

                    txtID.Text = rows["CID"].ToString();
                    txtNombre.Text = rows["Customer_Name"].ToString();
                    txtCelular.Text = rows["MOBILE"].ToString();
                    txtDireccion.Text = rows["Street_Name"].ToString();
                    txtCiudad.Text = rows["City"].ToString();
                    txtEmail.Text = rows["EMAIL"].ToString();
                    txtTelefono.Text = rows["Land_Number"].ToString();
                    txtTipoPlan.Text = rows["Product"].ToString();
                    txtComentarios.Text = rows["Cus_Coment"].ToString();
                    txtFechaIngreso.Text = rows["FIngreso"].ToString();
                    dtFechaNacimiento.Text = rows["FNAC"].ToString();

                    if (rows["Estado"].ToString() == "Sin Contacto") { rbSinContacto.Checked = true; }
                    else if (rows["Estado"].ToString() == "Eliminado") { rbEliminado.Checked = true; }
                    else if (rows["Estado"].ToString() == "Stand By") { rbStandBy.Checked = true; }
                    else if (rows["Estado"].ToString() == "Vendido") { rbVendido.Checked = true; }
                    else if (rows["Estado"].ToString() == "En Gestión") { rbEnGestion.Checked = true; }
                    else if (rows["Estado"].ToString() == "Llamar Despues") { rbLlamarDespues.Checked = true; }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            //dtgrid1.Refresh();
            //dtgrid1.Rows.Clear();
            habilitar = false;
            FormatoControles();
        }


        #region NewID
        private void new_ID()
        {
            try
            {
                int myID;

                SqlConnection conns = new SqlConnection(con.conn_str);
                conns.Open();
                SqlCommand cmddr = new SqlCommand("select max(CID) as ids from Customer", conns);
                SqlDataReader dr = cmddr.ExecuteReader();

                while (dr.Read())
                {
                    string strid = dr["ids"].ToString();
                    if (strid == "")
                    {

                        this.txtID.Text = "1";
                    }
                    else
                    {

                        myID = Convert.ToInt32(dr["ids"]) + 1;
                        if (myID >= 1 && myID <= 9)
                        {

                            txtID.Text = "" + myID.ToString();
                        }
                        else
                        {
                            if (myID >= 10)
                            {

                                txtID.Text = myID.ToString();
                            }
                        }
                    }

                }
                dr.Close();

                conns.Close();
                cmddr.Dispose();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

        }
        #endregion

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnEditar.Visible = false;
            try
            {
                new_ID();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Error Auto");
            }
            habilitar = true;
            FormatoControles();
            btnNuevo.Visible = false;
            LimpiarControles();
            CargarCombo();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                String cusID = txtID.Text;

                BOCustomer thisCus = new BOCustomer();

                DataSet ds = thisCus.Eliminar(cusID);

                MessageBox.Show("Cliente Eliminado", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Error al Eliminar el Cliente");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
