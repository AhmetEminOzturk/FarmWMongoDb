using AutoMapper;
using FarmWMongoDb.WebApi.Dtos.Statistic.Requests;
using FarmWMongoDb.WebApi.Dtos.Statistic.Responses;
using FarmWMongoDb.WebApi.Models;
using FarmWMongoDb.WebApi.Settings;
using MongoDB.Driver;

namespace FarmWMongoDb.WebApi.Services.StatisticServices
{
    public class StatisticService :IStatisticService
    {
        private readonly IMongoCollection<Statistic> _statisticCollection;
        private readonly IMapper _mapper;

        public StatisticService(IMapper mapper, IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _statisticCollection = database.GetCollection<Statistic>(_databaseSettings.StatisticCollectionName);
            _mapper = mapper;
        }
        public async Task TDelete(string id)
        {
            await _statisticCollection.DeleteOneAsync(x => x.StatisticId == id);
        }

        public async Task<List<DisplayStatisticResponse>> TGetList()
        {
            var values = await _statisticCollection.Find(x => true).ToListAsync();
            return (_mapper.Map<List<DisplayStatisticResponse>>(values));
        }

        public async Task TInsert(CreateStatisticRequest createStatisticRequest)
        {
            var value = _mapper.Map<Statistic>(createStatisticRequest);
            await _statisticCollection.InsertOneAsync(value);
        }

        public async Task TUpdate(UpdateStatisticRequest updateStatisticRequest)
        {
            var value = _mapper.Map<Statistic>(updateStatisticRequest);
            await _statisticCollection.FindOneAndReplaceAsync(x => x.StatisticId == updateStatisticRequest.StatisticId, value);
        }
    }
}
