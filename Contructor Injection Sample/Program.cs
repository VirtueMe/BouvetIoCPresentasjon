namespace Contructor.Injection.Sample
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var container = BootStrap.Components();

            var controller = container.Resolve<CustomerController>();

            controller.Index();

            Console.ReadLine();
        }
    }

}
