using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.Models.Identity;
using OnlineShop.ViewModels;

namespace OnlineShop.Controllers;

public class RegisterController : Controller
{
    //
    private readonly UserManager<CustomUser> _userManager;


    public RegisterController(UserManager<CustomUser> userManager)
    {
         _userManager = userManager;
    }

    //
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }


    [HttpPost]
    public async Task<IActionResult> Index(RegisterViewModel registerViewModel) 
    {
        
        if (ModelState.IsValid) 
        {

            var result = await _userManager.CreateAsync(registerViewModel, registerViewModel.Password);

            if (result.Succeeded)
            {
                Console.WriteLine("lol");
                return RedirectToAction("Success", "Register");
            }
            else
            {
                foreach(var error in result.Errors)
                {
                    //Console.WriteLine(errors);
                    ModelState.AddModelError("", error.Description);
                }
                    
            }

        }
        return View(registerViewModel);
    }






    public IActionResult Success()
    {
        return View();
    }
    public IActionResult Error() { return View(); }
}
