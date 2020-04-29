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
        private List<Object> prodDonados;
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
        public List<Producto> ProdDonados
        {
            get { return ProdDonados; }
        }
        #endregion

        #region Metodos
        public DonacionProd(decimal valorDonacion, DateTime fecha, List<Object> productosDonados): base(fecha)
        {
            decimal valorDesc = DescDonacionProd(valorDonacion);
            this.valorDonacion = valorDonacion;
            this.valorDesc = valorDesc;
            prodDonados = new List<Object>();
            prodDonados = productosDonados;
        }
        public override string ToString()
        {
            string retorno = "Id donacion: " + Id + " - Fecha: " + Fecha + " - " + valorDonacion + " " + valorDesc;
            return retorno;
        }
        public static decimal DescDonacionProd(decimal importeDonacion)
        {
            //Recibe el monto de la donacion economica, calcula el descuento y lo devuelve
            //Menor a 1000 - 0% 
            //Entre 1000 y 2000 - 10 %
            //Mayor a 2000 - 12 %
            decimal montoDescuento = 0;
            if (importeDonacion >= 1000)
            {
                if (importeDonacion >= 2000)
                {
                    montoDescuento = importeDonacion * 12 / 1000;
                }
                else
                {
                    montoDescuento = importeDonacion * 10 / 1000;
                }
            }
            return montoDescuento;
        }
        #endregion
    }
}
