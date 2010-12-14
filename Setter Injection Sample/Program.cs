namespace Setter.Injection.Sample
{
    using System;

    using Microsoft.Practices.Unity;

    class Program
    {
        static void Main(string[] args)
        {
            var container = BootStrap.Components();

            var controller = new CustomerController();

            container.BuildUp(controller);

            controller.Index();

            Console.ReadLine();
        }
    }
}
