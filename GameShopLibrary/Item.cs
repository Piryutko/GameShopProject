using System;

namespace GameShopLibrary
{
    class Item
    {
        public Item(int cost, Guid id, Game game)
        {
            Cost = cost;
            Id = id;
            Game = game;
        }

        public Game Game { get; }
        public int Cost { get; } 
        public Guid Id { get; }
    }
   
}
