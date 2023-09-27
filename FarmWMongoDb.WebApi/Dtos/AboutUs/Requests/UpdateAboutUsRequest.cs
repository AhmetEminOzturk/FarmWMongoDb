namespace FarmWMongoDb.WebApi.Dtos.AboutUs.Requests
{
    public class UpdateAboutUsRequest
    {
        public string AboutUsId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Service1 { get; set; }
        public string Service2 { get; set; }
        public string Service3 { get; set; }
        public string ImageUrl1 { get; set; }
        public string ImageUrl2 { get; set; }
        public string ImageUrl3 { get; set; }
    }
}
