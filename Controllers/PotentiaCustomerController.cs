using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyMvcAuthApp.Data;

namespace  MyMvcAuthApp.Controllers
{
   [Authorize(Roles = "Admin")]
   [Route("Admin/PotentiaCustomer")]
    public class PotentiaCustomerController : Controller
    {
        private readonly ApplicationDbContext _db;

        public PotentiaCustomerController(ApplicationDbContext db)
        {
            _db = db;
        }
        

        public IActionResult Index()
        {
            var PTO = _db.PotansiyelMusteriler.ToList();
            
            return View(PTO);
        }
    }
}