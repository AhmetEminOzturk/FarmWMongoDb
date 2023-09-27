using FarmWMongoDb.WebApi.Dtos.Testimonial.Requests;
using FarmWMongoDb.WebApi.Dtos.Testimonial.Responses;

namespace FarmWMongoDb.WebApi.Services.TestimonialServices
{
    public interface ITestimonialService
    {
        Task TInsert(CreateTestimonialRequest createTestimonialRequest);
        Task TDelete(string id);
        Task TUpdate(UpdateTestimonialRequest updateTestimonialRequest);
        Task<List<DisplayTestimonialResponse>> TGetList();
    }
}
