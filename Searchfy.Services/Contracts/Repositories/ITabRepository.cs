using Elastic.Clients.Elasticsearch;
using Searchfy.Domain.Entities;

namespace Searchfy.Services.Contracts.Repositories
{
    public interface ITabRepository : IRepository<Tab, SearchRequest>
    {

    }
}
