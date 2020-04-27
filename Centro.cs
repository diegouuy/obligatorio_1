using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1
{
    class Centro
    {
        #region Atributos
        private int id;
        private static int ultimoId;
        private string nombre;
        private string direccion;
        private List<Voluntario> voluntarios;
        private List<Donacion> donaciones;
        #endregion

        #region Propiedades
        public string Nombre
        {
            get { return nombre; }
        }

        public string Direccion
        {
            get { return direccion; }
        }

        public List<Voluntario> Voluntarios
        {
            get { return voluntarios; }
        }

        public List<Donacion> Donaciones
        {
            get { return donaciones; }
        }

        #endregion

        #region Metodos

        public Centro (string nombre, string direccion)
        {
            voluntarios = new List<Voluntario>();
            donaciones = new List<Donacion>();
            this.id = ++ultimoId;
            this.nombre = nombre;
            this.direccion = direccion;
        }

        
        #endregion

    }
}
