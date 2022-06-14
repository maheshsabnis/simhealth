
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using Core_API.Models;

namespace Core_API.Services
{
    /// <summary>
    /// The class that will be used to Create New USer 
    /// and also login the user
    /// </summary>
    public class AuthService
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        /// <summary>
        /// Thsi will be injected with UserManager<IdentityUser>\
        /// and SignInManager<IdentityUser>
        /// These will be resolved by services.AddIdetity<IdentityUser,IdentityRole>
        /// from ConfigureServices() methdo of StartUp class
        /// </summary>
        public AuthService(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager; 
        }

        /// <summary>
        /// REgister New USer
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<ResponseData> RegisterNewUserAsync(RegisterUser user)
        {
            ResponseData responseData = new ResponseData();
            IdentityUser identityUser = new IdentityUser();
            identityUser.UserName = user.UserName;
            identityUser.Email = user.UserName;
            // Create the user
            var result = await userManager.CreateAsync(identityUser, user.Password);
            if (result.Succeeded)
            {
                responseData.Message = $"User {user.UserName} is Created Successfully";
            }
            else
            {
                responseData.Message = $"User {user.UserName} creation failed ";
            }
            return responseData;
        }
        /// <summary>
        /// Auteticate the USer
        /// </summary>
        /// <returns></returns>
        public async Task<ResponseData> AutheticateAsync(LoginUser user)
        {
            ResponseData responseData = new ResponseData();
            var identityUser = new IdentityUser() 
            {
               UserName = user.UserName
            };

            var result = await signInManager.PasswordSignInAsync(identityUser, user.Password, true, false);
            if (result.Succeeded)
            {
                responseData.Message = $"User {user.UserName} is Successfully Logged-In";
            }
            else
            {
                responseData.Message = $"Hay!! User {user.UserName} Don't be smart";
            }

            return responseData;
        }


    }
}
