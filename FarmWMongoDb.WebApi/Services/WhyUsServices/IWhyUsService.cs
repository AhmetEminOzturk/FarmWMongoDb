using FarmWMongoDb.WebApi.Dtos.WhyUs.Requests;
using FarmWMongoDb.WebApi.Dtos.WhyUs.Responses;

namespace FarmWMongoDb.WebApi.Services.WhyUsServices
{
    public interface IWhyUsService
    {
        Task TInsert(CreateWhyUsRequest createWhyUsRequest);
        Task TDelete(string id);
        Task TUpdate(UpdateWhyUsRequest updateWhyUsRequest);
        Task<List<DisplayWhyUsResponse>> TGetList();
    }
}
