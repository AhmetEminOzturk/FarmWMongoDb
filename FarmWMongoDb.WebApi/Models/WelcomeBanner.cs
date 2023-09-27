using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace FarmWMongoDb.WebApi.Models
{
    public class WelcomeBanner
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string WelcomeBannerId { get; set; }
        public string Title1 { get; set; }
        public string Title2 { get; set; }
        public string Description { get; set; }
    }
}
