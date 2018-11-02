using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace LibClases
{
    public class Usuario
    {

        public Usuario(int _idUsuario, string cuenta, string _contrasena)
        {
            this.idUsuario = _idUsuario;
            this.cuenta = cuenta;
            this.contrasena = Encriptar(_contrasena);
        }

        private string Encriptar(string password)
        {
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(password);
            SHA256 mySHA256 = SHA256.Create();
            bytes = mySHA256.ComputeHash(bytes);
            return (System.Text.Encoding.ASCII.GetString(bytes));
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

        public bool comprobarPass(string pass)
        {
            string con = Encriptar(pass);
            return con.Equals(this.contrasena);
        }

        public override bool Equals(object obj)
        {
            Usuario user = obj as Usuario;

            if (this.idUsuario == user.idUsuario)
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return this.idUsuario;
        }
    }
}

