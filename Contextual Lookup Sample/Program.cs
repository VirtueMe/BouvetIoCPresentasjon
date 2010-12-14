namespace Contextual.Lookup.Sample
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var container = Bootstrap.Components();

            var controller = container.GetInstance<ICustomerController>("Test");

            controller.Index();

            Console.ReadLine();
        }
    }
}
