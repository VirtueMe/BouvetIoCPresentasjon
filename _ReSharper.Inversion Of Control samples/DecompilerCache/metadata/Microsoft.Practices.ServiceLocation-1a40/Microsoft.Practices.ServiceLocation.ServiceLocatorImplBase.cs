// Type: Microsoft.Practices.ServiceLocation.ServiceLocatorImplBase
// Assembly: Microsoft.Practices.ServiceLocation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// Assembly location: c:\Projects\Inversion Of Control samples\packages\CommonServiceLocator.1.0\lib\NET35\Microsoft.Practices.ServiceLocation.dll

using System;
using System.Collections.Generic;

namespace Microsoft.Practices.ServiceLocation
{
    public abstract class ServiceLocatorImplBase : IServiceLocator, IServiceProvider
    {
        #region Implemented Interfaces

        #region IServiceLocator

        public virtual IEnumerable<object> GetAllInstances(Type serviceType);

        public virtual IEnumerable<TService> GetAllInstances<TService>();

        public virtual object GetInstance(Type serviceType);

        public virtual object GetInstance(Type serviceType, string key);

        public virtual TService GetInstance<TService>();

        public virtual TService GetInstance<TService>(string key);

        #endregion

        #region IServiceProvider

        public virtual object GetService(Type serviceType);

        #endregion

        #endregion

        #region Methods

        protected abstract IEnumerable<object> DoGetAllInstances(Type serviceType);

        protected abstract object DoGetInstance(Type serviceType, string key);

        protected virtual string FormatActivateAllExceptionMessage(Exception actualException, Type serviceType);

        protected virtual string FormatActivationExceptionMessage(
            Exception actualException, Type serviceType, string key);

        #endregion
    }
}
