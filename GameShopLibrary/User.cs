using EnsureThat;
using System;
using System.Collections.Generic;

namespace GameShopLibrary
{
    class User
    {
        public User(string firstName, string lastName, string nickName, Guid id, PaymentOption paymentOption)
        {
            Ensure.That(firstName).IsNotNullOrWhiteSpace();
            Ensure.That(lastName).IsNotNullOrWhiteSpace();
            Ensure.That(nickName).IsNotNullOrWhiteSpace();
            FirstName = firstName;
            LastName = lastName;
            NickName = nickName;
            Id = id;
            PaymentOption = paymentOption;
        }
        public string FirstName { get; }

        public string LastName { get; }

        public string NickName { get; private set; }

        public Guid Id { get; }

        public PaymentOption PaymentOption { get; private set; }

        public void ChangeNickName(string newNickName)
        {
            NickName = newNickName;
        }
        public List<Item> AllItems()
        {
            var GameListShopping = new List<Item>(){ };
            foreach (var item in GameListShopping)
            {

            }
            return GameListShopping;
        }
        public void ChangePayment(PaymentOption newPaymentMethod)
        {
            PaymentOption = newPaymentMethod;
        }
    }
}
