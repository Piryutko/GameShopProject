using System;

namespace GameShopLibrary
{
    class PayOnlineGameItem : Item
    {
        public PayOnlineGameItem(int cost, Guid itemId, int numberOfMonths,Game game) : base(cost, itemId,game)
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
