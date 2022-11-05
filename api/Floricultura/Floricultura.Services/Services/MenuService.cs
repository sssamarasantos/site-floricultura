using Floricultura.Data;
using Floricultura.Domain.Interfaces.Services;
using Floricultura.Domain.Models.Menu;
using Microsoft.EntityFrameworkCore;

namespace Floricultura.Services.Services
{
    public class MenuService : IMenuService
    {
        private readonly Context _context;
        public MenuService(Context context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Menu>> BuscarMenuAsync()
        {
            return await _context.Menu.Include(x => x.SubMenus).ToListAsync();
        }
    }
}
