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
        private decimal valorDonacion;
        private decimal valorDesc;
        //private List<Producto> prodDonados;
        #endregion

        #region Propiedades
        public decimal ValorDonacion
        {
            get { return valorDonacion; }
        }
        public decimal ValorDesc
        {
            get { return valorDesc; }
        }
        //public List<Producto> ProdDonados
        //{
        //    get { return ProdDonados; }
        //}
        #endregion

        #region Metodos
        public DonacionProd(decimal valorDonacion, decimal valorDesc, DateTime fecha, Centro centroRecepcion): base(fecha,centroRecepcion)
        {
            this.valorDonacion = valorDonacion;
            this.valorDesc = valorDesc;
        }

        #endregion
    }
}
