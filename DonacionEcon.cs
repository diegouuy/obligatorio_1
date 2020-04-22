using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1
{
    class DonacionEcon : Donacion
    {
        #region Atributos
        private float valorDonacion;
        private float valorDesc;
        #endregion

        #region Propiedades
        public float ValorDonacion
        {
            get { return valorDonacion; }
        }
        public float ValorDesc
        {
            get { return valorDesc; }
        }
        #endregion

        #region Metodos
        public DonacionEcon(float valorDonacion, float valorDesc)
        {
            this.valorDonacion = valorDonacion;
            this.valorDesc = valorDesc;
        }

        #endregion
    }
}
