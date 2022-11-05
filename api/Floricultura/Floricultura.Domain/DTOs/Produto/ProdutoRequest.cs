using Microsoft.AspNetCore.Http;

namespace Floricultura.Domain.DTOs.Produto
{
    public class ProdutoRequest
    {
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public decimal Valor { get; set; }
        public int Quantidade { get; set; }
        public int? IdCategoria { get; set; }

        public IFormFile Foto { get; set; }
    }

    public class ProdutoFotoRequest
    {
        public string? Foto { get; set; }
    }
}
