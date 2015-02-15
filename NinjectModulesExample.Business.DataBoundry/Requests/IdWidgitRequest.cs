
namespace NinjectModulesExample.Business.Boundry.Data.Requests
{
    public class IdWidgitRequest
    {
        public int Id { get; private set; }

        public IdWidgitRequest(int id)
        {
            Id = id;
        }
    }
}
