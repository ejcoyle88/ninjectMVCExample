using Ninject.Modules;

namespace NinjectModulesExample.Business
{
    internal class BusinessNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Kernel.Bind<WidgitDiscombobulationManager>().ToSelf();
        }
    }
}
