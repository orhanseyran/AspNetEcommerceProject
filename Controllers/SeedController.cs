using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyMvcAuthApp.Data;
using MyMvcAuthApp.Models;

namespace auth.Controllers
{
    public class SeedController : Controller
    {
        private readonly ApplicationDbContext _db;
    
       private readonly UserManager<IdentityUser> _userManager;


        public SeedController(ApplicationDbContext db , UserManager<IdentityUser> userManager )

        {
            _userManager = userManager;
            _db = db;

         
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> UserCreate()
        {
            for (int i = 0; i < 10; i++)
            {
              await _userManager.CreateAsync(
                new IdentityUser
                {
                    UserName = String.Format("orhanseyran{0}@gmail.com", Random.Shared.Next(1, 1000)),
                    Email = String.Format("orhanseyran{0}@gmail.com", Random.Shared.Next(1, 1000)),
                    EmailConfirmed = true,
                },  "Admin123456."
                );
                
            }


                
                
            return View();
        }
        public IActionResult Build()
        {
            var ekle = 100;
             if (_db.Products.Count() == 0)
             
        {
            for (int i = 0; i < ekle; i++)
                {
                _db.Products.AddRange(

        

                    new Product
                    {
                        Id = Random.Shared.Next(1, 10000000),
                        Name = String.Format("Iphone {0}", Random.Shared.Next(1, 1000)),
                        Price = Random.Shared.Next(1000, 10000),
                        Description = String.Format("Iphone {0}", Random.Shared.Next(1, 1000)),
                        ImageUrl = "https://www.apple.com/v/iphone-13/b/images/overview/compare/compare_iphone_13__d333x.jpg"
                    }

                );
                    
                }
   

        _db.SaveChanges();
        TempData["success"] = "Veriler Başarıyla Eklendi";

        return RedirectToAction("Index");
           
        }
        else{
             TempData["error"] = "Daha Önce Veri Eklenmiş";
             return RedirectToAction("Index");
             

        }
            
          
        }
        public IActionResult Delete()
        {
   
            _db.Products.RemoveRange(_db.Products);
            _db.SaveChanges();
            TempData["success"] = "Veriler Başarıyla Silindi";
            return RedirectToAction("Index");

        }
    }
}