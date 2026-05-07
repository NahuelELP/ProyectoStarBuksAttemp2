using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using WebAppRestaurante.Data;
using WebAppRestaurante.Models;

namespace WebAppRestaurante.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
            private readonly AppDbContext _context;
    
            public PedidoController(AppDbContext context)
            {
                _context = context;
            }

        [HttpPost("CrearPedido")]
        public async Task<ActionResult> CrearPedido([FromBody] PedidoRequest pedidoRequest)
        {
            var usuario = await _context.Clientes.FindAsync(pedidoRequest.UsuarioId);
            if (usuario == null)
            {
                return NotFound("Usuario no encontrado");
            }
            if(pedidoRequest.DetallePedidoRequests == null || !pedidoRequest.DetallePedidoRequests.Any())
            {
                return BadRequest("El pedido debe contener al menos un detalle");
            }
            var pedido = new Pedido
            {
                DataPedido = DateTime.Now,
                ClienteId = usuario.Id,
                Total = 0
            };
            foreach(var detalleRequest in pedidoRequest.DetallePedidoRequests)
            {
                var productoEncontrado = await _context.Productos.FindAsync(detalleRequest.ProductoId);
                if(productoEncontrado == null)
                {
                    return NotFound($"Producto con ID {detalleRequest.ProductoId} no encontrado");
                }
                if(detalleRequest.Cantidad <= 0)
                {
                    return BadRequest("La cantidad debe ser mayor a cero");
                }
                var DetallePeido = new DetallePedido
                {
                    ProductoId = productoEncontrado.Id,
                    Cantidad = detalleRequest.Cantidad,
                    PrecioUnitario = productoEncontrado.Price
                };
                pedido.Total += DetallePeido.Cantidad * DetallePeido.PrecioUnitario;
                pedido.DetallesPedido.Add(DetallePeido);
                await _context.SaveChangesAsync();
            }
            return CreatedAtAction(nameof(ObtenerPedidos), new { id = pedido.Id }, pedido);
        }
        [HttpGet("ObtenerPedidos")]
        public async Task<ActionResult<Pedido>> ObtenerPedidos(int id)
        {
            var pedidos = await _context.Pedidos
                .Include(p => p.Cliente)
                .Include(p => p.DetallesPedido)
                .ThenInclude(d => d.Producto)
                .FirstOrDefaultAsync(v => v.Id == id);
            if (pedidos == null)
            {
                return NotFound("No se encontraron pedidos");
            }
            var PeidoResponse = new
            {
                id = pedidos.Id,
                UsuarioId = pedidos.ClienteId,
                usuario = new
                {
                    id = pedidos.Cliente.Id,
                    nombre = pedidos.Cliente.Name
                },
                DataPedido = pedidos.DataPedido,
                Total = pedidos.Total,
                detalles = pedidos.DetallesPedido.Select(d => new
                {
                    ProductoId = d.ProductoId,
                    ProductoNombre = d.Producto.Name,
                    Cantidad = d.Cantidad,
                    PrecioUnitario = d.PrecioUnitario
                })
            };
            return Ok(PeidoResponse);
        }
    }
}
