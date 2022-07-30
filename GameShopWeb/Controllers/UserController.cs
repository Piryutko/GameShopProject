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
        public Guid Create(string firstName, string lastName, string nickName, PaymentOption paymentOption)
        {
        }

        [Route("{userId}/name")]
        [HttpPut]
        public void ChangeName(string newName)
        {
        }

        [Route("{userId}")]
        [HttpDelete]
        public void Delete(Guid userId)
        { 
        }

        [Route("{userId}/payment")]
        [HttpPut]
        public void ChangePaymentOption(string newPaymentOption)
        {
        }
    }
}
