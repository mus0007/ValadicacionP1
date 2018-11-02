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

        public Encuesta(int id, string nombre, string descripcion, bool activa = false)
        {
            this.id = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.activa = activa;
        }

        private int id;
        public int Id
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

        public List<Valoracion> getOpiniones()
        {
            return opiniones;
        }
        public void setOpinion(int valor, string opinion = null )
        {
            if(valor != 0){
                this.opiniones.Add(new Valoracion(valor, opinion));
            }
        }

        public override bool Equals(object obj)
        {
            Encuesta encuesta = obj as Encuesta;
            
            if(this.Id == encuesta.Id)
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return this.Id;
        }
    }
}
