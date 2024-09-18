using Microsoft.AspNetCore.Identity;
using MyMvcAuthApp.Data;

namespace  MyMvcAuthApp.Models;


public class Cart
{





    public int Id { get; set; }
    public int ProductId { get; set; }
    public string  UserId  { get; set; }
    public int Quantity { get; set; }
    public double ? Price { get; set; }
    public double ? İpAdres { get; set; }
    public double ? TotalPrice { get; set; }
    public string ProductName { get; set; }
    public string ? ImageUrl { get; set; }
    public string ? UserName { get; set; }
    public string ? UserEmail { get; set; }
    public string ? UserPhone { get; set; }
    public string ? UserAddress { get; set;}


    public DateTime Create_At { get; set; } = DateTime.Now;
    public DateTime Update_At { get; set; } = DateTime.Now;
}   
