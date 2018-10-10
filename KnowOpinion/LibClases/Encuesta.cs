using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibClases;

namespace LibClases
{
    public class Encuesta
    {
        private string id;
        public string Id
        {
            get { return id; }
            set { this.id = value; }
        }

        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { this.nombre = value; }
        }

        private string descripcion;
        public string Descripcion
        {
            get { return descripcion; }
            set { this.descripcion = value; }
        }

        private bool activa;
        public bool Activa
        {
            get { return activa; }
            set { this.activa = value; }
        }

        private List<Valoracion> opiniones = new List<Valoracion> ();
    }
}
