using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarWorkshop.API.Models;
using CarWorkshop.Entities;
using CarWorkshop.Storage;
using Microsoft.AspNetCore.Mvc;

namespace CarWorkshop.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EntityControllerBase<T> : ControllerBase where T : PersistentEntity
    {
        private readonly IEntityStorage<T> storage;

        public EntityControllerBase(IEntityStorage<T> storage)
        {
            this.storage = storage;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<T>> Get(Guid id)
        {
            var entity = await this.storage.FindById(id);

            if (entity == null)
            {
                return NotFound();
            }

            return new ActionResult<T>(entity);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            if (!await this.storage.Delete(id))
            {
                return NotFound();
            }

            return Ok();
        }
    }
}
