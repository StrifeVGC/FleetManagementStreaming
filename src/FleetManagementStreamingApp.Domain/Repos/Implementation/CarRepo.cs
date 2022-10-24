using FleetManagementStreamingApp.Common.Constants;
using FleetManagementStreamingApp.Domain.Models;
using FleetManagementStreamingApp.Domain.Repos.Contract;
using MongoDB.Driver;

namespace FleetManagementStreamingApp.Domain.Repos.Implementation
{
    public class CarRepo : ICarRepo
    {
        private readonly IMongoCollection<Car> _cars;
        private readonly IMongoClient _client;

        public CarRepo(IMongoClient client)
        {
            _client = client;

            _cars = client.GetDatabase(DbConstants.DatabaseName).GetCollection<Car>(nameof(Car));
        }

        public async Task<List<Car>> GetAllCars()
            => await _cars.Find(x => true).ToListAsync();

        public async Task<Car> GetCarById(string id)
        {
            var filter = Builders<Car>.Filter.Eq(c => c.Id, id);
            return await _cars.Find(filter).FirstOrDefaultAsync();
        }
    }
}
