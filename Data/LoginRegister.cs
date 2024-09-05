using Microsoft.Build.Framework;

namespace MyMvcAuthApp.Data;

public class LoginRegister
{
    [Required]
    public string ?Username { get; set; }

    [Required]
    public string ?Password { get; set; }
    public string ?Email { get; set; }
    public string ?PhoneNumber { get; set; }
    public string ?Role { get; set; }
}