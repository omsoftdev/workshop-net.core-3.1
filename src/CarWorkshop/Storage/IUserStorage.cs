using System.Threading.Tasks;
using CarWorkshop.Entities;

namespace CarWorkshop.Storage
{
    public interface IUserStorage : IEntityStorage<User>
    {
        Task<User> FindByEmail(string email);

        Task<User> FindByName(string name);
    }
}
