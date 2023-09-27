using FarmWMongoDb.WebApi.Dtos.WelcomeBanner.Requests;
using FarmWMongoDb.WebApi.Dtos.WelcomeBanner.Responses;

namespace FarmWMongoDb.WebApi.Services.WelcomeBannerServices
{
    public interface IWelcomeBannerService
    {
        Task TInsert(CreateWelcomeBannerRequest createWelcomeBannerRequest);
        Task TDelete(string id);
        Task TUpdate(UpdateWelcomeBannerRequest updateWelcomeBannerRequest);
        Task<List<DisplayWelcomeBannerResponse>> TGetList();
    }
}
