using NinjectModulesExample.Business.Boundry.Data.Responses;
using NinjectModulesExample.Data.InMemory.Entities;

namespace NinjectModulesExample.Data.InMemory.Mappers.Widgits
{
    public class IdWidgitResponseMapper
    {
        public IdWidgitResponse Map(Widgit widgit)
        {
            return new IdWidgitResponse(widgit.Id, widgit.Name, widgit.Description, widgit.Price);
        }
    }
}
