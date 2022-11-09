﻿using System.Reflection.Metadata;

namespace Floricultura.Domain.Models.Produto
{
    public class ProdutoFoto
    {
        public int Id { get; set; }
        public string? Foto { get; set; }
        public int IdProduto { get; set; }
        public Produto? Produto { get; set; }
    }
}
