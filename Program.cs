using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MyMvcAuthApp.Data;
using MyMvcAuthApp.Repository;
using HGO.ASPNetCore.FileManager;
using MyMvcAuthApp.Models;

var builder = WebApplication.CreateBuilder(args);

// HGO File Manager'ı ekleyin
builder.Services.AddHgoFileManager();

// Veritabanı bağlantısı
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") 
    ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(connectionString));

// Identity ve roller için konfigürasyon
builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options =>
{
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(15);
    options.Lockout.MaxFailedAccessAttempts = 5;
    options.Lockout.AllowedForNewUsers = true;
    options.SignIn.RequireConfirmedAccount = true;
})
.AddEntityFrameworkStores<ApplicationDbContext>()
.AddDefaultTokenProviders();

// CORS politikası - tüm kaynaklara izin ver
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        policy =>
        {
            policy.AllowAnyOrigin()   // Tüm kaynaklara izin ver
                  .AllowAnyHeader()   // Tüm başlıklara izin ver
                  .AllowAnyMethod();  // Tüm HTTP yöntemlerine izin ver
        });
});

// Repository bağımlılıklarını ekleyin
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IUploadImageRepository, UploadImageRepository>();

// Veritabanı hata ayıklama için developer page filter ekleyin
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Giriş ve erişim engellendi sayfalarını yapılandırın
builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Auth/Login";
    options.AccessDeniedPath = "/";
});

// MVC ve Razor sayfaları ekleyin
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

// CORS politikasını uygulayın
app.UseCors("AllowAllOrigins");

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

// Authentication ve Authorization sıralaması
app.UseAuthentication();
app.UseAuthorization();

app.UseHgoFileManager();

// Route yapılandırması
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
