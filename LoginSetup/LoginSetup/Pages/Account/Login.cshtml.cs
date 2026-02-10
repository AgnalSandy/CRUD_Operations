using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LoginSetup.ViewModels;

namespace LoginSetup.Pages.Account
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public LoginViewModel Input { get; set; } // This must exist!

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            // Login logic here
            return Page();
        }
    }
}
