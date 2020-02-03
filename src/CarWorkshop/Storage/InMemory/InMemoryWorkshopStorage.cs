using CarWorkshop.Entities;
using System;
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
    }
}
