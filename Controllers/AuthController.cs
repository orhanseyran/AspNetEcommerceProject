using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;
using MyMvcAuthApp.Controllers;
using MyMvcAuthApp.Data;


namespace MyMvcAuthApp.Controllers
{
[AllowAnonymous]
    public class AuthController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AuthController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, ApplicationDbContext db)
        {
            _db = db;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult AccessDenied()
        {
            // Yetkisiz erişim olduğunda anasayfaya yönlendiriyoruz
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Login()
        {
                    var user = await _userManager.GetUserAsync(User);
                if (user != null)
                {
                    // Eğer kullanıcı oturum açmışsa, Index sayfasına yönlendir
                    return RedirectToAction("Index", "Home");
                }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LoginPost(MyMvcAuthApp.Data.LoginRegister login)
        {
        var user = await _userManager.GetUserAsync(User);
    if (user != null)
    {
        // Eğer kullanıcı oturum açmışsa, Index sayfasına yönlendir
        return RedirectToAction("Index", "Home");
    }

            var result = await _signInManager.PasswordSignInAsync(login.Username, login.Password, false, false);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("Login");
        }

        public async Task<IActionResult> Register()
        {
         var user = await _userManager.GetUserAsync(User);
                if (user != null)
                {
                    // Eğer kullanıcı oturum açmışsa, Index sayfasına yönlendir
                    return RedirectToAction("Index", "Home");
                }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RegisterPost(MyMvcAuthApp.Data.LoginRegister register)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser
                {
                    UserName = register.Email,
                    Email = register.Email,
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true,
                    TwoFactorEnabled = false,
                    LockoutEnabled = true,
                    AccessFailedCount = 0,
                    SecurityStamp = Guid.NewGuid().ToString(),
                };
                var result = await _userManager.CreateAsync(user, register.Password ?? "");

                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, isPersistent: false);
                    await _userManager.AddToRoleAsync(user, register.Role ?? "Müşteri");
                    TempData["Success"] = "Kayıt başarıyla tamamlandı.";

                    return RedirectToAction("Login");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return RedirectToAction("Register");
        }
    }
}