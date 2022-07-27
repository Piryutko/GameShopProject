using System;
using System.Collections.Generic;

namespace GameShopLibrary
{
    interface IUserFacade
    {
        public void BuyItem(Guid itemId,Guid userId);

        public void ChangeNickName(string newNickName);

        public void SelectPaymentOption(PaymentOption paymentOption);

        public List<Item> ShowAllItem();

        public void ChangePayment(PaymentOption paymentOption);

        public void DelelteItem(Guid itemid, Guid userId);

    }
}
