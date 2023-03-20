using AutoMapper;
using HotelListing.API.Contracts;
using HotelListing.API.Data;
using HotelListing.API.Models.Users;
using Microsoft.AspNetCore.Identity;

namespace HotelListing.API.Services
{
    public class AuthManager : IAuthManager
    {
        private readonly IMapper _mapper;
        private readonly UserManager<ApiUser> _userManager;

        public AuthManager(IMapper mapper, UserManager<ApiUser> userManager)
        {
            _mapper = mapper;
            _userManager = userManager;
        }


        public async Task<IEnumerable<IdentityError>> Register(ApiUserDto userDto)
        {
            var user = _mapper.Map<ApiUser>(userDto);
            user.UserName = userDto.Email; // Δεν είχαμε ζητήσει UserName, κανουμε το email

            var result = await _userManager.CreateAsync(user, userDto.Password);

            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, "User");
            }

            return result.Errors;
        }

        public async Task<bool> Login(LoginDto loginDto)
        {
            bool isValidUser = false;
            try
            {
                var user = await _userManager.FindByEmailAsync(loginDto.Email);
                if (user == null)
                {
                    return default; // Η FindByEmail μπορει να γυρισει null αν το IdentityOptions.User.RequireUniqueEmail δεν ειναι true
                }

                 isValidUser = await _userManager.CheckPasswordAsync(user, loginDto.Password);
            }
            catch (Exception)
            {
            }

            return isValidUser;
        }
    }
}
