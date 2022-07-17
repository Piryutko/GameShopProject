using System;

namespace GameShopLibrary
{
    class User
    {
        public User(string firstname,string lastname,string nickname,Guid id,string paymentoption)
        {
            FirstName = firstname;
            LastName = lastname;
            NickName = nickname;
            Id = id;
            PaymentOption = paymentoption;
        }
        public string FirstName { get;}

        public string LastName { get;}

        public string NickName { get; set; }

        public Guid Id { get; }

        public string PaymentOption { get; set; }

        public string ChangeNickName(ref User nickName)
        {
            return nickName.NickName;
        }
        public string PurchasesMade(string shoppingCart)
        {
            return shoppingCart;
        }
        public string ChangePayment(ref User paymentOption)
        {
            return paymentOption.PaymentOption;
        }
    }
}
