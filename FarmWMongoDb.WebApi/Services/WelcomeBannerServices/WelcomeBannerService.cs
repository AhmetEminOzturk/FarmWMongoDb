using AutoMapper;
using FarmWMongoDb.WebApi.Dtos.WelcomeBanner.Requests;
using FarmWMongoDb.WebApi.Dtos.WelcomeBanner.Responses;
using FarmWMongoDb.WebApi.Models;
using FarmWMongoDb.WebApi.Settings;
using MongoDB.Driver;

namespace FarmWMongoDb.WebApi.Services.WelcomeBannerServices
{
    public class WelcomeBannerService:IWelcomeBannerService
    {
        private readonly IMongoCollection<WelcomeBanner> _welcomeBannerCollection;
        private readonly IMapper _mapper;

        public WelcomeBannerService(IMapper mapper, IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _welcomeBannerCollection = database.GetCollection<WelcomeBanner>(_databaseSettings.WelcomeBannerCollectionName);
            _mapper = mapper;
        }
        public async Task TDelete(string id)
        {
            await _welcomeBannerCollection.DeleteOneAsync(x => x.WelcomeBannerId == id);
        }

        public async Task<List<DisplayWelcomeBannerResponse>> TGetList()
        {
            var values = await _welcomeBannerCollection.Find(x => true).ToListAsync();
            return (_mapper.Map<List<DisplayWelcomeBannerResponse>>(values));
        }

        public async Task TInsert(CreateWelcomeBannerRequest createWelcomeBannerRequest)
        {
            var value = _mapper.Map<WelcomeBanner>(createWelcomeBannerRequest);
            await _welcomeBannerCollection.InsertOneAsync(value);
        }

        public async Task TUpdate(UpdateWelcomeBannerRequest updateWelcomeBannerRequest)
        {
            var value = _mapper.Map<WelcomeBanner>(updateWelcomeBannerRequest);
            await _welcomeBannerCollection.FindOneAndReplaceAsync(x => x.WelcomeBannerId == updateWelcomeBannerRequest.WelcomeBannerId, value);
        }
    }
}
