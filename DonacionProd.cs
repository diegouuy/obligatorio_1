using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1
{
    class DonacionProd : Donacion
    {
        #region Atributos
        private float valorDonacion;
        private float valorDesc;
        private List<Producto> prodDonados;
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
        public List<Producto> ProdDonados
        {
            get { return ProdDonados; }
        }
        #endregion

        #region Metodos
        public DonacionProd(float valorDonacion, float valorDesc)
        {
            this.valorDonacion = valorDonacion;
            this.valorDesc = valorDesc;
        }

        #endregion
    }
}
