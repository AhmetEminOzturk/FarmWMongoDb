using FarmWMongoDb.WebApi.Dtos.Testimonial.Requests;
using FarmWMongoDb.WebApi.Services.TestimonialServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FarmWMongoDb.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialsController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;

        public TestimonialsController(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }
        [HttpGet]
        public async Task<IActionResult> GetListTestimonial()
        {
            var values = await _testimonialService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateTestimonial(CreateTestimonialRequest createTestimonialRequest)
        {
            await _testimonialService.TInsert(createTestimonialRequest);
            return Ok("İşlem Başarılı");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateTestimonial(UpdateTestimonialRequest updateTestimonialRequest)
        {
            await _testimonialService.TUpdate(updateTestimonialRequest);
            return Ok("İşlem Başarılı");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteTestimonial(string id)
        {
            await _testimonialService.TDelete(id);
            return Ok("İşlem Başarılı");
        }
    }
}
