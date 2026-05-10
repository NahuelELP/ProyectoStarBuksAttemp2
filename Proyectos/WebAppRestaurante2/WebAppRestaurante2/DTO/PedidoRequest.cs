using WebAppRestaurante2.Models;

namespace WebAppRestaurante2.DTO
{
    public class PedidoRequest
    {
        public int ClienteId { get; set; }
        public List<DetallePedidoRequest> DetallesPedidoRequest { get; set; } = new();
    }
}
