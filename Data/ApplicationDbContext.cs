using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyMvcAuthApp.Models;

namespace MyMvcAuthApp.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Slider> Sliders { get; set; }
    public DbSet<Cart> Carts { get; set; }

    public DbSet<Brand> Brands {get; set;}
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
}
