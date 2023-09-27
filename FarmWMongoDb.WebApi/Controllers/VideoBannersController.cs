using FarmWMongoDb.WebApi.Dtos.VideoBanner.Requests;
using FarmWMongoDb.WebApi.Services.VideoBannerServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FarmWMongoDb.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoBannersController : ControllerBase
    {
        private readonly IVideoBannerService _videoBannerService;

        public VideoBannersController(IVideoBannerService videoBannerService)
        {
            _videoBannerService = videoBannerService;
        }
        [HttpGet]
        public async Task<IActionResult> GetListVideoBanner()
        {
            var values = await _videoBannerService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateVideoBanner(CreateVideoBannerRequest createVideoBannerRequest)
        {
            await _videoBannerService.TInsert(createVideoBannerRequest);
            return Ok("İşlem Başarılı");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateVideoBanner(UpdateVideoBannerRequest updateVideoBannerRequest)
        {
            await _videoBannerService.TUpdate(updateVideoBannerRequest);
            return Ok("İşlem Başarılı");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteVideoBanner(string id)
        {
            await _videoBannerService.TDelete(id);
            return Ok("İşlem Başarılı");
        }

    }
}
