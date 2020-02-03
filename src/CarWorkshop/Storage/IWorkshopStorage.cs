using CarWorkshop.Entities;
using System.Threading.Tasks;

namespace CarWorkshop.Storage
{
    public interface IWorkshopStorage : IEntityStorage<Workshop>
    {
        Task<Workshop> FindByCompanyName(string companyName);
    }
}
