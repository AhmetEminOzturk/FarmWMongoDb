using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace FarmWMongoDb.WebApi.Models
{
    public class Testimonial
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string TestimonialId { get; set; }
        public string Title1 { get; set; }
        public string Title2 { get; set; }
        public string Description { get; set; }
        public string NameSurname { get; set; }
        public string City { get; set; }
    }
}
