namespace FarmWMongoDb.WebApi.Dtos.HomeService.Requests
{
    public class UpdateHomeServiceRequest
    {
        public string HomeServiceId { get; set; }
        public string Title { get; set; }
        public string ServiceTitle { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
