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
    class PayOneGameItem : Item
    {

        
    }
    class OnlineGameItem : Item
    {
        public OnlineGameItem(string name, int coast, Guid itemId,int numberOfMonths) : base(name, coast, itemId)
        {
            Subscription = numberOfMonths;
        }
        public int Subscription { get; set; }

        public void SubscriptionRenewal(int addingSubscriptionMonths)
        {
            Subscription = addingSubscriptionMonths;
        }
    }




}
