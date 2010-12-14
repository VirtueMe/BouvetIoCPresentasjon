namespace Factory.Pattern.Sample
{
    using System;

    using Autofac;

    class Program
    {
        static void Main(string[] args)
        {
            var container = Bootstrap.Components();

            var controller = container.Resolve<CustomerController>();

            controller.Index();

            Console.ReadLine();
        }
    }
}
