namespace Contextual.Lookup.Sample
{
    using Samples.Implementation;
    using Samples.Interfaces;

    using StructureMap.Configuration.DSL;

    public class CustomerRegistry : Registry
    {
        public CustomerRegistry()
        {
            
            For<ICustomerService>().Add<CustomerService>().Named("DefaultService");

            For<ICustomerService>().Add<TestCustomerService>().Named("TestService");

            For<ICustomerController>().Add<CustomerController>().Named("Default").OnCreation(
                (c, s) => s.CustomerService = c.GetInstance<ICustomerService>(c.RequestedName + "Service"));

            For<ICustomerController>().Add<CustomerController>().Named("Test").OnCreation(
                (c, s) => s.CustomerService = c.GetInstance<ICustomerService>(c.RequestedName + "Service"));
        }
    }
}