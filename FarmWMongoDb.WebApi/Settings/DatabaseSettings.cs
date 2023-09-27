namespace FarmWMongoDb.WebApi.Settings
{
    public class DatabaseSettings : IDatabaseSettings
    {
        public string AboutUsCollectionName { get; set; }
        public string HomeServiceCollectionName { get; set; }
        public string StatisticCollectionName { get; set; }
        public string TestimonialCollectionName { get; set; }
        public string VideoBannerCollectionName { get; set; }
        public string WelcomeBannerCollectionName { get; set; }
        public string WhyUsCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
