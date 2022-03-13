using Discount.Calculator.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discount.Calculator.Service.Implementations
{
    public class OutputService : IOutputService
    {
        public void ShowCalculationResult(double price)
        {
            Console.WriteLine("Price Of Gold is :"+ price);
        }

        public void ShowInValidLoginResult()
        {
            Console.WriteLine("Please check user id or password");
        }
    }
}
