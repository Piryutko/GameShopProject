using Microsoft.AspNetCore.Mvc;

namespace GameShopWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        [Route("add")]
        [HttpPost]
        public void ItemAdd()
        {
        }

        [Route("delete")]
        [HttpDelete]
        public void ItemDelete()
        {
        }

        [Route("change")]
        [HttpPost]
        public void ItemChange()
        {
        }
    }
}
