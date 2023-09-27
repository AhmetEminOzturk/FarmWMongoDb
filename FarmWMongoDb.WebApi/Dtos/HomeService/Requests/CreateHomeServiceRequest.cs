namespace FarmWMongoDb.WebApi.Dtos.HomeService.Requests
{
    public class CreateHomeServiceRequest
    {
        public string Title { get; set; }
        public string ServiceTitle { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
