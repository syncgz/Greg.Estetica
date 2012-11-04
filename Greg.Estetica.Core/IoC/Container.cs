using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Greg.Estetica.Core.Interfaces;
using Greg.Estetica.Core.Model;
using Moq;
using Ninject;

namespace Greg.Estetica.Core.IoC
{
    public class Container
    {
        private static IKernel _kernel;

        public static object ResolveType(Type type)
        {
            if(_kernel == null)
            {
                ContainerInitialization();
            }

            return _kernel.Get(type);
        }

        public static T ResolveType<T>()
        {
            if (_kernel == null)
            {
                ContainerInitialization();
            }

            return _kernel.Get<T>();
        }

        private static void ContainerInitialization()
        {
            _kernel = new StandardKernel();

            CompositionRoot();
        }

        public static void RegisterType<T>(T obj)
        {
            if(_kernel == null)
            {
                ContainerInitialization();
            }

            _kernel.Bind<T>().ToConstant(obj);
        }




        private static void CompositionRoot()
        {
            
        }
    }
}
