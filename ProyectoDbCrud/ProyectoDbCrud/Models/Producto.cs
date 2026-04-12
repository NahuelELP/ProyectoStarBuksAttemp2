namespace ProyectoDbCrud.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string? Name { get; set; } = string.Empty;
        public double Precio { get; set; }
    }
}
