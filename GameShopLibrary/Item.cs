using System;

namespace GameShopLibrary
{
    class Item
    {
        public Item(int cost, Guid id,Game game)
        {
            Cost = cost;
            ItemId = id;
            Game = game;
        }

        public Game Game;
        public int Cost { get; set; } 
        public Guid ItemId { get; }
    }
   
}
