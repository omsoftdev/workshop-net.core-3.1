using System;
using System.ComponentModel.DataAnnotations;

namespace CarWorkshop.API.Models
{
    public class UpdateAppointmentModel
    {
        [Required]
        public Guid? Id { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime? Time { get; set; }
    }
}
