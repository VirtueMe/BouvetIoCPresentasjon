// Type: StructureMap.ServiceLocatorAdapter.StructureMapServiceLocator
// Assembly: StructureMapAdapter, Version=1.1.0.0, Culture=neutral
// Assembly location: c:\Projects\Inversion Of Control samples\packages\CommonServiceLocator.StructureMapAdapter.1.1\lib\StructureMapAdapter.dll

using Microsoft.Practices.ServiceLocation;

using StructureMap;

using System;
using System.Collections.Generic;

namespace StructureMap.ServiceLocatorAdapter
{
    public class StructureMapServiceLocator : ServiceLocatorImplBase
    {
        #region Constants and Fields

        private IContainer container;

        #endregion

        #region Constructors and Destructors

        public StructureMapServiceLocator(IContainer container);

        #endregion

        #region Methods

        protected override IEnumerable<object> DoGetAllInstances(Type serviceType);

        protected override object DoGetInstance(Type serviceType, string key);

        #endregion
    }
}
