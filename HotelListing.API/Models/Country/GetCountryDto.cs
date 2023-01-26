﻿using HotelListing.API.Models.Hotel;

namespace HotelListing.API.Models.Country
{
    public class GetCountryDto
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string ShortName { get; set; }


        public List<GetHotelsDto> Hotels { get; set; }
    }
}