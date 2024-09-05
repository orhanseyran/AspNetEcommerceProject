using System;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using MyMvcAuthApp.Data;

namespace MyMvcAuthApp.Controllers
{
    public class BaseController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public BaseController(ApplicationDbContext db, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _db = db;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);

            // Kullanıcı oturum açtıysa sepet bilgilerini ve toplam fiyatı ViewBag'e ekleyin
            if (User.Identity.IsAuthenticated)
            {
                var userId = _userManager.GetUserId(User);
                var cart = _db.Carts.Where(c => c.UserId == userId).ToList();
                ViewBag.Cart = cart;
                ViewBag.TotalPrice = cart.Sum(item => item.Price);
            }
            else
            {
                ViewBag.Cart = null;
                ViewBag.TotalPrice = 0;
            }
        }
    }
}
