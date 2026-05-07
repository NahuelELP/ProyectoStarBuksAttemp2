using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp.Data;
using WebApp.Model;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : Controller
    {
        private readonly AppDbContext _context;

        public VentaController(AppDbContext context)
        {
            _context = context;
        }
        //POST
        [HttpPost("RegistrarVenta")]
        public async Task<ActionResult<Venta>> RegistrarVenta(CrearVentaRequest request)
        {
            var usuario = await _context.Usuarios.FindAsync(request.UsuarioId);
            if (usuario == null)
            {
                return NotFound();
            }
            if (request.Detalles == null || request.Detalles.Count == 0)
            {
                return BadRequest("La venta debe tener al menos un producto.");
            }
            var venta = new Venta
            {
                UsuarioId = request.UsuarioId,
                Fecha = DateTime.Now,
                Total = 0,
                Detalles = new List<DetalleVenta>()
            };
            foreach(var detalle in request.Detalles)
            {
                var producto = await _context.Productos.FindAsync(detalle.ProductoId);
                
                if (producto == null)
                {
                    return BadRequest($"El producto con ID {detalle.ProductoId} no existe.");
                }
                if (detalle.Cantidad <= 0)
                {
                    return BadRequest("La cantidad debe ser mayor a 0.");
                }
                var detalleVenta = new DetalleVenta
                {
                    ProductoId = producto.Id,
                    Cantidad = detalle.Cantidad,
                    PrecioUnitario = producto.Precio
                };
                venta.Detalles.Add(detalleVenta);
            }
            venta.Total = venta.Detalles.Sum(d => d.PrecioUnitario * d.Cantidad);
            _context.Ventas.Add(venta);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetVenta), new { id = venta.Id }, new
            {
                ventaId = venta.Id,
                total = venta.Total
            });
        }
        //GET por Id
        [HttpGet("VerVenta/{id}")]
        public async Task<ActionResult<Venta>> GetVenta(int id)
        {
            var venta = await _context.Ventas
            .Include(v => v.Usuario)
            .Include(v => v.Detalles)
                .ThenInclude(d => d.Producto)
            .FirstOrDefaultAsync(v => v.Id == id);

            if (venta == null)
            {
                return NotFound("La venta no existe.");
            }

            var ventaResponse = new
            {
                id = venta.Id,
                usuarioId = venta.UsuarioId,
                usuario = new
                {
                    id = venta.Usuario.Id,
                    nombre = venta.Usuario.Nombre,
                    email = venta.Usuario.Email
                },
                fecha = venta.Fecha,
                total = venta.Total,
                detalles = venta.Detalles.Select(d => new
                {
                    productoId = d.ProductoId,
                    producto = d.Producto.Nombre,
                    cantidad = d.Cantidad,
                    precioUnitario = d.PrecioUnitario,
                    subtotal = d.Cantidad * d.PrecioUnitario
                })
            };
            return Ok(ventaResponse);
        }
    }
}   