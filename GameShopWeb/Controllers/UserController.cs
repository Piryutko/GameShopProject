using GameShopLibrary;
using Microsoft.AspNetCore.Mvc;
using System;

namespace GameShopWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost]
        public void CreatorUser(string firstName, string lastName, string nickName, Guid id,PaymentOption paymentOption)
        { }

        [HttpPut]
        public void ChangeName(Guid id,string newName)
        { }

        [HttpDelete]
        public void DeleteUser(Guid id)
        { }

    }
}
