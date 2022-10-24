using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace FleetManagementStreamingApp.Domain.Models
{
    public class CarModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string ModelName { get; set; }
        public Brand Brand { get; set; }
    }
}
