namespace Samples.Implementation
{
    using System.Collections.Generic;

    using Samples.Interfaces;

    public class CustomerService : ICustomerService
    {
        public IEnumerable<ICustomer> List()
        {
            yield return new Customer { Number = "10000", Name = "Hans Andersen" };
            yield return new Customer { Number = "10001", Name = "Bjørn Olsen" };
            yield return new Customer { Number = "10002", Name = "Ola Jensen" };
        }
    }
}