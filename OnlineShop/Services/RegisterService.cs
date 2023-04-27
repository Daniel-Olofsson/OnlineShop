using OnlineShop.Contexts;
using OnlineShop.Models.Identity;
using OnlineShop.Repository;
using OnlineShop.ViewModels;

namespace OnlineShop.Services;

public class RegisterService : IRegisterRepository
{
    private readonly IdentityContext _context;

    public RegisterService(IdentityContext context)
    {
        _context = context;
    }

    public bool CheckIfEmailExists(string email)
    {
        return _context.Users.Any(x => x.Email == email);
    }

    public void AddUser(RegisterViewModel registerViewModel)
    {
        var user = new CustomUser()
        {
            Email = registerViewModel.Email,
            UserName = registerViewModel.Email
        };
        var result = _context.Users.Add(user);
        _context.SaveChanges();
    }
    public CustomUser GetByEmail(string email)
    {
        return _context.Users.FirstOrDefault(u => u.Email == email);
    }
}
