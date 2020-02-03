using CarWorkshop.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarWorkshop.Storage.InMemory
{
    public class InMemoryEntityStorage<T> : IEntityStorage<T> where T : PersistentEntity
    {
        protected List<T> entities = new List<T>();
        protected Dictionary<Guid, T> entitiesById = new Dictionary<Guid, T>();

        public virtual Task<Guid> Create(T entity)
        {
            entity.Id = Guid.NewGuid();

            this.entitiesById.Add(entity.Id, entity);
            this.entities.Add(entity);

            return Task.FromResult(entity.Id);
        }

        public virtual Task<bool> Delete(Guid id)
        {
            if (!this.entitiesById.ContainsKey(id))
            {
                return Task.FromResult(false);
            }

            this.entities.Remove(this.entitiesById[id]);
            this.entitiesById.Remove(id);

            return Task.FromResult(true);
        }

        public virtual Task<T> FindById(Guid userId)
        {
            T entity;
            entitiesById.TryGetValue(userId, out entity);

            return Task.FromResult(entity);
        }

        public virtual Task Update(T entity)
        {
            return Task.CompletedTask;
        }
    }
}
