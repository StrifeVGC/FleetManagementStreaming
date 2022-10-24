using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace FleetManagementStreamingApp.Domain.Models
{
    public class Car
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public CarModel CarModel { get; set; }
    }
}
