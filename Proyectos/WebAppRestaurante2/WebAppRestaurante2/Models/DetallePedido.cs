namespace WebAppRestaurante2.Models
{
    public class DetallePedido
    {
        public int Id { get; set; }
        public int PedidoId { get; set; }
        public Pedido Pedido { get; set; } = new ();
        public int ProductoId { get; set; }
        public Producto Producto { get; set; } = new ();
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
    }
}
