using System;
using System.Collections.Generic;

namespace GameShopLibrary
{
    interface IItemFacade
    {
        public Guid CreateItem(string name, double coast, GameGenre genre, GameCategory category, GamePlatforma platform);

        public void DeleteItem(Guid itemId);

        public void ChangePrice(Guid itemId);

        public void BuyItem(Guid userId, Guid itemId);

        public List<Item> ShowAllItems(Guid userId);
    }
}
