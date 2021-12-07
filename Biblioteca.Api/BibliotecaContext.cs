using Microsoft.EntityFrameworkCore;
using Biblioteca.Api.Model;


namespace Biblioteca.Api
{
    public class BibliotecaContext : DbContext
    {
        public BibliotecaContext(DbContextOptions<BibliotecaContext> options) : base(options)
        {

        }

        public DbSet<Libros> Libros { get; set; } 
    }
}
