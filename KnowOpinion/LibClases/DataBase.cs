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
            Usuario u1 = new Usuario(++nextUser, "Usuario1@gmail.com", "usuario1");
            Usuario u2 = new Usuario(++nextUser, "Usuario2@gmail.com", "usuario2");
            Usuario u3 = new Usuario(++nextUser, "Usuario3@gmail.com", "usuario3");
            
            Encuesta e1 = new Encuesta(++nextPoll, "Encuesta"+(this.nextPoll).ToString(), "encuesta1descripcion", true);
            Encuesta e2 = new Encuesta(++nextPoll, "Encuesta"+(this.nextPoll).ToString(), "encuesta2descripcion", true);

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

        public List<Encuesta> getNoActivas()
        {
            List<Encuesta> encuestasNoActivas = new List<Encuesta>();
            foreach (Encuesta e in encuestas)
            {
                if (!e.Activa)
                {
                    encuestasNoActivas.Add(e);
                }
            }
            return encuestasNoActivas;
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

        public Usuario getUsuario(string cuenta)
        {
            foreach(Usuario u in usuarios)
            {
                if (u.Cuenta.Equals(cuenta))
                {
                    return u;
                }
            }
            return null;
        }

        public void sugerirEncuesta(string nombre, string descripcion)
        {
            Encuesta e = new Encuesta(++nextPoll, "Encuesta" + (this.nextPoll).ToString(), descripcion);
            sugerencias.Add(e);
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
            if (descripcion != null && nombre != null)
            {
                foreach(Encuesta ee in encuestas)
                {
                    if(ee.Nombre == nombre)
                    {
                        return false;
                    }
                }
                Encuesta e = new Encuesta(++nextPoll, nombre, descripcion, activa);
                encuestas.Add(e);
                return true;
            }
            return false;
            
        }

        public bool modificarEncuesta(string nombre, string descripcion)
        {
            foreach(Encuesta e in encuestas)
            {
                if(e.Nombre == nombre)
                {
                    e.Nombre = nombre;
                    e.Descripcion = descripcion;
                    return true;
                }
            }
            return false;
        }

        public bool borrarEncuesta(string nombre)
        {
            Encuesta prueba = null;
            foreach (Encuesta e in encuestas)
            {
                if (e.Nombre.Equals(nombre))
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
