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

        //CONSTRUCTOR SISTEMA
        public Sistema()
        {
            centros = new List<Centro>();
            donaciones = new List<Donacion>();
            productos = new List<Producto>();
            voluntarios = new List<Voluntario>();
            PrecargaProductos();
            PrecargaCentros();
            PrecargaDonaciones();
            //PrecargaVoluntarios();
        }

        //PRECARGA

        private void PrecargaCentros() //AgregarCentro(nombre: string, direccion: string)
        {
            AgregarCentro("Soriano", "Cerro largo 1432");
            AgregarCentro("Mercedes", "Misiones 298");
            AgregarCentro("Montevideo", "Arenal Grabde 1729");
            AgregarCentro("Paysandu", "Canelones 785");
            AgregarCentro("Tacuarembo", "Mercedes 1324");

        }

        //List<Object> listaProd = new {producto = producto, cantidad = cantidad},

        private void PrecargaDonaciones()
        {
            DateTime fechaDonacionA = new DateTime(2019, 09, 05);
            AgregarDonacionEconmica(1345.20m, fechaDonacionA, "Soriano");
            DateTime fechaDonacionB = new DateTime(2019, 09, 22);
            AgregarDonacionEconmica(2571.50m, fechaDonacionB, "Montevideo");

            //Donaciones de productos
            //Lista y objeto auxiliar para agregar enviar en el metodo AgregarDonacionProducto
            //Para cada donacion se completa una listaProductos
            //Donacion A
            List<Object> listaProductos = new List<object>();
            Object productoDonado = new { producto = productos[1], cantidad = 2 };
            listaProductos.Add(productoDonado);
            productoDonado = new { producto = productos[1], cantidad = 1 };
            listaProductos.Add(productoDonado);
            productoDonado = new { producto = productos[1], cantidad = 3 };
            listaProductos.Add(productoDonado);
            productoDonado = new { producto = productos[1], cantidad = 2 };
            listaProductos.Add(productoDonado);
            DateTime fechaDonacionC = new DateTime(2019, 10, 04);
            AgregarDonacionProducto(870.25m, fechaDonacionC, "Soriano", listaProductos);
            //Donacion B
            listaProductos.Clear();
            productoDonado = new { producto = productos[1], cantidad = 1 };
            listaProductos.Add(productoDonado);
            productoDonado = new { producto = productos[0], cantidad = 5 };
            listaProductos.Add(productoDonado);
            productoDonado = new { producto = productos[7], cantidad = 2 };
            listaProductos.Add(productoDonado);
            productoDonado = new { producto = productos[4], cantidad = 10 };
            listaProductos.Add(productoDonado);
            productoDonado = new { producto = productos[2], cantidad = 6 };
            listaProductos.Add(productoDonado);
            productoDonado = new { producto = productos[9], cantidad = 3 };
            listaProductos.Add(productoDonado);
            DateTime fechaDonacionD = new DateTime(2019, 10, 07);
            AgregarDonacionProducto(1001.01m, fechaDonacionD, "Montevideo", listaProductos);
            //Donacion C
            listaProductos.Clear();
            productoDonado = new { producto = productos[2], cantidad = 2 };
            listaProductos.Add(productoDonado);
            productoDonado = new { producto = productos[8], cantidad = 10 };
            listaProductos.Add(productoDonado);
            DateTime fechaDonacionE = new DateTime(2019, 11, 12);
            AgregarDonacionProducto(1999.99m, fechaDonacionE, "Paysandu", listaProductos);
            //Donacion D
            listaProductos.Clear();
            productoDonado = new { producto = productos[2], cantidad = 2 };
            listaProductos.Add(productoDonado);
            productoDonado = new { producto = productos[3], cantidad = 4 };
            listaProductos.Add(productoDonado);
            productoDonado = new { producto = productos[5], cantidad = 6 };
            listaProductos.Add(productoDonado);
            productoDonado = new { producto = productos[6], cantidad = 4 };
            listaProductos.Add(productoDonado);
            productoDonado = new { producto = productos[7], cantidad = 1 };
            listaProductos.Add(productoDonado);
            productoDonado = new { producto = productos[8], cantidad = 3 };
            listaProductos.Add(productoDonado);
            productoDonado = new { producto = productos[9], cantidad = 5 };
            listaProductos.Add(productoDonado);
            DateTime fechaDonacionF = new DateTime(2019, 11, 14);
            AgregarDonacionProducto(2575, fechaDonacionF, "Tacuarembo", listaProductos);
        }

        private void PrecargaProductos()
        {
            AltaProducto("Agua nativa", 2, 39.4m, 1);
            AltaProducto("Agua salus", 2.5m, 50, 1);
            AltaProducto("Arroz", 5, 120, 3);
            AltaProducto("Fideos", 5, 80, 3);
            AltaProducto("Pan", 0.5m, 50, 2);
            AltaProducto("Galletas", 0.5m, 130, 2);
            AltaProducto("Panio de piso", 0.3m, 56, 4);
            AltaProducto("Lavandina", 2, 70, 4);
            AltaProducto("Jabon de banio", 1, 140, 5);
            AltaProducto("Jabon liquido", 3, 110, 5);
        }

        private void PrecargaVoluntarios() //MM/dd/yyyy //AgregarVoluntario(nombre: string, cedula: int, telefono: int, fechaNac: date)
        {
            AgregarVoluntario("Edhys", 47479537, 098650104, 04/24/2019);
            AgregarVoluntario("Diego", 38548711, 099345761, 04 / 24 / 2019);
            AgregarVoluntario("Juan", 34598123, 098549123, 04 / 24 / 2019);
            AgregarVoluntario("Perez", 47632567, 099876543, 04 / 24 / 2019);
            AgregarVoluntario("Maxi", 32198754, 099123765, 04 / 24 / 2019);
            AgregarVoluntario("Sofia", 36745612, 098345612, 04 / 24 / 2019);
            AgregarVoluntario("Carolina", 34509847, 098435678, 04 / 24 / 2019);
            AgregarVoluntario("Gabriela", 47234509, 098123678, 04 / 24 / 2019);
            AgregarVoluntario("Luciana", 45678234, 098123098, 04 / 24 / 2019);
            AgregarVoluntario("Ornella", 23459876, 097543654, 04 / 24 / 2019);
        }
        public bool AgregarVoluntario(string nombre, int cedula, int telefono, DateTime fechaNac)
        {
            //valido dato no vacios 
            if (nombre != "" && cedula != "" && telefono != "" && fechaNac != "")
            {
            AgregarVoluntario unV = new Voluntario(nombre, cedula, telefono, fechaNac);
            Voluntario.Add(unV);
            }
        }
        public bool AgregarCentro(string nombre, string direccion)
        {
            bool centroCreado = false;
            //Validaciones nombre Centro
            if (NombreCentroValido(nombre) && !CentroExistente(nombre) && direccion is string)
            {
                Centro unC = new Centro(nombre, direccion);
                centros.Add(unC);
                centroCreado = true;
            }
            return centroCreado;
        }

        public bool AgregarDonacionEconmica(decimal valorDonacion, DateTime fecha, string nombreCentro)
        {
            bool donacionAgregada = false;
            Centro centroRecepcion = BuscarCentro(nombreCentro);
            DonacionEcon unaDe = new DonacionEcon(valorDonacion, fecha);
            donaciones.Add(unaDe);
            return donacionAgregada;
        }

        public bool AgregarDonacionProducto(decimal valorDonacion, DateTime fecha, string nombreCentro, List<Object> listaProductos)
        {
            bool donacionAgregada = false;
            Centro centroRecepcion = BuscarCentro(nombreCentro);
            DonacionProd unaDp = new DonacionProd(valorDonacion, fecha, listaProductos);
            donaciones.Add(unaDp);
            return donacionAgregada;
        }

        public void AltaProducto(string nombre, decimal peso, decimal precio, int tipo)
        {
            Producto unP = new Producto(nombre, peso, precio, tipo);
            productos.Add(unP);
        }

        //BUSQUEDAS

        public Centro BuscarCentro(string nombreCentro)
        {
            Centro elCentro = null;
            int i = 0;
            while (elCentro == null && i < centros.Count)
            {
                if (centros[i].Nombre == nombreCentro)
                {
                    elCentro = centros[i];
                }
                i++;
            }
            return elCentro;
        }

        //VALIDACIONES
        //Centro
        public bool NombreCentroValido(string nombreCentro)
        {
            bool valido = false;
            if(nombreCentro is string && nombreCentro != "" && nombreCentro != " ")
            {
                valido = true;
            }
            return valido;
        }

        public bool CentroExistente(string nombreCentro)
        {
            bool existe = false;
            if (BuscarCentro(nombreCentro) != null)
            {
                existe = true;
            }
            return existe;
        }

         

        #endregion
    }
}
