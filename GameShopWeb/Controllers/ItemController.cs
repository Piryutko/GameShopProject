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
        public void CreateItem()
        {
        }

        [Route("{id}")]
        [HttpDelete]
        public void ItemDelete(Guid id)
        {
        }

        [Route("{id}")]
        [HttpPut]
        public void ItemChange(Guid id)
        {
        }

        [Route("{userId}")]
        [HttpGet]
        public List<Item> AllUserItems(Guid userId)
        { 
        }

        [Route("{user}/{itemId}")]
        [HttpPost]
        public void BuyItem(Guid user, Guid itemId)
        { 
        }
    }
}
