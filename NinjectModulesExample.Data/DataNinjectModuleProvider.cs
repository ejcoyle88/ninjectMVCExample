using Ninject.Modules;
using NinjectModulesExample.Utility;
using System.Collections.Generic;

namespace NinjectModulesExample.Data.InMemory
{
    public class DataNinjectModuleProvider : INinjectModuleProvider
    {
        public IEnumerable<INinjectModule> Get()
        {
            return new List<NinjectModule> 
            { 
                new DataNinjectModule()
            };
        }
    }
}
