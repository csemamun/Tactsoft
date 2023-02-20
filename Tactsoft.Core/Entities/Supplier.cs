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
    public class Supplier : BaseEntity
    {
        [Required]
        [Display(Name = "Supplier Name")]
        public string SupplierName { get; set; }

        [Required]
        [Display(Name = "Supplier Address")]
        public string SupplierAddress { get; set; }
    }
}