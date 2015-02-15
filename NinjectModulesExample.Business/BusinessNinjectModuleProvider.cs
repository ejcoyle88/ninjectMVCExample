using Ninject.Modules;
using NinjectModulesExample.Data.InMemory;
using NinjectModulesExample.Utility;
using System.Collections.Generic;
using System.Linq;

namespace NinjectModulesExample.Business
{
    public class BusinessNinjectModuleProvider : INinjectModuleProvider
    {
        public IEnumerable<INinjectModule> Get()
        {
            var dataModules = GetDataNinjectModules();
            var businessModules = GetBusinessNinjectModules();
            return businessModules.Union(dataModules);
        }

        internal IEnumerable<INinjectModule> GetBusinessNinjectModules()
        {
            return new List<NinjectModule>
            {
                new BusinessNinjectModule()
            };
        }

        internal IEnumerable<INinjectModule> GetDataNinjectModules()
        {
            return (new DataNinjectModuleProvider()).Get();
        }
    }
}
