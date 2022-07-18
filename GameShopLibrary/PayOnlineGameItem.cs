using System;

namespace GameShopLibrary
{
    class PayOnlineGameItem : Item
    {
        public PayOnlineGameItem(int coast, Guid itemId, int numberOfMonths) : base(coast, itemId)
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
