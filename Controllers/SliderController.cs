using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyMvcAuthApp.Data;
using MyMvcAuthApp.Models;

namespace MyMvcAuthApp.Controllers
{
    public class SliderController : Controller
    {
        private readonly ApplicationDbContext _db;
        public SliderController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var data = _db.Sliders.OrderByDescending(x => x.Create_At).ToList();

            
            return View(data);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Slider slider, IFormFile sliderImage)
        {
            if (ModelState.IsValid)
            {
                if (sliderImage != null)
                {
                    // Dosya adını oluştur
                    var fileName = Path.GetFileName(sliderImage.FileName);
                    // Dosya yolunu oluştur
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", fileName);

                    // Dosyayı yükle
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        sliderImage.CopyTo(stream);
                    }

                    // Slider'ın ImageUrl'ini dosya adıyla güncelle
                    slider.ImageUrl = fileName;
                }
                else
                {
                    // Dosya yüklenmezse varsayılan bir resim ayarla
                    slider.ImageUrl = "noimage.png";
                }

                // Slider'ı veritabanına ekle ve kaydet
                _db.Sliders.Add(slider);
                _db.SaveChanges();
                TempData["success"] = "Slider Başarıyla Eklendi";
                return RedirectToAction("Index");
            }

            return View(slider);
        }
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var slider = _db.Sliders.Find(id);
            if (slider == null)
            {
                return NotFound();
            }
            return View(slider);
        }
        [HttpPost]
        public IActionResult Edit(Slider slider, IFormFile sliderImage)
        {
            if (ModelState.IsValid)
            {
                if (sliderImage != null)
                {
                    // Dosya adını oluştur
                    var fileName = Path.GetFileName(sliderImage.FileName);
                    // Dosya yolunu oluştur
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", fileName);
                    // Dosyayı yükle
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        sliderImage.CopyTo(stream);
                    }
                    // Slider'ın ImageUrl'ini güncelle
                    slider.ImageUrl = fileName;
                }
                else
                {
                    // Dosya yüklenmezse varsayılan bir resim ayarla
                    slider.ImageUrl = "noimage.png";
                }


                // Slider'ı güncelle ve kaydet
                _db.Sliders.Update(slider);
                _db.SaveChanges();
                TempData["success"] = "Slider Başarıyla Güncellendi";
                return RedirectToAction("Index");
            }

         return RedirectToAction("Index");
     }
     
     public IActionResult Delete(int? id)
     {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var slider = _db.Sliders.Find(id);
            
            if (slider == null)
            {
                return NotFound();
            }
            _db.Sliders.Remove(slider);
            _db.SaveChanges();
            TempData["success"] = "Slider Başarıyla Silindi";
            return RedirectToAction("Index");
     }     
    }
}