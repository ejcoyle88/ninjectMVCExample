using NinjectModulesExample.Business.DataBoundry.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectModulesExample.Data.Entities.Mappers.Widgits
{
    public class IdWidgitResponseMapper
    {
        public IdWidgitResponse Map(Widgit widgit)
        {
            return new IdWidgitResponse(widgit.Id, widgit.Name, widgit.Description, widgit.Price);
        }
    }
}
