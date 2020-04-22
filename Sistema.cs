using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1
{
    class Sistema
    {
        #region Atributos
        private List<Centro> centros;
        private List<Donacion> donaciones;
        private List<Producto> productos;
        private List<Voluntario> voluntarios;
        #endregion

        #region Propiedades
        public List<Centro> Centros
        {
            get { return centros; }
        }

        public List<Donacion> Donaciones
        {
            get { return donaciones; }
        }

        public List<Producto> Productos
        {
            get { return productos; }
        }

        public List<Voluntario> Voluntarios
        {
            get { return voluntarios; }
        }

        #endregion

        #region Metodos

        //Consturctor Sistema
        //*******************
        public Sistema()
        {
            centros = new List<Centro>();
            donaciones = new List<Donacion>();
            productos = new List<Producto>();
            voluntarios = new List<Voluntario>();
            //PrecargaCentros()
            //PrecargaDonaciones()
            //PrecargaProductos()
            //PrecargaVoluntarios()
        }

        //Metodos de precarga
        //*******************

        //private PrecargaCentros()
        //{
            //List.Add...
        //}

        //private PrecargaDonaciones()
        //{

        //}

        //private PrecargaProductos()
        //{

        //}

        //private PrecargaVoluntarios()
        //{

        //}


        #endregion

    }
}
