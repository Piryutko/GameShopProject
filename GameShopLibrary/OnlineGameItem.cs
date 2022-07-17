using System;

namespace GameShopLibrary
{
    class OnlineGameItem : Item
    {
        public OnlineGameItem(string name, int coast, Guid itemId, int numberOfMonths) : base(name, coast, itemId)
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
