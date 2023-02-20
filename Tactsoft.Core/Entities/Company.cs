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
    public class Company:BaseEntity
    {
        //user table not created
        [Required]
        [Display(Name = "User Id")]
        public long UserId { get; set; }

        [Required]
        [Display(Name = "Country Id")]
        public long CountryId { get; set; }

        [Required]
        [Display(Name = "State Id")]
        public long StateId { get; set; }

        [Required]
        [Display(Name = "City Id")]
        public long CityId { get; set; }

        [Required]
        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; }

        [Required]
        [Display(Name = "Contact Number")]
        public string ContactNumber { get; set; }

        public Country Country { get; set; }
        public State State { get; set; }
        public City City { get; set; }

        public IList<WareHouse> WareHouses { get; set; }
        public IList<Currency> Currencies { get; set; }
        public IList<Item> Items { get; set; }

    }
}
