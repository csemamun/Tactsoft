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
    public class Unit : BaseEntity
    {
        [Required]
        [Display(Name = "Unit Name")]
        public string UnitName { get; set; }
        public IList<Item> Items { get; set; }
    }
   

}
