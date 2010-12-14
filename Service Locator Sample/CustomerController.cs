namespace Service.Locator.Sample
{
    using System;
    using System.Linq;

    using Microsoft.Practices.ServiceLocation;

    using Samples.Interfaces;

    public class CustomerController
    {
        public void Index()
        {
            var service = ServiceLocator.Current.GetInstance<ICustomerService>();

            var list = service.List();

            list.ToList().ForEach(Console.WriteLine);
        }
    }
}