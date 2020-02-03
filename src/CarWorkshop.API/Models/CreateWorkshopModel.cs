using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarWorkshop.API.Models
{
    public class CreateWorkshopModel
    {
        [Required]
        public string CompanyName { get; set;  }

        [Required]
        public List<string> Trademarks { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string PostalCode { get; set; }

        [Required]
        public string Country { get; set; }
    }
}
