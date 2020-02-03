using CarWorkshop.Entities;
using System;
using System.Threading.Tasks;

namespace CarWorkshop.Storage
{
    public interface IEntityStorage<T> where T : PersistentEntity
    {
        Task<Guid> Create(T entity);

        Task<bool> Delete(Guid id);

        Task<T> FindById(Guid id);
    }
}
