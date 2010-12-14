namespace Factory.Pattern.Sample
{
    using Autofac;

    using Samples.Implementation;
    using Samples.Interfaces;

    public static class Bootstrap
    {
        public static IContainer Components()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<CustomerService>().As<ICustomerService>();
            builder.RegisterType<CustomerController>();

            return builder.Build();
        }
    }
}