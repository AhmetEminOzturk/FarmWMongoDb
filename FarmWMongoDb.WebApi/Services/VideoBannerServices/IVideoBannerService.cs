using FarmWMongoDb.WebApi.Dtos.VideoBanner.Requests;
using FarmWMongoDb.WebApi.Dtos.VideoBanner.Responses;

namespace FarmWMongoDb.WebApi.Services.VideoBannerServices
{
    public interface IVideoBannerService
    {
        Task TInsert(CreateVideoBannerRequest createVideoBannerRequest);
        Task TDelete(string id);
        Task TUpdate(UpdateVideoBannerRequest updateVideoBannerRequest);
        Task<List<DisplayVideoBannerResponse>> TGetList();
    }
}
