using System.Diagnostics;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyMvcAuthApp.Data;
using MyMvcAuthApp.Models;
using MyMvcAuthApp.Repository;

namespace MyMvcAuthApp.Controllers;

public class HomeController : Controller
{
    private readonly IProductRepository _product;
    private readonly ApplicationDbContext _db;
    private readonly UserManager<IdentityUser> _userManager;

    public HomeController(IProductRepository product, ApplicationDbContext db , UserManager<IdentityUser> userManager)
    {
        _userManager = userManager;
        _product = product;
        _db = db;

    }



        public async Task<IActionResult> Index()
        {
            var products = await _product.Getir();

            var cart = await _db.Carts.Where(id => id.UserId == _userManager.GetUserId(User)).ToListAsync();
            ViewBag.Cart = cart;
            ViewBag.TotalPrice = Convert.ToDecimal(cart.Sum(item => item.Price));

            return View(products);
        }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
