using FleetManagementStreamingApp.Common.Constants;
using FleetManagementStreamingApp.Domain.Models;
using FleetManagementStreamingApp.Domain.Repos.Contract;
using MongoDB.Driver;

namespace FleetManagementStreamingApp.Domain.Repos.Implementation
{
    public class BrandRepo : IBrandRepo
    {
        private readonly IMongoCollection<Brand> _brands;
        private readonly IMongoClient _client;

        public BrandRepo(IMongoClient client)
        {
            _client = client;

            _brands = client.GetDatabase(DbConstants.DatabaseName).GetCollection<Brand>(nameof(Brand));
        }

        public async Task<List<Brand>> GetAllBrands()
            => await _brands.Find(x => true).ToListAsync();

        public async Task<Brand> GetBrandById(string id)
        {
            var filter = Builders<Brand>.Filter.Eq(c => c.Id, id);
            return await _brands.Find(filter).FirstOrDefaultAsync();
        }
    }
}
