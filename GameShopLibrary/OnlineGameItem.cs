using System;

namespace GameShopLibrary
{
    class PayOnlineGameItem : Item
    {
        public PayOnlineGameItem(string name, int coast, Guid itemId, int numberOfMonths) : base(name, coast, itemId)
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
