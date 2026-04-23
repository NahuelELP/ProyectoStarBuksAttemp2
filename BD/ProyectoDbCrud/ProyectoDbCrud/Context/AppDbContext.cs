using Microsoft.EntityFrameworkCore;
using ProyectoDbCrud.Models;

namespace ProyectoDbCrud.Context
{
    public class AppDbContext : DbContext //representa una sesion con la base de datos y se utiliza para consultar y guardar instancias de las entidades en la base de datos.
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {

        }
    }
}
