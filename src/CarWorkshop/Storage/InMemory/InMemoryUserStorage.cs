using CarWorkshop.Entities;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace CarWorkshop.Storage.InMemory
{
    public class InMemoryUserStorage : InMemoryEntityStorage<User>, IUserStorage
    {
        public Task<User> FindByEmail(string email)
        {
            var user = this.entities
                .Where(u => StringComparer.OrdinalIgnoreCase.Compare(u.Email, email) == 0)
                .FirstOrDefault();

            return Task.FromResult(user);
        }

        public Task<User> FindByName(string name)
        {
            var user = this.entities
                .Where(u => StringComparer.OrdinalIgnoreCase.Compare(u.Name, name) == 0)
                .FirstOrDefault();

            return Task.FromResult(user);
        }
    }
}
