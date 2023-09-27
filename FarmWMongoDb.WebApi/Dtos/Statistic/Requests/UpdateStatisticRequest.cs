namespace FarmWMongoDb.WebApi.Dtos.Statistic.Requests
{
    public class UpdateStatisticRequest
    {
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
