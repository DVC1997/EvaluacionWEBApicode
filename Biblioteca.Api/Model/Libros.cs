using System;
using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Api.Model
{
    public class Libros
    {
        [Key]
        public int Id { get; set; }

        public string Titulo { get; set; }

        public string Autor { get; set; }

        public string Editorial { get; set; }

        public string Paginas { get; set; }

        public DateTime anioEdicion { get; set; }

        public Boolean Activo { get; set; }
    }
}
