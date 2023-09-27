using AutoMapper;
using FarmWMongoDb.WebApi.Dtos.AboutUs.Requests;
using FarmWMongoDb.WebApi.Dtos.HomeService.Requests;
using FarmWMongoDb.WebApi.Dtos.Statistic.Requests;
using FarmWMongoDb.WebApi.Dtos.Testimonial.Requests;
using FarmWMongoDb.WebApi.Dtos.VideoBanner.Requests;
using FarmWMongoDb.WebApi.Dtos.WelcomeBanner.Requests;
using FarmWMongoDb.WebApi.Dtos.WhyUs.Requests;
using FarmWMongoDb.WebApi.Models;

namespace FarmWMongoDb.WebApi.Mappings
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<AboutUs,CreateAboutUsRequest>().ReverseMap();
            CreateMap<HomeService, CreateHomeServiceRequest>().ReverseMap();
            CreateMap<Statistic, CreateStatisticRequest>().ReverseMap();
            CreateMap<Testimonial, CreateTestimonialRequest>().ReverseMap();
            CreateMap<VideoBanner, CreateVideoBannerRequest>().ReverseMap();
            CreateMap<WelcomeBanner, CreateWelcomeBannerRequest>().ReverseMap();
            CreateMap<WhyUs, CreateWhyUsRequest>().ReverseMap();

            CreateMap<AboutUs, UpdateAboutUsRequest>().ReverseMap();
            CreateMap<HomeService, UpdateHomeServiceRequest>().ReverseMap();
            CreateMap<Statistic, UpdateStatisticRequest>().ReverseMap();
            CreateMap<Testimonial, UpdateTestimonialRequest>().ReverseMap();
            CreateMap<VideoBanner, UpdateVideoBannerRequest>().ReverseMap();
            CreateMap<WelcomeBanner, UpdateWelcomeBannerRequest>().ReverseMap();
            CreateMap<WhyUs, UpdateWhyUsRequest>().ReverseMap();
        }
    }
}
