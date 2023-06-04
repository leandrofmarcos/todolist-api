using Microsoft.EntityFrameworkCore;
using TodoListApi.Models;

namespace TodoListApi.Db
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {
        }

        public DbSet<Todo> Todos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Defina aqui as configurações adicionais do modelo, como chaves primárias, relacionamentos, etc.
        }
    }
}
