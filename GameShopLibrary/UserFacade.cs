using System;
using System.Collections.Generic;

namespace GameShopLibrary
{
    class UserFacade : IUserFacade
    {
        private List<User> _userRepository;

        public void ChangeNickName(Guid userId, string newNickName)
        {
            
        }

        public void ChangePayment(Guid userId, PaymentOption newPaymentOption)
        {
            
        }

        public Guid CreateUser(string firstName, string lastName, string nickName, PaymentOption paymentOption)
        {
            
        }

        public void DeleteUser(Guid userId)
        {
            
        }
    }
}
