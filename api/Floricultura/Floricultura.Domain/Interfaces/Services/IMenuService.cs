using Floricultura.Domain.Models.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Floricultura.Domain.Interfaces.Services
{
    public interface IMenuService
    {
        public Task<IEnumerable<Menu>> BuscarMenuAsync();
    }
}
