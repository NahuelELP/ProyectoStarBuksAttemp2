using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAppRestaurante2.Data;
using WebAppRestaurante2.DTO;
using WebAppRestaurante2.Models;

namespace WebAppRestaurante2.Controllers
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
        public async Task<ActionResult<PedidoResponse>>CrearPedido(PedidoRequest pedidoRequest)
        {
            //Buscamos si en la rekuest se proporcionó un cliente válido
            var cliente = await _context.Clientes.FindAsync(pedidoRequest.ClienteId);
            //Validamos si existe el cliente
            if (cliente == null)
            {
                return NotFound("Cliente no encontrado");
            }
            //se valida si los detalles del pedidos no son nulos o vacios
            if(pedidoRequest.DetallesPedidoRequest == null || pedidoRequest.DetallesPedidoRequest.Count == 0)
            {
                return BadRequest("Detalles del pedido no proporcionados");
            }
            //se crea un nuevo pedido
            var pedidoResponse = new Pedido
            {
                ClienteId = pedidoRequest.ClienteId,
                Fecha = DateTime.Now,
                Total = 0,
                Detalles = new List<DetallePedido>()
            };
            decimal totalPedido = 0;
            //se valida cada detalle del pedido
            foreach(var detallesRequest in pedidoRequest.DetallesPedidoRequest)
            {
                //validar si el producto existe
                var producto = await _context.Productos.FindAsync(detallesRequest.ProductoId);
                if(producto == null)
                {
                    return NotFound($"Producto con ID {detallesRequest.ProductoId} no encontrado");
                }
                //validar la cantidad del producto
                if (detallesRequest.Cantidad <= 0)
                {
                    return BadRequest("La cantidad debe ser mayor a cero");
                }
                //crear un nuevo detalle del pedido
                var detallePedido = new DetallePedido
                {
                    ProductoId = detallesRequest.ProductoId,
                    Cantidad = detallesRequest.Cantidad,
                    PrecioUnitario = producto.Precio
                };
                totalPedido += detallePedido.Cantidad * detallePedido.PrecioUnitario;
                pedidoResponse.Detalles.Add(detallePedido);
            }
            pedidoResponse.Total = totalPedido;
            _context.Pedidos.Add(pedidoResponse);
            await _context.SaveChangesAsync();
            return Ok(pedidoResponse);
        }
        [HttpGet("ObtenerPedido/{id}")]
        public async Task<ActionResult<PedidoResponse>> GetPedido(int id)
        {
            var pedido = await _context.Pedidos
                .Include(p => p.Cliente)
                .Include(p => p.Detalles)
                .ThenInclude(d => d.Producto)
                .FirstOrDefaultAsync(p => p.Id == id);
            if (pedido == null)
            {
                return NotFound("Pedido no encontrado");
            }
            var pedidoResponse = new PedidoResponse
            {
                Id = pedido.Id,
                ClienteId = pedido.ClienteId,
                NombreCliente = pedido.Cliente.Nombre,
                Fecha = pedido.Fecha,
                Total = pedido.Total,
                DetallesPedido = pedido.Detalles.Select(detalle => new DetallePedidoResponse
                {
                    ProductoId = detalle.ProductoId,
                    NombreProducto = detalle.Producto.Nombre,
                    Cantidad = detalle.Cantidad,
                    PrecioUnitario = detalle.PrecioUnitario
                }).ToList()
            };
            return Ok(pedidoResponse);
        }
    }
}
