using Discount.Calculator.Data.Interfaces;
using Discount.Calculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discount.Calculator.Data.Implementations
{
    public class UserRepository : IUserRepository
    {
        static List<UserModel> RegisteredUser;

        public UserRepository()
        {
            RegisteredUser = new List<UserModel>();
            LoadData();
        }
        
        public bool IsUserValid(UserModel userDetail)
        {
            if (RegisteredUser.Any(user => user.UserId.Equals(userDetail.UserId) && user.Password.Equals(userDetail.Password)))
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        private void LoadData()
        {
            RegisteredUser.Add(new UserModel() 
            {
                UserId = "Harsh",
                Password = "7777"
            });

            RegisteredUser.Add(new UserModel()
            {
                UserId = "George",
                Password = "5443"
            });

            RegisteredUser.Add(new UserModel()
            {
                UserId = "John",
                Password = "7676"
            });

            RegisteredUser.Add(new UserModel()
            {
                UserId = "Abhisek",
                Password = "6777"
            });

            RegisteredUser.Add(new UserModel()
            {
                UserId = "Sushrut",
                Password = "8999"
            });
        }
    }
}
