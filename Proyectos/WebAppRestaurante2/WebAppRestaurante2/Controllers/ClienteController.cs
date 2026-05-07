using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAppRestaurante2.Data;
using WebAppRestaurante2.Models;


namespace WebAppRestaurante2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ClienteController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet("Listar")]
        public async Task<ActionResult<Cliente>> GetList()
        {
            var clientes = await _context.Set<Cliente>().ToListAsync();
            return Ok(clientes);
        }
        [HttpGet("ObtenerPorId/{Id}")]
        public async Task<ActionResult<Cliente>> GetById(int id)
        {
            var clienteEncontrado = await _context.Clientes.FindAsync(id);
            if (clienteEncontrado == null)
            {
                return NotFound();
            }
            return Ok(clienteEncontrado);
        }
        [HttpPost("Crear")]
        public async Task<ActionResult<Cliente>> Crear(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetById), new { id = cliente.Id }, cliente);
        }
        [HttpPut("Actualizar/{Id}")]
        public async Task<ActionResult<Cliente>> Actualizar(int id, Cliente cliente)
        {
            var clienteEncontrado = await _context.Clientes.FindAsync(id);
            if (clienteEncontrado == null)
            {
                return NotFound();
            }
            clienteEncontrado.Nombre = cliente.Nombre;
            clienteEncontrado.Telefono = cliente.Telefono;
            await _context.SaveChangesAsync();
            return Ok(clienteEncontrado);
        }
        [HttpDelete("Eliminar/{Id}")]
        public async Task<IActionResult> Eliminar(int id)
        {
            var clienteEncontrado = await _context.Clientes.FindAsync(id);
            if (clienteEncontrado == null)
            {
                return NotFound();
            }
            _context.Clientes.Remove(clienteEncontrado);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
