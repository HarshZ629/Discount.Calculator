using Discount.Calculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discount.Calculation.Helpers
{
    public static class Cache
    {
        private static UserModel _user;
        private static bool _isLoggedIn = false;

        /// <summary>
        /// Initialize the data for logged in User
        /// </summary>
        /// <param name="userModel"></param>
        public static void SetLoggedInUserDetails(UserModel userModel) 
        {
            _user = userModel;
            _isLoggedIn = true;
        }

        /// <summary>
        /// Deletes the User Data from the cache when User logs out.
        /// </summary>
        public static void ClearLoggedInUserDetails() 
        {
            _user = null;
        }

        /// <summary>
        /// Checks if the user is logged in.
        /// </summary>
        /// <returns></returns>
        public static bool IsUserLoggedIn() 
        {
            return _isLoggedIn;
        }
    }
}
