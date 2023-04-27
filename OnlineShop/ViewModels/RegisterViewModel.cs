using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OnlineShop.ViewModels;

public class RegisterViewModel
{
    public RegisterViewModel() 
    {
        FirstName = null!;
        LastName = null!;
        Email = null!;
        Password = null!;
        ConfirmPassword = null!;


    }
    [Display(Name = "First Name")]
    [Required(ErrorMessage = "First Name is required")]
    public string FirstName { get; set; }
    [Display(Name = "Last Name")]
    [Required(ErrorMessage = "Last Name is required")]
    public string LastName { get; set; }
    [Display(Name = "Email")]
    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Invalid email format")]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; }
    [Display(Name = "Phone Number")]
    [Phone(ErrorMessage = "Invalid phone number format")]
    public string? PhoneNumber { get; set; }
    [Display(Name = "Password")]
    [Required(ErrorMessage = "Password is required")]
    [MinLength(8, ErrorMessage = "Password must be at least 8 characters long")]
    [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$", ErrorMessage = "Password must contain at least one letter and one number")]
    public string Password { get; set; }
    [Display(Name = "Confirm Password")]
    [Required(ErrorMessage = "Password is required")]
    [Compare(nameof(Password), ErrorMessage = "Password must match")]
    public string ConfirmPassword { get; set; }
    [Display(Name = "Street Name")]
    public string? StreetName { get; set; }
    [Display(Name = "City")]
    public string? City { get; set; }
    [Display(Name = "Postal code")]
    [Required(ErrorMessage = "Postal code is required")]
    [RegularExpression(@"^\d{6,8}$", ErrorMessage = "Postal code must be 6-8 digits")]
    public string? PostalCode { get; set; }
}
