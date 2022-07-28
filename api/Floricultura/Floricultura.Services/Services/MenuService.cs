using Floricultura.Domain.Interfaces.Repositories;
using Floricultura.Domain.Interfaces.Services;
using Floricultura.Domain.Models.Menu;

namespace Floricultura.Services.Services
{
    public class MenuService : IMenuService
    {
        private readonly IBaseRepository<Menu> _menuRepository;
        public MenuService(IBaseRepository<Menu> menuRepository)
        {
            _menuRepository = menuRepository;
        }
        public async Task<IEnumerable<Menu>> BuscarMenuAsync()
        {
            return await _menuRepository.GetAll();
        }
    }
}
