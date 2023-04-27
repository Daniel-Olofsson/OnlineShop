using Microsoft.AspNetCore.Identity;

namespace OnlineShop.Models.Identity;

public class CustomUser : IdentityUser
{
    public CustomUser() { FirstName = null!; LastName = null!; }
    [ProtectedPersonalData]
    public string FirstName { get; set; }
    [ProtectedPersonalData]
    public string LastName { get; set; }
}
