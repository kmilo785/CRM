using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading.Tasks;
using CRM.Modelo;

namespace CRM.Controlador
{
    class BOEstado
    {
        private int _id;
        private String _estado;
        private DAEstado _infoEstado;

        public BOEstado(int id, string estado)
        {
            _id = id;
            _estado = estado;
        }

        public DataSet ComboEstados()
        {
            DataSet data = null;

            data = _infoEstado.BuscaEstado();

            return data;

        }
        public BOEstado()
        {
            _infoEstado = new DAEstado(this);
        }

    }
}
