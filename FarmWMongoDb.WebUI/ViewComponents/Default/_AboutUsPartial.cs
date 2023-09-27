using FarmWMongoDb.WebUI.Dtos.AboutUs.Responses;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace FarmWMongoDb.WebUI.ViewComponents.Default
{
    public class _AboutUsPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _AboutUsPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5011/api/AboutUs");
            if (responseMessage.IsSuccessStatusCode) 
            {
                var jsonData= await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<DisplayAboutUsResponse>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
