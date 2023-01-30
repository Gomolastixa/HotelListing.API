using HotelListing.API.Data;
using HotelListing.API.Models.Country;
using AutoMapper;
using HotelListing.API.Models.Hotel;

namespace HotelListing.API.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig() 
        {
            CreateMap<Country, CreateCountryDto>().ReverseMap();
            CreateMap<Country, GetCountriesDto>().ReverseMap();
            CreateMap<Country, GetCountryDto>().ReverseMap();
            CreateMap<Country, UpdateCountryDto>().ReverseMap();

            CreateMap<Hotel, GetHotelDto>().ReverseMap();
            CreateMap<Hotel, CreateHotelDto>().ReverseMap();
        }
    }
}
