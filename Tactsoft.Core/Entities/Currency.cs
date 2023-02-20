using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Tactsoft.Core.Base;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Tactsoft.Core.Entities
{
    public class Currency:BaseEntity
    {
        
            [Required]
            [Display(Name = "Country Id")]
            public long CountryId { get; set; }

            [Required]
            [Display(Name = "Company Id")]
            public long CompanyId { get; set; }

            [Required]
            [Display(Name = "Currency Name")]
            public string CurrencyName { get; set; }

            [Required]
            [Display(Name = "Currency Code")]
            public string CurrencyCode { get; set; }

            [Required]
            public string Syambol { get; set; }

            [Required]
            [Display(Name = "Is Default")]
            public Boolean IsDefault { get; set; }

            public Country Country { get; set; }
            public Company Company { get; set; }
       
    }
}
