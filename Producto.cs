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
            Bebida = 1,
            Perecedero = 2,
            No_Perecedero = 3,
            Limpieza = 4,
            Higiene = 5
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

        public Producto(string nombre, decimal peso, decimal precio, int tipo)
        {
            this.id = ++ultimoId;
            this.nombre = nombre;
            this.peso = peso;
            this.precio = precio;
            this.tipo = (TipoProducto)tipo;
        }

        public override string ToString()
        {
            string retorno = "- " + nombre + ":\n  * Id: " + id + "\n  * Peso: " + peso + "\n  * Precio: $" + precio + "\n  * Tipo: " + tipo;
            return retorno;
        }

        public static bool ValidarNombre(string nombre)
        {
            bool nombreValido = false;
            if (nombre is string && nombre != "" && nombre != " ")
            {
                nombreValido = true;
            }
            return nombreValido;
        }

        public static bool ValidarPeso(decimal peso)
        {
            bool pesoValido = false;
            if(peso > 0)
            {
                pesoValido = true;
            }
            return pesoValido;
        }
        public static bool ValidarPrecio(decimal precio)
        {
            bool precioValido = false;
            if(precio > 0)
            {
                precioValido = true;
            }
            return precioValido;
        }

        public static bool ValidarTipo(int tipo)
        {
            bool retorno = false;
            if (tipo >= 1 && tipo <= 5)
            {
                retorno = true;
            }
            return retorno;
        }

        #endregion

    }
}
