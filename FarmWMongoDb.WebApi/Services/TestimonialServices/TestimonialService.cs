using AutoMapper;
using FarmWMongoDb.WebApi.Dtos.Testimonial.Requests;
using FarmWMongoDb.WebApi.Dtos.Testimonial.Responses;
using FarmWMongoDb.WebApi.Models;
using FarmWMongoDb.WebApi.Settings;
using MongoDB.Driver;

namespace FarmWMongoDb.WebApi.Services.TestimonialServices
{
    public class TestimonialService:ITestimonialService
    {
        private readonly IMongoCollection<Testimonial> _testimonialCollection;
        private readonly IMapper _mapper;

        public TestimonialService(IMapper mapper, IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _testimonialCollection = database.GetCollection<Testimonial>(_databaseSettings.TestimonialCollectionName);
            _mapper = mapper;
        }
        public async Task TDelete(string id)
        {
            await _testimonialCollection.DeleteOneAsync(x => x.TestimonialId == id);
        }

        public async Task<List<DisplayTestimonialResponse>> TGetList()
        {
            var values = await _testimonialCollection.Find(x => true).ToListAsync();
            return (_mapper.Map<List<DisplayTestimonialResponse>>(values));
        }

        public async Task TInsert(CreateTestimonialRequest createTestimonialRequest)
        {
            var value = _mapper.Map<Testimonial>(createTestimonialRequest);
            await _testimonialCollection.InsertOneAsync(value);
        }

        public async Task TUpdate(UpdateTestimonialRequest updateTestimonialRequest)
        {
            var value = _mapper.Map<Testimonial>(updateTestimonialRequest);
            await _testimonialCollection.FindOneAndReplaceAsync(x => x.TestimonialId == updateTestimonialRequest.TestimonialId, value);
        }
    }
}
