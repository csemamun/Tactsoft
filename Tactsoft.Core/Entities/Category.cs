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
    public class Category:BaseEntity
    {
        [Required]
        [Display(Name = "Category Name")]
        public string CategoryName { get; set; }

        [Required]
        [Display(Name = "Category Code")]
        public string CategoryCode { get; set; }

        [Required]
        public string Description { get; set; }

        
        public string Picture { get; set; }

  
        public Boolean Cancel { get; set; }

        public IList<SubCategory> SubCategories { get; set;}
 
    }
}
