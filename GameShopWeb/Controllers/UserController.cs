using Microsoft.AspNetCore.Mvc;

namespace GameShopWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [Route("GameShop/user/allitem")]
        [HttpGet]
        public void AllItem()
        { 
        }

        [Route("GameShop/user/buyitem")]
        [HttpPost]
        public void BuyItem()
        { 
        }

        [Route("GameShop/user/changename")]
        [HttpPut]
        public void ChangeName(string name)
        { 
        }

        [Route("GameShop/user/createuser")]
        [HttpPut]
        public void СreateUser()
        { 
        }

        [Route("GameShop/user/deleteuser")]
        [HttpDelete]
        public void DeleteUser()
        {
        }
    }
}
