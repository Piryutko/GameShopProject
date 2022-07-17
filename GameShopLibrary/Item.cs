using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShopLibrary
{
    class Item
    {
        public Item(string name,int coast)
        {
            Name = name;
            Cost = coast;
        }
        public string Name { get;}
        public int Cost { get;}
        public virtual string BuyersUser(string name)
        {
            return name;
        }

    }
    class ItemSubscription : Item
    {
        public ItemSubscription(string name, int coast):base (name,coast)
        {

        }
        public override string BuyersUser(string nameSubscription)
        {
            return nameSubscription;
        }
        public bool RenewSubscription(bool registrationSubscriptionRenewal)
        {
            return registrationSubscriptionRenewal;
        }
    }
    class ItemOnline : Item
    {
        public ItemOnline(string name, int coast) : base (name, coast)
        {

        }
        public override string BuyersUser(string nameItemOnline)
        {
            return nameItemOnline;
        }
        public bool SaleOnlineProductSubscription (bool subscriptionRegistration)
        {
            return subscriptionRegistration;
        }

        public bool RenewSubscription(bool registration)
        {
            return registration;
        }

    }




}
