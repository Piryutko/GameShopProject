using System;

namespace GameShopLibrary
{
    class PayOnlineGameItem : Item
    {
        public PayOnlineGameItem(int cost, Guid itemId, DateTime numberOfMonths, Game game) : base(cost, itemId, game)
        {
            Subscription = numberOfMonths;
        }
        public DateTime Subscription { get; set; }

        public void BuySubscription(int numberMonths)
        {
            Subscription = Subscription.AddMonths(numberMonths);
        }
        public void FindSubscriptionStatus()
        {
            if (Subscription == DateTime.MinValue)
            {

            }
            else
            {
                
            }
        }
    }
}
