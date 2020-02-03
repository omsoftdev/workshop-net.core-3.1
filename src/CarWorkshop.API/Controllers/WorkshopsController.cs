using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using CarWorkshop.API.Models;
using CarWorkshop.Entities;
using CarWorkshop.Storage;
using Microsoft.AspNetCore.Mvc;

namespace CarWorkshop.API.Controllers
{
    public class WorkshopsController : EntityControllerBase<Workshop>
    {
        private readonly IWorkshopStorage storage;

        public WorkshopsController(IWorkshopStorage storage)
            : base(storage)
        {
            this.storage = storage;
        }

        [HttpPost()]
        public async Task<ActionResult<Guid>> Create(
            [FromBody]
            CreateWorkshopModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest();
            }

            if (await this.storage.FindByCompanyName(model.CompanyName) != null)
            {
                return BadRequest();
            }

            var id = await this.storage.Create(
                new Workshop
                {
                    CompanyName = model.CompanyName,
                    City = model.City,
                    Country = model.Country,
                    PostalCode = model.PostalCode,
                    Trademarks = new List<string>(model.Trademarks)
                });

            return new ActionResult<Guid>(id);
        }

        [HttpPost("search")]
        public async Task<ActionResult<object>> Search(string city)
        {
            if (string.IsNullOrEmpty(city))
            {
                return BadRequest();
            }

            var workshops = await this.storage.FindByCity(city);

            return new ActionResult<object>(
                workshops
                    .Select(w => new { w.Id, w.CompanyName })
                    .ToList());
        }
    }
}
