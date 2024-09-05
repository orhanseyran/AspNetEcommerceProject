using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyMvcAuthApp.Data;
using MyMvcAuthApp.Models;
using MyMvcAuthApp.Repository;

namespace MyMvcAuthApp.Controllers
{
    public class ApiController : ControllerBase
    {
        private readonly IProductRepository _db;

        private readonly UserManager<IdentityUser> _userManager;

        private readonly ApplicationDbContext _dbcontext;
        public ApiController(IProductRepository db, UserManager<IdentityUser> userManager,ApplicationDbContext dbcontext)
        {
            _db = db;
            _dbcontext = dbcontext;
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
            [HttpPost]
            [Route("api/ProductAddCart/{id}/{quantity}")]
            public async Task<IActionResult> ProductAddCart( int id , int quantity)
            {
        
                var user = await _userManager.GetUserAsync(User);
                if (user == null)
                {
                    return Unauthorized();
                }
                var cartget = await _dbcontext.Carts.FirstAsync(c => c.UserId == (user != null ? user.Id : null));
                 var product = await _dbcontext.Products.FindAsync(id);
                 
               if (cartget != null)
               {
                
                cartget.Quantity += quantity;
                    cartget.TotalPrice += product.Price ?? 0;
                    await _dbcontext.SaveChangesAsync();
                    return Ok(cartget);
                
               } 
            var cart = new Cart();
                // Ürünü al
              
                if (product == null)
                {
                    return BadRequest("Ürün Bulunamadı");
                }

                // Sepet bilgilerini doldur
                cart.UserId = user?.Id ?? "0";
                cart.ProductName = product.Name ?? "Ürün Bulunamadı";
                cart.Price = product.Price ?? 0;
                cart.ImageUrl = product.ImageUrl ?? "https://via.placeholder.com/150";
                cart.Quantity = quantity;
                cart.TotalPrice = product.Price ?? 0;
                cart.ProductId = id;
                cart.UserName = "1";

                
                cart.Create_At = DateTime.Now;
                cart.Update_At = DateTime.Now;

                // Sepete ekle
                await _dbcontext.Carts.AddAsync(cart);
                await _dbcontext.SaveChangesAsync();

                return Ok(cart);
            }
    }
}