
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using Core_API.Models;
using System;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;

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
        private readonly IConfiguration configuration;
        /// <summary>
        /// Thsi will be injected with UserManager<IdentityUser>\
        /// and SignInManager<IdentityUser>
        /// These will be resolved by services.AddIdetity<IdentityUser,IdentityRole>
        /// from ConfigureServices() methdo of StartUp class
        /// IConfiguration: This is used for reading appsettings.json to read JWTSettings from it
        /// </summary>
        public AuthService(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, IConfiguration configuration)
        {
            this.userManager = userManager;
            this.signInManager = signInManager; 
            this.configuration = configuration;
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
            string jwtToken = string.Empty;
           

            /// Inform the ASP.NET COre Identty that the LoginUSer Objet will
            /// Hold the Identity SO that the User Can be Logged-In
            var result = await signInManager.PasswordSignInAsync(user.UserName, user.Password, true, false);
            if (result.Succeeded)
            {
                //3b Read the secret key and the expiration from the configuration 
                var secretKey = Convert.FromBase64String(configuration["JWTCoreSettings:SecretKey"]);
                var expiryTimeSpan = Convert.ToInt32(configuration["JWTCoreSettings:ExpiryInMinuts"]);
                //3c. logic to get the user role
                // get the user object based on Email
                //  IdentityUser user = new IdentityUser(inputModel.UserName);
                IdentityUser appuser = new IdentityUser(user.UserName);

                //3d set the expity, subject, etc.
                // note that Issuer and Audience will be null because 
                // there is no third-party issuer
                var securityTokenDescription = new SecurityTokenDescriptor()
                {
                    Issuer = null, /*Issuer Service*/
                    Audience = null, /*Audience Service*/
                    /*List of Claims thse are added into the Token*/
                    Subject = new ClaimsIdentity(new List<Claim> {
                        new Claim("username",appuser.Id,ToString()), // claim will be the ID for the USer
                    }),
                    Expires = DateTime.UtcNow.AddMinutes(expiryTimeSpan), // 20 mins
                    IssuedAt = DateTime.UtcNow, // Issue time, this will be used for expiry check
                    NotBefore = DateTime.UtcNow, // The tkne will not be used befor this time 
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(secretKey), SecurityAlgorithms.HmacSha256Signature)
                };
                //3e Now generate token using JwtSecurityTokenHandler
                var jwtHandler = new JwtSecurityTokenHandler();
                var jwToken = jwtHandler.CreateJwtSecurityToken(securityTokenDescription);
                jwtToken = jwtHandler.WriteToken(jwToken);
            }
            else
            {
                jwtToken = "Login failed";
            }

            responseData.Message = jwtToken;

            return responseData;
        }


    }
}
