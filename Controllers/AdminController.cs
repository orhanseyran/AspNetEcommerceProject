using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyMvcAuthApp.Models;
using Microsoft.AspNetCore.Mvc;
using MyMvcAuthApp.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;


namespace auth.Controllers
{  
[Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
   
        private readonly ApplicationDbContext _db;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        public AdminController(ApplicationDbContext db,
         UserManager<IdentityUser> userManager,
          SignInManager<IdentityUser> signInManager,
           RoleManager<IdentityRole> roleManager
           )
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _db = db;
        }




        public IActionResult Index()
        {

            return View();
        }
        public IActionResult Products()
        {
            
            var products = _db.Products.ToList();
            return View(products);
        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            const string imageFormField = "Image";
            var imgUpload = Request.Form.Files.GetFiles(imageFormField);
            
            // Check if the model state is valid before processing the image
            if (ModelState.IsValid)
            {
                if (imgUpload.Count > 0)
                {
                    // Validate file type (e.g., only allow images)
                    var fileExtension = Path.GetExtension(imgUpload[0].FileName).ToLower();
                    var allowedExtensions = new[] { ".jpg", ".jpeg", ".png", ".gif" };
                    if (!allowedExtensions.Contains(fileExtension))
                    {
                        TempData["erroe"] = "Resim dosyası türü geçersiz. .JPG, .JPEG, .PNG veya .GIF dosyaları yükleyin.";
                        return View(product);
                    }

                    // Create a unique file name to prevent overwriting
                    var uniqueFileName = Guid.NewGuid().ToString() + fileExtension;
                    var imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", uniqueFileName);
                    
                    try
                    {
                        using (var stream = new FileStream(imagePath, FileMode.Create))
                        {
                            imgUpload[0].CopyTo(stream);
                        }
                        product.ImageUrl = $"/images/{uniqueFileName}";
                    }
                    catch (Exception ex)
                    {
                        ModelState.AddModelError("", "Error uploading image: " + ex.Message);
                        return View(product);
                    }
                }

                var userId = _userManager.GetUserId(User) ?? "0";
                var userName = _userManager.GetUserName(User) ?? "0";

                var newProduct = new Product
                {
                    Name = product.Name,
                    Description = product.Description,
                    Price = product.Price,
                    ImageUrl = product.ImageUrl,
                    stock = product.stock,
                    Brand = product.Brand,
                    CargoDesi = product.CargoDesi,
                    Cargo = product.Cargo,
                    Sehir = product.Sehir,
                    ShipDetail = product.ShipDetail,
                    Category = product.Category,
                    UserId = userId,
                    UserName = userName,
                    Create_At = DateTime.Now,
                    Update_At = DateTime.Now,
                };

                try
                {
                    _db.Products.Add(newProduct);
                    _db.SaveChanges();
                    TempData["success"] = "Ürün başarıyla eklendi.";
                    return RedirectToAction("Pruducts");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "Error saving product: " + ex.Message);
                    return View(product);
                }
            }

