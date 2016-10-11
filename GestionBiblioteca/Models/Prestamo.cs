using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionBiblioteca.Models
{
    public class Prestamo
    {
        private Guid idPrestamo;
        private DateTime fRecogida;
        private DateTime fDevolucion;
        private Usuario usuario;
        private Ejemplar ejemplar;

        public Guid IdPrestamo
        {
            get
            {
                return idPrestamo;
            }

            set
            {
                idPrestamo = value;
            }
        }

        public DateTime FRecogida
        {
            get
            {
                return fRecogida;
            }

            set
            {
                fRecogida = value;
            }
        }

        public DateTime FDevolucion
        {
            get
            {
                return fDevolucion;
            }

            set
            {
                fDevolucion = value;
            }
        }

        public Usuario Usuario
        {
            get
            {
                return usuario;
            }

            set
            {
                usuario = value;
            }
        }

        public Ejemplar Ejemplar
        {
            get
            {
                return ejemplar;
            }

            set
            {
                ejemplar = value;
            }
        }

        public Prestamo(Guid idPrestamo, DateTime fRecogida, DateTime fDevolucion, Usuario usuario, Ejemplar ejemplar)
        {
            this.IdPrestamo = idPrestamo;
            this.FRecogida = fRecogida;
            this.FDevolucion = fDevolucion;
            this.Usuario = usuario;
            this.Ejemplar = ejemplar;
        }
        public Prestamo()
        {
            this.IdPrestamo = new Guid("-1");
            this.FRecogida = new DateTime();
            this.FDevolucion = new DateTime();
            this.Usuario = new Usuario();
            this.Ejemplar = new Ejemplar();
        }
    }
}