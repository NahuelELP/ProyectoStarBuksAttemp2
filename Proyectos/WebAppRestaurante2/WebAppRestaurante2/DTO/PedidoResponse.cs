namespace WebAppRestaurante2.DTO
{
    public class PedidoResponse
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public string NombreCliente { get; set; } = string.Empty;
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public List<DetallePedidoResponse> DetallesPedido { get; set; } = new();
    }
}