            return View(product); // Return the view with the current product data if the model state is invalid
        }
        public IActionResult DeleteProduct(int id)
        {
            
            var product = _db.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            _db.Products.Remove(product);
            _db.SaveChanges();
            TempData["success"] = "Ürün başarıyla silindi.";
            return RedirectToAction("Pruducts");
        }
        public IActionResult UpdateProduct(int id)
        {
            var product = _db.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
       [HttpPost]
        public IActionResult UpdateProduct(int id, Product product)
        {
            const string imageFormField = "Image";
            var imgUpload = Request.Form.Files.GetFiles(imageFormField);
            
            // Check if the model state is valid before processing the image
            if (ModelState.IsValid)
            {
                if (imgUpload.Count > 0)
                {
                    // Validate file type (e.g., only allow images)
                    var fileExtension = Path.GetExtension(imgUpload[0].FileName).ToLower();
                    var allowedExtensions = new[] { ".jpg", ".jpeg", ".png", ".gif" };
                    if (!allowedExtensions.Contains(fileExtension))
                    {
                        TempData["error"] = "Resim dosyası türü geçersiz. .JPG, .JPEG, .PNG veya .GIF dosyaları yükleyin.";
                        return View(product);
                    }

                    // Create a unique file name to prevent overwriting
                    var uniqueFileName = Guid.NewGuid().ToString() + fileExtension;
                    var imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", uniqueFileName);
                    
                    try
                    {
                        using (var stream = new FileStream(imagePath, FileMode.Create))
                        {
                            imgUpload[0].CopyTo(stream);
                        }
                        if (product.ImageUrl == null)
                        {
                            product.ImageUrl = $"/images/{uniqueFileName}"; 
                        }
                    
                    }
                    catch (Exception ex)
                    {
                        ModelState.AddModelError("", "Error uploading image: " + ex.Message);
                        return View(product);
                    }
                }

                var userId = _userManager.GetUserId(User) ?? "0";
                var userName = _userManager.GetUserName(User) ?? "0";
                var existingProduct = _db.Products.Find(id);
                if (existingProduct == null)
                {
                    return NotFound();
                }

                // Update the existing product with new values
                existingProduct.Name = product.Name;
                existingProduct.Description = product.Description;
                existingProduct.Price = product.Price;
                existingProduct.ImageUrl = product.ImageUrl == null ? existingProduct.ImageUrl : product.ImageUrl;
                existingProduct.stock = product.stock;
                existingProduct.Brand = product.Brand;
                existingProduct.CargoDesi = product.CargoDesi;
                existingProduct.Cargo = product.Cargo;
                existingProduct.Sehir = product.Sehir;
                existingProduct.ShipDetail = product.ShipDetail;
                existingProduct.Category = product.Category;
                existingProduct.UserId = userId;
                existingProduct.UserName = userName;
                existingProduct.Create_At = DateTime.Now;
                existingProduct.Update_At = DateTime.Now;

                try
                {
                    _db.Products.Update(existingProduct);
                    _db.SaveChanges();
                    TempData["success"] = "Ürün başarıyla güncellendi.";
                    return RedirectToAction("Pruducts"); // Corrected typo
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "Error saving product: " + ex.Message);
                    return View(product);
                }
            }

            return View(product); // Return the view if model state is invalid
        }

        public IActionResult Cart()
        {
            var cartItems = _db.Carts.ToList();
            return View(cartItems);
        }
        public IActionResult CartAdd(int id)
        {
            var product = _db.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }

            var cartfirst =  _db.Carts.FirstOrDefault(c => c.ProductId == id);
            if (cartfirst != null)
            {
                cartfirst.Quantity += 1;
                cartfirst.TotalPrice =  Convert.ToDouble(cartfirst.Quantity)* Convert.ToDouble(product.Price) ;


                _db.SaveChanges();
              return RedirectToAction("Products");
            }
            else{
         var cartItem = new Cart
            {
                ProductId = product.Id,
                UserId = _userManager.GetUserId(User) ?? "0",
                ProductName = product.Name ?? "",
                Price = product.Price,
                UserName = product.UserName,
                ImageUrl = product.ImageUrl,
                Quantity = 1,

              
            };
            _db.Carts.Add(cartItem);
            _db.SaveChanges();

              return RedirectToAction("Products");

            }
        }

        public IActionResult Slider()
        {
            var slider = _db.Sliders.ToList();
            return View(slider);
        }
        public IActionResult RoleManage()
        {
            var roles = _roleManager.Roles.ToList();
            return View(roles);
        }
        public IActionResult RoleAdd()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> RoleAdd(Role role)
        {
            if (ModelState.IsValid)
            {
                var result = await _roleManager.CreateAsync(
                    new IdentityRole(role.UserRole ?? "User")
                );
                if (result.Succeeded)
                {
                    TempData["success"] = "Role Başarıyla Eklendi.";
                    return RedirectToAction("RoleManage");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(role);
        }
        public  async Task<IActionResult> RoleEdits(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);
            return View(role);
  
        }

        [HttpPost]
        public async Task<IActionResult> RoleEdit(Role role, string id)
        {
            var user = await _roleManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }
             

              if (ModelState.IsValid)
              {
                 user.Name = role.UserRole;
                 var result = await _roleManager.UpdateAsync(user);
                 if (result.Succeeded)
                 {
                     TempData["success"] = "Role Başarıyla Güncellendi.";
                     return RedirectToAction("RoleManage");
                 }
                
              }


            return View(role);
        }
        public async Task<IActionResult> RoleDelete(string id)
        {
            var user = await _roleManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            var result = await _roleManager.DeleteAsync(user);
            if (result.Succeeded)
            {
                TempData["success"]="Role Başarıyla Silindi.";
                return RedirectToAction("RoleManage");
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(user);
        }
        
        public async Task<IActionResult> UserManage()
        {
            // Retrieve all users
            var users = _userManager.Users.ToList();

            // Create a list to store user and role information
            var userRolesList = new List<UserRoleViewModel>();

            foreach (var user in users)
            {
                // Fetch roles for the user
                var roles = await _userManager.GetRolesAsync(user);

                // Add user and their roles to the list
                userRolesList.Add(new UserRoleViewModel
                {
                    User = user,
                    Roles = roles
                });
            }

            // Pass the user and role data to the view using ViewBag
            ViewBag.UserRoles = userRolesList;

            return View();
        }
        public IActionResult UserAdd()
        {
            var role =  _roleManager.Roles.ToList();
            ViewBag.Role = role;

            return View();
        }
        public async Task<IActionResult> UserEdit(string id)
        {
            var user = await _userManager.FindByIdAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            // Kullanıcıya atanmış rolleri al
            var userRoles = await _userManager.GetRolesAsync(user);

            var roles = _roleManager.Roles.ToList();
            ViewBag.Roles = roles; // Tüm roller
            ViewBag.UserRoles = userRoles; // Kullanıcıya atanmış roller
            ViewBag.User = user;

            if (roles == null || !roles.Any())
            {
                return NotFound();
            }

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UserAdd(AddUser user)

        {
            if (user.Password == null)
            {
                TempData["error"] = "Lütfen Şifre Giriniz.";
                return RedirectToAction("UserManage");
            }
            var userCreate = new IdentityUser
            {
                UserName = user.Email,
                Email = user.Email,
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                TwoFactorEnabled = false,
                LockoutEnabled = true,
                AccessFailedCount = 0,
                SecurityStamp = Guid.NewGuid().ToString(),
            };
            var result = await _userManager.CreateAsync(userCreate, user.Password);
              await _userManager.AddToRoleAsync(userCreate, user.Role ?? "User");
            if (result.Succeeded)
            {
                TempData["success"] = "Kullanıcı Başarıyla Eklendi.";
                return RedirectToAction("UserManage");
                
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(user);

        }
          
          
          
        [HttpPost]
        public async Task<IActionResult> UsersEdit(AddUser addUser, string id)
        {
              var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            // Kullanıcı rolünü güncellemek için:
            var currentRoles = await _userManager.GetRolesAsync(user);
            var resultRemoveRoles = await _userManager.RemoveFromRolesAsync(user, currentRoles);
            if (!resultRemoveRoles.Succeeded)
            {
                foreach (var error in resultRemoveRoles.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                return View(addUser);
            }

            var resultAddRole = await _userManager.AddToRoleAsync(user, addUser.Role ?? "User");
            if (!resultAddRole.Succeeded)
            {
                foreach (var error in resultAddRole.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                return View(addUser);
            }

            // Kullanıcı bilgilerini güncelle
            user.Email = addUser.Email;
            user.UserName = addUser.Email;

            user.EmailConfirmed = true;
            user.LockoutEnabled = true;

            var userUpdateResult = await _userManager.UpdateAsync(user);
            if (userUpdateResult.Succeeded)
            {
                return RedirectToAction("UserManage");
            }
            else
            {
                foreach (var error in userUpdateResult.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                return View(addUser);
            }
        }
        public async Task<IActionResult> UserDelete(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            var result = await _userManager.DeleteAsync(user);
            if (result.Succeeded)
            {
                TempData["success"] = "Kullanıcı Başarıyla Silindi.";
                return RedirectToAction("UserManage");
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(user);
        }

    }
}