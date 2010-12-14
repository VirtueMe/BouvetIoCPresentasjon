namespace Contextual.Lookup.Sample
{
    using System;
    using System.Linq;

    using Samples.Interfaces;

    public class CustomerController : ICustomerController
    {
        public ICustomerService CustomerService { get; set; }
        
        public void Index()
        {
            var list = CustomerService.List();

            list.ToList().ForEach(Console.WriteLine);
        }
    }
}