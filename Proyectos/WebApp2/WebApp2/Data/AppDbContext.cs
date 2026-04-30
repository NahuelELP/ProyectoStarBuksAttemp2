using Microsoft.EntityFrameworkCore;
using WebApp2.Models;

namespace WebApp2.Data
{
    //appdbcontext es el nombre de la clase que se encarga de manejar la conexion a la base de datos,
    //hereda de dbcontext
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Ventas> Ventas { get; set; }
        public DbSet<DetalleVenta> DetalleVenta { get; set; }
    }
}
