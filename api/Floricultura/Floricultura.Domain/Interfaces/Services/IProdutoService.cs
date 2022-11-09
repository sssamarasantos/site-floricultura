using Floricultura.Domain.DTOs.Produto;

namespace Floricultura.Domain.Interfaces.Services
{
    public interface IProdutoService
    {
        Task IncluirAsync(ProdutoRequest request);
    }
}
