namespace WebApp2.Models
{
    public class CrearVentaRequest
    {
        public int UsuarioId { get; set; }
        public List<DetalleVentaRequest> DetalleVentas { get; set; } = new();
    }
}
