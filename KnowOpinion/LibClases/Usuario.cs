using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibClases
{
    public class Usuario
    {

        public Usuario(int _idUsuario, string cuenta, string _contrasena)
        {
            this.idUsuario = _idUsuario;
            this.cuenta = cuenta;
            this.contrasena = _contrasena;
        }

        private int idUsuario;
        public int IdUsuario
        {
            get { return this.idUsuario; }
            set { this.idUsuario = value; }
        }

        private string contrasena;
        public string Contrasena
        {
            get { return this.contrasena; }
            set { this.contrasena = value; }
        }

        private string cuenta;
        public string Cuenta
        {
            get { return cuenta; }
            set { this.cuenta = value; }
        }

        private bool usuarioGrabado;
        public bool UsuarioGrabado
        {
            get { return this.usuarioGrabado; }
            set { this.usuarioGrabado = value; }
        }

        public void asignarPass(string pass)
        {
            this.contrasena = pass;
        }

        public bool comprobarPass(string pass)
        {
            if(contrasena == pass)
            {
                return true;
            }
            return false;
        }
    }
}

