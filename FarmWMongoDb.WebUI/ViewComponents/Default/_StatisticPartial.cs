using FarmWMongoDb.WebUI.Dtos.Statistic.Responses;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace FarmWMongoDb.WebUI.ViewComponents.Default
{
    public class _StatisticPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _StatisticPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5011/api/Statistics");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<DisplayStatisticResponse>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
