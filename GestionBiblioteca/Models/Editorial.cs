using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionBiblioteca.Models
{
    public class Editorial
    {
        private Guid _idEditorial;
        private string _nombre;

        public Guid IdEditorial
        {
            get
            {
                return _idEditorial;
            }

            set
            {
                _idEditorial = value;
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

        public Editorial(Guid _idEditorial, string _nombre)
        {
            this._idEditorial = _idEditorial;
            this._nombre = _nombre;
        }

        public Editorial()
        {
            this._idEditorial = new Guid("-1");
            this._nombre = "";
        }


    }
}