using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HGO.ASPNetCore.FileManager.CommandsProcessor;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyMvcAuthApp.Data;

namespace MyMvcAuthApp.Controllers
{
    public class FileController : Controller
    {
        private readonly IFileManagerCommandsProcessor _processor;
            private readonly ApplicationDbContext _db;
            private readonly UserManager<IdentityUser> _userManager;


        public FileController(IFileManagerCommandsProcessor processor , ApplicationDbContext db , UserManager<IdentityUser> userManager)
        {
            _processor = processor;
            _db = db;
            _userManager = userManager;
        }
        [HttpPost, HttpGet]
        public async Task<IActionResult> HgoApi(string id, string command, string parameters, IFormFile file)
        {
            return await _processor.ProcessCommandAsync(id, command, parameters, file);
        }
        

        public IActionResult Index()
        {
                  var cart = _db.Carts.Where(id => id.UserId == _userManager.GetUserId(User)).ToList();
            ViewBag.Cart = cart;
                    ViewBag.TotalPrice = Convert.ToDecimal(cart.Sum(item => item.Price));
            
            return View();
        }
    }
}