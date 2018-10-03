using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibClases
{
    class DataBase
    {
        private List<Usuario> usuarios = new List<Usuario>();
        private List<Encuesta> encuestas = new List<Encuesta>();

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
    }
}
