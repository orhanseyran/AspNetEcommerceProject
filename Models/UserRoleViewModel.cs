using Microsoft.AspNetCore.Identity;

namespace MyMvcAuthApp.Models;
public class UserRoleViewModel
{
    public IdentityUser ? User { get; set; }
    public IList<string> ? Roles { get; set; }
}