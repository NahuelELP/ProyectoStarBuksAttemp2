namespace WebAppRestaurante2.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public List<DetallePedido> Detalles { get; set; } = new();
        //lazy loading 
    }
}
