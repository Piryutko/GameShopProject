using System;

namespace GameShopLibrary
{
    interface IUserFacade
    {
        public Guid CreateUser(string firstName, string lastName, string nickName, PaymentOption paymentOption);

        public void ChangeNickName(Guid userId, string newNickName);

        public void ChangePayment(Guid userId, PaymentOption newPaymentOption);

        public void DeleteUser(Guid userId);
    }
}
