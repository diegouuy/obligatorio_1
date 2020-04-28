using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1
{
    class Voluntario
    {
        #region Atributos
        private string nombre;
        private int cedula;
        private int telefono;
        private DateTime fechaNacimiento;
        #endregion

        #region Propiedades
        public string Nombre
        {
            get { return nombre; }
        }

        public int Cedula
        {
            get { return cedula; }
        }

        public int Telefono
        {
            get { return telefono; }
        }

        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
        }
        #endregion

        #region Metodos

        //Constructor
        //***********

        public Voluntario (string nombre, int cedula, int telefono, DateTime fechaNacimiento)
        {
            //if (validaciones true) agregar datos
            this.nombre = nombre;
            this.cedula = cedula;
            this.telefono = telefono;
            this.fechaNacimiento = fechaNacimiento;
        }

        public override string ToString()
        {
            string retorno = "- " + nombre + " ; CI: " + cedula + " ; Telefono: " + telefono + " ; Fecha de nacimiento: " + fechaNacimiento;
            return retorno;
        }

        public static bool ValidarNombreVoluntario(string nombre)
        {
            return nombre != "" && nombre != " ";
        }

        public static bool ValidarCIVoluntario(int ci)
        {
            return ci.ToString().Length >= 7 & ci.ToString().Length <= 9;
        }

        public static bool ValidarTelVoluntario(int tel)
        {
            return tel.ToString().Length >= 8 && tel.ToString().Length <= 9;
        }

        public static bool ValidarFechaNac(DateTime fechaNac)
        {
            return fechaNac <= DateTime.Now.AddYears(-16);
        }
        #endregion

    }
}
