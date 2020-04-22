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
        private DateTime fecha;
        private Centro centroRecepcion;
        #endregion

        #region Propiedades
        public DateTime Fecha
        {
            get { return fecha; }
        }
        public Centro CentroRecepcion
        {
            get { return centroRecepcion; }
        }
        #endregion

        #region Metodos
        public Donacion(DateTime fecha, Centro centroRecepcion)
        {
            this.fecha = fecha;
            this.centroRecepcion = centroRecepcion;
        }

        #endregion
    }
}
