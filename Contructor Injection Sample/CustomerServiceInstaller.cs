namespace Contructor.Injection.Sample
{
    using Castle.MicroKernel.Registration;
    using Castle.MicroKernel.SubSystems.Configuration;
    using Castle.Windsor;

    using Samples.Implementation;
    using Samples.Interfaces;

    public class CustomerServiceInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<ICustomerService>().ImplementedBy<CustomerService>().LifeStyle.Singleton);
            container.Register(Component.For<CustomerController>().LifeStyle.Transient);
        }
    }
}