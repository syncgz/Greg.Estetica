using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.Web.Routing;
using Greg.Estetica.Core.Interfaces;
using Greg.Estetica.Core.IoC;
using Greg.Estetica.Core.Model;
using Moq;
using Ninject;

namespace Greg.Estetica.Core.Factories
{
    public class CustomControllerFactory : DefaultControllerFactory
    {
        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)Container.ResolveType(controllerType);
        }
    }
}
