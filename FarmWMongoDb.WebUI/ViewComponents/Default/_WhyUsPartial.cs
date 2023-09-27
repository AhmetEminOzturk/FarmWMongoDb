using FarmWMongoDb.WebUI.Dtos.WhyUs.Responses;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace FarmWMongoDb.WebUI.ViewComponents.Default
{
    public class _WhyUsPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _WhyUsPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5011/api/WhyUs");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<DisplayWhyUsResponse>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
