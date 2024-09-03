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

    public class OrdersController : Controller
    {
        private readonly ApplicationDbContext _db;

        public OrdersController(ApplicationDbContext db)
        {
            _db = db;
        }
      
        public IActionResult Index()
        {
            var orders = _db.Orders.ToList();
            
            return View(orders);
        }
        public IActionResult Detail(int id)
        {
            var orderdetail = _db.Orders.Find(id);
            return View(orderdetail);
        }
        public IActionResult Delete(int id)
        {
            var orderdetail = _db.Orders.Find(id);
            _db.Orders.Remove(orderdetail);
            _db.SaveChanges();
            TempData["success"] = "Silme İşlemi Başarılı";
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Update(Order order , int? id)
        {
            if (id == null)
            {
                return NotFound();
                
            }
            var orderdetail = _db.Orders.Find(id);
            if (orderdetail == null)
            {
                return NotFound();
            }
            orderdetail.OrderStatus = order.OrderStatus;
            _db.Orders.Update(orderdetail);
            _db.SaveChanges();
            TempData["success"] = "Güncelleme İşlemi Başarılı";
            return RedirectToAction("Index");


        }
    }
}