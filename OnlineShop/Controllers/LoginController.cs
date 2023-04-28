using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.Models.Identity;
using OnlineShop.ViewModels;

namespace OnlineShop.Controllers;

public class LoginController : Controller
{
    private readonly SignInManager<CustomUser> _signInManager;
    public LoginController(SignInManager<CustomUser> signInManager) 
    {
        _signInManager = signInManager;
    }
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Index(LoginViewModel loginViewModel)
    {
        if(ModelState.IsValid) 
        {

            var result = await _signInManager.PasswordSignInAsync(loginViewModel.Email,loginViewModel.Password, false, false);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }
                //Console.WriteLine(errors);
            ModelState.AddModelError("", "The Email address or password that you've entered doesn't match any account.");


        }
        return View(loginViewModel);
    }
}
