using Microsoft.AspNetCore.Identity;

namespace MyMvcAuthApp.Models

{
         public class User : IdentityUser
         {
             public string ? Jwt { get; set; }
         }
}