namespace Service.Locator.Sample
{
    using Microsoft.Practices.ServiceLocation;

    using Samples.Implementation;
    using Samples.Interfaces;

    using StructureMap;
    using StructureMap.Configuration.DSL;
    using StructureMap.ServiceLocatorAdapter;

    public static class Bootstrap
    {
        public static void Components()
        {
            var registry = new Registry();
            registry.For<ICustomerService>().Use<CustomerService>();
            var container = new Container(registry);

            
            ServiceLocator.SetLocatorProvider(() => new StructureMapServiceLocator(container));
        }
    }
}