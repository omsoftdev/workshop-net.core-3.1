using System;
using System.Threading.Tasks;
using CarWorkshop.API.Models;
using CarWorkshop.Entities;
using CarWorkshop.Storage;
using Microsoft.AspNetCore.Mvc;

namespace CarWorkshop.API.Controllers
{
    public class AppointmentsController : EntityControllerBase<Appointment>
    {
        private readonly IAppointmentStorage storage;
        private readonly IUserStorage userStorage;
        private readonly IWorkshopStorage workshopStorage;

        public AppointmentsController(
            IAppointmentStorage storage,
            IUserStorage userStorage,
            IWorkshopStorage workshopStorage)
            : base(storage)
        {
            this.storage = storage;
            this.userStorage = userStorage;
            this.workshopStorage = workshopStorage;
        }

        [HttpPost()]
        public async Task<ActionResult<Guid>> Create(
            [FromBody]
            CreateAppointmentModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest();
            }

            var workshop = await this.workshopStorage.FindById(model.WorkshopId.Value);
            if (workshop == null)
            {
                return BadRequest();
            }

            var user = await this.userStorage.FindById(model.UserId.Value);
            if (user == null)
            {
                return BadRequest();
            }

            var id = await this.storage.Create(
                new Appointment
                {
                    UserId = model.UserId.Value,
                    WorkshopId = model.WorkshopId.Value,
                    CarTrademark = model.CarTrademark,
                    Time = model.Time.Value
                });

            return new ActionResult<Guid>(id);
        }
    }
}
