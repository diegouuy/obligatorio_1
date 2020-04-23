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

            //MENU EN PANTALLA

            int opcion = 0;
            bool salir = false;
            while (!salir)
            {
                Console.Clear();
                //Console.WriteLine("*******************************************");
                //Console.WriteLine("OBLIGATORIO 1 - Edhys Santos / Diego Urreta");
                //Console.WriteLine("*******************************************");

                string mensaje = "\nOBLIGATORIO 1 - Edhys Santos / Diego Urreta\n*******************************************\n0 - Salir\n1 - Ver Productos para donar\n2 - Ver Voluntarios por centro de recepcion\n3 - Ver donaciones por fecha para cada centro\n4 - Ingresar un Producto nuevo";
                opcion = SolicitarNumero(0, 4, mensaje);
                switch (opcion)
                {
                    //Salir
                    case 0:
                        salir = true;
                        break;
                    // 
                    case 1:
                        salir = true;
                        break;
                    case 2:
                        salir = true;
                        break;
                    case 3:
                        salir = true;
                        break;
                    case 4:
                        salir = true;
                        break;
                }
            }

        }

        //FUNCIONES DEL MENU

        //Muestra mensaje y solicita el ingreso de un numero
        static public int SolicitarNumero(int desde, int hasta, string mensaje)
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
    }
}
