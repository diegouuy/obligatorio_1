using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1
{
    class Donacion
    {
        #region Atributos
        private int id;
        private static int ultimoId;
        private string fecha;
        #endregion

        #region Propiedades
        public int Id
        {
            get { return id; }
        }
        public string Fecha
        {
            get { return fecha; }
        }
        #endregion

        #region Metodos
        public Donacion(string fecha)
        {
            this.id = ++ultimoId;
            this.fecha = fecha;
        }

        #endregion
    }
}
