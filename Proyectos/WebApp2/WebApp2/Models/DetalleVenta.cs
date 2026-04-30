namespace WebApp2.Models
{
    public class DetalleVenta
    {
        public int Id { get; set; }
        //id de la venta
        public int VentaId { get; set; }
        //id de la venta para relacionar con la tabla ventas, es una clave foranea
        public int ProductoId { get; set; }
        // id del producto para relacionar con la tabla productos, es una clave foranea
        public int Cantidad { get; set; }
        // cantidad de productos vendidos
        public decimal PrecioUnitario { get; set; }
        // precio unitario del producto
    }
}
