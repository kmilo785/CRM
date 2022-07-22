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
    public partial class ctrlMenuHome : UserControl
    {
        public ctrlMenuHome()
        {
            InitializeComponent();
        }

        public void CierraForms()
        {
           
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmABMClientes frmClientes = new frmABMClientes();
            frmClientes.ShowDialog();

        }

        private void btnBClientes_Click(object sender, EventArgs e)
        {
            frmBClientes frmClientes = new frmBClientes();
            frmClientes.ShowDialog();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmMain frmClientes = new frmMain();
            frmClientes.ShowDialog();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            frmExportarDatosClientes frmClientes = new frmExportarDatosClientes();
            frmClientes.ShowDialog();
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            frmConfiguracion frmClientes = new frmConfiguracion();
            frmClientes.ShowDialog();
        }
    }
}
