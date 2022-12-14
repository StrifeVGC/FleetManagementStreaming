using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace FleetManagementStreamingApp.Domain.Models
{
    public class Brand
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
