using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace FarmWMongoDb.WebApi.Models
{
    public class WhyUs
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string WhyUsId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string Service1 { get; set; }
        public string Service2 { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public string ServicePercentage1 { get; set; }
        public string ServicePercentage2 { get; set; }


    }
}
