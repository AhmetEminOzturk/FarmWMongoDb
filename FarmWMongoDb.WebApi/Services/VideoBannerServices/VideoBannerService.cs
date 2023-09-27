using AutoMapper;
using FarmWMongoDb.WebApi.Dtos.VideoBanner.Requests;
using FarmWMongoDb.WebApi.Dtos.VideoBanner.Responses;
using FarmWMongoDb.WebApi.Models;
using FarmWMongoDb.WebApi.Settings;
using MongoDB.Driver;

namespace FarmWMongoDb.WebApi.Services.VideoBannerServices
{
    public class VideoBannerService:IVideoBannerService
    {
        private readonly IMongoCollection<VideoBanner> _videoBannerCollection;
        private readonly IMapper _mapper;

        public VideoBannerService(IMapper mapper, IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _videoBannerCollection = database.GetCollection<VideoBanner>(_databaseSettings.VideoBannerCollectionName);
            _mapper = mapper;
        }
        public async Task TDelete(string id)
        {
            await _videoBannerCollection.DeleteOneAsync(x => x.VideoBannerId == id);
        }

        public async Task<List<DisplayVideoBannerResponse>> TGetList()
        {
            var values = await _videoBannerCollection.Find(x => true).ToListAsync();
            return (_mapper.Map<List<DisplayVideoBannerResponse>>(values));
        }

        public async Task TInsert(CreateVideoBannerRequest createVideoBannerRequest)
        {
            var value = _mapper.Map<VideoBanner>(createVideoBannerRequest);
            await _videoBannerCollection.InsertOneAsync(value);
        }

        public async Task TUpdate(UpdateVideoBannerRequest updateVideoBannerRequest)
        {
            var value = _mapper.Map<VideoBanner>(updateVideoBannerRequest);
            await _videoBannerCollection.FindOneAndReplaceAsync(x => x.VideoBannerId == updateVideoBannerRequest.VideoBannerId, value);
        }
    }
}
