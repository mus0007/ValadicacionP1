﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibClases
{
    public class Usuario
    {

        public Usuario(int _idUsuario, string _nombre, string _apellido, string cuenta, string _eMail)
        {
            this.idUsuario = _idUsuario;
            this.nombre = _nombre;
            this.apellido = _apellido;
            this.cuenta = cuenta;
            this.eMail = _eMail;
            this.contrasena = "";
        }

        public Usuario(int _idUsuario, string _nombre, string _apellido, string cuenta, string _eMail, string _contrasena)
        {
            this.idUsuario = _idUsuario;
            this.nombre = _nombre;
            this.apellido = _apellido;
            this.cuenta = cuenta;
            this.eMail = _eMail;
            this.contrasena = _contrasena;
        }

        private int idUsuario;
        public int IdUsuario
        {
            get { return this.idUsuario; }
            set { this.idUsuario = value; }
        }

        private string nombre;
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        private string apellido;
        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
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

        private string eMail;
        public string EMail
        {
            get { return this.eMail; }
            set { this.eMail = value; }
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

        public bool cambiarPassNoBD(string pass)
        {
            if (!usuarioGrabado)
            {
                asignarPass(pass);
                return true;
            }
            return false;
        }

        public bool cambiarPassEnUso(string passOld, string passNew)
        {
            if (usuarioGrabado && this.contrasena == passOld)
            {
                asignarPass(passNew);
                return true;
            }
            return false;
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

