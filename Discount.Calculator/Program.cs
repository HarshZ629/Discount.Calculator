using Discount.Calculation.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Discount.Calculator.Service.Interfaces;

namespace Discount.Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = Factory.GetFactory();

            using (var scope = container.BeginLifetimeScope()) 
            {
                var outputService = scope.Resolve<IOutputService>();
                var inputService = scope.Resolve<IInputService>();

                
                var userDetails = inputService.GetLoginDetails();

                var loginService = scope.Resolve<ILoginService>();
                if (loginService.ValidateUser(userDetails))
                {
                    Cache.SetLoggedInUserDetails(userDetails);
                    var calculationModel = inputService.GetCalculationDetails();

                    var calculationService = scope.Resolve<ICalculationService>();
                    outputService.ShowCalculationResult(calculationService.CalculatePrice(calculationModel));
                }
                else 
                {
                    outputService.ShowInValidLoginResult();
                }
            }

            Console.ReadKey();

        }
    }
}
