namespace FarmWMongoDb.WebApi.Dtos.VideoBanner.Requests
{
    public class UpdateVideoBannerRequest
    {
        public string VideoBannerId { get; set; }
        public string Title1 { get; set; }
        public string Title2 { get; set; }
        public string Description { get; set; }
        public string? VideoUrl { get; set; }
    }
}
