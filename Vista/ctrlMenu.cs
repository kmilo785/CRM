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
    public partial class ctrlMenu : UserControl
    {
        public ctrlMenu()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmABMClientes frmClientes = new frmABMClientes();
            frmClientes.ShowDialog();
        }
    }
}
