using FarmWMongoDb.WebApi.Dtos.HomeService.Requests;
using FarmWMongoDb.WebApi.Dtos.HomeService.Responses;

namespace FarmWMongoDb.WebApi.Services.HomeServiceServices
{
    public interface IHomeServiceService
    {
        Task TInsert(CreateHomeServiceRequest createHomeServiceRequest);
        Task TDelete(string id);
        Task TUpdate(UpdateHomeServiceRequest updateHomeServiceRequest);
        Task<List<DisplayHomeServiceResponse>> TGetList();
    }
}
