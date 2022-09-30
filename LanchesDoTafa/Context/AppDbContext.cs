using LanchesDoTafa.Models;
using Microsoft.EntityFrameworkCore;

namespace LanchesDoTafa.Context
{
    public class AppDbContext : DbContext
    {
        protected AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Lanche> Lanches { get; set; }
    }
}
