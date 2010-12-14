namespace Interface.Injection.Sample
{
    using Ninject;

    public static class Bootstrap
    {
        public static IKernel Components()
        {
            return new StandardKernel(new CustomerModule());
        }
    }
}