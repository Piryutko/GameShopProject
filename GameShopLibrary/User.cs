using System;

namespace GameShopLibrary
{
    class User
    {
        public User(string firstName,string lastName,string nickName,Guid id,PaymentOption paymentOption)
        {
            FirstName = firstName;
            LastName = lastName;
            NickName = nickName;
            Id = id;
            PaymentOption = paymentOption;
        }
        public string FirstName { get;}

        public string LastName { get;}

        public string NickName { get; set; }

        public Guid Id { get; }

        public PaymentOption PaymentOption;

        public void ChangeNickName(string newNickName)
        {
            NickName = newNickName;
        }
        public void PurchasesMade()
        {
            
        }
        public void ChangePayment(PaymentOption newPaymentMethod)
        {
            PaymentOption = newPaymentMethod;
        }
    }
}
