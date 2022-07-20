using System;

namespace GameShopLibrary
{
    class PayOnlineGameItem : Item
    {
        public PayOnlineGameItem(int cost, Guid id, Game game) : base(cost, id, game)
        {
            ExpirationDate = DateTime.Now;
        }

        public DateTime ExpirationDate { get; private set; }

        private const int SUBSCRIPTIONDAYS = 30;

        public DateTime BuySubscription()
        {
            if (IsActive())
            {
                return ExpirationDate;
            }
            else
            {
                return ExpirationDate.AddDays(SUBSCRIPTIONDAYS);
            }
        }
        public bool IsActive()
        {
            if (ExpirationDate.Date.Day + SUBSCRIPTIONDAYS > DateTime.Now.Day)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
