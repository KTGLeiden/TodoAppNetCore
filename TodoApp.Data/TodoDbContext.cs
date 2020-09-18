using Microsoft.EntityFrameworkCore;
using TodoApp.Domain;

namespace TodoApp.Data
{
    public class TodoDbContext : DbContext
    {
        public DbSet<TodoItem> todoItems { get; set; }

        public TodoDbContext(DbContextOptions<TodoDbContext> options) : base(options)
        {

        }
    }
}
