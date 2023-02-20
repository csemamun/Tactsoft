﻿using Tactsoft.Core.Entities;
using Tactsoft.Service.DbDependencies;
using Tactsoft.Service.Services.Base;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Tactsoft.Service.Services
{
    public class CountryService : BaseService<Country>, ICountryService
    {
        private readonly AppDbContext _context;
        public CountryService(AppDbContext context) : base(context)
        {
            _context = context;            
        }

        public IEnumerable<SelectListItem> Dropdown()
        {
            return All().Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() });
        }
    }
}
