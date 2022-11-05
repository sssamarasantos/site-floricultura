using Floricultura.Domain.Interfaces.Services;
using Floricultura.Domain.Models.Menu;
using Microsoft.AspNetCore.Mvc;

namespace Floricultura.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MenuController : Controller
    {
        private readonly IMenuService _menuService;
        public MenuController(IMenuService menuService)
        {
            _menuService = menuService;
        }

        [HttpGet]
        public async Task<IEnumerable<Menu>> List()
        {
            return await _menuService.BuscarMenuAsync();
        }
    }
}
