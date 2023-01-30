using HotelListing.API.Models.Country;

namespace HotelListing.API.Models.Hotel
{
    public class GetHotelDto : BaseHotelDto
    {
        public int Id { get; set; }

        // θα ηθελα και country name
        //public List<GetCountriesDto> Countries { get; set; }
    }
}
