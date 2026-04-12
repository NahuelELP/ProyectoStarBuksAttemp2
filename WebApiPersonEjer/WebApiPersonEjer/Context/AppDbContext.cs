using Microsoft.EntityFrameworkCore;
using WebApiPersonEjer.Models;

namespace WebApiPersonEjer.Context
{
    public class AppDbContext : DbContext //dbContext classe fundamental- ORM facilita el acceso y modificacion a base de datos 
    {
        public AppDbContext(DbContextOptions <AppDbContext>options) : base (options)
        {

        }
        public DbSet<Person> Persons { get; set; }
    }
}
