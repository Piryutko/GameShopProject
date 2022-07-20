using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace GameShopWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [Route("GameShop/user/allgame")]
        [HttpGet]
        public void AllGame()
        { 
        }

        [Route("GameShop/user/buygames")]
        [HttpGet]
        public void Buy()
        { 
        }

        [Route("GameShop/user/")]
        [HttpPost]
        public void ChangeName(string newName)
        { 
        }

    }
}
