using AutoMapper;
using FarmWMongoDb.WebUI.Dtos.AboutUs.Responses;
using FarmWMongoDb.WebUI.Dtos.HomeService.Responses;
using FarmWMongoDb.WebUI.Dtos.Statistic.Responses;
using FarmWMongoDb.WebUI.Dtos.Testimonial.Responses;
using FarmWMongoDb.WebUI.Dtos.VideoBanner.Responses;
using FarmWMongoDb.WebUI.Dtos.WelcomeBanner.Responses;
using FarmWMongoDb.WebUI.Dtos.WhyUs.Responses;
using FarmWMongoDb.WebUI.Models;

namespace FarmWMongoDb.WebUI.Mappings
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<AboutUs, DisplayAboutUsResponse>().ReverseMap();
            CreateMap<HomeService, DisplayHomeServiceResponse>().ReverseMap();
            CreateMap<Statistic, DisplayStatisticResponse>().ReverseMap();
            CreateMap<Testimonial, DisplayTestimonialResponse>().ReverseMap();
            CreateMap<VideoBanner, DisplayVideoBannerResponse>().ReverseMap();
            CreateMap<WelcomeBanner, DisplayWelcomeBannerResponse>().ReverseMap();
            CreateMap<WhyUs, DisplayWhyUsResponse>().ReverseMap();
        }
    }
}
