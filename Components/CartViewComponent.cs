using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyMvcAuthApp.Data;
using System.Collections.Generic;
using System.Data.Common;


public class CartViewComponent : ViewComponent
{
    private readonly ApplicationDbContext _db;

    private readonly UserManager<IdentityUser> _userManager;

    public CartViewComponent(ApplicationDbContext db, UserManager<IdentityUser> userManager)
    {
        _db = db;
        _userManager = userManager;
    }
    public IViewComponentResult Invoke()
    {
        var cart = _db.Carts.Where(id => id.UserId == _userManager.GetUserId(HttpContext.User)).ToList();





        
        return View(cart);
    }
}