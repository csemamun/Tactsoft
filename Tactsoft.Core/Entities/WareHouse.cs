using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Tactsoft.Core.Base;

namespace Tactsoft.Core.Entities
{
    public class WareHouse : BaseEntity
    {

        [Required]
        [Display(Name = "Company Id")]
        public long CompanyId { get; set; }

        [Required]
        [Display(Name = "Country Id")]
        public long CountryId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Location { get; set; }
        public Company Company { get; set; }
        public Country Country { get; set; }

    }
}
