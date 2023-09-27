using FarmWMongoDb.WebApi.Dtos.AboutUs.Requests;
using FarmWMongoDb.WebApi.Dtos.AboutUs.Responses;
using FarmWMongoDb.WebApi.Models;

namespace FarmWMongoDb.WebApi.Services.AboutUsServices
{
    public interface IAboutUsService
    {
        Task TInsert(CreateAboutUsRequest createAboutUsRequest);
        Task TDelete(string id);
        Task TUpdate(UpdateAboutUsRequest updateAboutUsRequest);
        Task<List<DisplayAboutUsResponse>> TGetList();
    }
}
