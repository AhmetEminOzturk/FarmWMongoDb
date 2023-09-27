using FarmWMongoDb.WebUI.Dtos.HomeService.Responses;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace FarmWMongoDb.WebUI.ViewComponents.Default
{
    public class _HomeServicePartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _HomeServicePartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5011/api/HomeServices");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<DisplayHomeServiceResponse>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
