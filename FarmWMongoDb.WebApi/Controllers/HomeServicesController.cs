using FarmWMongoDb.WebApi.Dtos.HomeService.Requests;
using FarmWMongoDb.WebApi.Services.HomeServiceServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FarmWMongoDb.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeServicesController : ControllerBase
    {
        private readonly IHomeServiceService _homeServiceService;

        public HomeServicesController(IHomeServiceService homeServiceService)
        {
            _homeServiceService = homeServiceService;
        }
        [HttpGet]
        public async Task<IActionResult> GetListHomeService()
        {
            var values = await _homeServiceService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateHomeService(CreateHomeServiceRequest createHomeServiceRequest)
        {
            await _homeServiceService.TInsert(createHomeServiceRequest);
            return Ok("İşlem Başarılı");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateHomeService(UpdateHomeServiceRequest updateHomeServiceRequest)
        {
            await _homeServiceService.TUpdate(updateHomeServiceRequest);
            return Ok("İşlem Başarılı");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteHomeService(string id)
        {
            await _homeServiceService.TDelete(id);
            return Ok("İşlem Başarılı");
        }
    }
}
