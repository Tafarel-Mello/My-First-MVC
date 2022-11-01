using LanchesDoTafa.Models;

namespace LanchesDoTafa.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
