using System;
using System.Threading.Tasks;
using CarWorkshop.API.Models;
using CarWorkshop.Entities;
using CarWorkshop.Storage;
using Microsoft.AspNetCore.Mvc;

namespace CarWorkshop.API.Controllers
{
    public class UsersController : EntityControllerBase<User>
    {
        private readonly IUserStorage userStorage;

        public UsersController(IUserStorage userStorage)
            : base(userStorage)
        {
            this.userStorage = userStorage;
        }

        [HttpPost()]
        public async Task<ActionResult<Guid>> Create(
            [FromBody]
            CreateUserModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest();
            }

            if (await this.userStorage.FindByName(model.Name) != null)
            {
                return BadRequest();
            }

            if (await this.userStorage.FindByEmail(model.Email) != null)
            {
                return BadRequest();
            }

            var userId = await this.userStorage.Create(
                new User
                {
                    Name = model.Name,
                    Email = model.Email,
                    City = model.City,
                    PostalCode = model.PostalCode
                });

            return new ActionResult<Guid>(userId);
        }
    }
}
