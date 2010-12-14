namespace Contextual.Lookup.Sample
{
    using StructureMap;

    public static class Bootstrap
    {
        public static IContainer Components()
        {
            return new Container(new CustomerRegistry());
        }
    }
}