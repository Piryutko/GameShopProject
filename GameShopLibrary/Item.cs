using EnsureThat;
using System;

namespace GameShopLibrary
{
    public class Item
    {
        public Item(double cost, Guid itemid, Game game)
        {
            Ensure.That(cost).IsGt(0.00);
            Ensure.That(itemid).IsNotEmpty();

            Cost = cost;
            Id = itemid;
            Game = game;
        }

        public Game Game { get; }
        public double Cost { get; } 
        public Guid Id { get; }
    }
   
}
