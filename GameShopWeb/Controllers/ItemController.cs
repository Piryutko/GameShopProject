using GameShopLibrary;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace GameShopWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        [HttpPost]
        public void CreatorItem(double coast,Guid id,Game Game)
        {
        }

        [HttpDelete]
        public void ItemDelete(Guid id)
        {
        }

        [HttpPut]
        public void ItemChange(Guid id)
        {
        }

        [HttpGet]
        public List<Item> GetItemUser(Guid userId)
        { }

        [HttpPost]
        public void BuyItem(Guid user,Guid idItem)
        { }
    }
}
