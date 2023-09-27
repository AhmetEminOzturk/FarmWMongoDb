using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace FarmWMongoDb.WebApi.Models
{
    public class VideoBanner
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string VideoBannerId { get; set; }
        public string Title1 { get; set; }
        public string Title2 { get; set; }
        public string Description { get; set; }
        public string? VideoUrl { get; set; }
    }
}
