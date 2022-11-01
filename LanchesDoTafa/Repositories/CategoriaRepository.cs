using LanchesDoTafa.Context;
using LanchesDoTafa.Models;
using LanchesDoTafa.Repositories.Interfaces;

namespace LanchesDoTafa.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
