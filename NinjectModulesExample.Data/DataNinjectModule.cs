using Ninject.Modules;
using NinjectModulesExample.Business.Boundry.Data;
using NinjectModulesExample.Data.InMemory.Mappers.Widgits;
using NinjectModulesExample.Data.InMemory.Repositories;

namespace NinjectModulesExample.Data.InMemory
{
    internal class DataNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Kernel.Bind<IdWidgitResponseMapper>().ToSelf();
            Kernel.Bind<IWidgitProvider>().To<WidgitProvider>();
        }
    }
}
