using NinjectModulesExample.Business.Boundry.Data;
using NinjectModulesExample.Business.Boundry.Data.Requests;

namespace NinjectModulesExample.Business
{
    public class WidgitDiscombobulationManager
    {
        private readonly IWidgitProvider _widgitProvider;

        public WidgitDiscombobulationManager(IWidgitProvider widgitProvider)
        {
            _widgitProvider = widgitProvider;
        }

        public string DoStuff()
        {
            var things = _widgitProvider.GetFor(new IdWidgitRequest(1));
            return things.Description;
        }
    }
}