using System;

namespace GameShopLibrary
{
    class PayOneGameItem : Item
    {
        public PayOneGameItem(int cost, Guid id, Game game) : base (cost, id, game)
        {

        }
    }
}
