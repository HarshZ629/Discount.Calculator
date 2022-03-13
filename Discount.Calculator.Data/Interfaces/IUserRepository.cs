using Discount.Calculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discount.Calculator.Data.Interfaces
{
    public interface IUserRepository
    {
        bool IsUserValid(UserModel userDetail);
    }
}
