using CarWorkshop.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarWorkshop.Storage
{
    public interface IWorkshopStorage : IEntityStorage<Workshop>
    {
        Task<Workshop> FindByCompanyName(string companyName);

        Task<IEnumerable<Workshop>> FindByCity(string city);
    }
}
