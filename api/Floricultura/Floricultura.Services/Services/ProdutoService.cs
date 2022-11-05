using AutoMapper;
using Floricultura.Data;
using Floricultura.Domain.DTOs.Produto;
using Floricultura.Domain.Interfaces.Clients;
using Floricultura.Domain.Interfaces.Services;
using Floricultura.Domain.Models.Produto;
using Microsoft.AspNetCore.Http;

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

        public async Task IncluirAsync(ProdutoRequest request, CancellationToken cancellationToken)
        {
            _ = request ?? throw new ArgumentNullException(nameof(request));

            var nomeImagem = await IncluirFotoAsync(request.Foto);
            var produto = _mapper.Map<Produto>(request);
            produto.ProdutoFoto = new ProdutoFoto { Foto = nomeImagem };
            await _context.Produto.AddAsync(produto, cancellationToken);
            _context.SaveChanges();
        }

        private async Task<string> IncluirFotoAsync(IFormFile foto)
        {
            var nomeImagem = "cestas/" + foto.FileName;
            await _s3Client.UploadFileAsync(nomeImagem, foto);
            return nomeImagem;
        }
    }
}
