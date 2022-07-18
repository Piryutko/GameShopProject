using System;

namespace GameShopLibrary
{
    class Item
    {
        public Item(int coast, Guid id)
        {
            Coast = coast;
            ItemId = id;
        }

        public Game Game;
        public int Coast { get; set; } 
        public Guid ItemId { get; }

    }
   
}
