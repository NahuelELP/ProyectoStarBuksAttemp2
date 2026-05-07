namespace WebAppRestaurante.Models
{
    public class PedidoRequest
    {
        public int UsuarioId { get; set; }
        public List<DetallePedidoRequest> DetallePedidoRequests { get; set; } = new ();
    }
}
