using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRM.Modelo;

namespace CRM.Controlador
{
    internal class BOOrigenDato
    {
        private int _id;
        private String _OrigenDato;
        private DAOrigenDato OrigenDato;

        public int Id { get => _id; set => _id = value; }
        public string OrigDato { get => _OrigenDato; set => _OrigenDato = value; }

        public BOOrigenDato(int id, string origen)
        {
            _id = id;
            _OrigenDato = origen;
        }

        public DataSet ComboOrigenDato()
        {
            DataSet data = null;

            data = OrigenDato.BuscaOrigen();

            return data;
        }

        public DataSet ComboOrigenDato(int i)
        {
            DataSet data = null;

            data = OrigenDato.BuscaOrigen(i);

            return data;
        }

        public BOOrigenDato()
        {
            OrigenDato = new DAOrigenDato(this);
        }

        public BOOrigenDato(int i)
        {
            OrigenDato = new DAOrigenDato(this);
            
        }

        public void Update()//Update Origen
        {
            OrigenDato.Update();
        }

        public void Guardar()//Guarda Origen
        {
            OrigenDato.Guardar();
        }

        public DataSet Eliminar(String str)
        {
            DataSet data = null;

            data = OrigenDato.Eliminar(str);

            return data;
        }
    }
}
