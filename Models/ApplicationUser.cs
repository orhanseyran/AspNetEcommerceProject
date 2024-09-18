using Microsoft.AspNetCore.Identity;

public class ApplicationUser : IdentityUser
{
    // Ek kullanıcı alanları
    public string Jwt { get; set; }
    
}