using FarmWMongoDb.WebApi.Dtos.WelcomeBanner.Requests;
using FarmWMongoDb.WebApi.Services.WelcomeBannerServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FarmWMongoDb.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WelcomeBannersController : ControllerBase
    {
        private readonly IWelcomeBannerService _welcomeBannerService;

        public WelcomeBannersController(IWelcomeBannerService welcomeBannerService)
        {
            _welcomeBannerService = welcomeBannerService;
        }
        [HttpGet]
        public async Task<IActionResult> GetListWelcomeBanner()
        {
            var values = await _welcomeBannerService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateWelcomeBanner(CreateWelcomeBannerRequest createWelcomeBannerRequest)
        {
            await _welcomeBannerService.TInsert(createWelcomeBannerRequest);
            return Ok("İşlem Başarılı");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateWelcomeBanner(UpdateWelcomeBannerRequest updateWelcomeBannerRequest)
        {
            await _welcomeBannerService.TUpdate(updateWelcomeBannerRequest);
            return Ok("İşlem Başarılı");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteWelcomeBanner(string id)
        {
            await _welcomeBannerService.TDelete(id);
            return Ok("İşlem Başarılı");
        }

    }
}
