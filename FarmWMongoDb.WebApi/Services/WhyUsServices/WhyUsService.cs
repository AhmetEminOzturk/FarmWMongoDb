using AutoMapper;
using FarmWMongoDb.WebApi.Dtos.WhyUs.Requests;
using FarmWMongoDb.WebApi.Dtos.WhyUs.Responses;
using FarmWMongoDb.WebApi.Models;
using FarmWMongoDb.WebApi.Settings;
using MongoDB.Driver;

namespace FarmWMongoDb.WebApi.Services.WhyUsServices
{
    public class WhyUsService:IWhyUsService
    {
        private readonly IMongoCollection<WhyUs> _whyUsCollection;
        private readonly IMapper _mapper;

        public WhyUsService(IMapper mapper, IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _whyUsCollection = database.GetCollection<WhyUs>(_databaseSettings.WhyUsCollectionName);
            _mapper = mapper;
        }
        public async Task TDelete(string id)
        {
            await _whyUsCollection.DeleteOneAsync(x => x.WhyUsId == id);
        }

        public async Task<List<DisplayWhyUsResponse>> TGetList()
        {
            var values = await _whyUsCollection.Find(x => true).ToListAsync();
            return (_mapper.Map<List<DisplayWhyUsResponse>>(values));
        }

        public async Task TInsert(CreateWhyUsRequest createWhyUsRequest)
        {
            var value = _mapper.Map<WhyUs>(createWhyUsRequest);
            await _whyUsCollection.InsertOneAsync(value);
        }

        public async Task TUpdate(UpdateWhyUsRequest updateWhyUsRequest)
        {
            var value = _mapper.Map<WhyUs>(updateWhyUsRequest);
            await _whyUsCollection.FindOneAndReplaceAsync(x => x.WhyUsId == updateWhyUsRequest.WhyUsId, value);
        }
    }
}
