using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionBiblioteca.Models
{
    public class Ejemplar:Libro
    {
        private Guid idEjemplar;
        private Editorial editorial;
        private string isbn;
        private int numeropaginas;
        private DateTime fPublicacion;
        private IList<Prestamo> prestamos;

        public Guid IdEjemplar
        {
            get
            {
                return idEjemplar;
            }

            set
            {
                idEjemplar = value;
            }
        }

        public Editorial Editorial
        {
            get
            {
                return editorial;
            }

            set
            {
                editorial = value;
            }
        }

        public string Isbn
        {
            get
            {
                return isbn;
            }

            set
            {
                isbn = value;
            }
        }

        public int Numeropaginas
        {
            get
            {
                return numeropaginas;
            }

            set
            {
                numeropaginas = value;
            }
        }

        public DateTime FPublicacion
        {
            get
            {
                return fPublicacion;
            }

            set
            {
                fPublicacion = value;
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

        public Ejemplar()
        {
            this.IdEjemplar = new Guid("-1");
            this.Editorial = new Editorial();
            this.Isbn = "";
            this.Numeropaginas = 0;
            this.FPublicacion = new DateTime();
            this.Prestamos = null;
        }

        public Ejemplar(Guid idEjemplar, Editorial editorial, string isbn, int numeropaginas, DateTime fPublicacion, IList<Prestamo> prestamos)
        {
            this.IdEjemplar = idEjemplar;
            this.Editorial = editorial;
            this.Isbn = isbn;
            this.Numeropaginas = numeropaginas;
            this.FPublicacion = fPublicacion;
            this.Prestamos = prestamos;
        }
    }
}