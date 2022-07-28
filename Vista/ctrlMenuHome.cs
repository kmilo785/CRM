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
            Form tmp = this.FindForm();
            tmp.Close();
            tmp.Dispose();

            frmABMClientes frmABMClientes = new frmABMClientes();
            frmABMClientes.ShowDialog();

        }

        private void btnBClientes_Click(object sender, EventArgs e)
        {
            Form tmp = this.FindForm();
            tmp.Close();
            tmp.Dispose();

            frmBClientes FrmBClientes = new frmBClientes();
            FrmBClientes.ShowDialog();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form tmp = this.FindForm();
            frmMain frmMain = new frmMain();

            tmp.Close();
            tmp.Dispose();
            frmMain.ShowDialog();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            Form tmp = this.FindForm();
            tmp.Close();
            tmp.Dispose();

            frmExportarDatosClientes frmExportarDatosClientes = new frmExportarDatosClientes();
            frmExportarDatosClientes.ShowDialog();
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            Form tmp = this.FindForm();
            tmp.Close();
            tmp.Dispose();

            frmConfiguracion frmConfiguracion = new frmConfiguracion();
            frmConfiguracion.ShowDialog();
        }
    }
}
