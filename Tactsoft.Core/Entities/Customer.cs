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
    public class Customer : BaseEntity
    {
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
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Contact { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string Address { get; set; }

        public Country Country { get; set; }
        public State State { get; set; }
        public City City { get; set; }
    }
}
