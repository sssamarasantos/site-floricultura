namespace Floricultura.Domain.Models.Produto
{
    public class Produto
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public decimal Valor { get; set; }
        public int Quantidade { get; set; }
        public int? IdCategoria { get; set; }

        public Categoria? Categoria { get; set; }
        public IEnumerable<ProdutoFoto>? Fotos { get; set; }
    }
}
