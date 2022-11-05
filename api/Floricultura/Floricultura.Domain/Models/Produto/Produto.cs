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
        public int IdFoto { get; set; }

        public virtual Categoria? Categoria { get; set; }
        public virtual ProdutoFoto? ProdutoFoto { get; set; }
    }
}
