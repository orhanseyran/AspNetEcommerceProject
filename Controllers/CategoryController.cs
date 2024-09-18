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


    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
      
        public IActionResult Index()
        {
            var Category = _db.Categories.ToList();

            
            return View(Category);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Category category)
        {
            var Category = _db.Categories.FirstOrDefault(c => c.Name == category.Name);
            if (Category != null)
            {
                TempData["Error"] = "Kategori adı daha önce kullanılmış";
            }

            if (ModelState.IsValid)
            {
                await _db.Categories.AddAsync(category);
                await _db.SaveChangesAsync();
                
            }
            else
            {
                return View(category);
            }
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            
            var Category = await _db.Categories.FindAsync(id);
            if (Category == null)
            {
                return NotFound();
            }
            return View(Category);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Category category,int? id)
        {
            if (id == null)
            {
                return NotFound();
                
            }
            var Category = await _db.Categories.FindAsync(id);
            if (Category == null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                Category.Name = category.Name;
                Category.Description = category.Description;
                Category.Update_At = DateTime.Now;
                await _db.SaveChangesAsync();
                TempData["Success"] = "Kategori Başarıyla Güncellendi";
                return RedirectToAction("Index");
            }
            else
            {
                return View(category);
            }

        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var Category = await _db.Categories.FindAsync(id);

            if (Category == null)
            {
                return NotFound();
            }
            else
            {
                _db.Categories.Remove(Category);
                await _db.SaveChangesAsync();
                TempData["Success"] = "Kategori Başarıyla Silindi";
                return RedirectToAction("Index");
            }
          
        }
    }
}