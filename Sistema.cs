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
            PrecargaCentros();
            //PrecargaDonaciones();
            //PrecargaProductos();
            //PrecargaVoluntarios();
        }

        //Metodos de precarga
        //*******************

        private void PrecargaCentros() //AgregarCentro(nombre: string, direccion: string)
        {
            AgregarCentro("Soriano", "Cerro largo 1432");
            AgregarCentro("Mercedes", "Misiones 298");
            AgregarCentro("Montevideo", "Arenal Grabde 1729");
            AgregarCentro("Paysandu", "Canelones 785");
            AgregarCentro("Tacuarembo", "Mercedes 1324");

        }

        //private void PrecargaDonaciones()   //AgregarDonacionEconmica(fecha: date, centroRecepcion: Centros, valorDoncacion: float)
        //                                    //AgregarDonacionProducto(fecha: date, centroRecepcion: Centros)
        //{
        //    //decimal valorDonacion, DateTime fecha, Centro centroRecepcion
        //    AgregarDonacionEconmica(1345.20, 04 / 24 / 2019, "Soriano");
        //    AgregarDonacionEconmica(04 / 24 / 2019, "Montevideo", "Arenal Grabde 1729", 345.99);
        //    AgregarDonacionProducto(04 / 24 / 2019, "Soriano", "Cerro largo 1432");
        //    AgregarDonacionProducto(04 / 24 / 2019, "Montevideo", "Arenal Grabde 1729");
        //    AgregarDonacionProducto(04 / 24 / 2019, "Paysandu", "Canelones 785");
        //    AgregarDonacionProducto(04 / 24 / 2019, "Tacuarembo", "Mercedes 1324");

        //}

      
        //private void PrecargaVoluntarios() //MM/dd/yyyy //AgregarVoluntario(nombre: string, cedula: int, telefono: int, fechaNac: date)
        //{
        //    AgregarVoluntario("Edhys", 47479537, 098650104, 04/24/2019);
        //    AgregarVoluntario("Diego", 38548711, 099345761, 04 / 24 / 2019);
        //    AgregarVoluntario("Juan", 34598123, 098549123, 04 / 24 / 2019);
        //    AgregarVoluntario("Perez", 47632567, 099876543, 04 / 24 / 2019);
        //    AgregarVoluntario("Maxi", 32198754, 099123765, 04 / 24 / 2019);
        //    AgregarVoluntario("Sofia", 36745612, 098345612, 04 / 24 / 2019);
        //    AgregarVoluntario("Carolina", 34509847, 098435678, 04 / 24 / 2019);
        //    AgregarVoluntario("Gabriela", 47234509, 098123678, 04 / 24 / 2019);
        //    AgregarVoluntario("Luciana", 45678234, 098123098, 04 / 24 / 2019);
        //    AgregarVoluntario("Ornella", 23459876, 097543654, 04 / 24 / 2019);
        //}

        #endregion

        //public static List<Producto> ProductosDisponibles()
        //{
        //    return productos;
        //}

        public void AgregarCentro(string nombre, string direccion)
        {
            Centro unC = new Centro(nombre, direccion);
            centros.Add(unC);
        }

        public void AgregarDonacionEconmica(decimal valorDonacion, DateTime fecha, string nombreCentro)
        {
            Centro centroRecepcion = BuscarCentro(nombreCentro);
            DonacionEcon unaDe = new DonacionEcon(valorDonacion, fecha, centroRecepcion);
            donaciones.Add(unaDe);
        }

        //BUSQUEDAS

        public Centro BuscarCentro(string nombreCentro)
        {
            Centro elCentro = null;
            bool centroEncontrado = false;
            int i = 0;
            while (!centroEncontrado && i < centros.Count)
            {
                if (centros[i].Nombre == nombreCentro)
                {
                    elCentro = centros[i];
                    centroEncontrado = true;
                }
                i++;
            }
            return elCentro;
        }
    }
}
