using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyMvcAuthApp.Data;
using MyMvcAuthApp.Repository;

namespace auth.Controllers
{

    

    
    public class ShopController : Controller
    {
        private readonly ApplicationDbContext _db;
            private readonly IProductRepository _product;
private readonly UserManager<IdentityUser> _userManager;

        public ShopController(ApplicationDbContext db , IProductRepository product , UserManager<IdentityUser> userManager )
        {
            _product = product;
            _userManager = userManager;

            _db = db;
        }

        public IActionResult Index()
        {
            
            return View();
        }

       
        public async Task<IActionResult> Details(int id)
        {

                var product = await _product.GetById(id);
                var cart = await _db.Carts.Where(c => c.UserId == _userManager.GetUserId(User)).ToListAsync();

                var products = await _db.Products.
                OrderByDescending(x => x.Create_At).Take(4).
                ToListAsync();
                ViewBag.Products = products;
                ViewBag.Cart = cart;
            
                ViewBag.TotalPrice = Convert.ToDecimal(cart.Sum(item => item.Price));


                return View(product);
        }
        public IActionResult Cart()
        {
            return View();
        }
        public IActionResult Checkout()
        {
            return View();
        }
    }
}