namespace WebApp2.Models
{
    public class Producto
    {
        public int Id { get; set; }
        //id del producto, es la clave primaria
        public string Nombre { get; set; } = string.Empty;
        //nombre del producto
        public decimal Precio { get; set; }
        //precio del producto
    }
}
