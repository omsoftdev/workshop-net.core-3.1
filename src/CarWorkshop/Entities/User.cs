using System;

namespace CarWorkshop.Entities
{
    public class User : PersistentEntity
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string City { get; set; }

        public string PostalCode { get; set; }

        public string Country { get; set; }
    }
}
