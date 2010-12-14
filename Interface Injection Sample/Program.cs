namespace Interface.Injection.Sample
{
    using System;

    using Ninject;

    class Program
    {
        static void Main(string[] args)
        {
            var container = Bootstrap.Components();

            var controller = container.Get<CustomerController>();

            controller.Index();

            Console.ReadLine();
        }
    }
}
