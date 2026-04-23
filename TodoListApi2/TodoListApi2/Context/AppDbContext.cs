using Microsoft.EntityFrameworkCore;
using TodoListApi2.Models;

namespace TodoListApi2.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<TodoItem> TodoItems { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
    }
}
