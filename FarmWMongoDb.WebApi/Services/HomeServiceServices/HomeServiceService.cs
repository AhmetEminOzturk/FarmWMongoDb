using AutoMapper;
using FarmWMongoDb.WebApi.Dtos.HomeService.Requests;
using FarmWMongoDb.WebApi.Dtos.HomeService.Responses;
using FarmWMongoDb.WebApi.Models;
using FarmWMongoDb.WebApi.Settings;
using MongoDB.Driver;

namespace FarmWMongoDb.WebApi.Services.HomeServiceServices
{
    public class HomeServiceService : IHomeServiceService
    {
        private readonly IMongoCollection<HomeService> _homeServiceCollection;
        private readonly IMapper _mapper;

        public HomeServiceService(IMapper mapper, IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _homeServiceCollection = database.GetCollection<HomeService>(_databaseSettings.HomeServiceCollectionName);
            _mapper = mapper;
        }
        public async Task TDelete(string id)
        {
            await _homeServiceCollection.DeleteOneAsync(x => x.HomeServiceId == id);
        }

        public async Task<List<DisplayHomeServiceResponse>> TGetList()
        {
            var values = await _homeServiceCollection.Find(x => true).ToListAsync();
            return (_mapper.Map<List<DisplayHomeServiceResponse>>(values));
        }

        public async Task TInsert(CreateHomeServiceRequest createHomeServiceRequest)
        {
            var value = _mapper.Map<HomeService>(createHomeServiceRequest);
            await _homeServiceCollection.InsertOneAsync(value);
        }

        public async Task TUpdate(UpdateHomeServiceRequest updateHomeServiceRequest)
        {
            var value = _mapper.Map<HomeService>(updateHomeServiceRequest);
            await _homeServiceCollection.FindOneAndReplaceAsync(x => x.HomeServiceId == updateHomeServiceRequest.HomeServiceId, value);
        }
    }
}
