using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discount.Calculator.Service.Interfaces
{
    public interface IOutputService
    {
        void ShowInValidLoginResult();
        void ShowCalculationResult(double price);
    }
}
