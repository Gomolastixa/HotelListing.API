using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.API.Data.Configurations
{
    public class HotelConfig : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Hilton",
                    Address = "Athens",
                    CountryId = 1,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Lasagna",
                    Address = "Milan",
                    CountryId = 2,
                    Rating = 4.4
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Jamon",
                    Address = "Mallorca",
                    CountryId = 3,
                    Rating = 4.3
                });
        }
    }
}
