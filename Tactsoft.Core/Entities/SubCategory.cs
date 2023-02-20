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
    public class SubCategory:BaseEntity
    {
        [Required]
        [Display(Name = "Category Id")]
        public long CategoryId { get; set; }

        [Required]
        [Display(Name = "Sub Category Name")]
        public string SubCategoryName { get; set; }

        [Required]
        [Display(Name = "Sub Category Code")]
        public string SubCategoryCode { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Picture { get; set; }

        [Required]
        public bool Cancel { get; set; }

        public Category Category { get; set; }

        public IList<Item> Items { get; set; }
    }
}
