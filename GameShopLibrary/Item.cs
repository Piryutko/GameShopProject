using System;

namespace GameShopLibrary
{
    class Item
    {
        public Item(int coast, Guid itemId)
        {
            Cost = coast;
            ItemId = itemId;
        }
        public string Name { get; }
        public int Cost { get; }
        public Guid ItemId { get; }
    }
   
}
