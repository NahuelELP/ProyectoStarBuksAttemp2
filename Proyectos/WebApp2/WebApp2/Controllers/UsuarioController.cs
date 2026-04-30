using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp2.Data;
using WebApp2.Models;

namespace WebApp2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UsuarioController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var usuarios = await _context.Usuario.ToListAsync();
            return Ok(usuarios);
        }
        [HttpGet("ObtenerPorID/{id}")]
        public async Task<ActionResult> GetById(int id)
        {
            var usuarioEncontrado = await _context.Usuario.FindAsync(id);

            if (usuarioEncontrado == null)
            {
                return NotFound();
            }
            return Ok(usuarioEncontrado);
        }
        [HttpPost("Crear")]
        public async Task<ActionResult> CrearUsuario(Usuario usuario)
        {
            _context.Usuario.Add(usuario);
            await _context.SaveChangesAsync();
            return Ok(usuario);
        }
        [HttpPut("Actualizar/{id}")]
        public async Task<ActionResult> ActualizarUsuario(int id, Usuario usuario)
        {
            var usuarioEncontrado = await _context.Usuario.FindAsync(id);
            if(usuarioEncontrado == null)
            {
                return NotFound();
            }
            usuarioEncontrado.Nombre = usuario.Nombre;
            usuarioEncontrado.Email = usuario.Email;
            await _context.SaveChangesAsync();
            return Ok(usuarioEncontrado);
        }
        [HttpDelete("Eliminar/{id}")]
        public async Task<ActionResult> Eliminar(int id)
        {
            var usuarioEncontrado = await _context.Usuario.FindAsync(id);
            if (usuarioEncontrado == null)
            {
                return NotFound();
            }
            _context.Usuario.Remove(usuarioEncontrado);
            await _context.SaveChangesAsync();
            return NoContent(); //NoContent se utiliza para indicar que la solicitud se ha procesado
                                //correctamente pero no hay contenido que devolver
        }
    }
}
