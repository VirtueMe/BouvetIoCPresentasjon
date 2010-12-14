namespace Contextual.Lookup.Sample
{
    using System.Collections.Generic;

    using Samples.Implementation;
    using Samples.Interfaces;

    public class TestCustomerService : ICustomerService
    {
        public IEnumerable<ICustomer> List()
        {
            for (int i = 1; i < 11; i++)
            {
                yield return new Customer { Number = i.ToString(), Name = "Test " + i.ToString() };    
            }
            
        }
    }
}