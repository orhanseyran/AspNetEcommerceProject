using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyMvcAuthApp.Data;
using MyMvcAuthApp.Repository;

namespace MyMvcAuthApp.Controllers
{
    public class ApiController : ControllerBase
    {
        private readonly IProductRepository _db;

        private readonly UserManager<IdentityUser> _userManager;
        public ApiController(IProductRepository db, UserManager<IdentityUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }
        [HttpGet]
        
        public async Task<IActionResult> Product()
        {

            var product = await _db.Getir();
            return Ok(product);
        }
         [HttpGet]
         [Route("api/product/{id}")]

        public async Task<IActionResult> ProductFilter(int id)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user != null)
            {
                await _userManager.GetRolesAsync(user);
            }

              
            var product = await _db.GetById(id);
            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }
    }
}