using System.ComponentModel.DataAnnotations;

namespace OnlineShop.ViewModels;

public class LoginViewModel
{
    public LoginViewModel()
    {
        //FirstName = null!; 
        //LastName= null!;
        Email = null!;
        Password = null!;

    }
    //[Display(Name = "First Name")]
    //[Required(ErrorMessage = "First Name is required")]
    //public string FirstName { get; set; }

    //[Display(Name = "Last Name")]
    //[Required(ErrorMessage = "Last Name is required")]
    //public string LastName { get; set; }
    [Display(Name = "Email")]
    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Invalid email format")]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; }
    [Display(Name = "Password")]
    [Required(ErrorMessage = "Password is required")]
    [MinLength(8, ErrorMessage = "Password must be at least 8 characters long")]
    [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$", ErrorMessage = "Password must contain at least one letter and one number")]
    [DataType(DataType.Password)]
    public string Password { get; set; } 
}
