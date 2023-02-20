using Microsoft.AspNetCore.Mvc.Rendering;
using Tactsoft.Core.Entities;
using Tactsoft.Service.DbDependencies;
using Tactsoft.Service.Services.Base;

namespace Tactsoft.Service.Services
{
    public class CurrencyServices : BaseService<Currency>, ICurrencyServices
    {
        private readonly AppDbContext _context;

        public CurrencyServices(AppDbContext context) : base(context)
        {
            this._context = context;
        }

        public IEnumerable<SelectListItem> Dropdown()
        {
            return All().Select(x => new SelectListItem
            {
                Text = x.CurrencyName,
                Value = x.Id.ToString()
            });
        }
    }
}
