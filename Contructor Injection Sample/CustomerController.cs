namespace Contructor.Injection.Sample
{
    using System;
    using System.Linq;

    using Samples.Interfaces;

    public class CustomerController
    {
        private readonly ICustomerService customerService;

        public CustomerController(ICustomerService customerService)
        {
            this.customerService = customerService;
        }

        public void Index()
        {
            var list = customerService.List();

            list.ToList().ForEach(Console.WriteLine);
        }
    }
}