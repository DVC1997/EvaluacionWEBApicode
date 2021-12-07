using Biblioteca.Api.LibrosService;
using Biblioteca.Api.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibrosController : Controller
    {
        private readonly ILibroService _librosService;

        public LibrosController(ILibroService libroService)
        {
            _librosService = libroService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/Libros/IsAlive")]
        public IActionResult IsAlive()
        {
            return Ok();
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/Libros/GetLibros")]
        public IEnumerable<Libros> GetLibros()
        {
            return _librosService.GetLibros();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/Libros/AddLibros")]
        public IActionResult AddLibros(Libros libros)
        {
            _librosService.AddLibro(libros);
            return Ok();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/Libros/UpdateLibro")]
        public IActionResult UpdateLibro(Libros libro)
        {
            _librosService.UpdateLibro(libro);
            return Ok();
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/Libros/DeleteLibros")]
        public IActionResult DeleteLibros(int id)
        {
           string mensaje = _librosService.DeleteLibros(id);
            return Ok(mensaje);
        }
    }
}
