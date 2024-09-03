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
      [Route("Admin/Cargo")]
    public class CargoController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CargoController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var Cargo = _db.Cargos.ToList();
            
            return View(Cargo);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Cargo cargo)
        {
            if (ModelState.IsValid)
            {
               await _db.Cargos.AddAsync(cargo);
               await _db.SaveChangesAsync();
               TempData["Success"] = "Kargo Firması Başarıyla Eklendi";
               return RedirectToAction("Index");
            }
            return View(cargo);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var Cargo = await _db.Cargos.FindAsync(id);
            if (Cargo == null)
            {
                return NotFound();
            }
            return View(Cargo);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Cargo cargo,int? id)
        {
            if (id == null)
            {
                return NotFound();
                
            }
            var Cargo = await _db.Cargos.FindAsync(id);
            if (Cargo == null)
            {
                return NotFound();
                
            }
            if (ModelState.IsValid)
            {
                Cargo.CargoName = cargo.CargoName;
                Cargo.CargoDescription = cargo.CargoDescription;
                Cargo.CargoWebSite = cargo.CargoWebSite;
                Cargo.CargoPhone = cargo.CargoPhone;
                _db.Cargos.Update(Cargo);
                await _db.SaveChangesAsync();
                TempData["Success"] = "Kargo Firması Başarıyla Güncellendi";
                return RedirectToAction("Index");

                
            }
            return View(cargo);

        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var Cargo = await _db.Cargos.FindAsync(id);
            if (Cargo == null)
            {
                return NotFound();
            }
            return View(Cargo);
        }

    }
}