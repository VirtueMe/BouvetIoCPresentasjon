namespace Interface.Injection.Sample
{
    using Ninject.Modules;

    using Samples.Implementation;
    using Samples.Interfaces;

    public class CustomerModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ICustomerService>().To<CustomerService>();
            Bind<CustomerController>().ToSelf();
        }
    }
}