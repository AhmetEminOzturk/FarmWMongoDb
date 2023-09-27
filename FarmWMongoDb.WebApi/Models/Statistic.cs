using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace FarmWMongoDb.WebApi.Models
{
    public class Statistic
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)] 
        public string StatisticId { get; set; }
        public string Title1 { get; set; }
        public string Title2 { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public string Icon1 { get; set; }
        public string Icon2 { get; set; }
        public string Count1 { get; set; }
        public string Count2 { get; set; }
        
    }
}
