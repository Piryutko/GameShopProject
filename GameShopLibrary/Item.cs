using EnsureThat;
using System;

namespace GameShopLibrary
{
    class Item
    {
        public Item(double cost, Guid id, Game game)
        {
            Cost = cost;
            Id = id;
            Game = game;
        }

        public Game Game { get; }
        public double Cost { get; } 
        public Guid Id { get; }
    }
   
}
