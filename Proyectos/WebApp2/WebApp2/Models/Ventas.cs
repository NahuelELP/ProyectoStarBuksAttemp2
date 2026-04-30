namespace WebApp2.Models
{
    public class Ventas
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; } = new ();
        public decimal Total { get; set; }
        public DateTime Fecha { get; set; }
        public List<DetalleVenta> DetalleVentas { get; set; } = new ();
    }
}
