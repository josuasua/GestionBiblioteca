using System;
using System.Collections.Generic;
using GestionBiblioteca.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBiblioteca.DAL
{
    interface EjemplarRepository
    {
        IList<Ejemplar> getAll();

        Ejemplar getById(Guid idEjemplar);

        Ejemplar update(Ejemplar ejemplar);

        void delete(Guid idEjemplar);

        Guid create(Ejemplar ejemplar);
    }
}
