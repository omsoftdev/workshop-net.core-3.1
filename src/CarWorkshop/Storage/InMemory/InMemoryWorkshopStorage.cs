using CarWorkshop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWorkshop.Storage.InMemory
{
    public class InMemoryWorkshopStorage : InMemoryEntityStorage<Workshop>, IWorkshopStorage
    {
        public Task<Workshop> FindByCompanyName(string companyName)
        {
            var workshop = this.entities
                .Where(w => StringComparer.OrdinalIgnoreCase.Compare(w.CompanyName, companyName) == 0)
                .FirstOrDefault();

            return Task.FromResult(workshop);
        }

        public Task<IEnumerable<Workshop>> FindByCity(string city)
        {
            var workshops = this.entities
                .Where(w => StringComparer.OrdinalIgnoreCase.Compare(w.City, city) == 0)
                .ToList();

            return Task.FromResult((IEnumerable<Workshop>)workshops);
        }
    }
}
