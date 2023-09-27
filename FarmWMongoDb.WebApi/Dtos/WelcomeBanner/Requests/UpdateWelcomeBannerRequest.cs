namespace FarmWMongoDb.WebApi.Dtos.WelcomeBanner.Requests
{
    public class UpdateWelcomeBannerRequest
    {
        public string WelcomeBannerId { get; set; }
        public string Title1 { get; set; }
        public string Title2 { get; set; }
        public string Description { get; set; }
    }
}
