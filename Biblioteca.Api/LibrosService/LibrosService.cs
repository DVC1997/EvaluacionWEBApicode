using Biblioteca.Api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca.Api.LibrosService
{
    
    public class LibroService : ILibroService
    {

        public BibliotecaContext _bibliotecaDbContext;

        public LibroService(BibliotecaContext libreriaDbContext)
        {
            _bibliotecaDbContext = libreriaDbContext;
        }


        #region Metodos

        public Libros AddLibro(Libros libro)
        {
            _bibliotecaDbContext.Libros.Add(libro);
            _bibliotecaDbContext.SaveChanges();
            return libro;
        }

        public List<Libros> GetLibros()
        {
            return _bibliotecaDbContext.Libros.ToList();
        }

        public void UpdateLibro(Libros libro)
        {
            _bibliotecaDbContext.Libros.Update(libro);
            _bibliotecaDbContext.SaveChanges();

        }

        public string DeleteLibros(int id)
        {
            string mensaje = "";
            Libros libro = _bibliotecaDbContext.Libros.FirstOrDefault(x => x.Id == id);
            if(libro != null)
            {
                _bibliotecaDbContext.Libros.Remove(libro);
                _bibliotecaDbContext.SaveChanges();
                mensaje = "El Libro se borro";
            }
            else
            {
                mensaje = "El Libro con el id: " + id + " no existe";
            }

            return mensaje;

        }


        #endregion

    }
}
