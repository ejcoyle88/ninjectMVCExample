using NinjectModulesExample.Data.InMemory.Entities;
using NinjectModulesExample.Data.InMemory.Mappers.Widgits;
using System.Collections.Generic;
using System.Linq;
using NinjectModulesExample.Business.Boundry.Data;
using NinjectModulesExample.Business.Boundry.Data.Requests;
using NinjectModulesExample.Business.Boundry.Data.Responses;

namespace NinjectModulesExample.Data.InMemory.Repositories
{
    internal class WidgitProvider : IWidgitProvider
    {
        private List<Widgit> _widgits;
        private IdWidgitResponseMapper _idWidgitResponseMapper;

        public WidgitProvider(IdWidgitResponseMapper idWidgitResponseMapper)
        {
            _idWidgitResponseMapper = idWidgitResponseMapper;
            _widgits = new List<Widgit>
            {
                new Widgit { Id = 1, Name = "Testing 1", Description = "This is a test.", Price = 5 }
            };
        }

        public IdWidgitResponse GetFor(IdWidgitRequest request)
        {
            var target = _widgits.Single(x => x.Id.Equals(request.Id));
            return _idWidgitResponseMapper.Map(target);
        }
    }
}
