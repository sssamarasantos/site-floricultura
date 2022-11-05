using AutoMapper;
using Floricultura.Domain.DTOs.Produto;
using Floricultura.Domain.Models.Produto;

namespace Floricultura.Domain.Profiles
{
    public class ProdutoProfile : Profile
    {
        public ProdutoProfile()
        {
            CreateMap<ProdutoRequest, Produto>();
        }
    }
}
