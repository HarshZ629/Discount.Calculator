using Autofac;
using Discount.Calculator.Data.Implementations;
using Discount.Calculator.Data.Interfaces;
using Discount.Calculator.Service.Implementations;
using Discount.Calculator.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discount.Calculation.Helpers
{
    public static class Factory
    {
        private static IContainer _container;

        //Retruns the factory object to to used for object creation
        public static IContainer GetFactory() 
        {
            var builder = new ContainerBuilder();

            //register the depemdencies in this section
            builder.RegisterType<LoginService>().As<ILoginService>();
            builder.RegisterType<CalculationService>().As<ICalculationService>();
            builder.RegisterType<InputService>().As<IInputService>();
            builder.RegisterType<OutputService>().As<IOutputService>();
            builder.RegisterType<UserRepository>().As<IUserRepository>();

            _container = builder.Build();
            
            return _container;
        }
    }
}
