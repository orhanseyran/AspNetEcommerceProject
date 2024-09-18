using System.Diagnostics;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyMvcAuthApp.Data;
using MyMvcAuthApp.Models;
using MyMvcAuthApp.Repository;
using X.PagedList;
using X.PagedList.Extensions;

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



        public async Task<IActionResult> Index(int? page)
        {
                int pageSize = 4; // Sayfa başına gösterilecek eleman sayısı
            int pageNumber = (page ?? 1);
            
                var products =  _db.Products
                .OrderBy(x => x.Id) // Kendi sıralamanı ekleyebilirsin
                .ToPagedList(pageNumber, pageSize);
        // Sayfa numarası, eğer yoksa 1

        var slider = await _db.Sliders.OrderByDescending(x => x.Create_At).Take(5).ToListAsync();
        ViewBag.Slider = slider;

            var cart = await _db.Carts.Where(id => id.UserId == _userManager.GetUserId(User)).ToListAsync();
             ViewBag.Cart = cart;
            

            ViewBag.TotalPrice = Convert.ToDecimal(cart.Sum(item => item.Price));

            return View(products);
        }
            public async Task<IActionResult> ProductDetail(int id)
            {
                var product = await _product.GetById(id);
                var cart = await _db.Carts.
                Where(c => c.UserId == _userManager.GetUserId(User))
                .ToListAsync();


                var products = await _db.Products.OrderByDescending(x => x.Create_At).ToListAsync();
                    ViewBag.Products = products;
                ViewBag.Cart = cart;
            
                ViewBag.TotalPrice = Convert.ToDecimal(cart.Sum(item => item.Price));


                return View(product);
            }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
