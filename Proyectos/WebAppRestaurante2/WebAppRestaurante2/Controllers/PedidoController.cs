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
        //1. Recibe PedidoRequest
        //2. Valida cliente
        //3. Valida productos
        //4. Crea un Pedido
        //5. Crea DetallePedido
        //6. Guarda Pedido en la BD
        //7. Arma un PedidoResponse
        //8. Devuelve PedidoResponse  
        public async Task<ActionResult<PedidoResponse>> CrearPedido(PedidoRequest pedidoRequest)
        {
            //Buscamos si en la request se proporcionó un cliente válido
            //Validamos si existe el cliente
            //se valida si los detalles del pedidos no son nulos o vacios
            //se crea un nuevo pedido
            var ClienteEncontrado = await _context.Clientes.FindAsync(pedidoRequest.ClienteId);
            if (ClienteEncontrado == null)
            {
                return NotFound("Cliente no encontrado");
            }
            var nuevoPedido = new Pedido
            {
                ClienteId = pedidoRequest.ClienteId,
                Fecha = DateTime.Now,
                Total = 0m,
                Detalles = new List<DetallePedido>()
            };
            //se valida cada detalle del pedido
            //validar si el producto existe
            //validar la cantidad del producto
            //crear un nuevo detalle del pedido
            decimal totalPedido = 0;
            var detalleResponse = new List<DetallePedidoResponse>();
            foreach (var detalle in pedidoRequest.DetallesPedidoRequest)
            {
                if(detalle.Cantidad <= 0)
                {
                    return BadRequest("La cantidad debe ser mayor a cero");
                }
                var nuevoDetallePedido = new DetallePedido
                {
                    ProductoId = detalle.ProductoId,
                    Cantidad = detalle.Cantidad,
                    PrecioUnitario = Producto.
                };
                nuevoPedido.Detalles.Add(nuevoDetallePedido);
                totalPedido += nuevoDetallePedido.Cantidad * nuevoDetallePedido.PrecioUnitario;
                detalleResponse.Add(new DetallePedidoResponse
                {
                    ProductoId = nuevoDetallePedido.ProductoId,
                    Cantidad = nuevoDetallePedido.Cantidad,
                    PrecioUnitario = nuevoDetallePedido.PrecioUnitario
                });
            }
            nuevoPedido.Total = totalPedido;
            _context.Pedidos.Add(nuevoPedido);
            await _context.SaveChangesAsync();
            var pedidoResponse = new PedidoResponse
            {
                Id = nuevoPedido.Id,
                ClienteId = nuevoPedido.ClienteId,
                NombreCliente = ClienteEncontrado.Nombre,
                Fecha = nuevoPedido.Fecha,
                Total = nuevoPedido.Total,
                DetallesPedido = detalleResponse
            };
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
