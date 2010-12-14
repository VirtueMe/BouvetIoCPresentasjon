namespace Setter.Injection.Sample
{
    using System;
    using System.Linq;

    using Samples.Implementation;

    public class CustomerController
    {
        public CustomerService CustomerService { get; set; }

        public void Index()
        {
            var list = CustomerService.List();

            list.ToList().ForEach(Console.WriteLine);
        }
    }
}