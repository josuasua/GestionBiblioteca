using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionBiblioteca.Models
{
    public class Libro
    {
        private int _idAutor;
        private string _titulo;
        private Autor _autor;

        public int IdAutor
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

        public string Titulo
        {
            get
            {
                return _titulo;
            }

            set
            {
                _titulo = value;
            }
        }

        

        public Libro()
        {
            this.IdAutor = -1;
            this.Titulo = "";
            this._autor = new Autor();
        }

        public Libro(int _idAutor, string _titulo, Autor _autor)
        {
            this.IdAutor = _idAutor;
            this.Titulo = _titulo;
            this._autor = _autor;
        }
    }
}