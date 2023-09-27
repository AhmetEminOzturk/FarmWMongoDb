using FarmWMongoDb.WebApi.Dtos.AboutUs.Requests;
using FarmWMongoDb.WebApi.Services.AboutUsServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FarmWMongoDb.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutUsController : ControllerBase
    {
        private readonly IAboutUsService _aboutUsService;

        public AboutUsController(IAboutUsService aboutUsService)
        {
            _aboutUsService = aboutUsService;
        }
        [HttpGet]
        public async Task<IActionResult> GetListAboutUs()
        {
            var values = await _aboutUsService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateAboutUs(CreateAboutUsRequest createAboutUsRequest)
        {
            await _aboutUsService.TInsert(createAboutUsRequest);
            return Ok("İşlem Başarılı");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateAboutUs(UpdateAboutUsRequest updateAboutUsRequest)
        {
            await _aboutUsService.TUpdate(updateAboutUsRequest);
            return Ok("İşlem Başarılı");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteAboutUs(string id)
        {
            await _aboutUsService.TDelete(id);
            return Ok("İşlem Başarılı");
        }

    }
}
