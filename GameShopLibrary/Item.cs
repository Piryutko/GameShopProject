using EnsureThat;
using System;

namespace GameShopLibrary
{
    public class Item
    {
        public Item(double cost, Guid Itemid, Game game)
        {
            Ensure.That(cost).IsGt(0.00);
            Ensure.That(Itemid).IsNotEmpty();

            Cost = cost;
            Id = Itemid;
            Game = game;
        }

        public Game Game { get; }
        public double Cost { get; } 
        public Guid Id { get; }
    }
   
}
