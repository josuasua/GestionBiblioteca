using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionBiblioteca.Models
{
    public class Autor
    {
        private Guid _idAutor;
        private string _nombreautor;

        public Autor(Guid _idAutor, string _nombreautor)
        {
            this.IdAutor = _idAutor;
            this.Nombreautor = _nombreautor;
        }
        public Autor()
        {
            this.IdAutor = new Guid("-1");
            this.Nombreautor = "";
        }

        public Guid IdAutor
        {
            get
            {
                return _idAutor;
            }

            set
            {
                _idAutor = value;
            }
        }

        public string Nombreautor
        {
            get
            {
                return _nombreautor;
            }

            set
            {
                _nombreautor = value;
            }
        }
    }
}