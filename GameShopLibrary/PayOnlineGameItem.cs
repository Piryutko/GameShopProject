using System;

namespace GameShopLibrary
{
    class PayOnlineGameItem : Item
    {
        public PayOnlineGameItem(double cost, Guid id, Game game) : base(cost, id, game)
        {
            ExpirationDate = DateTime.Now;
        }

        public DateTime ExpirationDate { get; private set; }

        private const int SUBSCRIPTIONMONTH = 1;

        public DateTime BuySubscription()
        {
            if (IsActive())
            {
                return ExpirationDate;
            }
            else
            {
                return ExpirationDate.AddMonths(SUBSCRIPTIONMONTH);
            }
        }
        
        public bool IsActive()
        {
            return ExpirationDate.Date.Month > DateTime.Now.Month;
        }
    }
}
