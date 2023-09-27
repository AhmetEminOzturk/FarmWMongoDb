namespace FarmWMongoDb.WebApi.Dtos.Testimonial.Requests
{
    public class UpdateTestimonialRequest
    {
        public string TestimonialId { get; set; }
        public string Title1 { get; set; }
        public string Title2 { get; set; }
        public string Description { get; set; }
        public string NameSurname { get; set; }
        public string City { get; set; }
    }
}
