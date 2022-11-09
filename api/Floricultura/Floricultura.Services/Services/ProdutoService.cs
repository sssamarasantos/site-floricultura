using AutoMapper;
using Floricultura.Data;
using Floricultura.Domain.DTOs.Produto;
using Floricultura.Domain.Interfaces.Clients;
using Floricultura.Domain.Interfaces.Services;
using Floricultura.Domain.Models.Produto;
using Microsoft.AspNetCore.Http;
using System.Threading;

namespace Floricultura.Services.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IMapper _mapper;
        private readonly IS3Client _s3Client;
        private readonly Context _context;
        public ProdutoService(IMapper mapper, IS3Client s3Client, Context context)
        {
            _mapper = mapper;
            _s3Client = s3Client;
            _context = context;
        }

        public async Task IncluirAsync(ProdutoRequest request)
        {
            _ = request ?? throw new ArgumentNullException(nameof(request));

            var nomeFoto = await IncluirFotoBucketAsync(request.Foto);

            var produto = _mapper.Map<Produto>(request);
            await _context.Produto.AddAsync(produto);
            var idProduto = _context.SaveChanges();

            await IncluirProdutoFotoAsync(idProduto, nomeFoto);
        }

        private async Task<string> IncluirFotoBucketAsync(IFormFile foto)
        {
            var nomeImagem = "cestas/" + foto.FileName;
            await _s3Client.UploadFileAsync(nomeImagem, foto);
            return nomeImagem;
        }

        private async Task IncluirProdutoFotoAsync(int idProduto, string nomeFoto)
        {
            var produtoFoto = new ProdutoFoto
            {
                Foto = nomeFoto,
                IdProduto = idProduto
            };

            await _context.ProdutoFoto.AddAsync(produtoFoto);
            _context.SaveChanges();
        }
    }
}
