using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyMvcAuthApp.Data;

namespace MyMvcAuthApp.Controllers
{
       [Authorize(Roles = "Admin")]
    [Route("Admin/WishList")]
    public class WishListController : Controller
    {
        private readonly ApplicationDbContext _db;
        public WishListController(ApplicationDbContext db)
        {
            _db = db;
        }
                
  
        public IActionResult Index()
        {
            
            return View();
        }

    }
}