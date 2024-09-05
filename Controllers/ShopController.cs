using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
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

       
        public IActionResult Details(int id)
        {

            var product = _db.Products.Find(id);
            if (product == null)
            {
                return NotFound();
                
            }

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