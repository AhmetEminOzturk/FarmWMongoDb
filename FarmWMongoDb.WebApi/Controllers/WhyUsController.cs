using FarmWMongoDb.WebApi.Dtos.WhyUs.Requests;
using FarmWMongoDb.WebApi.Services.WhyUsServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FarmWMongoDb.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WhyUsController : ControllerBase
    {
        private readonly IWhyUsService _whyUsService;

        public WhyUsController(IWhyUsService whyUsService)
        {
            _whyUsService = whyUsService;
        }
        [HttpGet]
        public async Task<IActionResult> GetListWhyUs()
        {
            var values = await _whyUsService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateWhyUs(CreateWhyUsRequest createWhyUsRequest)
        {
            await _whyUsService.TInsert(createWhyUsRequest);
            return Ok("İşlem Başarılı");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateWhyUs(UpdateWhyUsRequest updateWhyUsRequest)
        {
            await _whyUsService.TUpdate(updateWhyUsRequest);
            return Ok("İşlem Başarılı");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteWhyUs(string id)
        {
            await _whyUsService.TDelete(id);
            return Ok("İşlem Başarılı");
        }

    }
}
