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
    public class Item:BaseEntity
    {
        [Required]
        [Display(Name = "Sub Category Id")]
        public long SubCategoryId { get; set; }

        [Required]
        [Display(Name = "Company Id")]
        public long CompanyId { get; set; }

        [Required]
        [Display(Name = "Unit Id ")]
        public long UnitId { get; set; }

        [Required]
        [Display(Name = "Item Code")]
        public string ItemCode { get; set; }

        [Required]
        [Display(Name = "Item Name")]
        public string ItemName { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Measure { get; set; }

        [Required]
        [Display(Name = "Measure value")]
        public float Measurevalue { get; set; }

        [Display(Name = "Unit Price")]
        public float UnitPrice { get; set; }

        [Required]
        [Display(Name = "Sell Price")]
        public float SellPrice { get; set; }

        [Required]
        [Display(Name = " Old Unit Price")]
        public float OldUnitPrice { get; set; }

        [Required]
        [Display(Name = "Old Sell Price")]
        public float OldSellPrice { get; set; }

        [Required]
        [Display(Name = "Reorder Level")]
        public string ReOrderLevel { get; set; }

        [Required]
        public float Stock { get; set; }

        public SubCategory SubCategory { get; set; }
        public Company Company { get; set; }
        public Unit Unit { get; set; }

        public IList<OpenQuantity> OpenQuantities { get; set; }


    }
}
