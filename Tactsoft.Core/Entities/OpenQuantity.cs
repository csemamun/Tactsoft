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
    public class OpenQuantity : BaseEntity
    {
        [Required]
        [Display(Name = "Item Id")]
        public long ItemId { get; set; }

        [Required]
        [Display(Name = "Opening Quentity")]
        public float OpeningQuentity { get; set; }

        [Required]
        [Display(Name = "Purchase Quantity")]
        public float PurchaseQuantity { get; set; }

        [Required]
        public string Sell { get; set; }

        [Required]
        [Display(Name = "Reorder Quantity")]
        public float ReorderQuantity { get; set; }

        public Item Item { get; set; }
    }
}
