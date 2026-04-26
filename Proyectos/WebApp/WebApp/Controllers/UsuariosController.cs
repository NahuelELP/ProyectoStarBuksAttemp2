using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp.Data;
using WebApp.Model;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuariosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UsuariosController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Usuario>>> GetUsuarios()
        {
            var usuarios = await _context.Usuarios.ToListAsync();

            return Ok(usuarios);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Usuario>> GetUsuario(int id)
        {
            var usuario = await _context.Usuarios.FindAsync(id);

            if (usuario == null)
            {
                return NotFound();
            }

            return Ok(usuario);
        }

        [HttpPost]
        public async Task<ActionResult<Usuario>> CrearUsuario(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);

            await _context.SaveChangesAsync();

            return Ok(usuario);
        }
        [HttpPut("Actualizar/{id}")]
        public async Task<ActionResult> ActualizarUsuario(int id, Usuario usuario)
        {
            var UsuarioActualizado = await _context.Usuarios.FindAsync(id);

            if(UsuarioActualizado == null)
            {
                return NotFound();
            }
            UsuarioActualizado.Nombre= usuario.Nombre;
            UsuarioActualizado.Email= usuario.Email;
            await _context.SaveChangesAsync();
            return Ok(UsuarioActualizado);
        }
        [HttpDelete("Eliminar/{id}")]
        public async Task<ActionResult> EliminarUsuario(int id)
        {
            var usuarioEncontrado = await _context.Usuarios.FindAsync(id);

            if (usuarioEncontrado == null)
            {
                return NotFound();
            }
            _context.Usuarios.Remove(usuarioEncontrado);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
