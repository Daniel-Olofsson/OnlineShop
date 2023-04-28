using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Models.Identity;
using OnlineShop.ViewModels;

namespace OnlineShop.Contexts;

public class IdentityContext : IdentityDbContext<CustomUser>
{
    public IdentityContext(DbContextOptions<IdentityContext> options) : base(options)
    { 
    }
    
}
