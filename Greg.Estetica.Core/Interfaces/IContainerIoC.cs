using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Greg.Estetica.Core.Interfaces
{
    public interface IContainerIoC
    {
        T ResolveType<T>();
    }
}
