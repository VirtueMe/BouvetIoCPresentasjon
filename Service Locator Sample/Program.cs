namespace Service.Locator.Sample
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Bootstrap.Components();

            var controller = new CustomerController();

            controller.Index();

            Console.ReadLine();
        }
    }
}
