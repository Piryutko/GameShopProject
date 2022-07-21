using Microsoft.AspNetCore.Mvc;
using System;

namespace GameShopWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [Route("all")]
        [HttpGet]
        public void AllItem()
        { 
        }

        [Route("buy")]
        [HttpPost]
        public void BuyItem()
        { 
        }

        [Route("changename/{name}")]
        [HttpPut]
        public void ChangeName()
        { 
        }

        [Route("create")]
        [HttpPost]
        public void СreateUser()
        { 
        }

        [Route("delete/{id}")]
        [HttpDelete]
        public void DeleteUser()
        {
        }
    }
}
