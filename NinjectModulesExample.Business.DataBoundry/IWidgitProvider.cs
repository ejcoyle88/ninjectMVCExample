using NinjectModulesExample.Business.Boundry.Data.Requests;
using NinjectModulesExample.Business.Boundry.Data.Responses;

namespace NinjectModulesExample.Business.Boundry.Data
{
    public interface IWidgitProvider
    {
        IdWidgitResponse GetFor(IdWidgitRequest request);
    }
}
