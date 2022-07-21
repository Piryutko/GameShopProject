using Microsoft.AspNetCore.Mvc;

namespace GameShopWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        [Route("GameShop/item/itemadd")]
        [HttpPut]
        public void ItemAdd()
        {
        }

        [Route("GameShop/item/itemdelete")]
        [HttpPut]
        public void ItemDelete()
        {
        }

        [Route("GameShop/item/itemchange")]
        [HttpPost]
        public void ItemChange()
        {
        }
    }
}
