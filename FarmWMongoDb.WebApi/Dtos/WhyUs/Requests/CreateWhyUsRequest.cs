namespace FarmWMongoDb.WebApi.Dtos.WhyUs.Requests
{
    public class CreateWhyUsRequest
    {
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
