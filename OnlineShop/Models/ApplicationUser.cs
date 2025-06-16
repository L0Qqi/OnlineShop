using Microsoft.AspNetCore.Identity;


public class ApplicationUser : IdentityUser
{
    public string? DisplayName { get; set; }
    public string Role { get; set; } = "user";
}