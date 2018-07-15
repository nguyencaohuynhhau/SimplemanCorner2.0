using SimplemanCorner.Data.Infrastructure;
using SimplemanCorner.Model.Models;

namespace SimplemanCorner.Data.Repositories
{
    public interface ISupportOnlineRepository : IRepository<SupportOnline>
    {
    }

    public class SupportOnlineRepository : RepositoryBase<SupportOnline>, ISupportOnlineRepository
    {
        public SupportOnlineRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}