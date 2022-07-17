using System;

namespace GameShopLibrary
{
    class Item
    {
        public Item(string name,int coast,Guid itemId)
        {
            Name = name;
            Cost = coast;
            ItemId = itemId;
        }
        public string Name { get; }
        public int Cost { get; }
        public Guid ItemId { get; }
    }
    
    




}
