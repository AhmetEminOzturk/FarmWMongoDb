using FarmWMongoDb.WebApi.Dtos.Statistic.Requests;
using FarmWMongoDb.WebApi.Services.StatisticServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FarmWMongoDb.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {
        private readonly IStatisticService _statisticService;

        public StatisticsController(IStatisticService statisticService)
        {
            _statisticService = statisticService;
        }
        [HttpGet]
        public async Task<IActionResult> GetListStatistic()
        {
            var values = await _statisticService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateStatistic(CreateStatisticRequest createStatisticRequest)
        {
            await _statisticService.TInsert(createStatisticRequest);
            return Ok("İşlem Başarılı");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateStatistic(UpdateStatisticRequest updateStatisticRequest)
        {
            await _statisticService.TUpdate(updateStatisticRequest);
            return Ok("İşlem Başarılı");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteStatistic(string id)
        {
            await _statisticService.TDelete(id);
            return Ok("İşlem Başarılı");
        }
    }
}
