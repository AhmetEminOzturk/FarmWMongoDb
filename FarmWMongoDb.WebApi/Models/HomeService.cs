using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace FarmWMongoDb.WebApi.Models
{
    public class HomeService
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string HomeServiceId { get; set; }
        public string Title { get; set; }
        public string ServiceTitle { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
