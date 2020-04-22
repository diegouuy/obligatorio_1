using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1
{
    class Producto
    {
        #region Atributos
        private int id;
        private static int ultimoId;
        private string nombre;
        private decimal peso;
        private decimal precio;
        private TipoProducto tipo;

        public enum TipoProducto
        {
            bebida = 1,
            perecedero = 2,
            noPerecedero = 3,
            limpieza = 4,
            higiene = 5
        }
        #endregion

        #region Propiedades

        public int Id
        {
            get { return id; }
        }

        public string Nombre
        {
            get { return nombre; }
        }

        public decimal Peso
        {
            get { return peso; }
        }

        public decimal Precio
        {
            get { return precio; }
        }


        #endregion

        #region Metodos

        //Constructor
        //***********

        public Producto(string nombre, decimal peso, decimal precio, TipoProducto tipo)
        {
            this.id = ++ultimoId;
            this.nombre = nombre;
            this.peso = peso;
            this.precio = precio;
            this.tipo = tipo;

        }

        #endregion

    }
}
