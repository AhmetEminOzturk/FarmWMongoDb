using FarmWMongoDb.WebApi.Dtos.Statistic.Requests;
using FarmWMongoDb.WebApi.Dtos.Statistic.Responses;

namespace FarmWMongoDb.WebApi.Services.StatisticServices
{
    public interface IStatisticService
    {
        Task TInsert(CreateStatisticRequest createStatisticRequest);
        Task TDelete(string id);
        Task TUpdate(UpdateStatisticRequest updateStatisticRequest);
        Task<List<DisplayStatisticResponse>> TGetList();
    }
}
