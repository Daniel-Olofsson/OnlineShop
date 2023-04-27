using Microsoft.AspNetCore.Mvc;
using OnlineShop.Repository;
using OnlineShop.ViewModels;

namespace OnlineShop.Controllers;

public class RegisterController : Controller
{
    //
    private readonly IRegisterRepository _repository;

    public RegisterController(IRegisterRepository repository)
    {
        _repository = repository;
    }

    //
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }


    [HttpPost]
    public IActionResult Index(RegisterViewModel registerViewModel) 
    {
        if(ModelState.IsValid) 
        {
            //user vailid
            string email = registerViewModel.Email;
            if (_repository.GetByEmail(email)!= null) 
            {
                ModelState.AddModelError("", "Error, Email already in exist.");
                return View(registerViewModel);
            }
            else
            {
                _repository.AddUser(registerViewModel);
                return RedirectToAction("Success");
            }
            

        }
        return View(registerViewModel);
    }
    public IActionResult Success()
    {
        return View();
    }
}
