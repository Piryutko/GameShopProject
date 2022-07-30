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
        public Guid CreateItem(string name,double coast, GameGenre genre, GameCategory category, GamePlatforma platform)
        {
        }

        [Route("{itemId}")]
        [HttpDelete]
        public void ItemDelete()
        {
        }

        [Route("{itemId}")]
        [HttpPut]
        public void ChangePrice(double newCost)
        {
        }

        [Route("{userId}")]
        [HttpGet]
        public List<Item> AllUserItems()
        { 
        }

        [Route("{userId}/{itemId}")]
        [HttpPost]
        public void BuyItem()
        { 
        }
    }
}
