using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibClases;

namespace LibClases
{
    public class DataBase
    {

        private int nextUser = 0;
        private int nextPoll = 0;
        private int nextAnswer = 0;
        private List<Usuario> usuarios = new List<Usuario>();
        private List<Encuesta> encuestas = new List<Encuesta>();
        private List<Valoracion> valoraciones = new List<Valoracion>();
        private List<Encuesta> sugerencias = new List<Encuesta>();

        public DataBase()
        {
            Usuario u1 = new Usuario(++nextUser, "Usuario1", "usuario1");
            Usuario u2 = new Usuario(++nextUser, "Usuario2", "usuario2");
            Usuario u3 = new Usuario(++nextUser, "Usuario3", "usuario3");
            
            Encuesta e1 = new Encuesta(++nextPoll, "Encuesta"+(this.nextPoll).ToString(), "encuesta0descripcion", true);
            Encuesta e2 = new Encuesta(++nextPoll, "Encuesta"+(this.nextPoll).ToString(), "encuesta1descripcion", true);

            usuarios.Add(u1);
            usuarios.Add(u2);
            usuarios.Add(u3);

            encuestas.Add(e1);
            encuestas.Add(e2);

        }

        public int setNextPoll()
        {
            return ++this.nextPoll;
        }
        
        public List<Encuesta> getActivas()
        {
            List<Encuesta> encuestasActivas = new List<Encuesta>();
            foreach(Encuesta e in encuestas)
            {
                if (e.Activa)
                {
                    encuestasActivas.Add(e);
                }
            }
            return encuestasActivas;
        }

        public List<Usuario> getUsuarios()
        {
            return this.usuarios;
        }

        public List<Encuesta> getEncuestas()
        {
            return this.encuestas;
        }

        public List<Valoracion> getValoraciones(Encuesta e)
        {
            return e.getOpiniones();
        }

        public Usuario getUsuario(int id)
        {
            foreach(Usuario u in usuarios)
            {
                if (u.IdUsuario.Equals(id))
                {
                    return u;
                }
            }
            return null;
        }

        public void sugerirEncuesta(string nombre, string descripcion)
        {
            Encuesta e = new Encuesta(nextPoll+1, nombre, descripcion);
            sugerencias.Add(e);
        }

        public Encuesta getEncuesta2(int id)
        {
            foreach(Encuesta e in encuestas)
            {
                if (e.Id.Equals(id))
                {
                    return e;
                }
            }
            return null;
        }

        public Encuesta getEncuesta(string nombre)
        {
            foreach (Encuesta e in encuestas)
            {
                if (e.Nombre.Equals(nombre))
                {
                    return e;
                }
            }
            return null;
        }

        public bool addEncuesta(string nombre, string descripcion, bool activa = false)
        {
            int id = ++nextPoll;
            Encuesta e = new Encuesta(id, nombre, descripcion, activa);
            encuestas.Add(e);

            foreach(Encuesta e1 in encuestas)
            {
                if(e1.Id == id)
                {
                    return true;
                }
            }
            return false;
        }

        public bool modificarEncuesta(int id, string nombre, string descripcion, bool activa = false)
        {
            foreach(Encuesta e in encuestas)
            {
                if(e.Id == id)
                {
                    e.Nombre = nombre;
                    e.Descripcion = descripcion;
                    e.Activa = activa;
                    return true;
                }
            }
            return false;
        }

        //Preguntar al profesor si al borrar una encuesta los ids de las demas encuestas a partir de ella deberian bajar una unidad o no
        public bool borrarEncuesta(int id)
        {
            Encuesta prueba = null;
            foreach (Encuesta e in encuestas)
            {
                if (e.Id.Equals(id))
                {
                    prueba = e;
                }
            }
            return encuestas.Remove(prueba);
        }

        public List<Encuesta> getSugeridas()
        {
            return sugerencias;
        }
    }
}
