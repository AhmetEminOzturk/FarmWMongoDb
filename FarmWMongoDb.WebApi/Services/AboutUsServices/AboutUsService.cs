using AutoMapper;
using FarmWMongoDb.WebApi.Dtos.AboutUs.Requests;
using FarmWMongoDb.WebApi.Dtos.AboutUs.Responses;
using FarmWMongoDb.WebApi.Models;
using FarmWMongoDb.WebApi.Settings;
using MongoDB.Driver;

namespace FarmWMongoDb.WebApi.Services.AboutUsServices
{
    public class AboutUsService : IAboutUsService
    {
        private readonly IMongoCollection<AboutUs> _aboutUsCollection;
        private readonly IMapper _mapper;

        public AboutUsService(IMapper mapper, IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _aboutUsCollection = database.GetCollection<AboutUs>(_databaseSettings.AboutUsCollectionName);
            _mapper = mapper;
        }
        public async Task TDelete(string id)
        {
            await _aboutUsCollection.DeleteOneAsync(x=> x.AboutUsId == id);
        }

        public async Task<List<DisplayAboutUsResponse>> TGetList()
        {
            var values= await _aboutUsCollection.Find(x=>true).ToListAsync();
            return (_mapper.Map<List<DisplayAboutUsResponse>>(values));
        }

        public async Task TInsert(CreateAboutUsRequest createAboutUsRequest)
        {
            var value = _mapper.Map<AboutUs>(createAboutUsRequest);
            await _aboutUsCollection.InsertOneAsync(value);
        }

        public async Task TUpdate(UpdateAboutUsRequest updateAboutUsRequest)
        {
            var value = _mapper.Map<AboutUs>(updateAboutUsRequest);
            await _aboutUsCollection.FindOneAndReplaceAsync(x => x.AboutUsId == updateAboutUsRequest.AboutUsId, value);
        }
    }
}
