using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        public void BuyGame()
        { 
        }
        [Route("GameShop/user/buygames")]
        [HttpPost]
        public void ChangeName(string newName)
        { 
        }








    }
}
