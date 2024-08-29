using System.Diagnostics;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyMvcAuthApp.Data;
using MyMvcAuthApp.Models;

namespace MyMvcAuthApp.Controllers;

public class HomeController : Controller
{

    private readonly ApplicationDbContext _db;

    public HomeController( ApplicationDbContext db)
    {
 
        _db = db;
    }

    public async Task<IActionResult> Index()
    {
        var products = await _db.Products.ToListAsync();
      

        return View(products);
    }



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
