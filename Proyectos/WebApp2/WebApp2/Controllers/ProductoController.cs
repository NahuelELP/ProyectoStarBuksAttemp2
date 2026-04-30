using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp2.Data;
using WebApp2.Models;

namespace WebApp2.Controllers
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
        [HttpGet("ListarProductos")]
        public async Task<ActionResult> Get()
        {
            var productos = await _context.Producto.ToListAsync();
            return Ok(productos);
        }
        [HttpGet("BuscarPorId/{id}")]
        public async Task<ActionResult> GetById(int id)
        {
            var productoEncontrado = await _context.Producto.FindAsync(id);
            if (productoEncontrado == null)
            {
                return NotFound();
            }
            return Ok(productoEncontrado);
        }
        [HttpPost("CrearProducto")]
        public async Task<ActionResult> CreateProducto([FromBody] Producto producto)
        {
            _context.Producto.Add(producto);
            await _context.SaveChangesAsync();
            //✔ devuelve 201 Created
            //✔ indica dónde está el recurso creado
            //✔ devuelve el objeto creado
            //     Metodo CreatedAtAction:
            return CreatedAtAction(nameof(GetById), new { id = producto.Id }, producto);
        }
        [HttpPut("ActualizarProducto/{id}")]
        public async Task<ActionResult> UpdateProducto(int id, [FromBody] Producto producto)
        {
            var productoExistente = await _context.Producto.FindAsync(id);
            if (productoExistente == null)
            {
                return NotFound();
            }
            productoExistente.Nombre = producto.Nombre;
            productoExistente.Precio = producto.Precio;
            await _context.SaveChangesAsync();
            return NoContent();
        }
        [HttpDelete("DeleteProducto/{id}")]
        public async Task<ActionResult> DeleteProducto(int id)
        {
            var productoExistente = await _context.Producto.FindAsync(id);
            if (productoExistente == null)
            {
                return NotFound();
            }
            _context.Producto.Remove(productoExistente);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
