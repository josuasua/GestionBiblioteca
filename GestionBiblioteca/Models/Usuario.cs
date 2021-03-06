﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionBiblioteca.Models
{
    public class Usuario
    {
        private string _nombre;
        private string _apellidos;
        private string _password;
        private string _user;
        private string _email;
        private string _dni;
        private DateTime _fNacimiento;
        private Guid _idUsuario;
        private IList<Prestamo> prestamos;

        public Usuario()
        {
            this._nombre = "";
            this._apellidos = "";
            this._password = "";
            this._user = "";
            this._email = "";
            this._dni = "";
            this._fNacimiento = new DateTime();
            this._idUsuario = new Guid("-1");
            this.prestamos = null;

        }
        public Usuario(string _nombre, string _dni, string _apellidos, string _password, string _user, string _email, DateTime _fNacimiento, Guid _idUsuario, IList<Prestamo> prestamos)
        {

            this._nombre = _nombre;
            this._apellidos = _apellidos;
            this._password = _password;
            this._user = _user;
            this._email = _email;
            this._dni = _dni;
            this._fNacimiento = _fNacimiento;
            this._idUsuario = _idUsuario;
            this.prestamos = prestamos;
        }

        public Guid CodigoUsuario
        {
            get
            {
                return _idUsuario;
            }

            set
            {
                _idUsuario = value;
            }
        }

        public DateTime FNacimiento
        {
            get
            {
                return _fNacimiento;
            }

            set
            {
                _fNacimiento = value;
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
            }
        }

        public string User
        {
            get
            {
                return _user;
            }

            set
            {
                _user = value;
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }

            set
            {
                _password = value;
            }
        }

        public string Apellidos
        {
            get
            {
                return _apellidos;
            }

            set
            {
                _apellidos = value;
            }
        }

        public string Nombre
        {
            get
            {
                return _nombre;
            }

            set
            {
                _nombre = value;
            }
        }

        public string Dni
        {
            get
            {
                return _dni;
            }

            set
            {
                _dni = value;
            }
        }

        public IList<Prestamo> Prestamos
        {
            get
            {
                return prestamos;
            }

            set
            {
                prestamos = value;
            }
        }
    }
}