using EnsureThat;
using System;

namespace GameShopLibrary
{
    public class Item
    {
        public Item(double cost, Guid id, Game game)
        {
            Ensure.That(cost).IsGt(0.00);

            Ensure.That(id).IsNotEmpty();

            Cost = cost;
            Id = id;
            Game = game;
        }

        public Game Game { get; }
        public double Cost { get; } 
        public Guid Id { get; }
    }
   
}
