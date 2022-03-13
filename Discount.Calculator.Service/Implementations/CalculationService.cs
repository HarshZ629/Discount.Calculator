using Discount.Calculator.Models;
using Discount.Calculator.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discount.Calculator.Service.Implementations
{
    public class CalculationService : ICalculationService
    {
        public double CalculatePrice(CalculationInputModel calculationInputModel)
        {
            var totalPrice = (calculationInputModel.Price * calculationInputModel.Quantity) - 
                ((calculationInputModel.DiscountPercentage * calculationInputModel.Price * calculationInputModel.Quantity) / 100);
            return totalPrice;
        }
    }
}
