using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyMvcAuthApp.Data;

namespace MyMvcAuthApp.Controllers
{
    
    
    public class ApiController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public ApiController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public IActionResult Product()
        {
            var product = _db.Products.ToList();

            return Ok(product);

        }



    }
}