using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inicio de clase Sistema
            Sistema unS = new Sistema();

            //MENU DE SELECCION
            int opcion = 0;
            bool salir = false;
            while (!salir)
            {
                Console.Clear();
                string mensaje = "\nOBLIGATORIO 1 - Edhys Santos / Diego Urreta\n*******************************************\n0 - Salir\n1 - Ver Productos para donar\n2 - Ver Voluntarios por centro de recepcion\n3 - Ver donaciones por fecha para cada centro\n4 - Ingresar un Producto nuevo";
                opcion = SolicitarNumero(0, 4, mensaje);
                switch (opcion)
                {
                    //Salir
                    case 0:
                        salir = true;
                        break;
                    //Listar productos disponibles para donación.
                    case 1:
                        ListarProductos(unS);
                        break;
                    //Seleccionar un centro de recepción. Lista voluntarios para centro seleccionado.
                    case 2:
                        ListarVoluntariosEnCentro(unS);
                        break;
                    //Mostrar donaciones por Centro dada una fecha 
                    case 3:
                        ListarDonacionesPorFecha(unS);
                        break;
                    //Alta de Producto
                    case 4:
                        IngresarProductoNuevo(unS);
                        break;
                }
            }

        }

        //FUNCIONES DEL MENU

        //Muestra mensaje y solicita el ingreso de un numero
        static int SolicitarNumero(int desde, int hasta, string mensaje)
        {
            int numIngresado;
            do
            {
                Console.Clear();
                Console.WriteLine(mensaje);
                int.TryParse(Console.ReadLine(), out numIngresado);
            }
            while (numIngresado < desde || numIngresado > hasta);
            return numIngresado;
        }

        //REQUERIMIENTOS DEL MENU EN CONSOLA

        //Listar productos disponibles para donacion
        static void ListarProductos(Sistema unS)
        {
            Console.Clear();
            if (unS.Productos.Count > 0)
            {
                Console.WriteLine("PRODUCTOS DISPONIBLES PARA DONACION\n\n");
                foreach (Producto unP in unS.Productos)
                {
                    Console.WriteLine(unP);
                }
            }
            else
            {
                Console.WriteLine("No hay productos para mostar");
            }
            Console.WriteLine();
            Console.WriteLine("Presione cualquier tecla para volver al Menu principal");
            Console.ReadKey();
        }

        //Listar Voluntarios por Centro
        static void ListarVoluntariosEnCentro(Sistema unS)
        {
            int centroSeleccionado;
            List<Voluntario> listaVoluntarios;
            int numeroDeCentros = unS.Centros.Count;
            if (numeroDeCentros >= 1)
            {
                string mensaje = "LISTADO DE VOLUNTARIOS POR CENTRO\n\nIngrese un numero de la lista para seleccionar el Centro de Recepción o ingrese 0 para volver al menu principal\n";
                int numeroOpcion = 0;
                foreach (Centro unC in unS.Centros)
                {
                    mensaje += ++numeroOpcion + " - " + unC.Nombre + "\n";
                }
                bool salir = false;
                while (!salir)
                {
                    centroSeleccionado = SolicitarNumero(0, numeroDeCentros, mensaje);
                    if (centroSeleccionado != 0)
                    {
                        --centroSeleccionado;
                        string nombreCentro = unS.ObtenerNombreCentro(unS, centroSeleccionado);
                        listaVoluntarios = unS.ListaVoluntariosEnCentro(unS, centroSeleccionado);//unS.Centros[centroSeleccionado].Voluntarios;
                        int cantidadVoluntarios = listaVoluntarios.Count;
                        if (cantidadVoluntarios >= 1)
                        {
                            Console.Clear();
                            Console.WriteLine("Mostrando Voluntarios del centro " + nombreCentro);
                            foreach (Voluntario unV in listaVoluntarios)
                            {
                                Console.WriteLine(unV);
                            }
                            Console.WriteLine("Presione cualquier tecla para volver al menu anterior.");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("El Centro " + nombreCentro + " no tiene Voluntarios asignados. Presione cualquier tecla para volver al menu anterior.");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        salir = true;
                    }
                }
            }
            else
            {
                Console.WriteLine("No hay Centros creados en el sistema");
            }
        }

        //Listar donaciones por fecha y Centro
        static void ListarDonacionesPorFecha(Sistema unS)
        {
            Console.Clear();
            bool fechaValida = false;
            DateTime fechaIngresada = new DateTime();
            string datoIngresado = "";
            //Pide el ingreso de una fecha hasta que se ingrese en el formato valido o se ingrese 0 para salir
            while (!fechaValida && datoIngresado != "0")
            {
                Console.Clear();
                Console.WriteLine("LISTADO DE DONACIONES POR FECHA\n");
                Console.WriteLine("Ingrese la fecha deseada (en formato aaaa/mm/dd) o ingrese 0 para volver");
                datoIngresado = Console.ReadLine();
                fechaValida = DateTime.TryParse(datoIngresado, out fechaIngresada);
            }
            //Si se ingreso una fecha valida se sigue con los pasos para buscar donaciones en esa fecha
            //Si se ingreso "0" se finaliza el algoritmo
            if (fechaValida)
            {
                Console.Clear();
                Console.WriteLine("Donaciones por centro en el día " + fechaIngresada.ToShortDateString() + "\n");
                if (unS.Donaciones.Count != 0)
                {
                    //Busco donaciones en esa fecha. Se recibe una lista para recorrerla y imprimir en pantalla.
                    List<string> listaCantDonaciones = unS.DonacionesPorFechaEnCentro(fechaIngresada);
                    foreach (string s in listaCantDonaciones)
                    {
                        Console.WriteLine(s);
                    }
                    Console.WriteLine("\nPresione cualquier tecla para volver al menu anterior");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("No hay donaciones registradas. Presione cualquier tecla para continuar.");
                    Console.ReadKey();
                }
            }
        }

        //Alta Producto
        static void IngresarProductoNuevo(Sistema unS)
        {
            Console.Clear();
            Console.WriteLine("ALTA DE PRODUCTO\n");
            Console.WriteLine("Ingrese NOMBRE del producto");
            string nombreIngresado = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Nombre ingresado: " + nombreIngresado + "\n");
            Console.WriteLine("Ingrese el PESO del producto");
            decimal pesoIngresado;
            bool pesoValido = Decimal.TryParse(Console.ReadLine(), out pesoIngresado);
            while (!pesoValido)
            {
                Console.WriteLine("El peso ingresado no es válido. Ingrese un peso en valores numéricos mayores a 0.");
                pesoValido = Decimal.TryParse(Console.ReadLine(), out pesoIngresado);
            }
            Console.Clear();
            Console.WriteLine("Peso ingresado: " + pesoIngresado + "\n");
            Console.WriteLine("Ingrese el PRECIO del producto");
            decimal precioIngresado;
            bool precioValido = Decimal.TryParse(Console.ReadLine(), out precioIngresado);
            while (!precioValido)
            {
                Console.WriteLine("El peso ingresado no es válido. Ingrese un peso en valores numéricos mayores a 0.");
                precioValido = Decimal.TryParse(Console.ReadLine(), out precioIngresado);
            }
            Console.Clear();
            string pedirTipo = "Precio ingresado: " + precioIngresado + "\n\nIngrese el TIPO de producto\n1 - Bebida // 2 - Perecedero // 3 - No Perecedero // 4 - Limpieza // 5 - Higiene";
            int tipoIngresado = SolicitarNumero(1, 5, pedirTipo);
            string nombreTipo = unS.SolicitarTipoProd(unS, tipoIngresado);
            Console.Clear();
            string mensajeTipo = "Tipo ingresado: " + tipoIngresado + " - " + nombreTipo + "\n\n";
            Console.WriteLine(mensajeTipo);
            Console.WriteLine("Presione cualquier tecla para finalizar");
            Console.ReadKey();
            Console.Clear();
            Producto unP = unS.AltaProducto(nombreIngresado, pesoIngresado, precioIngresado, tipoIngresado);
            if (unP != null)
            {
                Console.WriteLine("Producto ingresado con éxito\n\n" + unP + "\n\nPresione cualquier tecal para volver al menu principal\n");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Error. No se pudo ingresar el producto. Verifique los datos ingresados.\nPresione cualquier tecal para volver al menu principal");
            }
        }

    }
}
