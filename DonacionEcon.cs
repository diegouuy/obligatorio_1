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
        private decimal valorDonacion;
        private decimal valorDesc;
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
        #endregion

        #region Metodos
        public DonacionEcon(decimal montoDonacion, string fecha) : base(fecha)
        {
            decimal valorDesc = DescDonacionEcon(montoDonacion);
            this.valorDonacion = montoDonacion;
            this.valorDesc = valorDesc;
        }

        public override string ToString()
        {
            string retorno = "Id donacion: " + Id + " - Fecha: " + Fecha + " - " + valorDonacion + " " + valorDesc;
            return retorno;
        }

        private static decimal DescDonacionEcon(decimal montoDonacion)
        {
            //Recibe el monto de la donacion economica, calcula el descuento y lo devuelve
            //Menor a  1000 - 5 %
            //Entre 1000 y 2000 - 8 %
            //Mayor a 2000 - 10 %

            decimal montoDesc = (montoDonacion * 5) / 100;
            if ( montoDonacion >= 1000)
            {
                if (montoDonacion >= 2000)
                {
                    montoDesc = (montoDonacion * 10) / 100;
                }
                else
                {
                    montoDesc = (montoDonacion * 8) / 100;
                }
            }
            return montoDesc;
        }

        #endregion
    }
}
