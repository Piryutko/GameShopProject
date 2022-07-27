using GameShopLibrary;
using Microsoft.AspNetCore.Mvc;
using System;

namespace GameShopWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [Route("{firstName}/{lastName}/{nickName}/{paymentOption}")]
        [HttpPost]
        public void Create(string firstName, string lastName, string nickName, PaymentOption paymentOption)
        { 
        }

        [Route("{newName}")]
        [HttpPut]
        public void ChangeName(string newName)
        { 
        }

        [Route("{userId}")]
        [HttpDelete]
        public void Delete(Guid userId)
        { }

    }
}
