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
        test
        #region Metodos

        //Constructor
        //***********

        public Voluntario (string nombre, int cedula, int telefono, DateTime fechaNacimiento)
        {
            this.nombre = nombre;
            this.cedula = cedula;
            this.telefono = telefono;
            this.fechaNacimiento = fechaNacimiento;
        }



        #endregion

    }
}
