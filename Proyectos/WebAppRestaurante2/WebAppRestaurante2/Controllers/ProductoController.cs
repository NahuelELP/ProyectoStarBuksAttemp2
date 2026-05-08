using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAppRestaurante2.Data;
using WebAppRestaurante2.Models;

namespace WebAppRestaurante2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly AppDbContext _context;
        public ProductoController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet("Listar")]
        public async Task<ActionResult<Producto>> GetList()
        {
            var productos = await _context.Productos.ToListAsync();
            return Ok(productos);
        }
        [HttpGet("ObtenerPorId/{Id}")]
        public async Task<ActionResult<Producto>> GetById(int Id)
        {
            var productoEncontrado = await _context.Productos.FindAsync(Id);
            if (productoEncontrado == null)
            {
                return NotFound();
            }
            return Ok(productoEncontrado);
        }
        [HttpPost("Crear")]
        public async Task<ActionResult<Producto>> Crear(Producto producto)
        {
            _context.Productos.Add(producto);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetById), new { id = producto.Id }, producto);
        }
        [HttpPut("Actualizar/{Id}")]
        public async Task<ActionResult<Producto>> Actualizar(int id, Producto producto)
        {
            var productoEncontrado = await _context.Productos.FindAsync(id);
            if (productoEncontrado == null)
            {
                return NotFound();
            }
            productoEncontrado.Nombre = producto.Nombre;
            productoEncontrado.Precio = producto.Precio;
            await _context.SaveChangesAsync();
            return Ok(productoEncontrado);
        }
        [HttpDelete("Eliminar/{Id}")]
        public async Task<IActionResult> Eliminar(int Id)
        {
            var productoEncontrado = await _context.Productos.FindAsync(Id);
            if (productoEncontrado == null)
            {
                return NotFound();
            }
            _context.Productos.Remove(productoEncontrado);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
