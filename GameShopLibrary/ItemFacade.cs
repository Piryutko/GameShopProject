using System;

namespace GameShopLibrary
{
    interface IItemFacade
    {
        public void SetPrice(double cost);

        public void SetId(Guid id);

        public void SetGame(Game game);

    }
}
