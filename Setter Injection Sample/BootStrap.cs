namespace Setter.Injection.Sample
{
    using Microsoft.Practices.Unity;

    using Samples.Implementation;
    using Samples.Interfaces;

    public static class BootStrap
    {
        public static IUnityContainer Components()
        {
            var container = new UnityContainer();

            container.RegisterType<CustomerController>(new InjectionProperty("CustomerService"));

            return container;
        }
    }
}