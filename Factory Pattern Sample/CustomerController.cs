namespace Factory.Pattern.Sample
{
    using System;
    using System.Linq;

    using Samples.Interfaces;

    public class CustomerController
    {
        private readonly Func<ICustomerService> customerServiceFactory;

        public CustomerController(Func<ICustomerService> customerServiceFactory)
        {
            this.customerServiceFactory = customerServiceFactory;
        }

        public void Index()
        {
            var customerService = customerServiceFactory();

            var list = customerService.List();

            list.ToList().ForEach(Console.WriteLine);
        }
    }
}