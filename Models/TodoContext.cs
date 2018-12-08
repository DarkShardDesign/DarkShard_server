using Microsoft.EntityFrameworkCore;

namespace darkshard_server.Models
{
  public class TodoContext : DbContext
  {
    public TodoContext(DbContextOptions<TodoContext> options)
      : base(options)
      {
      }

      public DbSet<TodoItem> TodoItems { get; set; }
  }
}