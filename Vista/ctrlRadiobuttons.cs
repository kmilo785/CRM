using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM.Vista
{
    public partial class ctrlRadiobuttons : UserControl
    {
        public ctrlRadiobuttons()
        {
            InitializeComponent();
        }

        private void rbHome_CheckedChanged(object sender, EventArgs e)
        {
            frmMain frmMain= new frmMain();
            frmMain.ShowDialog();
            Form.ActiveForm.Close();
        }

        private void rbABMClientes_CheckedChanged(object sender, EventArgs e)
        {

            frmABMClientes frmABMClientes = new frmABMClientes();
            frmABMClientes.ShowDialog();
            Form.ActiveForm.Close();
        }

        private void rbBuscar_CheckedChanged(object sender, EventArgs e)
        {
            frmBClientes frmBClientes = new frmBClientes();
            frmBClientes.ShowDialog();
        }

        private void rbExportar_CheckedChanged(object sender, EventArgs e)
        {
            frmExportarDatosClientes frmExportarDatosClientes = new frmExportarDatosClientes();
            frmExportarDatosClientes.ShowDialog();
        }

        private void rbConfiguracion_CheckedChanged(object sender, EventArgs e)
        {
            frmConfiguracion frmConfiguracion = new frmConfiguracion();
            frmConfiguracion.ShowDialog();
        }
    }
}
