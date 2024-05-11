using Elastic.Clients.Elasticsearch;
using Searchfy.Domain.Entities;
using Searchfy.Services.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Searchfy.Services.Repositories
{
    public class TabRepository : ITabRepository
    {
        private readonly ElasticsearchClient _elasticsearchClient;

        public TabRepository(ElasticsearchClient elasticsearchClient)
        {
            _elasticsearchClient = elasticsearchClient;
        }
        public Task AddAsync(Tab entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Tab entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Tab>> GetAllAsync(SearchRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
