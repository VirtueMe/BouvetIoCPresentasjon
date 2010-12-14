namespace Contructor.Injection.Sample
{
    using System;

    using Castle.Windsor;
    using Castle.Windsor.Installer;

    public static class BootStrap
    {
        public static IWindsorContainer Components()
        {
            var container = new WindsorContainer();
            
            container.Install(FromAssembly.This());

            return container;
        }
    }
}