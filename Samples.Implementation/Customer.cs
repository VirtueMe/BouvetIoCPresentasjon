namespace Samples.Implementation
{
    using Samples.Interfaces;

    public class Customer : ICustomer
    {
        public string Number { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return Number + " " + Name;
        }
    }
}