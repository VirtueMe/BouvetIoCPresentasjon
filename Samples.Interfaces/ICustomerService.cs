namespace Samples.Interfaces
{
    using System.Collections.Generic;

    public interface ICustomerService
    {
        IEnumerable<ICustomer> List();
    }
}