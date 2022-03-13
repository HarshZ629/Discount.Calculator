using Discount.Calculator.Data.Interfaces;
using Discount.Calculator.Models;
using Discount.Calculator.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discount.Calculator.Service.Implementations
{
    public class LoginService : ILoginService
    {
        IUserRepository _userRepository;
        public LoginService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        /// <summary>
        /// Validates the user details
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool ValidateUser(UserModel user)
        {
            return _userRepository.IsUserValid(user);
        }
    }
}
