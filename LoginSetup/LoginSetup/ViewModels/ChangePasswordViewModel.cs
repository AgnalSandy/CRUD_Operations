using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LoginSetup.ViewModels
{
    public class ChangePasswordViewModel
    {
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(30, MinimumLength = 6, ErrorMessage = "The {0} must be at {2} and at max {1} characters long ")]
        [DataType(DataType.Password)]
        
        [Compare("ConfirmPassword", ErrorMessage = "The password and confirmation password do not match.")]
        [Display(Name = "New Password")]

        public string NewPassword { get; set; }

        [Required(ErrorMessage = "Confirm Password is required")]
        [DataType(DataType.Password)]
        [Display(Name = " Confirm new Password")]
        public string ConfirmNewPassword { get; set; }

    }
}
