using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using WebAppiRest.Models;

namespace WebAppiRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly Models.DbUsuarioContext _context;

        public UsuarioController(Models.DbUsuarioContext context)
        {
            _context = context;
        }
        [HttpGet("listar")]
        public async Task<ActionResult<IEnumerable<Models.Usuario>>> GetUsuarios()
        {
            return await _context.Usuarios.ToListAsync();
        }
        [HttpGet("Buscar/{id}")]
        public async Task<ActionResult<Usuario>>BuscarPorId(int id)
        {
            var usuarioEncontrado = await _context.Usuarios.FindAsync(id);

            if (usuarioEncontrado == null)
            {
                return NotFound();//404
            }
            return Ok(usuarioEncontrado);
        }
        [HttpPost("guardar")]
        public async Task<ActionResult<Usuario>> GuardarUsuario(Usuario usuario)
        {
            usuario.FechaCreacion = DateTime.Now;
            _context.Usuarios.Add(usuario);
            await _context.SaveChangesAsync();
            return StatusCode(StatusCodes.Status201Created, usuario);
        }
        [HttpPut("actualizar/{id}")]
        public async Task<ActionResult> ActualizarUsuario(int id, Usuario usuario)
        {
            var usuarioActualizado = await _context.Usuarios.FindAsync(id);

            if (usuarioActualizado == null)
            {
                return NotFound();//404
            }
            usuarioActualizado.Nombre = usuario.Nombre;
            usuarioActualizado.Apellido = usuario.Apellido;
            usuarioActualizado.Email = usuario.Email;
            usuarioActualizado.Username = usuario.Username;
            await _context.SaveChangesAsync();
            return Ok(usuarioActualizado);
        }
        [HttpDelete("borrar/{id}")]
        public async Task<ActionResult> EliminarUsuario(int id)
        {
            var usuarioEncontrado = await _context.Usuarios.FindAsync(id);

            if (usuarioEncontrado == null)
            {
                return NotFound();//404
            }
            _context.Usuarios.Remove(usuarioEncontrado);
            await _context.SaveChangesAsync();
            return NoContent();//204
        }
    }
}
