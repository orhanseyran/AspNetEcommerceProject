using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyMvcAuthApp.Data;
using MyMvcAuthApp.Models;

namespace MyMvcAuthApp.Controllers
{
    [Authorize(Roles = "Admin")]

    
    public class BrandController : Controller
    {
        private readonly ApplicationDbContext _db;

        public BrandController(ApplicationDbContext db)
        {
            _db = db;
        }
        
        
        public IActionResult Index()
        {
            var brand = _db.Brands.ToList();
            
            return View(brand);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Brand brand)
        {
            if (ModelState.IsValid)
            {
                _db.Brands.Add(brand);
                await _db.SaveChangesAsync();
                TempData["success"] = "Marka Başarıyla Eklendi.";
                return RedirectToAction(nameof(Index));
                
            }
            return View(brand);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var brand = _db.Brands.Find(id);
            return View(brand);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Brand brand , int id)
        {
            if (ModelState.IsValid)
            {
                var brandFromDb = _db.Brands.Find(id);
                if (brandFromDb == null)
                {
                    return NotFound();
                }
                brandFromDb.Name = brand.Name;

                _db.Brands.Update(brandFromDb);
                await _db.SaveChangesAsync();
                TempData["success"] = "Marka Başarıyla Güncellendi.";
                return RedirectToAction(nameof(Index));
                
            }
            return View(brand);
        }
        
        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var brand = await _db.Brands.FindAsync(id);

            if (brand == null)
            {
                return NotFound();
            }
            else
            {
                _db.Brands.Remove(brand);
                await _db.SaveChangesAsync();
                TempData["Success"] = "Marka Başarıyla Silindi";
                return RedirectToAction("Index");
            }
          
        }
    }
}