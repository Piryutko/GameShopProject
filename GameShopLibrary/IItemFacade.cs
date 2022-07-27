using System;

namespace GameShopLibrary
{
    interface IItemFacade
    {
        public void Buy(Guid userId,Guid itemId);

        public void Delete(Guid userId, Guid itemId);

        public void ChangePrices(Guid itemId);

    }
}
