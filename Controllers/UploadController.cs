using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyMvcAuthApp.Data;
using MyMvcAuthApp.Repository;

namespace MyMvcAuthApp.Controllers
{
    public class UploadController : Controller
    {
        private readonly IUploadImageRepository _uploadImageRepository;

        public UploadController(IUploadImageRepository uploadImageRepository)
        {
            _uploadImageRepository = uploadImageRepository;
        }
        public IActionResult Index()
        {

            
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Upload(Uploadİmage uploadİmage)
        {
            if (ModelState.IsValid)
            {
                var fileName = await _uploadImageRepository.UploadImage(uploadİmage);

                return RedirectToAction("Index");
            }
            return View(uploadİmage);
        }

        [HttpPost]
        public async Task<IActionResult> UploadImages(List<IFormFile> images)
        {
          if (images == null || images.Count == 0)
            {
                return NotFound();
            }
            try
            {
                 var fileNames = await _uploadImageRepository.UploadImages(images);
                 TempData["Onay"] = "Resimler Yüklendi";
                    return RedirectToAction("Index");
            }
            catch ( ArgumentException ex)
            {
                  TempData["Onay"] = ex.Message;
                 return RedirectToAction("Index");
                
         
            }
      
         
           
            

         
        }
    }
}