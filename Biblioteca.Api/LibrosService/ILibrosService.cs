using Biblioteca.Api.Model;
using System.Collections.Generic;

namespace Biblioteca.Api.LibrosService
{
    public interface ILibroService
    {
        Libros AddLibro(Libros libro);

        List<Libros> GetLibros();

        void UpdateLibro(Libros libro);

        string DeleteLibros(int id);
    }
}
