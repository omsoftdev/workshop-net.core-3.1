using System;
using System.ComponentModel.DataAnnotations;

namespace CarWorkshop.API.Models
{
    public class CreateAppointmentModel
    {
        [Required]
        public Guid? UserId { get; set; }

        [Required]
        public Guid? WorkshopId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime? Time { get; set; }

        [Required]
        public string CarTrademark { get; set; }
    }
}
