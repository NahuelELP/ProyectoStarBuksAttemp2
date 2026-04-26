namespace WebApp.Model
{
    public class CrearVentaRequest
    {
        public int UsuarioId { get; set; }
        public List<DetalleRequest> Detalles { get; set; } = new ();
    }
}
