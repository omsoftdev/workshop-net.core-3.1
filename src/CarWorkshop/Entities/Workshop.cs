using System;
using System.Collections.Generic;
using System.Text;

namespace CarWorkshop.Entities
{
    public class Workshop : PersistentEntity
    {
        public string CompanyName { get; set; }

        public List<string> Trademarks { get; set; }

        public string City { get; set; }

        public string PostalCode { get; set; }

        public string Country { get; set; }
    }
}
