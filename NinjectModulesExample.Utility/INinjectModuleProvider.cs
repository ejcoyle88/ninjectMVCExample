using Ninject.Modules;
using System.Collections.Generic;

namespace NinjectModulesExample.Utility
{
    public interface INinjectModuleProvider
    {
        IEnumerable<INinjectModule> Get();
    }
}
