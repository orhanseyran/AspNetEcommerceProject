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
using MyMvcAuthApp.ViewModels;

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
        public async Task<IActionResult> ProductDetail(int id)
        {
            var detail = await _db.GetById(id);
            if (detail == null)
            {
                return BadRequest();
                
            }
            return Ok(detail);
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
public async Task<IActionResult> ProductAddCart(CartAdd cartuser ,int id, int quantity )
{
   



    // Fetch the product
    var product = await _dbcontext.Products.FindAsync(id);
    if (product == null)
    {
        return BadRequest("Ürün Bulunamadı");
    }
         var ipAddress =  HttpContext.Request.HttpContext.Connection.RemoteIpAddress?.ToString();

        // IP adresini string olarak formatla
        

    // Check stock availability
    if (product.stock < quantity)
    {
        return BadRequest("Ürün Stokta Yeterli Miktarda Yok");
    }

    // Try to get the user's cart
    var cartget = await _dbcontext.Carts.FirstOrDefaultAsync(c => c.ProductId == product.Id);
    
    if (cartget != null)
    {
        // Check stock again before updating the cart
        if (product.stock < cartget.Quantity + quantity)
        {
            return BadRequest("Ürün Stokta Yeterli Miktarda Yok");
        }

        // Update existing cart
        cartget.Quantity += quantity;
        cartget.TotalPrice = product.Price * cartget.Quantity;
        cartget.UserName = cartget.UserName == null ?  ipAddress : cartuser.UserName;
        await _dbcontext.SaveChangesAsync();
        return Ok(cartget);
    }

    // Create a new cart if it doesn't exist
    var cart = new Cart
    {
        UserId = "1",
        ProductName = product.Name ?? "Ürün Bulunamadı",
        Price = product.Price ?? 0,
        ImageUrl = product.ImageUrl ?? "https://via.placeholder.com/150",
        Quantity = quantity,
        TotalPrice = product.Price * quantity,
        ProductId = id,
        UserName = cartuser.UserName == null ?  ipAddress : cartuser.UserName , // Assuming UserName is a property of the user object
        Create_At = DateTime.Now,
        Update_At = DateTime.Now,
     

    };

    // Add to cart
    await _dbcontext.Carts.AddAsync(cart);
    await _dbcontext.SaveChangesAsync();

    return Ok(cart);
}

            [HttpGet]

            [Route("api/Cart/{UserName}")]

            public async Task<IActionResult> Cart(string UserName)
            {

                var cart = await _dbcontext.Carts.Where(c => c.UserName == UserName).ToListAsync();

                if (cart == null)
                {
                    var ipAddress =  HttpContext.Request.HttpContext.Connection.RemoteIpAddress?.ToString();
                   var cartget = await _dbcontext.Carts.Where(c => c.UserName == ipAddress).ToListAsync();
                   return Ok(cartget);
                }

                return Ok(cart);
            }
            
           
            public async Task<IActionResult> CartDelete(int id)
            {

                var cart = await _dbcontext.Carts.FindAsync(id);
                if (cart == null)
                {
                    return BadRequest("Sepet Bulunamadı");
                }
                _dbcontext.Carts.Remove(cart);
                await _dbcontext.SaveChangesAsync();
                return Ok(cart);
            }
            public async Task<IActionResult> CartDeleteAll()
            {
                var cart = await _dbcontext.Carts.ToListAsync();
                if (cart == null)
                {
                    return BadRequest("Sepet Bulunamadı");
                }
                _dbcontext.Carts.RemoveRange(cart);
                await _dbcontext.SaveChangesAsync();
                return Ok(cart);
            }
            [HttpPost]
            [Route("api/CartPlus/{id}")]
            public async Task<IActionResult> CartPlus(int id)
            {
                var cart = await _dbcontext.Carts.FirstOrDefaultAsync(c => c.Id == id);

                if (cart == null)
                {
                    return BadRequest("Sepet Bulunamadı");
                }

                if (cart.Quantity == 0)
                {
                    _dbcontext.Carts.Remove(cart);
                }
                else
                {
                    cart.Quantity += 1;
                    cart.TotalPrice += cart.Price;
                }

                await _dbcontext.SaveChangesAsync();
                return Ok(cart);
            }
            public async Task<IActionResult> CartUpdate(CartViewModel cartViewModel)
            {
                if (ModelState.IsValid)
                {
                    if (cartViewModel == null)
                    {
                        return BadRequest("Sepet Bulunamadı");
                        
                    }
                    foreach (var cart in cartViewModel.Cart)
                    {
                        var cartdb = await _dbcontext.Carts.FindAsync(cart.Id);
                        if (cartdb != null)
                        {
                            cartdb.Quantity = cart.Quantity;
                            cartdb.TotalPrice = cart.TotalPrice;
                            await _dbcontext.SaveChangesAsync();
                            return Ok(cartdb);
                        }
                    }

                    
                }
                return BadRequest("Sepet Bulunamadı");

            }
            [HttpPost]
            [Route("api/CartNegative/{id}")]
            public async Task<IActionResult> CartNegative(int id)
            {

                var cart = await _dbcontext.Carts.FirstOrDefaultAsync(c => c.Id == id);

                if (cart == null)
                {
                    return BadRequest("Sepet Bulunamadı");
                }

                if (cart.Quantity == 1)
                {
                     cart.Quantity = 1;
                    cart.TotalPrice = cart.Price;
                }
                else
                {
                    cart.Quantity -= 1;
                    cart.TotalPrice -= cart.Price;
                }

                await _dbcontext.SaveChangesAsync();
                return Ok(cart);

            }


            [HttpGet]
            [Route("api/CartTotalPrice/{UserName}")]

            public async Task<IActionResult> CartTotalPrice(string UserName)
            {
                var cart = await _dbcontext.Carts.Where(c => c.UserName == UserName).ToListAsync();
                if (cart == null)
                {
                    return BadRequest("Sepet Bulunamadı");
                }
                var totalPrice = cart.Sum(c => c.TotalPrice);
                return Ok(totalPrice);
            }

            [HttpGet]
            [Route("Api/WishList/{UserName}")]
            public async Task<IActionResult> WishList (string UserName)
            {
               var wishlist = await _dbcontext.WishLists.Where(g=>g.UserName == UserName ).ToListAsync();
               if (wishlist == null)
               {
                return BadRequest("Beğeni Listesi Bulunamadı");
               }
               return Ok(wishlist);
            }
             [HttpGet]
            [Route("Api/WishListDetail/{id}")]
            public async Task<IActionResult> WishListDetail(int id)
            {
                var wishlist = await _dbcontext.WishLists.Where(g=>g.ProductId == id).FirstOrDefaultAsync();
                if (wishlist == null)
                {
                    return BadRequest("Beğeni Listesi Bulunamadı");
                }
                return Ok(wishlist);
            }

            [HttpGet]
            [Route("Api/WishListDelete/{id}")]
            public async Task<IActionResult> WishListDelete(int id){
                var wishlist = await _dbcontext.WishLists.Where(g=>g.ProductId == id).FirstOrDefaultAsync();
                if (wishlist == null)
                {
                    return BadRequest("Beğeni Listesi Bulunamadı");
                }
                _dbcontext.WishLists.Remove(wishlist);
                await _dbcontext.SaveChangesAsync();
                return Ok(wishlist);

            }


            [HttpPost]
            public async Task<IActionResult> WishListAdd(WishList wishList)
            {
                // Ürün veritabanında var mı kontrolü
                var product = await _dbcontext.Products.FindAsync(wishList.ProductId);
                if (product == null)
                {
                    return BadRequest("Ürün Bulunamadı");
                }

                // Ürünün zaten favorilerde olup olmadığını kontrol ediyoruz
                var existingWishlistItem = await _dbcontext.WishLists
                    .Where(g => g.ProductId == wishList.ProductId && g.UserName == wishList.UserName)
                    .FirstOrDefaultAsync();

                if (existingWishlistItem != null)
                {
                   _dbcontext.WishLists.Remove(existingWishlistItem);
                   await _dbcontext.SaveChangesAsync();

                   return Ok(existingWishlistItem);
                }

                // Ürünü favorilere ekliyoruz
                var wishlistItem = new WishList
                {
                    ProductId = product.Id,
                    ProductName = product.Name,
                    ProductImage = product.ImageUrl,
                    ProductPrice = product.Price ?? 0,
                    UserName = wishList.UserName,
                    Create_At = DateTime.Now,
                    Update_At = DateTime.Now,
                };
                await _dbcontext.WishLists.AddAsync(wishlistItem);
                await _dbcontext.SaveChangesAsync();

                return Ok(wishlistItem);
            }

            public async Task<IActionResult> CategoryGet()
            {
                var category = await _dbcontext.Categories.ToListAsync();
                return Ok(category);
            }

            [HttpGet]
            [Route("Api/CategoryGetProductFilter")]
            public async Task<IActionResult> CategoryGetProductFilter(List<string> category)
            {
                if (category == null || !category.Any())
                {
                    return BadRequest("Kategori Bulunamadı");
                }
                var product = await _dbcontext.Products.Where(p => p.Category != null && category.Contains(p.Category)).ToListAsync();
                return Ok(product);
            }

            [HttpGet]
            [Route("Api/Productİmages/{id}")]
            public async Task<IActionResult> Productİmages (int id)
            {
                var product = await _dbcontext.Images.Where(g=>g.ProductId == id).ToListAsync();
                if (product == null)
                {
                    return BadRequest("Ürün Bulunamadı");
                }
                return Ok(product);
            }

            [HttpGet]
            [Route("Api/ProductCompareGet")]
            public async Task<IActionResult> ProductCompareGet(Compore compore)
            {
                // Ürün veritabanında var mı kontrolü

                // Ürünün zaten favorilerde olup olmadığını kontrol ediyoruz
                var CompareItem = await _dbcontext.Compores.Where(g => g.UserName == compore.UserName).ToListAsync();

                if (CompareItem == null)
                {
                    return BadRequest("Ürün Bulunamadı");
                    
                }

                return Ok(CompareItem);
            }
            public async Task<IActionResult> ProductCompareAdd(Compore compore)
            {
                // Ürün veritabanında var mı kontrolü
                var product = await _dbcontext.Products.FindAsync(compore.ProductId);
                if (product == null)
                {
                    return BadRequest("Urun Bulunamadı");
                }
                else {
                    var addCompore = new Compore{
                        ProductId = product.Id,
                        Name = product.Name,
                        ImageUrl = product.ImageUrl,
                        Price = product.Price ?? 0,
                        UserName = compore.UserName,
                        Create_At = DateTime.Now,
                        Update_At = DateTime.Now,
                    };

                    _dbcontext.Compores.Add(addCompore);
                    await _dbcontext.SaveChangesAsync();

                    return Ok(addCompore);




                }


            } 
    }
}