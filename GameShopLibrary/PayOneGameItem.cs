using System;

namespace GameShopLibrary
{
    class PayOneGameItem : Item
    {
        public PayOneGameItem(double cost, Guid id, Game game) : base (cost, id, game)
        {

        }
    }
}
