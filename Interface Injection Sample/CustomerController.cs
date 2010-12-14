namespace Interface.Injection.Sample
{
    using System;
    using System.Linq;

    using Ninject;

    using Samples.Interfaces;

    public class CustomerController
    {
        [Inject]
        public ICustomerService CustomerService { get; set; }

        public void Index()
        {
            var list = CustomerService.List();

            list.ToList().ForEach(Console.WriteLine);
        }
    }
}