using System;

namespace CarWorkshop.Entities
{
    public class Appointment : PersistentEntity
    {
        public Guid UserId { get; set; }

        public Guid WorkshopId { get; set; }

        public string CarTrademark { get; set; }

        public DateTime Time { get; set; }
    }
}
