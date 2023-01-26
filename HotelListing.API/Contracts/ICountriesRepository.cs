using HotelListing.API.Contracts;
using HotelListing.API.Data;
using Microsoft.EntityFrameworkCore;

public interface ICountriesRepository : IGenericRepository<Country>
{
    Task<Country> GetDetailsAsync(int id);

}