using OnlineShop.ViewModels;

namespace OnlineShop.Repository;

public interface IRegisterRepository
{
    bool CheckIfEmailExists(string email);
    void AddUser(RegisterViewModel registerViewModel);
    RegisterViewModel GetByEmail(string email);
}
