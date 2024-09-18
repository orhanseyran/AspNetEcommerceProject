using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Humanizer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;
using MyMvcAuthApp.Data;
using MyMvcAuthApp.Models;

namespace MyMvcAuthApp.Controllers
{
    using System.IdentityModel.Tokens.Jwt;
    using System.Text;
    using Microsoft.AspNetCore.Http.HttpResults;
    using Microsoft.IdentityModel.Tokens;

    public class LoginRegisterController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly ApplicationDbContext _db;

        private readonly IConfiguration _configuration;

        public LoginRegisterController(UserManager<ApplicationUser> userManager, SignInManager<IdentityUser> signInManager, ApplicationDbContext db, IConfiguration configuration)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _db = db;
            _configuration = configuration;
        }
        public async Task<IActionResult> GetUser ()
        {
            var user = await _userManager.GetUserAsync(User);   
            if (user == null)
            {
                return BadRequest("Kullanıcı bulunamadı.");
                
            }
            return Ok(user);
        }

        [HttpPost]
        [EnableRateLimiting("LoginPolicy")]
        public async Task<IActionResult> Login(AddUser user)
        {
            if (string.IsNullOrEmpty(user.Email) || string.IsNullOrEmpty(user.Password))
            {
                return BadRequest("Email veya şifre boş olamaz.");
                
            }
            var useremail = await _userManager.FindByEmailAsync(user.Email);

            if (useremail == null)
            {
                return BadRequest("Kullanıcı bulunamadı.");
                
            }
            if (await _userManager.IsLockedOutAsync(useremail))
            {
                return Unauthorized("Birden Fazla Hatalı Giriş Yaptınız. Hesabınız 15 dakika boyunca kilitlenecektir.");
                
            }
            if (!useremail.EmailConfirmed)
            {
                return BadRequest("Lütfen email adresinizi doğrulayınız.");
                
            }
            var result = await _signInManager.PasswordSignInAsync(useremail, user.Password, false, false);

            if (result.Succeeded)
            {
                await _userManager.ResetAccessFailedCountAsync(useremail);

                var token = GenerateJwtToken(useremail);

                var usertoken = new ApplicationUser 
                { 
                    UserName = token , 

                };

                await _userManager.UpdateAsync(usertoken);
                


                 var getuser = await _userManager.GetUserAsync(User);   


                return Ok(new
                {
                    message = "Giriş Başarılı",
                    user = new { useremail.UserName, useremail.Email },
                    token = token,
                    getuser = getuser
                });
                
                
            }
            else if(result.IsLockedOut)
            {
                return Unauthorized("Birden Fazla Hatalı Giriş Yaptınız. Hesabınız 15 dakika boyunca kilitlenecektir.");

            }
            else
            {
                await _userManager.AccessFailedAsync(useremail);
                return BadRequest("Kullanıcı adı veya şifre yanlış.");
            }

            
            
            
        }
        private string GenerateJwtToken(IdentityUser user)
        {
           var jwtKey = _configuration["Jwt:Key"];

           if (string.IsNullOrEmpty(jwtKey) || jwtKey.Length < 32)
           {
            throw new InvalidOperationException("JWT anahtarı geçersiz veya yetersiz uzunlukta.");
            
           }
        var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()), // Benzersiz kimlik
                new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()), // Token oluşturulma zamanı
                // Gerekirse diğer gerekli claim'ler
            };

             var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtKey));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                claims: claims,
                expires: DateTime.UtcNow.AddHours(1), // Token süresi (örneğin 1 saat)
                signingCredentials: creds
            );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return Ok();
        }
        
    }
}